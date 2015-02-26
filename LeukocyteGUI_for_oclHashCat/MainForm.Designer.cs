namespace LeukocyteGUI_for_oclHashCat
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
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHashType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDigests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSalts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEstimated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOutput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDictionary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFinished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripTasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopyTaskInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFullInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemHashType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHashTargetName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHashTargetPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemTimeEstimated = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTimeStarted = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTimeFinished = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOutputFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOutputFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemMaskDictionaryName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMaskDictionaryPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.labelGPUSpeed = new System.Windows.Forms.Label();
            this.labelGPUTemp = new System.Windows.Forms.Label();
            this.labelGPUUtil = new System.Windows.Forms.Label();
            this.labelFanSpeed = new System.Windows.Forms.Label();
            this.imageListCheckBox = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialogCrackTasks = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogCrackTasks = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveCrackTasksFileAs = new System.Windows.Forms.Button();
            this.buttonOpenCrackTasksFile = new System.Windows.Forms.Button();
            this.buttonSaveCrackTasksFile = new System.Windows.Forms.Button();
            this.checkBoxPauseCracking = new System.Windows.Forms.CheckBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.pictureBoxFan = new System.Windows.Forms.PictureBox();
            this.pictureBoxVideocard = new System.Windows.Forms.PictureBox();
            this.pictureBoxTemperature = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpeed = new System.Windows.Forms.PictureBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonUpTask = new System.Windows.Forms.Button();
            this.buttonOpenConverter = new System.Windows.Forms.Button();
            this.buttonDownTask = new System.Windows.Forms.Button();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonPauseTask = new System.Windows.Forms.Button();
            this.buttonChangeTask = new System.Windows.Forms.Button();
            this.buttonStartTask = new System.Windows.Forms.Button();
            this.buttonStopTask = new System.Windows.Forms.Button();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.tsslCrackTasksFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPauseCracking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResumeCracking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxAllChecked = new System.Windows.Forms.CheckBox();
            this.notifyMessage = new LeukocyteGUI_for_oclHashCat.NotifyMessage(this.components);
            this.contextMenuStripTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideocard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).BeginInit();
            this.statusStripInfo.SuspendLayout();
            this.contextMenuStripIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTasks.CheckBoxes = true;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderHashType,
            this.columnHeaderHash,
            this.columnHeaderPlain,
            this.columnHeaderLength,
            this.columnHeaderProgress,
            this.columnHeaderDigests,
            this.columnHeaderSalts,
            this.columnHeaderEstimated,
            this.columnHeaderOutput,
            this.columnHeaderDictionary,
            this.columnHeaderStarted,
            this.columnHeaderFinished,
            this.columnHeaderSession});
            this.listViewTasks.ContextMenuStrip = this.contextMenuStripTasks;
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(11, 83);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.OwnerDraw = true;
            this.listViewTasks.Size = new System.Drawing.Size(860, 360);
            this.listViewTasks.TabIndex = 1;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewTasks_DrawColumnHeader);
            this.listViewTasks.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewTasks_DrawSubItem);
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            this.listViewTasks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewTasks_MouseMove);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "#";
            this.columnHeaderNumber.Width = 37;
            // 
            // columnHeaderHashType
            // 
            this.columnHeaderHashType.Text = "Hash Type";
            this.columnHeaderHashType.Width = 75;
            // 
            // columnHeaderHash
            // 
            this.columnHeaderHash.Text = "Hash";
            this.columnHeaderHash.Width = 155;
            // 
            // columnHeaderPlain
            // 
            this.columnHeaderPlain.Text = "Plain";
            this.columnHeaderPlain.Width = 98;
            // 
            // columnHeaderLength
            // 
            this.columnHeaderLength.Text = "Length";
            this.columnHeaderLength.Width = 45;
            // 
            // columnHeaderProgress
            // 
            this.columnHeaderProgress.Text = "Progress";
            this.columnHeaderProgress.Width = 172;
            // 
            // columnHeaderDigests
            // 
            this.columnHeaderDigests.Text = "Digests";
            this.columnHeaderDigests.Width = 55;
            // 
            // columnHeaderSalts
            // 
            this.columnHeaderSalts.Text = "Salts";
            this.columnHeaderSalts.Width = 49;
            // 
            // columnHeaderEstimated
            // 
            this.columnHeaderEstimated.Text = "Estimated";
            this.columnHeaderEstimated.Width = 108;
            // 
            // columnHeaderOutput
            // 
            this.columnHeaderOutput.Text = "Output File";
            this.columnHeaderOutput.Width = 116;
            // 
            // columnHeaderDictionary
            // 
            this.columnHeaderDictionary.Text = "Dictionary / Mask";
            this.columnHeaderDictionary.Width = 102;
            // 
            // columnHeaderStarted
            // 
            this.columnHeaderStarted.Text = "Started";
            this.columnHeaderStarted.Width = 105;
            // 
            // columnHeaderFinished
            // 
            this.columnHeaderFinished.Text = "Finished";
            this.columnHeaderFinished.Width = 109;
            // 
            // columnHeaderSession
            // 
            this.columnHeaderSession.Text = "Session";
            // 
            // contextMenuStripTasks
            // 
            this.contextMenuStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopyTaskInfo,
            this.toolStripSeparator6,
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemChange,
            this.toolStripMenuItemRemove,
            this.toolStripSeparator1,
            this.toolStripMenuItemRemoveAll,
            this.toolStripSeparator2,
            this.toolStripMenuItemMoveUp,
            this.toolStripMenuItemMoveDown,
            this.toolStripSeparator3,
            this.toolStripMenuItemStart,
            this.toolStripMenuItemPause,
            this.toolStripMenuItemStop});
            this.contextMenuStripTasks.Name = "contextMenuStripTasks";
            this.contextMenuStripTasks.Size = new System.Drawing.Size(156, 248);
            // 
            // toolStripMenuItemCopyTaskInfo
            // 
            this.toolStripMenuItemCopyTaskInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFullInfo,
            this.toolStripSeparator7,
            this.toolStripMenuItemHashType,
            this.toolStripMenuItemHashTargetName,
            this.toolStripMenuItemHashTargetPath,
            this.toolStripMenuItemPlain,
            this.toolStripSeparator8,
            this.toolStripMenuItemTimeEstimated,
            this.toolStripMenuItemTimeStarted,
            this.toolStripMenuItemTimeFinished,
            this.toolStripSeparator9,
            this.toolStripMenuItemOutputFileName,
            this.toolStripMenuItemOutputFilePath,
            this.toolStripSeparator10,
            this.toolStripMenuItemMaskDictionaryName,
            this.toolStripMenuItemMaskDictionaryPath,
            this.toolStripSeparator11,
            this.toolStripMenuItemSession});
            this.toolStripMenuItemCopyTaskInfo.Name = "toolStripMenuItemCopyTaskInfo";
            this.toolStripMenuItemCopyTaskInfo.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemCopyTaskInfo.Text = "Copy task info";
            // 
            // toolStripMenuItemFullInfo
            // 
            this.toolStripMenuItemFullInfo.Name = "toolStripMenuItemFullInfo";
            this.toolStripMenuItemFullInfo.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemFullInfo.Text = "Full info";
            this.toolStripMenuItemFullInfo.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItemHashType
            // 
            this.toolStripMenuItemHashType.Name = "toolStripMenuItemHashType";
            this.toolStripMenuItemHashType.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemHashType.Text = "Hash type";
            this.toolStripMenuItemHashType.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemHashTargetName
            // 
            this.toolStripMenuItemHashTargetName.Name = "toolStripMenuItemHashTargetName";
            this.toolStripMenuItemHashTargetName.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemHashTargetName.Text = "Hash target (name)";
            this.toolStripMenuItemHashTargetName.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemHashTargetPath
            // 
            this.toolStripMenuItemHashTargetPath.Name = "toolStripMenuItemHashTargetPath";
            this.toolStripMenuItemHashTargetPath.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemHashTargetPath.Text = "Hash target (path)";
            this.toolStripMenuItemHashTargetPath.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemPlain
            // 
            this.toolStripMenuItemPlain.Name = "toolStripMenuItemPlain";
            this.toolStripMenuItemPlain.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemPlain.Text = "Plain";
            this.toolStripMenuItemPlain.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItemTimeEstimated
            // 
            this.toolStripMenuItemTimeEstimated.Name = "toolStripMenuItemTimeEstimated";
            this.toolStripMenuItemTimeEstimated.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemTimeEstimated.Text = "Time estimated";
            this.toolStripMenuItemTimeEstimated.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemTimeStarted
            // 
            this.toolStripMenuItemTimeStarted.Name = "toolStripMenuItemTimeStarted";
            this.toolStripMenuItemTimeStarted.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemTimeStarted.Text = "Time started";
            this.toolStripMenuItemTimeStarted.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemTimeFinished
            // 
            this.toolStripMenuItemTimeFinished.Name = "toolStripMenuItemTimeFinished";
            this.toolStripMenuItemTimeFinished.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemTimeFinished.Text = "Time finished";
            this.toolStripMenuItemTimeFinished.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItemOutputFileName
            // 
            this.toolStripMenuItemOutputFileName.Name = "toolStripMenuItemOutputFileName";
            this.toolStripMenuItemOutputFileName.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemOutputFileName.Text = "Output file (name)";
            this.toolStripMenuItemOutputFileName.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemOutputFilePath
            // 
            this.toolStripMenuItemOutputFilePath.Name = "toolStripMenuItemOutputFilePath";
            this.toolStripMenuItemOutputFilePath.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemOutputFilePath.Text = "Output file (path)";
            this.toolStripMenuItemOutputFilePath.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItemMaskDictionaryName
            // 
            this.toolStripMenuItemMaskDictionaryName.Name = "toolStripMenuItemMaskDictionaryName";
            this.toolStripMenuItemMaskDictionaryName.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemMaskDictionaryName.Text = "Mask / Dictionary (name)";
            this.toolStripMenuItemMaskDictionaryName.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemMaskDictionaryPath
            // 
            this.toolStripMenuItemMaskDictionaryPath.Name = "toolStripMenuItemMaskDictionaryPath";
            this.toolStripMenuItemMaskDictionaryPath.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemMaskDictionaryPath.Text = "Mask / Dictionary (path)";
            this.toolStripMenuItemMaskDictionaryPath.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItemSession
            // 
            this.toolStripMenuItemSession.Name = "toolStripMenuItemSession";
            this.toolStripMenuItemSession.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemSession.Text = "Session";
            this.toolStripMenuItemSession.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(152, 6);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemAdd.Text = "Add..";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // toolStripMenuItemChange
            // 
            this.toolStripMenuItemChange.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_edit;
            this.toolStripMenuItemChange.Name = "toolStripMenuItemChange";
            this.toolStripMenuItemChange.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemChange.Text = "Change..";
            this.toolStripMenuItemChange.Click += new System.EventHandler(this.buttonChangeTask_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemRemove.Text = "Remove";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // toolStripMenuItemRemoveAll
            // 
            this.toolStripMenuItemRemoveAll.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_clear;
            this.toolStripMenuItemRemoveAll.Name = "toolStripMenuItemRemoveAll";
            this.toolStripMenuItemRemoveAll.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemRemoveAll.Text = "Remove All";
            this.toolStripMenuItemRemoveAll.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // toolStripMenuItemMoveUp
            // 
            this.toolStripMenuItemMoveUp.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.toolStripMenuItemMoveUp.Name = "toolStripMenuItemMoveUp";
            this.toolStripMenuItemMoveUp.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemMoveUp.Text = "Move Up";
            this.toolStripMenuItemMoveUp.Click += new System.EventHandler(this.buttonUpTask_Click);
            // 
            // toolStripMenuItemMoveDown
            // 
            this.toolStripMenuItemMoveDown.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.toolStripMenuItemMoveDown.Name = "toolStripMenuItemMoveDown";
            this.toolStripMenuItemMoveDown.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemMoveDown.Text = "Move Down";
            this.toolStripMenuItemMoveDown.Click += new System.EventHandler(this.buttonDownTask_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_play;
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemStart.Text = "Start Cracking";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.buttonStartTask_Click);
            // 
            // toolStripMenuItemPause
            // 
            this.toolStripMenuItemPause.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_pause;
            this.toolStripMenuItemPause.Name = "toolStripMenuItemPause";
            this.toolStripMenuItemPause.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemPause.Text = "Pause Cracking";
            this.toolStripMenuItemPause.Click += new System.EventHandler(this.buttonPauseTask_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_stop;
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemStop.Text = "Stop Cracking";
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.buttonStopTask_Click);
            // 
            // labelGPUSpeed
            // 
            this.labelGPUSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUSpeed.AutoSize = true;
            this.labelGPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUSpeed.Location = new System.Drawing.Point(683, 18);
            this.labelGPUSpeed.Name = "labelGPUSpeed";
            this.labelGPUSpeed.Size = new System.Drawing.Size(39, 17);
            this.labelGPUSpeed.TabIndex = 22;
            this.labelGPUSpeed.Text = "0 h/s";
            // 
            // labelGPUTemp
            // 
            this.labelGPUTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUTemp.AutoSize = true;
            this.labelGPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUTemp.Location = new System.Drawing.Point(683, 49);
            this.labelGPUTemp.Name = "labelGPUTemp";
            this.labelGPUTemp.Size = new System.Drawing.Size(35, 17);
            this.labelGPUTemp.TabIndex = 24;
            this.labelGPUTemp.Text = "0 °C";
            // 
            // labelGPUUtil
            // 
            this.labelGPUUtil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUUtil.AutoSize = true;
            this.labelGPUUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUUtil.Location = new System.Drawing.Point(823, 18);
            this.labelGPUUtil.Name = "labelGPUUtil";
            this.labelGPUUtil.Size = new System.Drawing.Size(32, 17);
            this.labelGPUUtil.TabIndex = 26;
            this.labelGPUUtil.Text = "0 %";
            // 
            // labelFanSpeed
            // 
            this.labelFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFanSpeed.AutoSize = true;
            this.labelFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFanSpeed.Location = new System.Drawing.Point(823, 49);
            this.labelFanSpeed.Name = "labelFanSpeed";
            this.labelFanSpeed.Size = new System.Drawing.Size(32, 17);
            this.labelFanSpeed.TabIndex = 28;
            this.labelFanSpeed.Text = "0 %";
            // 
            // imageListCheckBox
            // 
            this.imageListCheckBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCheckBox.ImageStream")));
            this.imageListCheckBox.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCheckBox.Images.SetKeyName(0, "glyph_switch_on.png");
            this.imageListCheckBox.Images.SetKeyName(1, "glyph_switch_off.png");
            // 
            // openFileDialogCrackTasks
            // 
            this.openFileDialogCrackTasks.DefaultExt = "bin";
            this.openFileDialogCrackTasks.FileName = "CrackTasks.bin";
            this.openFileDialogCrackTasks.Filter = "Binary file (*.bin)|*.bin|All files (*.*)|*.*";
            this.openFileDialogCrackTasks.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCrackTasks_FileOk);
            // 
            // saveFileDialogCrackTasks
            // 
            this.saveFileDialogCrackTasks.FileName = "CrackTasks.bin";
            this.saveFileDialogCrackTasks.Filter = "Binary file (*.bin)|*.bin|All files (*.*)|*.*";
            this.saveFileDialogCrackTasks.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogCrackTasks_FileOk);
            // 
            // buttonSaveCrackTasksFileAs
            // 
            this.buttonSaveCrackTasksFileAs.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSaveCrackTasksFileAs.FlatAppearance.BorderSize = 0;
            this.buttonSaveCrackTasksFileAs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSaveCrackTasksFileAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveCrackTasksFileAs.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_save_as;
            this.buttonSaveCrackTasksFileAs.Location = new System.Drawing.Point(86, 45);
            this.buttonSaveCrackTasksFileAs.Name = "buttonSaveCrackTasksFileAs";
            this.buttonSaveCrackTasksFileAs.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSaveCrackTasksFileAs.Size = new System.Drawing.Size(31, 32);
            this.buttonSaveCrackTasksFileAs.TabIndex = 40;
            this.buttonSaveCrackTasksFileAs.TabStop = false;
            this.buttonSaveCrackTasksFileAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveCrackTasksFileAs.UseVisualStyleBackColor = true;
            this.buttonSaveCrackTasksFileAs.Click += new System.EventHandler(this.buttonSaveCrackTasksFileAs_Click);
            // 
            // buttonOpenCrackTasksFile
            // 
            this.buttonOpenCrackTasksFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenCrackTasksFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenCrackTasksFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOpenCrackTasksFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCrackTasksFile.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe;
            this.buttonOpenCrackTasksFile.Location = new System.Drawing.Point(12, 45);
            this.buttonOpenCrackTasksFile.Name = "buttonOpenCrackTasksFile";
            this.buttonOpenCrackTasksFile.Padding = new System.Windows.Forms.Padding(3);
            this.buttonOpenCrackTasksFile.Size = new System.Drawing.Size(31, 32);
            this.buttonOpenCrackTasksFile.TabIndex = 39;
            this.buttonOpenCrackTasksFile.TabStop = false;
            this.buttonOpenCrackTasksFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenCrackTasksFile.UseVisualStyleBackColor = true;
            this.buttonOpenCrackTasksFile.Click += new System.EventHandler(this.buttonOpenCrackTasksFile_Click);
            // 
            // buttonSaveCrackTasksFile
            // 
            this.buttonSaveCrackTasksFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSaveCrackTasksFile.FlatAppearance.BorderSize = 0;
            this.buttonSaveCrackTasksFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSaveCrackTasksFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveCrackTasksFile.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_save;
            this.buttonSaveCrackTasksFile.Location = new System.Drawing.Point(49, 45);
            this.buttonSaveCrackTasksFile.Name = "buttonSaveCrackTasksFile";
            this.buttonSaveCrackTasksFile.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSaveCrackTasksFile.Size = new System.Drawing.Size(31, 32);
            this.buttonSaveCrackTasksFile.TabIndex = 38;
            this.buttonSaveCrackTasksFile.TabStop = false;
            this.buttonSaveCrackTasksFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveCrackTasksFile.UseVisualStyleBackColor = true;
            this.buttonSaveCrackTasksFile.Click += new System.EventHandler(this.buttonSaveCrackTasksFile_Click);
            // 
            // checkBoxPauseCracking
            // 
            this.checkBoxPauseCracking.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPauseCracking.AutoSize = true;
            this.checkBoxPauseCracking.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.checkBoxPauseCracking.FlatAppearance.BorderSize = 0;
            this.checkBoxPauseCracking.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxPauseCracking.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxPauseCracking.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxPauseCracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPauseCracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPauseCracking.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxPauseCracking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxPauseCracking.ImageIndex = 0;
            this.checkBoxPauseCracking.ImageList = this.imageListCheckBox;
            this.checkBoxPauseCracking.Location = new System.Drawing.Point(171, 7);
            this.checkBoxPauseCracking.Name = "checkBoxPauseCracking";
            this.checkBoxPauseCracking.Size = new System.Drawing.Size(139, 32);
            this.checkBoxPauseCracking.TabIndex = 37;
            this.checkBoxPauseCracking.Text = "  Pause cracking";
            this.checkBoxPauseCracking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxPauseCracking.UseVisualStyleBackColor = true;
            this.checkBoxPauseCracking.CheckedChanged += new System.EventHandler(this.checkBoxPauseCracking_CheckedChanged);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_settings;
            this.buttonSettings.Location = new System.Drawing.Point(553, 45);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSettings.Size = new System.Drawing.Size(31, 32);
            this.buttonSettings.TabIndex = 35;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxFan
            // 
            this.pictureBoxFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFan.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.fan;
            this.pictureBoxFan.Location = new System.Drawing.Point(791, 45);
            this.pictureBoxFan.Name = "pictureBoxFan";
            this.pictureBoxFan.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFan.TabIndex = 34;
            this.pictureBoxFan.TabStop = false;
            // 
            // pictureBoxVideocard
            // 
            this.pictureBoxVideocard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxVideocard.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_videocard;
            this.pictureBoxVideocard.Location = new System.Drawing.Point(791, 15);
            this.pictureBoxVideocard.Name = "pictureBoxVideocard";
            this.pictureBoxVideocard.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxVideocard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVideocard.TabIndex = 33;
            this.pictureBoxVideocard.TabStop = false;
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTemperature.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_temperature;
            this.pictureBoxTemperature.Location = new System.Drawing.Point(652, 46);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTemperature.TabIndex = 32;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // pictureBoxSpeed
            // 
            this.pictureBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSpeed.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_speed;
            this.pictureBoxSpeed.Location = new System.Drawing.Point(652, 15);
            this.pictureBoxSpeed.Name = "pictureBoxSpeed";
            this.pictureBoxSpeed.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSpeed.TabIndex = 31;
            this.pictureBoxSpeed.TabStop = false;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddTask.FlatAppearance.BorderSize = 0;
            this.buttonAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.buttonAddTask.Location = new System.Drawing.Point(133, 45);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonAddTask.Size = new System.Drawing.Size(31, 32);
            this.buttonAddTask.TabIndex = 9;
            this.buttonAddTask.TabStop = false;
            this.buttonAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Enabled = false;
            this.buttonDeleteTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteTask.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.buttonDeleteTask.Location = new System.Drawing.Point(170, 45);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteTask.Size = new System.Drawing.Size(31, 32);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.TabStop = false;
            this.buttonDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonUpTask
            // 
            this.buttonUpTask.Enabled = false;
            this.buttonUpTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpTask.FlatAppearance.BorderSize = 0;
            this.buttonUpTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.buttonUpTask.Location = new System.Drawing.Point(301, 45);
            this.buttonUpTask.Name = "buttonUpTask";
            this.buttonUpTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonUpTask.Size = new System.Drawing.Size(31, 32);
            this.buttonUpTask.TabIndex = 11;
            this.buttonUpTask.TabStop = false;
            this.buttonUpTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpTask.UseVisualStyleBackColor = true;
            this.buttonUpTask.Click += new System.EventHandler(this.buttonUpTask_Click);
            // 
            // buttonOpenConverter
            // 
            this.buttonOpenConverter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenConverter.FlatAppearance.BorderSize = 0;
            this.buttonOpenConverter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOpenConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenConverter.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_convert;
            this.buttonOpenConverter.Location = new System.Drawing.Point(506, 45);
            this.buttonOpenConverter.Name = "buttonOpenConverter";
            this.buttonOpenConverter.Padding = new System.Windows.Forms.Padding(3);
            this.buttonOpenConverter.Size = new System.Drawing.Size(31, 32);
            this.buttonOpenConverter.TabIndex = 18;
            this.buttonOpenConverter.TabStop = false;
            this.buttonOpenConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenConverter.UseVisualStyleBackColor = true;
            this.buttonOpenConverter.Click += new System.EventHandler(this.buttonOpenConverter_Click);
            // 
            // buttonDownTask
            // 
            this.buttonDownTask.Enabled = false;
            this.buttonDownTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDownTask.FlatAppearance.BorderSize = 0;
            this.buttonDownTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDownTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.buttonDownTask.Location = new System.Drawing.Point(338, 45);
            this.buttonDownTask.Name = "buttonDownTask";
            this.buttonDownTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownTask.Size = new System.Drawing.Size(31, 32);
            this.buttonDownTask.TabIndex = 12;
            this.buttonDownTask.TabStop = false;
            this.buttonDownTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownTask.UseVisualStyleBackColor = true;
            this.buttonDownTask.Click += new System.EventHandler(this.buttonDownTask_Click);
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.Enabled = false;
            this.buttonClearTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearTask.FlatAppearance.BorderSize = 0;
            this.buttonClearTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_clear;
            this.buttonClearTask.Location = new System.Drawing.Point(254, 45);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearTask.Size = new System.Drawing.Size(31, 32);
            this.buttonClearTask.TabIndex = 17;
            this.buttonClearTask.TabStop = false;
            this.buttonClearTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearTask.UseVisualStyleBackColor = true;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // buttonPauseTask
            // 
            this.buttonPauseTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonPauseTask.FlatAppearance.BorderSize = 0;
            this.buttonPauseTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPauseTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPauseTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_pause;
            this.buttonPauseTask.Location = new System.Drawing.Point(422, 45);
            this.buttonPauseTask.Name = "buttonPauseTask";
            this.buttonPauseTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonPauseTask.Size = new System.Drawing.Size(31, 32);
            this.buttonPauseTask.TabIndex = 15;
            this.buttonPauseTask.TabStop = false;
            this.buttonPauseTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPauseTask.UseVisualStyleBackColor = true;
            this.buttonPauseTask.Click += new System.EventHandler(this.buttonPauseTask_Click);
            // 
            // buttonChangeTask
            // 
            this.buttonChangeTask.Enabled = false;
            this.buttonChangeTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonChangeTask.FlatAppearance.BorderSize = 0;
            this.buttonChangeTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChangeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_edit;
            this.buttonChangeTask.Location = new System.Drawing.Point(207, 45);
            this.buttonChangeTask.Name = "buttonChangeTask";
            this.buttonChangeTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonChangeTask.Size = new System.Drawing.Size(31, 32);
            this.buttonChangeTask.TabIndex = 13;
            this.buttonChangeTask.TabStop = false;
            this.buttonChangeTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeTask.UseVisualStyleBackColor = true;
            this.buttonChangeTask.Click += new System.EventHandler(this.buttonChangeTask_Click);
            // 
            // buttonStartTask
            // 
            this.buttonStartTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonStartTask.FlatAppearance.BorderSize = 0;
            this.buttonStartTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_play;
            this.buttonStartTask.Location = new System.Drawing.Point(385, 45);
            this.buttonStartTask.Name = "buttonStartTask";
            this.buttonStartTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStartTask.Size = new System.Drawing.Size(31, 32);
            this.buttonStartTask.TabIndex = 14;
            this.buttonStartTask.TabStop = false;
            this.buttonStartTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartTask.UseVisualStyleBackColor = true;
            this.buttonStartTask.Click += new System.EventHandler(this.buttonStartTask_Click);
            // 
            // buttonStopTask
            // 
            this.buttonStopTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonStopTask.FlatAppearance.BorderSize = 0;
            this.buttonStopTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStopTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_stop;
            this.buttonStopTask.Location = new System.Drawing.Point(459, 45);
            this.buttonStopTask.Name = "buttonStopTask";
            this.buttonStopTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStopTask.Size = new System.Drawing.Size(31, 32);
            this.buttonStopTask.TabIndex = 16;
            this.buttonStopTask.TabStop = false;
            this.buttonStopTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopTask.UseVisualStyleBackColor = true;
            this.buttonStopTask.Click += new System.EventHandler(this.buttonStopTask_Click);
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCrackTasksFile});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 454);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(884, 22);
            this.statusStripInfo.TabIndex = 41;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // tsslCrackTasksFile
            // 
            this.tsslCrackTasksFile.Name = "tsslCrackTasksFile";
            this.tsslCrackTasksFile.Size = new System.Drawing.Size(10, 17);
            this.tsslCrackTasksFile.Text = " ";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LeukocyteGUI for oclHashcat";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripSeparator4,
            this.toolStripMenuItemPauseCracking,
            this.toolStripMenuItemResumeCracking,
            this.toolStripSeparator5,
            this.toolStripMenuItemExit});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(165, 104);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_videocard;
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItemShow.Text = "Show";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // toolStripMenuItemPauseCracking
            // 
            this.toolStripMenuItemPauseCracking.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_pause;
            this.toolStripMenuItemPauseCracking.Name = "toolStripMenuItemPauseCracking";
            this.toolStripMenuItemPauseCracking.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItemPauseCracking.Text = "Pause cracking";
            this.toolStripMenuItemPauseCracking.Click += new System.EventHandler(this.toolStripMenuItemPauseCracking_Click);
            // 
            // toolStripMenuItemResumeCracking
            // 
            this.toolStripMenuItemResumeCracking.Enabled = false;
            this.toolStripMenuItemResumeCracking.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_play;
            this.toolStripMenuItemResumeCracking.Name = "toolStripMenuItemResumeCracking";
            this.toolStripMenuItemResumeCracking.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItemResumeCracking.Text = "Resume cracking";
            this.toolStripMenuItemResumeCracking.Click += new System.EventHandler(this.toolStripMenuItemResumeCracking_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // checkBoxAllChecked
            // 
            this.checkBoxAllChecked.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAllChecked.AutoSize = true;
            this.checkBoxAllChecked.Checked = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.CrackAllChecked;
            this.checkBoxAllChecked.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "CrackAllChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAllChecked.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatAppearance.BorderSize = 0;
            this.checkBoxAllChecked.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAllChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAllChecked.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxAllChecked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxAllChecked.ImageIndex = 0;
            this.checkBoxAllChecked.ImageList = this.imageListCheckBox;
            this.checkBoxAllChecked.Location = new System.Drawing.Point(11, 7);
            this.checkBoxAllChecked.Name = "checkBoxAllChecked";
            this.checkBoxAllChecked.Size = new System.Drawing.Size(154, 32);
            this.checkBoxAllChecked.TabIndex = 36;
            this.checkBoxAllChecked.Text = "  Crack all checked";
            this.checkBoxAllChecked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxAllChecked.UseVisualStyleBackColor = true;
            this.checkBoxAllChecked.CheckedChanged += new System.EventHandler(this.checkBoxAllChecked_CheckedChanged);
            this.checkBoxAllChecked.VisibleChanged += new System.EventHandler(this.checkBoxAllChecked_CheckedChanged);
            // 
            // notifyMessage
            // 
            this.notifyMessage.Caption = "";
            this.notifyMessage.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.notifyMessage.CaptionForeColor = System.Drawing.Color.White;
            this.notifyMessage.ConnectedForm = this;
            this.notifyMessage.HidingValue = 20;
            this.notifyMessage.Icon = null;
            this.notifyMessage.MessageTime = 6000;
            this.notifyMessage.ShowIcon = false;
            this.notifyMessage.ShowingValue = 20;
            this.notifyMessage.Text = "";
            this.notifyMessage.TextBackColor = System.Drawing.Color.White;
            this.notifyMessage.TextForeColor = System.Drawing.Color.Black;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 476);
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.buttonSaveCrackTasksFileAs);
            this.Controls.Add(this.buttonOpenCrackTasksFile);
            this.Controls.Add(this.buttonSaveCrackTasksFile);
            this.Controls.Add(this.checkBoxPauseCracking);
            this.Controls.Add(this.checkBoxAllChecked);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.pictureBoxFan);
            this.Controls.Add(this.pictureBoxVideocard);
            this.Controls.Add(this.pictureBoxTemperature);
            this.Controls.Add(this.pictureBoxSpeed);
            this.Controls.Add(this.labelFanSpeed);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelGPUUtil);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonUpTask);
            this.Controls.Add(this.labelGPUTemp);
            this.Controls.Add(this.labelGPUSpeed);
            this.Controls.Add(this.buttonOpenConverter);
            this.Controls.Add(this.buttonDownTask);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(this.buttonClearTask);
            this.Controls.Add(this.buttonPauseTask);
            this.Controls.Add(this.buttonChangeTask);
            this.Controls.Add(this.buttonStartTask);
            this.Controls.Add(this.buttonStopTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 220);
            this.Name = "MainForm";
            this.Text = "LeukocyteGUI for oclHashCat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStripTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideocard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).EndInit();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderHashType;
        private System.Windows.Forms.ColumnHeader columnHeaderProgress;
        private System.Windows.Forms.ColumnHeader columnHeaderHash;
        private System.Windows.Forms.ColumnHeader columnHeaderPlain;
        private System.Windows.Forms.ColumnHeader columnHeaderStarted;
        private System.Windows.Forms.ColumnHeader columnHeaderFinished;
        private System.Windows.Forms.ColumnHeader columnHeaderEstimated;
        private System.Windows.Forms.ColumnHeader columnHeaderSession;
        private System.Windows.Forms.ColumnHeader columnHeaderDictionary;
        private System.Windows.Forms.ColumnHeader columnHeaderOutput;
        private System.Windows.Forms.Label labelGPUSpeed;
        private System.Windows.Forms.Label labelGPUTemp;
        private System.Windows.Forms.Label labelGPUUtil;
        private System.Windows.Forms.Label labelFanSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.ColumnHeader columnHeaderDigests;
        private System.Windows.Forms.ColumnHeader columnHeaderSalts;
        private System.Windows.Forms.Button buttonDownTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.Button buttonOpenConverter;
        private System.Windows.Forms.Button buttonPauseTask;
        private System.Windows.Forms.Button buttonChangeTask;
        private System.Windows.Forms.Button buttonUpTask;
        private System.Windows.Forms.Button buttonStartTask;
        private System.Windows.Forms.Button buttonStopTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.PictureBox pictureBoxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxTemperature;
        private System.Windows.Forms.PictureBox pictureBoxVideocard;
        private System.Windows.Forms.PictureBox pictureBoxFan;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ImageList imageListCheckBox;
        private System.Windows.Forms.CheckBox checkBoxAllChecked;
        private System.Windows.Forms.CheckBox checkBoxPauseCracking;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTasks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMoveUp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMoveDown;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPause;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.Button buttonSaveCrackTasksFile;
        private System.Windows.Forms.Button buttonOpenCrackTasksFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogCrackTasks;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCrackTasks;
        private System.Windows.Forms.Button buttonSaveCrackTasksFileAs;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslCrackTasksFile;
        private NotifyMessage notifyMessage;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPauseCracking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemResumeCracking;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyTaskInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFullInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHashType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHashTargetName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHashTargetPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTimeEstimated;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTimeStarted;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTimeFinished;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOutputFileName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOutputFilePath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMaskDictionaryName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMaskDictionaryPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSession;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}