using System;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameInsertParameters : FileRenameParameters
    {
        private FileRenameInsert insert;
        private string separator;
        private string customValue;
        private DateTime dateTime;
        private string dateTimeFormat;
        private FileRenameInsertTimeAccuracy timeAccuracy;
        private int incrementInitial;
        private int increment;
        private int currentIncrement;
        private FileRenameInsertLocation location;
        private int locationIndex;

        public FileRenameInsert Insert
        {
            get { return insert; }
            set
            {
                if (insert != value)
                {
                    insert = value;
                    SetHasParameterChanges();
                }
            }
        }

        public string Separator
        {
            get { return separator; }
            set
            {
                if (separator != value)
                {
                    separator = value;
                    SetHasParameterChanges();
                }
            }
        }

        public string CustomValue
        {
            get { return customValue; }
            set
            {
                if (customValue != value)
                {
                    customValue = value;
                    SetHasParameterChanges();
                }
            }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;
                    SetHasParameterChanges();
                }
            }
        }

        public string DateTimeFormat
        {
            get { return dateTimeFormat; }
            set
            {
                if (dateTimeFormat != value)
                {
                    dateTimeFormat = value;
                    SetHasParameterChanges();
                }
            }
        }

        public FileRenameInsertTimeAccuracy TimeAccuracy
        {
            get { return timeAccuracy; }
            set
            {
                if (timeAccuracy != value)
                {
                    timeAccuracy = value;
                    SetHasParameterChanges();
                }
            }
        }

        public int IncrementInitial
        {
            get { return incrementInitial; }
            set
            {
                int tmp = value < 0 ? 0 : value;

                if (incrementInitial != tmp)
                {
                    incrementInitial = tmp;
                    currentIncrement = tmp;
                    SetHasParameterChanges();
                }
            }
        }

        public int Increment
        {
            get { return increment; }
            set
            {
                int tmp = value < 0 ? 0 : value;

                if (increment != tmp)
                {
                    increment = tmp;
                    currentIncrement = IncrementInitial;
                    SetHasParameterChanges();
                }
            }
        }

        public int CurrentIncrement
        {
            get { return currentIncrement; }
            set { currentIncrement = value; }
        }

        public FileRenameInsertLocation Location
        {
            get { return location; }
            set
            {
                if (location != value)
                {
                    location = value;
                    SetHasParameterChanges();
                }
            }
        }

        public int LocationIndex
        {
            get { return locationIndex; }
            set
            {
                if (locationIndex != value)
                {
                    locationIndex = value;
                    SetHasParameterChanges();
                }
            }
        }

        public void ResetIncrement()
        {
            CurrentIncrement = IncrementInitial;
        }
    }
}
