namespace Masasamjant.FileRenameManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupFiles = new System.Windows.Forms.GroupBox();
            this.fileListView = new System.Windows.Forms.ListView();
            this.sourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileListViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupRules = new System.Windows.Forms.GroupBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.operationTabs = new System.Windows.Forms.TabControl();
            this.insertTab = new System.Windows.Forms.TabPage();
            this.groupInsertSeparator = new System.Windows.Forms.GroupBox();
            this.textInsertSeparator = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericIndex = new System.Windows.Forms.NumericUpDown();
            this.comboPosition = new System.Windows.Forms.ComboBox();
            this.panelInsertControls = new System.Windows.Forms.Panel();
            this.valueGroupBox = new System.Windows.Forms.GroupBox();
            this.radioIncrement = new System.Windows.Forms.RadioButton();
            this.radioDateTime = new System.Windows.Forms.RadioButton();
            this.radioDate = new System.Windows.Forms.RadioButton();
            this.radioCustomValue = new System.Windows.Forms.RadioButton();
            this.replaceTab = new System.Windows.Forms.TabPage();
            this.textReplacement = new System.Windows.Forms.TextBox();
            this.textReplace = new System.Windows.Forms.TextBox();
            this.labelReplacement = new System.Windows.Forms.Label();
            this.comboReplaceKind = new System.Windows.Forms.ComboBox();
            this.labelReplace = new System.Windows.Forms.Label();
            this.removeTab = new System.Windows.Forms.TabPage();
            this.textRemove = new System.Windows.Forms.TextBox();
            this.comboRemoveKind = new System.Windows.Forms.ComboBox();
            this.labelRemove = new System.Windows.Forms.Label();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripToolTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.renameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileButtonsPanel = new System.Windows.Forms.Panel();
            this.checkSimulate = new System.Windows.Forms.CheckBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPerform = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonPerform2 = new System.Windows.Forms.Button();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.groupFiles.SuspendLayout();
            this.fileListViewContextMenu.SuspendLayout();
            this.groupRules.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.operationTabs.SuspendLayout();
            this.insertTab.SuspendLayout();
            this.groupInsertSeparator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).BeginInit();
            this.valueGroupBox.SuspendLayout();
            this.replaceTab.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.fileButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.mainMenu.Name = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // operationToolStripMenuItem1
            // 
            resources.ApplyResources(this.operationToolStripMenuItem1, "operationToolStripMenuItem1");
            this.operationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.operationToolStripMenuItem1.Name = "operationToolStripMenuItem1";
            // 
            // insertToolStripMenuItem
            // 
            resources.ApplyResources(this.insertToolStripMenuItem, "insertToolStripMenuItem");
            this.insertToolStripMenuItem.Checked = true;
            this.insertToolStripMenuItem.CheckOnClick = true;
            this.insertToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customValueToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.dateAndTimeToolStripMenuItem,
            this.incrementToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnInsertToolStripMenuItemCheckedChanged);
            // 
            // customValueToolStripMenuItem
            // 
            resources.ApplyResources(this.customValueToolStripMenuItem, "customValueToolStripMenuItem");
            this.customValueToolStripMenuItem.Checked = true;
            this.customValueToolStripMenuItem.CheckOnClick = true;
            this.customValueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customValueToolStripMenuItem.Name = "customValueToolStripMenuItem";
            this.customValueToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnCustomValueToolStripMenuItemCheckedChanged);
            // 
            // dateToolStripMenuItem
            // 
            resources.ApplyResources(this.dateToolStripMenuItem, "dateToolStripMenuItem");
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnDateToolStripMenuItemCheckedChanged);
            // 
            // dateAndTimeToolStripMenuItem
            // 
            resources.ApplyResources(this.dateAndTimeToolStripMenuItem, "dateAndTimeToolStripMenuItem");
            this.dateAndTimeToolStripMenuItem.CheckOnClick = true;
            this.dateAndTimeToolStripMenuItem.Name = "dateAndTimeToolStripMenuItem";
            this.dateAndTimeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnDateAndTimeToolStripMenuItemCheckedChanged);
            // 
            // incrementToolStripMenuItem
            // 
            resources.ApplyResources(this.incrementToolStripMenuItem, "incrementToolStripMenuItem");
            this.incrementToolStripMenuItem.CheckOnClick = true;
            this.incrementToolStripMenuItem.Name = "incrementToolStripMenuItem";
            this.incrementToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnIncrementToolStripMenuItemCheckedChanged);
            // 
            // replaceToolStripMenuItem
            // 
            resources.ApplyResources(this.replaceToolStripMenuItem, "replaceToolStripMenuItem");
            this.replaceToolStripMenuItem.CheckOnClick = true;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnReplaceToolStripMenuItemCheckedChanged);
            // 
            // removeToolStripMenuItem
            // 
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.CheckOnClick = true;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnRemoveToolStripMenuItemCheckedChanged);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            // 
            // addToolStripMenuItem
            // 
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addFolderToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            // 
            // addFileToolStripMenuItem
            // 
            resources.ApplyResources(this.addFileToolStripMenuItem, "addFileToolStripMenuItem");
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.OnSelectFile);
            // 
            // addFolderToolStripMenuItem
            // 
            resources.ApplyResources(this.addFolderToolStripMenuItem, "addFolderToolStripMenuItem");
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.OnSelectFolder);
            // 
            // removeSelectedToolStripMenuItem
            // 
            resources.ApplyResources(this.removeSelectedToolStripMenuItem, "removeSelectedToolStripMenuItem");
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveSelectedToolStripMenuItemClick);
            // 
            // clearToolStripMenuItem
            // 
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.OnButtonClearAllClick);
            // 
            // actionToolStripMenuItem
            // 
            resources.ApplyResources(this.actionToolStripMenuItem, "actionToolStripMenuItem");
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.toolStripSeparator3,
            this.undoToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            // 
            // performToolStripMenuItem
            // 
            resources.ApplyResources(this.performToolStripMenuItem, "performToolStripMenuItem");
            this.performToolStripMenuItem.Name = "performToolStripMenuItem";
            this.performToolStripMenuItem.Click += new System.EventHandler(this.OnButtonPerformClick);
            // 
            // cancelToolStripMenuItem
            // 
            resources.ApplyResources(this.cancelToolStripMenuItem, "cancelToolStripMenuItem");
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // undoToolStripMenuItem
            // 
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            // 
            // sortToolStripMenuItem
            // 
            resources.ApplyResources(this.sortToolStripMenuItem, "sortToolStripMenuItem");
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byPathToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            // 
            // byNameToolStripMenuItem
            // 
            resources.ApplyResources(this.byNameToolStripMenuItem, "byNameToolStripMenuItem");
            this.byNameToolStripMenuItem.Checked = true;
            this.byNameToolStripMenuItem.CheckOnClick = true;
            this.byNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnByNameToolStripMenuItemCheckedChanged);
            // 
            // byPathToolStripMenuItem
            // 
            resources.ApplyResources(this.byPathToolStripMenuItem, "byPathToolStripMenuItem");
            this.byPathToolStripMenuItem.CheckOnClick = true;
            this.byPathToolStripMenuItem.Name = "byPathToolStripMenuItem";
            this.byPathToolStripMenuItem.CheckedChanged += new System.EventHandler(this.OnByPathToolStripMenuItemCheckedChanged);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OnShowOptions);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.OnHelpToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // groupFiles
            // 
            resources.ApplyResources(this.groupFiles, "groupFiles");
            this.groupFiles.Controls.Add(this.fileListView);
            this.groupFiles.Name = "groupFiles";
            this.groupFiles.TabStop = false;
            // 
            // fileListView
            // 
            resources.ApplyResources(this.fileListView, "fileListView");
            this.fileListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sourceColumn,
            this.destinationColumn});
            this.fileListView.ContextMenuStrip = this.fileListViewContextMenu;
            this.fileListView.FullRowSelect = true;
            this.fileListView.HideSelection = false;
            this.fileListView.LargeImageList = this.listViewImageList;
            this.fileListView.Name = "fileListView";
            this.fileListView.OwnerDraw = true;
            this.fileListView.ShowItemToolTips = true;
            this.fileListView.SmallImageList = this.listViewImageList;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnFileListViewColumnClick);
            this.fileListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.OnFileListViewDrawColumnHeader);
            this.fileListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.OnFileListViewDrawItem);
            this.fileListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.OnFileListViewDrawSubItem);
            this.fileListView.Resize += new System.EventHandler(this.OnFileListViewResize);
            // 
            // sourceColumn
            // 
            resources.ApplyResources(this.sourceColumn, "sourceColumn");
            // 
            // destinationColumn
            // 
            resources.ApplyResources(this.destinationColumn, "destinationColumn");
            // 
            // fileListViewContextMenu
            // 
            resources.ApplyResources(this.fileListViewContextMenu, "fileListViewContextMenu");
            this.fileListViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileContextMenuItem,
            this.addFolderContextMenuItem,
            this.toolStripSeparator1,
            this.removeSelectedContextMenuItem});
            this.fileListViewContextMenu.Name = "fileListViewContextMenu";
            // 
            // addFileContextMenuItem
            // 
            resources.ApplyResources(this.addFileContextMenuItem, "addFileContextMenuItem");
            this.addFileContextMenuItem.Name = "addFileContextMenuItem";
            this.addFileContextMenuItem.Click += new System.EventHandler(this.OnSelectFile);
            // 
            // addFolderContextMenuItem
            // 
            resources.ApplyResources(this.addFolderContextMenuItem, "addFolderContextMenuItem");
            this.addFolderContextMenuItem.Name = "addFolderContextMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // removeSelectedContextMenuItem
            // 
            resources.ApplyResources(this.removeSelectedContextMenuItem, "removeSelectedContextMenuItem");
            this.removeSelectedContextMenuItem.Name = "removeSelectedContextMenuItem";
            this.removeSelectedContextMenuItem.Click += new System.EventHandler(this.OnRemoveSelectedToolStripMenuItemClick);
            // 
            // listViewImageList
            // 
            this.listViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listViewImageList.ImageStream")));
            this.listViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.listViewImageList.Images.SetKeyName(0, "Accept.png");
            this.listViewImageList.Images.SetKeyName(1, "Error.png");
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "Error.png");
            this.iconImageList.Images.SetKeyName(1, "File.png");
            this.iconImageList.Images.SetKeyName(2, "Folder.png");
            this.iconImageList.Images.SetKeyName(3, "Options.png");
            this.iconImageList.Images.SetKeyName(4, "Perform.png");
            this.iconImageList.Images.SetKeyName(5, "Redo.png");
            this.iconImageList.Images.SetKeyName(6, "Refresh.png");
            this.iconImageList.Images.SetKeyName(7, "Remove.png");
            this.iconImageList.Images.SetKeyName(8, "Stop.png");
            this.iconImageList.Images.SetKeyName(9, "Undo.png");
            this.iconImageList.Images.SetKeyName(10, "Sort.png");
            // 
            // groupRules
            // 
            resources.ApplyResources(this.groupRules, "groupRules");
            this.groupRules.Controls.Add(this.panelTools);
            this.groupRules.Name = "groupRules";
            this.groupRules.TabStop = false;
            // 
            // panelTools
            // 
            resources.ApplyResources(this.panelTools, "panelTools");
            this.panelTools.Controls.Add(this.operationTabs);
            this.panelTools.Name = "panelTools";
            // 
            // operationTabs
            // 
            resources.ApplyResources(this.operationTabs, "operationTabs");
            this.operationTabs.Controls.Add(this.insertTab);
            this.operationTabs.Controls.Add(this.replaceTab);
            this.operationTabs.Controls.Add(this.removeTab);
            this.operationTabs.Name = "operationTabs";
            this.operationTabs.SelectedIndex = 0;
            this.operationTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnOperationTabsSelected);
            // 
            // insertTab
            // 
            resources.ApplyResources(this.insertTab, "insertTab");
            this.insertTab.Controls.Add(this.groupInsertSeparator);
            this.insertTab.Controls.Add(this.groupBox1);
            this.insertTab.Controls.Add(this.panelInsertControls);
            this.insertTab.Controls.Add(this.valueGroupBox);
            this.insertTab.Name = "insertTab";
            this.insertTab.Tag = "Insert";
            this.insertTab.UseVisualStyleBackColor = true;
            // 
            // groupInsertSeparator
            // 
            resources.ApplyResources(this.groupInsertSeparator, "groupInsertSeparator");
            this.groupInsertSeparator.Controls.Add(this.textInsertSeparator);
            this.groupInsertSeparator.Name = "groupInsertSeparator";
            this.groupInsertSeparator.TabStop = false;
            // 
            // textInsertSeparator
            // 
            resources.ApplyResources(this.textInsertSeparator, "textInsertSeparator");
            this.textInsertSeparator.Name = "textInsertSeparator";
            this.textInsertSeparator.TextChanged += new System.EventHandler(this.OnTextInsertSeparatorTextChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.numericIndex);
            this.groupBox1.Controls.Add(this.comboPosition);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // numericIndex
            // 
            resources.ApplyResources(this.numericIndex, "numericIndex");
            this.numericIndex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericIndex.Name = "numericIndex";
            this.numericIndex.ValueChanged += new System.EventHandler(this.OnNumericIndexValueChanged);
            // 
            // comboPosition
            // 
            resources.ApplyResources(this.comboPosition, "comboPosition");
            this.comboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPosition.FormattingEnabled = true;
            this.comboPosition.Items.AddRange(new object[] {
            resources.GetString("comboPosition.Items"),
            resources.GetString("comboPosition.Items1"),
            resources.GetString("comboPosition.Items2")});
            this.comboPosition.Name = "comboPosition";
            this.comboPosition.SelectedIndexChanged += new System.EventHandler(this.OnComboPositionSelectedIndexChanged);
            // 
            // panelInsertControls
            // 
            resources.ApplyResources(this.panelInsertControls, "panelInsertControls");
            this.panelInsertControls.Name = "panelInsertControls";
            // 
            // valueGroupBox
            // 
            resources.ApplyResources(this.valueGroupBox, "valueGroupBox");
            this.valueGroupBox.Controls.Add(this.radioIncrement);
            this.valueGroupBox.Controls.Add(this.radioDateTime);
            this.valueGroupBox.Controls.Add(this.radioDate);
            this.valueGroupBox.Controls.Add(this.radioCustomValue);
            this.valueGroupBox.Name = "valueGroupBox";
            this.valueGroupBox.TabStop = false;
            // 
            // radioIncrement
            // 
            resources.ApplyResources(this.radioIncrement, "radioIncrement");
            this.radioIncrement.Name = "radioIncrement";
            this.radioIncrement.UseVisualStyleBackColor = true;
            this.radioIncrement.CheckedChanged += new System.EventHandler(this.OnRadioIncrementCheckedChanged);
            // 
            // radioDateTime
            // 
            resources.ApplyResources(this.radioDateTime, "radioDateTime");
            this.radioDateTime.Name = "radioDateTime";
            this.radioDateTime.UseVisualStyleBackColor = true;
            this.radioDateTime.CheckedChanged += new System.EventHandler(this.OnRadioDateTimeCheckedChanged);
            // 
            // radioDate
            // 
            resources.ApplyResources(this.radioDate, "radioDate");
            this.radioDate.Name = "radioDate";
            this.radioDate.UseVisualStyleBackColor = true;
            this.radioDate.CheckedChanged += new System.EventHandler(this.OnRadioDateCheckedChanged);
            // 
            // radioCustomValue
            // 
            resources.ApplyResources(this.radioCustomValue, "radioCustomValue");
            this.radioCustomValue.Checked = true;
            this.radioCustomValue.Name = "radioCustomValue";
            this.radioCustomValue.TabStop = true;
            this.radioCustomValue.UseVisualStyleBackColor = true;
            this.radioCustomValue.CheckedChanged += new System.EventHandler(this.OnRadioCustomValueCheckedChanged);
            // 
            // replaceTab
            // 
            resources.ApplyResources(this.replaceTab, "replaceTab");
            this.replaceTab.Controls.Add(this.textReplacement);
            this.replaceTab.Controls.Add(this.textReplace);
            this.replaceTab.Controls.Add(this.labelReplacement);
            this.replaceTab.Controls.Add(this.comboReplaceKind);
            this.replaceTab.Controls.Add(this.labelReplace);
            this.replaceTab.Name = "replaceTab";
            this.replaceTab.Tag = "Replace";
            this.replaceTab.UseVisualStyleBackColor = true;
            // 
            // textReplacement
            // 
            resources.ApplyResources(this.textReplacement, "textReplacement");
            this.textReplacement.Name = "textReplacement";
            this.textReplacement.TextChanged += new System.EventHandler(this.OnTextReplacementTextChanged);
            // 
            // textReplace
            // 
            resources.ApplyResources(this.textReplace, "textReplace");
            this.textReplace.Name = "textReplace";
            this.textReplace.TextChanged += new System.EventHandler(this.OnTextReplaceTextChanged);
            // 
            // labelReplacement
            // 
            resources.ApplyResources(this.labelReplacement, "labelReplacement");
            this.labelReplacement.Name = "labelReplacement";
            // 
            // comboReplaceKind
            // 
            resources.ApplyResources(this.comboReplaceKind, "comboReplaceKind");
            this.comboReplaceKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReplaceKind.FormattingEnabled = true;
            this.comboReplaceKind.Items.AddRange(new object[] {
            resources.GetString("comboReplaceKind.Items"),
            resources.GetString("comboReplaceKind.Items1"),
            resources.GetString("comboReplaceKind.Items2"),
            resources.GetString("comboReplaceKind.Items3"),
            resources.GetString("comboReplaceKind.Items4")});
            this.comboReplaceKind.Name = "comboReplaceKind";
            this.comboReplaceKind.SelectedIndexChanged += new System.EventHandler(this.OnComboReplaceKindSelectedIndexChanged);
            // 
            // labelReplace
            // 
            resources.ApplyResources(this.labelReplace, "labelReplace");
            this.labelReplace.Name = "labelReplace";
            // 
            // removeTab
            // 
            resources.ApplyResources(this.removeTab, "removeTab");
            this.removeTab.Controls.Add(this.textRemove);
            this.removeTab.Controls.Add(this.comboRemoveKind);
            this.removeTab.Controls.Add(this.labelRemove);
            this.removeTab.Name = "removeTab";
            this.removeTab.Tag = "Remove";
            this.removeTab.UseVisualStyleBackColor = true;
            // 
            // textRemove
            // 
            resources.ApplyResources(this.textRemove, "textRemove");
            this.textRemove.Name = "textRemove";
            this.textRemove.TextChanged += new System.EventHandler(this.OnTextRemoveTextChanged);
            // 
            // comboRemoveKind
            // 
            resources.ApplyResources(this.comboRemoveKind, "comboRemoveKind");
            this.comboRemoveKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRemoveKind.FormattingEnabled = true;
            this.comboRemoveKind.Items.AddRange(new object[] {
            resources.GetString("comboRemoveKind.Items"),
            resources.GetString("comboRemoveKind.Items1"),
            resources.GetString("comboRemoveKind.Items2"),
            resources.GetString("comboRemoveKind.Items3"),
            resources.GetString("comboRemoveKind.Items4")});
            this.comboRemoveKind.Name = "comboRemoveKind";
            this.comboRemoveKind.SelectedIndexChanged += new System.EventHandler(this.OnComboRemoveKindSelectedIndexChanged);
            // 
            // labelRemove
            // 
            resources.ApplyResources(this.labelRemove, "labelRemove");
            this.labelRemove.Name = "labelRemove";
            // 
            // mainStatus
            // 
            resources.ApplyResources(this.mainStatus, "mainStatus");
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripToolTip,
            this.renameStatusLabel});
            this.mainStatus.Name = "mainStatus";
            // 
            // toolStripToolTip
            // 
            resources.ApplyResources(this.toolStripToolTip, "toolStripToolTip");
            this.toolStripToolTip.Name = "toolStripToolTip";
            // 
            // renameStatusLabel
            // 
            resources.ApplyResources(this.renameStatusLabel, "renameStatusLabel");
            this.renameStatusLabel.Name = "renameStatusLabel";
            // 
            // fileButtonsPanel
            // 
            resources.ApplyResources(this.fileButtonsPanel, "fileButtonsPanel");
            this.fileButtonsPanel.Controls.Add(this.checkSimulate);
            this.fileButtonsPanel.Controls.Add(this.buttonSort);
            this.fileButtonsPanel.Controls.Add(this.buttonClearAll);
            this.fileButtonsPanel.Controls.Add(this.buttonOptions);
            this.fileButtonsPanel.Controls.Add(this.buttonUndo);
            this.fileButtonsPanel.Controls.Add(this.buttonRefresh);
            this.fileButtonsPanel.Controls.Add(this.buttonStop);
            this.fileButtonsPanel.Controls.Add(this.buttonPerform);
            this.fileButtonsPanel.Controls.Add(this.buttonAddFile);
            this.fileButtonsPanel.Controls.Add(this.buttonAddFolder);
            this.fileButtonsPanel.Name = "fileButtonsPanel";
            // 
            // checkSimulate
            // 
            resources.ApplyResources(this.checkSimulate, "checkSimulate");
            this.checkSimulate.Name = "checkSimulate";
            this.checkSimulate.UseVisualStyleBackColor = true;
            this.checkSimulate.CheckedChanged += new System.EventHandler(this.OnCheckSimulateCheckedChanged);
            // 
            // buttonSort
            // 
            resources.ApplyResources(this.buttonSort, "buttonSort");
            this.buttonSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSort.ImageList = this.iconImageList;
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Tag = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.OnButtonSortClick);
            this.buttonSort.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonSort.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonClearAll
            // 
            resources.ApplyResources(this.buttonClearAll, "buttonClearAll");
            this.buttonClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearAll.ImageList = this.iconImageList;
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Tag = "ClearAll";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.OnButtonClearAllClick);
            this.buttonClearAll.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonClearAll.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonOptions
            // 
            resources.ApplyResources(this.buttonOptions, "buttonOptions");
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOptions.ImageList = this.iconImageList;
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Tag = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.OnShowOptions);
            this.buttonOptions.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonOptions.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonUndo
            // 
            resources.ApplyResources(this.buttonUndo, "buttonUndo");
            this.buttonUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonUndo.ImageList = this.iconImageList;
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Tag = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.OnButtonUndoClick);
            this.buttonUndo.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonUndo.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefresh.ImageList = this.iconImageList;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Tag = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.OnButtonRefreshClick);
            this.buttonRefresh.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonRefresh.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStop.ImageList = this.iconImageList;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Tag = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.OnButtonStopClick);
            this.buttonStop.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonStop.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonPerform
            // 
            resources.ApplyResources(this.buttonPerform, "buttonPerform");
            this.buttonPerform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPerform.ImageList = this.iconImageList;
            this.buttonPerform.Name = "buttonPerform";
            this.buttonPerform.Tag = "Perform";
            this.buttonPerform.UseVisualStyleBackColor = true;
            this.buttonPerform.Click += new System.EventHandler(this.OnButtonPerformClick);
            this.buttonPerform.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonPerform.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonAddFile
            // 
            resources.ApplyResources(this.buttonAddFile, "buttonAddFile");
            this.buttonAddFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddFile.ImageList = this.iconImageList;
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Tag = "AddFile";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.OnSelectFile);
            this.buttonAddFile.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonAddFile.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // buttonAddFolder
            // 
            resources.ApplyResources(this.buttonAddFolder, "buttonAddFolder");
            this.buttonAddFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddFolder.ImageList = this.iconImageList;
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Tag = "AddFolder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.OnSelectFolder);
            this.buttonAddFolder.MouseEnter += new System.EventHandler(this.OnToolButtonMouseEnter);
            this.buttonAddFolder.MouseLeave += new System.EventHandler(this.OnToolButtonMouseLeave);
            // 
            // selectFileDialog
            // 
            resources.ApplyResources(this.selectFileDialog, "selectFileDialog");
            this.selectFileDialog.Multiselect = true;
            // 
            // buttonPerform2
            // 
            resources.ApplyResources(this.buttonPerform2, "buttonPerform2");
            this.buttonPerform2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPerform2.ImageList = this.iconImageList;
            this.buttonPerform2.Name = "buttonPerform2";
            this.buttonPerform2.UseVisualStyleBackColor = true;
            this.buttonPerform2.Click += new System.EventHandler(this.OnButtonPerformClick);
            // 
            // buttonStop2
            // 
            resources.ApplyResources(this.buttonStop2, "buttonStop2");
            this.buttonStop2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStop2.ImageList = this.iconImageList;
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStop2);
            this.Controls.Add(this.buttonPerform2);
            this.Controls.Add(this.fileButtonsPanel);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.groupRules);
            this.Controls.Add(this.groupFiles);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.Resize += new System.EventHandler(this.OnMainFormResize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupFiles.ResumeLayout(false);
            this.fileListViewContextMenu.ResumeLayout(false);
            this.groupRules.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.operationTabs.ResumeLayout(false);
            this.insertTab.ResumeLayout(false);
            this.groupInsertSeparator.ResumeLayout(false);
            this.groupInsertSeparator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).EndInit();
            this.valueGroupBox.ResumeLayout(false);
            this.valueGroupBox.PerformLayout();
            this.replaceTab.ResumeLayout(false);
            this.replaceTab.PerformLayout();
            this.removeTab.ResumeLayout(false);
            this.removeTab.PerformLayout();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.fileButtonsPanel.ResumeLayout(false);
            this.fileButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateAndTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupFiles;
        private System.Windows.Forms.GroupBox groupRules;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.TabControl operationTabs;
        private System.Windows.Forms.TabPage insertTab;
        private System.Windows.Forms.TabPage replaceTab;
        private System.Windows.Forms.TabPage removeTab;
        private System.Windows.Forms.GroupBox valueGroupBox;
        private System.Windows.Forms.RadioButton radioIncrement;
        private System.Windows.Forms.RadioButton radioDateTime;
        private System.Windows.Forms.RadioButton radioDate;
        private System.Windows.Forms.RadioButton radioCustomValue;
        private System.Windows.Forms.Panel panelInsertControls;
        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.Panel fileButtonsPanel;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPerform;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.ToolStripStatusLabel toolStripToolTip;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader sourceColumn;
        private System.Windows.Forms.ColumnHeader destinationColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboPosition;
        private System.Windows.Forms.NumericUpDown numericIndex;
        private System.Windows.Forms.TextBox textReplacement;
        private System.Windows.Forms.TextBox textReplace;
        private System.Windows.Forms.Label labelReplacement;
        private System.Windows.Forms.ComboBox comboReplaceKind;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textRemove;
        private System.Windows.Forms.ComboBox comboRemoveKind;
        private System.Windows.Forms.Label labelRemove;
        private System.Windows.Forms.ContextMenuStrip fileListViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addFileContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList listViewImageList;
        private System.Windows.Forms.GroupBox groupInsertSeparator;
        private System.Windows.Forms.TextBox textInsertSeparator;
        private System.Windows.Forms.CheckBox checkSimulate;
        private System.Windows.Forms.ToolStripStatusLabel renameStatusLabel;
        private System.Windows.Forms.Button buttonPerform2;
        private System.Windows.Forms.Button buttonStop2;
    }
}

