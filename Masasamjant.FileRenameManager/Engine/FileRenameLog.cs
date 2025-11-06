using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Timers;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameLog : IDisposable
    {
        private Queue<string> lineQueue;
        private object lineQueueMutex;
        private Timer writeTimer;
        private int writeErrorCount;
        private string user;

        public FileRenameLog()
        {
            Properties.Settings settings = Properties.Settings.Default;

            LogDirectoryPath = settings.LogLocation;
            IsEnabled = CheckEnabledState();
            IsWriting = false;

            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (identity != null)
                user = identity.Name;

            if (IsEnabled)
            {
                lineQueue = new Queue<string>();
                lineQueueMutex = new object();
                writeTimer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
                writeTimer.Elapsed += OnWriteTimerElapsed;
                writeTimer.Start();
                writeErrorCount = 0;
            }
        }

        public string LogDirectoryPath { get; }

        public bool IsEnabled { get; private set; }

        private bool IsWriting { get; set; }

        public void Write(string message)
        {
            if (!IsEnabled)
                return;

            if (string.IsNullOrWhiteSpace(message))
                return;

            string messageLine;

            if (user == null)
                messageLine = $"{DateTime.Now.ToString("G")} -- {message}";
            else
                messageLine = $"{DateTime.Now.ToString("G")} -- {user} -- {message}";

            lock (lineQueueMutex)
            {
                lineQueue.Enqueue(messageLine);
            }
        }

        public void Dispose()
        {
            if (!IsEnabled)
                return;

            IsEnabled = false;

            writeTimer.Stop();
            writeTimer.Elapsed -= OnWriteTimerElapsed;
            writeTimer.Dispose();

            bool writeContent;

            lock (lineQueueMutex)
            {
                writeContent = lineQueue.Count < 0;
            }

            if (writeContent)
                WriteLogContent();

            lock (lineQueueMutex)
            {
                lineQueue.Clear();
            }
        }

        private static string GetDailyLogFileName()
        {
            DateTime today = DateTime.Today;

            return $"Log_{today.Year.ToString().PadLeft(4, '0')}{today.Month.ToString().PadLeft(2, '0')}{today.Day.ToString().PadLeft(2, '0')}.log";
        }

        private void OnWriteTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (!IsEnabled)
                return;

            WriteLogContent();
        }

        private void WriteLogContent()
        {
            Queue<string> writeQueue = null;
            Queue<string> readQueue = null;

            try
            {
                lock (lineQueueMutex)
                {
                    if (IsWriting)
                        return;

                    if (lineQueue.Count == 0)
                        return;

                    IsWriting = true;
                    readQueue = lineQueue;
                    lineQueue = new Queue<string>();
                }

                writeQueue = new Queue<string>();

                string dailyLogFileName = GetDailyLogFileName();
                string dailyLogFilePath = Path.Combine(LogDirectoryPath, dailyLogFileName);

                FileMode mode = File.Exists(dailyLogFilePath) ? FileMode.Append : FileMode.CreateNew;

                using (FileStream stream = new FileStream(dailyLogFilePath, mode, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    if (mode == FileMode.CreateNew)
                        writer.WriteLine($"-- Log created {DateTime.Now.ToString("G")} --");

                    while (readQueue.Count > 0)
                    {
                        string line = readQueue.Dequeue();
                        writer.WriteLine(line);
                        writeQueue.Enqueue(line);
                    }

                    writer.Flush();
                }
            }
            catch (Exception exception)
            {
                HandleWriteContentException(exception, readQueue, writeQueue);
            }
            finally
            {
                if (writeQueue != null && writeQueue.Count > 0)
                    writeQueue.Clear();

                lock (lineQueueMutex)
                {
                    if (IsWriting)
                    {
                        IsWriting = false;
                    }
                }
            }
        }

        private void HandleWriteContentException(Exception exception, Queue<string> readQueue, Queue<string> writeQueue)
        {
            lock (lineQueueMutex)
            {
                // If log write error count is 10 or greater, then disable log.
                if (writeErrorCount >= 10)
                {
                    IsEnabled = false;
                    writeTimer.Stop();
                    writeTimer.Elapsed -= OnWriteTimerElapsed;
                    writeTimer.Dispose();
                    lineQueue.Clear();
                    return;
                }

                // Otherwise we create line queue again. 

                string messageLine = $"{DateTime.Now.ToString("G")} -- Log write exception: {exception.Message}";

                // Nothing to re-create, just log exception.
                if ((readQueue == null || readQueue.Count == 0) && (writeQueue == null || writeQueue.Count == 0))
                {
                    lineQueue.Enqueue(messageLine);
                    return;
                }

                // Empty current line queue to temp queue.
                Queue<string> tempQueue = new Queue<string>();
                while (lineQueue.Count > 0)
                    tempQueue.Enqueue(lineQueue.Dequeue());

                // Then create new line queue instance.
                lineQueue = new Queue<string>();

                // Enqueue all in write queue to line queue.
                if (writeQueue != null && writeQueue.Count > 0)
                    while (writeQueue.Count > 0)
                        lineQueue.Enqueue(writeQueue.Dequeue());

                // Enqueue all in read queue to line queue.
                if (readQueue != null && readQueue.Count > 0)
                    while (readQueue.Count > 0)
                        lineQueue.Enqueue(readQueue.Dequeue());

                // Enqueue exception message about log write to line queue.
                lineQueue.Enqueue(messageLine);

                // Enqueue all in temp queue to line queue.
                if (tempQueue.Count > 0)
                    while (tempQueue.Count > 0)
                        lineQueue.Enqueue(tempQueue.Dequeue());

                // Increment write error count.
                writeErrorCount += 1;
            }
        }

        private bool CheckEnabledState()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(LogDirectoryPath))
                    return false;

                if (!Directory.Exists(LogDirectoryPath))
                    return false;

                string testFileName = Guid.NewGuid().ToString("N") + ".tmp";
                string testFilePath = Path.Combine(LogDirectoryPath, testFileName);

                using (StreamWriter writer = File.CreateText(testFilePath))
                {
                    writer.WriteLine(testFileName);
                    writer.Flush();
                }

                File.Delete(testFilePath);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
