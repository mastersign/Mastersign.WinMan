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
            System.Windows.Forms.TableLayoutPanel tableConfigurationPatterns;
            System.Windows.Forms.TableLayoutPanel tableConfigurationPatternList;
            System.Windows.Forms.FlowLayoutPanel flowConfigurations;
            System.Windows.Forms.TableLayoutPanel tableConfigurationPatternDetails;
            System.Windows.Forms.TableLayoutPanel tableWindowPatterns;
            System.Windows.Forms.FlowLayoutPanel flowWindowPatternActions;
            System.Windows.Forms.TableLayoutPanel tableLayouts;
            System.Windows.Forms.TableLayoutPanel tableLayoutList;
            System.Windows.Forms.FlowLayoutPanel flowLayoutActions;
            System.Windows.Forms.TableLayoutPanel tableLayoutDetails;
            System.Windows.Forms.FlowLayoutPanel flowWindowActionActions;
            System.Windows.Forms.TableLayoutPanel tableLayoutOptions;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chkRespectVirtualDesktopCount = new System.Windows.Forms.CheckBox();
            this.configurationPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numVirtualDesktopCount = new System.Windows.Forms.NumericUpDown();
            this.lblVirtualDesktopsCaption = new System.Windows.Forms.Label();
            this.btnRecordConfiguration = new System.Windows.Forms.Button();
            this.lblConfigurationNameCaption = new System.Windows.Forms.Label();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.listConfigurationPatterns = new System.Windows.Forms.ListBox();
            this.btnMoveUpConfiguration = new System.Windows.Forms.Button();
            this.btnMoveDownConfiguration = new System.Windows.Forms.Button();
            this.btnSortConfigurations = new System.Windows.Forms.Button();
            this.btnDeleteConfiguration = new System.Windows.Forms.Button();
            this.previewConfiguration = new Mastersign.WinMan.PreviewCanvas();
            this.numScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.listScreenPatterns = new System.Windows.Forms.ListBox();
            this.screensPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listWindows = new System.Windows.Forms.ListView();
            this.colMatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWindowClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScreen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVirtualDesktop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReloadWindowList = new System.Windows.Forms.Button();
            this.lblWindowPatternsCaption = new System.Windows.Forms.Label();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.lblRestoreWorkingDir = new System.Windows.Forms.Label();
            this.txtRestoreWorkingDir = new System.Windows.Forms.TextBox();
            this.windowPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblMatchCountCaption = new System.Windows.Forms.Label();
            this.txtProcessFileName = new System.Windows.Forms.TextBox();
            this.lblProcessFileName = new System.Windows.Forms.Label();
            this.lblTitlePatternCaption = new System.Windows.Forms.Label();
            this.cmbTitlePatternType = new System.Windows.Forms.ComboBox();
            this.txtWindowClassPattern = new System.Windows.Forms.TextBox();
            this.lblWindowClassPatternCaption = new System.Windows.Forms.Label();
            this.btnNewWindowPattern = new System.Windows.Forms.Button();
            this.btnMoveUpWindowPattern = new System.Windows.Forms.Button();
            this.btnMoveDownWindowPattern = new System.Windows.Forms.Button();
            this.btnSortWindowPatterns = new System.Windows.Forms.Button();
            this.btnDuplicateWindowPattern = new System.Windows.Forms.Button();
            this.btnDeleteWindowPattern = new System.Windows.Forms.Button();
            this.previewLayout = new Mastersign.WinMan.PreviewCanvas();
            this.btnNewLayout = new System.Windows.Forms.Button();
            this.lblLayoutNameCaption = new System.Windows.Forms.Label();
            this.txtLayoutName = new System.Windows.Forms.TextBox();
            this.layoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkLayoutIsDefaultLayout = new System.Windows.Forms.CheckBox();
            this.lblConfigurationPatternCaption = new System.Windows.Forms.Label();
            this.cmbLayoutConfiguration = new System.Windows.Forms.ComboBox();
            this.listLayouts = new System.Windows.Forms.ListBox();
            this.btnMoveUpLayout = new System.Windows.Forms.Button();
            this.btnMoveDownLayout = new System.Windows.Forms.Button();
            this.btnSortLayouts = new System.Windows.Forms.Button();
            this.btnDuplicateLayout = new System.Windows.Forms.Button();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.lblWindowActionsCaption = new System.Windows.Forms.Label();
            this.chkWindowActionBottomInvert = new System.Windows.Forms.CheckBox();
            this.windowActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnMoveUpWindowAction = new System.Windows.Forms.Button();
            this.btnMoveDownWindowAction = new System.Windows.Forms.Button();
            this.btnSortWindowActions = new System.Windows.Forms.Button();
            this.btnDuplicateWindowAction = new System.Windows.Forms.Button();
            this.btnDeleteWindowAction = new System.Windows.Forms.Button();
            this.tableLayoutOsWindowMargin = new System.Windows.Forms.TableLayoutPanel();
            this.numOsWindowMarginBottom = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginRight = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginTop = new System.Windows.Forms.NumericUpDown();
            this.numOsWindowMarginLeft = new System.Windows.Forms.NumericUpDown();
            this.lblOsWindowMarginBottom = new System.Windows.Forms.Label();
            this.lblOsWindowMarginRight = new System.Windows.Forms.Label();
            this.lblOsWindowMarginTop = new System.Windows.Forms.Label();
            this.lblOsWindowMarginLeft = new System.Windows.Forms.Label();
            this.lblOsWindowMarginCaption = new System.Windows.Forms.Label();
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
            this.tsbApplyCurrentLayout = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyWindowAction = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.windowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tableConfigurationPatterns = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatternList = new System.Windows.Forms.TableLayoutPanel();
            flowConfigurations = new System.Windows.Forms.FlowLayoutPanel();
            tableConfigurationPatternDetails = new System.Windows.Forms.TableLayoutPanel();
            tableWindowPatterns = new System.Windows.Forms.TableLayoutPanel();
            flowWindowPatternActions = new System.Windows.Forms.FlowLayoutPanel();
            tableLayouts = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutList = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutActions = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutDetails = new System.Windows.Forms.TableLayoutPanel();
            flowWindowActionActions = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutOptions = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatterns.SuspendLayout();
            tableConfigurationPatternList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).BeginInit();
            flowConfigurations.SuspendLayout();
            tableConfigurationPatternDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).BeginInit();
            tableWindowPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).BeginInit();
            flowWindowPatternActions.SuspendLayout();
            tableLayouts.SuspendLayout();
            tableLayoutList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).BeginInit();
            flowLayoutActions.SuspendLayout();
            tableLayoutDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).BeginInit();
            flowWindowActionActions.SuspendLayout();
            tableLayoutOptions.SuspendLayout();
            this.tableLayoutOsWindowMargin.SuspendLayout();
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
            tableConfigurationPatterns.Size = new System.Drawing.Size(967, 648);
            tableConfigurationPatterns.TabIndex = 0;
            // 
            // tableConfigurationPatternList
            // 
            tableConfigurationPatternList.ColumnCount = 2;
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableConfigurationPatternList.Controls.Add(this.chkRespectVirtualDesktopCount, 0, 5);
            tableConfigurationPatternList.Controls.Add(this.numVirtualDesktopCount, 0, 4);
            tableConfigurationPatternList.Controls.Add(this.lblVirtualDesktopsCaption, 0, 3);
            tableConfigurationPatternList.Controls.Add(this.btnRecordConfiguration, 0, 0);
            tableConfigurationPatternList.Controls.Add(this.lblConfigurationNameCaption, 0, 1);
            tableConfigurationPatternList.Controls.Add(this.txtConfigurationName, 0, 2);
            tableConfigurationPatternList.Controls.Add(this.listConfigurationPatterns, 0, 6);
            tableConfigurationPatternList.Controls.Add(flowConfigurations, 1, 6);
            tableConfigurationPatternList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatternList.Location = new System.Drawing.Point(3, 4);
            tableConfigurationPatternList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableConfigurationPatternList.Name = "tableConfigurationPatternList";
            tableConfigurationPatternList.RowCount = 7;
            tableConfigurationPatterns.SetRowSpan(tableConfigurationPatternList, 2);
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternList.Size = new System.Drawing.Size(235, 640);
            tableConfigurationPatternList.TabIndex = 0;
            // 
            // chkRespectVirtualDesktopCount
            // 
            this.chkRespectVirtualDesktopCount.AutoSize = true;
            this.chkRespectVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationPatternsBindingSource, "RespectVirtualDesktopCount", true));
            this.chkRespectVirtualDesktopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkRespectVirtualDesktopCount.Location = new System.Drawing.Point(3, 145);
            this.chkRespectVirtualDesktopCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRespectVirtualDesktopCount.Name = "chkRespectVirtualDesktopCount";
            this.chkRespectVirtualDesktopCount.Size = new System.Drawing.Size(196, 20);
            this.chkRespectVirtualDesktopCount.TabIndex = 6;
            this.chkRespectVirtualDesktopCount.Text = "Respect VD Count";
            this.chkRespectVirtualDesktopCount.UseVisualStyleBackColor = true;
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
            // numVirtualDesktopCount
            // 
            this.numVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurationPatternsBindingSource, "VirtualDesktopCount", true));
            this.numVirtualDesktopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVirtualDesktopCount.Location = new System.Drawing.Point(3, 115);
            this.numVirtualDesktopCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVirtualDesktopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVirtualDesktopCount.Name = "numVirtualDesktopCount";
            this.numVirtualDesktopCount.Size = new System.Drawing.Size(196, 22);
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
            this.lblVirtualDesktopsCaption.Location = new System.Drawing.Point(3, 91);
            this.lblVirtualDesktopsCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblVirtualDesktopsCaption.Name = "lblVirtualDesktopsCaption";
            this.lblVirtualDesktopsCaption.Size = new System.Drawing.Size(109, 16);
            this.lblVirtualDesktopsCaption.TabIndex = 4;
            this.lblVirtualDesktopsCaption.Text = "Virtual Desktops:";
            // 
            // btnRecordConfiguration
            // 
            this.btnRecordConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecordConfiguration.Location = new System.Drawing.Point(3, 4);
            this.btnRecordConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecordConfiguration.Name = "btnRecordConfiguration";
            this.btnRecordConfiguration.Size = new System.Drawing.Size(196, 25);
            this.btnRecordConfiguration.TabIndex = 0;
            this.btnRecordConfiguration.Text = "Record Configuration";
            this.btnRecordConfiguration.UseVisualStyleBackColor = true;
            this.btnRecordConfiguration.Click += new System.EventHandler(this.RecordConfigurationHandler);
            // 
            // lblConfigurationNameCaption
            // 
            this.lblConfigurationNameCaption.AutoSize = true;
            this.lblConfigurationNameCaption.Location = new System.Drawing.Point(3, 37);
            this.lblConfigurationNameCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblConfigurationNameCaption.Name = "lblConfigurationNameCaption";
            this.lblConfigurationNameCaption.Size = new System.Drawing.Size(48, 16);
            this.lblConfigurationNameCaption.TabIndex = 2;
            this.lblConfigurationNameCaption.Text = "Name:";
            // 
            // txtConfigurationName
            // 
            this.txtConfigurationName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtConfigurationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfigurationName.Location = new System.Drawing.Point(3, 61);
            this.txtConfigurationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(196, 22);
            this.txtConfigurationName.TabIndex = 3;
            // 
            // listConfigurationPatterns
            // 
            this.listConfigurationPatterns.DataSource = this.configurationPatternsBindingSource;
            this.listConfigurationPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConfigurationPatterns.FormattingEnabled = true;
            this.listConfigurationPatterns.IntegralHeight = false;
            this.listConfigurationPatterns.ItemHeight = 16;
            this.listConfigurationPatterns.Location = new System.Drawing.Point(3, 173);
            this.listConfigurationPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listConfigurationPatterns.Name = "listConfigurationPatterns";
            this.listConfigurationPatterns.Size = new System.Drawing.Size(196, 463);
            this.listConfigurationPatterns.TabIndex = 7;
            // 
            // flowConfigurations
            // 
            flowConfigurations.Controls.Add(this.btnMoveUpConfiguration);
            flowConfigurations.Controls.Add(this.btnMoveDownConfiguration);
            flowConfigurations.Controls.Add(this.btnSortConfigurations);
            flowConfigurations.Controls.Add(this.btnDeleteConfiguration);
            flowConfigurations.Dock = System.Windows.Forms.DockStyle.Fill;
            flowConfigurations.Location = new System.Drawing.Point(202, 169);
            flowConfigurations.Margin = new System.Windows.Forms.Padding(0);
            flowConfigurations.Name = "flowConfigurations";
            flowConfigurations.Size = new System.Drawing.Size(33, 471);
            flowConfigurations.TabIndex = 8;
            // 
            // btnMoveUpConfiguration
            // 
            this.btnMoveUpConfiguration.Location = new System.Drawing.Point(3, 4);
            this.btnMoveUpConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpConfiguration.Name = "btnMoveUpConfiguration";
            this.btnMoveUpConfiguration.Size = new System.Drawing.Size(27, 27);
            this.btnMoveUpConfiguration.TabIndex = 2;
            this.btnMoveUpConfiguration.Text = "^";
            this.btnMoveUpConfiguration.UseVisualStyleBackColor = true;
            this.btnMoveUpConfiguration.Click += new System.EventHandler(this.MoveUpConfigurationHandler);
            // 
            // btnMoveDownConfiguration
            // 
            this.btnMoveDownConfiguration.Location = new System.Drawing.Point(3, 35);
            this.btnMoveDownConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownConfiguration.Name = "btnMoveDownConfiguration";
            this.btnMoveDownConfiguration.Size = new System.Drawing.Size(27, 27);
            this.btnMoveDownConfiguration.TabIndex = 3;
            this.btnMoveDownConfiguration.Text = "v";
            this.btnMoveDownConfiguration.UseVisualStyleBackColor = true;
            this.btnMoveDownConfiguration.Click += new System.EventHandler(this.MoveDownConfigurationHandler);
            // 
            // btnSortConfigurations
            // 
            this.btnSortConfigurations.Location = new System.Drawing.Point(3, 66);
            this.btnSortConfigurations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortConfigurations.Name = "btnSortConfigurations";
            this.btnSortConfigurations.Size = new System.Drawing.Size(27, 27);
            this.btnSortConfigurations.TabIndex = 4;
            this.btnSortConfigurations.Text = "s";
            this.btnSortConfigurations.UseVisualStyleBackColor = true;
            this.btnSortConfigurations.Click += new System.EventHandler(this.SortConfigurationsHandler);
            // 
            // btnDeleteConfiguration
            // 
            this.btnDeleteConfiguration.Location = new System.Drawing.Point(3, 97);
            this.btnDeleteConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteConfiguration.Name = "btnDeleteConfiguration";
            this.btnDeleteConfiguration.Size = new System.Drawing.Size(27, 27);
            this.btnDeleteConfiguration.TabIndex = 1;
            this.btnDeleteConfiguration.Text = "x";
            this.btnDeleteConfiguration.UseVisualStyleBackColor = true;
            this.btnDeleteConfiguration.Click += new System.EventHandler(this.DeleteConfigurationHandler);
            // 
            // previewConfiguration
            // 
            this.previewConfiguration.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewConfiguration.Location = new System.Drawing.Point(244, 4);
            this.previewConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewConfiguration.Name = "previewConfiguration";
            this.previewConfiguration.Size = new System.Drawing.Size(720, 283);
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
            tableConfigurationPatternDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatternDetails.Location = new System.Drawing.Point(244, 295);
            tableConfigurationPatternDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableConfigurationPatternDetails.Name = "tableConfigurationPatternDetails";
            tableConfigurationPatternDetails.RowCount = 8;
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableConfigurationPatternDetails.Size = new System.Drawing.Size(720, 349);
            tableConfigurationPatternDetails.TabIndex = 2;
            // 
            // numScreenHeight
            // 
            this.numScreenHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenHeight.Enabled = false;
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
            this.numScreenHeight.ReadOnly = true;
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
            tableConfigurationPatternDetails.SetRowSpan(this.listScreenPatterns, 7);
            this.listScreenPatterns.Size = new System.Drawing.Size(200, 317);
            this.listScreenPatterns.TabIndex = 1;
            // 
            // screensPatternsBindingSource
            // 
            this.screensPatternsBindingSource.DataMember = "Screens";
            this.screensPatternsBindingSource.DataSource = this.configurationPatternsBindingSource;
            this.screensPatternsBindingSource.CurrentChanged += new System.EventHandler(this.ScreenPatternSelectionChanged);
            this.screensPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedScreenPatternChanged);
            // 
            // lblScreenHeightCaption
            // 
            this.lblScreenHeightCaption.AutoSize = true;
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
            this.numScreenWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenWidth.Enabled = false;
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
            this.numScreenWidth.ReadOnly = true;
            this.numScreenWidth.Size = new System.Drawing.Size(200, 22);
            this.numScreenWidth.TabIndex = 11;
            // 
            // lblScreenTopCaption
            // 
            this.lblScreenTopCaption.AutoSize = true;
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
            this.numScreenTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenTop.Enabled = false;
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
            this.numScreenTop.ReadOnly = true;
            this.numScreenTop.Size = new System.Drawing.Size(200, 22);
            this.numScreenTop.TabIndex = 9;
            // 
            // numScreenLeft
            // 
            this.numScreenLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenLeft.Enabled = false;
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
            this.numScreenLeft.ReadOnly = true;
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
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(309, 58);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(200, 22);
            this.txtDeviceName.TabIndex = 5;
            // 
            // tableWindowPatterns
            // 
            tableWindowPatterns.ColumnCount = 6;
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableWindowPatterns.Controls.Add(this.listWindows, 0, 0);
            tableWindowPatterns.Controls.Add(this.btnReloadWindowList, 5, 1);
            tableWindowPatterns.Controls.Add(this.lblWindowPatternsCaption, 0, 1);
            tableWindowPatterns.Controls.Add(this.lblMatchCount, 3, 9);
            tableWindowPatterns.Controls.Add(this.lblRestoreWorkingDir, 2, 12);
            tableWindowPatterns.Controls.Add(this.txtRestoreWorkingDir, 3, 12);
            tableWindowPatterns.Controls.Add(this.listWindowPatterns, 0, 5);
            tableWindowPatterns.Controls.Add(this.lblWindowPatternName, 0, 3);
            tableWindowPatterns.Controls.Add(this.chkWindowClassIgnoreCase, 4, 7);
            tableWindowPatterns.Controls.Add(this.txtRestoreCommandArgs, 3, 11);
            tableWindowPatterns.Controls.Add(this.txtWindowPatternName, 0, 4);
            tableWindowPatterns.Controls.Add(this.txtRestoreCommand, 3, 10);
            tableWindowPatterns.Controls.Add(this.lblRestoreCommandArgs, 2, 11);
            tableWindowPatterns.Controls.Add(this.lblRestoreCommand, 2, 10);
            tableWindowPatterns.Controls.Add(this.chkTitleIgnoreCase, 4, 5);
            tableWindowPatterns.Controls.Add(this.cmbWindowClassPatternType, 3, 7);
            tableWindowPatterns.Controls.Add(this.txtTitlePattern, 3, 4);
            tableWindowPatterns.Controls.Add(this.lblMatchCountCaption, 2, 9);
            tableWindowPatterns.Controls.Add(this.txtProcessFileName, 3, 8);
            tableWindowPatterns.Controls.Add(this.lblProcessFileName, 2, 8);
            tableWindowPatterns.Controls.Add(this.lblTitlePatternCaption, 2, 4);
            tableWindowPatterns.Controls.Add(this.cmbTitlePatternType, 3, 5);
            tableWindowPatterns.Controls.Add(this.txtWindowClassPattern, 3, 6);
            tableWindowPatterns.Controls.Add(this.lblWindowClassPatternCaption, 2, 6);
            tableWindowPatterns.Controls.Add(this.btnNewWindowPattern, 0, 2);
            tableWindowPatterns.Controls.Add(flowWindowPatternActions, 1, 5);
            tableWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            tableWindowPatterns.Location = new System.Drawing.Point(3, 4);
            tableWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableWindowPatterns.Name = "tableWindowPatterns";
            tableWindowPatterns.RowCount = 14;
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
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
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableWindowPatterns.Size = new System.Drawing.Size(967, 648);
            tableWindowPatterns.TabIndex = 0;
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
            this.colState});
            tableWindowPatterns.SetColumnSpan(this.listWindows, 6);
            this.listWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindows.FullRowSelect = true;
            this.listWindows.GridLines = true;
            this.listWindows.Location = new System.Drawing.Point(3, 4);
            this.listWindows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWindows.MultiSelect = false;
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(961, 222);
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
            // btnReloadWindowList
            // 
            this.btnReloadWindowList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReloadWindowList.Location = new System.Drawing.Point(794, 234);
            this.btnReloadWindowList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReloadWindowList.Name = "btnReloadWindowList";
            this.btnReloadWindowList.Size = new System.Drawing.Size(170, 27);
            this.btnReloadWindowList.TabIndex = 25;
            this.btnReloadWindowList.Text = "Refresh Window List";
            this.btnReloadWindowList.UseVisualStyleBackColor = true;
            this.btnReloadWindowList.Click += new System.EventHandler(this.ReloadWindowListHandler);
            // 
            // lblWindowPatternsCaption
            // 
            this.lblWindowPatternsCaption.AutoSize = true;
            this.lblWindowPatternsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowPatternsCaption.Location = new System.Drawing.Point(3, 234);
            this.lblWindowPatternsCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowPatternsCaption.Name = "lblWindowPatternsCaption";
            this.lblWindowPatternsCaption.Size = new System.Drawing.Size(227, 27);
            this.lblWindowPatternsCaption.TabIndex = 1;
            this.lblWindowPatternsCaption.Text = "Window Patterns:";
            this.lblWindowPatternsCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMatchCount
            // 
            this.lblMatchCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchCount.Location = new System.Drawing.Point(409, 476);
            this.lblMatchCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMatchCount.Name = "lblMatchCount";
            this.lblMatchCount.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblMatchCount.Size = new System.Drawing.Size(134, 31);
            this.lblMatchCount.TabIndex = 18;
            this.lblMatchCount.Text = "0";
            this.lblMatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRestoreWorkingDir
            // 
            this.lblRestoreWorkingDir.AutoSize = true;
            this.lblRestoreWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreWorkingDir.Location = new System.Drawing.Point(269, 575);
            this.lblRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreWorkingDir.Name = "lblRestoreWorkingDir";
            this.lblRestoreWorkingDir.Size = new System.Drawing.Size(134, 22);
            this.lblRestoreWorkingDir.TabIndex = 23;
            this.lblRestoreWorkingDir.Text = "Working Directory:";
            this.lblRestoreWorkingDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRestoreWorkingDir
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreWorkingDir, 3);
            this.txtRestoreWorkingDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WorkingDir", true));
            this.txtRestoreWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreWorkingDir.Location = new System.Drawing.Point(409, 575);
            this.txtRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestoreWorkingDir.Name = "txtRestoreWorkingDir";
            this.txtRestoreWorkingDir.Size = new System.Drawing.Size(555, 22);
            this.txtRestoreWorkingDir.TabIndex = 24;
            // 
            // windowPatternsBindingSource
            // 
            this.windowPatternsBindingSource.DataMember = "WindowPatterns";
            this.windowPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.windowPatternsBindingSource.CurrentChanged += new System.EventHandler(this.WindowPatternSelectionChangedHandler);
            this.windowPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedWindowPatternChangedHandler);
            this.windowPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.WindowPatternListChangedHandler);
            // 
            // listWindowPatterns
            // 
            this.listWindowPatterns.DataSource = this.windowPatternsBindingSource;
            this.listWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindowPatterns.FormattingEnabled = true;
            this.listWindowPatterns.IntegralHeight = false;
            this.listWindowPatterns.ItemHeight = 16;
            this.listWindowPatterns.Location = new System.Drawing.Point(3, 358);
            this.listWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWindowPatterns.Name = "listWindowPatterns";
            tableWindowPatterns.SetRowSpan(this.listWindowPatterns, 9);
            this.listWindowPatterns.Size = new System.Drawing.Size(227, 286);
            this.listWindowPatterns.TabIndex = 6;
            // 
            // lblWindowPatternName
            // 
            this.lblWindowPatternName.AutoSize = true;
            this.lblWindowPatternName.Location = new System.Drawing.Point(3, 304);
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
            this.chkWindowClassIgnoreCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowClassIgnoreCase.Location = new System.Drawing.Point(549, 417);
            this.chkWindowClassIgnoreCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowClassIgnoreCase.Name = "chkWindowClassIgnoreCase";
            this.chkWindowClassIgnoreCase.Size = new System.Drawing.Size(134, 21);
            this.chkWindowClassIgnoreCase.TabIndex = 14;
            this.chkWindowClassIgnoreCase.Text = "Ignore Case";
            this.chkWindowClassIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // txtRestoreCommandArgs
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreCommandArgs, 3);
            this.txtRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "CommandArgs", true));
            this.txtRestoreCommandArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreCommandArgs.Location = new System.Drawing.Point(409, 545);
            this.txtRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestoreCommandArgs.Name = "txtRestoreCommandArgs";
            this.txtRestoreCommandArgs.Size = new System.Drawing.Size(555, 22);
            this.txtRestoreCommandArgs.TabIndex = 22;
            // 
            // txtWindowPatternName
            // 
            this.txtWindowPatternName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWindowPatternName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWindowPatternName.Location = new System.Drawing.Point(3, 328);
            this.txtWindowPatternName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWindowPatternName.Name = "txtWindowPatternName";
            this.txtWindowPatternName.Size = new System.Drawing.Size(227, 22);
            this.txtWindowPatternName.TabIndex = 5;
            // 
            // txtRestoreCommand
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreCommand, 3);
            this.txtRestoreCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Command", true));
            this.txtRestoreCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreCommand.Location = new System.Drawing.Point(409, 515);
            this.txtRestoreCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestoreCommand.Name = "txtRestoreCommand";
            this.txtRestoreCommand.Size = new System.Drawing.Size(555, 22);
            this.txtRestoreCommand.TabIndex = 20;
            // 
            // lblRestoreCommandArgs
            // 
            this.lblRestoreCommandArgs.AutoSize = true;
            this.lblRestoreCommandArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreCommandArgs.Location = new System.Drawing.Point(269, 545);
            this.lblRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreCommandArgs.Name = "lblRestoreCommandArgs";
            this.lblRestoreCommandArgs.Size = new System.Drawing.Size(134, 22);
            this.lblRestoreCommandArgs.TabIndex = 21;
            this.lblRestoreCommandArgs.Text = "Command Args:";
            this.lblRestoreCommandArgs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRestoreCommand
            // 
            this.lblRestoreCommand.AutoSize = true;
            this.lblRestoreCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreCommand.Location = new System.Drawing.Point(269, 515);
            this.lblRestoreCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRestoreCommand.Name = "lblRestoreCommand";
            this.lblRestoreCommand.Size = new System.Drawing.Size(134, 22);
            this.lblRestoreCommand.TabIndex = 19;
            this.lblRestoreCommand.Text = "Command:";
            this.lblRestoreCommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkTitleIgnoreCase
            // 
            this.chkTitleIgnoreCase.AutoSize = true;
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "TitleIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTitleIgnoreCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTitleIgnoreCase.Location = new System.Drawing.Point(549, 358);
            this.chkTitleIgnoreCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTitleIgnoreCase.Name = "chkTitleIgnoreCase";
            this.chkTitleIgnoreCase.Size = new System.Drawing.Size(134, 21);
            this.chkTitleIgnoreCase.TabIndex = 10;
            this.chkTitleIgnoreCase.Text = "Ignore Case";
            this.chkTitleIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // cmbWindowClassPatternType
            // 
            this.cmbWindowClassPatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "WindowClassPatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowClassPatternType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowClassPatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowClassPatternType.FormattingEnabled = true;
            this.cmbWindowClassPatternType.Location = new System.Drawing.Point(409, 417);
            this.cmbWindowClassPatternType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowClassPatternType.Name = "cmbWindowClassPatternType";
            this.cmbWindowClassPatternType.Size = new System.Drawing.Size(134, 24);
            this.cmbWindowClassPatternType.TabIndex = 13;
            // 
            // txtTitlePattern
            // 
            tableWindowPatterns.SetColumnSpan(this.txtTitlePattern, 2);
            this.txtTitlePattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "TitlePattern", true));
            this.txtTitlePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitlePattern.Location = new System.Drawing.Point(409, 328);
            this.txtTitlePattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitlePattern.Name = "txtTitlePattern";
            this.txtTitlePattern.Size = new System.Drawing.Size(274, 22);
            this.txtTitlePattern.TabIndex = 8;
            // 
            // lblMatchCountCaption
            // 
            this.lblMatchCountCaption.AutoSize = true;
            this.lblMatchCountCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchCountCaption.Location = new System.Drawing.Point(269, 476);
            this.lblMatchCountCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMatchCountCaption.Name = "lblMatchCountCaption";
            this.lblMatchCountCaption.Size = new System.Drawing.Size(134, 31);
            this.lblMatchCountCaption.TabIndex = 17;
            this.lblMatchCountCaption.Text = "Matching:";
            this.lblMatchCountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcessFileName
            // 
            tableWindowPatterns.SetColumnSpan(this.txtProcessFileName, 3);
            this.txtProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "ProcessFileName", true));
            this.txtProcessFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcessFileName.Location = new System.Drawing.Point(409, 446);
            this.txtProcessFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessFileName.Name = "txtProcessFileName";
            this.txtProcessFileName.Size = new System.Drawing.Size(555, 22);
            this.txtProcessFileName.TabIndex = 16;
            // 
            // lblProcessFileName
            // 
            this.lblProcessFileName.AutoSize = true;
            this.lblProcessFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessFileName.Location = new System.Drawing.Point(269, 446);
            this.lblProcessFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblProcessFileName.Name = "lblProcessFileName";
            this.lblProcessFileName.Size = new System.Drawing.Size(134, 22);
            this.lblProcessFileName.TabIndex = 15;
            this.lblProcessFileName.Text = "Process File:";
            this.lblProcessFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitlePatternCaption
            // 
            this.lblTitlePatternCaption.AutoSize = true;
            this.lblTitlePatternCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitlePatternCaption.Location = new System.Drawing.Point(269, 328);
            this.lblTitlePatternCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitlePatternCaption.Name = "lblTitlePatternCaption";
            this.lblTitlePatternCaption.Size = new System.Drawing.Size(134, 22);
            this.lblTitlePatternCaption.TabIndex = 7;
            this.lblTitlePatternCaption.Text = "Window Title:";
            this.lblTitlePatternCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTitlePatternType
            // 
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "TitlePatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbTitlePatternType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTitlePatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitlePatternType.FormattingEnabled = true;
            this.cmbTitlePatternType.Location = new System.Drawing.Point(409, 358);
            this.cmbTitlePatternType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTitlePatternType.Name = "cmbTitlePatternType";
            this.cmbTitlePatternType.Size = new System.Drawing.Size(134, 24);
            this.cmbTitlePatternType.TabIndex = 9;
            // 
            // txtWindowClassPattern
            // 
            tableWindowPatterns.SetColumnSpan(this.txtWindowClassPattern, 3);
            this.txtWindowClassPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WindowClassPattern", true));
            this.txtWindowClassPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWindowClassPattern.Location = new System.Drawing.Point(409, 387);
            this.txtWindowClassPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWindowClassPattern.Name = "txtWindowClassPattern";
            this.txtWindowClassPattern.Size = new System.Drawing.Size(555, 22);
            this.txtWindowClassPattern.TabIndex = 12;
            // 
            // lblWindowClassPatternCaption
            // 
            this.lblWindowClassPatternCaption.AutoSize = true;
            this.lblWindowClassPatternCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowClassPatternCaption.Location = new System.Drawing.Point(269, 387);
            this.lblWindowClassPatternCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowClassPatternCaption.Name = "lblWindowClassPatternCaption";
            this.lblWindowClassPatternCaption.Size = new System.Drawing.Size(134, 22);
            this.lblWindowClassPatternCaption.TabIndex = 11;
            this.lblWindowClassPatternCaption.Text = "Window Class:";
            this.lblWindowClassPatternCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewWindowPattern
            // 
            this.btnNewWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowPattern.Location = new System.Drawing.Point(3, 269);
            this.btnNewWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewWindowPattern.Name = "btnNewWindowPattern";
            this.btnNewWindowPattern.Size = new System.Drawing.Size(227, 27);
            this.btnNewWindowPattern.TabIndex = 2;
            this.btnNewWindowPattern.Text = "New Window Pattern";
            this.btnNewWindowPattern.UseVisualStyleBackColor = true;
            this.btnNewWindowPattern.Click += new System.EventHandler(this.NewWindowPatternHandler);
            // 
            // flowWindowPatternActions
            // 
            flowWindowPatternActions.Controls.Add(this.btnMoveUpWindowPattern);
            flowWindowPatternActions.Controls.Add(this.btnMoveDownWindowPattern);
            flowWindowPatternActions.Controls.Add(this.btnSortWindowPatterns);
            flowWindowPatternActions.Controls.Add(this.btnDuplicateWindowPattern);
            flowWindowPatternActions.Controls.Add(this.btnDeleteWindowPattern);
            flowWindowPatternActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flowWindowPatternActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowWindowPatternActions.Location = new System.Drawing.Point(233, 354);
            flowWindowPatternActions.Margin = new System.Windows.Forms.Padding(0);
            flowWindowPatternActions.Name = "flowWindowPatternActions";
            tableWindowPatterns.SetRowSpan(flowWindowPatternActions, 9);
            flowWindowPatternActions.Size = new System.Drawing.Size(33, 294);
            flowWindowPatternActions.TabIndex = 29;
            // 
            // btnMoveUpWindowPattern
            // 
            this.btnMoveUpWindowPattern.Location = new System.Drawing.Point(3, 4);
            this.btnMoveUpWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpWindowPattern.Name = "btnMoveUpWindowPattern";
            this.btnMoveUpWindowPattern.Size = new System.Drawing.Size(27, 27);
            this.btnMoveUpWindowPattern.TabIndex = 26;
            this.btnMoveUpWindowPattern.Text = "^";
            this.btnMoveUpWindowPattern.UseVisualStyleBackColor = true;
            this.btnMoveUpWindowPattern.Click += new System.EventHandler(this.MoveUpWindowPatternHandler);
            // 
            // btnMoveDownWindowPattern
            // 
            this.btnMoveDownWindowPattern.Location = new System.Drawing.Point(3, 35);
            this.btnMoveDownWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownWindowPattern.Name = "btnMoveDownWindowPattern";
            this.btnMoveDownWindowPattern.Size = new System.Drawing.Size(27, 27);
            this.btnMoveDownWindowPattern.TabIndex = 27;
            this.btnMoveDownWindowPattern.Text = "v";
            this.btnMoveDownWindowPattern.UseVisualStyleBackColor = true;
            this.btnMoveDownWindowPattern.Click += new System.EventHandler(this.MoveDownWindowPatternHandler);
            // 
            // btnSortWindowPatterns
            // 
            this.btnSortWindowPatterns.Location = new System.Drawing.Point(3, 66);
            this.btnSortWindowPatterns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortWindowPatterns.Name = "btnSortWindowPatterns";
            this.btnSortWindowPatterns.Size = new System.Drawing.Size(27, 27);
            this.btnSortWindowPatterns.TabIndex = 29;
            this.btnSortWindowPatterns.Text = "s";
            this.btnSortWindowPatterns.UseVisualStyleBackColor = true;
            this.btnSortWindowPatterns.Click += new System.EventHandler(this.SortWindowPatternsHandler);
            // 
            // btnDuplicateWindowPattern
            // 
            this.btnDuplicateWindowPattern.Location = new System.Drawing.Point(3, 97);
            this.btnDuplicateWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDuplicateWindowPattern.Name = "btnDuplicateWindowPattern";
            this.btnDuplicateWindowPattern.Size = new System.Drawing.Size(27, 27);
            this.btnDuplicateWindowPattern.TabIndex = 28;
            this.btnDuplicateWindowPattern.Text = "d";
            this.btnDuplicateWindowPattern.UseVisualStyleBackColor = true;
            this.btnDuplicateWindowPattern.Click += new System.EventHandler(this.DuplicateWindowPatternHandler);
            // 
            // btnDeleteWindowPattern
            // 
            this.btnDeleteWindowPattern.Location = new System.Drawing.Point(3, 128);
            this.btnDeleteWindowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteWindowPattern.Name = "btnDeleteWindowPattern";
            this.btnDeleteWindowPattern.Size = new System.Drawing.Size(27, 27);
            this.btnDeleteWindowPattern.TabIndex = 3;
            this.btnDeleteWindowPattern.Text = "x";
            this.btnDeleteWindowPattern.UseVisualStyleBackColor = true;
            this.btnDeleteWindowPattern.Click += new System.EventHandler(this.DeleteWindowPatternHandler);
            // 
            // tableLayouts
            // 
            tableLayouts.ColumnCount = 2;
            tableLayouts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayouts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayouts.Controls.Add(this.previewLayout, 1, 0);
            tableLayouts.Controls.Add(tableLayoutList, 0, 0);
            tableLayouts.Controls.Add(tableLayoutDetails, 1, 1);
            tableLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayouts.Location = new System.Drawing.Point(3, 4);
            tableLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayouts.Name = "tableLayouts";
            tableLayouts.RowCount = 2;
            tableLayouts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayouts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tableLayouts.Size = new System.Drawing.Size(967, 648);
            tableLayouts.TabIndex = 0;
            // 
            // previewLayout
            // 
            this.previewLayout.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewLayout.Location = new System.Drawing.Point(244, 4);
            this.previewLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(720, 283);
            this.previewLayout.TabIndex = 1;
            this.previewLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPreviewPaintHandler);
            // 
            // tableLayoutList
            // 
            tableLayoutList.ColumnCount = 2;
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutList.Controls.Add(this.btnNewLayout, 0, 0);
            tableLayoutList.Controls.Add(this.lblLayoutNameCaption, 0, 1);
            tableLayoutList.Controls.Add(this.txtLayoutName, 0, 2);
            tableLayoutList.Controls.Add(this.chkLayoutIsDefaultLayout, 0, 3);
            tableLayoutList.Controls.Add(this.lblConfigurationPatternCaption, 0, 4);
            tableLayoutList.Controls.Add(this.cmbLayoutConfiguration, 0, 5);
            tableLayoutList.Controls.Add(this.listLayouts, 0, 6);
            tableLayoutList.Controls.Add(flowLayoutActions, 1, 6);
            tableLayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutList.Location = new System.Drawing.Point(3, 4);
            tableLayoutList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutList.Name = "tableLayoutList";
            tableLayoutList.RowCount = 7;
            tableLayouts.SetRowSpan(tableLayoutList, 2);
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutList.Size = new System.Drawing.Size(235, 640);
            tableLayoutList.TabIndex = 0;
            // 
            // btnNewLayout
            // 
            this.btnNewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewLayout.Location = new System.Drawing.Point(3, 4);
            this.btnNewLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewLayout.Name = "btnNewLayout";
            this.btnNewLayout.Size = new System.Drawing.Size(196, 27);
            this.btnNewLayout.TabIndex = 0;
            this.btnNewLayout.Text = "New Layout";
            this.btnNewLayout.UseVisualStyleBackColor = true;
            this.btnNewLayout.Click += new System.EventHandler(this.NewLayoutHandler);
            // 
            // lblLayoutNameCaption
            // 
            this.lblLayoutNameCaption.AutoSize = true;
            this.lblLayoutNameCaption.Location = new System.Drawing.Point(3, 39);
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
            this.txtLayoutName.Location = new System.Drawing.Point(3, 63);
            this.txtLayoutName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLayoutName.Name = "txtLayoutName";
            this.txtLayoutName.Size = new System.Drawing.Size(196, 22);
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
            this.chkLayoutIsDefaultLayout.Location = new System.Drawing.Point(3, 93);
            this.chkLayoutIsDefaultLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLayoutIsDefaultLayout.Name = "chkLayoutIsDefaultLayout";
            this.chkLayoutIsDefaultLayout.Size = new System.Drawing.Size(196, 20);
            this.chkLayoutIsDefaultLayout.TabIndex = 4;
            this.chkLayoutIsDefaultLayout.Text = "Default Layout";
            this.chkLayoutIsDefaultLayout.UseVisualStyleBackColor = true;
            // 
            // lblConfigurationPatternCaption
            // 
            this.lblConfigurationPatternCaption.AutoSize = true;
            this.lblConfigurationPatternCaption.Location = new System.Drawing.Point(3, 121);
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
            this.cmbLayoutConfiguration.Location = new System.Drawing.Point(3, 145);
            this.cmbLayoutConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLayoutConfiguration.Name = "cmbLayoutConfiguration";
            this.cmbLayoutConfiguration.Size = new System.Drawing.Size(196, 24);
            this.cmbLayoutConfiguration.TabIndex = 6;
            // 
            // listLayouts
            // 
            this.listLayouts.DataSource = this.layoutsBindingSource;
            this.listLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLayouts.FormattingEnabled = true;
            this.listLayouts.IntegralHeight = false;
            this.listLayouts.ItemHeight = 16;
            this.listLayouts.Location = new System.Drawing.Point(3, 177);
            this.listLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listLayouts.Name = "listLayouts";
            this.listLayouts.Size = new System.Drawing.Size(196, 459);
            this.listLayouts.TabIndex = 7;
            // 
            // flowLayoutActions
            // 
            flowLayoutActions.Controls.Add(this.btnMoveUpLayout);
            flowLayoutActions.Controls.Add(this.btnMoveDownLayout);
            flowLayoutActions.Controls.Add(this.btnSortLayouts);
            flowLayoutActions.Controls.Add(this.btnDuplicateLayout);
            flowLayoutActions.Controls.Add(this.btnDeleteLayout);
            flowLayoutActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutActions.Location = new System.Drawing.Point(202, 173);
            flowLayoutActions.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutActions.Name = "flowLayoutActions";
            flowLayoutActions.Size = new System.Drawing.Size(33, 467);
            flowLayoutActions.TabIndex = 30;
            // 
            // btnMoveUpLayout
            // 
            this.btnMoveUpLayout.Location = new System.Drawing.Point(3, 4);
            this.btnMoveUpLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpLayout.Name = "btnMoveUpLayout";
            this.btnMoveUpLayout.Size = new System.Drawing.Size(27, 27);
            this.btnMoveUpLayout.TabIndex = 27;
            this.btnMoveUpLayout.Text = "^";
            this.btnMoveUpLayout.UseVisualStyleBackColor = true;
            this.btnMoveUpLayout.Click += new System.EventHandler(this.MoveUpLayoutHandler);
            // 
            // btnMoveDownLayout
            // 
            this.btnMoveDownLayout.Location = new System.Drawing.Point(3, 35);
            this.btnMoveDownLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownLayout.Name = "btnMoveDownLayout";
            this.btnMoveDownLayout.Size = new System.Drawing.Size(27, 27);
            this.btnMoveDownLayout.TabIndex = 28;
            this.btnMoveDownLayout.Text = "v";
            this.btnMoveDownLayout.UseVisualStyleBackColor = true;
            this.btnMoveDownLayout.Click += new System.EventHandler(this.MoveDownLayoutHandler);
            // 
            // btnSortLayouts
            // 
            this.btnSortLayouts.Location = new System.Drawing.Point(3, 66);
            this.btnSortLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortLayouts.Name = "btnSortLayouts";
            this.btnSortLayouts.Size = new System.Drawing.Size(27, 27);
            this.btnSortLayouts.TabIndex = 30;
            this.btnSortLayouts.Text = "s";
            this.btnSortLayouts.UseVisualStyleBackColor = true;
            this.btnSortLayouts.Click += new System.EventHandler(this.SortLayoutsHandler);
            // 
            // btnDuplicateLayout
            // 
            this.btnDuplicateLayout.Enabled = false;
            this.btnDuplicateLayout.Location = new System.Drawing.Point(3, 97);
            this.btnDuplicateLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDuplicateLayout.Name = "btnDuplicateLayout";
            this.btnDuplicateLayout.Size = new System.Drawing.Size(27, 27);
            this.btnDuplicateLayout.TabIndex = 29;
            this.btnDuplicateLayout.Text = "d";
            this.btnDuplicateLayout.UseVisualStyleBackColor = true;
            this.btnDuplicateLayout.Click += new System.EventHandler(this.DuplicateLayoutHandler);
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Location = new System.Drawing.Point(3, 128);
            this.btnDeleteLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(27, 27);
            this.btnDeleteLayout.TabIndex = 1;
            this.btnDeleteLayout.Text = "x";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.DeleteLayoutHandler);
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 6;
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
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
            tableLayoutDetails.Controls.Add(this.chkWindowActionRestore, 3, 1);
            tableLayoutDetails.Controls.Add(this.numWindowActionTop, 3, 7);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionWindow, 3, 2);
            tableLayoutDetails.Controls.Add(this.numWindowActionLeft, 3, 6);
            tableLayoutDetails.Controls.Add(this.lblWindowActionWindowCaption, 2, 2);
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
            tableLayoutDetails.Controls.Add(this.btnRecordWindowPosition, 5, 1);
            tableLayoutDetails.Controls.Add(flowWindowActionActions, 1, 2);
            tableLayoutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutDetails.Location = new System.Drawing.Point(244, 295);
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
            tableLayoutDetails.Size = new System.Drawing.Size(720, 349);
            tableLayoutDetails.TabIndex = 2;
            // 
            // lblWindowActionsCaption
            // 
            this.lblWindowActionsCaption.AutoSize = true;
            this.lblWindowActionsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionsCaption.Location = new System.Drawing.Point(3, 4);
            this.lblWindowActionsCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionsCaption.Name = "lblWindowActionsCaption";
            this.lblWindowActionsCaption.Size = new System.Drawing.Size(186, 16);
            this.lblWindowActionsCaption.TabIndex = 0;
            this.lblWindowActionsCaption.Text = "Window Actions:";
            this.lblWindowActionsCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkWindowActionBottomInvert
            // 
            this.chkWindowActionBottomInvert.AutoSize = true;
            this.chkWindowActionBottomInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "BottomInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionBottomInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionBottomInvert.Location = new System.Drawing.Point(597, 279);
            this.chkWindowActionBottomInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionBottomInvert.Name = "chkWindowActionBottomInvert";
            this.chkWindowActionBottomInvert.Size = new System.Drawing.Size(120, 22);
            this.chkWindowActionBottomInvert.TabIndex = 28;
            this.chkWindowActionBottomInvert.Text = "from Bottom";
            this.chkWindowActionBottomInvert.UseVisualStyleBackColor = true;
            // 
            // windowActionsBindingSource
            // 
            this.windowActionsBindingSource.DataMember = "Windows";
            this.windowActionsBindingSource.DataSource = this.layoutsBindingSource;
            this.windowActionsBindingSource.CurrentChanged += new System.EventHandler(this.WindowActionSelectionChangedHandler);
            this.windowActionsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedWindowActionChangedHandler);
            // 
            // chkWindowActionCompensateOsMargin
            // 
            this.chkWindowActionCompensateOsMargin.AutoSize = true;
            tableLayoutDetails.SetColumnSpan(this.chkWindowActionCompensateOsMargin, 2);
            this.chkWindowActionCompensateOsMargin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "CompensateOsMargin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionCompensateOsMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionCompensateOsMargin.Location = new System.Drawing.Point(351, 309);
            this.chkWindowActionCompensateOsMargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionCompensateOsMargin.Name = "chkWindowActionCompensateOsMargin";
            this.chkWindowActionCompensateOsMargin.Size = new System.Drawing.Size(240, 20);
            this.chkWindowActionCompensateOsMargin.TabIndex = 29;
            this.chkWindowActionCompensateOsMargin.Text = "Compensate OS Margin";
            this.chkWindowActionCompensateOsMargin.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionRightInvert
            // 
            this.chkWindowActionRightInvert.AutoSize = true;
            this.chkWindowActionRightInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "RightInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionRightInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionRightInvert.Location = new System.Drawing.Point(597, 249);
            this.chkWindowActionRightInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionRightInvert.Name = "chkWindowActionRightInvert";
            this.chkWindowActionRightInvert.Size = new System.Drawing.Size(120, 22);
            this.chkWindowActionRightInvert.TabIndex = 24;
            this.chkWindowActionRightInvert.Text = "from Right";
            this.chkWindowActionRightInvert.UseVisualStyleBackColor = true;
            // 
            // btnNewWindowAction
            // 
            this.btnNewWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowAction.Location = new System.Drawing.Point(3, 28);
            this.btnNewWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewWindowAction.Name = "btnNewWindowAction";
            this.btnNewWindowAction.Size = new System.Drawing.Size(186, 27);
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
            this.chkWindowActionTopInvert.Location = new System.Drawing.Point(597, 219);
            this.chkWindowActionTopInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionTopInvert.Name = "chkWindowActionTopInvert";
            this.chkWindowActionTopInvert.Size = new System.Drawing.Size(120, 22);
            this.chkWindowActionTopInvert.TabIndex = 20;
            this.chkWindowActionTopInvert.Text = "from Bottom";
            this.chkWindowActionTopInvert.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionLeftInvert
            // 
            this.chkWindowActionLeftInvert.AutoSize = true;
            this.chkWindowActionLeftInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "LeftInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionLeftInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionLeftInvert.Location = new System.Drawing.Point(597, 189);
            this.chkWindowActionLeftInvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionLeftInvert.Name = "chkWindowActionLeftInvert";
            this.chkWindowActionLeftInvert.Size = new System.Drawing.Size(120, 22);
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
            this.listWindowAction.Location = new System.Drawing.Point(3, 63);
            this.listWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWindowAction.Name = "listWindowAction";
            tableLayoutDetails.SetRowSpan(this.listWindowAction, 10);
            this.listWindowAction.Size = new System.Drawing.Size(186, 282);
            this.listWindowAction.TabIndex = 3;
            // 
            // cmbWindowActionBottomUnit
            // 
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "BottomUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionBottomUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionBottomUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionBottomUnit.FormattingEnabled = true;
            this.cmbWindowActionBottomUnit.Location = new System.Drawing.Point(474, 279);
            this.cmbWindowActionBottomUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionBottomUnit.Name = "cmbWindowActionBottomUnit";
            this.cmbWindowActionBottomUnit.Size = new System.Drawing.Size(117, 24);
            this.cmbWindowActionBottomUnit.TabIndex = 27;
            // 
            // numWindowActionBottom
            // 
            this.numWindowActionBottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Bottom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionBottom.Location = new System.Drawing.Point(351, 279);
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
            this.numWindowActionBottom.Size = new System.Drawing.Size(117, 22);
            this.numWindowActionBottom.TabIndex = 26;
            // 
            // cmbWindowActionRightUnit
            // 
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "RightUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionRightUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionRightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionRightUnit.FormattingEnabled = true;
            this.cmbWindowActionRightUnit.Location = new System.Drawing.Point(474, 249);
            this.cmbWindowActionRightUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionRightUnit.Name = "cmbWindowActionRightUnit";
            this.cmbWindowActionRightUnit.Size = new System.Drawing.Size(117, 24);
            this.cmbWindowActionRightUnit.TabIndex = 23;
            // 
            // cmbWindowActionTopUnit
            // 
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "TopUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionTopUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionTopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionTopUnit.FormattingEnabled = true;
            this.cmbWindowActionTopUnit.Location = new System.Drawing.Point(474, 219);
            this.cmbWindowActionTopUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionTopUnit.Name = "cmbWindowActionTopUnit";
            this.cmbWindowActionTopUnit.Size = new System.Drawing.Size(117, 24);
            this.cmbWindowActionTopUnit.TabIndex = 19;
            // 
            // numWindowActionRight
            // 
            this.numWindowActionRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Right", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionRight.Location = new System.Drawing.Point(351, 249);
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
            this.numWindowActionRight.Size = new System.Drawing.Size(117, 22);
            this.numWindowActionRight.TabIndex = 22;
            // 
            // cmbWindowActionLeftUnit
            // 
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "LeftUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionLeftUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionLeftUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionLeftUnit.FormattingEnabled = true;
            this.cmbWindowActionLeftUnit.Location = new System.Drawing.Point(474, 189);
            this.cmbWindowActionLeftUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionLeftUnit.Name = "cmbWindowActionLeftUnit";
            this.cmbWindowActionLeftUnit.Size = new System.Drawing.Size(117, 24);
            this.cmbWindowActionLeftUnit.TabIndex = 15;
            // 
            // chkWindowActionRestore
            // 
            this.chkWindowActionRestore.AutoSize = true;
            this.chkWindowActionRestore.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "Restore", true));
            this.chkWindowActionRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionRestore.Location = new System.Drawing.Point(351, 28);
            this.chkWindowActionRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWindowActionRestore.Name = "chkWindowActionRestore";
            this.chkWindowActionRestore.Size = new System.Drawing.Size(117, 27);
            this.chkWindowActionRestore.TabIndex = 4;
            this.chkWindowActionRestore.Text = "Restore";
            this.chkWindowActionRestore.UseVisualStyleBackColor = true;
            // 
            // numWindowActionTop
            // 
            this.numWindowActionTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionTop.Location = new System.Drawing.Point(351, 219);
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
            this.numWindowActionTop.Size = new System.Drawing.Size(117, 22);
            this.numWindowActionTop.TabIndex = 18;
            // 
            // cmbWindowActionWindow
            // 
            tableLayoutDetails.SetColumnSpan(this.cmbWindowActionWindow, 2);
            this.cmbWindowActionWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Window", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionWindow.FormattingEnabled = true;
            this.cmbWindowActionWindow.Location = new System.Drawing.Point(351, 63);
            this.cmbWindowActionWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionWindow.Name = "cmbWindowActionWindow";
            this.cmbWindowActionWindow.Size = new System.Drawing.Size(240, 24);
            this.cmbWindowActionWindow.TabIndex = 6;
            // 
            // numWindowActionLeft
            // 
            this.numWindowActionLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionLeft.Location = new System.Drawing.Point(351, 189);
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
            this.numWindowActionLeft.Size = new System.Drawing.Size(117, 22);
            this.numWindowActionLeft.TabIndex = 14;
            // 
            // lblWindowActionWindowCaption
            // 
            this.lblWindowActionWindowCaption.AutoSize = true;
            this.lblWindowActionWindowCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionWindowCaption.Location = new System.Drawing.Point(228, 63);
            this.lblWindowActionWindowCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionWindowCaption.Name = "lblWindowActionWindowCaption";
            this.lblWindowActionWindowCaption.Size = new System.Drawing.Size(117, 24);
            this.lblWindowActionWindowCaption.TabIndex = 5;
            this.lblWindowActionWindowCaption.Text = "Window Pattern:";
            this.lblWindowActionWindowCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionVirtualDesktop
            // 
            this.lblWindowActionVirtualDesktop.AutoSize = true;
            this.lblWindowActionVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionVirtualDesktop.Location = new System.Drawing.Point(228, 95);
            this.lblWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionVirtualDesktop.Name = "lblWindowActionVirtualDesktop";
            this.lblWindowActionVirtualDesktop.Size = new System.Drawing.Size(117, 22);
            this.lblWindowActionVirtualDesktop.TabIndex = 7;
            this.lblWindowActionVirtualDesktop.Text = "Virtual Desktop:";
            this.lblWindowActionVirtualDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numWindowActionVirtualDesktop
            // 
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "VirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionVirtualDesktop.Location = new System.Drawing.Point(351, 95);
            this.numWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numWindowActionVirtualDesktop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowActionVirtualDesktop.Name = "numWindowActionVirtualDesktop";
            this.numWindowActionVirtualDesktop.Size = new System.Drawing.Size(117, 22);
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
            this.lblWindowActionBottomCaption.Location = new System.Drawing.Point(228, 279);
            this.lblWindowActionBottomCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionBottomCaption.Name = "lblWindowActionBottomCaption";
            this.lblWindowActionBottomCaption.Size = new System.Drawing.Size(117, 22);
            this.lblWindowActionBottomCaption.TabIndex = 25;
            this.lblWindowActionBottomCaption.Text = "Bottom:";
            this.lblWindowActionBottomCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionScreenCaption
            // 
            this.lblWindowActionScreenCaption.AutoSize = true;
            this.lblWindowActionScreenCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionScreenCaption.Location = new System.Drawing.Point(228, 125);
            this.lblWindowActionScreenCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionScreenCaption.Name = "lblWindowActionScreenCaption";
            this.lblWindowActionScreenCaption.Size = new System.Drawing.Size(117, 24);
            this.lblWindowActionScreenCaption.TabIndex = 9;
            this.lblWindowActionScreenCaption.Text = "Screen:";
            this.lblWindowActionScreenCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionRightCaption
            // 
            this.lblWindowActionRightCaption.AutoSize = true;
            this.lblWindowActionRightCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionRightCaption.Location = new System.Drawing.Point(228, 249);
            this.lblWindowActionRightCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionRightCaption.Name = "lblWindowActionRightCaption";
            this.lblWindowActionRightCaption.Size = new System.Drawing.Size(117, 22);
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
            this.cmbWindowActionScreen.Location = new System.Drawing.Point(351, 125);
            this.cmbWindowActionScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionScreen.Name = "cmbWindowActionScreen";
            this.cmbWindowActionScreen.Size = new System.Drawing.Size(240, 24);
            this.cmbWindowActionScreen.TabIndex = 10;
            this.cmbWindowActionScreen.ValueMember = "Name";
            // 
            // lblWindowActionTopCaption
            // 
            this.lblWindowActionTopCaption.AutoSize = true;
            this.lblWindowActionTopCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionTopCaption.Location = new System.Drawing.Point(228, 219);
            this.lblWindowActionTopCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionTopCaption.Name = "lblWindowActionTopCaption";
            this.lblWindowActionTopCaption.Size = new System.Drawing.Size(117, 22);
            this.lblWindowActionTopCaption.TabIndex = 17;
            this.lblWindowActionTopCaption.Text = "Top:";
            this.lblWindowActionTopCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionWindowStateCaption
            // 
            this.lblWindowActionWindowStateCaption.AutoSize = true;
            this.lblWindowActionWindowStateCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionWindowStateCaption.Location = new System.Drawing.Point(228, 157);
            this.lblWindowActionWindowStateCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionWindowStateCaption.Name = "lblWindowActionWindowStateCaption";
            this.lblWindowActionWindowStateCaption.Size = new System.Drawing.Size(117, 24);
            this.lblWindowActionWindowStateCaption.TabIndex = 11;
            this.lblWindowActionWindowStateCaption.Text = "Window State:";
            this.lblWindowActionWindowStateCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionLeftCaption
            // 
            this.lblWindowActionLeftCaption.AutoSize = true;
            this.lblWindowActionLeftCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionLeftCaption.Location = new System.Drawing.Point(228, 189);
            this.lblWindowActionLeftCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWindowActionLeftCaption.Name = "lblWindowActionLeftCaption";
            this.lblWindowActionLeftCaption.Size = new System.Drawing.Size(117, 22);
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
            this.cmbWindowActionWindowState.Location = new System.Drawing.Point(351, 157);
            this.cmbWindowActionWindowState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbWindowActionWindowState.Name = "cmbWindowActionWindowState";
            this.cmbWindowActionWindowState.Size = new System.Drawing.Size(240, 24);
            this.cmbWindowActionWindowState.TabIndex = 12;
            this.cmbWindowActionWindowState.ValueMember = "Name";
            // 
            // btnRecordWindowPosition
            // 
            this.btnRecordWindowPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecordWindowPosition.Location = new System.Drawing.Point(597, 27);
            this.btnRecordWindowPosition.Name = "btnRecordWindowPosition";
            this.btnRecordWindowPosition.Size = new System.Drawing.Size(120, 29);
            this.btnRecordWindowPosition.TabIndex = 30;
            this.btnRecordWindowPosition.Text = "Record Position";
            this.btnRecordWindowPosition.UseVisualStyleBackColor = true;
            this.btnRecordWindowPosition.Click += new System.EventHandler(this.RecordWindowPositionHandler);
            // 
            // flowWindowActionActions
            // 
            flowWindowActionActions.Controls.Add(this.btnMoveUpWindowAction);
            flowWindowActionActions.Controls.Add(this.btnMoveDownWindowAction);
            flowWindowActionActions.Controls.Add(this.btnSortWindowActions);
            flowWindowActionActions.Controls.Add(this.btnDuplicateWindowAction);
            flowWindowActionActions.Controls.Add(this.btnDeleteWindowAction);
            flowWindowActionActions.Dock = System.Windows.Forms.DockStyle.Fill;
            flowWindowActionActions.Location = new System.Drawing.Point(192, 59);
            flowWindowActionActions.Margin = new System.Windows.Forms.Padding(0);
            flowWindowActionActions.Name = "flowWindowActionActions";
            tableLayoutDetails.SetRowSpan(flowWindowActionActions, 10);
            flowWindowActionActions.Size = new System.Drawing.Size(33, 290);
            flowWindowActionActions.TabIndex = 31;
            // 
            // btnMoveUpWindowAction
            // 
            this.btnMoveUpWindowAction.Location = new System.Drawing.Point(3, 4);
            this.btnMoveUpWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveUpWindowAction.Name = "btnMoveUpWindowAction";
            this.btnMoveUpWindowAction.Size = new System.Drawing.Size(27, 27);
            this.btnMoveUpWindowAction.TabIndex = 3;
            this.btnMoveUpWindowAction.Text = "^";
            this.btnMoveUpWindowAction.UseVisualStyleBackColor = true;
            this.btnMoveUpWindowAction.Click += new System.EventHandler(this.MoveUpWindowActionHandler);
            // 
            // btnMoveDownWindowAction
            // 
            this.btnMoveDownWindowAction.Location = new System.Drawing.Point(3, 35);
            this.btnMoveDownWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnMoveDownWindowAction.Name = "btnMoveDownWindowAction";
            this.btnMoveDownWindowAction.Size = new System.Drawing.Size(27, 27);
            this.btnMoveDownWindowAction.TabIndex = 4;
            this.btnMoveDownWindowAction.Text = "v";
            this.btnMoveDownWindowAction.UseVisualStyleBackColor = true;
            this.btnMoveDownWindowAction.Click += new System.EventHandler(this.MoveDownWindowActionHandler);
            // 
            // btnSortWindowActions
            // 
            this.btnSortWindowActions.Location = new System.Drawing.Point(3, 66);
            this.btnSortWindowActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnSortWindowActions.Name = "btnSortWindowActions";
            this.btnSortWindowActions.Size = new System.Drawing.Size(27, 27);
            this.btnSortWindowActions.TabIndex = 29;
            this.btnSortWindowActions.Text = "s";
            this.btnSortWindowActions.UseVisualStyleBackColor = true;
            this.btnSortWindowActions.Click += new System.EventHandler(this.SortWindowActionsHandler);
            // 
            // btnDuplicateWindowAction
            // 
            this.btnDuplicateWindowAction.Location = new System.Drawing.Point(3, 97);
            this.btnDuplicateWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDuplicateWindowAction.Name = "btnDuplicateWindowAction";
            this.btnDuplicateWindowAction.Size = new System.Drawing.Size(27, 27);
            this.btnDuplicateWindowAction.TabIndex = 5;
            this.btnDuplicateWindowAction.Text = "d";
            this.btnDuplicateWindowAction.UseVisualStyleBackColor = true;
            this.btnDuplicateWindowAction.Click += new System.EventHandler(this.DuplicateWindowActionHandler);
            // 
            // btnDeleteWindowAction
            // 
            this.btnDeleteWindowAction.Location = new System.Drawing.Point(3, 128);
            this.btnDeleteWindowAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnDeleteWindowAction.Name = "btnDeleteWindowAction";
            this.btnDeleteWindowAction.Size = new System.Drawing.Size(27, 27);
            this.btnDeleteWindowAction.TabIndex = 2;
            this.btnDeleteWindowAction.Text = "x";
            this.btnDeleteWindowAction.UseVisualStyleBackColor = true;
            this.btnDeleteWindowAction.Click += new System.EventHandler(this.DeleteWindowActionHandler);
            // 
            // tableLayoutOptions
            // 
            tableLayoutOptions.ColumnCount = 2;
            tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutOptions.Controls.Add(this.tableLayoutOsWindowMargin, 0, 1);
            tableLayoutOptions.Controls.Add(this.lblOsWindowMarginCaption, 0, 0);
            tableLayoutOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutOptions.Location = new System.Drawing.Point(3, 3);
            tableLayoutOptions.Name = "tableLayoutOptions";
            tableLayoutOptions.RowCount = 3;
            tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutOptions.Size = new System.Drawing.Size(967, 650);
            tableLayoutOptions.TabIndex = 0;
            // 
            // tableLayoutOsWindowMargin
            // 
            this.tableLayoutOsWindowMargin.ColumnCount = 2;
            this.tableLayoutOsWindowMargin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOsWindowMargin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginBottom, 1, 3);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginRight, 1, 2);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginTop, 1, 1);
            this.tableLayoutOsWindowMargin.Controls.Add(this.numOsWindowMarginLeft, 1, 0);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginBottom, 0, 3);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginRight, 0, 2);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginTop, 0, 1);
            this.tableLayoutOsWindowMargin.Controls.Add(this.lblOsWindowMarginLeft, 0, 0);
            this.tableLayoutOsWindowMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOsWindowMargin.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutOsWindowMargin.Name = "tableLayoutOsWindowMargin";
            this.tableLayoutOsWindowMargin.RowCount = 5;
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutOsWindowMargin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOsWindowMargin.Size = new System.Drawing.Size(235, 307);
            this.tableLayoutOsWindowMargin.TabIndex = 0;
            // 
            // numOsWindowMarginBottom
            // 
            this.numOsWindowMarginBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginBottom.Location = new System.Drawing.Point(120, 94);
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
            this.numOsWindowMarginBottom.Size = new System.Drawing.Size(112, 22);
            this.numOsWindowMarginBottom.TabIndex = 18;
            // 
            // numOsWindowMarginRight
            // 
            this.numOsWindowMarginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginRight.Location = new System.Drawing.Point(120, 64);
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
            this.numOsWindowMarginRight.Size = new System.Drawing.Size(112, 22);
            this.numOsWindowMarginRight.TabIndex = 17;
            // 
            // numOsWindowMarginTop
            // 
            this.numOsWindowMarginTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginTop.Location = new System.Drawing.Point(120, 34);
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
            this.numOsWindowMarginTop.Size = new System.Drawing.Size(112, 22);
            this.numOsWindowMarginTop.TabIndex = 16;
            // 
            // numOsWindowMarginLeft
            // 
            this.numOsWindowMarginLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOsWindowMarginLeft.Location = new System.Drawing.Point(120, 4);
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
            this.numOsWindowMarginLeft.Size = new System.Drawing.Size(112, 22);
            this.numOsWindowMarginLeft.TabIndex = 15;
            // 
            // lblOsWindowMarginBottom
            // 
            this.lblOsWindowMarginBottom.AutoSize = true;
            this.lblOsWindowMarginBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginBottom.Location = new System.Drawing.Point(3, 94);
            this.lblOsWindowMarginBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginBottom.Name = "lblOsWindowMarginBottom";
            this.lblOsWindowMarginBottom.Size = new System.Drawing.Size(111, 22);
            this.lblOsWindowMarginBottom.TabIndex = 3;
            this.lblOsWindowMarginBottom.Text = "Bottom:";
            this.lblOsWindowMarginBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginRight
            // 
            this.lblOsWindowMarginRight.AutoSize = true;
            this.lblOsWindowMarginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginRight.Location = new System.Drawing.Point(3, 64);
            this.lblOsWindowMarginRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginRight.Name = "lblOsWindowMarginRight";
            this.lblOsWindowMarginRight.Size = new System.Drawing.Size(111, 22);
            this.lblOsWindowMarginRight.TabIndex = 2;
            this.lblOsWindowMarginRight.Text = "Right:";
            this.lblOsWindowMarginRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginTop
            // 
            this.lblOsWindowMarginTop.AutoSize = true;
            this.lblOsWindowMarginTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginTop.Location = new System.Drawing.Point(3, 34);
            this.lblOsWindowMarginTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginTop.Name = "lblOsWindowMarginTop";
            this.lblOsWindowMarginTop.Size = new System.Drawing.Size(111, 22);
            this.lblOsWindowMarginTop.TabIndex = 1;
            this.lblOsWindowMarginTop.Text = "Top:";
            this.lblOsWindowMarginTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginLeft
            // 
            this.lblOsWindowMarginLeft.AutoSize = true;
            this.lblOsWindowMarginLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginLeft.Location = new System.Drawing.Point(3, 4);
            this.lblOsWindowMarginLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginLeft.Name = "lblOsWindowMarginLeft";
            this.lblOsWindowMarginLeft.Size = new System.Drawing.Size(111, 22);
            this.lblOsWindowMarginLeft.TabIndex = 0;
            this.lblOsWindowMarginLeft.Text = "Left:";
            this.lblOsWindowMarginLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOsWindowMarginCaption
            // 
            this.lblOsWindowMarginCaption.AutoSize = true;
            this.lblOsWindowMarginCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOsWindowMarginCaption.Location = new System.Drawing.Point(3, 4);
            this.lblOsWindowMarginCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOsWindowMarginCaption.Name = "lblOsWindowMarginCaption";
            this.lblOsWindowMarginCaption.Size = new System.Drawing.Size(235, 16);
            this.lblOsWindowMarginCaption.TabIndex = 1;
            this.lblOsWindowMarginCaption.Text = "OS Window Margin:";
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
            this.tabMain.Size = new System.Drawing.Size(981, 685);
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
            this.tpConfigurationPatterns.Size = new System.Drawing.Size(973, 656);
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
            this.tpWindowPatterns.Size = new System.Drawing.Size(973, 656);
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
            this.tpLayouts.Size = new System.Drawing.Size(973, 656);
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
            this.tpOptions.Size = new System.Drawing.Size(973, 656);
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
            this.tsbApplyCurrentLayout,
            this.tsbApplyWindowAction});
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
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName});
            this.statusStrip.Location = new System.Drawing.Point(0, 712);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 734);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "WinMan";
            this.Load += new System.EventHandler(this.FormLoadHandler);
            tableConfigurationPatterns.ResumeLayout(false);
            tableConfigurationPatternList.ResumeLayout(false);
            tableConfigurationPatternList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).EndInit();
            flowConfigurations.ResumeLayout(false);
            tableConfigurationPatternDetails.ResumeLayout(false);
            tableConfigurationPatternDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).EndInit();
            tableWindowPatterns.ResumeLayout(false);
            tableWindowPatterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).EndInit();
            flowWindowPatternActions.ResumeLayout(false);
            tableLayouts.ResumeLayout(false);
            tableLayoutList.ResumeLayout(false);
            tableLayoutList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).EndInit();
            flowLayoutActions.ResumeLayout(false);
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).EndInit();
            flowWindowActionActions.ResumeLayout(false);
            tableLayoutOptions.ResumeLayout(false);
            tableLayoutOptions.PerformLayout();
            this.tableLayoutOsWindowMargin.ResumeLayout(false);
            this.tableLayoutOsWindowMargin.PerformLayout();
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
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblMatchCountCaption;
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
        private System.Windows.Forms.Label lblOsWindowMarginCaption;
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
    }
}

