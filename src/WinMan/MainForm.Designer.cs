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
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.tabConfigurations = new System.Windows.Forms.TabPage();
            this.listScreenPatterns = new System.Windows.Forms.ListBox();
            this.screensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScreensCaption = new System.Windows.Forms.Label();
            this.lblVirtualDesktopsCaption = new System.Windows.Forms.Label();
            this.lblConfigurationNameCaption = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabWindowActions = new System.Windows.Forms.TabPage();
            this.chkWindowActionRestore = new System.Windows.Forms.CheckBox();
            this.windowActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblWindowPositioningCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionRightUnit = new System.Windows.Forms.ComboBox();
            this.lblWindowStateCaption = new System.Windows.Forms.Label();
            this.lblWindowActionScreenCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionTopUnit = new System.Windows.Forms.ComboBox();
            this.lblWindowActionVirtualDesktop = new System.Windows.Forms.Label();
            this.cmbWindowActionLeftUnit = new System.Windows.Forms.ComboBox();
            this.cmbWindowPositioning = new System.Windows.Forms.ComboBox();
            this.cmbWindowState = new System.Windows.Forms.ComboBox();
            this.cmdWindowActionScreen = new System.Windows.Forms.ComboBox();
            this.btnDeleteWindowAction = new System.Windows.Forms.Button();
            this.listWindowAction = new System.Windows.Forms.ListBox();
            this.lblLayoutNameCaption = new System.Windows.Forms.Label();
            this.txtLayoutName = new System.Windows.Forms.TextBox();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.btnNewLayout = new System.Windows.Forms.Button();
            this.listLayouts = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabWindows = new System.Windows.Forms.TabPage();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.lblWindowPatternsCaption = new System.Windows.Forms.Label();
            this.txtRestoreWorkingDir = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRestoreCommand = new System.Windows.Forms.TextBox();
            this.lblRestoreWorkingDir = new System.Windows.Forms.Label();
            this.lblRestoreCommandArgs = new System.Windows.Forms.Label();
            this.lblWindowPatternCommand = new System.Windows.Forms.Label();
            this.lblMatchCountCaption = new System.Windows.Forms.Label();
            this.tabLayouts = new System.Windows.Forms.TabPage();
            this.chkLayoutIsDefaultLayout = new System.Windows.Forms.CheckBox();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.lblWindowPatterns2Caption = new System.Windows.Forms.Label();
            this.listWindowPatterns2 = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbOpenWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyCurrentLayout = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).BeginInit();
            this.tabLayout.SuspendLayout();
            this.tabConfigurations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).BeginInit();
            this.tabWindowActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabWindows.SuspendLayout();
            this.tabLayouts.SuspendLayout();
            this.toolStrip.SuspendLayout();
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
            this.chkWindowClassIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "WindowClassIgnoreCase", true));
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
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "TitleIgnoreCase", true));
            this.chkTitleIgnoreCase.Location = new System.Drawing.Point(362, 309);
            this.chkTitleIgnoreCase.Name = "chkTitleIgnoreCase";
            this.chkTitleIgnoreCase.Size = new System.Drawing.Size(83, 17);
            this.chkTitleIgnoreCase.TabIndex = 23;
            this.chkTitleIgnoreCase.Text = "Ignore Case";
            this.chkTitleIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // cmbWindowClassPatternType
            // 
            this.cmbWindowClassPatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "WindowClassPatternType", true));
            this.cmbWindowClassPatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowClassPatternType.FormattingEnabled = true;
            this.cmbWindowClassPatternType.Location = new System.Drawing.Point(273, 360);
            this.cmbWindowClassPatternType.Name = "cmbWindowClassPatternType";
            this.cmbWindowClassPatternType.Size = new System.Drawing.Size(83, 21);
            this.cmbWindowClassPatternType.TabIndex = 20;
            // 
            // cmbTitlePatternType
            // 
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "TitlePatternType", true));
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
            this.txtWindowPatternName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Name", true));
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
            this.listWindowPatterns.Size = new System.Drawing.Size(160, 296);
            this.listWindowPatterns.TabIndex = 14;
            // 
            // tabLayout
            // 
            this.tabLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayout.Controls.Add(this.tabConfigurations);
            this.tabLayout.Controls.Add(this.tabWindowActions);
            this.tabLayout.Location = new System.Drawing.Point(174, 202);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(450, 322);
            this.tabLayout.TabIndex = 30;
            // 
            // tabConfigurations
            // 
            this.tabConfigurations.Controls.Add(this.listScreenPatterns);
            this.tabConfigurations.Controls.Add(this.chkRespectVirtualDesktopCount);
            this.tabConfigurations.Controls.Add(this.numScreenHeight);
            this.tabConfigurations.Controls.Add(this.numScreenWidth);
            this.tabConfigurations.Controls.Add(this.numScreenTop);
            this.tabConfigurations.Controls.Add(this.numScreenLeft);
            this.tabConfigurations.Controls.Add(this.numVirtualDesktopCount);
            this.tabConfigurations.Controls.Add(this.btnDeleteConfiguration);
            this.tabConfigurations.Controls.Add(this.btnRecordConfiguration);
            this.tabConfigurations.Controls.Add(this.lblScreenTopCaption);
            this.tabConfigurations.Controls.Add(this.lblScreenHeightCaption);
            this.tabConfigurations.Controls.Add(this.lblScreenWidthCaption);
            this.tabConfigurations.Controls.Add(this.lblScreenLeftCaption);
            this.tabConfigurations.Controls.Add(this.label1);
            this.tabConfigurations.Controls.Add(this.lblScreensCaption);
            this.tabConfigurations.Controls.Add(this.lblVirtualDesktopsCaption);
            this.tabConfigurations.Controls.Add(this.lblConfigurationNameCaption);
            this.tabConfigurations.Controls.Add(this.txtDeviceName);
            this.tabConfigurations.Controls.Add(this.txtScreenName);
            this.tabConfigurations.Controls.Add(this.txtConfigurationName);
            this.tabConfigurations.Controls.Add(this.listBox1);
            this.tabConfigurations.Location = new System.Drawing.Point(4, 22);
            this.tabConfigurations.Name = "tabConfigurations";
            this.tabConfigurations.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigurations.Size = new System.Drawing.Size(442, 296);
            this.tabConfigurations.TabIndex = 0;
            this.tabConfigurations.Text = "Screen Configurations";
            this.tabConfigurations.UseVisualStyleBackColor = true;
            // 
            // listScreenPatterns
            // 
            this.listScreenPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listScreenPatterns.DataSource = this.screensBindingSource;
            this.listScreenPatterns.FormattingEnabled = true;
            this.listScreenPatterns.IntegralHeight = false;
            this.listScreenPatterns.Location = new System.Drawing.Point(172, 150);
            this.listScreenPatterns.Name = "listScreenPatterns";
            this.listScreenPatterns.Size = new System.Drawing.Size(123, 140);
            this.listScreenPatterns.TabIndex = 36;
            // 
            // screensBindingSource
            // 
            this.screensBindingSource.DataMember = "Screens";
            this.screensBindingSource.DataSource = this.configurationsBindingSource;
            this.screensBindingSource.CurrentChanged += new System.EventHandler(this.CurrentScreenPatternChanged);
            // 
            // configurationsBindingSource
            // 
            this.configurationsBindingSource.DataMember = "Configurations";
            this.configurationsBindingSource.DataSource = this.layoutsBindingSource;
            // 
            // layoutsBindingSource
            // 
            this.layoutsBindingSource.DataMember = "Layouts";
            this.layoutsBindingSource.DataSource = this.workspaceBindingSource;
            // 
            // chkRespectVirtualDesktopCount
            // 
            this.chkRespectVirtualDesktopCount.AutoSize = true;
            this.chkRespectVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationsBindingSource, "RespectVirtualDesktopCount", true));
            this.chkRespectVirtualDesktopCount.Location = new System.Drawing.Point(172, 82);
            this.chkRespectVirtualDesktopCount.Name = "chkRespectVirtualDesktopCount";
            this.chkRespectVirtualDesktopCount.Size = new System.Drawing.Size(115, 17);
            this.chkRespectVirtualDesktopCount.TabIndex = 35;
            this.chkRespectVirtualDesktopCount.Text = "Respect VD Count";
            this.chkRespectVirtualDesktopCount.UseVisualStyleBackColor = true;
            // 
            // numScreenHeight
            // 
            this.numScreenHeight.Enabled = false;
            this.numScreenHeight.Location = new System.Drawing.Point(338, 228);
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
            this.numScreenHeight.TabIndex = 34;
            // 
            // numScreenWidth
            // 
            this.numScreenWidth.Enabled = false;
            this.numScreenWidth.Location = new System.Drawing.Point(338, 202);
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
            this.numScreenWidth.TabIndex = 34;
            // 
            // numScreenTop
            // 
            this.numScreenTop.Enabled = false;
            this.numScreenTop.Location = new System.Drawing.Point(338, 176);
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
            this.numScreenTop.TabIndex = 34;
            // 
            // numScreenLeft
            // 
            this.numScreenLeft.Enabled = false;
            this.numScreenLeft.Location = new System.Drawing.Point(338, 150);
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
            this.numScreenLeft.TabIndex = 34;
            // 
            // numVirtualDesktopCount
            // 
            this.numVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurationsBindingSource, "VirtualDesktopCount", true));
            this.numVirtualDesktopCount.Location = new System.Drawing.Point(172, 56);
            this.numVirtualDesktopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVirtualDesktopCount.Name = "numVirtualDesktopCount";
            this.numVirtualDesktopCount.Size = new System.Drawing.Size(123, 20);
            this.numVirtualDesktopCount.TabIndex = 34;
            this.numVirtualDesktopCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDeleteConfiguration
            // 
            this.btnDeleteConfiguration.Location = new System.Drawing.Point(88, 7);
            this.btnDeleteConfiguration.Name = "btnDeleteConfiguration";
            this.btnDeleteConfiguration.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteConfiguration.TabIndex = 33;
            this.btnDeleteConfiguration.Text = "Delete";
            this.btnDeleteConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnRecordConfiguration
            // 
            this.btnRecordConfiguration.Location = new System.Drawing.Point(6, 7);
            this.btnRecordConfiguration.Name = "btnRecordConfiguration";
            this.btnRecordConfiguration.Size = new System.Drawing.Size(78, 23);
            this.btnRecordConfiguration.TabIndex = 32;
            this.btnRecordConfiguration.Text = "Record";
            this.btnRecordConfiguration.UseVisualStyleBackColor = true;
            this.btnRecordConfiguration.Click += new System.EventHandler(this.RecordConfigurationHandler);
            // 
            // lblScreenTopCaption
            // 
            this.lblScreenTopCaption.AutoSize = true;
            this.lblScreenTopCaption.Location = new System.Drawing.Point(297, 178);
            this.lblScreenTopCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenTopCaption.Name = "lblScreenTopCaption";
            this.lblScreenTopCaption.Size = new System.Drawing.Size(29, 13);
            this.lblScreenTopCaption.TabIndex = 31;
            this.lblScreenTopCaption.Text = "Top:";
            // 
            // lblScreenHeightCaption
            // 
            this.lblScreenHeightCaption.AutoSize = true;
            this.lblScreenHeightCaption.Location = new System.Drawing.Point(297, 230);
            this.lblScreenHeightCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenHeightCaption.Name = "lblScreenHeightCaption";
            this.lblScreenHeightCaption.Size = new System.Drawing.Size(41, 13);
            this.lblScreenHeightCaption.TabIndex = 31;
            this.lblScreenHeightCaption.Text = "Height:";
            // 
            // lblScreenWidthCaption
            // 
            this.lblScreenWidthCaption.AutoSize = true;
            this.lblScreenWidthCaption.Location = new System.Drawing.Point(298, 204);
            this.lblScreenWidthCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenWidthCaption.Name = "lblScreenWidthCaption";
            this.lblScreenWidthCaption.Size = new System.Drawing.Size(38, 13);
            this.lblScreenWidthCaption.TabIndex = 31;
            this.lblScreenWidthCaption.Text = "Width:";
            // 
            // lblScreenLeftCaption
            // 
            this.lblScreenLeftCaption.AutoSize = true;
            this.lblScreenLeftCaption.Location = new System.Drawing.Point(298, 152);
            this.lblScreenLeftCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenLeftCaption.Name = "lblScreenLeftCaption";
            this.lblScreenLeftCaption.Size = new System.Drawing.Size(28, 13);
            this.lblScreenLeftCaption.TabIndex = 31;
            this.lblScreenLeftCaption.Text = "Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Device Name:";
            // 
            // lblScreensCaption
            // 
            this.lblScreensCaption.AutoSize = true;
            this.lblScreensCaption.Location = new System.Drawing.Point(172, 105);
            this.lblScreensCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreensCaption.Name = "lblScreensCaption";
            this.lblScreensCaption.Size = new System.Drawing.Size(49, 13);
            this.lblScreensCaption.TabIndex = 31;
            this.lblScreensCaption.Text = "Screens:";
            // 
            // lblVirtualDesktopsCaption
            // 
            this.lblVirtualDesktopsCaption.AutoSize = true;
            this.lblVirtualDesktopsCaption.Location = new System.Drawing.Point(172, 37);
            this.lblVirtualDesktopsCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblVirtualDesktopsCaption.Name = "lblVirtualDesktopsCaption";
            this.lblVirtualDesktopsCaption.Size = new System.Drawing.Size(87, 13);
            this.lblVirtualDesktopsCaption.TabIndex = 31;
            this.lblVirtualDesktopsCaption.Text = "Virtual Desktops:";
            // 
            // lblConfigurationNameCaption
            // 
            this.lblConfigurationNameCaption.AutoSize = true;
            this.lblConfigurationNameCaption.Location = new System.Drawing.Point(6, 36);
            this.lblConfigurationNameCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfigurationNameCaption.Name = "lblConfigurationNameCaption";
            this.lblConfigurationNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblConfigurationNameCaption.TabIndex = 31;
            this.lblConfigurationNameCaption.Text = "Name:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensBindingSource, "DeviceName", true));
            this.txtDeviceName.Location = new System.Drawing.Point(301, 124);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(123, 20);
            this.txtDeviceName.TabIndex = 30;
            // 
            // txtScreenName
            // 
            this.txtScreenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensBindingSource, "Name", true));
            this.txtScreenName.Location = new System.Drawing.Point(172, 124);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(123, 20);
            this.txtScreenName.TabIndex = 30;
            // 
            // txtConfigurationName
            // 
            this.txtConfigurationName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "Name", true));
            this.txtConfigurationName.Location = new System.Drawing.Point(6, 55);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(160, 20);
            this.txtConfigurationName.TabIndex = 30;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DataSource = this.configurationsBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(6, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 209);
            this.listBox1.TabIndex = 0;
            // 
            // tabWindowActions
            // 
            this.tabWindowActions.Controls.Add(this.chkWindowActionRestore);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionWindow);
            this.tabWindowActions.Controls.Add(this.lblWindowActionCaption);
            this.tabWindowActions.Controls.Add(this.btnNewWindowAction);
            this.tabWindowActions.Controls.Add(this.btnWindowActionApply);
            this.tabWindowActions.Controls.Add(this.numWindowActionBottom);
            this.tabWindowActions.Controls.Add(this.numWindowActionRight);
            this.tabWindowActions.Controls.Add(this.numWindowActionTop);
            this.tabWindowActions.Controls.Add(this.numWindowActionLeft);
            this.tabWindowActions.Controls.Add(this.lblWindowActionBottomCaption);
            this.tabWindowActions.Controls.Add(this.lblWindowActionRightCaption);
            this.tabWindowActions.Controls.Add(this.lblWindowActionTopCaption);
            this.tabWindowActions.Controls.Add(this.numWindowActionVirtualDesktop);
            this.tabWindowActions.Controls.Add(this.lblWindowActionLeftCaption);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionBottomUnit);
            this.tabWindowActions.Controls.Add(this.lblWindowPositioningCaption);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionRightUnit);
            this.tabWindowActions.Controls.Add(this.lblWindowStateCaption);
            this.tabWindowActions.Controls.Add(this.lblWindowActionScreenCaption);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionTopUnit);
            this.tabWindowActions.Controls.Add(this.lblWindowActionVirtualDesktop);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionLeftUnit);
            this.tabWindowActions.Controls.Add(this.cmbWindowPositioning);
            this.tabWindowActions.Controls.Add(this.cmbWindowState);
            this.tabWindowActions.Controls.Add(this.cmdWindowActionScreen);
            this.tabWindowActions.Controls.Add(this.btnDeleteWindowAction);
            this.tabWindowActions.Controls.Add(this.listWindowAction);
            this.tabWindowActions.Location = new System.Drawing.Point(4, 22);
            this.tabWindowActions.Name = "tabWindowActions";
            this.tabWindowActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabWindowActions.Size = new System.Drawing.Size(442, 296);
            this.tabWindowActions.TabIndex = 1;
            this.tabWindowActions.Text = "Window Actions";
            this.tabWindowActions.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionRestore
            // 
            this.chkWindowActionRestore.AutoSize = true;
            this.chkWindowActionRestore.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "Restore", true));
            this.chkWindowActionRestore.Location = new System.Drawing.Point(272, 11);
            this.chkWindowActionRestore.Name = "chkWindowActionRestore";
            this.chkWindowActionRestore.Size = new System.Drawing.Size(63, 17);
            this.chkWindowActionRestore.TabIndex = 42;
            this.chkWindowActionRestore.Text = "Restore";
            this.chkWindowActionRestore.UseVisualStyleBackColor = true;
            // 
            // windowActionsBindingSource
            // 
            this.windowActionsBindingSource.DataMember = "Windows";
            this.windowActionsBindingSource.DataSource = this.layoutsBindingSource;
            // 
            // cmbWindowActionWindow
            // 
            this.cmbWindowActionWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Window", true));
            this.cmbWindowActionWindow.FormattingEnabled = true;
            this.cmbWindowActionWindow.Location = new System.Drawing.Point(272, 36);
            this.cmbWindowActionWindow.Name = "cmbWindowActionWindow";
            this.cmbWindowActionWindow.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowActionWindow.TabIndex = 41;
            // 
            // lblWindowActionCaption
            // 
            this.lblWindowActionCaption.AutoSize = true;
            this.lblWindowActionCaption.Location = new System.Drawing.Point(172, 39);
            this.lblWindowActionCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionCaption.Name = "lblWindowActionCaption";
            this.lblWindowActionCaption.Size = new System.Drawing.Size(86, 13);
            this.lblWindowActionCaption.TabIndex = 40;
            this.lblWindowActionCaption.Text = "Window Pattern:";
            // 
            // btnNewWindowAction
            // 
            this.btnNewWindowAction.Location = new System.Drawing.Point(6, 7);
            this.btnNewWindowAction.Name = "btnNewWindowAction";
            this.btnNewWindowAction.Size = new System.Drawing.Size(78, 23);
            this.btnNewWindowAction.TabIndex = 39;
            this.btnNewWindowAction.Text = "New";
            this.btnNewWindowAction.UseVisualStyleBackColor = true;
            this.btnNewWindowAction.Click += new System.EventHandler(this.NewWindowActionHandler);
            // 
            // btnWindowActionApply
            // 
            this.btnWindowActionApply.Location = new System.Drawing.Point(172, 7);
            this.btnWindowActionApply.Name = "btnWindowActionApply";
            this.btnWindowActionApply.Size = new System.Drawing.Size(73, 23);
            this.btnWindowActionApply.TabIndex = 38;
            this.btnWindowActionApply.Text = "Apply";
            this.btnWindowActionApply.UseVisualStyleBackColor = true;
            this.btnWindowActionApply.Click += new System.EventHandler(this.ApplyWindowActionHandler);
            // 
            // numWindowActionBottom
            // 
            this.numWindowActionBottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Bottom", true));
            this.numWindowActionBottom.Location = new System.Drawing.Point(272, 248);
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
            this.numWindowActionBottom.TabIndex = 37;
            // 
            // numWindowActionRight
            // 
            this.numWindowActionRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Right", true));
            this.numWindowActionRight.Location = new System.Drawing.Point(272, 222);
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
            this.numWindowActionRight.TabIndex = 37;
            // 
            // numWindowActionTop
            // 
            this.numWindowActionTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Top", true));
            this.numWindowActionTop.Location = new System.Drawing.Point(272, 196);
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
            this.numWindowActionTop.TabIndex = 37;
            // 
            // numWindowActionLeft
            // 
            this.numWindowActionLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Left", true));
            this.numWindowActionLeft.Location = new System.Drawing.Point(272, 170);
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
            this.numWindowActionLeft.TabIndex = 37;
            // 
            // lblWindowActionBottomCaption
            // 
            this.lblWindowActionBottomCaption.AutoSize = true;
            this.lblWindowActionBottomCaption.Location = new System.Drawing.Point(172, 250);
            this.lblWindowActionBottomCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionBottomCaption.Name = "lblWindowActionBottomCaption";
            this.lblWindowActionBottomCaption.Size = new System.Drawing.Size(43, 13);
            this.lblWindowActionBottomCaption.TabIndex = 35;
            this.lblWindowActionBottomCaption.Text = "Bottom:";
            // 
            // lblWindowActionRightCaption
            // 
            this.lblWindowActionRightCaption.AutoSize = true;
            this.lblWindowActionRightCaption.Location = new System.Drawing.Point(172, 223);
            this.lblWindowActionRightCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionRightCaption.Name = "lblWindowActionRightCaption";
            this.lblWindowActionRightCaption.Size = new System.Drawing.Size(35, 13);
            this.lblWindowActionRightCaption.TabIndex = 35;
            this.lblWindowActionRightCaption.Text = "Right:";
            // 
            // lblWindowActionTopCaption
            // 
            this.lblWindowActionTopCaption.AutoSize = true;
            this.lblWindowActionTopCaption.Location = new System.Drawing.Point(172, 197);
            this.lblWindowActionTopCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionTopCaption.Name = "lblWindowActionTopCaption";
            this.lblWindowActionTopCaption.Size = new System.Drawing.Size(29, 13);
            this.lblWindowActionTopCaption.TabIndex = 35;
            this.lblWindowActionTopCaption.Text = "Top:";
            // 
            // numWindowActionVirtualDesktop
            // 
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "VirtualDesktop", true));
            this.numWindowActionVirtualDesktop.Location = new System.Drawing.Point(272, 63);
            this.numWindowActionVirtualDesktop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowActionVirtualDesktop.Name = "numWindowActionVirtualDesktop";
            this.numWindowActionVirtualDesktop.Size = new System.Drawing.Size(160, 20);
            this.numWindowActionVirtualDesktop.TabIndex = 36;
            this.numWindowActionVirtualDesktop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWindowActionLeftCaption
            // 
            this.lblWindowActionLeftCaption.AutoSize = true;
            this.lblWindowActionLeftCaption.Location = new System.Drawing.Point(172, 171);
            this.lblWindowActionLeftCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionLeftCaption.Name = "lblWindowActionLeftCaption";
            this.lblWindowActionLeftCaption.Size = new System.Drawing.Size(28, 13);
            this.lblWindowActionLeftCaption.TabIndex = 35;
            this.lblWindowActionLeftCaption.Text = "Left:";
            // 
            // cmbWindowActionBottomUnit
            // 
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "BottomUnit", true));
            this.cmbWindowActionBottomUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionBottomUnit.FormattingEnabled = true;
            this.cmbWindowActionBottomUnit.Location = new System.Drawing.Point(372, 247);
            this.cmbWindowActionBottomUnit.Name = "cmbWindowActionBottomUnit";
            this.cmbWindowActionBottomUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionBottomUnit.TabIndex = 34;
            // 
            // lblWindowPositioningCaption
            // 
            this.lblWindowPositioningCaption.AutoSize = true;
            this.lblWindowPositioningCaption.Location = new System.Drawing.Point(172, 146);
            this.lblWindowPositioningCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPositioningCaption.Name = "lblWindowPositioningCaption";
            this.lblWindowPositioningCaption.Size = new System.Drawing.Size(61, 13);
            this.lblWindowPositioningCaption.TabIndex = 35;
            this.lblWindowPositioningCaption.Text = "Positioning:";
            // 
            // cmbWindowActionRightUnit
            // 
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "RightUnit", true));
            this.cmbWindowActionRightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionRightUnit.FormattingEnabled = true;
            this.cmbWindowActionRightUnit.Location = new System.Drawing.Point(372, 221);
            this.cmbWindowActionRightUnit.Name = "cmbWindowActionRightUnit";
            this.cmbWindowActionRightUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionRightUnit.TabIndex = 34;
            // 
            // lblWindowStateCaption
            // 
            this.lblWindowStateCaption.AutoSize = true;
            this.lblWindowStateCaption.Location = new System.Drawing.Point(172, 119);
            this.lblWindowStateCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowStateCaption.Name = "lblWindowStateCaption";
            this.lblWindowStateCaption.Size = new System.Drawing.Size(77, 13);
            this.lblWindowStateCaption.TabIndex = 35;
            this.lblWindowStateCaption.Text = "Window State:";
            // 
            // lblWindowActionScreenCaption
            // 
            this.lblWindowActionScreenCaption.AutoSize = true;
            this.lblWindowActionScreenCaption.Location = new System.Drawing.Point(172, 92);
            this.lblWindowActionScreenCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionScreenCaption.Name = "lblWindowActionScreenCaption";
            this.lblWindowActionScreenCaption.Size = new System.Drawing.Size(44, 13);
            this.lblWindowActionScreenCaption.TabIndex = 35;
            this.lblWindowActionScreenCaption.Text = "Screen:";
            // 
            // cmbWindowActionTopUnit
            // 
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "TopUnit", true));
            this.cmbWindowActionTopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionTopUnit.FormattingEnabled = true;
            this.cmbWindowActionTopUnit.Location = new System.Drawing.Point(372, 195);
            this.cmbWindowActionTopUnit.Name = "cmbWindowActionTopUnit";
            this.cmbWindowActionTopUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionTopUnit.TabIndex = 34;
            // 
            // lblWindowActionVirtualDesktop
            // 
            this.lblWindowActionVirtualDesktop.AutoSize = true;
            this.lblWindowActionVirtualDesktop.Location = new System.Drawing.Point(172, 65);
            this.lblWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionVirtualDesktop.Name = "lblWindowActionVirtualDesktop";
            this.lblWindowActionVirtualDesktop.Size = new System.Drawing.Size(82, 13);
            this.lblWindowActionVirtualDesktop.TabIndex = 35;
            this.lblWindowActionVirtualDesktop.Text = "Virtual Desktop:";
            // 
            // cmbWindowActionLeftUnit
            // 
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "LeftUnit", true));
            this.cmbWindowActionLeftUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionLeftUnit.FormattingEnabled = true;
            this.cmbWindowActionLeftUnit.Location = new System.Drawing.Point(372, 169);
            this.cmbWindowActionLeftUnit.Name = "cmbWindowActionLeftUnit";
            this.cmbWindowActionLeftUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionLeftUnit.TabIndex = 34;
            // 
            // cmbWindowPositioning
            // 
            this.cmbWindowPositioning.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "Positioning", true));
            this.cmbWindowPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowPositioning.FormattingEnabled = true;
            this.cmbWindowPositioning.Location = new System.Drawing.Point(272, 143);
            this.cmbWindowPositioning.Name = "cmbWindowPositioning";
            this.cmbWindowPositioning.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowPositioning.TabIndex = 34;
            // 
            // cmbWindowState
            // 
            this.cmbWindowState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "WindowState", true));
            this.cmbWindowState.DisplayMember = "Name";
            this.cmbWindowState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowState.FormattingEnabled = true;
            this.cmbWindowState.Location = new System.Drawing.Point(272, 116);
            this.cmbWindowState.Name = "cmbWindowState";
            this.cmbWindowState.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowState.TabIndex = 34;
            this.cmbWindowState.ValueMember = "Name";
            // 
            // cmdWindowActionScreen
            // 
            this.cmdWindowActionScreen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Screen", true));
            this.cmdWindowActionScreen.DataSource = this.screensBindingSource;
            this.cmdWindowActionScreen.DisplayMember = "Name";
            this.cmdWindowActionScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdWindowActionScreen.FormattingEnabled = true;
            this.cmdWindowActionScreen.Location = new System.Drawing.Point(272, 89);
            this.cmdWindowActionScreen.Name = "cmdWindowActionScreen";
            this.cmdWindowActionScreen.Size = new System.Drawing.Size(160, 21);
            this.cmdWindowActionScreen.TabIndex = 34;
            this.cmdWindowActionScreen.ValueMember = "Name";
            // 
            // btnDeleteWindowAction
            // 
            this.btnDeleteWindowAction.Location = new System.Drawing.Point(88, 7);
            this.btnDeleteWindowAction.Name = "btnDeleteWindowAction";
            this.btnDeleteWindowAction.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteWindowAction.TabIndex = 33;
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
            this.listWindowAction.Location = new System.Drawing.Point(6, 36);
            this.listWindowAction.Name = "listWindowAction";
            this.listWindowAction.Size = new System.Drawing.Size(160, 254);
            this.listWindowAction.TabIndex = 32;
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
            this.txtLayoutName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Name", true));
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
            this.listLayouts.Location = new System.Drawing.Point(8, 103);
            this.listLayouts.Name = "listLayouts";
            this.listLayouts.Size = new System.Drawing.Size(160, 421);
            this.listLayouts.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabWindows);
            this.tabMain.Controls.Add(this.tabLayouts);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 25);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(784, 556);
            this.tabMain.TabIndex = 17;
            // 
            // tabWindows
            // 
            this.tabWindows.Controls.Add(this.lblMatchCount);
            this.tabWindows.Controls.Add(this.lblWindowPatternsCaption);
            this.tabWindows.Controls.Add(this.lblWindowPatternName);
            this.tabWindows.Controls.Add(this.btnDeleteWindowPattern);
            this.tabWindows.Controls.Add(this.chkWindowClassIgnoreCase);
            this.tabWindows.Controls.Add(this.listWindows);
            this.tabWindows.Controls.Add(this.chkTitleIgnoreCase);
            this.tabWindows.Controls.Add(this.btnListTopWindows);
            this.tabWindows.Controls.Add(this.cmbWindowClassPatternType);
            this.tabWindows.Controls.Add(this.btnNewWindowPattern);
            this.tabWindows.Controls.Add(this.cmbTitlePatternType);
            this.tabWindows.Controls.Add(this.txtRestoreWorkingDir);
            this.tabWindows.Controls.Add(this.textBox1);
            this.tabWindows.Controls.Add(this.txtRestoreCommand);
            this.tabWindows.Controls.Add(this.txtProcessFileName);
            this.tabWindows.Controls.Add(this.listWindowPatterns);
            this.tabWindows.Controls.Add(this.txtWindowClassPattern);
            this.tabWindows.Controls.Add(this.lblTitlePatternCaption);
            this.tabWindows.Controls.Add(this.txtWindowPatternName);
            this.tabWindows.Controls.Add(this.lblWindowClassPatternCaption);
            this.tabWindows.Controls.Add(this.txtTitlePattern);
            this.tabWindows.Controls.Add(this.lblRestoreWorkingDir);
            this.tabWindows.Controls.Add(this.lblRestoreCommandArgs);
            this.tabWindows.Controls.Add(this.lblWindowPatternCommand);
            this.tabWindows.Controls.Add(this.lblMatchCountCaption);
            this.tabWindows.Controls.Add(this.lblProcessFileName);
            this.tabWindows.Location = new System.Drawing.Point(4, 22);
            this.tabWindows.Name = "tabWindows";
            this.tabWindows.Padding = new System.Windows.Forms.Padding(3);
            this.tabWindows.Size = new System.Drawing.Size(776, 530);
            this.tabWindows.TabIndex = 0;
            this.tabWindows.Text = "Windows";
            this.tabWindows.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 20);
            this.textBox1.TabIndex = 17;
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
            // lblRestoreCommandArgs
            // 
            this.lblRestoreCommandArgs.AutoSize = true;
            this.lblRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "CommandArgs", true));
            this.lblRestoreCommandArgs.Location = new System.Drawing.Point(174, 468);
            this.lblRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(3);
            this.lblRestoreCommandArgs.Name = "lblRestoreCommandArgs";
            this.lblRestoreCommandArgs.Size = new System.Drawing.Size(81, 13);
            this.lblRestoreCommandArgs.TabIndex = 15;
            this.lblRestoreCommandArgs.Text = "Command Args:";
            // 
            // lblWindowPatternCommand
            // 
            this.lblWindowPatternCommand.AutoSize = true;
            this.lblWindowPatternCommand.Location = new System.Drawing.Point(174, 442);
            this.lblWindowPatternCommand.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPatternCommand.Name = "lblWindowPatternCommand";
            this.lblWindowPatternCommand.Size = new System.Drawing.Size(57, 13);
            this.lblWindowPatternCommand.TabIndex = 15;
            this.lblWindowPatternCommand.Text = "Command:";
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
            // tabLayouts
            // 
            this.tabLayouts.Controls.Add(this.chkLayoutIsDefaultLayout);
            this.tabLayouts.Controls.Add(this.panelPreview);
            this.tabLayouts.Controls.Add(this.tabLayout);
            this.tabLayouts.Controls.Add(this.lblWindowPatterns2Caption);
            this.tabLayouts.Controls.Add(this.txtLayoutName);
            this.tabLayouts.Controls.Add(this.lblLayoutNameCaption);
            this.tabLayouts.Controls.Add(this.listWindowPatterns2);
            this.tabLayouts.Controls.Add(this.btnDeleteLayout);
            this.tabLayouts.Controls.Add(this.listLayouts);
            this.tabLayouts.Controls.Add(this.btnNewLayout);
            this.tabLayouts.Location = new System.Drawing.Point(4, 22);
            this.tabLayouts.Name = "tabLayouts";
            this.tabLayouts.Padding = new System.Windows.Forms.Padding(3);
            this.tabLayouts.Size = new System.Drawing.Size(776, 530);
            this.tabLayouts.TabIndex = 1;
            this.tabLayouts.Text = "Layouts";
            this.tabLayouts.UseVisualStyleBackColor = true;
            // 
            // chkLayoutIsDefaultLayout
            // 
            this.chkLayoutIsDefaultLayout.AutoSize = true;
            this.chkLayoutIsDefaultLayout.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutsBindingSource, "DefaultLayout", true));
            this.chkLayoutIsDefaultLayout.Location = new System.Drawing.Point(8, 80);
            this.chkLayoutIsDefaultLayout.Name = "chkLayoutIsDefaultLayout";
            this.chkLayoutIsDefaultLayout.Size = new System.Drawing.Size(95, 17);
            this.chkLayoutIsDefaultLayout.TabIndex = 32;
            this.chkLayoutIsDefaultLayout.Text = "Default Layout";
            this.chkLayoutIsDefaultLayout.UseVisualStyleBackColor = true;
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelPreview.Location = new System.Drawing.Point(174, 6);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(450, 190);
            this.panelPreview.TabIndex = 31;
            this.panelPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.PreviewPaintHandler);
            // 
            // lblWindowPatterns2Caption
            // 
            this.lblWindowPatterns2Caption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindowPatterns2Caption.AutoSize = true;
            this.lblWindowPatterns2Caption.Location = new System.Drawing.Point(627, 6);
            this.lblWindowPatterns2Caption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPatterns2Caption.Name = "lblWindowPatterns2Caption";
            this.lblWindowPatterns2Caption.Size = new System.Drawing.Size(91, 13);
            this.lblWindowPatterns2Caption.TabIndex = 29;
            this.lblWindowPatterns2Caption.Text = "Window Patterns:";
            // 
            // listWindowPatterns2
            // 
            this.listWindowPatterns2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listWindowPatterns2.DataSource = this.windowPatternsBindingSource;
            this.listWindowPatterns2.DisplayMember = "Name";
            this.listWindowPatterns2.FormattingEnabled = true;
            this.listWindowPatterns2.IntegralHeight = false;
            this.listWindowPatterns2.Location = new System.Drawing.Point(630, 25);
            this.listWindowPatterns2.Name = "listWindowPatterns2";
            this.listWindowPatterns2.Size = new System.Drawing.Size(135, 497);
            this.listWindowPatterns2.TabIndex = 28;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(800, 620);
            this.Name = "MainForm";
            this.Text = "WinMan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedHandler);
            this.Load += new System.EventHandler(this.FormLoadHandler);
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).EndInit();
            this.tabLayout.ResumeLayout(false);
            this.tabConfigurations.ResumeLayout(false);
            this.tabConfigurations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).EndInit();
            this.tabWindowActions.ResumeLayout(false);
            this.tabWindowActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabWindows.ResumeLayout(false);
            this.tabWindows.PerformLayout();
            this.tabLayouts.ResumeLayout(false);
            this.tabLayouts.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage tabConfigurations;
        private System.Windows.Forms.TabPage tabWindowActions;
        private System.Windows.Forms.Label lblConfigurationNameCaption;
        private System.Windows.Forms.TextBox txtConfigurationName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeleteConfiguration;
        private System.Windows.Forms.Button btnRecordConfiguration;
        private System.Windows.Forms.BindingSource configurationsBindingSource;
        private System.Windows.Forms.NumericUpDown numVirtualDesktopCount;
        private System.Windows.Forms.Label lblVirtualDesktopsCaption;
        private System.Windows.Forms.CheckBox chkRespectVirtualDesktopCount;
        private System.Windows.Forms.ListBox listScreenPatterns;
        private System.Windows.Forms.Label lblScreensCaption;
        private System.Windows.Forms.BindingSource screensBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.NumericUpDown numScreenLeft;
        private System.Windows.Forms.Label lblScreenLeftCaption;
        private System.Windows.Forms.Label lblScreenTopCaption;
        private System.Windows.Forms.NumericUpDown numScreenHeight;
        private System.Windows.Forms.NumericUpDown numScreenWidth;
        private System.Windows.Forms.NumericUpDown numScreenTop;
        private System.Windows.Forms.Label lblScreenHeightCaption;
        private System.Windows.Forms.Label lblScreenWidthCaption;
        private System.Windows.Forms.TextBox txtScreenName;
        private System.Windows.Forms.Button btnDeleteWindowAction;
        private System.Windows.Forms.ListBox listWindowAction;
        private System.Windows.Forms.BindingSource windowActionsBindingSource;
        private System.Windows.Forms.NumericUpDown numWindowActionVirtualDesktop;
        private System.Windows.Forms.Label lblWindowActionVirtualDesktop;
        private System.Windows.Forms.ComboBox cmdWindowActionScreen;
        private System.Windows.Forms.Label lblWindowActionScreenCaption;
        private System.Windows.Forms.Label lblWindowPositioningCaption;
        private System.Windows.Forms.ComboBox cmbWindowPositioning;
        private System.Windows.Forms.NumericUpDown numWindowActionLeft;
        private System.Windows.Forms.Label lblWindowActionLeftCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionLeftUnit;
        private System.Windows.Forms.Button btnWindowActionApply;
        private System.Windows.Forms.NumericUpDown numWindowActionTop;
        private System.Windows.Forms.Label lblWindowActionTopCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionTopUnit;
        private System.Windows.Forms.NumericUpDown numWindowActionBottom;
        private System.Windows.Forms.NumericUpDown numWindowActionRight;
        private System.Windows.Forms.Label lblWindowActionBottomCaption;
        private System.Windows.Forms.Label lblWindowActionRightCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionBottomUnit;
        private System.Windows.Forms.ComboBox cmbWindowActionRightUnit;
        private System.Windows.Forms.Label lblWindowActionCaption;
        private System.Windows.Forms.Button btnNewWindowAction;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabWindows;
        private System.Windows.Forms.Label lblWindowPatternsCaption;
        private System.Windows.Forms.Label lblWindowPatternCommand;
        private System.Windows.Forms.TabPage tabLayouts;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbOpenWorkspace;
        private System.Windows.Forms.ToolStripButton tsbSaveWorkspace;
        private System.Windows.Forms.TextBox txtRestoreCommand;
        private System.Windows.Forms.TextBox txtRestoreWorkingDir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRestoreWorkingDir;
        private System.Windows.Forms.Label lblRestoreCommandArgs;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblMatchCountCaption;
        private System.Windows.Forms.Label lblWindowPatterns2Caption;
        private System.Windows.Forms.ListBox listWindowPatterns2;
        private System.Windows.Forms.ComboBox cmbWindowActionWindow;
        private System.Windows.Forms.ToolStripButton tsbApplyWorkspace;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.CheckBox chkLayoutIsDefaultLayout;
        private System.Windows.Forms.ComboBox cmbWindowState;
        private System.Windows.Forms.CheckBox chkWindowActionRestore;
        private System.Windows.Forms.Label lblWindowStateCaption;
        private System.Windows.Forms.ToolStripButton tsbApplyCurrentLayout;
    }
}

