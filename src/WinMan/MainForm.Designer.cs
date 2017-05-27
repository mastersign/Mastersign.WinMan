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
            this.btnListTopWindows = new System.Windows.Forms.Button();
            this.listWindows = new System.Windows.Forms.ListView();
            this.colMatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWindowClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScreen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVirtualDesktop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblWindowListCaption = new System.Windows.Forms.Label();
            this.grpWindowPatterns = new System.Windows.Forms.GroupBox();
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
            this.lblProcessFileNameCaption = new System.Windows.Forms.Label();
            this.lblWindowClassPatternCaption = new System.Windows.Forms.Label();
            this.lblTitlePatternCaption = new System.Windows.Forms.Label();
            this.listWindowPatterns = new System.Windows.Forms.ListBox();
            this.grpLayouts = new System.Windows.Forms.GroupBox();
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
            this.txtWindowActionWindow = new System.Windows.Forms.TextBox();
            this.windowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblWindowActionCaption = new System.Windows.Forms.Label();
            this.btnNewWindowAction = new System.Windows.Forms.Button();
            this.btnWindowActionTest = new System.Windows.Forms.Button();
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
            this.lblWindowActionScreenCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionTopUnit = new System.Windows.Forms.ComboBox();
            this.lblWindowActionVirtualDesktop = new System.Windows.Forms.Label();
            this.cmbWindowActionLeftUnit = new System.Windows.Forms.ComboBox();
            this.cmbWindowPositioning = new System.Windows.Forms.ComboBox();
            this.cmdWindowActionScreen = new System.Windows.Forms.ComboBox();
            this.btnDeleteWindowAction = new System.Windows.Forms.Button();
            this.listWindowAction = new System.Windows.Forms.ListBox();
            this.lblLayoutNameCaption = new System.Windows.Forms.Label();
            this.txtLayoutName = new System.Windows.Forms.TextBox();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.btnNewLayout = new System.Windows.Forms.Button();
            this.listLayouts = new System.Windows.Forms.ListBox();
            this.grpWindowPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).BeginInit();
            this.grpLayouts.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.windowsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListTopWindows
            // 
            this.btnListTopWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListTopWindows.Location = new System.Drawing.Point(880, 12);
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
            this.colHandle,
            this.colWindowClass,
            this.colState,
            this.colPosition,
            this.colScreen,
            this.colVirtualDesktop,
            this.colProcess});
            this.listWindows.FullRowSelect = true;
            this.listWindows.GridLines = true;
            this.listWindows.Location = new System.Drawing.Point(12, 41);
            this.listWindows.MultiSelect = false;
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(984, 195);
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
            // colHandle
            // 
            this.colHandle.Text = "HWnd";
            this.colHandle.Width = 70;
            // 
            // colWindowClass
            // 
            this.colWindowClass.Text = "Window Class";
            this.colWindowClass.Width = 110;
            // 
            // colState
            // 
            this.colState.Text = "State";
            this.colState.Width = 80;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            this.colPosition.Width = 150;
            // 
            // colScreen
            // 
            this.colScreen.Text = "Screen";
            this.colScreen.Width = 100;
            // 
            // colVirtualDesktop
            // 
            this.colVirtualDesktop.Text = "Virtual Desktop";
            this.colVirtualDesktop.Width = 90;
            // 
            // colProcess
            // 
            this.colProcess.Text = "Process";
            this.colProcess.Width = 190;
            // 
            // lblWindowListCaption
            // 
            this.lblWindowListCaption.AutoSize = true;
            this.lblWindowListCaption.Location = new System.Drawing.Point(12, 22);
            this.lblWindowListCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowListCaption.Name = "lblWindowListCaption";
            this.lblWindowListCaption.Size = new System.Drawing.Size(87, 13);
            this.lblWindowListCaption.TabIndex = 5;
            this.lblWindowListCaption.Text = "Visible Windows:";
            // 
            // grpWindowPatterns
            // 
            this.grpWindowPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpWindowPatterns.Controls.Add(this.btnDeleteWindowPattern);
            this.grpWindowPatterns.Controls.Add(this.lblWindowPatternName);
            this.grpWindowPatterns.Controls.Add(this.btnNewWindowPattern);
            this.grpWindowPatterns.Controls.Add(this.chkWindowClassIgnoreCase);
            this.grpWindowPatterns.Controls.Add(this.chkTitleIgnoreCase);
            this.grpWindowPatterns.Controls.Add(this.cmbWindowClassPatternType);
            this.grpWindowPatterns.Controls.Add(this.cmbTitlePatternType);
            this.grpWindowPatterns.Controls.Add(this.txtProcessFileName);
            this.grpWindowPatterns.Controls.Add(this.txtWindowClassPattern);
            this.grpWindowPatterns.Controls.Add(this.txtWindowPatternName);
            this.grpWindowPatterns.Controls.Add(this.txtTitlePattern);
            this.grpWindowPatterns.Controls.Add(this.lblProcessFileNameCaption);
            this.grpWindowPatterns.Controls.Add(this.lblWindowClassPatternCaption);
            this.grpWindowPatterns.Controls.Add(this.lblTitlePatternCaption);
            this.grpWindowPatterns.Controls.Add(this.listWindowPatterns);
            this.grpWindowPatterns.Location = new System.Drawing.Point(12, 242);
            this.grpWindowPatterns.Name = "grpWindowPatterns";
            this.grpWindowPatterns.Size = new System.Drawing.Size(343, 407);
            this.grpWindowPatterns.TabIndex = 14;
            this.grpWindowPatterns.TabStop = false;
            this.grpWindowPatterns.Text = "Window Patterns";
            // 
            // btnDeleteWindowPattern
            // 
            this.btnDeleteWindowPattern.Location = new System.Drawing.Point(88, 19);
            this.btnDeleteWindowPattern.Name = "btnDeleteWindowPattern";
            this.btnDeleteWindowPattern.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteWindowPattern.TabIndex = 26;
            this.btnDeleteWindowPattern.Text = "Delete";
            this.btnDeleteWindowPattern.UseVisualStyleBackColor = true;
            this.btnDeleteWindowPattern.Click += new System.EventHandler(this.DeleteWindowPatternHandler);
            // 
            // lblWindowPatternName
            // 
            this.lblWindowPatternName.AutoSize = true;
            this.lblWindowPatternName.Location = new System.Drawing.Point(3, 48);
            this.lblWindowPatternName.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPatternName.Name = "lblWindowPatternName";
            this.lblWindowPatternName.Size = new System.Drawing.Size(38, 13);
            this.lblWindowPatternName.TabIndex = 25;
            this.lblWindowPatternName.Text = "Name:";
            // 
            // btnNewWindowPattern
            // 
            this.btnNewWindowPattern.Location = new System.Drawing.Point(6, 19);
            this.btnNewWindowPattern.Name = "btnNewWindowPattern";
            this.btnNewWindowPattern.Size = new System.Drawing.Size(78, 23);
            this.btnNewWindowPattern.TabIndex = 24;
            this.btnNewWindowPattern.Text = "New";
            this.btnNewWindowPattern.UseVisualStyleBackColor = true;
            this.btnNewWindowPattern.Click += new System.EventHandler(this.NewWindowPatternHandler);
            // 
            // chkWindowClassIgnoreCase
            // 
            this.chkWindowClassIgnoreCase.AutoSize = true;
            this.chkWindowClassIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "WindowClassIgnoreCase", true));
            this.chkWindowClassIgnoreCase.Location = new System.Drawing.Point(172, 215);
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
            // 
            // workspaceBindingSource
            // 
            this.workspaceBindingSource.DataSource = typeof(Mastersign.WinMan.Workspace);
            // 
            // chkTitleIgnoreCase
            // 
            this.chkTitleIgnoreCase.AutoSize = true;
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "TitleIgnoreCase", true));
            this.chkTitleIgnoreCase.Location = new System.Drawing.Point(172, 120);
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
            this.cmbWindowClassPatternType.Location = new System.Drawing.Point(172, 188);
            this.cmbWindowClassPatternType.Name = "cmbWindowClassPatternType";
            this.cmbWindowClassPatternType.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowClassPatternType.TabIndex = 20;
            // 
            // cmbTitlePatternType
            // 
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "TitlePatternType", true));
            this.cmbTitlePatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitlePatternType.FormattingEnabled = true;
            this.cmbTitlePatternType.Location = new System.Drawing.Point(172, 93);
            this.cmbTitlePatternType.Name = "cmbTitlePatternType";
            this.cmbTitlePatternType.Size = new System.Drawing.Size(160, 21);
            this.cmbTitlePatternType.TabIndex = 21;
            // 
            // txtProcessFileName
            // 
            this.txtProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "ProcessFileName", true));
            this.txtProcessFileName.Location = new System.Drawing.Point(172, 257);
            this.txtProcessFileName.Name = "txtProcessFileName";
            this.txtProcessFileName.Size = new System.Drawing.Size(160, 20);
            this.txtProcessFileName.TabIndex = 17;
            // 
            // txtWindowClassPattern
            // 
            this.txtWindowClassPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WindowClassPattern", true));
            this.txtWindowClassPattern.Location = new System.Drawing.Point(172, 162);
            this.txtWindowClassPattern.Name = "txtWindowClassPattern";
            this.txtWindowClassPattern.Size = new System.Drawing.Size(160, 20);
            this.txtWindowClassPattern.TabIndex = 17;
            // 
            // txtWindowPatternName
            // 
            this.txtWindowPatternName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Name", true));
            this.txtWindowPatternName.Location = new System.Drawing.Point(6, 67);
            this.txtWindowPatternName.Name = "txtWindowPatternName";
            this.txtWindowPatternName.Size = new System.Drawing.Size(160, 20);
            this.txtWindowPatternName.TabIndex = 18;
            // 
            // txtTitlePattern
            // 
            this.txtTitlePattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "TitlePattern", true));
            this.txtTitlePattern.Location = new System.Drawing.Point(172, 67);
            this.txtTitlePattern.Name = "txtTitlePattern";
            this.txtTitlePattern.Size = new System.Drawing.Size(160, 20);
            this.txtTitlePattern.TabIndex = 19;
            // 
            // lblProcessFileNameCaption
            // 
            this.lblProcessFileNameCaption.AutoSize = true;
            this.lblProcessFileNameCaption.Location = new System.Drawing.Point(169, 238);
            this.lblProcessFileNameCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblProcessFileNameCaption.Name = "lblProcessFileNameCaption";
            this.lblProcessFileNameCaption.Size = new System.Drawing.Size(67, 13);
            this.lblProcessFileNameCaption.TabIndex = 15;
            this.lblProcessFileNameCaption.Text = "Process File:";
            // 
            // lblWindowClassPatternCaption
            // 
            this.lblWindowClassPatternCaption.AutoSize = true;
            this.lblWindowClassPatternCaption.Location = new System.Drawing.Point(169, 143);
            this.lblWindowClassPatternCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowClassPatternCaption.Name = "lblWindowClassPatternCaption";
            this.lblWindowClassPatternCaption.Size = new System.Drawing.Size(77, 13);
            this.lblWindowClassPatternCaption.TabIndex = 15;
            this.lblWindowClassPatternCaption.Text = "Window Class:";
            // 
            // lblTitlePatternCaption
            // 
            this.lblTitlePatternCaption.AutoSize = true;
            this.lblTitlePatternCaption.Location = new System.Drawing.Point(169, 48);
            this.lblTitlePatternCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitlePatternCaption.Name = "lblTitlePatternCaption";
            this.lblTitlePatternCaption.Size = new System.Drawing.Size(30, 13);
            this.lblTitlePatternCaption.TabIndex = 16;
            this.lblTitlePatternCaption.Text = "Title:";
            // 
            // listWindowPatterns
            // 
            this.listWindowPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listWindowPatterns.DataSource = this.windowPatternsBindingSource;
            this.listWindowPatterns.FormattingEnabled = true;
            this.listWindowPatterns.IntegralHeight = false;
            this.listWindowPatterns.Location = new System.Drawing.Point(6, 93);
            this.listWindowPatterns.Name = "listWindowPatterns";
            this.listWindowPatterns.Size = new System.Drawing.Size(160, 308);
            this.listWindowPatterns.TabIndex = 14;
            // 
            // grpLayouts
            // 
            this.grpLayouts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLayouts.Controls.Add(this.tabLayout);
            this.grpLayouts.Controls.Add(this.lblLayoutNameCaption);
            this.grpLayouts.Controls.Add(this.txtLayoutName);
            this.grpLayouts.Controls.Add(this.btnDeleteLayout);
            this.grpLayouts.Controls.Add(this.btnNewLayout);
            this.grpLayouts.Controls.Add(this.listLayouts);
            this.grpLayouts.Location = new System.Drawing.Point(361, 242);
            this.grpLayouts.Name = "grpLayouts";
            this.grpLayouts.Size = new System.Drawing.Size(635, 407);
            this.grpLayouts.TabIndex = 15;
            this.grpLayouts.TabStop = false;
            this.grpLayouts.Text = "Layouts";
            // 
            // tabLayout
            // 
            this.tabLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayout.Controls.Add(this.tabConfigurations);
            this.tabLayout.Controls.Add(this.tabWindowActions);
            this.tabLayout.Location = new System.Drawing.Point(172, 19);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(457, 382);
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
            this.tabConfigurations.Size = new System.Drawing.Size(449, 356);
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
            this.listScreenPatterns.Size = new System.Drawing.Size(160, 200);
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
            this.numScreenHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScreenHeight.Enabled = false;
            this.numScreenHeight.Location = new System.Drawing.Point(375, 228);
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
            this.numScreenHeight.Size = new System.Drawing.Size(68, 20);
            this.numScreenHeight.TabIndex = 34;
            // 
            // numScreenWidth
            // 
            this.numScreenWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScreenWidth.Enabled = false;
            this.numScreenWidth.Location = new System.Drawing.Point(375, 202);
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
            this.numScreenWidth.Size = new System.Drawing.Size(68, 20);
            this.numScreenWidth.TabIndex = 34;
            // 
            // numScreenTop
            // 
            this.numScreenTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScreenTop.Enabled = false;
            this.numScreenTop.Location = new System.Drawing.Point(375, 176);
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
            this.numScreenTop.Size = new System.Drawing.Size(68, 20);
            this.numScreenTop.TabIndex = 34;
            // 
            // numScreenLeft
            // 
            this.numScreenLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScreenLeft.Enabled = false;
            this.numScreenLeft.Location = new System.Drawing.Point(375, 150);
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
            this.numScreenLeft.Size = new System.Drawing.Size(68, 20);
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
            this.numVirtualDesktopCount.Size = new System.Drawing.Size(160, 20);
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
            this.lblScreenTopCaption.Location = new System.Drawing.Point(334, 178);
            this.lblScreenTopCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenTopCaption.Name = "lblScreenTopCaption";
            this.lblScreenTopCaption.Size = new System.Drawing.Size(29, 13);
            this.lblScreenTopCaption.TabIndex = 31;
            this.lblScreenTopCaption.Text = "Top:";
            // 
            // lblScreenHeightCaption
            // 
            this.lblScreenHeightCaption.AutoSize = true;
            this.lblScreenHeightCaption.Location = new System.Drawing.Point(334, 230);
            this.lblScreenHeightCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenHeightCaption.Name = "lblScreenHeightCaption";
            this.lblScreenHeightCaption.Size = new System.Drawing.Size(41, 13);
            this.lblScreenHeightCaption.TabIndex = 31;
            this.lblScreenHeightCaption.Text = "Height:";
            // 
            // lblScreenWidthCaption
            // 
            this.lblScreenWidthCaption.AutoSize = true;
            this.lblScreenWidthCaption.Location = new System.Drawing.Point(335, 204);
            this.lblScreenWidthCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenWidthCaption.Name = "lblScreenWidthCaption";
            this.lblScreenWidthCaption.Size = new System.Drawing.Size(38, 13);
            this.lblScreenWidthCaption.TabIndex = 31;
            this.lblScreenWidthCaption.Text = "Width:";
            // 
            // lblScreenLeftCaption
            // 
            this.lblScreenLeftCaption.AutoSize = true;
            this.lblScreenLeftCaption.Location = new System.Drawing.Point(335, 152);
            this.lblScreenLeftCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblScreenLeftCaption.Name = "lblScreenLeftCaption";
            this.lblScreenLeftCaption.Size = new System.Drawing.Size(28, 13);
            this.lblScreenLeftCaption.TabIndex = 31;
            this.lblScreenLeftCaption.Text = "Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 105);
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
            this.txtDeviceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensBindingSource, "DeviceName", true));
            this.txtDeviceName.Location = new System.Drawing.Point(338, 124);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(105, 20);
            this.txtDeviceName.TabIndex = 30;
            // 
            // txtScreenName
            // 
            this.txtScreenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensBindingSource, "Name", true));
            this.txtScreenName.Location = new System.Drawing.Point(172, 124);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(160, 20);
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
            this.listBox1.Size = new System.Drawing.Size(160, 269);
            this.listBox1.TabIndex = 0;
            // 
            // tabWindowActions
            // 
            this.tabWindowActions.Controls.Add(this.txtWindowActionWindow);
            this.tabWindowActions.Controls.Add(this.lblWindowActionCaption);
            this.tabWindowActions.Controls.Add(this.btnNewWindowAction);
            this.tabWindowActions.Controls.Add(this.btnWindowActionTest);
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
            this.tabWindowActions.Controls.Add(this.lblWindowActionScreenCaption);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionTopUnit);
            this.tabWindowActions.Controls.Add(this.lblWindowActionVirtualDesktop);
            this.tabWindowActions.Controls.Add(this.cmbWindowActionLeftUnit);
            this.tabWindowActions.Controls.Add(this.cmbWindowPositioning);
            this.tabWindowActions.Controls.Add(this.cmdWindowActionScreen);
            this.tabWindowActions.Controls.Add(this.btnDeleteWindowAction);
            this.tabWindowActions.Controls.Add(this.listWindowAction);
            this.tabWindowActions.Location = new System.Drawing.Point(4, 22);
            this.tabWindowActions.Name = "tabWindowActions";
            this.tabWindowActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabWindowActions.Size = new System.Drawing.Size(449, 356);
            this.tabWindowActions.TabIndex = 1;
            this.tabWindowActions.Text = "Window Actions";
            this.tabWindowActions.UseVisualStyleBackColor = true;
            // 
            // txtWindowActionWindow
            // 
            this.txtWindowActionWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowsBindingSource, "Window", true));
            this.txtWindowActionWindow.Location = new System.Drawing.Point(6, 55);
            this.txtWindowActionWindow.Name = "txtWindowActionWindow";
            this.txtWindowActionWindow.Size = new System.Drawing.Size(160, 20);
            this.txtWindowActionWindow.TabIndex = 41;
            // 
            // windowsBindingSource
            // 
            this.windowsBindingSource.DataMember = "Windows";
            this.windowsBindingSource.DataSource = this.layoutsBindingSource;
            // 
            // lblWindowActionCaption
            // 
            this.lblWindowActionCaption.AutoSize = true;
            this.lblWindowActionCaption.Location = new System.Drawing.Point(6, 36);
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
            // btnWindowActionTest
            // 
            this.btnWindowActionTest.Location = new System.Drawing.Point(172, 6);
            this.btnWindowActionTest.Name = "btnWindowActionTest";
            this.btnWindowActionTest.Size = new System.Drawing.Size(160, 23);
            this.btnWindowActionTest.TabIndex = 38;
            this.btnWindowActionTest.Text = "Test Action";
            this.btnWindowActionTest.UseVisualStyleBackColor = true;
            this.btnWindowActionTest.Click += new System.EventHandler(this.TestWindowActionHandler);
            // 
            // numWindowActionBottom
            // 
            this.numWindowActionBottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowsBindingSource, "Bottom", true));
            this.numWindowActionBottom.Location = new System.Drawing.Point(172, 327);
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
            this.numWindowActionRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowsBindingSource, "Right", true));
            this.numWindowActionRight.Location = new System.Drawing.Point(172, 282);
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
            this.numWindowActionTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowsBindingSource, "Top", true));
            this.numWindowActionTop.Location = new System.Drawing.Point(172, 237);
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
            this.numWindowActionLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowsBindingSource, "Left", true));
            this.numWindowActionLeft.Location = new System.Drawing.Point(172, 192);
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
            this.lblWindowActionBottomCaption.Location = new System.Drawing.Point(169, 308);
            this.lblWindowActionBottomCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionBottomCaption.Name = "lblWindowActionBottomCaption";
            this.lblWindowActionBottomCaption.Size = new System.Drawing.Size(43, 13);
            this.lblWindowActionBottomCaption.TabIndex = 35;
            this.lblWindowActionBottomCaption.Text = "Bottom:";
            // 
            // lblWindowActionRightCaption
            // 
            this.lblWindowActionRightCaption.AutoSize = true;
            this.lblWindowActionRightCaption.Location = new System.Drawing.Point(169, 263);
            this.lblWindowActionRightCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionRightCaption.Name = "lblWindowActionRightCaption";
            this.lblWindowActionRightCaption.Size = new System.Drawing.Size(35, 13);
            this.lblWindowActionRightCaption.TabIndex = 35;
            this.lblWindowActionRightCaption.Text = "Right:";
            // 
            // lblWindowActionTopCaption
            // 
            this.lblWindowActionTopCaption.AutoSize = true;
            this.lblWindowActionTopCaption.Location = new System.Drawing.Point(169, 218);
            this.lblWindowActionTopCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionTopCaption.Name = "lblWindowActionTopCaption";
            this.lblWindowActionTopCaption.Size = new System.Drawing.Size(29, 13);
            this.lblWindowActionTopCaption.TabIndex = 35;
            this.lblWindowActionTopCaption.Text = "Top:";
            // 
            // numWindowActionVirtualDesktop
            // 
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowsBindingSource, "VirtualDesktop", true));
            this.numWindowActionVirtualDesktop.Location = new System.Drawing.Point(172, 55);
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
            this.lblWindowActionLeftCaption.Location = new System.Drawing.Point(169, 173);
            this.lblWindowActionLeftCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionLeftCaption.Name = "lblWindowActionLeftCaption";
            this.lblWindowActionLeftCaption.Size = new System.Drawing.Size(28, 13);
            this.lblWindowActionLeftCaption.TabIndex = 35;
            this.lblWindowActionLeftCaption.Text = "Left:";
            // 
            // cmbWindowActionBottomUnit
            // 
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowsBindingSource, "BottomUnit", true));
            this.cmbWindowActionBottomUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionBottomUnit.FormattingEnabled = true;
            this.cmbWindowActionBottomUnit.Location = new System.Drawing.Point(272, 326);
            this.cmbWindowActionBottomUnit.Name = "cmbWindowActionBottomUnit";
            this.cmbWindowActionBottomUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionBottomUnit.TabIndex = 34;
            // 
            // lblWindowPositioningCaption
            // 
            this.lblWindowPositioningCaption.AutoSize = true;
            this.lblWindowPositioningCaption.Location = new System.Drawing.Point(169, 127);
            this.lblWindowPositioningCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowPositioningCaption.Name = "lblWindowPositioningCaption";
            this.lblWindowPositioningCaption.Size = new System.Drawing.Size(61, 13);
            this.lblWindowPositioningCaption.TabIndex = 35;
            this.lblWindowPositioningCaption.Text = "Positioning:";
            // 
            // cmbWindowActionRightUnit
            // 
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowsBindingSource, "RightUnit", true));
            this.cmbWindowActionRightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionRightUnit.FormattingEnabled = true;
            this.cmbWindowActionRightUnit.Location = new System.Drawing.Point(272, 281);
            this.cmbWindowActionRightUnit.Name = "cmbWindowActionRightUnit";
            this.cmbWindowActionRightUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionRightUnit.TabIndex = 34;
            // 
            // lblWindowActionScreenCaption
            // 
            this.lblWindowActionScreenCaption.AutoSize = true;
            this.lblWindowActionScreenCaption.Location = new System.Drawing.Point(169, 81);
            this.lblWindowActionScreenCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionScreenCaption.Name = "lblWindowActionScreenCaption";
            this.lblWindowActionScreenCaption.Size = new System.Drawing.Size(44, 13);
            this.lblWindowActionScreenCaption.TabIndex = 35;
            this.lblWindowActionScreenCaption.Text = "Screen:";
            // 
            // cmbWindowActionTopUnit
            // 
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowsBindingSource, "TopUnit", true));
            this.cmbWindowActionTopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionTopUnit.FormattingEnabled = true;
            this.cmbWindowActionTopUnit.Location = new System.Drawing.Point(272, 236);
            this.cmbWindowActionTopUnit.Name = "cmbWindowActionTopUnit";
            this.cmbWindowActionTopUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionTopUnit.TabIndex = 34;
            // 
            // lblWindowActionVirtualDesktop
            // 
            this.lblWindowActionVirtualDesktop.AutoSize = true;
            this.lblWindowActionVirtualDesktop.Location = new System.Drawing.Point(169, 36);
            this.lblWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3);
            this.lblWindowActionVirtualDesktop.Name = "lblWindowActionVirtualDesktop";
            this.lblWindowActionVirtualDesktop.Size = new System.Drawing.Size(82, 13);
            this.lblWindowActionVirtualDesktop.TabIndex = 35;
            this.lblWindowActionVirtualDesktop.Text = "Virtual Desktop:";
            // 
            // cmbWindowActionLeftUnit
            // 
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowsBindingSource, "LeftUnit", true));
            this.cmbWindowActionLeftUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionLeftUnit.FormattingEnabled = true;
            this.cmbWindowActionLeftUnit.Location = new System.Drawing.Point(272, 191);
            this.cmbWindowActionLeftUnit.Name = "cmbWindowActionLeftUnit";
            this.cmbWindowActionLeftUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbWindowActionLeftUnit.TabIndex = 34;
            // 
            // cmbWindowPositioning
            // 
            this.cmbWindowPositioning.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowsBindingSource, "Positioning", true));
            this.cmbWindowPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowPositioning.FormattingEnabled = true;
            this.cmbWindowPositioning.Location = new System.Drawing.Point(172, 146);
            this.cmbWindowPositioning.Name = "cmbWindowPositioning";
            this.cmbWindowPositioning.Size = new System.Drawing.Size(160, 21);
            this.cmbWindowPositioning.TabIndex = 34;
            // 
            // cmdWindowActionScreen
            // 
            this.cmdWindowActionScreen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowsBindingSource, "Screen", true));
            this.cmdWindowActionScreen.DataSource = this.screensBindingSource;
            this.cmdWindowActionScreen.DisplayMember = "Name";
            this.cmdWindowActionScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdWindowActionScreen.FormattingEnabled = true;
            this.cmdWindowActionScreen.Location = new System.Drawing.Point(172, 100);
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
            this.listWindowAction.DataSource = this.windowsBindingSource;
            this.listWindowAction.FormattingEnabled = true;
            this.listWindowAction.IntegralHeight = false;
            this.listWindowAction.Location = new System.Drawing.Point(6, 81);
            this.listWindowAction.Name = "listWindowAction";
            this.listWindowAction.Size = new System.Drawing.Size(160, 269);
            this.listWindowAction.TabIndex = 32;
            // 
            // lblLayoutNameCaption
            // 
            this.lblLayoutNameCaption.AutoSize = true;
            this.lblLayoutNameCaption.Location = new System.Drawing.Point(6, 48);
            this.lblLayoutNameCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblLayoutNameCaption.Name = "lblLayoutNameCaption";
            this.lblLayoutNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblLayoutNameCaption.TabIndex = 29;
            this.lblLayoutNameCaption.Text = "Name:";
            // 
            // txtLayoutName
            // 
            this.txtLayoutName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Name", true));
            this.txtLayoutName.Location = new System.Drawing.Point(6, 67);
            this.txtLayoutName.Name = "txtLayoutName";
            this.txtLayoutName.Size = new System.Drawing.Size(160, 20);
            this.txtLayoutName.TabIndex = 28;
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Location = new System.Drawing.Point(88, 19);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteLayout.TabIndex = 27;
            this.btnDeleteLayout.Text = "Delete";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.DeleteLayoutHandler);
            // 
            // btnNewLayout
            // 
            this.btnNewLayout.Location = new System.Drawing.Point(6, 19);
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
            this.listLayouts.Location = new System.Drawing.Point(6, 93);
            this.listLayouts.Name = "listLayouts";
            this.listLayouts.Size = new System.Drawing.Size(160, 308);
            this.listLayouts.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.grpLayouts);
            this.Controls.Add(this.grpWindowPatterns);
            this.Controls.Add(this.lblWindowListCaption);
            this.Controls.Add(this.listWindows);
            this.Controls.Add(this.btnListTopWindows);
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "MainForm";
            this.Text = "WinMan";
            this.Load += new System.EventHandler(this.LoadHandler);
            this.grpWindowPatterns.ResumeLayout(false);
            this.grpWindowPatterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).EndInit();
            this.grpLayouts.ResumeLayout(false);
            this.grpLayouts.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.windowsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListTopWindows;
        private System.Windows.Forms.ListView listWindows;
        private System.Windows.Forms.ColumnHeader colHandle;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colWindowClass;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colScreen;
        private System.Windows.Forms.ColumnHeader colVirtualDesktop;
        private System.Windows.Forms.ColumnHeader colProcess;
        private System.Windows.Forms.Label lblWindowListCaption;
        private System.Windows.Forms.GroupBox grpWindowPatterns;
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
        private System.Windows.Forms.Label lblProcessFileNameCaption;
        private System.Windows.Forms.BindingSource windowPatternsBindingSource;
        private System.Windows.Forms.BindingSource workspaceBindingSource;
        private System.Windows.Forms.ColumnHeader colMatch;
        private System.Windows.Forms.GroupBox grpLayouts;
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
        private System.Windows.Forms.BindingSource windowsBindingSource;
        private System.Windows.Forms.NumericUpDown numWindowActionVirtualDesktop;
        private System.Windows.Forms.Label lblWindowActionVirtualDesktop;
        private System.Windows.Forms.ComboBox cmdWindowActionScreen;
        private System.Windows.Forms.Label lblWindowActionScreenCaption;
        private System.Windows.Forms.Label lblWindowPositioningCaption;
        private System.Windows.Forms.ComboBox cmbWindowPositioning;
        private System.Windows.Forms.NumericUpDown numWindowActionLeft;
        private System.Windows.Forms.Label lblWindowActionLeftCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionLeftUnit;
        private System.Windows.Forms.Button btnWindowActionTest;
        private System.Windows.Forms.NumericUpDown numWindowActionTop;
        private System.Windows.Forms.Label lblWindowActionTopCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionTopUnit;
        private System.Windows.Forms.NumericUpDown numWindowActionBottom;
        private System.Windows.Forms.NumericUpDown numWindowActionRight;
        private System.Windows.Forms.Label lblWindowActionBottomCaption;
        private System.Windows.Forms.Label lblWindowActionRightCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionBottomUnit;
        private System.Windows.Forms.ComboBox cmbWindowActionRightUnit;
        private System.Windows.Forms.TextBox txtWindowActionWindow;
        private System.Windows.Forms.Label lblWindowActionCaption;
        private System.Windows.Forms.Button btnNewWindowAction;
    }
}

