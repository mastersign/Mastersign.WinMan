namespace Mastersign.WinMan.Gui
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
            System.Windows.Forms.TableLayoutPanel tableConfigurationPatterns;
            System.Windows.Forms.TableLayoutPanel tableConfigurationPatternList;
            System.Windows.Forms.TableLayoutPanel tableConfigurationPatternDetails;
            System.Windows.Forms.TableLayoutPanel tableWindowPatterns;
            System.Windows.Forms.TableLayoutPanel tblWindowPatternsActions;
            System.Windows.Forms.TableLayoutPanel tableLayouts;
            System.Windows.Forms.TableLayoutPanel tableLayoutList;
            System.Windows.Forms.TableLayoutPanel tableLayoutDetails;
            System.Windows.Forms.TableLayoutPanel tblWindowActionActions;
            System.Windows.Forms.TableLayoutPanel tableLayoutOptions;
            System.Windows.Forms.Label lblRestoration;
            System.Windows.Forms.Label lblOsWindowMarginCaption;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDeleteConfiguration = new System.Windows.Forms.Button();
            this.btnSortConfigurations = new System.Windows.Forms.Button();
            this.btnMoveDownConfiguration = new System.Windows.Forms.Button();
            this.btnMoveUpConfiguration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfigurationIsMatch = new System.Windows.Forms.Label();
            this.configurationPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkRespectVirtualDesktopCount = new System.Windows.Forms.CheckBox();
            this.numVirtualDesktopCount = new System.Windows.Forms.NumericUpDown();
            this.lblVirtualDesktopsCaption = new System.Windows.Forms.Label();
            this.btnRecordConfiguration = new System.Windows.Forms.Button();
            this.lblConfigurationNameCaption = new System.Windows.Forms.Label();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.listConfigurationPatterns = new System.Windows.Forms.ListBox();
            this.previewConfiguration = new Mastersign.WinMan.PreviewCanvas();
            this.chkRespectSize = new System.Windows.Forms.CheckBox();
            this.screensPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblScreenMatches = new System.Windows.Forms.Label();
            this.lblScreenMatchesCaption = new System.Windows.Forms.Label();
            this.numScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.listScreenPatterns = new System.Windows.Forms.ListBox();
            this.lblScreenHeightCaption = new System.Windows.Forms.Label();
            this.numScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.lblScreenTopCaption = new System.Windows.Forms.Label();
            this.lblScreenWidthCaption = new System.Windows.Forms.Label();
            this.numScreenTop = new System.Windows.Forms.NumericUpDown();
            this.numScreenLeft = new System.Windows.Forms.NumericUpDown();
            this.lblScreensCaption = new System.Windows.Forms.Label();
            this.lblScreenNameCaption = new System.Windows.Forms.Label();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.lblScreenDeviceNameCaption = new System.Windows.Forms.Label();
            this.lblScreenLeftCaption = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.chkRespectPosition = new System.Windows.Forms.CheckBox();
            this.btnNewWindowPatternFromTemplate = new System.Windows.Forms.Button();
            this.lblAppId = new System.Windows.Forms.Label();
            this.windowPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.lblRestoreTimeoutCaption = new System.Windows.Forms.Label();
            this.listWindows = new System.Windows.Forms.ListView();
            this.colMatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWindowClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScreen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVirtualDesktop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAppId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReloadWindowList = new System.Windows.Forms.Button();
            this.lblWindowPatternsCaption = new System.Windows.Forms.Label();
            this.lblRestoreWorkingDir = new System.Windows.Forms.Label();
            this.txtRestoreWorkingDir = new System.Windows.Forms.TextBox();
            this.listWindowPatterns = new System.Windows.Forms.ListBox();
            this.lblWindowPatternName = new System.Windows.Forms.Label();
            this.chkWindowClassIgnoreCase = new System.Windows.Forms.CheckBox();
            this.txtRestoreCommandArgs = new System.Windows.Forms.TextBox();
            this.txtWindowPatternName = new System.Windows.Forms.TextBox();
            this.txtRestoreCommand = new System.Windows.Forms.TextBox();
            this.lblRestoreCommandArgs = new System.Windows.Forms.Label();
            this.lblRestoreCommand = new System.Windows.Forms.Label();
            this.chkTitleIgnoreCase = new System.Windows.Forms.CheckBox();
            this.cmbWindowClassPatternType = new System.Windows.Forms.ComboBox();
            this.txtTitlePattern = new System.Windows.Forms.TextBox();
            this.txtProcessFileName = new System.Windows.Forms.TextBox();
            this.lblProcessFileName = new System.Windows.Forms.Label();
            this.lblTitlePatternCaption = new System.Windows.Forms.Label();
            this.cmbTitlePatternType = new System.Windows.Forms.ComboBox();
            this.txtWindowClassPattern = new System.Windows.Forms.TextBox();
            this.lblWindowClassPatternCaption = new System.Windows.Forms.Label();
            this.btnNewWindowPattern = new System.Windows.Forms.Button();
            this.btnDeleteWindowPattern = new System.Windows.Forms.Button();
            this.btnDuplicateWindowPattern = new System.Windows.Forms.Button();
            this.btnSortWindowPatterns = new System.Windows.Forms.Button();
            this.btnMoveDownWindowPattern = new System.Windows.Forms.Button();
            this.btnMoveUpWindowPattern = new System.Windows.Forms.Button();
            this.numWindowPatternRestorationTimeout = new System.Windows.Forms.NumericUpDown();
            this.chkOverrideRestorationTimeout = new System.Windows.Forms.CheckBox();
            this.radClassicApp = new System.Windows.Forms.RadioButton();
            this.radModernApp = new System.Windows.Forms.RadioButton();
            this.rasterChooser = new Mastersign.WinMan.Gui.RasterChooser();
            this.previewLayout = new Mastersign.WinMan.PreviewCanvas();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.btnDuplicateLayout = new System.Windows.Forms.Button();
            this.btnSortLayouts = new System.Windows.Forms.Button();
            this.btnMoveDownLayout = new System.Windows.Forms.Button();
            this.btnMoveUpLayout = new System.Windows.Forms.Button();
            this.btnNewLayout = new System.Windows.Forms.Button();
            this.lblLayoutNameCaption = new System.Windows.Forms.Label();
            this.txtLayoutName = new System.Windows.Forms.TextBox();
            this.layoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkLayoutIsDefaultLayout = new System.Windows.Forms.CheckBox();
            this.lblConfigurationPatternCaption = new System.Windows.Forms.Label();
            this.cmbLayoutConfiguration = new System.Windows.Forms.ComboBox();
            this.listLayouts = new System.Windows.Forms.ListBox();
            this.lblLayoutDefaultVirtualDesktopCaption = new System.Windows.Forms.Label();
            this.numLayoutDefaultVirtualDesktop = new System.Windows.Forms.NumericUpDown();
            this.chkAllVirtualDesktops = new System.Windows.Forms.CheckBox();
            this.windowActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkOverrideDefaultVirtualDesktop = new System.Windows.Forms.CheckBox();
            this.lblWindowActionsCaption = new System.Windows.Forms.Label();
            this.chkWindowActionBottomInvert = new System.Windows.Forms.CheckBox();
            this.chkWindowActionCompensateOsMargin = new System.Windows.Forms.CheckBox();
            this.chkWindowActionRightInvert = new System.Windows.Forms.CheckBox();
            this.btnNewWindowAction = new System.Windows.Forms.Button();
            this.chkWindowActionTopInvert = new System.Windows.Forms.CheckBox();
            this.chkWindowActionLeftInvert = new System.Windows.Forms.CheckBox();
            this.listWindowAction = new System.Windows.Forms.ListBox();
            this.cmbWindowActionBottomUnit = new System.Windows.Forms.ComboBox();
            this.numWindowActionBottom = new System.Windows.Forms.NumericUpDown();
            this.cmbWindowActionRightUnit = new System.Windows.Forms.ComboBox();
            this.cmbWindowActionTopUnit = new System.Windows.Forms.ComboBox();
            this.numWindowActionRight = new System.Windows.Forms.NumericUpDown();
            this.cmbWindowActionLeftUnit = new System.Windows.Forms.ComboBox();
            this.chkWindowActionRestore = new System.Windows.Forms.CheckBox();
            this.numWindowActionTop = new System.Windows.Forms.NumericUpDown();
            this.cmbWindowActionWindow = new System.Windows.Forms.ComboBox();
            this.numWindowActionLeft = new System.Windows.Forms.NumericUpDown();
            this.lblWindowActionWindowCaption = new System.Windows.Forms.Label();
            this.lblWindowActionVirtualDesktop = new System.Windows.Forms.Label();
            this.numWindowActionVirtualDesktop = new System.Windows.Forms.NumericUpDown();
            this.lblWindowActionBottomCaption = new System.Windows.Forms.Label();
            this.lblWindowActionScreenCaption = new System.Windows.Forms.Label();
            this.lblWindowActionRightCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionScreen = new System.Windows.Forms.ComboBox();
            this.lblWindowActionTopCaption = new System.Windows.Forms.Label();
            this.lblWindowActionWindowStateCaption = new System.Windows.Forms.Label();
            this.lblWindowActionLeftCaption = new System.Windows.Forms.Label();
            this.cmbWindowActionWindowState = new System.Windows.Forms.ComboBox();
            this.btnRecordWindowPosition = new System.Windows.Forms.Button();
            this.btnDeleteWindowAction = new System.Windows.Forms.Button();
            this.btnDuplicateWindowAction = new System.Windows.Forms.Button();
            this.btnSortWindowActions = new System.Windows.Forms.Button();
            this.btnMoveDownWindowAction = new System.Windows.Forms.Button();
            this.btnMoveUpWindowAction = new System.Windows.Forms.Button();
            this.tableLayoutOsWindowMargin = new System.Windows.Forms.TableLayoutPanel();
            this.numRestorationTimeout = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginBottom = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginRight = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginTop = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginLeft = new System.Windows.Forms.NumericUpDown();
            this.lblOsWindowMarginBottom = new System.Windows.Forms.Label();
            this.lblOsWindowMarginRight = new System.Windows.Forms.Label();
            this.lblOsWindowMarginTop = new System.Windows.Forms.Label();
            this.lblOsWindowMarginLeft = new System.Windows.Forms.Label();
            this.lblRestorationTimeoutCaption = new System.Windows.Forms.Label();
            this.tsmiNewExplorerWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewCmdWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewPowerShellWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpConfigurationPatterns = new System.Windows.Forms.TabPage();
            this.tpWindowPatterns = new System.Windows.Forms.TabPage();
            this.tpLayouts = new System.Windows.Forms.TabPage();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNewWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveWorkspaceAs = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbKillWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyCurrentLayout = new System.Windows.Forms.ToolStripButton();
            this.tsbKillCurrentLayout = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyWindowAction = new System.Windows.Forms.ToolStripButton();
            this.tsbKillWindowAction = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.windowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsWindowPatternTemplates = new System.Windows.Forms.ContextMenuStrip(this.components);
            tableConfigurationPatterns = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatternList = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatternDetails = new System.Windows.Forms.TableLayoutPanel();
            tableWindowPatterns = new System.Windows.Forms.TableLayoutPanel();
            tblWindowPatternsActions = new System.Windows.Forms.TableLayoutPanel();
            tableLayouts = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutList = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutDetails = new System.Windows.Forms.TableLayoutPanel();
            tblWindowActionActions = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutOptions = new System.Windows.Forms.TableLayoutPanel();
            lblRestoration = new System.Windows.Forms.Label();
            lblOsWindowMarginCaption = new System.Windows.Forms.Label();
            tableConfigurationPatterns.SuspendLayout();
            tableConfigurationPatternList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).BeginInit();
            tableConfigurationPatternDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).BeginInit();
            tableWindowPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).BeginInit();
            tblWindowPatternsActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowPatternRestorationTimeout)).BeginInit();
            tableLayouts.SuspendLayout();
            tableLayoutList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayoutDefaultVirtualDesktop)).BeginInit();
            tableLayoutDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).BeginInit();
            tblWindowActionActions.SuspendLayout();
            tableLayoutOptions.SuspendLayout();
            this.tableLayoutOsWindowMargin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestorationTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginLeft)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpConfigurationPatterns.SuspendLayout();
            this.tpWindowPatterns.SuspendLayout();
            this.tpLayouts.SuspendLayout();
            this.tpOptions.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsBindingSource)).BeginInit();
            this.cmsWindowPatternTemplates.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableConfigurationPatterns
            // 
            tableConfigurationPatterns.ColumnCount = 2;
            tableConfigurationPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableConfigurationPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableConfigurationPatterns.Controls.Add(tableConfigurationPatternList, 0, 0);
            tableConfigurationPatterns.Controls.Add(this.previewConfiguration, 1, 0);
            tableConfigurationPatterns.Controls.Add(tableConfigurationPatternDetails, 1, 1);
            tableConfigurationPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatterns.Location = new System.Drawing.Point(3, 4);
            tableConfigurationPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableConfigurationPatterns.Name = "tableConfigurationPatterns";
            tableConfigurationPatterns.RowCount = 2;
            tableConfigurationPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableConfigurationPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tableConfigurationPatterns.Size = new System.Drawing.Size(967, 618);
            tableConfigurationPatterns.TabIndex = 0;
            // 
            // tableConfigurationPatternList
            // 
            tableConfigurationPatternList.ColumnCount = 3;
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableConfigurationPatternList.Controls.Add(this.btnDeleteConfiguration, 2, 6);
            tableConfigurationPatternList.Controls.Add(this.btnSortConfigurations, 2, 5);
            tableConfigurationPatternList.Controls.Add(this.btnMoveDownConfiguration, 2, 4);
            tableConfigurationPatternList.Controls.Add(this.btnMoveUpConfiguration, 2, 3);
            tableConfigurationPatternList.Controls.Add(this.label1, 0, 11);
            tableConfigurationPatternList.Controls.Add(this.lblConfigurationIsMatch, 1, 11);
            tableConfigurationPatternList.Controls.Add(this.chkRespectVirtualDesktopCount, 0, 10);
            tableConfigurationPatternList.Controls.Add(this.numVirtualDesktopCount, 0, 9);
            tableConfigurationPatternList.Controls.Add(this.lblVirtualDesktopsCaption, 0, 8);
            tableConfigurationPatternList.Controls.Add(this.btnRecordConfiguration, 0, 0);
            tableConfigurationPatternList.Controls.Add(this.lblConfigurationNameCaption, 0, 1);
            tableConfigurationPatternList.Controls.Add(this.txtConfigurationName, 0, 2);
            tableConfigurationPatternList.Controls.Add(this.listConfigurationPatterns, 0, 3);
            tableConfigurationPatternList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatternList.Location = new System.Drawing.Point(3, 4);
            tableConfigurationPatternList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableConfigurationPatternList.Name = "tableConfigurationPatternList";
            tableConfigurationPatternList.RowCount = 12;
            tableConfigurationPatterns.SetRowSpan(tableConfigurationPatternList, 2);
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.Size = new System.Drawing.Size(235, 610);
            tableConfigurationPatternList.TabIndex = 0;
            // 
            // btnDeleteConfiguration
            // 
            this.btnDeleteConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteConfiguration.Location = new System.Drawing.Point(200, 198);
            this.btnDeleteConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteConfiguration.Name = "btnDeleteConfiguration";
            this.btnDeleteConfiguration.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDeleteConfiguration.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteConfiguration.TabIndex = 1;
            this.btnDeleteConfiguration.Text = "x";
            this.btnDeleteConfiguration.UseVisualStyleBackColor = true;
            this.btnDeleteConfiguration.Click += new System.EventHandler(this.DeleteConfigurationHandler);
            // 
            // btnSortConfigurations
            // 
            this.btnSortConfigurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortConfigurations.Location = new System.Drawing.Point(200, 164);
            this.btnSortConfigurations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortConfigurations.Name = "btnSortConfigurations";
            this.btnSortConfigurations.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSortConfigurations.Size = new System.Drawing.Size(32, 30);
            this.btnSortConfigurations.TabIndex = 4;
            this.btnSortConfigurations.Text = "s";
            this.btnSortConfigurations.UseVisualStyleBackColor = true;
            this.btnSortConfigurations.Click += new System.EventHandler(this.SortConfigurationsHandler);
            // 
            // btnMoveDownConfiguration
            // 
            this.btnMoveDownConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDownConfiguration.Location = new System.Drawing.Point(200, 130);
            this.btnMoveDownConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownConfiguration.Name = "btnMoveDownConfiguration";
            this.btnMoveDownConfiguration.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveDownConfiguration.Size = new System.Drawing.Size(32, 30);
            this.btnMoveDownConfiguration.TabIndex = 3;
            this.btnMoveDownConfiguration.Text = "v";
            this.btnMoveDownConfiguration.UseVisualStyleBackColor = true;
            this.btnMoveDownConfiguration.Click += new System.EventHandler(this.MoveDownConfigurationHandler);
            // 
            // btnMoveUpConfiguration
            // 
            this.btnMoveUpConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUpConfiguration.Location = new System.Drawing.Point(200, 96);
            this.btnMoveUpConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpConfiguration.Name = "btnMoveUpConfiguration";
            this.btnMoveUpConfiguration.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveUpConfiguration.Size = new System.Drawing.Size(32, 30);
            this.btnMoveUpConfiguration.TabIndex = 2;
            this.btnMoveUpConfiguration.Text = "^";
            this.btnMoveUpConfiguration.UseVisualStyleBackColor = true;
            this.btnMoveUpConfiguration.Click += new System.EventHandler(this.MoveUpConfigurationHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Is Match:";
            // 
            // lblConfigurationIsMatch
            // 
            this.lblConfigurationIsMatch.AutoSize = true;
            this.lblConfigurationIsMatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationPatternsBindingSource, "Matches", true));
            this.lblConfigurationIsMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfigurationIsMatch.Location = new System.Drawing.Point(179, 590);
            this.lblConfigurationIsMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblConfigurationIsMatch.Name = "lblConfigurationIsMatch";
            this.lblConfigurationIsMatch.Size = new System.Drawing.Size(15, 16);
            this.lblConfigurationIsMatch.TabIndex = 9;
            this.lblConfigurationIsMatch.Text = "?";
            this.lblConfigurationIsMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // configurationPatternsBindingSource
            // 
            this.configurationPatternsBindingSource.DataMember = "ConfigurationPatterns";
            this.configurationPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.configurationPatternsBindingSource.CurrentChanged += new System.EventHandler(this.ConfigurationPatternSelectionChangedHandler);
            this.configurationPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedConfigurationPatternChanged);
            this.configurationPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ConfigurationPatternsListChangedHandler);
            // 
            // workspaceBindingSource
            // 
            this.workspaceBindingSource.DataSource = typeof(Mastersign.WinMan.Workspace);
            // 
            // chkRespectVirtualDesktopCount
            // 
            this.chkRespectVirtualDesktopCount.AutoSize = true;
            tableConfigurationPatternList.SetColumnSpan(this.chkRespectVirtualDesktopCount, 2);
            this.chkRespectVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationPatternsBindingSource, "RespectVirtualDesktopCount", true));
            this.chkRespectVirtualDesktopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkRespectVirtualDesktopCount.Location = new System.Drawing.Point(3, 562);
            this.chkRespectVirtualDesktopCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRespectVirtualDesktopCount.Name = "chkRespectVirtualDesktopCount";
            this.chkRespectVirtualDesktopCount.Size = new System.Drawing.Size(191, 20);
            this.chkRespectVirtualDesktopCount.TabIndex = 6;
            this.chkRespectVirtualDesktopCount.Text = "Respect VD Count";
            this.chkRespectVirtualDesktopCount.UseVisualStyleBackColor = true;
            // 
            // numVirtualDesktopCount
            // 
            tableConfigurationPatternList.SetColumnSpan(this.numVirtualDesktopCount, 2);
            this.numVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurationPatternsBindingSource, "VirtualDesktopCount", true));
            this.numVirtualDesktopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVirtualDesktopCount.Location = new System.Drawing.Point(3, 532);
            this.numVirtualDesktopCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVirtualDesktopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVirtualDesktopCount.Name = "numVirtualDesktopCount";
            this.numVirtualDesktopCount.Size = new System.Drawing.Size(191, 22);
            this.numVirtualDesktopCount.TabIndex = 5;
            this.numVirtualDesktopCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVirtualDesktopsCaption
            // 
            this.lblVirtualDesktopsCaption.AutoSize = true;
            tableConfigurationPatternList.SetColumnSpan(this.lblVirtualDesktopsCaption, 2);
            this.lblVirtualDesktopsCaption.Location = new System.Drawing.Point(3, 508);
            this.lblVirtualDesktopsCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblVirtualDesktopsCaption.Name = "lblVirtualDesktopsCaption";
            this.lblVirtualDesktopsCaption.Size = new System.Drawing.Size(109, 16);
            this.lblVirtualDesktopsCaption.TabIndex = 4;
            this.lblVirtualDesktopsCaption.Text = "Virtual Desktops:";
            // 
            // btnRecordConfiguration
            // 
            this.btnRecordConfiguration.AutoSize = true;
            tableConfigurationPatternList.SetColumnSpan(this.btnRecordConfiguration, 2);
            this.btnRecordConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecordConfiguration.Location = new System.Drawing.Point(3, 4);
            this.btnRecordConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecordConfiguration.Name = "btnRecordConfiguration";
            this.btnRecordConfiguration.Padding = new System.Windows.Forms.Padding(2);
            this.btnRecordConfiguration.Size = new System.Drawing.Size(191, 30);
            this.btnRecordConfiguration.TabIndex = 0;
            this.btnRecordConfiguration.Text = "Record Configuration";
            this.btnRecordConfiguration.UseVisualStyleBackColor = true;
            this.btnRecordConfiguration.Click += new System.EventHandler(this.RecordConfigurationHandler);
            // 
            // lblConfigurationNameCaption
            // 
            this.lblConfigurationNameCaption.AutoSize = true;
            tableConfigurationPatternList.SetColumnSpan(this.lblConfigurationNameCaption, 2);
            this.lblConfigurationNameCaption.Location = new System.Drawing.Point(3, 42);
            this.lblConfigurationNameCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblConfigurationNameCaption.Name = "lblConfigurationNameCaption";
            this.lblConfigurationNameCaption.Size = new System.Drawing.Size(48, 16);
            this.lblConfigurationNameCaption.TabIndex = 2;
            this.lblConfigurationNameCaption.Text = "Name:";
            // 
            // txtConfigurationName
            // 
            tableConfigurationPatternList.SetColumnSpan(this.txtConfigurationName, 2);
            this.txtConfigurationName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtConfigurationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfigurationName.Location = new System.Drawing.Point(3, 66);
            this.txtConfigurationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(191, 22);
            this.txtConfigurationName.TabIndex = 3;
            // 
            // listConfigurationPatterns
            // 
            tableConfigurationPatternList.SetColumnSpan(this.listConfigurationPatterns, 2);
            this.listConfigurationPatterns.DataSource = this.configurationPatternsBindingSource;
            this.listConfigurationPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConfigurationPatterns.FormattingEnabled = true;
            this.listConfigurationPatterns.IntegralHeight = false;
            this.listConfigurationPatterns.ItemHeight = 16;
            this.listConfigurationPatterns.Location = new System.Drawing.Point(3, 96);
            this.listConfigurationPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listConfigurationPatterns.Name = "listConfigurationPatterns";
            tableConfigurationPatternList.SetRowSpan(this.listConfigurationPatterns, 5);
            this.listConfigurationPatterns.Size = new System.Drawing.Size(191, 404);
            this.listConfigurationPatterns.TabIndex = 7;
            // 
            // previewConfiguration
            // 
            this.previewConfiguration.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewConfiguration.Location = new System.Drawing.Point(244, 4);
            this.previewConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewConfiguration.Name = "previewConfiguration";
            this.previewConfiguration.Size = new System.Drawing.Size(720, 270);
            this.previewConfiguration.TabIndex = 1;
            this.previewConfiguration.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfigurationPreviewPaintHandler);
            // 
            // tableConfigurationPatternDetails
            // 
            tableConfigurationPatternDetails.ColumnCount = 4;
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableConfigurationPatternDetails.Controls.Add(this.chkRespectSize, 3, 5);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenMatches, 2, 7);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenMatchesCaption, 1, 7);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenHeight, 2, 6);
            tableConfigurationPatternDetails.Controls.Add(this.listScreenPatterns, 0, 1);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenHeightCaption, 1, 6);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenWidth, 2, 5);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenTopCaption, 1, 4);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenWidthCaption, 1, 5);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenTop, 2, 4);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenLeft, 2, 3);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreensCaption, 0, 0);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenNameCaption, 1, 1);
            tableConfigurationPatternDetails.Controls.Add(this.txtScreenName, 2, 1);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenDeviceNameCaption, 1, 2);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenLeftCaption, 1, 3);
            tableConfigurationPatternDetails.Controls.Add(this.txtDeviceName, 2, 2);
            tableConfigurationPatternDetails.Controls.Add(this.chkRespectPosition, 3, 3);
            tableConfigurationPatternDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatternDetails.Location = new System.Drawing.Point(244, 282);
            tableConfigurationPatternDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableConfigurationPatternDetails.Name = "tableConfigurationPatternDetails";
            tableConfigurationPatternDetails.RowCount = 9;
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableConfigurationPatternDetails.Size = new System.Drawing.Size(720, 332);
            tableConfigurationPatternDetails.TabIndex = 2;
            // 
            // chkRespectSize
            // 
            this.chkRespectSize.AutoSize = true;
            this.chkRespectSize.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.screensPatternsBindingSource, "RespectSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkRespectSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkRespectSize.Location = new System.Drawing.Point(515, 147);
            this.chkRespectSize.Name = "chkRespectSize";
            this.chkRespectSize.Size = new System.Drawing.Size(202, 24);
            this.chkRespectSize.TabIndex = 22;
            this.chkRespectSize.Text = "Respect Size";
            this.chkRespectSize.UseVisualStyleBackColor = true;
            // 
            // screensPatternsBindingSource
            // 
            this.screensPatternsBindingSource.DataMember = "Screens";
            this.screensPatternsBindingSource.DataSource = this.configurationPatternsBindingSource;
            this.screensPatternsBindingSource.CurrentChanged += new System.EventHandler(this.ScreenPatternSelectionChanged);
            this.screensPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedScreenPatternChanged);
            // 
            // lblScreenMatches
            // 
            this.lblScreenMatches.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "Matches", true));
            this.lblScreenMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenMatches.Location = new System.Drawing.Point(309, 208);
            this.lblScreenMatches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenMatches.Name = "lblScreenMatches";
            this.lblScreenMatches.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblScreenMatches.Size = new System.Drawing.Size(200, 22);
            this.lblScreenMatches.TabIndex = 19;
            this.lblScreenMatches.Text = "0";
            this.lblScreenMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScreenMatchesCaption
            // 
            this.lblScreenMatchesCaption.AutoSize = true;
            this.lblScreenMatchesCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenMatchesCaption.Location = new System.Drawing.Point(209, 208);
            this.lblScreenMatchesCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenMatchesCaption.Name = "lblScreenMatchesCaption";
            this.lblScreenMatchesCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenMatchesCaption.TabIndex = 14;
            this.lblScreenMatchesCaption.Text = "Is Match:";
            this.lblScreenMatchesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numScreenHeight
            // 
            this.numScreenHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.screensPatternsBindingSource, "Height", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numScreenHeight.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectSize", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numScreenHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenHeight.Location = new System.Drawing.Point(309, 178);
            this.numScreenHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numScreenHeight.Size = new System.Drawing.Size(200, 22);
            this.numScreenHeight.TabIndex = 13;
            // 
            // listScreenPatterns
            // 
            this.listScreenPatterns.DataSource = this.screensPatternsBindingSource;
            this.listScreenPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScreenPatterns.FormattingEnabled = true;
            this.listScreenPatterns.IntegralHeight = false;
            this.listScreenPatterns.ItemHeight = 16;
            this.listScreenPatterns.Location = new System.Drawing.Point(3, 28);
            this.listScreenPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listScreenPatterns.Name = "listScreenPatterns";
            tableConfigurationPatternDetails.SetRowSpan(this.listScreenPatterns, 8);
            this.listScreenPatterns.Size = new System.Drawing.Size(200, 300);
            this.listScreenPatterns.TabIndex = 1;
            // 
            // lblScreenHeightCaption
            // 
            this.lblScreenHeightCaption.AutoSize = true;
            this.lblScreenHeightCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectSize", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblScreenHeightCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenHeightCaption.Enabled = false;
            this.lblScreenHeightCaption.Location = new System.Drawing.Point(209, 178);
            this.lblScreenHeightCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenHeightCaption.Name = "lblScreenHeightCaption";
            this.lblScreenHeightCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenHeightCaption.TabIndex = 12;
            this.lblScreenHeightCaption.Text = "Height:";
            this.lblScreenHeightCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numScreenWidth
            // 
            this.numScreenWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.screensPatternsBindingSource, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numScreenWidth.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectSize", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numScreenWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenWidth.Location = new System.Drawing.Point(309, 148);
            this.numScreenWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numScreenWidth.Size = new System.Drawing.Size(200, 22);
            this.numScreenWidth.TabIndex = 11;
            // 
            // lblScreenTopCaption
            // 
            this.lblScreenTopCaption.AutoSize = true;
            this.lblScreenTopCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectPosition", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblScreenTopCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenTopCaption.Enabled = false;
            this.lblScreenTopCaption.Location = new System.Drawing.Point(209, 118);
            this.lblScreenTopCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenTopCaption.Name = "lblScreenTopCaption";
            this.lblScreenTopCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenTopCaption.TabIndex = 8;
            this.lblScreenTopCaption.Text = "Top:";
            this.lblScreenTopCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScreenWidthCaption
            // 
            this.lblScreenWidthCaption.AutoSize = true;
            this.lblScreenWidthCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectSize", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblScreenWidthCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenWidthCaption.Enabled = false;
            this.lblScreenWidthCaption.Location = new System.Drawing.Point(209, 148);
            this.lblScreenWidthCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenWidthCaption.Name = "lblScreenWidthCaption";
            this.lblScreenWidthCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenWidthCaption.TabIndex = 10;
            this.lblScreenWidthCaption.Text = "Width:";
            this.lblScreenWidthCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numScreenTop
            // 
            this.numScreenTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.screensPatternsBindingSource, "Top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numScreenTop.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectPosition", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numScreenTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenTop.Location = new System.Drawing.Point(309, 118);
            this.numScreenTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numScreenTop.Size = new System.Drawing.Size(200, 22);
            this.numScreenTop.TabIndex = 9;
            // 
            // numScreenLeft
            // 
            this.numScreenLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.screensPatternsBindingSource, "Left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numScreenLeft.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectPosition", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numScreenLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenLeft.Location = new System.Drawing.Point(309, 88);
            this.numScreenLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numScreenLeft.Size = new System.Drawing.Size(200, 22);
            this.numScreenLeft.TabIndex = 7;
            // 
            // lblScreensCaption
            // 
            this.lblScreensCaption.AutoSize = true;
            this.lblScreensCaption.Location = new System.Drawing.Point(3, 4);
            this.lblScreensCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreensCaption.Name = "lblScreensCaption";
            this.lblScreensCaption.Size = new System.Drawing.Size(61, 16);
            this.lblScreensCaption.TabIndex = 0;
            this.lblScreensCaption.Text = "Screens:";
            // 
            // lblScreenNameCaption
            // 
            this.lblScreenNameCaption.AutoSize = true;
            this.lblScreenNameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenNameCaption.Location = new System.Drawing.Point(209, 28);
            this.lblScreenNameCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenNameCaption.Name = "lblScreenNameCaption";
            this.lblScreenNameCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenNameCaption.TabIndex = 2;
            this.lblScreenNameCaption.Text = "Name:";
            this.lblScreenNameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScreenName
            // 
            this.txtScreenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtScreenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScreenName.Location = new System.Drawing.Point(309, 28);
            this.txtScreenName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(200, 22);
            this.txtScreenName.TabIndex = 3;
            // 
            // lblScreenDeviceNameCaption
            // 
            this.lblScreenDeviceNameCaption.AutoSize = true;
            this.lblScreenDeviceNameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenDeviceNameCaption.Enabled = false;
            this.lblScreenDeviceNameCaption.Location = new System.Drawing.Point(209, 58);
            this.lblScreenDeviceNameCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenDeviceNameCaption.Name = "lblScreenDeviceNameCaption";
            this.lblScreenDeviceNameCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenDeviceNameCaption.TabIndex = 4;
            this.lblScreenDeviceNameCaption.Text = "Device Name:";
            this.lblScreenDeviceNameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScreenLeftCaption
            // 
            this.lblScreenLeftCaption.AutoSize = true;
            this.lblScreenLeftCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.screensPatternsBindingSource, "RespectPosition", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblScreenLeftCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenLeftCaption.Enabled = false;
            this.lblScreenLeftCaption.Location = new System.Drawing.Point(209, 88);
            this.lblScreenLeftCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblScreenLeftCaption.Name = "lblScreenLeftCaption";
            this.lblScreenLeftCaption.Size = new System.Drawing.Size(94, 22);
            this.lblScreenLeftCaption.TabIndex = 6;
            this.lblScreenLeftCaption.Text = "Left:";
            this.lblScreenLeftCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "DeviceName", true));
            this.txtDeviceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceName.Location = new System.Drawing.Point(309, 58);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(200, 22);
            this.txtDeviceName.TabIndex = 5;
            // 
            // chkRespectPosition
            // 
            this.chkRespectPosition.AutoSize = true;
            this.chkRespectPosition.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.screensPatternsBindingSource, "RespectPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkRespectPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkRespectPosition.Location = new System.Drawing.Point(515, 87);
            this.chkRespectPosition.Name = "chkRespectPosition";
            this.chkRespectPosition.Size = new System.Drawing.Size(202, 24);
            this.chkRespectPosition.TabIndex = 21;
            this.chkRespectPosition.Text = "Respect Position";
            this.chkRespectPosition.UseVisualStyleBackColor = true;
            // 
            // tableWindowPatterns
            // 
            tableWindowPatterns.ColumnCount = 7;
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            tableWindowPatterns.Controls.Add(this.btnNewWindowPatternFromTemplate, 1, 2);
            tableWindowPatterns.Controls.Add(this.lblAppId, 3, 4);
            tableWindowPatterns.Controls.Add(this.txtAppId, 4, 4);
            tableWindowPatterns.Controls.Add(this.lblRestoreTimeoutCaption, 3, 13);
            tableWindowPatterns.Controls.Add(this.listWindows, 0, 0);
            tableWindowPatterns.Controls.Add(this.btnReloadWindowList, 6, 1);
            tableWindowPatterns.Controls.Add(this.lblWindowPatternsCaption, 0, 1);
            tableWindowPatterns.Controls.Add(this.lblRestoreWorkingDir, 3, 12);
            tableWindowPatterns.Controls.Add(this.txtRestoreWorkingDir, 4, 12);
            tableWindowPatterns.Controls.Add(this.listWindowPatterns, 0, 5);
            tableWindowPatterns.Controls.Add(this.lblWindowPatternName, 0, 3);
            tableWindowPatterns.Controls.Add(this.chkWindowClassIgnoreCase, 5, 8);
            tableWindowPatterns.Controls.Add(this.txtRestoreCommandArgs, 4, 11);
            tableWindowPatterns.Controls.Add(this.txtWindowPatternName, 0, 4);
            tableWindowPatterns.Controls.Add(this.txtRestoreCommand, 4, 10);
            tableWindowPatterns.Controls.Add(this.lblRestoreCommandArgs, 3, 11);
            tableWindowPatterns.Controls.Add(this.lblRestoreCommand, 3, 10);
            tableWindowPatterns.Controls.Add(this.chkTitleIgnoreCase, 5, 6);
            tableWindowPatterns.Controls.Add(this.cmbWindowClassPatternType, 4, 8);
            tableWindowPatterns.Controls.Add(this.txtTitlePattern, 4, 5);
            tableWindowPatterns.Controls.Add(this.txtProcessFileName, 4, 9);
            tableWindowPatterns.Controls.Add(this.lblProcessFileName, 3, 9);
            tableWindowPatterns.Controls.Add(this.lblTitlePatternCaption, 3, 5);
            tableWindowPatterns.Controls.Add(this.cmbTitlePatternType, 4, 6);
            tableWindowPatterns.Controls.Add(this.txtWindowClassPattern, 4, 7);
            tableWindowPatterns.Controls.Add(this.lblWindowClassPatternCaption, 3, 7);
            tableWindowPatterns.Controls.Add(this.btnNewWindowPattern, 0, 2);
            tableWindowPatterns.Controls.Add(tblWindowPatternsActions, 2, 5);
            tableWindowPatterns.Controls.Add(this.numWindowPatternRestorationTimeout, 4, 13);
            tableWindowPatterns.Controls.Add(this.chkOverrideRestorationTimeout, 5, 13);
            tableWindowPatterns.Controls.Add(this.radClassicApp, 4, 3);
            tableWindowPatterns.Controls.Add(this.radModernApp, 5, 3);
            tableWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            tableWindowPatterns.Location = new System.Drawing.Point(3, 4);
            tableWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableWindowPatterns.Name = "tableWindowPatterns";
            tableWindowPatterns.RowCount = 15;
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableWindowPatterns.Size = new System.Drawing.Size(967, 618);
            tableWindowPatterns.TabIndex = 0;
            // 
            // btnNewWindowPatternFromTemplate
            // 
            this.btnNewWindowPatternFromTemplate.AutoSize = true;
            this.btnNewWindowPatternFromTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowPatternFromTemplate.Location = new System.Drawing.Point(223, 212);
            this.btnNewWindowPatternFromTemplate.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.btnNewWindowPatternFromTemplate.Name = "btnNewWindowPatternFromTemplate";
            this.btnNewWindowPatternFromTemplate.Padding = new System.Windows.Forms.Padding(2);
            this.btnNewWindowPatternFromTemplate.Size = new System.Drawing.Size(32, 30);
            this.btnNewWindowPatternFromTemplate.TabIndex = 38;
            this.btnNewWindowPatternFromTemplate.Text = "v";
            this.btnNewWindowPatternFromTemplate.UseVisualStyleBackColor = true;
            this.btnNewWindowPatternFromTemplate.Click += new System.EventHandler(this.NewWindowPatternFromTemplateHandler);
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ModernApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblAppId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppId.Location = new System.Drawing.Point(299, 276);
            this.lblAppId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(145, 22);
            this.lblAppId.TabIndex = 37;
            this.lblAppId.Text = "App ID:";
            this.lblAppId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // windowPatternsBindingSource
            // 
            this.windowPatternsBindingSource.DataMember = "WindowPatterns";
            this.windowPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.windowPatternsBindingSource.CurrentChanged += new System.EventHandler(this.WindowPatternSelectionChangedHandler);
            this.windowPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedWindowPatternChangedHandler);
            this.windowPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.WindowPatternListChangedHandler);
            // 
            // txtAppId
            // 
            tableWindowPatterns.SetColumnSpan(this.txtAppId, 3);
            this.txtAppId.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ModernApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtAppId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "AppId", true));
            this.txtAppId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAppId.Location = new System.Drawing.Point(450, 276);
            this.txtAppId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(514, 22);
            this.txtAppId.TabIndex = 36;
            // 
            // lblRestoreTimeoutCaption
            // 
            this.lblRestoreTimeoutCaption.AutoSize = true;
            this.lblRestoreTimeoutCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "OverrideRestorationTimeout", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblRestoreTimeoutCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreTimeoutCaption.Location = new System.Drawing.Point(299, 550);
            this.lblRestoreTimeoutCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreTimeoutCaption.Name = "lblRestoreTimeoutCaption";
            this.lblRestoreTimeoutCaption.Size = new System.Drawing.Size(145, 20);
            this.lblRestoreTimeoutCaption.TabIndex = 31;
            this.lblRestoreTimeoutCaption.Text = "Restoration Timeout:";
            this.lblRestoreTimeoutCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listWindows
            // 
            this.listWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMatch,
            this.colTitle,
            this.colWindowClass,
            this.colProcess,
            this.colScreen,
            this.colVirtualDesktop,
            this.colPosition,
            this.colState,
            this.colAppId});
            tableWindowPatterns.SetColumnSpan(this.listWindows, 7);
            this.listWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindows.FullRowSelect = true;
            this.listWindows.GridLines = true;
            this.listWindows.Location = new System.Drawing.Point(3, 4);
            this.listWindows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWindows.MultiSelect = false;
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(961, 176);
            this.listWindows.TabIndex = 0;
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
            // colAppId
            // 
            this.colAppId.Text = "App ID";
            this.colAppId.Width = 110;
            // 
            // btnReloadWindowList
            // 
            this.btnReloadWindowList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadWindowList.AutoSize = true;
            this.btnReloadWindowList.Location = new System.Drawing.Point(821, 188);
            this.btnReloadWindowList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReloadWindowList.Name = "btnReloadWindowList";
            this.btnReloadWindowList.Padding = new System.Windows.Forms.Padding(2);
            tableWindowPatterns.SetRowSpan(this.btnReloadWindowList, 2);
            this.btnReloadWindowList.Size = new System.Drawing.Size(143, 30);
            this.btnReloadWindowList.TabIndex = 25;
            this.btnReloadWindowList.Text = "Refresh Window List";
            this.btnReloadWindowList.UseVisualStyleBackColor = true;
            this.btnReloadWindowList.Click += new System.EventHandler(this.ReloadWindowListHandler);
            // 
            // lblWindowPatternsCaption
            // 
            this.lblWindowPatternsCaption.AutoSize = true;
            this.lblWindowPatternsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowPatternsCaption.Location = new System.Drawing.Point(3, 188);
            this.lblWindowPatternsCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowPatternsCaption.Name = "lblWindowPatternsCaption";
            this.lblWindowPatternsCaption.Size = new System.Drawing.Size(217, 16);
            this.lblWindowPatternsCaption.TabIndex = 1;
            this.lblWindowPatternsCaption.Text = "Window Patterns:";
            this.lblWindowPatternsCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRestoreWorkingDir
            // 
            this.lblRestoreWorkingDir.AutoSize = true;
            this.lblRestoreWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreWorkingDir.Location = new System.Drawing.Point(299, 520);
            this.lblRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreWorkingDir.Name = "lblRestoreWorkingDir";
            this.lblRestoreWorkingDir.Size = new System.Drawing.Size(145, 22);
            this.lblRestoreWorkingDir.TabIndex = 23;
            this.lblRestoreWorkingDir.Text = "Working Directory:";
            this.lblRestoreWorkingDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRestoreWorkingDir
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreWorkingDir, 3);
            this.txtRestoreWorkingDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WorkingDir", true));
            this.txtRestoreWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreWorkingDir.Location = new System.Drawing.Point(450, 520);
            this.txtRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestoreWorkingDir.Name = "txtRestoreWorkingDir";
            this.txtRestoreWorkingDir.Size = new System.Drawing.Size(514, 22);
            this.txtRestoreWorkingDir.TabIndex = 24;
            // 
            // listWindowPatterns
            // 
            tableWindowPatterns.SetColumnSpan(this.listWindowPatterns, 2);
            this.listWindowPatterns.DataSource = this.windowPatternsBindingSource;
            this.listWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindowPatterns.FormattingEnabled = true;
            this.listWindowPatterns.IntegralHeight = false;
            this.listWindowPatterns.ItemHeight = 16;
            this.listWindowPatterns.Location = new System.Drawing.Point(3, 306);
            this.listWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWindowPatterns.Name = "listWindowPatterns";
            tableWindowPatterns.SetRowSpan(this.listWindowPatterns, 10);
            this.listWindowPatterns.Size = new System.Drawing.Size(252, 308);
            this.listWindowPatterns.TabIndex = 6;
            // 
            // lblWindowPatternName
            // 
            this.lblWindowPatternName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWindowPatternName.AutoSize = true;
            tableWindowPatterns.SetColumnSpan(this.lblWindowPatternName, 2);
            this.lblWindowPatternName.Location = new System.Drawing.Point(3, 252);
            this.lblWindowPatternName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowPatternName.Name = "lblWindowPatternName";
            this.lblWindowPatternName.Size = new System.Drawing.Size(48, 16);
            this.lblWindowPatternName.TabIndex = 4;
            this.lblWindowPatternName.Text = "Name:";
            // 
            // chkWindowClassIgnoreCase
            // 
            this.chkWindowClassIgnoreCase.AutoSize = true;
            this.chkWindowClassIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "WindowClassIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowClassIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.chkWindowClassIgnoreCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowClassIgnoreCase.Location = new System.Drawing.Point(601, 398);
            this.chkWindowClassIgnoreCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowClassIgnoreCase.Name = "chkWindowClassIgnoreCase";
            this.chkWindowClassIgnoreCase.Size = new System.Drawing.Size(145, 24);
            this.chkWindowClassIgnoreCase.TabIndex = 14;
            this.chkWindowClassIgnoreCase.Text = "Ignore Case";
            this.chkWindowClassIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // txtRestoreCommandArgs
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreCommandArgs, 3);
            this.txtRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "CommandArgs", true));
            this.txtRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtRestoreCommandArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreCommandArgs.Location = new System.Drawing.Point(450, 490);
            this.txtRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestoreCommandArgs.Name = "txtRestoreCommandArgs";
            this.txtRestoreCommandArgs.Size = new System.Drawing.Size(514, 22);
            this.txtRestoreCommandArgs.TabIndex = 22;
            // 
            // txtWindowPatternName
            // 
            tableWindowPatterns.SetColumnSpan(this.txtWindowPatternName, 2);
            this.txtWindowPatternName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWindowPatternName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWindowPatternName.Location = new System.Drawing.Point(3, 276);
            this.txtWindowPatternName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWindowPatternName.Name = "txtWindowPatternName";
            this.txtWindowPatternName.Size = new System.Drawing.Size(252, 22);
            this.txtWindowPatternName.TabIndex = 5;
            // 
            // txtRestoreCommand
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreCommand, 3);
            this.txtRestoreCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Command", true));
            this.txtRestoreCommand.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtRestoreCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreCommand.Location = new System.Drawing.Point(450, 460);
            this.txtRestoreCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestoreCommand.Name = "txtRestoreCommand";
            this.txtRestoreCommand.Size = new System.Drawing.Size(514, 22);
            this.txtRestoreCommand.TabIndex = 20;
            // 
            // lblRestoreCommandArgs
            // 
            this.lblRestoreCommandArgs.AutoSize = true;
            this.lblRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblRestoreCommandArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreCommandArgs.Location = new System.Drawing.Point(299, 490);
            this.lblRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreCommandArgs.Name = "lblRestoreCommandArgs";
            this.lblRestoreCommandArgs.Size = new System.Drawing.Size(145, 22);
            this.lblRestoreCommandArgs.TabIndex = 21;
            this.lblRestoreCommandArgs.Text = "Command Args:";
            this.lblRestoreCommandArgs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRestoreCommand
            // 
            this.lblRestoreCommand.AutoSize = true;
            this.lblRestoreCommand.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblRestoreCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreCommand.Location = new System.Drawing.Point(299, 460);
            this.lblRestoreCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreCommand.Name = "lblRestoreCommand";
            this.lblRestoreCommand.Size = new System.Drawing.Size(145, 22);
            this.lblRestoreCommand.TabIndex = 19;
            this.lblRestoreCommand.Text = "Command:";
            this.lblRestoreCommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkTitleIgnoreCase
            // 
            this.chkTitleIgnoreCase.AutoSize = true;
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "TitleIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.chkTitleIgnoreCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTitleIgnoreCase.Location = new System.Drawing.Point(601, 336);
            this.chkTitleIgnoreCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTitleIgnoreCase.Name = "chkTitleIgnoreCase";
            this.chkTitleIgnoreCase.Size = new System.Drawing.Size(145, 24);
            this.chkTitleIgnoreCase.TabIndex = 10;
            this.chkTitleIgnoreCase.Text = "Ignore Case";
            this.chkTitleIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // cmbWindowClassPatternType
            // 
            this.cmbWindowClassPatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "WindowClassPatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowClassPatternType.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbWindowClassPatternType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowClassPatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowClassPatternType.FormattingEnabled = true;
            this.cmbWindowClassPatternType.Location = new System.Drawing.Point(450, 398);
            this.cmbWindowClassPatternType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowClassPatternType.Name = "cmbWindowClassPatternType";
            this.cmbWindowClassPatternType.Size = new System.Drawing.Size(145, 24);
            this.cmbWindowClassPatternType.TabIndex = 13;
            // 
            // txtTitlePattern
            // 
            tableWindowPatterns.SetColumnSpan(this.txtTitlePattern, 3);
            this.txtTitlePattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "TitlePattern", true));
            this.txtTitlePattern.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTitlePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitlePattern.Location = new System.Drawing.Point(450, 306);
            this.txtTitlePattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitlePattern.Name = "txtTitlePattern";
            this.txtTitlePattern.Size = new System.Drawing.Size(514, 22);
            this.txtTitlePattern.TabIndex = 8;
            // 
            // txtProcessFileName
            // 
            tableWindowPatterns.SetColumnSpan(this.txtProcessFileName, 3);
            this.txtProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "ProcessFileName", true));
            this.txtProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtProcessFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcessFileName.Location = new System.Drawing.Point(450, 430);
            this.txtProcessFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessFileName.Name = "txtProcessFileName";
            this.txtProcessFileName.Size = new System.Drawing.Size(514, 22);
            this.txtProcessFileName.TabIndex = 16;
            // 
            // lblProcessFileName
            // 
            this.lblProcessFileName.AutoSize = true;
            this.lblProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblProcessFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessFileName.Location = new System.Drawing.Point(299, 430);
            this.lblProcessFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblProcessFileName.Name = "lblProcessFileName";
            this.lblProcessFileName.Size = new System.Drawing.Size(145, 22);
            this.lblProcessFileName.TabIndex = 15;
            this.lblProcessFileName.Text = "Process File:";
            this.lblProcessFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitlePatternCaption
            // 
            this.lblTitlePatternCaption.AutoSize = true;
            this.lblTitlePatternCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblTitlePatternCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitlePatternCaption.Location = new System.Drawing.Point(299, 306);
            this.lblTitlePatternCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitlePatternCaption.Name = "lblTitlePatternCaption";
            this.lblTitlePatternCaption.Size = new System.Drawing.Size(145, 22);
            this.lblTitlePatternCaption.TabIndex = 7;
            this.lblTitlePatternCaption.Text = "Window Title:";
            this.lblTitlePatternCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTitlePatternType
            // 
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "TitlePatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbTitlePatternType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTitlePatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitlePatternType.FormattingEnabled = true;
            this.cmbTitlePatternType.Location = new System.Drawing.Point(450, 336);
            this.cmbTitlePatternType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTitlePatternType.Name = "cmbTitlePatternType";
            this.cmbTitlePatternType.Size = new System.Drawing.Size(145, 24);
            this.cmbTitlePatternType.TabIndex = 9;
            // 
            // txtWindowClassPattern
            // 
            tableWindowPatterns.SetColumnSpan(this.txtWindowClassPattern, 3);
            this.txtWindowClassPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WindowClassPattern", true));
            this.txtWindowClassPattern.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtWindowClassPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWindowClassPattern.Location = new System.Drawing.Point(450, 368);
            this.txtWindowClassPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWindowClassPattern.Name = "txtWindowClassPattern";
            this.txtWindowClassPattern.Size = new System.Drawing.Size(514, 22);
            this.txtWindowClassPattern.TabIndex = 12;
            // 
            // lblWindowClassPatternCaption
            // 
            this.lblWindowClassPatternCaption.AutoSize = true;
            this.lblWindowClassPatternCaption.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblWindowClassPatternCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowClassPatternCaption.Location = new System.Drawing.Point(299, 368);
            this.lblWindowClassPatternCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowClassPatternCaption.Name = "lblWindowClassPatternCaption";
            this.lblWindowClassPatternCaption.Size = new System.Drawing.Size(145, 22);
            this.lblWindowClassPatternCaption.TabIndex = 11;
            this.lblWindowClassPatternCaption.Text = "Window Class:";
            this.lblWindowClassPatternCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewWindowPattern
            // 
            this.btnNewWindowPattern.AutoSize = true;
            this.btnNewWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowPattern.Location = new System.Drawing.Point(3, 212);
            this.btnNewWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 0, 4);
            this.btnNewWindowPattern.Name = "btnNewWindowPattern";
            this.btnNewWindowPattern.Padding = new System.Windows.Forms.Padding(2);
            this.btnNewWindowPattern.Size = new System.Drawing.Size(220, 30);
            this.btnNewWindowPattern.TabIndex = 2;
            this.btnNewWindowPattern.Text = "New Window Pattern";
            this.btnNewWindowPattern.UseVisualStyleBackColor = true;
            this.btnNewWindowPattern.Click += new System.EventHandler(this.NewWindowPatternHandler);
            // 
            // tblWindowPatternsActions
            // 
            tblWindowPatternsActions.AutoSize = true;
            tblWindowPatternsActions.ColumnCount = 1;
            tblWindowPatternsActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblWindowPatternsActions.Controls.Add(this.btnDeleteWindowPattern, 0, 4);
            tblWindowPatternsActions.Controls.Add(this.btnDuplicateWindowPattern, 0, 3);
            tblWindowPatternsActions.Controls.Add(this.btnSortWindowPatterns, 0, 2);
            tblWindowPatternsActions.Controls.Add(this.btnMoveDownWindowPattern, 0, 1);
            tblWindowPatternsActions.Controls.Add(this.btnMoveUpWindowPattern, 0, 0);
            tblWindowPatternsActions.Dock = System.Windows.Forms.DockStyle.Fill;
            tblWindowPatternsActions.Location = new System.Drawing.Point(258, 302);
            tblWindowPatternsActions.Margin = new System.Windows.Forms.Padding(0);
            tblWindowPatternsActions.Name = "tblWindowPatternsActions";
            tblWindowPatternsActions.RowCount = 6;
            tableWindowPatterns.SetRowSpan(tblWindowPatternsActions, 10);
            tblWindowPatternsActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowPatternsActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowPatternsActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowPatternsActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowPatternsActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowPatternsActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblWindowPatternsActions.Size = new System.Drawing.Size(38, 316);
            tblWindowPatternsActions.TabIndex = 30;
            // 
            // btnDeleteWindowPattern
            // 
            this.btnDeleteWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteWindowPattern.Location = new System.Drawing.Point(3, 140);
            this.btnDeleteWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteWindowPattern.Name = "btnDeleteWindowPattern";
            this.btnDeleteWindowPattern.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDeleteWindowPattern.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteWindowPattern.TabIndex = 3;
            this.btnDeleteWindowPattern.Text = "x";
            this.btnDeleteWindowPattern.UseVisualStyleBackColor = true;
            this.btnDeleteWindowPattern.Click += new System.EventHandler(this.DeleteWindowPatternHandler);
            // 
            // btnDuplicateWindowPattern
            // 
            this.btnDuplicateWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicateWindowPattern.Location = new System.Drawing.Point(3, 106);
            this.btnDuplicateWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDuplicateWindowPattern.Name = "btnDuplicateWindowPattern";
            this.btnDuplicateWindowPattern.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDuplicateWindowPattern.Size = new System.Drawing.Size(32, 30);
            this.btnDuplicateWindowPattern.TabIndex = 28;
            this.btnDuplicateWindowPattern.Text = "d";
            this.btnDuplicateWindowPattern.UseVisualStyleBackColor = true;
            this.btnDuplicateWindowPattern.Click += new System.EventHandler(this.DuplicateWindowPatternHandler);
            // 
            // btnSortWindowPatterns
            // 
            this.btnSortWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortWindowPatterns.Location = new System.Drawing.Point(3, 72);
            this.btnSortWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortWindowPatterns.Name = "btnSortWindowPatterns";
            this.btnSortWindowPatterns.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSortWindowPatterns.Size = new System.Drawing.Size(32, 30);
            this.btnSortWindowPatterns.TabIndex = 29;
            this.btnSortWindowPatterns.Text = "s";
            this.btnSortWindowPatterns.UseVisualStyleBackColor = true;
            this.btnSortWindowPatterns.Click += new System.EventHandler(this.SortWindowPatternsHandler);
            // 
            // btnMoveDownWindowPattern
            // 
            this.btnMoveDownWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDownWindowPattern.Location = new System.Drawing.Point(3, 38);
            this.btnMoveDownWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownWindowPattern.Name = "btnMoveDownWindowPattern";
            this.btnMoveDownWindowPattern.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveDownWindowPattern.Size = new System.Drawing.Size(32, 30);
            this.btnMoveDownWindowPattern.TabIndex = 27;
            this.btnMoveDownWindowPattern.Text = "v";
            this.btnMoveDownWindowPattern.UseVisualStyleBackColor = true;
            this.btnMoveDownWindowPattern.Click += new System.EventHandler(this.MoveDownWindowPatternHandler);
            // 
            // btnMoveUpWindowPattern
            // 
            this.btnMoveUpWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUpWindowPattern.Location = new System.Drawing.Point(3, 4);
            this.btnMoveUpWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpWindowPattern.Name = "btnMoveUpWindowPattern";
            this.btnMoveUpWindowPattern.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveUpWindowPattern.Size = new System.Drawing.Size(32, 30);
            this.btnMoveUpWindowPattern.TabIndex = 26;
            this.btnMoveUpWindowPattern.Text = "^";
            this.btnMoveUpWindowPattern.UseVisualStyleBackColor = true;
            this.btnMoveUpWindowPattern.Click += new System.EventHandler(this.MoveUpWindowPatternHandler);
            // 
            // numWindowPatternRestorationTimeout
            // 
            this.numWindowPatternRestorationTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowPatternsBindingSource, "RestorationTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowPatternRestorationTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowPatternsBindingSource, "OverrideRestorationTimeout", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numWindowPatternRestorationTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowPatternRestorationTimeout.Location = new System.Drawing.Point(450, 549);
            this.numWindowPatternRestorationTimeout.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numWindowPatternRestorationTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowPatternRestorationTimeout.Name = "numWindowPatternRestorationTimeout";
            this.numWindowPatternRestorationTimeout.Size = new System.Drawing.Size(145, 22);
            this.numWindowPatternRestorationTimeout.TabIndex = 32;
            this.numWindowPatternRestorationTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkOverrideRestorationTimeout
            // 
            this.chkOverrideRestorationTimeout.AutoSize = true;
            this.chkOverrideRestorationTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "OverrideRestorationTimeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOverrideRestorationTimeout.Location = new System.Drawing.Point(601, 549);
            this.chkOverrideRestorationTimeout.Name = "chkOverrideRestorationTimeout";
            this.chkOverrideRestorationTimeout.Size = new System.Drawing.Size(124, 20);
            this.chkOverrideRestorationTimeout.TabIndex = 33;
            this.chkOverrideRestorationTimeout.Text = "Override Default";
            this.chkOverrideRestorationTimeout.UseVisualStyleBackColor = true;
            // 
            // radClassicApp
            // 
            this.radClassicApp.AutoSize = true;
            this.radClassicApp.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "ClassicApp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radClassicApp.Location = new System.Drawing.Point(450, 249);
            this.radClassicApp.Name = "radClassicApp";
            this.radClassicApp.Size = new System.Drawing.Size(98, 20);
            this.radClassicApp.TabIndex = 34;
            this.radClassicApp.TabStop = true;
            this.radClassicApp.Text = "Classic App";
            this.radClassicApp.UseVisualStyleBackColor = true;
            // 
            // radModernApp
            // 
            this.radModernApp.AutoSize = true;
            this.radModernApp.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "ModernApp", true));
            this.radModernApp.Location = new System.Drawing.Point(601, 249);
            this.radModernApp.Name = "radModernApp";
            this.radModernApp.Size = new System.Drawing.Size(100, 20);
            this.radModernApp.TabIndex = 35;
            this.radModernApp.TabStop = true;
            this.radModernApp.Text = "Modern App";
            this.radModernApp.UseVisualStyleBackColor = true;
            // 
            // tableLayouts
            // 
            tableLayouts.ColumnCount = 3;
            tableLayouts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayouts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayouts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            tableLayouts.Controls.Add(this.rasterChooser, 2, 0);
            tableLayouts.Controls.Add(this.previewLayout, 1, 0);
            tableLayouts.Controls.Add(tableLayoutList, 0, 0);
            tableLayouts.Controls.Add(tableLayoutDetails, 1, 1);
            tableLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayouts.Location = new System.Drawing.Point(3, 4);
            tableLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayouts.Name = "tableLayouts";
            tableLayouts.RowCount = 2;
            tableLayouts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayouts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayouts.Size = new System.Drawing.Size(967, 618);
            tableLayouts.TabIndex = 0;
            // 
            // rasterChooser
            // 
            this.rasterChooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rasterChooser.Location = new System.Drawing.Point(884, 0);
            this.rasterChooser.Margin = new System.Windows.Forms.Padding(0);
            this.rasterChooser.Name = "rasterChooser";
            this.rasterChooser.Size = new System.Drawing.Size(83, 247);
            this.rasterChooser.TabIndex = 38;
            this.rasterChooser.MouseEnter += new System.EventHandler(this.RasterChooserMouseEnterHandler);
            this.rasterChooser.MouseLeave += new System.EventHandler(this.RasterChooserMouseLeaveHandler);
            // 
            // previewLayout
            // 
            this.previewLayout.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewLayout.Location = new System.Drawing.Point(224, 4);
            this.previewLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(657, 239);
            this.previewLayout.TabIndex = 1;
            this.previewLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.PreviewLayoutPaintHandler);
            this.previewLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviewLayoutMouseDownHandler);
            this.previewLayout.MouseEnter += new System.EventHandler(this.PreviewLayoutMouseEnterHandler);
            this.previewLayout.MouseLeave += new System.EventHandler(this.PreviewLayoutMouseLeaveHandler);
            this.previewLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PreviewLayoutMouseMoveHandler);
            this.previewLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PreviewLayoutMouseUpHandler);
            // 
            // tableLayoutList
            // 
            tableLayoutList.ColumnCount = 2;
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayoutList.Controls.Add(this.btnDeleteLayout, 1, 7);
            tableLayoutList.Controls.Add(this.btnDuplicateLayout, 1, 6);
            tableLayoutList.Controls.Add(this.btnSortLayouts, 1, 5);
            tableLayoutList.Controls.Add(this.btnMoveDownLayout, 1, 4);
            tableLayoutList.Controls.Add(this.btnMoveUpLayout, 1, 3);
            tableLayoutList.Controls.Add(this.btnNewLayout, 0, 0);
            tableLayoutList.Controls.Add(this.lblLayoutNameCaption, 0, 1);
            tableLayoutList.Controls.Add(this.txtLayoutName, 0, 2);
            tableLayoutList.Controls.Add(this.chkLayoutIsDefaultLayout, 0, 9);
            tableLayoutList.Controls.Add(this.lblConfigurationPatternCaption, 0, 10);
            tableLayoutList.Controls.Add(this.cmbLayoutConfiguration, 0, 11);
            tableLayoutList.Controls.Add(this.listLayouts, 0, 3);
            tableLayoutList.Controls.Add(this.lblLayoutDefaultVirtualDesktopCaption, 0, 12);
            tableLayoutList.Controls.Add(this.numLayoutDefaultVirtualDesktop, 0, 13);
            tableLayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutList.Location = new System.Drawing.Point(3, 4);
            tableLayoutList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutList.Name = "tableLayoutList";
            tableLayoutList.RowCount = 14;
            tableLayouts.SetRowSpan(tableLayoutList, 2);
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.Size = new System.Drawing.Size(215, 610);
            tableLayoutList.TabIndex = 0;
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteLayout.Location = new System.Drawing.Point(180, 232);
            this.btnDeleteLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDeleteLayout.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteLayout.TabIndex = 1;
            this.btnDeleteLayout.Text = "x";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.DeleteLayoutHandler);
            // 
            // btnDuplicateLayout
            // 
            this.btnDuplicateLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicateLayout.Enabled = false;
            this.btnDuplicateLayout.Location = new System.Drawing.Point(180, 198);
            this.btnDuplicateLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDuplicateLayout.Name = "btnDuplicateLayout";
            this.btnDuplicateLayout.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDuplicateLayout.Size = new System.Drawing.Size(32, 30);
            this.btnDuplicateLayout.TabIndex = 29;
            this.btnDuplicateLayout.Text = "d";
            this.btnDuplicateLayout.UseVisualStyleBackColor = true;
            this.btnDuplicateLayout.Click += new System.EventHandler(this.DuplicateLayoutHandler);
            // 
            // btnSortLayouts
            // 
            this.btnSortLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortLayouts.Location = new System.Drawing.Point(180, 164);
            this.btnSortLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortLayouts.Name = "btnSortLayouts";
            this.btnSortLayouts.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSortLayouts.Size = new System.Drawing.Size(32, 30);
            this.btnSortLayouts.TabIndex = 30;
            this.btnSortLayouts.Text = "s";
            this.btnSortLayouts.UseVisualStyleBackColor = true;
            this.btnSortLayouts.Click += new System.EventHandler(this.SortLayoutsHandler);
            // 
            // btnMoveDownLayout
            // 
            this.btnMoveDownLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDownLayout.Location = new System.Drawing.Point(180, 130);
            this.btnMoveDownLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownLayout.Name = "btnMoveDownLayout";
            this.btnMoveDownLayout.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveDownLayout.Size = new System.Drawing.Size(32, 30);
            this.btnMoveDownLayout.TabIndex = 28;
            this.btnMoveDownLayout.Text = "v";
            this.btnMoveDownLayout.UseVisualStyleBackColor = true;
            this.btnMoveDownLayout.Click += new System.EventHandler(this.MoveDownLayoutHandler);
            // 
            // btnMoveUpLayout
            // 
            this.btnMoveUpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUpLayout.Location = new System.Drawing.Point(180, 96);
            this.btnMoveUpLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpLayout.Name = "btnMoveUpLayout";
            this.btnMoveUpLayout.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveUpLayout.Size = new System.Drawing.Size(32, 30);
            this.btnMoveUpLayout.TabIndex = 27;
            this.btnMoveUpLayout.Text = "^";
            this.btnMoveUpLayout.UseVisualStyleBackColor = true;
            this.btnMoveUpLayout.Click += new System.EventHandler(this.MoveUpLayoutHandler);
            // 
            // btnNewLayout
            // 
            this.btnNewLayout.AutoSize = true;
            this.btnNewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewLayout.Location = new System.Drawing.Point(3, 4);
            this.btnNewLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewLayout.Name = "btnNewLayout";
            this.btnNewLayout.Padding = new System.Windows.Forms.Padding(2);
            this.btnNewLayout.Size = new System.Drawing.Size(171, 30);
            this.btnNewLayout.TabIndex = 0;
            this.btnNewLayout.Text = "New Layout";
            this.btnNewLayout.UseVisualStyleBackColor = true;
            this.btnNewLayout.Click += new System.EventHandler(this.NewLayoutHandler);
            // 
            // lblLayoutNameCaption
            // 
            this.lblLayoutNameCaption.AutoSize = true;
            this.lblLayoutNameCaption.Location = new System.Drawing.Point(3, 42);
            this.lblLayoutNameCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLayoutNameCaption.Name = "lblLayoutNameCaption";
            this.lblLayoutNameCaption.Size = new System.Drawing.Size(48, 16);
            this.lblLayoutNameCaption.TabIndex = 2;
            this.lblLayoutNameCaption.Text = "Name:";
            // 
            // txtLayoutName
            // 
            this.txtLayoutName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLayoutName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLayoutName.Location = new System.Drawing.Point(3, 66);
            this.txtLayoutName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLayoutName.Name = "txtLayoutName";
            this.txtLayoutName.Size = new System.Drawing.Size(171, 22);
            this.txtLayoutName.TabIndex = 3;
            // 
            // layoutsBindingSource
            // 
            this.layoutsBindingSource.DataMember = "Layouts";
            this.layoutsBindingSource.DataSource = this.workspaceBindingSource;
            this.layoutsBindingSource.CurrentChanged += new System.EventHandler(this.LayoutSelectionChangedHandler);
            this.layoutsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedLayoutChangedHandler);
            // 
            // chkLayoutIsDefaultLayout
            // 
            this.chkLayoutIsDefaultLayout.AutoSize = true;
            this.chkLayoutIsDefaultLayout.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutsBindingSource, "DefaultLayout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLayoutIsDefaultLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLayoutIsDefaultLayout.Location = new System.Drawing.Point(3, 479);
            this.chkLayoutIsDefaultLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLayoutIsDefaultLayout.Name = "chkLayoutIsDefaultLayout";
            this.chkLayoutIsDefaultLayout.Size = new System.Drawing.Size(171, 20);
            this.chkLayoutIsDefaultLayout.TabIndex = 4;
            this.chkLayoutIsDefaultLayout.Text = "Default Layout";
            this.chkLayoutIsDefaultLayout.UseVisualStyleBackColor = true;
            // 
            // lblConfigurationPatternCaption
            // 
            this.lblConfigurationPatternCaption.AutoSize = true;
            this.lblConfigurationPatternCaption.Location = new System.Drawing.Point(3, 507);
            this.lblConfigurationPatternCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblConfigurationPatternCaption.Name = "lblConfigurationPatternCaption";
            this.lblConfigurationPatternCaption.Size = new System.Drawing.Size(134, 16);
            this.lblConfigurationPatternCaption.TabIndex = 5;
            this.lblConfigurationPatternCaption.Text = "Configuration Pattern:";
            // 
            // cmbLayoutConfiguration
            // 
            this.cmbLayoutConfiguration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Configuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbLayoutConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLayoutConfiguration.FormattingEnabled = true;
            this.cmbLayoutConfiguration.Location = new System.Drawing.Point(3, 531);
            this.cmbLayoutConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLayoutConfiguration.Name = "cmbLayoutConfiguration";
            this.cmbLayoutConfiguration.Size = new System.Drawing.Size(171, 24);
            this.cmbLayoutConfiguration.TabIndex = 6;
            // 
            // listLayouts
            // 
            this.listLayouts.DataSource = this.layoutsBindingSource;
            this.listLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLayouts.FormattingEnabled = true;
            this.listLayouts.IntegralHeight = false;
            this.listLayouts.ItemHeight = 16;
            this.listLayouts.Location = new System.Drawing.Point(3, 96);
            this.listLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listLayouts.Name = "listLayouts";
            tableLayoutList.SetRowSpan(this.listLayouts, 6);
            this.listLayouts.Size = new System.Drawing.Size(171, 375);
            this.listLayouts.TabIndex = 7;
            // 
            // lblLayoutDefaultVirtualDesktopCaption
            // 
            this.lblLayoutDefaultVirtualDesktopCaption.AutoSize = true;
            this.lblLayoutDefaultVirtualDesktopCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLayoutDefaultVirtualDesktopCaption.Location = new System.Drawing.Point(3, 560);
            this.lblLayoutDefaultVirtualDesktopCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLayoutDefaultVirtualDesktopCaption.Name = "lblLayoutDefaultVirtualDesktopCaption";
            this.lblLayoutDefaultVirtualDesktopCaption.Size = new System.Drawing.Size(171, 16);
            this.lblLayoutDefaultVirtualDesktopCaption.TabIndex = 32;
            this.lblLayoutDefaultVirtualDesktopCaption.Text = "Standard Virtual Desktop:";
            this.lblLayoutDefaultVirtualDesktopCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numLayoutDefaultVirtualDesktop
            // 
            this.numLayoutDefaultVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.layoutsBindingSource, "DefaultVirtualDesktop", true));
            this.numLayoutDefaultVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLayoutDefaultVirtualDesktop.Location = new System.Drawing.Point(3, 584);
            this.numLayoutDefaultVirtualDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numLayoutDefaultVirtualDesktop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayoutDefaultVirtualDesktop.Name = "numLayoutDefaultVirtualDesktop";
            this.numLayoutDefaultVirtualDesktop.Size = new System.Drawing.Size(171, 22);
            this.numLayoutDefaultVirtualDesktop.TabIndex = 33;
            this.numLayoutDefaultVirtualDesktop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 6;
            tableLayouts.SetColumnSpan(tableLayoutDetails, 2);
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            tableLayoutDetails.Controls.Add(this.chkAllVirtualDesktops, 4, 3);
            tableLayoutDetails.Controls.Add(this.chkOverrideDefaultVirtualDesktop, 5, 3);
            tableLayoutDetails.Controls.Add(this.lblWindowActionsCaption, 0, 0);
            tableLayoutDetails.Controls.Add(this.chkWindowActionBottomInvert, 5, 9);
            tableLayoutDetails.Controls.Add(this.chkWindowActionCompensateOsMargin, 3, 10);
            tableLayoutDetails.Controls.Add(this.chkWindowActionRightInvert, 5, 8);
            tableLayoutDetails.Controls.Add(this.btnNewWindowAction, 0, 1);
            tableLayoutDetails.Controls.Add(this.chkWindowActionTopInvert, 5, 7);
            tableLayoutDetails.Controls.Add(this.chkWindowActionLeftInvert, 5, 6);
            tableLayoutDetails.Controls.Add(this.listWindowAction, 0, 2);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionBottomUnit, 4, 9);
            tableLayoutDetails.Controls.Add(this.numWindowActionBottom, 3, 9);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionRightUnit, 4, 8);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionTopUnit, 4, 7);
            tableLayoutDetails.Controls.Add(this.numWindowActionRight, 3, 8);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionLeftUnit, 4, 6);
            tableLayoutDetails.Controls.Add(this.chkWindowActionRestore, 3, 2);
            tableLayoutDetails.Controls.Add(this.numWindowActionTop, 3, 7);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionWindow, 3, 1);
            tableLayoutDetails.Controls.Add(this.numWindowActionLeft, 3, 6);
            tableLayoutDetails.Controls.Add(this.lblWindowActionWindowCaption, 2, 1);
            tableLayoutDetails.Controls.Add(this.lblWindowActionVirtualDesktop, 2, 3);
            tableLayoutDetails.Controls.Add(this.numWindowActionVirtualDesktop, 3, 3);
            tableLayoutDetails.Controls.Add(this.lblWindowActionBottomCaption, 2, 9);
            tableLayoutDetails.Controls.Add(this.lblWindowActionScreenCaption, 2, 4);
            tableLayoutDetails.Controls.Add(this.lblWindowActionRightCaption, 2, 8);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionScreen, 3, 4);
            tableLayoutDetails.Controls.Add(this.lblWindowActionTopCaption, 2, 7);
            tableLayoutDetails.Controls.Add(this.lblWindowActionWindowStateCaption, 2, 5);
            tableLayoutDetails.Controls.Add(this.lblWindowActionLeftCaption, 2, 6);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionWindowState, 3, 5);
            tableLayoutDetails.Controls.Add(this.btnRecordWindowPosition, 5, 2);
            tableLayoutDetails.Controls.Add(tblWindowActionActions, 1, 2);
            tableLayoutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutDetails.Location = new System.Drawing.Point(224, 251);
            tableLayoutDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutDetails.Name = "tableLayoutDetails";
            tableLayoutDetails.RowCount = 12;
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutDetails.Size = new System.Drawing.Size(740, 363);
            tableLayoutDetails.TabIndex = 2;
            // 
            // chkAllVirtualDesktops
            // 
            this.chkAllVirtualDesktops.AutoSize = true;
            this.chkAllVirtualDesktops.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "AllVirtualDesktops", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAllVirtualDesktops.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowActionsBindingSource, "OverrideVirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.chkAllVirtualDesktops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAllVirtualDesktops.Location = new System.Drawing.Point(468, 104);
            this.chkAllVirtualDesktops.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAllVirtualDesktops.Name = "chkAllVirtualDesktops";
            this.chkAllVirtualDesktops.Size = new System.Drawing.Size(99, 22);
            this.chkAllVirtualDesktops.TabIndex = 36;
            this.chkAllVirtualDesktops.Text = "Pin to all";
            this.chkAllVirtualDesktops.UseVisualStyleBackColor = true;
            // 
            // windowActionsBindingSource
            // 
            this.windowActionsBindingSource.DataMember = "Windows";
            this.windowActionsBindingSource.DataSource = this.layoutsBindingSource;
            this.windowActionsBindingSource.CurrentChanged += new System.EventHandler(this.WindowActionSelectionChangedHandler);
            this.windowActionsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedWindowActionChangedHandler);
            // 
            // chkOverrideDefaultVirtualDesktop
            // 
            this.chkOverrideDefaultVirtualDesktop.AutoSize = true;
            this.chkOverrideDefaultVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "OverrideVirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOverrideDefaultVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOverrideDefaultVirtualDesktop.Location = new System.Drawing.Point(573, 104);
            this.chkOverrideDefaultVirtualDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkOverrideDefaultVirtualDesktop.Name = "chkOverrideDefaultVirtualDesktop";
            this.chkOverrideDefaultVirtualDesktop.Size = new System.Drawing.Size(164, 22);
            this.chkOverrideDefaultVirtualDesktop.TabIndex = 34;
            this.chkOverrideDefaultVirtualDesktop.Text = "Override Default";
            this.chkOverrideDefaultVirtualDesktop.UseVisualStyleBackColor = true;
            // 
            // lblWindowActionsCaption
            // 
            this.lblWindowActionsCaption.AutoSize = true;
            this.lblWindowActionsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionsCaption.Location = new System.Drawing.Point(3, 4);
            this.lblWindowActionsCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionsCaption.Name = "lblWindowActionsCaption";
            this.lblWindowActionsCaption.Size = new System.Drawing.Size(190, 16);
            this.lblWindowActionsCaption.TabIndex = 0;
            this.lblWindowActionsCaption.Text = "Window Actions:";
            this.lblWindowActionsCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkWindowActionBottomInvert
            // 
            this.chkWindowActionBottomInvert.AutoSize = true;
            this.chkWindowActionBottomInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "BottomInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionBottomInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionBottomInvert.Location = new System.Drawing.Point(573, 288);
            this.chkWindowActionBottomInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionBottomInvert.Name = "chkWindowActionBottomInvert";
            this.chkWindowActionBottomInvert.Size = new System.Drawing.Size(164, 22);
            this.chkWindowActionBottomInvert.TabIndex = 28;
            this.chkWindowActionBottomInvert.Text = "from Bottom";
            this.chkWindowActionBottomInvert.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionCompensateOsMargin
            // 
            this.chkWindowActionCompensateOsMargin.AutoSize = true;
            tableLayoutDetails.SetColumnSpan(this.chkWindowActionCompensateOsMargin, 2);
            this.chkWindowActionCompensateOsMargin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "CompensateOsMargin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionCompensateOsMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionCompensateOsMargin.Location = new System.Drawing.Point(363, 318);
            this.chkWindowActionCompensateOsMargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionCompensateOsMargin.Name = "chkWindowActionCompensateOsMargin";
            this.chkWindowActionCompensateOsMargin.Size = new System.Drawing.Size(204, 20);
            this.chkWindowActionCompensateOsMargin.TabIndex = 29;
            this.chkWindowActionCompensateOsMargin.Text = "Compensate OS Margin";
            this.chkWindowActionCompensateOsMargin.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionRightInvert
            // 
            this.chkWindowActionRightInvert.AutoSize = true;
            this.chkWindowActionRightInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "RightInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionRightInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionRightInvert.Location = new System.Drawing.Point(573, 258);
            this.chkWindowActionRightInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionRightInvert.Name = "chkWindowActionRightInvert";
            this.chkWindowActionRightInvert.Size = new System.Drawing.Size(164, 22);
            this.chkWindowActionRightInvert.TabIndex = 24;
            this.chkWindowActionRightInvert.Text = "from Right";
            this.chkWindowActionRightInvert.UseVisualStyleBackColor = true;
            // 
            // btnNewWindowAction
            // 
            this.btnNewWindowAction.AutoSize = true;
            this.btnNewWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowAction.Location = new System.Drawing.Point(3, 28);
            this.btnNewWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewWindowAction.Name = "btnNewWindowAction";
            this.btnNewWindowAction.Padding = new System.Windows.Forms.Padding(2);
            this.btnNewWindowAction.Size = new System.Drawing.Size(190, 32);
            this.btnNewWindowAction.TabIndex = 1;
            this.btnNewWindowAction.Text = "New Window Action";
            this.btnNewWindowAction.UseVisualStyleBackColor = true;
            this.btnNewWindowAction.Click += new System.EventHandler(this.NewWindowActionHandler);
            // 
            // chkWindowActionTopInvert
            // 
            this.chkWindowActionTopInvert.AutoSize = true;
            this.chkWindowActionTopInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "TopInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionTopInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionTopInvert.Location = new System.Drawing.Point(573, 228);
            this.chkWindowActionTopInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionTopInvert.Name = "chkWindowActionTopInvert";
            this.chkWindowActionTopInvert.Size = new System.Drawing.Size(164, 22);
            this.chkWindowActionTopInvert.TabIndex = 20;
            this.chkWindowActionTopInvert.Text = "from Bottom";
            this.chkWindowActionTopInvert.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionLeftInvert
            // 
            this.chkWindowActionLeftInvert.AutoSize = true;
            this.chkWindowActionLeftInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "LeftInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionLeftInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionLeftInvert.Location = new System.Drawing.Point(573, 198);
            this.chkWindowActionLeftInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionLeftInvert.Name = "chkWindowActionLeftInvert";
            this.chkWindowActionLeftInvert.Size = new System.Drawing.Size(164, 22);
            this.chkWindowActionLeftInvert.TabIndex = 16;
            this.chkWindowActionLeftInvert.Text = "from Right";
            this.chkWindowActionLeftInvert.UseVisualStyleBackColor = true;
            // 
            // listWindowAction
            // 
            this.listWindowAction.DataSource = this.windowActionsBindingSource;
            this.listWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindowAction.FormattingEnabled = true;
            this.listWindowAction.IntegralHeight = false;
            this.listWindowAction.ItemHeight = 16;
            this.listWindowAction.Location = new System.Drawing.Point(3, 68);
            this.listWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWindowAction.Name = "listWindowAction";
            tableLayoutDetails.SetRowSpan(this.listWindowAction, 10);
            this.listWindowAction.Size = new System.Drawing.Size(190, 291);
            this.listWindowAction.TabIndex = 3;
            // 
            // cmbWindowActionBottomUnit
            // 
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "BottomUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowActionsBindingSource, "BottomUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionBottomUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionBottomUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionBottomUnit.FormattingEnabled = true;
            this.cmbWindowActionBottomUnit.Location = new System.Drawing.Point(468, 288);
            this.cmbWindowActionBottomUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionBottomUnit.Name = "cmbWindowActionBottomUnit";
            this.cmbWindowActionBottomUnit.Size = new System.Drawing.Size(99, 24);
            this.cmbWindowActionBottomUnit.TabIndex = 27;
            // 
            // numWindowActionBottom
            // 
            this.numWindowActionBottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Bottom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionBottom.Location = new System.Drawing.Point(363, 288);
            this.numWindowActionBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numWindowActionBottom.Size = new System.Drawing.Size(99, 22);
            this.numWindowActionBottom.TabIndex = 26;
            // 
            // cmbWindowActionRightUnit
            // 
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "RightUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowActionsBindingSource, "RightUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionRightUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionRightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionRightUnit.FormattingEnabled = true;
            this.cmbWindowActionRightUnit.Location = new System.Drawing.Point(468, 258);
            this.cmbWindowActionRightUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionRightUnit.Name = "cmbWindowActionRightUnit";
            this.cmbWindowActionRightUnit.Size = new System.Drawing.Size(99, 24);
            this.cmbWindowActionRightUnit.TabIndex = 23;
            // 
            // cmbWindowActionTopUnit
            // 
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "TopUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowActionsBindingSource, "TopUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionTopUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionTopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionTopUnit.FormattingEnabled = true;
            this.cmbWindowActionTopUnit.Location = new System.Drawing.Point(468, 228);
            this.cmbWindowActionTopUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionTopUnit.Name = "cmbWindowActionTopUnit";
            this.cmbWindowActionTopUnit.Size = new System.Drawing.Size(99, 24);
            this.cmbWindowActionTopUnit.TabIndex = 19;
            // 
            // numWindowActionRight
            // 
            this.numWindowActionRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Right", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionRight.Location = new System.Drawing.Point(363, 258);
            this.numWindowActionRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numWindowActionRight.Size = new System.Drawing.Size(99, 22);
            this.numWindowActionRight.TabIndex = 22;
            // 
            // cmbWindowActionLeftUnit
            // 
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "LeftUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.windowActionsBindingSource, "LeftUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionLeftUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionLeftUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionLeftUnit.FormattingEnabled = true;
            this.cmbWindowActionLeftUnit.Location = new System.Drawing.Point(468, 198);
            this.cmbWindowActionLeftUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionLeftUnit.Name = "cmbWindowActionLeftUnit";
            this.cmbWindowActionLeftUnit.Size = new System.Drawing.Size(99, 24);
            this.cmbWindowActionLeftUnit.TabIndex = 15;
            // 
            // chkWindowActionRestore
            // 
            this.chkWindowActionRestore.AutoSize = true;
            this.chkWindowActionRestore.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "Restore", true));
            this.chkWindowActionRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionRestore.Location = new System.Drawing.Point(363, 68);
            this.chkWindowActionRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionRestore.Name = "chkWindowActionRestore";
            this.chkWindowActionRestore.Size = new System.Drawing.Size(99, 28);
            this.chkWindowActionRestore.TabIndex = 4;
            this.chkWindowActionRestore.Text = "Restore";
            this.chkWindowActionRestore.UseVisualStyleBackColor = true;
            // 
            // numWindowActionTop
            // 
            this.numWindowActionTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionTop.Location = new System.Drawing.Point(363, 228);
            this.numWindowActionTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numWindowActionTop.Size = new System.Drawing.Size(99, 22);
            this.numWindowActionTop.TabIndex = 18;
            // 
            // cmbWindowActionWindow
            // 
            tableLayoutDetails.SetColumnSpan(this.cmbWindowActionWindow, 2);
            this.cmbWindowActionWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Window", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionWindow.FormattingEnabled = true;
            this.cmbWindowActionWindow.Location = new System.Drawing.Point(363, 28);
            this.cmbWindowActionWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionWindow.Name = "cmbWindowActionWindow";
            this.cmbWindowActionWindow.Size = new System.Drawing.Size(204, 24);
            this.cmbWindowActionWindow.TabIndex = 6;
            // 
            // numWindowActionLeft
            // 
            this.numWindowActionLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionLeft.Location = new System.Drawing.Point(363, 198);
            this.numWindowActionLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numWindowActionLeft.Size = new System.Drawing.Size(99, 22);
            this.numWindowActionLeft.TabIndex = 14;
            // 
            // lblWindowActionWindowCaption
            // 
            this.lblWindowActionWindowCaption.AutoSize = true;
            this.lblWindowActionWindowCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionWindowCaption.Location = new System.Drawing.Point(237, 28);
            this.lblWindowActionWindowCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionWindowCaption.Name = "lblWindowActionWindowCaption";
            this.lblWindowActionWindowCaption.Size = new System.Drawing.Size(120, 32);
            this.lblWindowActionWindowCaption.TabIndex = 5;
            this.lblWindowActionWindowCaption.Text = "Window Pattern:";
            this.lblWindowActionWindowCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionVirtualDesktop
            // 
            this.lblWindowActionVirtualDesktop.AutoSize = true;
            this.lblWindowActionVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionVirtualDesktop.Location = new System.Drawing.Point(237, 104);
            this.lblWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionVirtualDesktop.Name = "lblWindowActionVirtualDesktop";
            this.lblWindowActionVirtualDesktop.Size = new System.Drawing.Size(120, 22);
            this.lblWindowActionVirtualDesktop.TabIndex = 7;
            this.lblWindowActionVirtualDesktop.Text = "Virtual Desktop:";
            this.lblWindowActionVirtualDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numWindowActionVirtualDesktop
            // 
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "VirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.windowActionsBindingSource, "OverrideVirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numWindowActionVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionVirtualDesktop.Location = new System.Drawing.Point(363, 104);
            this.numWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numWindowActionVirtualDesktop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowActionVirtualDesktop.Name = "numWindowActionVirtualDesktop";
            this.numWindowActionVirtualDesktop.Size = new System.Drawing.Size(99, 22);
            this.numWindowActionVirtualDesktop.TabIndex = 8;
            this.numWindowActionVirtualDesktop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWindowActionBottomCaption
            // 
            this.lblWindowActionBottomCaption.AutoSize = true;
            this.lblWindowActionBottomCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionBottomCaption.Location = new System.Drawing.Point(237, 288);
            this.lblWindowActionBottomCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionBottomCaption.Name = "lblWindowActionBottomCaption";
            this.lblWindowActionBottomCaption.Size = new System.Drawing.Size(120, 22);
            this.lblWindowActionBottomCaption.TabIndex = 25;
            this.lblWindowActionBottomCaption.Text = "Bottom:";
            this.lblWindowActionBottomCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionScreenCaption
            // 
            this.lblWindowActionScreenCaption.AutoSize = true;
            this.lblWindowActionScreenCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionScreenCaption.Location = new System.Drawing.Point(237, 134);
            this.lblWindowActionScreenCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionScreenCaption.Name = "lblWindowActionScreenCaption";
            this.lblWindowActionScreenCaption.Size = new System.Drawing.Size(120, 24);
            this.lblWindowActionScreenCaption.TabIndex = 9;
            this.lblWindowActionScreenCaption.Text = "Screen:";
            this.lblWindowActionScreenCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionRightCaption
            // 
            this.lblWindowActionRightCaption.AutoSize = true;
            this.lblWindowActionRightCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionRightCaption.Location = new System.Drawing.Point(237, 258);
            this.lblWindowActionRightCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionRightCaption.Name = "lblWindowActionRightCaption";
            this.lblWindowActionRightCaption.Size = new System.Drawing.Size(120, 22);
            this.lblWindowActionRightCaption.TabIndex = 21;
            this.lblWindowActionRightCaption.Text = "Right:";
            this.lblWindowActionRightCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWindowActionScreen
            // 
            tableLayoutDetails.SetColumnSpan(this.cmbWindowActionScreen, 2);
            this.cmbWindowActionScreen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Screen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionScreen.DisplayMember = "Name";
            this.cmbWindowActionScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionScreen.FormattingEnabled = true;
            this.cmbWindowActionScreen.Location = new System.Drawing.Point(363, 134);
            this.cmbWindowActionScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionScreen.Name = "cmbWindowActionScreen";
            this.cmbWindowActionScreen.Size = new System.Drawing.Size(204, 24);
            this.cmbWindowActionScreen.TabIndex = 10;
            this.cmbWindowActionScreen.ValueMember = "Name";
            // 
            // lblWindowActionTopCaption
            // 
            this.lblWindowActionTopCaption.AutoSize = true;
            this.lblWindowActionTopCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionTopCaption.Location = new System.Drawing.Point(237, 228);
            this.lblWindowActionTopCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionTopCaption.Name = "lblWindowActionTopCaption";
            this.lblWindowActionTopCaption.Size = new System.Drawing.Size(120, 22);
            this.lblWindowActionTopCaption.TabIndex = 17;
            this.lblWindowActionTopCaption.Text = "Top:";
            this.lblWindowActionTopCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionWindowStateCaption
            // 
            this.lblWindowActionWindowStateCaption.AutoSize = true;
            this.lblWindowActionWindowStateCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionWindowStateCaption.Location = new System.Drawing.Point(237, 166);
            this.lblWindowActionWindowStateCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionWindowStateCaption.Name = "lblWindowActionWindowStateCaption";
            this.lblWindowActionWindowStateCaption.Size = new System.Drawing.Size(120, 24);
            this.lblWindowActionWindowStateCaption.TabIndex = 11;
            this.lblWindowActionWindowStateCaption.Text = "Window State:";
            this.lblWindowActionWindowStateCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionLeftCaption
            // 
            this.lblWindowActionLeftCaption.AutoSize = true;
            this.lblWindowActionLeftCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionLeftCaption.Location = new System.Drawing.Point(237, 198);
            this.lblWindowActionLeftCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionLeftCaption.Name = "lblWindowActionLeftCaption";
            this.lblWindowActionLeftCaption.Size = new System.Drawing.Size(120, 22);
            this.lblWindowActionLeftCaption.TabIndex = 13;
            this.lblWindowActionLeftCaption.Text = "Left:";
            this.lblWindowActionLeftCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWindowActionWindowState
            // 
            tableLayoutDetails.SetColumnSpan(this.cmbWindowActionWindowState, 2);
            this.cmbWindowActionWindowState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "WindowState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionWindowState.DisplayMember = "Name";
            this.cmbWindowActionWindowState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionWindowState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionWindowState.FormattingEnabled = true;
            this.cmbWindowActionWindowState.Location = new System.Drawing.Point(363, 166);
            this.cmbWindowActionWindowState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionWindowState.Name = "cmbWindowActionWindowState";
            this.cmbWindowActionWindowState.Size = new System.Drawing.Size(204, 24);
            this.cmbWindowActionWindowState.TabIndex = 12;
            this.cmbWindowActionWindowState.ValueMember = "Name";
            // 
            // btnRecordWindowPosition
            // 
            this.btnRecordWindowPosition.AutoSize = true;
            this.btnRecordWindowPosition.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRecordWindowPosition.Location = new System.Drawing.Point(619, 67);
            this.btnRecordWindowPosition.Name = "btnRecordWindowPosition";
            this.btnRecordWindowPosition.Padding = new System.Windows.Forms.Padding(2);
            this.btnRecordWindowPosition.Size = new System.Drawing.Size(118, 30);
            this.btnRecordWindowPosition.TabIndex = 30;
            this.btnRecordWindowPosition.Text = "Record Position";
            this.btnRecordWindowPosition.UseVisualStyleBackColor = true;
            this.btnRecordWindowPosition.Click += new System.EventHandler(this.RecordWindowPositionHandler);
            // 
            // tblWindowActionActions
            // 
            tblWindowActionActions.ColumnCount = 1;
            tblWindowActionActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblWindowActionActions.Controls.Add(this.btnDeleteWindowAction, 0, 4);
            tblWindowActionActions.Controls.Add(this.btnDuplicateWindowAction, 0, 3);
            tblWindowActionActions.Controls.Add(this.btnSortWindowActions, 0, 2);
            tblWindowActionActions.Controls.Add(this.btnMoveDownWindowAction, 0, 1);
            tblWindowActionActions.Controls.Add(this.btnMoveUpWindowAction, 0, 0);
            tblWindowActionActions.Dock = System.Windows.Forms.DockStyle.Fill;
            tblWindowActionActions.Location = new System.Drawing.Point(196, 64);
            tblWindowActionActions.Margin = new System.Windows.Forms.Padding(0);
            tblWindowActionActions.Name = "tblWindowActionActions";
            tblWindowActionActions.RowCount = 6;
            tableLayoutDetails.SetRowSpan(tblWindowActionActions, 10);
            tblWindowActionActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowActionActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowActionActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowActionActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowActionActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblWindowActionActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblWindowActionActions.Size = new System.Drawing.Size(38, 299);
            tblWindowActionActions.TabIndex = 35;
            // 
            // btnDeleteWindowAction
            // 
            this.btnDeleteWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteWindowAction.Location = new System.Drawing.Point(3, 140);
            this.btnDeleteWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteWindowAction.Name = "btnDeleteWindowAction";
            this.btnDeleteWindowAction.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDeleteWindowAction.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteWindowAction.TabIndex = 2;
            this.btnDeleteWindowAction.Text = "x";
            this.btnDeleteWindowAction.UseVisualStyleBackColor = true;
            this.btnDeleteWindowAction.Click += new System.EventHandler(this.DeleteWindowActionHandler);
            // 
            // btnDuplicateWindowAction
            // 
            this.btnDuplicateWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicateWindowAction.Location = new System.Drawing.Point(3, 106);
            this.btnDuplicateWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDuplicateWindowAction.Name = "btnDuplicateWindowAction";
            this.btnDuplicateWindowAction.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDuplicateWindowAction.Size = new System.Drawing.Size(32, 30);
            this.btnDuplicateWindowAction.TabIndex = 5;
            this.btnDuplicateWindowAction.Text = "d";
            this.btnDuplicateWindowAction.UseVisualStyleBackColor = true;
            this.btnDuplicateWindowAction.Click += new System.EventHandler(this.DuplicateWindowActionHandler);
            // 
            // btnSortWindowActions
            // 
            this.btnSortWindowActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortWindowActions.Location = new System.Drawing.Point(3, 72);
            this.btnSortWindowActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortWindowActions.Name = "btnSortWindowActions";
            this.btnSortWindowActions.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSortWindowActions.Size = new System.Drawing.Size(32, 30);
            this.btnSortWindowActions.TabIndex = 29;
            this.btnSortWindowActions.Text = "s";
            this.btnSortWindowActions.UseVisualStyleBackColor = true;
            this.btnSortWindowActions.Click += new System.EventHandler(this.SortWindowActionsHandler);
            // 
            // btnMoveDownWindowAction
            // 
            this.btnMoveDownWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDownWindowAction.Location = new System.Drawing.Point(3, 38);
            this.btnMoveDownWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownWindowAction.Name = "btnMoveDownWindowAction";
            this.btnMoveDownWindowAction.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveDownWindowAction.Size = new System.Drawing.Size(32, 30);
            this.btnMoveDownWindowAction.TabIndex = 4;
            this.btnMoveDownWindowAction.Text = "v";
            this.btnMoveDownWindowAction.UseVisualStyleBackColor = true;
            this.btnMoveDownWindowAction.Click += new System.EventHandler(this.MoveDownWindowActionHandler);
            // 
            // btnMoveUpWindowAction
            // 
            this.btnMoveUpWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUpWindowAction.Location = new System.Drawing.Point(3, 4);
            this.btnMoveUpWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpWindowAction.Name = "btnMoveUpWindowAction";
            this.btnMoveUpWindowAction.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMoveUpWindowAction.Size = new System.Drawing.Size(32, 30);
            this.btnMoveUpWindowAction.TabIndex = 3;
            this.btnMoveUpWindowAction.Text = "^";
            this.btnMoveUpWindowAction.UseVisualStyleBackColor = true;
            this.btnMoveUpWindowAction.Click += new System.EventHandler(this.MoveUpWindowActionHandler);
            // 
            // tableLayoutOptions
            // 
            tableLayoutOptions.ColumnCount = 2;
            tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutOptions.Controls.Add(this.tableLayoutOsWindowMargin, 0, 1);
            tableLayoutOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutOptions.Location = new System.Drawing.Point(3, 3);
            tableLayoutOptions.Name = "tableLayoutOptions";
            tableLayoutOptions.RowCount = 3;
            tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutOptions.Size = new System.Drawing.Size(967, 620);
            tableLayoutOptions.TabIndex = 0;
            // 
            // tableLayoutOsWindowMargin
            // 
            this.tableLayoutOsWindowMargin.ColumnCount = 2;
            this.tableLayoutOsWindowMargin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutOsWindowMargin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutOsWindowMargin.Controls.Add(this.numRestorationTimeout, 1, 1);
            this.tableLayoutOsWindowMargin.Controls.Add(lblRestoration, 0, 0);
            this.tableLayoutOsWindowMargin.Controls.Add(lblOsWindowMarginCaption, 0, 2);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginBottom, 1, 6);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginRight, 1, 5);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginTop, 1, 4);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginLeft, 1, 3);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginBottom, 0, 6);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginRight, 0, 5);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginTop, 0, 4);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginLeft, 0, 3);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblRestorationTimeoutCaption, 0, 1);
            this.tableLayoutOsWindowMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOsWindowMargin.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutOsWindowMargin.Name = "tableLayoutOsWindowMargin";
            this.tableLayoutOsWindowMargin.RowCount = 8;
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOsWindowMargin.Size = new System.Drawing.Size(235, 304);
            this.tableLayoutOsWindowMargin.TabIndex = 0;
            // 
            // numRestorationTimeout
            // 
            this.numRestorationTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numRestorationTimeout.Location = new System.Drawing.Point(158, 32);
            this.numRestorationTimeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numRestorationTimeout.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numRestorationTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRestorationTimeout.Name = "numRestorationTimeout";
            this.numRestorationTimeout.Size = new System.Drawing.Size(74, 22);
            this.numRestorationTimeout.TabIndex = 21;
            this.numRestorationTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblRestoration
            // 
            lblRestoration.AutoSize = true;
            this.tableLayoutOsWindowMargin.SetColumnSpan(lblRestoration, 2);
            lblRestoration.Dock = System.Windows.Forms.DockStyle.Fill;
            lblRestoration.Location = new System.Drawing.Point(3, 4);
            lblRestoration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblRestoration.Name = "lblRestoration";
            lblRestoration.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            lblRestoration.Size = new System.Drawing.Size(229, 20);
            lblRestoration.TabIndex = 19;
            lblRestoration.Text = "Window Restoration:";
            // 
            // lblOsWindowMarginCaption
            // 
            lblOsWindowMarginCaption.AutoSize = true;
            this.tableLayoutOsWindowMargin.SetColumnSpan(lblOsWindowMarginCaption, 2);
            lblOsWindowMarginCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            lblOsWindowMarginCaption.Location = new System.Drawing.Point(3, 62);
            lblOsWindowMarginCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblOsWindowMarginCaption.Name = "lblOsWindowMarginCaption";
            lblOsWindowMarginCaption.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            lblOsWindowMarginCaption.Size = new System.Drawing.Size(229, 20);
            lblOsWindowMarginCaption.TabIndex = 1;
            lblOsWindowMarginCaption.Text = "OS Window Margin:";
            // 
            // numOsWindowMarginBottom
            // 
            this.numOsWindowMarginBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginBottom.Location = new System.Drawing.Point(158, 180);
            this.numOsWindowMarginBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOsWindowMarginBottom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOsWindowMarginBottom.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numOsWindowMarginBottom.Name = "numOsWindowMarginBottom";
            this.numOsWindowMarginBottom.Size = new System.Drawing.Size(74, 22);
            this.numOsWindowMarginBottom.TabIndex = 18;
            // 
            // numOsWindowMarginRight
            // 
            this.numOsWindowMarginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginRight.Location = new System.Drawing.Point(158, 150);
            this.numOsWindowMarginRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOsWindowMarginRight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOsWindowMarginRight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numOsWindowMarginRight.Name = "numOsWindowMarginRight";
            this.numOsWindowMarginRight.Size = new System.Drawing.Size(74, 22);
            this.numOsWindowMarginRight.TabIndex = 17;
            // 
            // numOsWindowMarginTop
            // 
            this.numOsWindowMarginTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginTop.Location = new System.Drawing.Point(158, 120);
            this.numOsWindowMarginTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOsWindowMarginTop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOsWindowMarginTop.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numOsWindowMarginTop.Name = "numOsWindowMarginTop";
            this.numOsWindowMarginTop.Size = new System.Drawing.Size(74, 22);
            this.numOsWindowMarginTop.TabIndex = 16;
            // 
            // numOsWindowMarginLeft
            // 
            this.numOsWindowMarginLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginLeft.Location = new System.Drawing.Point(158, 90);
            this.numOsWindowMarginLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOsWindowMarginLeft.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOsWindowMarginLeft.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numOsWindowMarginLeft.Name = "numOsWindowMarginLeft";
            this.numOsWindowMarginLeft.Size = new System.Drawing.Size(74, 22);
            this.numOsWindowMarginLeft.TabIndex = 15;
            // 
            // lblOsWindowMarginBottom
            // 
            this.lblOsWindowMarginBottom.AutoSize = true;
            this.lblOsWindowMarginBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginBottom.Location = new System.Drawing.Point(3, 180);
            this.lblOsWindowMarginBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginBottom.Name = "lblOsWindowMarginBottom";
            this.lblOsWindowMarginBottom.Size = new System.Drawing.Size(149, 22);
            this.lblOsWindowMarginBottom.TabIndex = 3;
            this.lblOsWindowMarginBottom.Text = "Bottom:";
            this.lblOsWindowMarginBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginRight
            // 
            this.lblOsWindowMarginRight.AutoSize = true;
            this.lblOsWindowMarginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginRight.Location = new System.Drawing.Point(3, 150);
            this.lblOsWindowMarginRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginRight.Name = "lblOsWindowMarginRight";
            this.lblOsWindowMarginRight.Size = new System.Drawing.Size(149, 22);
            this.lblOsWindowMarginRight.TabIndex = 2;
            this.lblOsWindowMarginRight.Text = "Right:";
            this.lblOsWindowMarginRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginTop
            // 
            this.lblOsWindowMarginTop.AutoSize = true;
            this.lblOsWindowMarginTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginTop.Location = new System.Drawing.Point(3, 120);
            this.lblOsWindowMarginTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginTop.Name = "lblOsWindowMarginTop";
            this.lblOsWindowMarginTop.Size = new System.Drawing.Size(149, 22);
            this.lblOsWindowMarginTop.TabIndex = 1;
            this.lblOsWindowMarginTop.Text = "Top:";
            this.lblOsWindowMarginTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginLeft
            // 
            this.lblOsWindowMarginLeft.AutoSize = true;
            this.lblOsWindowMarginLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginLeft.Location = new System.Drawing.Point(3, 90);
            this.lblOsWindowMarginLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginLeft.Name = "lblOsWindowMarginLeft";
            this.lblOsWindowMarginLeft.Size = new System.Drawing.Size(149, 22);
            this.lblOsWindowMarginLeft.TabIndex = 0;
            this.lblOsWindowMarginLeft.Text = "Left:";
            this.lblOsWindowMarginLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRestorationTimeoutCaption
            // 
            this.lblRestorationTimeoutCaption.AutoSize = true;
            this.lblRestorationTimeoutCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestorationTimeoutCaption.Location = new System.Drawing.Point(3, 28);
            this.lblRestorationTimeoutCaption.Name = "lblRestorationTimeoutCaption";
            this.lblRestorationTimeoutCaption.Size = new System.Drawing.Size(149, 30);
            this.lblRestorationTimeoutCaption.TabIndex = 20;
            this.lblRestorationTimeoutCaption.Text = "Timeout (sec):";
            this.lblRestorationTimeoutCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmiNewExplorerWindow
            // 
            this.tsmiNewExplorerWindow.Name = "tsmiNewExplorerWindow";
            this.tsmiNewExplorerWindow.Size = new System.Drawing.Size(132, 22);
            this.tsmiNewExplorerWindow.Tag = "";
            this.tsmiNewExplorerWindow.Text = "Explorer";
            this.tsmiNewExplorerWindow.Click += new System.EventHandler(this.NewExplorerWindowPatternHandler);
            // 
            // tsmiNewCmdWindow
            // 
            this.tsmiNewCmdWindow.Name = "tsmiNewCmdWindow";
            this.tsmiNewCmdWindow.Size = new System.Drawing.Size(132, 22);
            this.tsmiNewCmdWindow.Text = "CMD";
            this.tsmiNewCmdWindow.Click += new System.EventHandler(this.NewCmdWindowPatternHandler);
            // 
            // tsmiNewPowerShellWindow
            // 
            this.tsmiNewPowerShellWindow.Name = "tsmiNewPowerShellWindow";
            this.tsmiNewPowerShellWindow.Size = new System.Drawing.Size(132, 22);
            this.tsmiNewPowerShellWindow.Text = "PowerShell";
            this.tsmiNewPowerShellWindow.Click += new System.EventHandler(this.NewPowerShellWindowPatternHandler);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpConfigurationPatterns);
            this.tabMain.Controls.Add(this.tpWindowPatterns);
            this.tabMain.Controls.Add(this.tpLayouts);
            this.tabMain.Controls.Add(this.tpOptions);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 27);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(981, 655);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.MainTabPageChangedHandler);
            // 
            // tpConfigurationPatterns
            // 
            this.tpConfigurationPatterns.Controls.Add(tableConfigurationPatterns);
            this.tpConfigurationPatterns.Location = new System.Drawing.Point(4, 25);
            this.tpConfigurationPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConfigurationPatterns.Name = "tpConfigurationPatterns";
            this.tpConfigurationPatterns.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConfigurationPatterns.Size = new System.Drawing.Size(973, 626);
            this.tpConfigurationPatterns.TabIndex = 2;
            this.tpConfigurationPatterns.Text = "Display Configuration Patterns";
            this.tpConfigurationPatterns.UseVisualStyleBackColor = true;
            // 
            // tpWindowPatterns
            // 
            this.tpWindowPatterns.Controls.Add(tableWindowPatterns);
            this.tpWindowPatterns.Location = new System.Drawing.Point(4, 25);
            this.tpWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpWindowPatterns.Name = "tpWindowPatterns";
            this.tpWindowPatterns.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpWindowPatterns.Size = new System.Drawing.Size(973, 626);
            this.tpWindowPatterns.TabIndex = 0;
            this.tpWindowPatterns.Text = "Window Patterns";
            this.tpWindowPatterns.UseVisualStyleBackColor = true;
            // 
            // tpLayouts
            // 
            this.tpLayouts.Controls.Add(tableLayouts);
            this.tpLayouts.Location = new System.Drawing.Point(4, 25);
            this.tpLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpLayouts.Name = "tpLayouts";
            this.tpLayouts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpLayouts.Size = new System.Drawing.Size(973, 626);
            this.tpLayouts.TabIndex = 1;
            this.tpLayouts.Text = "Layouts";
            this.tpLayouts.UseVisualStyleBackColor = true;
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(tableLayoutOptions);
            this.tpOptions.Location = new System.Drawing.Point(4, 25);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(973, 626);
            this.tpOptions.TabIndex = 3;
            this.tpOptions.Text = "Options";
            this.tpOptions.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewWorkspace,
            this.tsbOpenWorkspace,
            this.tsbSaveWorkspace,
            this.tsbSaveWorkspaceAs,
            this.tsbApplyWorkspace,
            this.tsbKillWorkspace,
            this.tsbApplyCurrentLayout,
            this.tsbKillCurrentLayout,
            this.tsbApplyWindowAction,
            this.tsbKillWindowAction});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.toolStrip.Size = new System.Drawing.Size(981, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // tsbNewWorkspace
            // 
            this.tsbNewWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewWorkspace.Image")));
            this.tsbNewWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewWorkspace.Name = "tsbNewWorkspace";
            this.tsbNewWorkspace.Size = new System.Drawing.Size(51, 20);
            this.tsbNewWorkspace.Text = "New";
            this.tsbNewWorkspace.ToolTipText = "Create new WinMan workspace";
            this.tsbNewWorkspace.Click += new System.EventHandler(this.NewWorkspaceHandler);
            // 
            // tsbOpenWorkspace
            // 
            this.tsbOpenWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenWorkspace.Image")));
            this.tsbOpenWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenWorkspace.Name = "tsbOpenWorkspace";
            this.tsbOpenWorkspace.Size = new System.Drawing.Size(56, 20);
            this.tsbOpenWorkspace.Text = "Open";
            this.tsbOpenWorkspace.ToolTipText = "Open WinMan workspace file";
            this.tsbOpenWorkspace.Click += new System.EventHandler(this.OpenWorkspaceHandler);
            // 
            // tsbSaveWorkspace
            // 
            this.tsbSaveWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveWorkspace.Image")));
            this.tsbSaveWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveWorkspace.Name = "tsbSaveWorkspace";
            this.tsbSaveWorkspace.Size = new System.Drawing.Size(51, 20);
            this.tsbSaveWorkspace.Text = "Save";
            this.tsbSaveWorkspace.ToolTipText = "Save current workspace";
            this.tsbSaveWorkspace.Click += new System.EventHandler(this.SaveWorkspaceHandler);
            // 
            // tsbSaveWorkspaceAs
            // 
            this.tsbSaveWorkspaceAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveWorkspaceAs.Image")));
            this.tsbSaveWorkspaceAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveWorkspaceAs.Name = "tsbSaveWorkspaceAs";
            this.tsbSaveWorkspaceAs.Size = new System.Drawing.Size(76, 20);
            this.tsbSaveWorkspaceAs.Text = "Save As...";
            this.tsbSaveWorkspaceAs.ToolTipText = "Save current workspace in a specific file";
            this.tsbSaveWorkspaceAs.Click += new System.EventHandler(this.SaveWorkspaceAsHandler);
            // 
            // tsbApplyWorkspace
            // 
            this.tsbApplyWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyWorkspace.Image")));
            this.tsbApplyWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyWorkspace.Name = "tsbApplyWorkspace";
            this.tsbApplyWorkspace.Size = new System.Drawing.Size(58, 20);
            this.tsbApplyWorkspace.Text = "Apply";
            this.tsbApplyWorkspace.ToolTipText = "Apply all default layouts from the current workspace";
            this.tsbApplyWorkspace.Click += new System.EventHandler(this.ApplyWorkspaceHandler);
            // 
            // tsbKillWorkspace
            // 
            this.tsbKillWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbKillWorkspace.Image")));
            this.tsbKillWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKillWorkspace.Name = "tsbKillWorkspace";
            this.tsbKillWorkspace.Size = new System.Drawing.Size(43, 20);
            this.tsbKillWorkspace.Text = "Kill";
            this.tsbKillWorkspace.Click += new System.EventHandler(this.KillWorkspaceHandler);
            // 
            // tsbApplyCurrentLayout
            // 
            this.tsbApplyCurrentLayout.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyCurrentLayout.Image")));
            this.tsbApplyCurrentLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyCurrentLayout.Name = "tsbApplyCurrentLayout";
            this.tsbApplyCurrentLayout.Size = new System.Drawing.Size(97, 20);
            this.tsbApplyCurrentLayout.Text = "Apply Layout";
            this.tsbApplyCurrentLayout.ToolTipText = "Apply the selected layout";
            this.tsbApplyCurrentLayout.Click += new System.EventHandler(this.ApplyCurrentLayoutHandler);
            // 
            // tsbKillCurrentLayout
            // 
            this.tsbKillCurrentLayout.Image = ((System.Drawing.Image)(resources.GetObject("tsbKillCurrentLayout.Image")));
            this.tsbKillCurrentLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKillCurrentLayout.Name = "tsbKillCurrentLayout";
            this.tsbKillCurrentLayout.Size = new System.Drawing.Size(82, 20);
            this.tsbKillCurrentLayout.Text = "Kill Layout";
            this.tsbKillCurrentLayout.ToolTipText = "Close all matching Windows from the selected layout.";
            this.tsbKillCurrentLayout.Click += new System.EventHandler(this.KillCurrentLayoutHandler);
            // 
            // tsbApplyWindowAction
            // 
            this.tsbApplyWindowAction.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyWindowAction.Image")));
            this.tsbApplyWindowAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyWindowAction.Name = "tsbApplyWindowAction";
            this.tsbApplyWindowAction.Size = new System.Drawing.Size(143, 20);
            this.tsbApplyWindowAction.Text = "Apply Window Action";
            this.tsbApplyWindowAction.ToolTipText = "Apply the selected window action";
            this.tsbApplyWindowAction.Click += new System.EventHandler(this.ApplyWindowActionHandler);
            // 
            // tsbKillWindowAction
            // 
            this.tsbKillWindowAction.Image = ((System.Drawing.Image)(resources.GetObject("tsbKillWindowAction.Image")));
            this.tsbKillWindowAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKillWindowAction.Name = "tsbKillWindowAction";
            this.tsbKillWindowAction.Size = new System.Drawing.Size(128, 20);
            this.tsbKillWindowAction.Text = "Kill Window Action";
            this.tsbKillWindowAction.ToolTipText = "Close all matching windows.";
            this.tsbKillWindowAction.Click += new System.EventHandler(this.KillWindowActionHandler);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName});
            this.statusStrip.Location = new System.Drawing.Point(0, 682);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(981, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslFileName
            // 
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(60, 17);
            this.tsslFileName.Text = "File Name";
            // 
            // cmsWindowPatternTemplates
            // 
            this.cmsWindowPatternTemplates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewExplorerWindow,
            this.tsmiNewCmdWindow,
            this.tsmiNewPowerShellWindow});
            this.cmsWindowPatternTemplates.Name = "cmsWindowPatternTemplates";
            this.cmsWindowPatternTemplates.Size = new System.Drawing.Size(133, 70);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 704);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "WinMan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingHandler);
            this.Load += new System.EventHandler(this.FormLoadHandler);
            tableConfigurationPatterns.ResumeLayout(false);
            tableConfigurationPatternList.ResumeLayout(false);
            tableConfigurationPatternList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).EndInit();
            tableConfigurationPatternDetails.ResumeLayout(false);
            tableConfigurationPatternDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).EndInit();
            tableWindowPatterns.ResumeLayout(false);
            tableWindowPatterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).EndInit();
            tblWindowPatternsActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWindowPatternRestorationTimeout)).EndInit();
            tableLayouts.ResumeLayout(false);
            tableLayoutList.ResumeLayout(false);
            tableLayoutList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayoutDefaultVirtualDesktop)).EndInit();
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).EndInit();
            tblWindowActionActions.ResumeLayout(false);
            tableLayoutOptions.ResumeLayout(false);
            this.tableLayoutOsWindowMargin.ResumeLayout(false);
            this.tableLayoutOsWindowMargin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestorationTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsWindowMarginLeft)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpConfigurationPatterns.ResumeLayout(false);
            this.tpWindowPatterns.ResumeLayout(false);
            this.tpLayouts.ResumeLayout(false);
            this.tpOptions.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsBindingSource)).EndInit();
            this.cmsWindowPatternTemplates.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReloadWindowList;
        private System.Windows.Forms.ListView listWindows;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colWindowClass;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colScreen;
        private System.Windows.Forms.ColumnHeader colVirtualDesktop;
        private System.Windows.Forms.ColumnHeader colProcess;
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
        private System.Windows.Forms.Label lblLayoutNameCaption;
        private System.Windows.Forms.TextBox txtLayoutName;
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
        private System.Windows.Forms.ToolStripButton tsbSaveWorkspaceAs;
        private System.Windows.Forms.TextBox txtRestoreCommand;
        private System.Windows.Forms.TextBox txtRestoreWorkingDir;
        private System.Windows.Forms.TextBox txtRestoreCommandArgs;
        private System.Windows.Forms.Label lblRestoreWorkingDir;
        private System.Windows.Forms.ToolStripButton tsbApplyWorkspace;
        private PreviewCanvas previewLayout;
        private System.Windows.Forms.CheckBox chkLayoutIsDefaultLayout;
        private System.Windows.Forms.ToolStripButton tsbApplyCurrentLayout;
        private System.Windows.Forms.TabPage tpConfigurationPatterns;
        private System.Windows.Forms.ListBox listScreenPatterns;
        private System.Windows.Forms.NumericUpDown numScreenHeight;
        private System.Windows.Forms.NumericUpDown numScreenWidth;
        private System.Windows.Forms.NumericUpDown numScreenTop;
        private System.Windows.Forms.NumericUpDown numScreenLeft;
        private System.Windows.Forms.Button btnDeleteConfiguration;
        private System.Windows.Forms.Button btnRecordConfiguration;
        private System.Windows.Forms.Label lblScreenTopCaption;
        private System.Windows.Forms.Label lblScreenHeightCaption;
        private System.Windows.Forms.Label lblScreenWidthCaption;
        private System.Windows.Forms.Label lblScreenLeftCaption;
        private System.Windows.Forms.Label lblScreenDeviceNameCaption;
        private System.Windows.Forms.Label lblScreensCaption;
        private System.Windows.Forms.Label lblConfigurationNameCaption;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtScreenName;
        private System.Windows.Forms.TextBox txtConfigurationName;
        private System.Windows.Forms.ListBox listConfigurationPatterns;
        private System.Windows.Forms.CheckBox chkWindowActionRestore;
        private System.Windows.Forms.ComboBox cmbLayoutConfiguration;
        private System.Windows.Forms.ComboBox cmbWindowActionWindow;
        private System.Windows.Forms.Label lblWindowActionWindowCaption;
        private System.Windows.Forms.Button btnNewWindowAction;
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
        private System.Windows.Forms.Label lblWindowActionWindowStateCaption;
        private System.Windows.Forms.Label lblWindowActionScreenCaption;
        private System.Windows.Forms.ComboBox cmbWindowActionTopUnit;
        private System.Windows.Forms.Label lblWindowActionVirtualDesktop;
        private System.Windows.Forms.ComboBox cmbWindowActionLeftUnit;
        private System.Windows.Forms.ComboBox cmbWindowActionWindowState;
        private System.Windows.Forms.ComboBox cmbWindowActionScreen;
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
        private System.Windows.Forms.ToolStripButton tsbApplyWindowAction;
        private System.Windows.Forms.BindingSource windowsBindingSource;
        private System.Windows.Forms.ToolStripButton tsbSaveWorkspace;
        private System.Windows.Forms.CheckBox chkRespectVirtualDesktopCount;
        private System.Windows.Forms.NumericUpDown numVirtualDesktopCount;
        private System.Windows.Forms.Label lblVirtualDesktopsCaption;
        private System.Windows.Forms.Button btnRecordWindowPosition;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutOsWindowMargin;
        private System.Windows.Forms.NumericUpDown numOsWindowMarginBottom;
        private System.Windows.Forms.NumericUpDown numOsWindowMarginRight;
        private System.Windows.Forms.NumericUpDown numOsWindowMarginTop;
        private System.Windows.Forms.NumericUpDown numOsWindowMarginLeft;
        private System.Windows.Forms.Label lblOsWindowMarginBottom;
        private System.Windows.Forms.Label lblOsWindowMarginRight;
        private System.Windows.Forms.Label lblOsWindowMarginTop;
        private System.Windows.Forms.Label lblOsWindowMarginLeft;
        private System.Windows.Forms.Button btnDeleteWindowPattern;
        private System.Windows.Forms.Button btnMoveDownWindowPattern;
        private System.Windows.Forms.Button btnMoveUpWindowPattern;
        private System.Windows.Forms.Button btnDuplicateWindowPattern;
        private System.Windows.Forms.ListBox listLayouts;
        private System.Windows.Forms.Button btnMoveUpLayout;
        private System.Windows.Forms.Button btnMoveDownLayout;
        private System.Windows.Forms.Button btnDuplicateLayout;
        private System.Windows.Forms.Button btnDeleteLayout;
        private System.Windows.Forms.Button btnMoveUpWindowAction;
        private System.Windows.Forms.Button btnMoveDownWindowAction;
        private System.Windows.Forms.Button btnDuplicateWindowAction;
        private System.Windows.Forms.Button btnSortWindowPatterns;
        private System.Windows.Forms.Button btnSortLayouts;
        private System.Windows.Forms.Button btnSortWindowActions;
        private System.Windows.Forms.Button btnMoveUpConfiguration;
        private System.Windows.Forms.Button btnMoveDownConfiguration;
        private System.Windows.Forms.Button btnSortConfigurations;
        private System.Windows.Forms.NumericUpDown numLayoutDefaultVirtualDesktop;
        private System.Windows.Forms.Label lblLayoutDefaultVirtualDesktopCaption;
        private System.Windows.Forms.CheckBox chkOverrideDefaultVirtualDesktop;
        private System.Windows.Forms.Label lblScreenMatches;
        private System.Windows.Forms.Label lblScreenMatchesCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfigurationIsMatch;
        private System.Windows.Forms.CheckBox chkRespectSize;
        private System.Windows.Forms.CheckBox chkRespectPosition;
        private System.Windows.Forms.Label lblRestoreTimeoutCaption;
        private System.Windows.Forms.NumericUpDown numWindowPatternRestorationTimeout;
        private System.Windows.Forms.CheckBox chkOverrideRestorationTimeout;
        private System.Windows.Forms.NumericUpDown numRestorationTimeout;
        private System.Windows.Forms.Label lblRestorationTimeoutCaption;
        private System.Windows.Forms.ColumnHeader colAppId;
        private System.Windows.Forms.CheckBox chkAllVirtualDesktops;
        private System.Windows.Forms.RadioButton radClassicApp;
        private System.Windows.Forms.RadioButton radModernApp;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Button btnNewWindowPatternFromTemplate;
        private System.Windows.Forms.ContextMenuStrip cmsWindowPatternTemplates;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewExplorerWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewCmdWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewPowerShellWindow;
        private System.Windows.Forms.ToolStripButton tsbKillWindowAction;
        private System.Windows.Forms.ToolStripButton tsbKillCurrentLayout;
        private System.Windows.Forms.ToolStripButton tsbKillWorkspace;
        private RasterChooser rasterChooser;
    }
}

