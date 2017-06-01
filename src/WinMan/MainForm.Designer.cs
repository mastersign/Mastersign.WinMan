﻿namespace Mastersign.WinMan
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
            System.Windows.Forms.TableLayoutPanel tableLayouts;
            System.Windows.Forms.TableLayoutPanel tableLayoutList;
            System.Windows.Forms.TableLayoutPanel tableLayoutDetails;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRecordConfiguration = new System.Windows.Forms.Button();
            this.btnDeleteConfiguration = new System.Windows.Forms.Button();
            this.lblConfigurationNameCaption = new System.Windows.Forms.Label();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.configurationPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listConfigurationPatterns = new System.Windows.Forms.ListBox();
            this.previewConfiguration = new Mastersign.WinMan.PreviewCanvas();
            this.lblVirtualDesktopsCaption = new System.Windows.Forms.Label();
            this.numScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.listScreenPatterns = new System.Windows.Forms.ListBox();
            this.screensPatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblScreenHeightCaption = new System.Windows.Forms.Label();
            this.numScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.numVirtualDesktopCount = new System.Windows.Forms.NumericUpDown();
            this.lblScreenTopCaption = new System.Windows.Forms.Label();
            this.lblScreenWidthCaption = new System.Windows.Forms.Label();
            this.numScreenTop = new System.Windows.Forms.NumericUpDown();
            this.chkRespectVirtualDesktopCount = new System.Windows.Forms.CheckBox();
            this.numScreenLeft = new System.Windows.Forms.NumericUpDown();
            this.lblScreensCaption = new System.Windows.Forms.Label();
            this.lblScreenNameCaption = new System.Windows.Forms.Label();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnListTopWindows = new System.Windows.Forms.Button();
            this.btnDeleteWindowPattern = new System.Windows.Forms.Button();
            this.lblRestoreCommandArgs = new System.Windows.Forms.Label();
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
            this.previewLayout = new Mastersign.WinMan.PreviewCanvas();
            this.btnNewLayout = new System.Windows.Forms.Button();
            this.btnDeleteLayout = new System.Windows.Forms.Button();
            this.lblLayoutNameCaption = new System.Windows.Forms.Label();
            this.txtLayoutName = new System.Windows.Forms.TextBox();
            this.layoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkLayoutIsDefaultLayout = new System.Windows.Forms.CheckBox();
            this.lblConfigurationPatternCaption = new System.Windows.Forms.Label();
            this.cmbLayoutConfiguration = new System.Windows.Forms.ComboBox();
            this.listLayouts = new System.Windows.Forms.ListBox();
            this.lblWindowActionsCaption = new System.Windows.Forms.Label();
            this.chkWindowActionBottomInvert = new System.Windows.Forms.CheckBox();
            this.windowActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkWindowActionCompensateOsMargin = new System.Windows.Forms.CheckBox();
            this.chkWindowActionRightInvert = new System.Windows.Forms.CheckBox();
            this.btnNewWindowAction = new System.Windows.Forms.Button();
            this.chkWindowActionTopInvert = new System.Windows.Forms.CheckBox();
            this.btnDeleteWindowAction = new System.Windows.Forms.Button();
            this.chkWindowActionLeftInvert = new System.Windows.Forms.CheckBox();
            this.listWindowAction = new System.Windows.Forms.ListBox();
            this.cmbWindowActionBottomUnit = new System.Windows.Forms.ComboBox();
            this.numWindowActionBottom = new System.Windows.Forms.NumericUpDown();
            this.cmbWindowActionRightUnit = new System.Windows.Forms.ComboBox();
            this.btnWindowActionApply = new System.Windows.Forms.Button();
            this.cmbWindowActionTopUnit = new System.Windows.Forms.ComboBox();
            this.numWindowActionRight = new System.Windows.Forms.NumericUpDown();
            this.cmbWindowActionLeftUnit = new System.Windows.Forms.ComboBox();
            this.chkWindowActionRestore = new System.Windows.Forms.CheckBox();
            this.numWindowActionTop = new System.Windows.Forms.NumericUpDown();
            this.cmbWindowActionWindow = new System.Windows.Forms.ComboBox();
            this.numWindowActionLeft = new System.Windows.Forms.NumericUpDown();
            this.lblWindowActionCaption = new System.Windows.Forms.Label();
            this.lblWindowActionVirtualDesktop = new System.Windows.Forms.Label();
            this.numWindowActionVirtualDesktop = new System.Windows.Forms.NumericUpDown();
            this.lblWindowActionBottomCaption = new System.Windows.Forms.Label();
            this.lblWindowActionScreenCaption = new System.Windows.Forms.Label();
            this.lblWindowActionRightCaption = new System.Windows.Forms.Label();
            this.cmdWindowActionScreen = new System.Windows.Forms.ComboBox();
            this.lblWindowActionTopCaption = new System.Windows.Forms.Label();
            this.lblWindowStateCaption = new System.Windows.Forms.Label();
            this.lblWindowActionLeftCaption = new System.Windows.Forms.Label();
            this.cmbWindowState = new System.Windows.Forms.ComboBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpConfigurationPatterns = new System.Windows.Forms.TabPage();
            this.tpWindowPatterns = new System.Windows.Forms.TabPage();
            this.tpLayouts = new System.Windows.Forms.TabPage();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNewWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyWorkspace = new System.Windows.Forms.ToolStripButton();
            this.tsbApplyCurrentLayout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            tableConfigurationPatterns = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatternList = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatternDetails = new System.Windows.Forms.TableLayoutPanel();
            tableWindowPatterns = new System.Windows.Forms.TableLayoutPanel();
            tableLayouts = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutList = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutDetails = new System.Windows.Forms.TableLayoutPanel();
            tableConfigurationPatterns.SuspendLayout();
            tableConfigurationPatternList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).BeginInit();
            tableConfigurationPatternDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).BeginInit();
            tableWindowPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).BeginInit();
            tableLayouts.SuspendLayout();
            tableLayoutList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).BeginInit();
            tableLayoutDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpConfigurationPatterns.SuspendLayout();
            this.tpWindowPatterns.SuspendLayout();
            this.tpLayouts.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            tableConfigurationPatterns.Location = new System.Drawing.Point(4, 5);
            tableConfigurationPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tableConfigurationPatterns.Name = "tableConfigurationPatterns";
            tableConfigurationPatterns.RowCount = 2;
            tableConfigurationPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableConfigurationPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tableConfigurationPatterns.Size = new System.Drawing.Size(1160, 833);
            tableConfigurationPatterns.TabIndex = 59;
            // 
            // tableConfigurationPatternList
            // 
            tableConfigurationPatternList.ColumnCount = 2;
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableConfigurationPatternList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableConfigurationPatternList.Controls.Add(this.btnRecordConfiguration, 0, 0);
            tableConfigurationPatternList.Controls.Add(this.btnDeleteConfiguration, 1, 0);
            tableConfigurationPatternList.Controls.Add(this.lblConfigurationNameCaption, 0, 1);
            tableConfigurationPatternList.Controls.Add(this.txtConfigurationName, 0, 2);
            tableConfigurationPatternList.Controls.Add(this.listConfigurationPatterns, 0, 3);
            tableConfigurationPatternList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatternList.Location = new System.Drawing.Point(4, 5);
            tableConfigurationPatternList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tableConfigurationPatternList.Name = "tableConfigurationPatternList";
            tableConfigurationPatternList.RowCount = 4;
            tableConfigurationPatterns.SetRowSpan(tableConfigurationPatternList, 2);
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableConfigurationPatternList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableConfigurationPatternList.Size = new System.Drawing.Size(282, 823);
            tableConfigurationPatternList.TabIndex = 0;
            // 
            // btnRecordConfiguration
            // 
            this.btnRecordConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecordConfiguration.Location = new System.Drawing.Point(4, 5);
            this.btnRecordConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecordConfiguration.Name = "btnRecordConfiguration";
            this.btnRecordConfiguration.Size = new System.Drawing.Size(133, 35);
            this.btnRecordConfiguration.TabIndex = 49;
            this.btnRecordConfiguration.Text = "Record";
            this.btnRecordConfiguration.UseVisualStyleBackColor = true;
            this.btnRecordConfiguration.Click += new System.EventHandler(this.RecordConfigurationHandler);
            // 
            // btnDeleteConfiguration
            // 
            this.btnDeleteConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteConfiguration.Location = new System.Drawing.Point(145, 5);
            this.btnDeleteConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteConfiguration.Name = "btnDeleteConfiguration";
            this.btnDeleteConfiguration.Size = new System.Drawing.Size(133, 35);
            this.btnDeleteConfiguration.TabIndex = 50;
            this.btnDeleteConfiguration.Text = "Delete";
            this.btnDeleteConfiguration.UseVisualStyleBackColor = true;
            this.btnDeleteConfiguration.Click += new System.EventHandler(this.DeleteConfigurationHandler);
            // 
            // lblConfigurationNameCaption
            // 
            this.lblConfigurationNameCaption.AutoSize = true;
            tableConfigurationPatternList.SetColumnSpan(this.lblConfigurationNameCaption, 2);
            this.lblConfigurationNameCaption.Location = new System.Drawing.Point(4, 50);
            this.lblConfigurationNameCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblConfigurationNameCaption.Name = "lblConfigurationNameCaption";
            this.lblConfigurationNameCaption.Size = new System.Drawing.Size(55, 20);
            this.lblConfigurationNameCaption.TabIndex = 41;
            this.lblConfigurationNameCaption.Text = "Name:";
            // 
            // txtConfigurationName
            // 
            tableConfigurationPatternList.SetColumnSpan(this.txtConfigurationName, 2);
            this.txtConfigurationName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtConfigurationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfigurationName.Location = new System.Drawing.Point(4, 80);
            this.txtConfigurationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(274, 26);
            this.txtConfigurationName.TabIndex = 40;
            // 
            // configurationPatternsBindingSource
            // 
            this.configurationPatternsBindingSource.DataMember = "ConfigurationPatterns";
            this.configurationPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.configurationPatternsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedConfigurationPatternChanged);
            this.configurationPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedConfigurationPatternChanged);
            this.configurationPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ConfigurationPatternsListChangedHandler);
            // 
            // workspaceBindingSource
            // 
            this.workspaceBindingSource.DataSource = typeof(Mastersign.WinMan.Workspace);
            // 
            // listConfigurationPatterns
            // 
            tableConfigurationPatternList.SetColumnSpan(this.listConfigurationPatterns, 2);
            this.listConfigurationPatterns.DataSource = this.configurationPatternsBindingSource;
            this.listConfigurationPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConfigurationPatterns.FormattingEnabled = true;
            this.listConfigurationPatterns.IntegralHeight = false;
            this.listConfigurationPatterns.ItemHeight = 20;
            this.listConfigurationPatterns.Location = new System.Drawing.Point(4, 116);
            this.listConfigurationPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listConfigurationPatterns.Name = "listConfigurationPatterns";
            this.listConfigurationPatterns.Size = new System.Drawing.Size(274, 702);
            this.listConfigurationPatterns.TabIndex = 37;
            // 
            // previewConfiguration
            // 
            this.previewConfiguration.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewConfiguration.Location = new System.Drawing.Point(294, 5);
            this.previewConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewConfiguration.Name = "previewConfiguration";
            this.previewConfiguration.Size = new System.Drawing.Size(862, 364);
            this.previewConfiguration.TabIndex = 58;
            this.previewConfiguration.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfigurationPreviewPaintHandler);
            // 
            // tableConfigurationPatternDetails
            // 
            tableConfigurationPatternDetails.ColumnCount = 4;
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableConfigurationPatternDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableConfigurationPatternDetails.Controls.Add(this.lblVirtualDesktopsCaption, 1, 0);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenHeight, 2, 7);
            tableConfigurationPatternDetails.Controls.Add(this.listScreenPatterns, 0, 2);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenHeightCaption, 1, 7);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenWidth, 2, 6);
            tableConfigurationPatternDetails.Controls.Add(this.numVirtualDesktopCount, 2, 0);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenTopCaption, 1, 5);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenWidthCaption, 1, 6);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenTop, 2, 5);
            tableConfigurationPatternDetails.Controls.Add(this.chkRespectVirtualDesktopCount, 3, 0);
            tableConfigurationPatternDetails.Controls.Add(this.numScreenLeft, 2, 4);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreensCaption, 0, 1);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenNameCaption, 1, 2);
            tableConfigurationPatternDetails.Controls.Add(this.txtScreenName, 2, 2);
            tableConfigurationPatternDetails.Controls.Add(this.label1, 1, 3);
            tableConfigurationPatternDetails.Controls.Add(this.lblScreenLeftCaption, 1, 4);
            tableConfigurationPatternDetails.Controls.Add(this.txtDeviceName, 2, 3);
            tableConfigurationPatternDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tableConfigurationPatternDetails.Location = new System.Drawing.Point(294, 379);
            tableConfigurationPatternDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            tableConfigurationPatternDetails.Size = new System.Drawing.Size(862, 449);
            tableConfigurationPatternDetails.TabIndex = 59;
            // 
            // lblVirtualDesktopsCaption
            // 
            this.lblVirtualDesktopsCaption.AutoSize = true;
            this.lblVirtualDesktopsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVirtualDesktopsCaption.Location = new System.Drawing.Point(245, 5);
            this.lblVirtualDesktopsCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblVirtualDesktopsCaption.Name = "lblVirtualDesktopsCaption";
            this.lblVirtualDesktopsCaption.Size = new System.Drawing.Size(130, 26);
            this.lblVirtualDesktopsCaption.TabIndex = 42;
            this.lblVirtualDesktopsCaption.Text = "Virtual Desktops:";
            this.lblVirtualDesktopsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numScreenHeight
            // 
            this.numScreenHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenHeight.Enabled = false;
            this.numScreenHeight.Location = new System.Drawing.Point(383, 251);
            this.numScreenHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numScreenHeight.Size = new System.Drawing.Size(233, 26);
            this.numScreenHeight.TabIndex = 55;
            // 
            // listScreenPatterns
            // 
            this.listScreenPatterns.DataSource = this.screensPatternsBindingSource;
            this.listScreenPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScreenPatterns.FormattingEnabled = true;
            this.listScreenPatterns.IntegralHeight = false;
            this.listScreenPatterns.ItemHeight = 20;
            this.listScreenPatterns.Location = new System.Drawing.Point(4, 71);
            this.listScreenPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listScreenPatterns.Name = "listScreenPatterns";
            tableConfigurationPatternDetails.SetRowSpan(this.listScreenPatterns, 7);
            this.listScreenPatterns.Size = new System.Drawing.Size(233, 373);
            this.listScreenPatterns.TabIndex = 57;
            // 
            // screensPatternsBindingSource
            // 
            this.screensPatternsBindingSource.DataMember = "Screens";
            this.screensPatternsBindingSource.DataSource = this.configurationPatternsBindingSource;
            this.screensPatternsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedScreenPatternChanged);
            this.screensPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedScreenPatternChanged);
            // 
            // lblScreenHeightCaption
            // 
            this.lblScreenHeightCaption.AutoSize = true;
            this.lblScreenHeightCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenHeightCaption.Enabled = false;
            this.lblScreenHeightCaption.Location = new System.Drawing.Point(245, 251);
            this.lblScreenHeightCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblScreenHeightCaption.Name = "lblScreenHeightCaption";
            this.lblScreenHeightCaption.Size = new System.Drawing.Size(130, 26);
            this.lblScreenHeightCaption.TabIndex = 47;
            this.lblScreenHeightCaption.Text = "Height:";
            this.lblScreenHeightCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numScreenWidth
            // 
            this.numScreenWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenWidth.Enabled = false;
            this.numScreenWidth.Location = new System.Drawing.Point(383, 215);
            this.numScreenWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numScreenWidth.Size = new System.Drawing.Size(233, 26);
            this.numScreenWidth.TabIndex = 54;
            // 
            // numVirtualDesktopCount
            // 
            this.numVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurationPatternsBindingSource, "VirtualDesktopCount", true));
            this.numVirtualDesktopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVirtualDesktopCount.Location = new System.Drawing.Point(383, 5);
            this.numVirtualDesktopCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numVirtualDesktopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVirtualDesktopCount.Name = "numVirtualDesktopCount";
            this.numVirtualDesktopCount.Size = new System.Drawing.Size(233, 26);
            this.numVirtualDesktopCount.TabIndex = 51;
            this.numVirtualDesktopCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblScreenTopCaption
            // 
            this.lblScreenTopCaption.AutoSize = true;
            this.lblScreenTopCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenTopCaption.Enabled = false;
            this.lblScreenTopCaption.Location = new System.Drawing.Point(245, 179);
            this.lblScreenTopCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblScreenTopCaption.Name = "lblScreenTopCaption";
            this.lblScreenTopCaption.Size = new System.Drawing.Size(130, 26);
            this.lblScreenTopCaption.TabIndex = 48;
            this.lblScreenTopCaption.Text = "Top:";
            this.lblScreenTopCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScreenWidthCaption
            // 
            this.lblScreenWidthCaption.AutoSize = true;
            this.lblScreenWidthCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenWidthCaption.Enabled = false;
            this.lblScreenWidthCaption.Location = new System.Drawing.Point(245, 215);
            this.lblScreenWidthCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblScreenWidthCaption.Name = "lblScreenWidthCaption";
            this.lblScreenWidthCaption.Size = new System.Drawing.Size(130, 26);
            this.lblScreenWidthCaption.TabIndex = 46;
            this.lblScreenWidthCaption.Text = "Width:";
            this.lblScreenWidthCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numScreenTop
            // 
            this.numScreenTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenTop.Enabled = false;
            this.numScreenTop.Location = new System.Drawing.Point(383, 179);
            this.numScreenTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numScreenTop.Size = new System.Drawing.Size(233, 26);
            this.numScreenTop.TabIndex = 53;
            // 
            // chkRespectVirtualDesktopCount
            // 
            this.chkRespectVirtualDesktopCount.AutoSize = true;
            this.chkRespectVirtualDesktopCount.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationPatternsBindingSource, "RespectVirtualDesktopCount", true));
            this.chkRespectVirtualDesktopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkRespectVirtualDesktopCount.Location = new System.Drawing.Point(624, 5);
            this.chkRespectVirtualDesktopCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRespectVirtualDesktopCount.Name = "chkRespectVirtualDesktopCount";
            this.chkRespectVirtualDesktopCount.Size = new System.Drawing.Size(234, 26);
            this.chkRespectVirtualDesktopCount.TabIndex = 56;
            this.chkRespectVirtualDesktopCount.Text = "Respect VD Count";
            this.chkRespectVirtualDesktopCount.UseVisualStyleBackColor = true;
            // 
            // numScreenLeft
            // 
            this.numScreenLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numScreenLeft.Enabled = false;
            this.numScreenLeft.Location = new System.Drawing.Point(383, 143);
            this.numScreenLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numScreenLeft.Size = new System.Drawing.Size(233, 26);
            this.numScreenLeft.TabIndex = 52;
            // 
            // lblScreensCaption
            // 
            this.lblScreensCaption.AutoSize = true;
            this.lblScreensCaption.Location = new System.Drawing.Point(4, 41);
            this.lblScreensCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblScreensCaption.Name = "lblScreensCaption";
            this.lblScreensCaption.Size = new System.Drawing.Size(72, 20);
            this.lblScreensCaption.TabIndex = 43;
            this.lblScreensCaption.Text = "Screens:";
            // 
            // lblScreenNameCaption
            // 
            this.lblScreenNameCaption.AutoSize = true;
            this.lblScreenNameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenNameCaption.Location = new System.Drawing.Point(245, 71);
            this.lblScreenNameCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblScreenNameCaption.Name = "lblScreenNameCaption";
            this.lblScreenNameCaption.Size = new System.Drawing.Size(130, 26);
            this.lblScreenNameCaption.TabIndex = 44;
            this.lblScreenNameCaption.Text = "Name:";
            this.lblScreenNameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScreenName
            // 
            this.txtScreenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtScreenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScreenName.Location = new System.Drawing.Point(383, 71);
            this.txtScreenName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.Size = new System.Drawing.Size(233, 26);
            this.txtScreenName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(245, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Device Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScreenLeftCaption
            // 
            this.lblScreenLeftCaption.AutoSize = true;
            this.lblScreenLeftCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreenLeftCaption.Enabled = false;
            this.lblScreenLeftCaption.Location = new System.Drawing.Point(245, 143);
            this.lblScreenLeftCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblScreenLeftCaption.Name = "lblScreenLeftCaption";
            this.lblScreenLeftCaption.Size = new System.Drawing.Size(130, 26);
            this.lblScreenLeftCaption.TabIndex = 45;
            this.lblScreenLeftCaption.Text = "Left:";
            this.lblScreenLeftCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screensPatternsBindingSource, "DeviceName", true));
            this.txtDeviceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(383, 107);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(233, 26);
            this.txtDeviceName.TabIndex = 39;
            // 
            // tableWindowPatterns
            // 
            tableWindowPatterns.ColumnCount = 5;
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            tableWindowPatterns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            tableWindowPatterns.Controls.Add(this.listWindows, 0, 0);
            tableWindowPatterns.Controls.Add(this.btnListTopWindows, 4, 1);
            tableWindowPatterns.Controls.Add(this.btnDeleteWindowPattern, 3, 2);
            tableWindowPatterns.Controls.Add(this.lblRestoreCommandArgs, 1, 11);
            tableWindowPatterns.Controls.Add(this.lblWindowPatternsCaption, 0, 1);
            tableWindowPatterns.Controls.Add(this.lblMatchCount, 2, 9);
            tableWindowPatterns.Controls.Add(this.lblRestoreWorkingDir, 1, 12);
            tableWindowPatterns.Controls.Add(this.txtRestoreWorkingDir, 2, 12);
            tableWindowPatterns.Controls.Add(this.listWindowPatterns, 0, 2);
            tableWindowPatterns.Controls.Add(this.lblWindowPatternName, 1, 3);
            tableWindowPatterns.Controls.Add(this.chkWindowClassIgnoreCase, 3, 7);
            tableWindowPatterns.Controls.Add(this.txtRestoreCommandArgs, 2, 11);
            tableWindowPatterns.Controls.Add(this.txtWindowPatternName, 2, 3);
            tableWindowPatterns.Controls.Add(this.txtRestoreCommand, 2, 10);
            tableWindowPatterns.Controls.Add(this.lblRestoreCommand, 1, 10);
            tableWindowPatterns.Controls.Add(this.chkTitleIgnoreCase, 3, 5);
            tableWindowPatterns.Controls.Add(this.cmbWindowClassPatternType, 2, 7);
            tableWindowPatterns.Controls.Add(this.txtTitlePattern, 2, 4);
            tableWindowPatterns.Controls.Add(this.lblMatchCountCaption, 1, 9);
            tableWindowPatterns.Controls.Add(this.txtProcessFileName, 2, 8);
            tableWindowPatterns.Controls.Add(this.lblProcessFileName, 1, 8);
            tableWindowPatterns.Controls.Add(this.lblTitlePatternCaption, 1, 4);
            tableWindowPatterns.Controls.Add(this.cmbTitlePatternType, 2, 5);
            tableWindowPatterns.Controls.Add(this.txtWindowClassPattern, 2, 6);
            tableWindowPatterns.Controls.Add(this.lblWindowClassPatternCaption, 1, 6);
            tableWindowPatterns.Controls.Add(this.btnNewWindowPattern, 2, 2);
            tableWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            tableWindowPatterns.Location = new System.Drawing.Point(4, 5);
            tableWindowPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tableWindowPatterns.Name = "tableWindowPatterns";
            tableWindowPatterns.RowCount = 14;
            tableWindowPatterns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
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
            tableWindowPatterns.Size = new System.Drawing.Size(1160, 833);
            tableWindowPatterns.TabIndex = 30;
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
            tableWindowPatterns.SetColumnSpan(this.listWindows, 5);
            this.listWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindows.FullRowSelect = true;
            this.listWindows.GridLines = true;
            this.listWindows.Location = new System.Drawing.Point(4, 5);
            this.listWindows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listWindows.MultiSelect = false;
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(1152, 301);
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
            // btnListTopWindows
            // 
            this.btnListTopWindows.Location = new System.Drawing.Point(980, 316);
            this.btnListTopWindows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListTopWindows.Name = "btnListTopWindows";
            this.btnListTopWindows.Size = new System.Drawing.Size(174, 35);
            this.btnListTopWindows.TabIndex = 1;
            this.btnListTopWindows.Text = "Refresh Window List";
            this.btnListTopWindows.UseVisualStyleBackColor = true;
            this.btnListTopWindows.Click += new System.EventHandler(this.ReloadWindowListHandler);
            // 
            // btnDeleteWindowPattern
            // 
            this.btnDeleteWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteWindowPattern.Location = new System.Drawing.Point(736, 361);
            this.btnDeleteWindowPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteWindowPattern.Name = "btnDeleteWindowPattern";
            this.btnDeleteWindowPattern.Size = new System.Drawing.Size(236, 35);
            this.btnDeleteWindowPattern.TabIndex = 26;
            this.btnDeleteWindowPattern.Text = "Delete Window Pattern";
            this.btnDeleteWindowPattern.UseVisualStyleBackColor = true;
            this.btnDeleteWindowPattern.Click += new System.EventHandler(this.DeleteWindowPatternHandler);
            // 
            // lblRestoreCommandArgs
            // 
            this.lblRestoreCommandArgs.AutoSize = true;
            this.lblRestoreCommandArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreCommandArgs.Location = new System.Drawing.Point(309, 703);
            this.lblRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRestoreCommandArgs.Name = "lblRestoreCommandArgs";
            this.lblRestoreCommandArgs.Size = new System.Drawing.Size(175, 26);
            this.lblRestoreCommandArgs.TabIndex = 29;
            this.lblRestoreCommandArgs.Text = "Command Args:";
            this.lblRestoreCommandArgs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowPatternsCaption
            // 
            this.lblWindowPatternsCaption.AutoSize = true;
            this.lblWindowPatternsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowPatternsCaption.Location = new System.Drawing.Point(4, 316);
            this.lblWindowPatternsCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowPatternsCaption.Name = "lblWindowPatternsCaption";
            this.lblWindowPatternsCaption.Size = new System.Drawing.Size(297, 35);
            this.lblWindowPatternsCaption.TabIndex = 27;
            this.lblWindowPatternsCaption.Text = "Window Patterns:";
            this.lblWindowPatternsCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMatchCount
            // 
            this.lblMatchCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchCount.Location = new System.Drawing.Point(492, 626);
            this.lblMatchCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblMatchCount.Name = "lblMatchCount";
            this.lblMatchCount.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblMatchCount.Size = new System.Drawing.Size(150, 31);
            this.lblMatchCount.TabIndex = 28;
            this.lblMatchCount.Text = "0";
            this.lblMatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRestoreWorkingDir
            // 
            this.lblRestoreWorkingDir.AutoSize = true;
            this.lblRestoreWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreWorkingDir.Location = new System.Drawing.Point(309, 739);
            this.lblRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRestoreWorkingDir.Name = "lblRestoreWorkingDir";
            this.lblRestoreWorkingDir.Size = new System.Drawing.Size(175, 26);
            this.lblRestoreWorkingDir.TabIndex = 15;
            this.lblRestoreWorkingDir.Text = "Working Directory:";
            this.lblRestoreWorkingDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRestoreWorkingDir
            // 
            this.txtRestoreWorkingDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WorkingDir", true));
            this.txtRestoreWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreWorkingDir.Location = new System.Drawing.Point(492, 739);
            this.txtRestoreWorkingDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestoreWorkingDir.Name = "txtRestoreWorkingDir";
            this.txtRestoreWorkingDir.Size = new System.Drawing.Size(236, 26);
            this.txtRestoreWorkingDir.TabIndex = 17;
            // 
            // windowPatternsBindingSource
            // 
            this.windowPatternsBindingSource.DataMember = "WindowPatterns";
            this.windowPatternsBindingSource.DataSource = this.workspaceBindingSource;
            this.windowPatternsBindingSource.CurrentChanged += new System.EventHandler(this.CurrentWindowPatternChangedHandler);
            this.windowPatternsBindingSource.CurrentItemChanged += new System.EventHandler(this.CurrentWindowPatternChangedHandler);
            this.windowPatternsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.WindowPatternListChangedHandler);
            // 
            // listWindowPatterns
            // 
            this.listWindowPatterns.DataSource = this.windowPatternsBindingSource;
            this.listWindowPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindowPatterns.FormattingEnabled = true;
            this.listWindowPatterns.IntegralHeight = false;
            this.listWindowPatterns.ItemHeight = 20;
            this.listWindowPatterns.Location = new System.Drawing.Point(4, 361);
            this.listWindowPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listWindowPatterns.Name = "listWindowPatterns";
            tableWindowPatterns.SetRowSpan(this.listWindowPatterns, 12);
            this.listWindowPatterns.Size = new System.Drawing.Size(297, 467);
            this.listWindowPatterns.TabIndex = 14;
            // 
            // lblWindowPatternName
            // 
            this.lblWindowPatternName.AutoSize = true;
            this.lblWindowPatternName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowPatternName.Location = new System.Drawing.Point(309, 406);
            this.lblWindowPatternName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowPatternName.Name = "lblWindowPatternName";
            this.lblWindowPatternName.Size = new System.Drawing.Size(175, 26);
            this.lblWindowPatternName.TabIndex = 25;
            this.lblWindowPatternName.Text = "Name:";
            this.lblWindowPatternName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkWindowClassIgnoreCase
            // 
            this.chkWindowClassIgnoreCase.AutoSize = true;
            this.chkWindowClassIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "WindowClassIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowClassIgnoreCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowClassIgnoreCase.Location = new System.Drawing.Point(736, 552);
            this.chkWindowClassIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowClassIgnoreCase.Name = "chkWindowClassIgnoreCase";
            this.chkWindowClassIgnoreCase.Size = new System.Drawing.Size(236, 28);
            this.chkWindowClassIgnoreCase.TabIndex = 22;
            this.chkWindowClassIgnoreCase.Text = "Ignore Case";
            this.chkWindowClassIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // txtRestoreCommandArgs
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreCommandArgs, 3);
            this.txtRestoreCommandArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "CommandArgs", true));
            this.txtRestoreCommandArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreCommandArgs.Location = new System.Drawing.Point(492, 703);
            this.txtRestoreCommandArgs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestoreCommandArgs.Name = "txtRestoreCommandArgs";
            this.txtRestoreCommandArgs.Size = new System.Drawing.Size(664, 26);
            this.txtRestoreCommandArgs.TabIndex = 17;
            // 
            // txtWindowPatternName
            // 
            tableWindowPatterns.SetColumnSpan(this.txtWindowPatternName, 2);
            this.txtWindowPatternName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWindowPatternName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWindowPatternName.Location = new System.Drawing.Point(492, 406);
            this.txtWindowPatternName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWindowPatternName.Name = "txtWindowPatternName";
            this.txtWindowPatternName.Size = new System.Drawing.Size(480, 26);
            this.txtWindowPatternName.TabIndex = 18;
            // 
            // txtRestoreCommand
            // 
            tableWindowPatterns.SetColumnSpan(this.txtRestoreCommand, 3);
            this.txtRestoreCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "Command", true));
            this.txtRestoreCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestoreCommand.Location = new System.Drawing.Point(492, 667);
            this.txtRestoreCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestoreCommand.Name = "txtRestoreCommand";
            this.txtRestoreCommand.Size = new System.Drawing.Size(664, 26);
            this.txtRestoreCommand.TabIndex = 17;
            // 
            // lblRestoreCommand
            // 
            this.lblRestoreCommand.AutoSize = true;
            this.lblRestoreCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestoreCommand.Location = new System.Drawing.Point(309, 667);
            this.lblRestoreCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRestoreCommand.Name = "lblRestoreCommand";
            this.lblRestoreCommand.Size = new System.Drawing.Size(175, 26);
            this.lblRestoreCommand.TabIndex = 15;
            this.lblRestoreCommand.Text = "Command:";
            this.lblRestoreCommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkTitleIgnoreCase
            // 
            this.chkTitleIgnoreCase.AutoSize = true;
            this.chkTitleIgnoreCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowPatternsBindingSource, "TitleIgnoreCase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTitleIgnoreCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTitleIgnoreCase.Location = new System.Drawing.Point(736, 478);
            this.chkTitleIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTitleIgnoreCase.Name = "chkTitleIgnoreCase";
            this.chkTitleIgnoreCase.Size = new System.Drawing.Size(236, 28);
            this.chkTitleIgnoreCase.TabIndex = 23;
            this.chkTitleIgnoreCase.Text = "Ignore Case";
            this.chkTitleIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // cmbWindowClassPatternType
            // 
            this.cmbWindowClassPatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "WindowClassPatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowClassPatternType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowClassPatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowClassPatternType.FormattingEnabled = true;
            this.cmbWindowClassPatternType.Location = new System.Drawing.Point(492, 552);
            this.cmbWindowClassPatternType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowClassPatternType.Name = "cmbWindowClassPatternType";
            this.cmbWindowClassPatternType.Size = new System.Drawing.Size(236, 28);
            this.cmbWindowClassPatternType.TabIndex = 20;
            // 
            // txtTitlePattern
            // 
            tableWindowPatterns.SetColumnSpan(this.txtTitlePattern, 2);
            this.txtTitlePattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "TitlePattern", true));
            this.txtTitlePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitlePattern.Location = new System.Drawing.Point(492, 442);
            this.txtTitlePattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitlePattern.Name = "txtTitlePattern";
            this.txtTitlePattern.Size = new System.Drawing.Size(480, 26);
            this.txtTitlePattern.TabIndex = 19;
            // 
            // lblMatchCountCaption
            // 
            this.lblMatchCountCaption.AutoSize = true;
            this.lblMatchCountCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatchCountCaption.Location = new System.Drawing.Point(309, 626);
            this.lblMatchCountCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblMatchCountCaption.Name = "lblMatchCountCaption";
            this.lblMatchCountCaption.Size = new System.Drawing.Size(175, 31);
            this.lblMatchCountCaption.TabIndex = 15;
            this.lblMatchCountCaption.Text = "Matching:";
            this.lblMatchCountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcessFileName
            // 
            tableWindowPatterns.SetColumnSpan(this.txtProcessFileName, 3);
            this.txtProcessFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "ProcessFileName", true));
            this.txtProcessFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcessFileName.Location = new System.Drawing.Point(492, 590);
            this.txtProcessFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProcessFileName.Name = "txtProcessFileName";
            this.txtProcessFileName.Size = new System.Drawing.Size(664, 26);
            this.txtProcessFileName.TabIndex = 17;
            // 
            // lblProcessFileName
            // 
            this.lblProcessFileName.AutoSize = true;
            this.lblProcessFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessFileName.Location = new System.Drawing.Point(309, 590);
            this.lblProcessFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblProcessFileName.Name = "lblProcessFileName";
            this.lblProcessFileName.Size = new System.Drawing.Size(175, 26);
            this.lblProcessFileName.TabIndex = 15;
            this.lblProcessFileName.Text = "Process File:";
            this.lblProcessFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitlePatternCaption
            // 
            this.lblTitlePatternCaption.AutoSize = true;
            this.lblTitlePatternCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitlePatternCaption.Location = new System.Drawing.Point(309, 442);
            this.lblTitlePatternCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTitlePatternCaption.Name = "lblTitlePatternCaption";
            this.lblTitlePatternCaption.Size = new System.Drawing.Size(175, 26);
            this.lblTitlePatternCaption.TabIndex = 16;
            this.lblTitlePatternCaption.Text = "Window Title:";
            this.lblTitlePatternCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTitlePatternType
            // 
            this.cmbTitlePatternType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowPatternsBindingSource, "TitlePatternType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbTitlePatternType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTitlePatternType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitlePatternType.FormattingEnabled = true;
            this.cmbTitlePatternType.Location = new System.Drawing.Point(492, 478);
            this.cmbTitlePatternType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTitlePatternType.Name = "cmbTitlePatternType";
            this.cmbTitlePatternType.Size = new System.Drawing.Size(236, 28);
            this.cmbTitlePatternType.TabIndex = 21;
            // 
            // txtWindowClassPattern
            // 
            tableWindowPatterns.SetColumnSpan(this.txtWindowClassPattern, 3);
            this.txtWindowClassPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowPatternsBindingSource, "WindowClassPattern", true));
            this.txtWindowClassPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWindowClassPattern.Location = new System.Drawing.Point(492, 516);
            this.txtWindowClassPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWindowClassPattern.Name = "txtWindowClassPattern";
            this.txtWindowClassPattern.Size = new System.Drawing.Size(664, 26);
            this.txtWindowClassPattern.TabIndex = 17;
            // 
            // lblWindowClassPatternCaption
            // 
            this.lblWindowClassPatternCaption.AutoSize = true;
            this.lblWindowClassPatternCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowClassPatternCaption.Location = new System.Drawing.Point(309, 516);
            this.lblWindowClassPatternCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowClassPatternCaption.Name = "lblWindowClassPatternCaption";
            this.lblWindowClassPatternCaption.Size = new System.Drawing.Size(175, 26);
            this.lblWindowClassPatternCaption.TabIndex = 15;
            this.lblWindowClassPatternCaption.Text = "Window Class:";
            this.lblWindowClassPatternCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewWindowPattern
            // 
            this.btnNewWindowPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowPattern.Location = new System.Drawing.Point(492, 361);
            this.btnNewWindowPattern.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewWindowPattern.Name = "btnNewWindowPattern";
            this.btnNewWindowPattern.Size = new System.Drawing.Size(236, 35);
            this.btnNewWindowPattern.TabIndex = 24;
            this.btnNewWindowPattern.Text = "New Window Pattern";
            this.btnNewWindowPattern.UseVisualStyleBackColor = true;
            this.btnNewWindowPattern.Click += new System.EventHandler(this.NewWindowPatternHandler);
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
            tableLayouts.Location = new System.Drawing.Point(4, 5);
            tableLayouts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tableLayouts.Name = "tableLayouts";
            tableLayouts.RowCount = 2;
            tableLayouts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayouts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tableLayouts.Size = new System.Drawing.Size(1160, 833);
            tableLayouts.TabIndex = 73;
            // 
            // previewLayout
            // 
            this.previewLayout.BackColor = System.Drawing.SystemColors.Desktop;
            this.previewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewLayout.Location = new System.Drawing.Point(294, 5);
            this.previewLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(862, 364);
            this.previewLayout.TabIndex = 31;
            this.previewLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPreviewPaintHandler);
            // 
            // tableLayoutList
            // 
            tableLayoutList.ColumnCount = 2;
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutList.Controls.Add(this.btnNewLayout, 0, 0);
            tableLayoutList.Controls.Add(this.btnDeleteLayout, 1, 0);
            tableLayoutList.Controls.Add(this.lblLayoutNameCaption, 0, 1);
            tableLayoutList.Controls.Add(this.txtLayoutName, 0, 2);
            tableLayoutList.Controls.Add(this.chkLayoutIsDefaultLayout, 0, 3);
            tableLayoutList.Controls.Add(this.lblConfigurationPatternCaption, 0, 4);
            tableLayoutList.Controls.Add(this.cmbLayoutConfiguration, 0, 5);
            tableLayoutList.Controls.Add(this.listLayouts, 0, 6);
            tableLayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutList.Location = new System.Drawing.Point(4, 5);
            tableLayoutList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            tableLayoutList.Size = new System.Drawing.Size(282, 823);
            tableLayoutList.TabIndex = 32;
            // 
            // btnNewLayout
            // 
            this.btnNewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewLayout.Location = new System.Drawing.Point(4, 5);
            this.btnNewLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewLayout.Name = "btnNewLayout";
            this.btnNewLayout.Size = new System.Drawing.Size(133, 35);
            this.btnNewLayout.TabIndex = 1;
            this.btnNewLayout.Text = "New";
            this.btnNewLayout.UseVisualStyleBackColor = true;
            this.btnNewLayout.Click += new System.EventHandler(this.NewLayoutHandler);
            // 
            // btnDeleteLayout
            // 
            this.btnDeleteLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteLayout.Location = new System.Drawing.Point(145, 5);
            this.btnDeleteLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteLayout.Name = "btnDeleteLayout";
            this.btnDeleteLayout.Size = new System.Drawing.Size(133, 35);
            this.btnDeleteLayout.TabIndex = 27;
            this.btnDeleteLayout.Text = "Delete";
            this.btnDeleteLayout.UseVisualStyleBackColor = true;
            this.btnDeleteLayout.Click += new System.EventHandler(this.DeleteLayoutHandler);
            // 
            // lblLayoutNameCaption
            // 
            this.lblLayoutNameCaption.AutoSize = true;
            tableLayoutList.SetColumnSpan(this.lblLayoutNameCaption, 2);
            this.lblLayoutNameCaption.Location = new System.Drawing.Point(4, 50);
            this.lblLayoutNameCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLayoutNameCaption.Name = "lblLayoutNameCaption";
            this.lblLayoutNameCaption.Size = new System.Drawing.Size(55, 20);
            this.lblLayoutNameCaption.TabIndex = 29;
            this.lblLayoutNameCaption.Text = "Name:";
            // 
            // txtLayoutName
            // 
            tableLayoutList.SetColumnSpan(this.txtLayoutName, 2);
            this.txtLayoutName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLayoutName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLayoutName.Location = new System.Drawing.Point(4, 80);
            this.txtLayoutName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLayoutName.Name = "txtLayoutName";
            this.txtLayoutName.Size = new System.Drawing.Size(274, 26);
            this.txtLayoutName.TabIndex = 28;
            // 
            // layoutsBindingSource
            // 
            this.layoutsBindingSource.DataMember = "Layouts";
            this.layoutsBindingSource.DataSource = this.workspaceBindingSource;
            this.layoutsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedLayoutChangedHandler);
            // 
            // chkLayoutIsDefaultLayout
            // 
            this.chkLayoutIsDefaultLayout.AutoSize = true;
            tableLayoutList.SetColumnSpan(this.chkLayoutIsDefaultLayout, 2);
            this.chkLayoutIsDefaultLayout.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.layoutsBindingSource, "DefaultLayout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLayoutIsDefaultLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLayoutIsDefaultLayout.Location = new System.Drawing.Point(4, 116);
            this.chkLayoutIsDefaultLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLayoutIsDefaultLayout.Name = "chkLayoutIsDefaultLayout";
            this.chkLayoutIsDefaultLayout.Size = new System.Drawing.Size(274, 24);
            this.chkLayoutIsDefaultLayout.TabIndex = 32;
            this.chkLayoutIsDefaultLayout.Text = "Default Layout";
            this.chkLayoutIsDefaultLayout.UseVisualStyleBackColor = true;
            // 
            // lblConfigurationPatternCaption
            // 
            this.lblConfigurationPatternCaption.AutoSize = true;
            tableLayoutList.SetColumnSpan(this.lblConfigurationPatternCaption, 2);
            this.lblConfigurationPatternCaption.Location = new System.Drawing.Point(4, 150);
            this.lblConfigurationPatternCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblConfigurationPatternCaption.Name = "lblConfigurationPatternCaption";
            this.lblConfigurationPatternCaption.Size = new System.Drawing.Size(164, 20);
            this.lblConfigurationPatternCaption.TabIndex = 29;
            this.lblConfigurationPatternCaption.Text = "Configuration Pattern:";
            // 
            // cmbLayoutConfiguration
            // 
            tableLayoutList.SetColumnSpan(this.cmbLayoutConfiguration, 2);
            this.cmbLayoutConfiguration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.layoutsBindingSource, "Configuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbLayoutConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLayoutConfiguration.FormattingEnabled = true;
            this.cmbLayoutConfiguration.Location = new System.Drawing.Point(4, 180);
            this.cmbLayoutConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLayoutConfiguration.Name = "cmbLayoutConfiguration";
            this.cmbLayoutConfiguration.Size = new System.Drawing.Size(274, 28);
            this.cmbLayoutConfiguration.TabIndex = 68;
            // 
            // listLayouts
            // 
            tableLayoutList.SetColumnSpan(this.listLayouts, 2);
            this.listLayouts.DataSource = this.layoutsBindingSource;
            this.listLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLayouts.FormattingEnabled = true;
            this.listLayouts.IntegralHeight = false;
            this.listLayouts.ItemHeight = 20;
            this.listLayouts.Location = new System.Drawing.Point(4, 218);
            this.listLayouts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listLayouts.Name = "listLayouts";
            this.listLayouts.Size = new System.Drawing.Size(274, 600);
            this.listLayouts.TabIndex = 0;
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 6;
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutDetails.Controls.Add(this.lblWindowActionsCaption, 0, 0);
            tableLayoutDetails.Controls.Add(this.chkWindowActionBottomInvert, 5, 9);
            tableLayoutDetails.Controls.Add(this.chkWindowActionCompensateOsMargin, 3, 10);
            tableLayoutDetails.Controls.Add(this.chkWindowActionRightInvert, 5, 8);
            tableLayoutDetails.Controls.Add(this.btnNewWindowAction, 0, 1);
            tableLayoutDetails.Controls.Add(this.chkWindowActionTopInvert, 5, 7);
            tableLayoutDetails.Controls.Add(this.btnDeleteWindowAction, 1, 1);
            tableLayoutDetails.Controls.Add(this.chkWindowActionLeftInvert, 5, 6);
            tableLayoutDetails.Controls.Add(this.listWindowAction, 0, 2);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionBottomUnit, 4, 9);
            tableLayoutDetails.Controls.Add(this.numWindowActionBottom, 3, 9);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionRightUnit, 4, 8);
            tableLayoutDetails.Controls.Add(this.btnWindowActionApply, 5, 1);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionTopUnit, 4, 7);
            tableLayoutDetails.Controls.Add(this.numWindowActionRight, 3, 8);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionLeftUnit, 4, 6);
            tableLayoutDetails.Controls.Add(this.chkWindowActionRestore, 3, 1);
            tableLayoutDetails.Controls.Add(this.numWindowActionTop, 3, 7);
            tableLayoutDetails.Controls.Add(this.cmbWindowActionWindow, 3, 2);
            tableLayoutDetails.Controls.Add(this.numWindowActionLeft, 3, 6);
            tableLayoutDetails.Controls.Add(this.lblWindowActionCaption, 2, 2);
            tableLayoutDetails.Controls.Add(this.lblWindowActionVirtualDesktop, 2, 3);
            tableLayoutDetails.Controls.Add(this.numWindowActionVirtualDesktop, 3, 3);
            tableLayoutDetails.Controls.Add(this.lblWindowActionBottomCaption, 2, 9);
            tableLayoutDetails.Controls.Add(this.lblWindowActionScreenCaption, 2, 4);
            tableLayoutDetails.Controls.Add(this.lblWindowActionRightCaption, 2, 8);
            tableLayoutDetails.Controls.Add(this.cmdWindowActionScreen, 3, 4);
            tableLayoutDetails.Controls.Add(this.lblWindowActionTopCaption, 2, 7);
            tableLayoutDetails.Controls.Add(this.lblWindowStateCaption, 2, 5);
            tableLayoutDetails.Controls.Add(this.lblWindowActionLeftCaption, 2, 6);
            tableLayoutDetails.Controls.Add(this.cmbWindowState, 3, 5);
            tableLayoutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutDetails.Location = new System.Drawing.Point(294, 379);
            tableLayoutDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            tableLayoutDetails.Size = new System.Drawing.Size(862, 449);
            tableLayoutDetails.TabIndex = 33;
            // 
            // lblWindowActionsCaption
            // 
            this.lblWindowActionsCaption.AutoSize = true;
            tableLayoutDetails.SetColumnSpan(this.lblWindowActionsCaption, 2);
            this.lblWindowActionsCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionsCaption.Location = new System.Drawing.Point(4, 5);
            this.lblWindowActionsCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionsCaption.Name = "lblWindowActionsCaption";
            this.lblWindowActionsCaption.Size = new System.Drawing.Size(278, 20);
            this.lblWindowActionsCaption.TabIndex = 70;
            this.lblWindowActionsCaption.Text = "Window Actions:";
            this.lblWindowActionsCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkWindowActionBottomInvert
            // 
            this.chkWindowActionBottomInvert.AutoSize = true;
            this.chkWindowActionBottomInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "BottomInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionBottomInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionBottomInvert.Location = new System.Drawing.Point(719, 346);
            this.chkWindowActionBottomInvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowActionBottomInvert.Name = "chkWindowActionBottomInvert";
            this.chkWindowActionBottomInvert.Size = new System.Drawing.Size(139, 28);
            this.chkWindowActionBottomInvert.TabIndex = 71;
            this.chkWindowActionBottomInvert.Text = "from Bottom";
            this.chkWindowActionBottomInvert.UseVisualStyleBackColor = true;
            // 
            // windowActionsBindingSource
            // 
            this.windowActionsBindingSource.DataMember = "Windows";
            this.windowActionsBindingSource.DataSource = this.layoutsBindingSource;
            this.windowActionsBindingSource.CurrentChanged += new System.EventHandler(this.SelectedWindowActionChangedHandler);
            this.windowActionsBindingSource.CurrentItemChanged += new System.EventHandler(this.SelectedWindowActionChangedHandler);
            // 
            // chkWindowActionCompensateOsMargin
            // 
            this.chkWindowActionCompensateOsMargin.AutoSize = true;
            tableLayoutDetails.SetColumnSpan(this.chkWindowActionCompensateOsMargin, 2);
            this.chkWindowActionCompensateOsMargin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "CompensateOsMargin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionCompensateOsMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionCompensateOsMargin.Location = new System.Drawing.Point(433, 384);
            this.chkWindowActionCompensateOsMargin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowActionCompensateOsMargin.Name = "chkWindowActionCompensateOsMargin";
            this.chkWindowActionCompensateOsMargin.Size = new System.Drawing.Size(278, 24);
            this.chkWindowActionCompensateOsMargin.TabIndex = 72;
            this.chkWindowActionCompensateOsMargin.Text = "Compensate OS Margin";
            this.chkWindowActionCompensateOsMargin.UseVisualStyleBackColor = true;
            // 
            // chkWindowActionRightInvert
            // 
            this.chkWindowActionRightInvert.AutoSize = true;
            this.chkWindowActionRightInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "RightInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionRightInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionRightInvert.Location = new System.Drawing.Point(719, 308);
            this.chkWindowActionRightInvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowActionRightInvert.Name = "chkWindowActionRightInvert";
            this.chkWindowActionRightInvert.Size = new System.Drawing.Size(139, 28);
            this.chkWindowActionRightInvert.TabIndex = 71;
            this.chkWindowActionRightInvert.Text = "from Right";
            this.chkWindowActionRightInvert.UseVisualStyleBackColor = true;
            // 
            // btnNewWindowAction
            // 
            this.btnNewWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewWindowAction.Location = new System.Drawing.Point(4, 35);
            this.btnNewWindowAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewWindowAction.Name = "btnNewWindowAction";
            this.btnNewWindowAction.Size = new System.Drawing.Size(135, 37);
            this.btnNewWindowAction.TabIndex = 66;
            this.btnNewWindowAction.Text = "New";
            this.btnNewWindowAction.UseVisualStyleBackColor = true;
            this.btnNewWindowAction.Click += new System.EventHandler(this.NewWindowActionHandler);
            // 
            // chkWindowActionTopInvert
            // 
            this.chkWindowActionTopInvert.AutoSize = true;
            this.chkWindowActionTopInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "TopInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionTopInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionTopInvert.Location = new System.Drawing.Point(719, 270);
            this.chkWindowActionTopInvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowActionTopInvert.Name = "chkWindowActionTopInvert";
            this.chkWindowActionTopInvert.Size = new System.Drawing.Size(139, 28);
            this.chkWindowActionTopInvert.TabIndex = 71;
            this.chkWindowActionTopInvert.Text = "from Bottom";
            this.chkWindowActionTopInvert.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWindowAction
            // 
            this.btnDeleteWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteWindowAction.Location = new System.Drawing.Point(147, 35);
            this.btnDeleteWindowAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteWindowAction.Name = "btnDeleteWindowAction";
            this.btnDeleteWindowAction.Size = new System.Drawing.Size(135, 37);
            this.btnDeleteWindowAction.TabIndex = 44;
            this.btnDeleteWindowAction.Text = "Delete";
            this.btnDeleteWindowAction.UseVisualStyleBackColor = true;
            this.btnDeleteWindowAction.Click += new System.EventHandler(this.DeleteWindowActionHandler);
            // 
            // chkWindowActionLeftInvert
            // 
            this.chkWindowActionLeftInvert.AutoSize = true;
            this.chkWindowActionLeftInvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "LeftInvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowActionLeftInvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionLeftInvert.Location = new System.Drawing.Point(719, 232);
            this.chkWindowActionLeftInvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowActionLeftInvert.Name = "chkWindowActionLeftInvert";
            this.chkWindowActionLeftInvert.Size = new System.Drawing.Size(139, 28);
            this.chkWindowActionLeftInvert.TabIndex = 71;
            this.chkWindowActionLeftInvert.Text = "from Right";
            this.chkWindowActionLeftInvert.UseVisualStyleBackColor = true;
            // 
            // listWindowAction
            // 
            tableLayoutDetails.SetColumnSpan(this.listWindowAction, 2);
            this.listWindowAction.DataSource = this.windowActionsBindingSource;
            this.listWindowAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindowAction.FormattingEnabled = true;
            this.listWindowAction.IntegralHeight = false;
            this.listWindowAction.ItemHeight = 20;
            this.listWindowAction.Location = new System.Drawing.Point(4, 82);
            this.listWindowAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listWindowAction.Name = "listWindowAction";
            tableLayoutDetails.SetRowSpan(this.listWindowAction, 10);
            this.listWindowAction.Size = new System.Drawing.Size(278, 362);
            this.listWindowAction.TabIndex = 43;
            // 
            // cmbWindowActionBottomUnit
            // 
            this.cmbWindowActionBottomUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "BottomUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionBottomUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionBottomUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionBottomUnit.FormattingEnabled = true;
            this.cmbWindowActionBottomUnit.Location = new System.Drawing.Point(576, 346);
            this.cmbWindowActionBottomUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowActionBottomUnit.Name = "cmbWindowActionBottomUnit";
            this.cmbWindowActionBottomUnit.Size = new System.Drawing.Size(135, 28);
            this.cmbWindowActionBottomUnit.TabIndex = 51;
            // 
            // numWindowActionBottom
            // 
            this.numWindowActionBottom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Bottom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionBottom.Location = new System.Drawing.Point(433, 346);
            this.numWindowActionBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numWindowActionBottom.Size = new System.Drawing.Size(135, 26);
            this.numWindowActionBottom.TabIndex = 64;
            // 
            // cmbWindowActionRightUnit
            // 
            this.cmbWindowActionRightUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "RightUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionRightUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionRightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionRightUnit.FormattingEnabled = true;
            this.cmbWindowActionRightUnit.Location = new System.Drawing.Point(576, 308);
            this.cmbWindowActionRightUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowActionRightUnit.Name = "cmbWindowActionRightUnit";
            this.cmbWindowActionRightUnit.Size = new System.Drawing.Size(135, 28);
            this.cmbWindowActionRightUnit.TabIndex = 50;
            // 
            // btnWindowActionApply
            // 
            this.btnWindowActionApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWindowActionApply.Location = new System.Drawing.Point(719, 35);
            this.btnWindowActionApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWindowActionApply.Name = "btnWindowActionApply";
            this.btnWindowActionApply.Size = new System.Drawing.Size(139, 37);
            this.btnWindowActionApply.TabIndex = 65;
            this.btnWindowActionApply.Text = "Apply";
            this.btnWindowActionApply.UseVisualStyleBackColor = true;
            this.btnWindowActionApply.Click += new System.EventHandler(this.ApplyWindowActionHandler);
            // 
            // cmbWindowActionTopUnit
            // 
            this.cmbWindowActionTopUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "TopUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionTopUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionTopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionTopUnit.FormattingEnabled = true;
            this.cmbWindowActionTopUnit.Location = new System.Drawing.Point(576, 270);
            this.cmbWindowActionTopUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowActionTopUnit.Name = "cmbWindowActionTopUnit";
            this.cmbWindowActionTopUnit.Size = new System.Drawing.Size(135, 28);
            this.cmbWindowActionTopUnit.TabIndex = 49;
            // 
            // numWindowActionRight
            // 
            this.numWindowActionRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Right", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionRight.Location = new System.Drawing.Point(433, 308);
            this.numWindowActionRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numWindowActionRight.Size = new System.Drawing.Size(135, 26);
            this.numWindowActionRight.TabIndex = 63;
            // 
            // cmbWindowActionLeftUnit
            // 
            this.cmbWindowActionLeftUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "LeftUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionLeftUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionLeftUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowActionLeftUnit.FormattingEnabled = true;
            this.cmbWindowActionLeftUnit.Location = new System.Drawing.Point(576, 232);
            this.cmbWindowActionLeftUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowActionLeftUnit.Name = "cmbWindowActionLeftUnit";
            this.cmbWindowActionLeftUnit.Size = new System.Drawing.Size(135, 28);
            this.cmbWindowActionLeftUnit.TabIndex = 48;
            // 
            // chkWindowActionRestore
            // 
            this.chkWindowActionRestore.AutoSize = true;
            this.chkWindowActionRestore.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowActionsBindingSource, "Restore", true));
            this.chkWindowActionRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWindowActionRestore.Location = new System.Drawing.Point(433, 35);
            this.chkWindowActionRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWindowActionRestore.Name = "chkWindowActionRestore";
            this.chkWindowActionRestore.Size = new System.Drawing.Size(135, 37);
            this.chkWindowActionRestore.TabIndex = 69;
            this.chkWindowActionRestore.Text = "Restore";
            this.chkWindowActionRestore.UseVisualStyleBackColor = true;
            // 
            // numWindowActionTop
            // 
            this.numWindowActionTop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionTop.Location = new System.Drawing.Point(433, 270);
            this.numWindowActionTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numWindowActionTop.Size = new System.Drawing.Size(135, 26);
            this.numWindowActionTop.TabIndex = 62;
            // 
            // cmbWindowActionWindow
            // 
            tableLayoutDetails.SetColumnSpan(this.cmbWindowActionWindow, 2);
            this.cmbWindowActionWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Window", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowActionWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowActionWindow.FormattingEnabled = true;
            this.cmbWindowActionWindow.Location = new System.Drawing.Point(433, 82);
            this.cmbWindowActionWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowActionWindow.Name = "cmbWindowActionWindow";
            this.cmbWindowActionWindow.Size = new System.Drawing.Size(278, 28);
            this.cmbWindowActionWindow.TabIndex = 68;
            // 
            // numWindowActionLeft
            // 
            this.numWindowActionLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "Left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionLeft.Location = new System.Drawing.Point(433, 232);
            this.numWindowActionLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numWindowActionLeft.Size = new System.Drawing.Size(135, 26);
            this.numWindowActionLeft.TabIndex = 61;
            // 
            // lblWindowActionCaption
            // 
            this.lblWindowActionCaption.AutoSize = true;
            this.lblWindowActionCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionCaption.Location = new System.Drawing.Point(290, 82);
            this.lblWindowActionCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionCaption.Name = "lblWindowActionCaption";
            this.lblWindowActionCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowActionCaption.TabIndex = 67;
            this.lblWindowActionCaption.Text = "Window Pattern:";
            this.lblWindowActionCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionVirtualDesktop
            // 
            this.lblWindowActionVirtualDesktop.AutoSize = true;
            this.lblWindowActionVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionVirtualDesktop.Location = new System.Drawing.Point(290, 120);
            this.lblWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionVirtualDesktop.Name = "lblWindowActionVirtualDesktop";
            this.lblWindowActionVirtualDesktop.Size = new System.Drawing.Size(135, 26);
            this.lblWindowActionVirtualDesktop.TabIndex = 52;
            this.lblWindowActionVirtualDesktop.Text = "Virtual Desktop:";
            this.lblWindowActionVirtualDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numWindowActionVirtualDesktop
            // 
            this.numWindowActionVirtualDesktop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.windowActionsBindingSource, "VirtualDesktop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numWindowActionVirtualDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWindowActionVirtualDesktop.Location = new System.Drawing.Point(433, 120);
            this.numWindowActionVirtualDesktop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numWindowActionVirtualDesktop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowActionVirtualDesktop.Name = "numWindowActionVirtualDesktop";
            this.numWindowActionVirtualDesktop.Size = new System.Drawing.Size(135, 26);
            this.numWindowActionVirtualDesktop.TabIndex = 60;
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
            this.lblWindowActionBottomCaption.Location = new System.Drawing.Point(290, 346);
            this.lblWindowActionBottomCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionBottomCaption.Name = "lblWindowActionBottomCaption";
            this.lblWindowActionBottomCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowActionBottomCaption.TabIndex = 59;
            this.lblWindowActionBottomCaption.Text = "Bottom:";
            this.lblWindowActionBottomCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionScreenCaption
            // 
            this.lblWindowActionScreenCaption.AutoSize = true;
            this.lblWindowActionScreenCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionScreenCaption.Location = new System.Drawing.Point(290, 156);
            this.lblWindowActionScreenCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionScreenCaption.Name = "lblWindowActionScreenCaption";
            this.lblWindowActionScreenCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowActionScreenCaption.TabIndex = 53;
            this.lblWindowActionScreenCaption.Text = "Screen:";
            this.lblWindowActionScreenCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionRightCaption
            // 
            this.lblWindowActionRightCaption.AutoSize = true;
            this.lblWindowActionRightCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionRightCaption.Location = new System.Drawing.Point(290, 308);
            this.lblWindowActionRightCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionRightCaption.Name = "lblWindowActionRightCaption";
            this.lblWindowActionRightCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowActionRightCaption.TabIndex = 58;
            this.lblWindowActionRightCaption.Text = "Right:";
            this.lblWindowActionRightCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdWindowActionScreen
            // 
            tableLayoutDetails.SetColumnSpan(this.cmdWindowActionScreen, 2);
            this.cmdWindowActionScreen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowActionsBindingSource, "Screen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmdWindowActionScreen.DataSource = this.screensPatternsBindingSource;
            this.cmdWindowActionScreen.DisplayMember = "Name";
            this.cmdWindowActionScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdWindowActionScreen.FormattingEnabled = true;
            this.cmdWindowActionScreen.Location = new System.Drawing.Point(433, 156);
            this.cmdWindowActionScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdWindowActionScreen.Name = "cmdWindowActionScreen";
            this.cmdWindowActionScreen.Size = new System.Drawing.Size(278, 28);
            this.cmdWindowActionScreen.TabIndex = 45;
            this.cmdWindowActionScreen.ValueMember = "Name";
            // 
            // lblWindowActionTopCaption
            // 
            this.lblWindowActionTopCaption.AutoSize = true;
            this.lblWindowActionTopCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionTopCaption.Location = new System.Drawing.Point(290, 270);
            this.lblWindowActionTopCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionTopCaption.Name = "lblWindowActionTopCaption";
            this.lblWindowActionTopCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowActionTopCaption.TabIndex = 57;
            this.lblWindowActionTopCaption.Text = "Top:";
            this.lblWindowActionTopCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowStateCaption
            // 
            this.lblWindowStateCaption.AutoSize = true;
            this.lblWindowStateCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowStateCaption.Location = new System.Drawing.Point(290, 194);
            this.lblWindowStateCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowStateCaption.Name = "lblWindowStateCaption";
            this.lblWindowStateCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowStateCaption.TabIndex = 54;
            this.lblWindowStateCaption.Text = "Window State:";
            this.lblWindowStateCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWindowActionLeftCaption
            // 
            this.lblWindowActionLeftCaption.AutoSize = true;
            this.lblWindowActionLeftCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWindowActionLeftCaption.Location = new System.Drawing.Point(290, 232);
            this.lblWindowActionLeftCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWindowActionLeftCaption.Name = "lblWindowActionLeftCaption";
            this.lblWindowActionLeftCaption.Size = new System.Drawing.Size(135, 28);
            this.lblWindowActionLeftCaption.TabIndex = 56;
            this.lblWindowActionLeftCaption.Text = "Left:";
            this.lblWindowActionLeftCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWindowState
            // 
            tableLayoutDetails.SetColumnSpan(this.cmbWindowState, 2);
            this.cmbWindowState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.windowActionsBindingSource, "WindowState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWindowState.DisplayMember = "Name";
            this.cmbWindowState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWindowState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowState.FormattingEnabled = true;
            this.cmbWindowState.Location = new System.Drawing.Point(433, 194);
            this.cmbWindowState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWindowState.Name = "cmbWindowState";
            this.cmbWindowState.Size = new System.Drawing.Size(278, 28);
            this.cmbWindowState.TabIndex = 46;
            this.cmbWindowState.ValueMember = "Name";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpConfigurationPatterns);
            this.tabMain.Controls.Add(this.tpWindowPatterns);
            this.tabMain.Controls.Add(this.tpLayouts);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 32);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1176, 876);
            this.tabMain.TabIndex = 17;
            // 
            // tpConfigurationPatterns
            // 
            this.tpConfigurationPatterns.Controls.Add(tableConfigurationPatterns);
            this.tpConfigurationPatterns.Location = new System.Drawing.Point(4, 29);
            this.tpConfigurationPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfigurationPatterns.Name = "tpConfigurationPatterns";
            this.tpConfigurationPatterns.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfigurationPatterns.Size = new System.Drawing.Size(1168, 843);
            this.tpConfigurationPatterns.TabIndex = 2;
            this.tpConfigurationPatterns.Text = "Configuration Patterns";
            this.tpConfigurationPatterns.UseVisualStyleBackColor = true;
            // 
            // tpWindowPatterns
            // 
            this.tpWindowPatterns.Controls.Add(tableWindowPatterns);
            this.tpWindowPatterns.Location = new System.Drawing.Point(4, 29);
            this.tpWindowPatterns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpWindowPatterns.Name = "tpWindowPatterns";
            this.tpWindowPatterns.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpWindowPatterns.Size = new System.Drawing.Size(1168, 843);
            this.tpWindowPatterns.TabIndex = 0;
            this.tpWindowPatterns.Text = "Windows Patterns";
            this.tpWindowPatterns.UseVisualStyleBackColor = true;
            // 
            // tpLayouts
            // 
            this.tpLayouts.Controls.Add(tableLayouts);
            this.tpLayouts.Location = new System.Drawing.Point(4, 29);
            this.tpLayouts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpLayouts.Name = "tpLayouts";
            this.tpLayouts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpLayouts.Size = new System.Drawing.Size(1168, 843);
            this.tpLayouts.TabIndex = 1;
            this.tpLayouts.Text = "Layouts";
            this.tpLayouts.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewWorkspace,
            this.tsbOpenWorkspace,
            this.tsbSaveWorkspace,
            this.tsbApplyWorkspace,
            this.tsbApplyCurrentLayout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1176, 32);
            this.toolStrip.TabIndex = 18;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbNewWorkspace
            // 
            this.tsbNewWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewWorkspace.Image")));
            this.tsbNewWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewWorkspace.Name = "tsbNewWorkspace";
            this.tsbNewWorkspace.Size = new System.Drawing.Size(167, 29);
            this.tsbNewWorkspace.Text = "New Workspace";
            this.tsbNewWorkspace.Click += new System.EventHandler(this.NewWorkspaceHandler);
            // 
            // tsbOpenWorkspace
            // 
            this.tsbOpenWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenWorkspace.Image")));
            this.tsbOpenWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenWorkspace.Name = "tsbOpenWorkspace";
            this.tsbOpenWorkspace.Size = new System.Drawing.Size(176, 29);
            this.tsbOpenWorkspace.Text = "Open Workspace";
            this.tsbOpenWorkspace.Click += new System.EventHandler(this.OpenWorkspaceHandler);
            // 
            // tsbSaveWorkspace
            // 
            this.tsbSaveWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveWorkspace.Image")));
            this.tsbSaveWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveWorkspace.Name = "tsbSaveWorkspace";
            this.tsbSaveWorkspace.Size = new System.Drawing.Size(169, 29);
            this.tsbSaveWorkspace.Text = "Save Workspace";
            this.tsbSaveWorkspace.Click += new System.EventHandler(this.SaveWorkspaceHandler);
            // 
            // tsbApplyWorkspace
            // 
            this.tsbApplyWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyWorkspace.Image")));
            this.tsbApplyWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyWorkspace.Name = "tsbApplyWorkspace";
            this.tsbApplyWorkspace.Size = new System.Drawing.Size(179, 29);
            this.tsbApplyWorkspace.Text = "Apply Workspace";
            this.tsbApplyWorkspace.Click += new System.EventHandler(this.ApplyWorkspaceHandler);
            // 
            // tsbApplyCurrentLayout
            // 
            this.tsbApplyCurrentLayout.Image = ((System.Drawing.Image)(resources.GetObject("tsbApplyCurrentLayout.Image")));
            this.tsbApplyCurrentLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyCurrentLayout.Name = "tsbApplyCurrentLayout";
            this.tsbApplyCurrentLayout.Size = new System.Drawing.Size(208, 29);
            this.tsbApplyCurrentLayout.Text = "Apply Current Layout";
            this.tsbApplyCurrentLayout.Click += new System.EventHandler(this.ApplyCurrentLayoutHandler);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName});
            this.statusStrip.Location = new System.Drawing.Point(0, 908);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1176, 30);
            this.statusStrip.TabIndex = 73;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslFileName
            // 
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(90, 25);
            this.tsslFileName.Text = "File Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 938);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1189, 954);
            this.Name = "MainForm";
            this.Text = "WinMan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedHandler);
            this.Load += new System.EventHandler(this.FormLoadHandler);
            tableConfigurationPatterns.ResumeLayout(false);
            tableConfigurationPatternList.ResumeLayout(false);
            tableConfigurationPatternList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceBindingSource)).EndInit();
            tableConfigurationPatternDetails.ResumeLayout(false);
            tableConfigurationPatternDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screensPatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVirtualDesktopCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenLeft)).EndInit();
            tableWindowPatterns.ResumeLayout(false);
            tableWindowPatterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPatternsBindingSource)).EndInit();
            tableLayouts.ResumeLayout(false);
            tableLayoutList.ResumeLayout(false);
            tableLayoutList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsBindingSource)).EndInit();
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowActionVirtualDesktop)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpConfigurationPatterns.ResumeLayout(false);
            this.tpWindowPatterns.ResumeLayout(false);
            this.tpLayouts.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listConfigurationPatterns;
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

