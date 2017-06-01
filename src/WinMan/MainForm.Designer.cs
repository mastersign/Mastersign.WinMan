namespace Mastersign.WinMan
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnListTopWindows = new System.Windows.Forms.Button();
            this.listWindows = new System.Windows.Forms.ListView();
            this.colMatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWindowClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScreen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVirtualDesktop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteWindowPattern = new System.Windows.Forms.Button();
            this.lblWindowPatternName = new System.Windows.Forms.Label();
            this.btnNewWindowPattern = new System.Windows.Forms.Button();
            this.chkWindowClassIgnoreCase = new System.Windows.Forms.CheckBox();
            this.windowPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkTitleIgnoreCase = new System.Windows.Forms.CheckBox();
            this.cmbWindowClassPatternType = new System.Windows.Forms.ComboBox();
            this.cmbTitlePatternType = new System.Windows.Forms.ComboBox();
            this.txtProcessFileName = new System.Windows.Forms.TextBox();
            this.txtWindowClassPattern = new System.Windows.Forms.TextBox();
            this.txtWindowPatternName = new System.Windows.Forms.TextBox();
            this.txtTitlePattern = new System.Windows.Forms.TextBox();
            this.lblProcessFileName = new System.Windows.Forms.Label();
            this.lblWindowClassPatternCaption = new System.Windows.Forms.Label();
            this.lblTitlePatternCaption = new System.Windows.Forms.Label();
            this.listWindowPatterns = new System.Windows.Forms.ListBox();
            this.screensPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windowActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLayoutNameCaption = new System.Windows.Forms.Label();
            this.txtLayoutName = new System.Windows.Forms.TextBox();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.btnNewLayout = new System.Windows.Forms.Button();
            this.listLayouts = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpConfigurationPatterns = new System.Windows.Forms.TabPage();
            this.previewConfiguration = new Mastersign.WinMan.PreviewCanvas();
            this.listScreenPatterns = new System.Windows.Forms.ListBox();
            this.chkRespectVirtualDesktopCount = new System.Windows.Forms.CheckBox();
            this.numScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.numScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.numScreenTop = new System.Windows.Forms.NumericUpDown();
            this.numScreenLeft = new System.Windows.Forms.NumericUpDown();
            this.numVirtualDesktopCount = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteConfiguration = new System.Windows.Forms.Button();
            this.btnRecordConfiguration = new System.Windows.Forms.Button();
            this.lblScreenTopCaption = new System.Windows.Forms.Label();
            this.lblScreenHeightCaption = new System.Windows.Forms.Label();
            this.lblScreenWidthCaption = new System.Windows.Forms.Label();
            this.lblScreenLeftCaption = new System.Windows.Forms.Label();
            this.lblScreenNameCaption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScreensCaption = new System.Windows.Forms.Label();
            this.lblVirtualDesktopsCaption = new System.Windows.Forms.Label();
            this.lblConfigurationNameCaption = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tpWindowPatterns = new System.Windows.Forms.TabPage();
            this.lblRestoreCommandArgs = new System.Windows.Forms.Label();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.lblWindowPatternsCaption = new System.Windows.Forms.Label();
            this.txtRestoreWorkingDir = new System.Windows.Forms.TextBox();
            this.txtRestoreCommandArgs = new System.Windows.Forms.TextBox();
            this.txtRestoreCommand = new System.Windows.Forms.TextBox();
            this.lblRestoreWorkingDir = new System.Windows.Forms.Label();
            this.lblRestoreCommand = new System.Windows.Forms.Label();
            this.lblMatchCountCaption = new System.Windows.Forms.Label();
            this.tpLayouts = new System.Windows.Forms.TabPage();
            this.chkWindowActionCompensateOsMargin = new System.Windows.Forms.CheckBox();
            this.chkWindowActionBottomInvert = new System.Windows.Forms.CheckBox();
            this.chkWindowActionRightInvert = new System.Windows.Forms.CheckBox();
            this.chkWindowActionTopInvert = new System.Windows.Forms.CheckBox();
            this.chkWindowActionLeftInvert = new System.Windows.Forms.CheckBox();
            this.lblWindowActionsCaption = new System.Windows.Forms.Label();
            this.chkWindowActionRestore = new System.Windows.Forms.CheckBox();
            this.cmbLayoutConfiguration = new System.Windows.Forms.ComboBox();
            this.cmbWindowActionWindow = new System.Windows.Forms.ComboBox();
            this.lblWindowActionCaption = new System.Windows.Forms.Label();
            this.btnNewWindowAction = new System.Windows.Forms.Button();
            this.btnWindowActionApply = new System.Windows.Forms.Button();
            this.numWindowActionBottom = new System.Windows.Forms.NumericUpDown();
            this.numWindowActionRight = new System.Windows.Forms.NumericUpDown();
            this.numWindowActionTop = new System.Windows.Forms.NumericUpDown();
            this.numWindowActionLeft = new System.Windows.Forms.NumericUpDown();
            this.lblWindowActionBottomCaption = new System.Windows.Forms.Label();
            this.lblWindowActionRightCaption = new System.Windows.Forms.Label();
            this.lblWindowActionTopCaption = new System.Windows.Forms.Label();
            this.numWindowActionVirtualDesktop = new System.Windows.Forms.NumericUpDown();
            this.lblWindowActionLeftCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionBottomUnit = new System.Windows.Forms.ComboBox();
            this.cmbWindowActionRightUnit = new System.Windows.Forms.ComboBox();
            this.lblWindowStateCaption = new System.Windows.Forms.Label();
            this.lblWindowActionScreenCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionTopUnit = new System.Windows.Forms.ComboBox();
            this.lblWindowActionVirtualDesktop = new System.Windows.Forms.Label();
            this.cmbWindowActionLeftUnit = new System.Windows.Forms.ComboBox();
            this.cmbWindowState = new System.Windows.Forms.ComboBox();
            this.cmdWindowActionScreen = new System.Windows.Forms.ComboBox();
            this.btnDeleteWindowAction = new System.Windows.Forms.Button();
            this.listWindowAction = new System.Windows.Forms.ListBox();
            this.chkLayoutIsDefaultLayout = new System.Windows.Forms.CheckBox();
            this.previewLayout = new Mastersign.WinMan.PreviewCanvas();
            this.lblConfigurationPatternCaption = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNewWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyCurrentLayout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpConfigurationPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).BeginInit();
            this.tpWindowPatterns.SuspendLayout();
            this.tpLayouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListTopWindows
            // 
            this.btnListTopWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListTopWindows.Location = new System.Drawing.Point(654, 207);
            this.btnListTopWindows.Name = "btnListTopWindows";
            this.btnListTopWindows.Size = new System.Drawing.Size(116, 23);
            this.btnListTopWindows.TabIndex = 1;
            this.btnListTopWindows.Text = "Refresh Window List";
            this.btnListTopWindows.UseVisualStyleBackColor = true;
            this.btnListTopWindows.Click += new System.EventHandler(this.ReloadWindowListHandler);
            // 
            // listWindows
            // 
            this.listWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMatch,
            this.colTitle,
            this.colWindowClass,
            this.colProcess,
            this.colScreen,
            this.colVirtualDesktop,
            this.colPosition,
            this.colState});
            this.listWindows.FullRowSelect = true;
            this.listWindows.GridLines = true;
            this.listWindows.Location = new System.Drawing.Point(6, 6);
            this.listWindows.MultiSelect = false;
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(764, 195);
            this.listWindows.TabIndex = 3;
            this.listWindows.UseCompatibleStateImageBehavior = false;
            this.listWindows.View = System.Windows.Forms.View.Details;
            // 
            // colMatch
            // 
            this.colMatch.Text = "Match";
            this.colMatch.Width = 45;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 140;
            // 
            // colWindowClass
            // 
            this.colWindowClass.Text = "Window Class";
            this.colWindowClass.Width = 110;
            // 
            // colProcess
            // 
            this.colProcess.Text = "Process";
            this.colProcess.Width = 110;
            // 
            // colScreen
            // 
            this.colScreen.Text = "Screen";
            this.colScreen.Width = 90;
            // 
            // colVirtualDesktop
            // 
            this.colVirtualDesktop.Text = "Virtual Desktop";
            this.colVirtualDesktop.Width = 85;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            this.colPosition.Width = 130;
            // 
            // colState
            // 
            this.colState.Text = "State";
            this.colState.Width = 100;
            // 
            // btnDeleteWindowPattern
            // 
            this.btnDeleteWindowPattern.Location = new System.Drawing.Point(299, 226);
            this.btnDeleteWindowPattern.Name = "btnDeleteWindowPattern";
            this.btnDeleteWindowPattern.Size = new System.Drawing.Size(141, 23);
            this.btnDeleteWindowPattern.TabIndex = 26;
            this.btnDeleteWindowPattern.Text = "Delete Window Pattern";
            this.btnDeleteWindowPattern.UseVisualStyleBackColor = true;
            this.btnDeleteWindowPattern.Click += new System.EventHandler(this.DeleteWindowPatternHandler);
            // 
            // lblWindowPatternName
            // 
            this.lblWindowPatternName.AutoSize = true;
            this.lblWindowPatternName.Location = new System.Drawing.Point(174, 258);
            this.lblWindowPatternName.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPatternName.Name = "lblWindowPatternName";
            this.lblWindowPatternName.Size = new System.Drawing.Size(38, 13);
            this.lblWindowPatternName.TabIndex = 25;
            this.lblWindowPatternName.Text = "Name:";
            // 
            // btnNewWindowPattern
            // 
            this.btnNewWindowPattern.Location = new System.Drawing.Point(177, 226);
            this.btnNewWindowPattern.Name = "btnNewWindowPattern";
            this.btnNewWindowPattern.Size = new System.Drawing.Size(116, 23);
            this.btnNewWindowPattern.TabIndex = 24;
            this.btnNewWindowPattern.Text = "New Window Pattern";
            this.btnNewWindowPattern.UseVisualStyleBackColor = true;
            this.btnNewWindowPattern.Click += new System.EventHandler(this.NewWindowPatternHandler);
            // 
            // chkWindowClassIgnoreCase
            // 
            this.chkWindowClassIgnoreCase.AutoSize = true;
            this.chkWindowClassIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "WindowClassIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowClassIgnoreCase.Location = new System.Drawing.Point(362, 362);
            this.chkWindowClassIgnoreCase.Name = "chkWindowClassIgnoreCase";
            this.chkWindowClassIgnoreCase.Size = new System.Drawing.Size(83, 17);
            this.chkWindowClassIgnoreCase.TabIndex = 22;
            this.chkWindowClassIgnoreCase.Text = "Ignore Case";
            this.chkWindowClassIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // windowPatternsBindingSource
            // 
            this.windowPatternsBindingSource.DataMember = "WindowPatterns";
            this.windowPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.windowPatternsBindingSource.CurrentChanged += new System.EventHandler(this.CurrentWindowPatternChangedHandler);
            this.windowPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.CurrentWindowPatternChangedHandler);
            this.windowPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.WindowPatternListChangedHandler);
            // 
            // workspaceBindingSource
            // 
            this.workspaceBindingSource.DataSource = typeof(Mastersign.WinMan.Workspace);
            // 
            // chkTitleIgnoreCase
            // 
            this.chkTitleIgnoreCase.AutoSize = true;
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "TitleIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTitleIgnoreCase.Location = new System.Drawing.Point(362, 309);
            this.chkTitleIgnoreCase.Name = "chkTitleIgnoreCase";
            this.chkTitleIgnoreCase.Size = new System.Drawing.Size(83, 17);
            this.chkTitleIgnoreCase.TabIndex = 23;
            this.chkTitleIgnoreCase.Text = "Ignore Case";
            this.chkTitleIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // cmbWindowClassPatternType
            // 
            this.cmbWindowClassPatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "WindowClassPatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowClassPatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowClassPatternType.FormattingEnabled = true;
            this.cmbWindowClassPatternType.Location = new System.Drawing.Point(273, 360);
            this.cmbWindowClassPatternType.Name = "cmbWindowClassPatternType";
            this.cmbWindowClassPatternType.Size = new System.Drawing.Size(83, 21);
            this.cmbWindowClassPatternType.TabIndex = 20;
            // 
            // cmbTitlePatternType
            // 
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "TitlePatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbTitlePatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitlePatternType.FormattingEnabled = true;
            this.cmbTitlePatternType.Location = new System.Drawing.Point(273, 307);
            this.cmbTitlePatternType.Name = "cmbTitlePatternType";
            this.cmbTitlePatternType.Size = new System.Drawing.Size(83, 21);
            this.cmbTitlePatternType.TabIndex = 21;
            // 
            // txtProcessFileName
            // 
            this.txtProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "ProcessFileName", true));
            this.txtProcessFileName.Location = new System.Drawing.Point(273, 387);
            this.txtProcessFileName.Name = "txtProcessFileName";
            this.txtProcessFileName.Size = new System.Drawing.Size(308, 20);
            this.txtProcessFileName.TabIndex = 17;
            // 
            // txtWindowClassPattern
            // 
            this.txtWindowClassPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WindowClassPattern", true));
            this.txtWindowClassPattern.Location = new System.Drawing.Point(273, 334);
            this.txtWindowClassPattern.Name = "txtWindowClassPattern";
            this.txtWindowClassPattern.Size = new System.Drawing.Size(308, 20);
            this.txtWindowClassPattern.TabIndex = 17;
            // 
            // txtWindowPatternName
            // 
            this.txtWindowPatternName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWindowPatternName.Location = new System.Drawing.Point(273, 255);
            this.txtWindowPatternName.Name = "txtWindowPatternName";
            this.txtWindowPatternName.Size = new System.Drawing.Size(308, 20);
            this.txtWindowPatternName.TabIndex = 18;
            // 
            // txtTitlePattern
            // 
            this.txtTitlePattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "TitlePattern", true));
            this.txtTitlePattern.Location = new System.Drawing.Point(273, 281);
            this.txtTitlePattern.Name = "txtTitlePattern";
            this.txtTitlePattern.Size = new System.Drawing.Size(308, 20);
            this.txtTitlePattern.TabIndex = 19;
            // 
            // lblProcessFileName
            // 
            this.lblProcessFileName.AutoSize = true;
            this.lblProcessFileName.Location = new System.Drawing.Point(174, 390);
            this.lblProcessFileName.Margin = new System.Windows.Forms.Padding(3);
            this.lblProcessFileName.Name = "lblProcessFileName";
            this.lblProcessFileName.Size = new System.Drawing.Size(67, 13);
            this.lblProcessFileName.TabIndex = 15;
            this.lblProcessFileName.Text = "Process File:";
            // 
            // lblWindowClassPatternCaption
            // 
            this.lblWindowClassPatternCaption.AutoSize = true;
            this.lblWindowClassPatternCaption.Location = new System.Drawing.Point(174, 337);
            this.lblWindowClassPatternCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowClassPatternCaption.Name = "lblWindowClassPatternCaption";
            this.lblWindowClassPatternCaption.Size = new System.Drawing.Size(77, 13);
            this.lblWindowClassPatternCaption.TabIndex = 15;
            this.lblWindowClassPatternCaption.Text = "Window Class:";
            // 
            // lblTitlePatternCaption
            // 
            this.lblTitlePatternCaption.AutoSize = true;
            this.lblTitlePatternCaption.Location = new System.Drawing.Point(174, 284);
            this.lblTitlePatternCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitlePatternCaption.Name = "lblTitlePatternCaption";
            this.lblTitlePatternCaption.Size = new System.Drawing.Size(72, 13);
            this.lblTitlePatternCaption.TabIndex = 16;
            this.lblTitlePatternCaption.Text = "Window Title:";
            // 
            // listWindowPatterns
            // 
            this.listWindowPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listWindowPatterns.DataSource = this.windowPatternsBindingSource;
            this.listWindowPatterns.FormattingEnabled = true;
            this.listWindowPatterns.IntegralHeight = false;
            this.listWindowPatterns.Location = new System.Drawing.Point(8, 226);
            this.listWindowPatterns.Name = "listWindowPatterns";
            this.listWindowPatterns.Size = new System.Drawing.Size(160, 320);
            this.listWindowPatterns.TabIndex = 14;
            // 
            // screensPatternsBindingSource
            // 
            this.screensPatternsBindingSource.DataMember = "Screens";
            this.screensPatternsBindingSource.DataSource = this.configurationPatternsBindingSource;
            this.screensPatternsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedScreenPatternChanged);
            this.screensPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedScreenPatternChanged);
            // 
            // configurationPatternsBindingSource
            // 
            this.configurationPatternsBindingSource.DataMember = "ConfigurationPatterns";
            this.configurationPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.configurationPatternsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedConfigurationPatternChanged);
            this.configurationPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedConfigurationPatternChanged);
            this.configurationPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ConfigurationPatternsListChangedHandler);
            // 
            // windowActionsBindingSource
            // 
            this.windowActionsBindingSource.DataMember = "Windows";
            this.windowActionsBindingSource.DataSource = this.layoutsBindingSource;
            this.windowActionsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedWindowActionChangedHandler);
            this.windowActionsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedWindowActionChangedHandler);
            // 
            // layoutsBindingSource
            // 
            this.layoutsBindingSource.DataMember = "Layouts";
            this.layoutsBindingSource.DataSource = this.workspaceBindingSource;
            this.layoutsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedLayoutChangedHandler);
            // 
            // lblLayoutNameCaption
            // 
            this.lblLayoutNameCaption.AutoSize = true;
            this.lblLayoutNameCaption.Location = new System.Drawing.Point(8, 35);
            this.lblLayoutNameCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblLayoutNameCaption.Name = "lblLayoutNameCaption";
            this.lblLayoutNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblLayoutNameCaption.TabIndex = 29;
            this.lblLayoutNameCaption.Text = "Name:";
            // 
            // txtLayoutName
            // 
            this.txtLayoutName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLayoutName.Location = new System.Drawing.Point(8, 54);
            this.txtLayoutName.Name = "txtLayoutName";
            this.txtLayoutName.Size = new System.Drawing.Size(160, 20);
            this.txtLayoutName.TabIndex = 28;
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Location = new System.Drawing.Point(90, 6);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteLayout.TabIndex = 27;
            this.btnDeleteLayout.Text = "Delete";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.DeleteLayoutHandler);
            // 
            // btnNewLayout
            // 
            this.btnNewLayout.Location = new System.Drawing.Point(8, 6);
            this.btnNewLayout.Name = "btnNewLayout";
            this.btnNewLayout.Size = new System.Drawing.Size(78, 23);
            this.btnNewLayout.TabIndex = 1;
            this.btnNewLayout.Text = "New";
            this.btnNewLayout.UseVisualStyleBackColor = true;
            this.btnNewLayout.Click += new System.EventHandler(this.NewLayoutHandler);
            // 
            // listLayouts
            // 
            this.listLayouts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listLayouts.DataSource = this.layoutsBindingSource;
            this.listLayouts.FormattingEnabled = true;
            this.listLayouts.IntegralHeight = false;
            this.listLayouts.Location = new System.Drawing.Point(8, 152);
            this.listLayouts.Name = "listLayouts";
            this.listLayouts.Size = new System.Drawing.Size(160, 392);
            this.listLayouts.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpConfigurationPatterns);
            this.tabMain.Controls.Add(this.tpWindowPatterns);
            this.tabMain.Controls.Add(this.tpLayouts);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 25);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(784, 578);
            this.tabMain.TabIndex = 17;
            // 
            // tpConfigurationPatterns
            // 
            this.tpConfigurationPatterns.Controls.Add(this.previewConfiguration);
            this.tpConfigurationPatterns.Controls.Add(this.listScreenPatterns);
            this.tpConfigurationPatterns.Controls.Add(this.chkRespectVirtualDesktopCount);
            this.tpConfigurationPatterns.Controls.Add(this.numScreenHeight);
            this.tpConfigurationPatterns.Controls.Add(this.numScreenWidth);
            this.tpConfigurationPatterns.Controls.Add(this.numScreenTop);
            this.tpConfigurationPatterns.Controls.Add(this.numScreenLeft);
            this.tpConfigurationPatterns.Controls.Add(this.numVirtualDesktopCount);
            this.tpConfigurationPatterns.Controls.Add(this.btnDeleteConfiguration);
            this.tpConfigurationPatterns.Controls.Add(this.btnRecordConfiguration);
            this.tpConfigurationPatterns.Controls.Add(this.lblScreenTopCaption);
            this.tpConfigurationPatterns.Controls.Add(this.lblScreenHeightCaption);
            this.tpConfigurationPatterns.Controls.Add(this.lblScreenWidthCaption);
            this.tpConfigurationPatterns.Controls.Add(this.lblScreenLeftCaption);
            this.tpConfigurationPatterns.Controls.Add(this.lblScreenNameCaption);
            this.tpConfigurationPatterns.Controls.Add(this.label1);
            this.tpConfigurationPatterns.Controls.Add(this.lblScreensCaption);
            this.tpConfigurationPatterns.Controls.Add(this.lblVirtualDesktopsCaption);
            this.tpConfigurationPatterns.Controls.Add(this.lblConfigurationNameCaption);
            this.tpConfigurationPatterns.Controls.Add(this.txtDeviceName);
            this.tpConfigurationPatterns.Controls.Add(this.txtScreenName);
            this.tpConfigurationPatterns.Controls.Add(this.txtConfigurationName);
            this.tpConfigurationPatterns.Controls.Add(this.listBox1);
            this.tpConfigurationPatterns.Location = new System.Drawing.Point(4, 22);
            this.tpConfigurationPatterns.Name = "tpConfigurationPatterns";
            this.tpConfigurationPatterns.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfigurationPatterns.Size = new System.Drawing.Size(776, 552);
            this.tpConfigurationPatterns.TabIndex = 2;
            this.tpConfigurationPatterns.Text = "Configuration Patterns";
            this.tpConfigurationPatterns.UseVisualStyleBackColor = true;
            // 
            // previewConfiguration
            // 
            this.previewConfiguration.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewConfiguration.Location = new System.Drawing.Point(174, 6);
            this.previewConfiguration.Name = "previewConfiguration";
            this.previewConfiguration.Size = new System.Drawing.Size(594, 256);
            this.previewConfiguration.TabIndex = 58;
            this.previewConfiguration.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfigurationPreviewPaintHandler);
            // 
            // listScreenPatterns
            // 
            this.listScreenPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listScreenPatterns.DataSource = this.screensPatternsBindingSource;
            this.listScreenPatterns.FormattingEnabled = true;
            this.listScreenPatterns.IntegralHeight = false;
            this.listScreenPatterns.Location = new System.Drawing.Point(174, 315);
            this.listScreenPatterns.Name = "listScreenPatterns";
            this.listScreenPatterns.Size = new System.Drawing.Size(123, 231);
            this.listScreenPatterns.TabIndex = 57;
            // 
            // chkRespectVirtualDesktopCount
            // 
            this.chkRespectVirtualDesktopCount.AutoSize = true;
            this.chkRespectVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationPatternsBindingSource, "RespectVirtualDesktopCount", true));
            this.chkRespectVirtualDesktopCount.Location = new System.Drawing.Point(337, 269);
            this.chkRespectVirtualDesktopCount.Name = "chkRespectVirtualDesktopCount";
            this.chkRespectVirtualDesktopCount.Size = new System.Drawing.Size(115, 17);
            this.chkRespectVirtualDesktopCount.TabIndex = 56;
            this.chkRespectVirtualDesktopCount.Text = "Respect VD Count";
            this.chkRespectVirtualDesktopCount.UseVisualStyleBackColor = true;
            // 
            // numScreenHeight
            // 
            this.numScreenHeight.Enabled = false;
            this.numScreenHeight.Location = new System.Drawing.Point(386, 445);
            this.numScreenHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScreenHeight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numScreenHeight.Name = "numScreenHeight";
            this.numScreenHeight.ReadOnly = true;
            this.numScreenHeight.Size = new System.Drawing.Size(86, 20);
            this.numScreenHeight.TabIndex = 55;
            // 
            // numScreenWidth
            // 
            this.numScreenWidth.Enabled = false;
            this.numScreenWidth.Location = new System.Drawing.Point(386, 419);
            this.numScreenWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScreenWidth.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numScreenWidth.Name = "numScreenWidth";
            this.numScreenWidth.ReadOnly = true;
            this.numScreenWidth.Size = new System.Drawing.Size(86, 20);
            this.numScreenWidth.TabIndex = 54;
            // 
            // numScreenTop
            // 
            this.numScreenTop.Enabled = false;
            this.numScreenTop.Location = new System.Drawing.Point(386, 393);
            this.numScreenTop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScreenTop.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numScreenTop.Name = "numScreenTop";
            this.numScreenTop.ReadOnly = true;
            this.numScreenTop.Size = new System.Drawing.Size(86, 20);
            this.numScreenTop.TabIndex = 53;
            // 
            // numScreenLeft
            // 
            this.numScreenLeft.Enabled = false;
            this.numScreenLeft.Location = new System.Drawing.Point(386, 367);
            this.numScreenLeft.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScreenLeft.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numScreenLeft.Name = "numScreenLeft";
            this.numScreenLeft.ReadOnly = true;
            this.numScreenLeft.Size = new System.Drawing.Size(86, 20);
            this.numScreenLeft.TabIndex = 52;
            // 
            // numVirtualDesktopCount
            // 
            this.numVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurationPatternsBindingSource, "VirtualDesktopCount", true));
            this.numVirtualDesktopCount.Location = new System.Drawing.Point(264, 268);
            this.numVirtualDesktopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVirtualDesktopCount.Name = "numVirtualDesktopCount";
            this.numVirtualDesktopCount.Size = new System.Drawing.Size(67, 20);
            this.numVirtualDesktopCount.TabIndex = 51;
            this.numVirtualDesktopCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDeleteConfiguration
            // 
            this.btnDeleteConfiguration.Location = new System.Drawing.Point(90, 6);
            this.btnDeleteConfiguration.Name = "btnDeleteConfiguration";
            this.btnDeleteConfiguration.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteConfiguration.TabIndex = 50;
            this.btnDeleteConfiguration.Text = "Delete";
            this.btnDeleteConfiguration.UseVisualStyleBackColor = true;
            this.btnDeleteConfiguration.Click += new System.EventHandler(this.DeleteConfigurationHandler);
            // 
            // btnRecordConfiguration
            // 
            this.btnRecordConfiguration.Location = new System.Drawing.Point(8, 6);
            this.btnRecordConfiguration.Name = "btnRecordConfiguration";
            this.btnRecordConfiguration.Size = new System.Drawing.Size(78, 23);
            this.btnRecordConfiguration.TabIndex = 49;
            this.btnRecordConfiguration.Text = "Record";
            this.btnRecordConfiguration.UseVisualStyleBackColor = true;
            this.btnRecordConfiguration.Click += new System.EventHandler(this.RecordConfigurationHandler);
            // 
            // lblScreenTopCaption
            // 
            this.lblScreenTopCaption.AutoSize = true;
            this.lblScreenTopCaption.Enabled = false;
            this.lblScreenTopCaption.Location = new System.Drawing.Point(302, 395);
            this.lblScreenTopCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenTopCaption.Name = "lblScreenTopCaption";
            this.lblScreenTopCaption.Size = new System.Drawing.Size(29, 13);
            this.lblScreenTopCaption.TabIndex = 48;
            this.lblScreenTopCaption.Text = "Top:";
            // 
            // lblScreenHeightCaption
            // 
            this.lblScreenHeightCaption.AutoSize = true;
            this.lblScreenHeightCaption.Enabled = false;
            this.lblScreenHeightCaption.Location = new System.Drawing.Point(302, 447);
            this.lblScreenHeightCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenHeightCaption.Name = "lblScreenHeightCaption";
            this.lblScreenHeightCaption.Size = new System.Drawing.Size(41, 13);
            this.lblScreenHeightCaption.TabIndex = 47;
            this.lblScreenHeightCaption.Text = "Height:";
            // 
            // lblScreenWidthCaption
            // 
            this.lblScreenWidthCaption.AutoSize = true;
            this.lblScreenWidthCaption.Enabled = false;
            this.lblScreenWidthCaption.Location = new System.Drawing.Point(303, 421);
            this.lblScreenWidthCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenWidthCaption.Name = "lblScreenWidthCaption";
            this.lblScreenWidthCaption.Size = new System.Drawing.Size(38, 13);
            this.lblScreenWidthCaption.TabIndex = 46;
            this.lblScreenWidthCaption.Text = "Width:";
            // 
            // lblScreenLeftCaption
            // 
            this.lblScreenLeftCaption.AutoSize = true;
            this.lblScreenLeftCaption.Enabled = false;
            this.lblScreenLeftCaption.Location = new System.Drawing.Point(303, 369);
            this.lblScreenLeftCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenLeftCaption.Name = "lblScreenLeftCaption";
            this.lblScreenLeftCaption.Size = new System.Drawing.Size(28, 13);
            this.lblScreenLeftCaption.TabIndex = 45;
            this.lblScreenLeftCaption.Text = "Left:";
            // 
            // lblScreenNameCaption
            // 
            this.lblScreenNameCaption.AutoSize = true;
            this.lblScreenNameCaption.Location = new System.Drawing.Point(302, 318);
            this.lblScreenNameCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenNameCaption.Name = "lblScreenNameCaption";
            this.lblScreenNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblScreenNameCaption.TabIndex = 44;
            this.lblScreenNameCaption.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(303, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Device Name:";
            // 
            // lblScreensCaption
            // 
            this.lblScreensCaption.AutoSize = true;
            this.lblScreensCaption.Location = new System.Drawing.Point(174, 296);
            this.lblScreensCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreensCaption.Name = "lblScreensCaption";
            this.lblScreensCaption.Size = new System.Drawing.Size(49, 13);
            this.lblScreensCaption.TabIndex = 43;
            this.lblScreensCaption.Text = "Screens:";
            // 
            // lblVirtualDesktopsCaption
            // 
            this.lblVirtualDesktopsCaption.AutoSize = true;
            this.lblVirtualDesktopsCaption.Location = new System.Drawing.Point(174, 268);
            this.lblVirtualDesktopsCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblVirtualDesktopsCaption.Name = "lblVirtualDesktopsCaption";
            this.lblVirtualDesktopsCaption.Size = new System.Drawing.Size(87, 13);
            this.lblVirtualDesktopsCaption.TabIndex = 42;
            this.lblVirtualDesktopsCaption.Text = "Virtual Desktops:";
            // 
            // lblConfigurationNameCaption
            // 
            this.lblConfigurationNameCaption.AutoSize = true;
            this.lblConfigurationNameCaption.Location = new System.Drawing.Point(8, 35);
            this.lblConfigurationNameCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfigurationNameCaption.Name = "lblConfigurationNameCaption";
            this.lblConfigurationNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblConfigurationNameCaption.TabIndex = 41;
            this.lblConfigurationNameCaption.Text = "Name:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "DeviceName", true));
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(386, 341);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(161, 20);
            this.txtDeviceName.TabIndex = 39;
            // 
            // txtScreenName
            // 
            this.txtScreenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtScreenName.Location = new System.Drawing.Point(386, 315);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(161, 20);
            this.txtScreenName.TabIndex = 38;
            // 
            // txtConfigurationName
            // 
            this.txtConfigurationName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtConfigurationName.Location = new System.Drawing.Point(8, 54);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(160, 20);
            this.txtConfigurationName.TabIndex = 40;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DataSource = this.configurationPatternsBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(8, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 466);
            this.listBox1.TabIndex = 37;
            // 
            // tpWindowPatterns
            // 
            this.tpWindowPatterns.Controls.Add(this.lblRestoreCommandArgs);
            this.tpWindowPatterns.Controls.Add(this.lblMatchCount);
            this.tpWindowPatterns.Controls.Add(this.lblWindowPatternsCaption);
            this.tpWindowPatterns.Controls.Add(this.lblWindowPatternName);
            this.tpWindowPatterns.Controls.Add(this.btnDeleteWindowPattern);
            this.tpWindowPatterns.Controls.Add(this.chkWindowClassIgnoreCase);
            this.tpWindowPatterns.Controls.Add(this.listWindows);
            this.tpWindowPatterns.Controls.Add(this.chkTitleIgnoreCase);
            this.tpWindowPatterns.Controls.Add(this.btnListTopWindows);
            this.tpWindowPatterns.Controls.Add(this.cmbWindowClassPatternType);
            this.tpWindowPatterns.Controls.Add(this.btnNewWindowPattern);
            this.tpWindowPatterns.Controls.Add(this.cmbTitlePatternType);
            this.tpWindowPatterns.Controls.Add(this.txtRestoreWorkingDir);
            this.tpWindowPatterns.Controls.Add(this.txtRestoreCommandArgs);
            this.tpWindowPatterns.Controls.Add(this.txtRestoreCommand);
            this.tpWindowPatterns.Controls.Add(this.txtProcessFileName);
            this.tpWindowPatterns.Controls.Add(this.listWindowPatterns);
            this.tpWindowPatterns.Controls.Add(this.txtWindowClassPattern);
            this.tpWindowPatterns.Controls.Add(this.lblTitlePatternCaption);
            this.tpWindowPatterns.Controls.Add(this.txtWindowPatternName);
            this.tpWindowPatterns.Controls.Add(this.lblWindowClassPatternCaption);
            this.tpWindowPatterns.Controls.Add(this.txtTitlePattern);
            this.tpWindowPatterns.Controls.Add(this.lblRestoreWorkingDir);
            this.tpWindowPatterns.Controls.Add(this.lblRestoreCommand);
            this.tpWindowPatterns.Controls.Add(this.lblMatchCountCaption);
            this.tpWindowPatterns.Controls.Add(this.lblProcessFileName);
            this.tpWindowPatterns.Location = new System.Drawing.Point(4, 22);
            this.tpWindowPatterns.Name = "tpWindowPatterns";
            this.tpWindowPatterns.Padding = new System.Windows.Forms.Padding(3);
            this.tpWindowPatterns.Size = new System.Drawing.Size(776, 552);
            this.tpWindowPatterns.TabIndex = 0;
            this.tpWindowPatterns.Text = "Windows Patterns";
            this.tpWindowPatterns.UseVisualStyleBackColor = true;
            // 
            // lblRestoreCommandArgs
            // 
            this.lblRestoreCommandArgs.AutoSize = true;
            this.lblRestoreCommandArgs.Location = new System.Drawing.Point(174, 468);
            this.lblRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(3);
            this.lblRestoreCommandArgs.Name = "lblRestoreCommandArgs";
            this.lblRestoreCommandArgs.Size = new System.Drawing.Size(81, 13);
            this.lblRestoreCommandArgs.TabIndex = 29;
            this.lblRestoreCommandArgs.Text = "Command Args:";
            // 
            // lblMatchCount
            // 
            this.lblMatchCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchCount.Location = new System.Drawing.Point(270, 413);
            this.lblMatchCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblMatchCount.Name = "lblMatchCount";
            this.lblMatchCount.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblMatchCount.Size = new System.Drawing.Size(100, 20);
            this.lblMatchCount.TabIndex = 28;
            this.lblMatchCount.Text = "0";
            this.lblMatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWindowPatternsCaption
            // 
            this.lblWindowPatternsCaption.AutoSize = true;
            this.lblWindowPatternsCaption.Location = new System.Drawing.Point(8, 207);
            this.lblWindowPatternsCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPatternsCaption.Name = "lblWindowPatternsCaption";
            this.lblWindowPatternsCaption.Size = new System.Drawing.Size(91, 13);
            this.lblWindowPatternsCaption.TabIndex = 27;
            this.lblWindowPatternsCaption.Text = "Window Patterns:";
            // 
            // txtRestoreWorkingDir
            // 
            this.txtRestoreWorkingDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WorkingDir", true));
            this.txtRestoreWorkingDir.Location = new System.Drawing.Point(273, 491);
            this.txtRestoreWorkingDir.Name = "txtRestoreWorkingDir";
            this.txtRestoreWorkingDir.Size = new System.Drawing.Size(308, 20);
            this.txtRestoreWorkingDir.TabIndex = 17;
            // 
            // txtRestoreCommandArgs
            // 
            this.txtRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "CommandArgs", true));
            this.txtRestoreCommandArgs.Location = new System.Drawing.Point(273, 465);
            this.txtRestoreCommandArgs.Name = "txtRestoreCommandArgs";
            this.txtRestoreCommandArgs.Size = new System.Drawing.Size(308, 20);
            this.txtRestoreCommandArgs.TabIndex = 17;
            // 
            // txtRestoreCommand
            // 
            this.txtRestoreCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Command", true));
            this.txtRestoreCommand.Location = new System.Drawing.Point(273, 439);
            this.txtRestoreCommand.Name = "txtRestoreCommand";
            this.txtRestoreCommand.Size = new System.Drawing.Size(308, 20);
            this.txtRestoreCommand.TabIndex = 17;
            // 
            // lblRestoreWorkingDir
            // 
            this.lblRestoreWorkingDir.AutoSize = true;
            this.lblRestoreWorkingDir.Location = new System.Drawing.Point(174, 494);
            this.lblRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(3);
            this.lblRestoreWorkingDir.Name = "lblRestoreWorkingDir";
            this.lblRestoreWorkingDir.Size = new System.Drawing.Size(95, 13);
            this.lblRestoreWorkingDir.TabIndex = 15;
            this.lblRestoreWorkingDir.Text = "Working Directory:";
            // 
            // lblRestoreCommand
            // 
            this.lblRestoreCommand.AutoSize = true;
            this.lblRestoreCommand.Location = new System.Drawing.Point(174, 442);
            this.lblRestoreCommand.Margin = new System.Windows.Forms.Padding(3);
            this.lblRestoreCommand.Name = "lblRestoreCommand";
            this.lblRestoreCommand.Size = new System.Drawing.Size(57, 13);
            this.lblRestoreCommand.TabIndex = 15;
            this.lblRestoreCommand.Text = "Command:";
            // 
            // lblMatchCountCaption
            // 
            this.lblMatchCountCaption.AutoSize = true;
            this.lblMatchCountCaption.Location = new System.Drawing.Point(174, 417);
            this.lblMatchCountCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblMatchCountCaption.Name = "lblMatchCountCaption";
            this.lblMatchCountCaption.Size = new System.Drawing.Size(54, 13);
            this.lblMatchCountCaption.TabIndex = 15;
            this.lblMatchCountCaption.Text = "Matching:";
            // 
            // tpLayouts
            // 
            this.tpLayouts.Controls.Add(this.chkWindowActionCompensateOsMargin);
            this.tpLayouts.Controls.Add(this.chkWindowActionBottomInvert);
            this.tpLayouts.Controls.Add(this.chkWindowActionRightInvert);
            this.tpLayouts.Controls.Add(this.chkWindowActionTopInvert);
            this.tpLayouts.Controls.Add(this.chkWindowActionLeftInvert);
            this.tpLayouts.Controls.Add(this.lblWindowActionsCaption);
            this.tpLayouts.Controls.Add(this.chkWindowActionRestore);
            this.tpLayouts.Controls.Add(this.cmbLayoutConfiguration);
            this.tpLayouts.Controls.Add(this.cmbWindowActionWindow);
            this.tpLayouts.Controls.Add(this.lblWindowActionCaption);
            this.tpLayouts.Controls.Add(this.btnNewWindowAction);
            this.tpLayouts.Controls.Add(this.btnWindowActionApply);
            this.tpLayouts.Controls.Add(this.numWindowActionBottom);
            this.tpLayouts.Controls.Add(this.numWindowActionRight);
            this.tpLayouts.Controls.Add(this.numWindowActionTop);
            this.tpLayouts.Controls.Add(this.numWindowActionLeft);
            this.tpLayouts.Controls.Add(this.lblWindowActionBottomCaption);
            this.tpLayouts.Controls.Add(this.lblWindowActionRightCaption);
            this.tpLayouts.Controls.Add(this.lblWindowActionTopCaption);
            this.tpLayouts.Controls.Add(this.numWindowActionVirtualDesktop);
            this.tpLayouts.Controls.Add(this.lblWindowActionLeftCaption);
            this.tpLayouts.Controls.Add(this.cmbWindowActionBottomUnit);
            this.tpLayouts.Controls.Add(this.cmbWindowActionRightUnit);
            this.tpLayouts.Controls.Add(this.lblWindowStateCaption);
            this.tpLayouts.Controls.Add(this.lblWindowActionScreenCaption);
            this.tpLayouts.Controls.Add(this.cmbWindowActionTopUnit);
            this.tpLayouts.Controls.Add(this.lblWindowActionVirtualDesktop);
            this.tpLayouts.Controls.Add(this.cmbWindowActionLeftUnit);
            this.tpLayouts.Controls.Add(this.cmbWindowState);
            this.tpLayouts.Controls.Add(this.cmdWindowActionScreen);
            this.tpLayouts.Controls.Add(this.btnDeleteWindowAction);
            this.tpLayouts.Controls.Add(this.listWindowAction);
            this.tpLayouts.Controls.Add(this.chkLayoutIsDefaultLayout);
            this.tpLayouts.Controls.Add(this.previewLayout);
            this.tpLayouts.Controls.Add(this.txtLayoutName);
            this.tpLayouts.Controls.Add(this.lblConfigurationPatternCaption);
            this.tpLayouts.Controls.Add(this.lblLayoutNameCaption);
            this.tpLayouts.Controls.Add(this.btnDeleteLayout);
            this.tpLayouts.Controls.Add(this.listLayouts);
            this.tpLayouts.Controls.Add(this.btnNewLayout);
            this.tpLayouts.Location = new System.Drawing.Point(4, 22);
            this.tpLayouts.Name = "tpLayouts";
            this.tpLayouts.Padding = new System.Windows.Forms.Padding(3);
            this.tpLayouts.Size = new System.Drawing.Size(776, 552);
            this.tpLayouts.TabIndex = 1;
            this.tpLayouts.Text = "Layouts";
            this.tpLayouts.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionCompensateOsMargin
            // 
            this.chkWindowActionCompensateOsMargin.AutoSize = true;
            this.chkWindowActionCompensateOsMargin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "CompensateOsMargin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionCompensateOsMargin.Location = new System.Drawing.Point(429, 528);
            this.chkWindowActionCompensateOsMargin.Name = "chkWindowActionCompensateOsMargin";
            this.chkWindowActionCompensateOsMargin.Size = new System.Drawing.Size(138, 17);
            this.chkWindowActionCompensateOsMargin.TabIndex = 72;
            this.chkWindowActionCompensateOsMargin.Text = "Compensate OS Margin";
            this.chkWindowActionCompensateOsMargin.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionBottomInvert
            // 
            this.chkWindowActionBottomInvert.AutoSize = true;
            this.chkWindowActionBottomInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "BottomInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionBottomInvert.Location = new System.Drawing.Point(595, 503);
            this.chkWindowActionBottomInvert.Name = "chkWindowActionBottomInvert";
            this.chkWindowActionBottomInvert.Size = new System.Drawing.Size(82, 17);
            this.chkWindowActionBottomInvert.TabIndex = 71;
            this.chkWindowActionBottomInvert.Text = "from Bottom";
            this.chkWindowActionBottomInvert.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionRightInvert
            // 
            this.chkWindowActionRightInvert.AutoSize = true;
            this.chkWindowActionRightInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "RightInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionRightInvert.Location = new System.Drawing.Point(595, 477);
            this.chkWindowActionRightInvert.Name = "chkWindowActionRightInvert";
            this.chkWindowActionRightInvert.Size = new System.Drawing.Size(74, 17);
            this.chkWindowActionRightInvert.TabIndex = 71;
            this.chkWindowActionRightInvert.Text = "from Right";
            this.chkWindowActionRightInvert.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionTopInvert
            // 
            this.chkWindowActionTopInvert.AutoSize = true;
            this.chkWindowActionTopInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "TopInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionTopInvert.Location = new System.Drawing.Point(595, 451);
            this.chkWindowActionTopInvert.Name = "chkWindowActionTopInvert";
            this.chkWindowActionTopInvert.Size = new System.Drawing.Size(82, 17);
            this.chkWindowActionTopInvert.TabIndex = 71;
            this.chkWindowActionTopInvert.Text = "from Bottom";
            this.chkWindowActionTopInvert.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionLeftInvert
            // 
            this.chkWindowActionLeftInvert.AutoSize = true;
            this.chkWindowActionLeftInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "LeftInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionLeftInvert.Location = new System.Drawing.Point(595, 425);
            this.chkWindowActionLeftInvert.Name = "chkWindowActionLeftInvert";
            this.chkWindowActionLeftInvert.Size = new System.Drawing.Size(74, 17);
            this.chkWindowActionLeftInvert.TabIndex = 71;
            this.chkWindowActionLeftInvert.Text = "from Right";
            this.chkWindowActionLeftInvert.UseVisualStyleBackColor = true;
            // 
            // lblWindowActionsCaption
            // 
            this.lblWindowActionsCaption.AutoSize = true;
            this.lblWindowActionsCaption.Location = new System.Drawing.Point(174, 269);
            this.lblWindowActionsCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionsCaption.Name = "lblWindowActionsCaption";
            this.lblWindowActionsCaption.Size = new System.Drawing.Size(87, 13);
            this.lblWindowActionsCaption.TabIndex = 70;
            this.lblWindowActionsCaption.Text = "Window Actions:";
            // 
            // chkWindowActionRestore
            // 
            this.chkWindowActionRestore.AutoSize = true;
            this.chkWindowActionRestore.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "Restore", true));
            this.chkWindowActionRestore.Location = new System.Drawing.Point(429, 292);
            this.chkWindowActionRestore.Name = "chkWindowActionRestore";
            this.chkWindowActionRestore.Size = new System.Drawing.Size(63, 17);
            this.chkWindowActionRestore.TabIndex = 69;
            this.chkWindowActionRestore.Text = "Restore";
            this.chkWindowActionRestore.UseVisualStyleBackColor = true;
            // 
            // cmbLayoutConfiguration
            // 
            this.cmbLayoutConfiguration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Configuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbLayoutConfiguration.FormattingEnabled = true;
            this.cmbLayoutConfiguration.Location = new System.Drawing.Point(8, 122);
            this.cmbLayoutConfiguration.Name = "cmbLayoutConfiguration";
            this.cmbLayoutConfiguration.Size = new System.Drawing.Size(160, 21);
            this.cmbLayoutConfiguration.TabIndex = 68;
            // 
            // cmbWindowActionWindow
            // 
            this.cmbWindowActionWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Window", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionWindow.FormattingEnabled = true;
            this.cmbWindowActionWindow.Location = new System.Drawing.Point(429, 317);
            this.cmbWindowActionWindow.Name = "cmbWindowActionWindow";
            this.cmbWindowActionWindow.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowActionWindow.TabIndex = 68;
            // 
            // lblWindowActionCaption
            // 
            this.lblWindowActionCaption.AutoSize = true;
            this.lblWindowActionCaption.Location = new System.Drawing.Point(340, 320);
            this.lblWindowActionCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionCaption.Name = "lblWindowActionCaption";
            this.lblWindowActionCaption.Size = new System.Drawing.Size(86, 13);
            this.lblWindowActionCaption.TabIndex = 67;
            this.lblWindowActionCaption.Text = "Window Pattern:";
            // 
            // btnNewWindowAction
            // 
            this.btnNewWindowAction.Location = new System.Drawing.Point(174, 288);
            this.btnNewWindowAction.Name = "btnNewWindowAction";
            this.btnNewWindowAction.Size = new System.Drawing.Size(78, 23);
            this.btnNewWindowAction.TabIndex = 66;
            this.btnNewWindowAction.Text = "New";
            this.btnNewWindowAction.UseVisualStyleBackColor = true;
            this.btnNewWindowAction.Click += new System.EventHandler(this.NewWindowActionHandler);
            // 
            // btnWindowActionApply
            // 
            this.btnWindowActionApply.Location = new System.Drawing.Point(340, 288);
            this.btnWindowActionApply.Name = "btnWindowActionApply";
            this.btnWindowActionApply.Size = new System.Drawing.Size(73, 23);
            this.btnWindowActionApply.TabIndex = 65;
            this.btnWindowActionApply.Text = "Apply";
            this.btnWindowActionApply.UseVisualStyleBackColor = true;
            this.btnWindowActionApply.Click += new System.EventHandler(this.ApplyWindowActionHandler);
            // 
            // numWindowActionBottom
            // 
            this.numWindowActionBottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Bottom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionBottom.Location = new System.Drawing.Point(429, 502);
            this.numWindowActionBottom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWindowActionBottom.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numWindowActionBottom.Name = "numWindowActionBottom";
            this.numWindowActionBottom.Size = new System.Drawing.Size(94, 20);
            this.numWindowActionBottom.TabIndex = 64;
            // 
            // numWindowActionRight
            // 
            this.numWindowActionRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Right", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionRight.Location = new System.Drawing.Point(429, 476);
            this.numWindowActionRight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWindowActionRight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numWindowActionRight.Name = "numWindowActionRight";
            this.numWindowActionRight.Size = new System.Drawing.Size(94, 20);
            this.numWindowActionRight.TabIndex = 63;
            // 
            // numWindowActionTop
            // 
            this.numWindowActionTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionTop.Location = new System.Drawing.Point(429, 450);
            this.numWindowActionTop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWindowActionTop.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numWindowActionTop.Name = "numWindowActionTop";
            this.numWindowActionTop.Size = new System.Drawing.Size(94, 20);
            this.numWindowActionTop.TabIndex = 62;
            // 
            // numWindowActionLeft
            // 
            this.numWindowActionLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionLeft.Location = new System.Drawing.Point(429, 424);
            this.numWindowActionLeft.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWindowActionLeft.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numWindowActionLeft.Name = "numWindowActionLeft";
            this.numWindowActionLeft.Size = new System.Drawing.Size(94, 20);
            this.numWindowActionLeft.TabIndex = 61;
            // 
            // lblWindowActionBottomCaption
            // 
            this.lblWindowActionBottomCaption.AutoSize = true;
            this.lblWindowActionBottomCaption.Location = new System.Drawing.Point(340, 504);
            this.lblWindowActionBottomCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionBottomCaption.Name = "lblWindowActionBottomCaption";
            this.lblWindowActionBottomCaption.Size = new System.Drawing.Size(43, 13);
            this.lblWindowActionBottomCaption.TabIndex = 59;
            this.lblWindowActionBottomCaption.Text = "Bottom:";
            // 
            // lblWindowActionRightCaption
            // 
            this.lblWindowActionRightCaption.AutoSize = true;
            this.lblWindowActionRightCaption.Location = new System.Drawing.Point(340, 477);
            this.lblWindowActionRightCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionRightCaption.Name = "lblWindowActionRightCaption";
            this.lblWindowActionRightCaption.Size = new System.Drawing.Size(35, 13);
            this.lblWindowActionRightCaption.TabIndex = 58;
            this.lblWindowActionRightCaption.Text = "Right:";
            // 
            // lblWindowActionTopCaption
            // 
            this.lblWindowActionTopCaption.AutoSize = true;
            this.lblWindowActionTopCaption.Location = new System.Drawing.Point(340, 451);
            this.lblWindowActionTopCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionTopCaption.Name = "lblWindowActionTopCaption";
            this.lblWindowActionTopCaption.Size = new System.Drawing.Size(29, 13);
            this.lblWindowActionTopCaption.TabIndex = 57;
            this.lblWindowActionTopCaption.Text = "Top:";
            // 
            // numWindowActionVirtualDesktop
            // 
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "VirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionVirtualDesktop.Location = new System.Drawing.Point(429, 344);
            this.numWindowActionVirtualDesktop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowActionVirtualDesktop.Name = "numWindowActionVirtualDesktop";
            this.numWindowActionVirtualDesktop.Size = new System.Drawing.Size(160, 20);
            this.numWindowActionVirtualDesktop.TabIndex = 60;
            this.numWindowActionVirtualDesktop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWindowActionLeftCaption
            // 
            this.lblWindowActionLeftCaption.AutoSize = true;
            this.lblWindowActionLeftCaption.Location = new System.Drawing.Point(340, 425);
            this.lblWindowActionLeftCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionLeftCaption.Name = "lblWindowActionLeftCaption";
            this.lblWindowActionLeftCaption.Size = new System.Drawing.Size(28, 13);
            this.lblWindowActionLeftCaption.TabIndex = 56;
            this.lblWindowActionLeftCaption.Text = "Left:";
            // 
            // cmbWindowActionBottomUnit
            // 
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "BottomUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionBottomUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionBottomUnit.FormattingEnabled = true;
            this.cmbWindowActionBottomUnit.Location = new System.Drawing.Point(529, 501);
            this.cmbWindowActionBottomUnit.Name = "cmbWindowActionBottomUnit";
            this.cmbWindowActionBottomUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionBottomUnit.TabIndex = 51;
            // 
            // cmbWindowActionRightUnit
            // 
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "RightUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionRightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionRightUnit.FormattingEnabled = true;
            this.cmbWindowActionRightUnit.Location = new System.Drawing.Point(529, 475);
            this.cmbWindowActionRightUnit.Name = "cmbWindowActionRightUnit";
            this.cmbWindowActionRightUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionRightUnit.TabIndex = 50;
            // 
            // lblWindowStateCaption
            // 
            this.lblWindowStateCaption.AutoSize = true;
            this.lblWindowStateCaption.Location = new System.Drawing.Point(340, 400);
            this.lblWindowStateCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowStateCaption.Name = "lblWindowStateCaption";
            this.lblWindowStateCaption.Size = new System.Drawing.Size(77, 13);
            this.lblWindowStateCaption.TabIndex = 54;
            this.lblWindowStateCaption.Text = "Window State:";
            // 
            // lblWindowActionScreenCaption
            // 
            this.lblWindowActionScreenCaption.AutoSize = true;
            this.lblWindowActionScreenCaption.Location = new System.Drawing.Point(340, 373);
            this.lblWindowActionScreenCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionScreenCaption.Name = "lblWindowActionScreenCaption";
            this.lblWindowActionScreenCaption.Size = new System.Drawing.Size(44, 13);
            this.lblWindowActionScreenCaption.TabIndex = 53;
            this.lblWindowActionScreenCaption.Text = "Screen:";
            // 
            // cmbWindowActionTopUnit
            // 
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "TopUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionTopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionTopUnit.FormattingEnabled = true;
            this.cmbWindowActionTopUnit.Location = new System.Drawing.Point(529, 449);
            this.cmbWindowActionTopUnit.Name = "cmbWindowActionTopUnit";
            this.cmbWindowActionTopUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionTopUnit.TabIndex = 49;
            // 
            // lblWindowActionVirtualDesktop
            // 
            this.lblWindowActionVirtualDesktop.AutoSize = true;
            this.lblWindowActionVirtualDesktop.Location = new System.Drawing.Point(340, 346);
            this.lblWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionVirtualDesktop.Name = "lblWindowActionVirtualDesktop";
            this.lblWindowActionVirtualDesktop.Size = new System.Drawing.Size(82, 13);
            this.lblWindowActionVirtualDesktop.TabIndex = 52;
            this.lblWindowActionVirtualDesktop.Text = "Virtual Desktop:";
            // 
            // cmbWindowActionLeftUnit
            // 
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "LeftUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionLeftUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionLeftUnit.FormattingEnabled = true;
            this.cmbWindowActionLeftUnit.Location = new System.Drawing.Point(529, 423);
            this.cmbWindowActionLeftUnit.Name = "cmbWindowActionLeftUnit";
            this.cmbWindowActionLeftUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionLeftUnit.TabIndex = 48;
            // 
            // cmbWindowState
            // 
            this.cmbWindowState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "WindowState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowState.DisplayMember = "Name";
            this.cmbWindowState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowState.FormattingEnabled = true;
            this.cmbWindowState.Location = new System.Drawing.Point(429, 397);
            this.cmbWindowState.Name = "cmbWindowState";
            this.cmbWindowState.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowState.TabIndex = 46;
            this.cmbWindowState.ValueMember = "Name";
            // 
            // cmdWindowActionScreen
            // 
            this.cmdWindowActionScreen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Screen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmdWindowActionScreen.DataSource = this.screensPatternsBindingSource;
            this.cmdWindowActionScreen.DisplayMember = "Name";
            this.cmdWindowActionScreen.FormattingEnabled = true;
            this.cmdWindowActionScreen.Location = new System.Drawing.Point(429, 370);
            this.cmdWindowActionScreen.Name = "cmdWindowActionScreen";
            this.cmdWindowActionScreen.Size = new System.Drawing.Size(160, 21);
            this.cmdWindowActionScreen.TabIndex = 45;
            this.cmdWindowActionScreen.ValueMember = "Name";
            // 
            // btnDeleteWindowAction
            // 
            this.btnDeleteWindowAction.Location = new System.Drawing.Point(256, 288);
            this.btnDeleteWindowAction.Name = "btnDeleteWindowAction";
            this.btnDeleteWindowAction.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteWindowAction.TabIndex = 44;
            this.btnDeleteWindowAction.Text = "Delete";
            this.btnDeleteWindowAction.UseVisualStyleBackColor = true;
            this.btnDeleteWindowAction.Click += new System.EventHandler(this.DeleteWindowActionHandler);
            // 
            // listWindowAction
            // 
            this.listWindowAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listWindowAction.DataSource = this.windowActionsBindingSource;
            this.listWindowAction.FormattingEnabled = true;
            this.listWindowAction.IntegralHeight = false;
            this.listWindowAction.Location = new System.Drawing.Point(174, 317);
            this.listWindowAction.Name = "listWindowAction";
            this.listWindowAction.Size = new System.Drawing.Size(160, 227);
            this.listWindowAction.TabIndex = 43;
            // 
            // chkLayoutIsDefaultLayout
            // 
            this.chkLayoutIsDefaultLayout.AutoSize = true;
            this.chkLayoutIsDefaultLayout.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutsBindingSource, "DefaultLayout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLayoutIsDefaultLayout.Location = new System.Drawing.Point(8, 80);
            this.chkLayoutIsDefaultLayout.Name = "chkLayoutIsDefaultLayout";
            this.chkLayoutIsDefaultLayout.Size = new System.Drawing.Size(95, 17);
            this.chkLayoutIsDefaultLayout.TabIndex = 32;
            this.chkLayoutIsDefaultLayout.Text = "Default Layout";
            this.chkLayoutIsDefaultLayout.UseVisualStyleBackColor = true;
            // 
            // previewLayout
            // 
            this.previewLayout.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewLayout.Location = new System.Drawing.Point(174, 6);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(594, 256);
            this.previewLayout.TabIndex = 31;
            this.previewLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPreviewPaintHandler);
            // 
            // lblConfigurationPatternCaption
            // 
            this.lblConfigurationPatternCaption.AutoSize = true;
            this.lblConfigurationPatternCaption.Location = new System.Drawing.Point(8, 103);
            this.lblConfigurationPatternCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfigurationPatternCaption.Name = "lblConfigurationPatternCaption";
            this.lblConfigurationPatternCaption.Size = new System.Drawing.Size(109, 13);
            this.lblConfigurationPatternCaption.TabIndex = 29;
            this.lblConfigurationPatternCaption.Text = "Configuration Pattern:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewWorkspace,
            this.tsbOpenWorkspace,
            this.tsbSaveWorkspace,
            this.tsbApplyWorkspace,
            this.tsbApplyCurrentLayout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 18;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbNewWorkspace
            // 
            this.tsbNewWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewWorkspace.Image")));
            this.tsbNewWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewWorkspace.Name = "tsbNewWorkspace";
            this.tsbNewWorkspace.Size = new System.Drawing.Size(112, 22);
            this.tsbNewWorkspace.Text = "New Workspace";
            this.tsbNewWorkspace.Click += new System.EventHandler(this.NewWorkspaceHandler);
            // 
            // tsbOpenWorkspace
            // 
            this.tsbOpenWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenWorkspace.Image")));
            this.tsbOpenWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenWorkspace.Name = "tsbOpenWorkspace";
            this.tsbOpenWorkspace.Size = new System.Drawing.Size(117, 22);
            this.tsbOpenWorkspace.Text = "Open Workspace";
            this.tsbOpenWorkspace.Click += new System.EventHandler(this.OpenWorkspaceHandler);
            // 
            // tsbSaveWorkspace
            // 
            this.tsbSaveWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveWorkspace.Image")));
            this.tsbSaveWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveWorkspace.Name = "tsbSaveWorkspace";
            this.tsbSaveWorkspace.Size = new System.Drawing.Size(112, 22);
            this.tsbSaveWorkspace.Text = "Save Workspace";
            this.tsbSaveWorkspace.Click += new System.EventHandler(this.SaveWorkspaceHandler);
            // 
            // tsbApplyWorkspace
            // 
            this.tsbApplyWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyWorkspace.Image")));
            this.tsbApplyWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyWorkspace.Name = "tsbApplyWorkspace";
            this.tsbApplyWorkspace.Size = new System.Drawing.Size(119, 22);
            this.tsbApplyWorkspace.Text = "Apply Workspace";
            this.tsbApplyWorkspace.Click += new System.EventHandler(this.ApplyWorkspaceHandler);
            // 
            // tsbApplyCurrentLayout
            // 
            this.tsbApplyCurrentLayout.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyCurrentLayout.Image")));
            this.tsbApplyCurrentLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyCurrentLayout.Name = "tsbApplyCurrentLayout";
            this.tsbApplyCurrentLayout.Size = new System.Drawing.Size(140, 22);
            this.tsbApplyCurrentLayout.Text = "Apply Current Layout";
            this.tsbApplyCurrentLayout.Click += new System.EventHandler(this.ApplyCurrentLayoutHandler);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName});
            this.statusStrip.Location = new System.Drawing.Point(0, 603);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 73;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslFileName
            // 
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(60, 17);
            this.tsslFileName.Text = "File Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 625);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(800, 664);
            this.Name = "MainForm";
            this.Text = "WinMan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedHandler);
            this.Load += new System.EventHandler(this.FormLoadHandler);
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpConfigurationPatterns.ResumeLayout(false);
            this.tpConfigurationPatterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).EndInit();
            this.tpWindowPatterns.ResumeLayout(false);
            this.tpWindowPatterns.PerformLayout();
            this.tpLayouts.ResumeLayout(false);
            this.tpLayouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListTopWindows;
        private System.Windows.Forms.ListView listWindows;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colWindowClass;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colScreen;
        private System.Windows.Forms.ColumnHeader colVirtualDesktop;
        private System.Windows.Forms.ColumnHeader colProcess;
        private System.Windows.Forms.Button btnDeleteWindowPattern;
        private System.Windows.Forms.Label lblWindowPatternName;
        private System.Windows.Forms.Button btnNewWindowPattern;
        private System.Windows.Forms.CheckBox chkWindowClassIgnoreCase;
        private System.Windows.Forms.CheckBox chkTitleIgnoreCase;
        private System.Windows.Forms.ComboBox cmbWindowClassPatternType;
        private System.Windows.Forms.ComboBox cmbTitlePatternType;
        private System.Windows.Forms.TextBox txtWindowClassPattern;
        private System.Windows.Forms.TextBox txtWindowPatternName;
        private System.Windows.Forms.TextBox txtTitlePattern;
        private System.Windows.Forms.Label lblWindowClassPatternCaption;
        private System.Windows.Forms.Label lblTitlePatternCaption;
        private System.Windows.Forms.ListBox listWindowPatterns;
        private System.Windows.Forms.TextBox txtProcessFileName;
        private System.Windows.Forms.Label lblProcessFileName;
        private System.Windows.Forms.BindingSource windowPatternsBindingSource;
        private System.Windows.Forms.BindingSource workspaceBindingSource;
        private System.Windows.Forms.ColumnHeader colMatch;
        private System.Windows.Forms.ListBox listLayouts;
        private System.Windows.Forms.Label lblLayoutNameCaption;
        private System.Windows.Forms.TextBox txtLayoutName;
        private System.Windows.Forms.Button btnDeleteLayout;
        private System.Windows.Forms.Button btnNewLayout;
        private System.Windows.Forms.BindingSource layoutsBindingSource;
        private System.Windows.Forms.BindingSource screensPatternsBindingSource;
        private System.Windows.Forms.BindingSource windowActionsBindingSource;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpWindowPatterns;
        private System.Windows.Forms.Label lblWindowPatternsCaption;
        private System.Windows.Forms.Label lblRestoreCommand;
        private System.Windows.Forms.TabPage tpLayouts;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbOpenWorkspace;
        private System.Windows.Forms.ToolStripButton tsbSaveWorkspace;
        private System.Windows.Forms.TextBox txtRestoreCommand;
        private System.Windows.Forms.TextBox txtRestoreWorkingDir;
        private System.Windows.Forms.TextBox txtRestoreCommandArgs;
        private System.Windows.Forms.Label lblRestoreWorkingDir;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblMatchCountCaption;
        private System.Windows.Forms.ToolStripButton tsbApplyWorkspace;
        private PreviewCanvas previewLayout;
        private System.Windows.Forms.CheckBox chkLayoutIsDefaultLayout;
        private System.Windows.Forms.ToolStripButton tsbApplyCurrentLayout;
        private System.Windows.Forms.TabPage tpConfigurationPatterns;
        private System.Windows.Forms.ListBox listScreenPatterns;
        private System.Windows.Forms.CheckBox chkRespectVirtualDesktopCount;
        private System.Windows.Forms.NumericUpDown numScreenHeight;
        private System.Windows.Forms.NumericUpDown numScreenWidth;
        private System.Windows.Forms.NumericUpDown numScreenTop;
        private System.Windows.Forms.NumericUpDown numScreenLeft;
        private System.Windows.Forms.NumericUpDown numVirtualDesktopCount;
        private System.Windows.Forms.Button btnDeleteConfiguration;
        private System.Windows.Forms.Button btnRecordConfiguration;
        private System.Windows.Forms.Label lblScreenTopCaption;
        private System.Windows.Forms.Label lblScreenHeightCaption;
        private System.Windows.Forms.Label lblScreenWidthCaption;
        private System.Windows.Forms.Label lblScreenLeftCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScreensCaption;
        private System.Windows.Forms.Label lblVirtualDesktopsCaption;
        private System.Windows.Forms.Label lblConfigurationNameCaption;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtScreenName;
        private System.Windows.Forms.TextBox txtConfigurationName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chkWindowActionRestore;
        private System.Windows.Forms.ComboBox cmbLayoutConfiguration;
        private System.Windows.Forms.ComboBox cmbWindowActionWindow;
        private System.Windows.Forms.Label lblWindowActionCaption;
        private System.Windows.Forms.Button btnNewWindowAction;
        private System.Windows.Forms.Button btnWindowActionApply;
        private System.Windows.Forms.NumericUpDown numWindowActionBottom;
        private System.Windows.Forms.NumericUpDown numWindowActionRight;
        private System.Windows.Forms.NumericUpDown numWindowActionTop;
        private System.Windows.Forms.NumericUpDown numWindowActionLeft;
        private System.Windows.Forms.Label lblWindowActionBottomCaption;
        private System.Windows.Forms.Label lblWindowActionRightCaption;
        private System.Windows.Forms.Label lblWindowActionTopCaption;
        private System.Windows.Forms.NumericUpDown numWindowActionVirtualDesktop;
        private System.Windows.Forms.Label lblWindowActionLeftCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionBottomUnit;
        private System.Windows.Forms.ComboBox cmbWindowActionRightUnit;
        private System.Windows.Forms.Label lblWindowStateCaption;
        private System.Windows.Forms.Label lblWindowActionScreenCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionTopUnit;
        private System.Windows.Forms.Label lblWindowActionVirtualDesktop;
        private System.Windows.Forms.ComboBox cmbWindowActionLeftUnit;
        private System.Windows.Forms.ComboBox cmbWindowState;
        private System.Windows.Forms.ComboBox cmdWindowActionScreen;
        private System.Windows.Forms.Button btnDeleteWindowAction;
        private System.Windows.Forms.ListBox listWindowAction;
        private System.Windows.Forms.Label lblConfigurationPatternCaption;
        private System.Windows.Forms.Label lblWindowActionsCaption;
        private PreviewCanvas previewConfiguration;
        private System.Windows.Forms.Label lblScreenNameCaption;
        private System.Windows.Forms.BindingSource configurationPatternsBindingSource;
        private System.Windows.Forms.CheckBox chkWindowActionLeftInvert;
        private System.Windows.Forms.CheckBox chkWindowActionBottomInvert;
        private System.Windows.Forms.CheckBox chkWindowActionRightInvert;
        private System.Windows.Forms.CheckBox chkWindowActionTopInvert;
        private System.Windows.Forms.Label lblRestoreCommandArgs;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton tsbNewWorkspace;
        private System.Windows.Forms.CheckBox chkWindowActionCompensateOsMargin;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
    }
}

