using Mastersign.WinMan.Gui.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;

namespace Mastersign.WinMan.Gui
{
    public partial class MainForm : ImprovedForm
    {
        private Core _core;
        private Workspace _changeObservationTarget;
        private readonly PreviewPainter _previewPainter;

        public MainForm()
        {
            _previewPainter = new PreviewPainter();
            _previewState = new LayoutPreviewState();
            InitializeComponent();
        }

        private void FormLoadHandler(object sender, EventArgs e)
        {
            InitializeWindowTitle();
            InitializeIcons();
            InitializeRasterChooser();

            cmbTitlePatternType.DataSource = Enum.GetValues(typeof(StringPatternType));
            cmbWindowClassPatternType.DataSource = Enum.GetValues(typeof(StringPatternType));
            cmbWindowActionWindowState.DataSource = Enum.GetValues(typeof(WindowState));
            cmbWindowActionLeftUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));
            cmbWindowActionTopUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));
            cmbWindowActionRightUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));
            cmbWindowActionBottomUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));

            UpdateControlActivation();
            Core = Core.DefaultCore;
        }

        private string WorkspaceState
            => Core?.Workspace != null
                ? (Core.Workspace.IsChanged ? " (changed)" : string.Empty)
                : string.Empty;

        private void InitializeWindowTitle()
            => Text = "WinMan " + Assembly.GetExecutingAssembly().GetName().Version.ToString(3) + WorkspaceState;

        private void InitializeIcons()
        {
            var size = toolStrip.ImageScalingSize;
            SetIcon(tsbNewWorkspace, Resources.New, size);
            SetIcon(tsbOpenWorkspace, Resources.Open, size);
            SetIcon(tsbSaveWorkspace, Resources.Save, size);
            tsbSaveWorkspaceAs.Image = tsbSaveWorkspace.Image;
            SetIcon(tsbApplyWorkspace, Resources.ApplyWorkspace, size);
            SetIcon(tsbApplyCurrentLayout, Resources.ApplyLayout, size);
            SetIcon(tsbApplyWindowAction, Resources.ApplyWindow, size);

            SetIcon(tsbKillWorkspace, Resources.KillWorkspace, size);
            SetIcon(tsbKillCurrentLayout, Resources.KillLayout, size);
            SetIcon(tsbKillWindowAction, Resources.KillWindow, size);

            SetIcon(btnRecordConfiguration, Resources.NewItem, size);
            SetIcon(btnMoveUpConfiguration, Resources.Up, size);
            SetIcon(btnMoveDownConfiguration, Resources.Down, size);
            SetIcon(btnSortConfigurations, Resources.Sort, size);
            SetIcon(btnDeleteConfiguration, Resources.DeleteItem, size);

            SetIcon(btnReloadWindowList, Resources.Refresh, size);
            SetIcon(btnNewWindowPattern, Resources.NewItem, size);
            SetIcon(btnMoveUpWindowPattern, Resources.Up, size);
            SetIcon(btnMoveDownWindowPattern, Resources.Down, size);
            SetIcon(btnSortWindowPatterns, Resources.Sort, size);
            SetIcon(btnDuplicateWindowPattern, Resources.DuplicateItem, size);
            SetIcon(btnDeleteWindowPattern, Resources.DeleteItem, size);

            SetIcon(btnNewWindowPatternFromTemplate, Resources.Template, size);
            SetIcon(tsmiNewExplorerWindow, Resources.Explorer, size);
            SetIcon(tsmiNewCmdWindow, Resources.Cmd, size);
            SetIcon(tsmiNewPowerShellWindow, Resources.PowerShell, size);

            SetIcon(btnNewLayout, Resources.NewItem, size);
            SetIcon(btnMoveUpLayout, Resources.Up, size);
            SetIcon(btnMoveDownLayout, Resources.Down, size);
            SetIcon(btnSortLayouts, Resources.Sort, size);
            SetIcon(btnDuplicateLayout, Resources.DuplicateItem, size);
            SetIcon(btnDeleteLayout, Resources.DeleteItem, size);

            SetIcon(btnNewWindowAction, Resources.NewItem, size);
            SetIcon(btnMoveUpWindowAction, Resources.Up, size);
            SetIcon(btnMoveDownWindowAction, Resources.Down, size);
            SetIcon(btnSortWindowActions, Resources.Sort, size);
            SetIcon(btnDuplicateWindowAction, Resources.DuplicateItem, size);
            SetIcon(btnDeleteWindowAction, Resources.DeleteItem, size);
        }

        private static void SetIcon(ToolStripItem tsi, Icon icon, Size size)
            => tsi.Image = new Icon(icon, size).ToBitmap();

        private static void SetIcon(Button btn, Icon icon, Size size)
        {
            btn.Image = new Icon(icon, size).ToBitmap();
            if (btn.Text.Length == 1)
                btn.Text = string.Empty;
            else
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void InitializeRasterChooser()
        {
            rasterChooser.RasterChangedHandler += RasterChangedHandler;
            rasterChooser.SetRaster(RasterPartitioning.Even6, RasterPartitioning.Even4);
        }

        private void RasterChangedHandler(object sender, EventArgs e)
        {
            _previewState.Raster = rasterChooser.Raster;
            previewLayout.Invalidate();
        }

        private void UpdateControlActivation()
        {
            SuspendLayout();
            var workspaceAvailable = HasCore && Core.Workspace != null;
            var layoutTab = workspaceAvailable && tabMain.SelectedTab == tpLayouts;

            var configPatternSelected = workspaceAvailable && SelectedConfigurationPattern != null;
            btnDeleteConfiguration.Enabled = configPatternSelected;
            lblConfigurationNameCaption.Enabled = configPatternSelected;
            txtConfigurationName.Enabled = configPatternSelected;
            lblVirtualDesktopsCaption.Enabled = configPatternSelected;
            numVirtualDesktopCount.Enabled = configPatternSelected;
            chkRespectVirtualDesktopCount.Enabled = configPatternSelected;
            lblScreensCaption.Enabled = configPatternSelected;
            listScreenPatterns.Enabled = configPatternSelected;

            var screenPatternSelected = workspaceAvailable && SelectedScreenPattern != null;
            lblScreenNameCaption.Enabled = screenPatternSelected;
            txtScreenName.Enabled = screenPatternSelected;
            lblScreenDeviceNameCaption.Enabled = screenPatternSelected;
            lblScreenLeftCaption.Enabled = screenPatternSelected;
            lblScreenTopCaption.Enabled = screenPatternSelected;
            lblScreenWidthCaption.Enabled = screenPatternSelected;
            lblScreenHeightCaption.Enabled = screenPatternSelected;

            var windowPatternSelected = workspaceAvailable && SelectedWindowPattern != null;
            btnDuplicateWindowPattern.Enabled = windowPatternSelected;
            btnMoveUpWindowPattern.Enabled =
                windowPatternSelected && windowPatternsBindingSource.Position > 0;
            btnMoveDownWindowPattern.Enabled =
                windowPatternSelected && windowPatternsBindingSource.Position < windowPatternsBindingSource.Count - 1;
            btnSortWindowPatterns.Enabled
                = workspaceAvailable && windowPatternsBindingSource.Count > 1;
            btnDeleteWindowPattern.Enabled = windowPatternSelected;
            lblWindowPatternName.Enabled = windowPatternSelected;
            txtWindowPatternName.Enabled = windowPatternSelected;

            lblRestoreWorkingDir.Enabled = windowPatternSelected;
            txtRestoreWorkingDir.Enabled = windowPatternSelected;
            chkOverrideRestorationTimeout.Enabled = windowPatternSelected;

            var layoutSelected = workspaceAvailable && SelectedLayout != null;
            btnDuplicateLayout.Enabled = layoutSelected;
            btnMoveUpLayout.Enabled
                = layoutSelected && layoutsBindingSource.Position > 0;
            btnMoveDownLayout.Enabled
                = layoutSelected && layoutsBindingSource.Position < layoutsBindingSource.Count - 1;
            btnSortLayouts.Enabled
                = workspaceAvailable && layoutsBindingSource.Count > 1;
            btnDeleteLayout.Enabled = layoutSelected;
            lblLayoutNameCaption.Enabled = layoutSelected;
            txtLayoutName.Enabled = layoutSelected;
            chkLayoutIsDefaultLayout.Enabled = layoutSelected;
            lblConfigurationPatternCaption.Enabled = layoutSelected;
            cmbLayoutConfiguration.Enabled = layoutSelected;
            lblWindowActionsCaption.Enabled = layoutSelected;
            btnNewWindowAction.Enabled = layoutSelected;
            listWindowAction.Enabled = layoutSelected;

            tsbApplyCurrentLayout.Enabled = layoutTab && layoutSelected;
            tsbKillCurrentLayout.Enabled = layoutTab && layoutSelected;

            var windowActionSelected = workspaceAvailable && SelectedWindowAction != null;
            btnMoveUpWindowAction.Enabled
                = windowActionSelected && windowActionsBindingSource.Position > 0;
            btnMoveDownWindowAction.Enabled
                = windowActionSelected && windowActionsBindingSource.Position < windowActionsBindingSource.Count - 1;
            btnSortLayouts.Enabled
                = workspaceAvailable && windowActionsBindingSource.Count > 1;
            btnDeleteWindowAction.Enabled = windowActionSelected;
            chkWindowActionRestore.Enabled = windowActionSelected;
            lblWindowActionWindowCaption.Enabled = windowActionSelected;
            cmbWindowActionWindow.Enabled = windowActionSelected;
            lblWindowActionVirtualDesktop.Enabled = windowActionSelected;
            chkOverrideDefaultVirtualDesktop.Enabled = windowActionSelected;
            lblWindowActionScreenCaption.Enabled = windowActionSelected;
            cmbWindowActionScreen.Enabled = windowActionSelected;
            lblWindowActionWindowStateCaption.Enabled = windowActionSelected;
            cmbWindowActionWindowState.Enabled = windowActionSelected;
            lblWindowActionLeftCaption.Enabled = windowActionSelected;
            numWindowActionLeft.Enabled = windowActionSelected;
            cmbWindowActionLeftUnit.Enabled = windowActionSelected;
            chkWindowActionLeftInvert.Enabled = windowActionSelected;
            lblWindowActionTopCaption.Enabled = windowActionSelected;
            numWindowActionTop.Enabled = windowActionSelected;
            cmbWindowActionTopUnit.Enabled = windowActionSelected;
            chkWindowActionTopInvert.Enabled = windowActionSelected;
            lblWindowActionRightCaption.Enabled = windowActionSelected;
            numWindowActionRight.Enabled = windowActionSelected;
            cmbWindowActionRightUnit.Enabled = windowActionSelected;
            chkWindowActionRightInvert.Enabled = windowActionSelected;
            lblWindowActionBottomCaption.Enabled = windowActionSelected;
            numWindowActionBottom.Enabled = windowActionSelected;
            cmbWindowActionBottomUnit.Enabled = windowActionSelected;
            chkWindowActionBottomInvert.Enabled = windowActionSelected;

            tsbApplyWindowAction.Enabled = layoutTab && windowActionSelected;
            tsbKillWindowAction.Enabled = layoutTab && windowActionSelected;

            ResumeLayout();
        }

        private void MainTabPageChangedHandler(object sender, EventArgs e)
        {
            UpdateControlActivation();
        }

        private void StatusMessageHandler(StatusLevel level, string message)
        {
            if (level == StatusLevel.Error)
            {
                MessageBox.Show(this, message, "WinMan Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Core

        public Core Core
        {
            get => _core;
            set
            {
                if (value == _core) return;
                if (_core != null) ReleaseCore();
                _core = value;
                BindCore();
            }
        }

        public bool HasCore => _core != null;

        private void ReleaseCore()
        {
            Core.WorkspaceChanged -= CoreWorkspaceChangedHandler;
            Core.WorkspaceFileNameChanged -= CoreWorkspaceFileNameChangedHandler;
            Core.WindowWrappersChanged -= CoreWindowWrappersChangedHandler;
        }

        private void BindCore()
        {
            if (HasCore)
            {
                Core.WorkspaceChanged += CoreWorkspaceChangedHandler;
                Core.WorkspaceFileNameChanged += CoreWorkspaceFileNameChangedHandler;
                Core.WindowWrappersChanged += CoreWindowWrappersChangedHandler;
            }

            CoreWorkspaceChangedHandler(this, EventArgs.Empty);
            CoreWorkspaceFileNameChangedHandler(this, EventArgs.Empty);
            CoreWindowWrappersChangedHandler(this, EventArgs.Empty);
            UpdateControlActivation();
        }

        private void CoreWorkspaceChangedHandler(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)CoreWorkspaceChangedHandler, sender, e);
                return;
            }

            workspaceBindingSource.DataSource = Core?.Workspace;
            ReleaseOptions();
            ReleaseChangeObservationTarget();
            BindChangeObservationTarget(Core?.Workspace);
            BindOptions(Core?.Workspace?.Options);
        }

        private void ReleaseChangeObservationTarget()
        {
            if (_changeObservationTarget == null) return;
            _changeObservationTarget.PropertyChanged -= GlobalChangeHandler;
        }
        private void BindChangeObservationTarget(Workspace w)
        {
            _changeObservationTarget = w;
            if (_changeObservationTarget == null) return;
            _changeObservationTarget.PropertyChanged += GlobalChangeHandler;
        }

        private void GlobalChangeHandler(object sender, PropertyChangedEventArgs e)
        {
            InitializeWindowTitle();
        }

        private void CoreWorkspaceFileNameChangedHandler(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)CoreWorkspaceFileNameChangedHandler, sender, e);
                return;
            }

            tsslFileName.Text = Core?.WorkspaceFileName;
        }

        private void CoreWindowWrappersChangedHandler(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)CoreWindowWrappersChangedHandler, sender, e);
                return;
            }

            RefreshWindowListHandler(sender, e);
        }

        #endregion

        #region Workspace

        private void NewWorkspaceHandler(object sender, EventArgs e)
        {
            Core.CreateNewWorkspace();
        }

        private void OpenWorkspaceHandler(object sender, EventArgs e)
        {
            if (!HasCore) return;
            Core.ShowOpenWorkspaceFileDialog(this, "Open Workspace...");
        }

        private void SaveWorkspaceHandler(object sender, EventArgs a)
        {
            if (!HasCore) return;
            if (string.IsNullOrWhiteSpace(Core.WorkspaceFileName))
            {
                Core.ShowSaveWorkspaceFileDialog(this, "Save Workspace...");
            }
            else
            {
                Core.WriteWorkspaceToFile();
            }
        }

        private void SaveWorkspaceAsHandler(object sender, EventArgs e)
        {
            if (!HasCore) return;
            Core.ShowSaveWorkspaceFileDialog(this, "Save Workspace As...");
        }

        private void ApplyWorkspaceHandler(object sender, EventArgs e)
        {
            if (!HasCore) return;
            Core.ApplyWorkspace(StatusMessageHandler, ApplyOverrides.None);
        }

        private void KillWorkspaceHandler(object sender, EventArgs e)
        {
            if (!HasCore) return;
            Core.KillWorkspace(StatusMessageHandler, KillOverrides.None);
        }

        #endregion

        #region Window List

        private ListViewItem ListViewItemFromWindow(WindowWrapper w)
        {
            var selectedPattern = SelectedWindowPattern;
            var vd = VirtualDesktopHelper.GetVirtualDesktopNumber(w.VirtualDesktop?.Id ?? Guid.Empty) + 1;
            var item = new ListViewItem(new[]
            {
                selectedPattern != null ? (selectedPattern.IsMatch(w) ? "Yes" : "No") : string.Empty,
                w.Title,
                w.WindowClass,
                Path.GetFileName(w.ProcessFileName),
                w.Screen.DeviceName,
                vd == 0 ? "all" : vd.ToString(),
                w.NormalPosition.ToString(),
                w.ShowCommand.ToString(),
                w.AppId,
            })
            {
                Tag = w
            };
            return item;
        }

        private void RefreshWindowListHandler(object sender, EventArgs e)
        {
            listWindows.Items.Clear();
            if (!HasCore || Core.WindowWrappers == null) return;
            listWindows.Items.AddRange(Core.WindowWrappers.Select(ListViewItemFromWindow).ToArray());
            listWindows.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private WindowWrapper SelectedWindow
            => listWindows.SelectedItems.Count > 0
                ? listWindows.SelectedItems[0].Tag as WindowWrapper
                : null;

        private void ReloadWindowListHandler(object sender, EventArgs e)
        {
            if (!HasCore) return;
            Core.ReloadWindows();
        }

        #endregion

        #region Window Patterns

        private WindowPattern SelectedWindowPattern
        {
            get => windowPatternsBindingSource.Position >= 0 && windowPatternsBindingSource.Count > windowPatternsBindingSource.Position
                ? windowPatternsBindingSource.Current as WindowPattern
                : null;
            set => windowPatternsBindingSource.Position
                = Core.Workspace.WindowPatterns.IndexOf(value);
        }

        private void NewWindowPatternHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedWindow = SelectedWindow;
            var newWindowPattern = selectedWindow != null
                ? WindowPattern.FromWindow(selectedWindow)
                : new WindowPattern();
            Core.Workspace.WindowPatterns.Add(newWindowPattern);
            SelectedWindowPattern = newWindowPattern;
            txtWindowPatternName.Focus();
            txtWindowPatternName.SelectAll();
        }


        private void NewWindowPatternFromTemplateHandler(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            cmsWindowPatternTemplates.Show(btn, new Point(1, 1 + btn.Height), ToolStripDropDownDirection.BelowRight);
        }

        private void NewExplorerWindowPatternHandler(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the location to open in the Explorer window.";
            folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog(this) != DialogResult.OK) return;
            var name = Path.GetFileName(folderBrowser.SelectedPath);
            if (string.IsNullOrWhiteSpace(name)) name = folderBrowser.SelectedPath;
            var exe = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                "explorer.exe");
            var pattern = new WindowPattern
            {
                Name = name + " - Explorer",
                ModernApp = false,
                TitlePattern = "*" + name,
                TitleIgnoreCase = true,
                TitlePatternType = StringPatternType.Wildcard,
                WindowClassPattern = "CabinetWClass",
                WindowClassIgnoreCase = false,
                WindowClassPatternType = StringPatternType.Exact,
                ProcessFileName = exe,
                Command = exe,
                CommandArgs = "/n, /e, \"" + folderBrowser.SelectedPath + "\"",
                WorkingDir = folderBrowser.SelectedPath
            };
            Core.Workspace.WindowPatterns.Add(pattern);
            SelectedWindowPattern = pattern;
            txtWindowPatternName.SelectAll();
            txtWindowPatternName.Focus();
        }

        private void NewCmdWindowPatternHandler(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the location to open in the CMD console.";
            folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog(this) != DialogResult.OK) return;
            var name = Path.GetFileName(folderBrowser.SelectedPath);
            if (string.IsNullOrWhiteSpace(name)) name = folderBrowser.SelectedPath;
            var title = StringForm.AskForString(this, "Window Title", "CMD - " + name);
            if (title == null) return;
            var exe = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                "System32", "cmd.exe");
            var pattern = new WindowPattern
            {
                Name = name + " - CMD",
                ModernApp = false,
                TitlePattern = title,
                TitleIgnoreCase = false,
                TitlePatternType = StringPatternType.Exact,
                WindowClassPattern = "ConsoleWindowClass",
                WindowClassIgnoreCase = false,
                WindowClassPatternType = StringPatternType.Exact,
                ProcessFileName = Path.GetFileName(exe),
                Command = exe,
                CommandArgs = "/K \"@TITLE " + title + "\"",
                WorkingDir = folderBrowser.SelectedPath
            };
            Core.Workspace.WindowPatterns.Add(pattern);
            SelectedWindowPattern = pattern;
            txtWindowPatternName.SelectAll();
            txtWindowPatternName.Focus();
        }

        private void NewPowerShellWindowPatternHandler(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the location to open in the Explorer window.";
            folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog(this) != DialogResult.OK) return;
            var name = Path.GetFileName(folderBrowser.SelectedPath);
            if (string.IsNullOrWhiteSpace(name)) name = folderBrowser.SelectedPath;
            var title = StringForm.AskForString(this, "Window Title", "PowerShell - " + name);
            if (title == null) return;
            var exe = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                "System32", "WindowsPowerShell", "v1.0",
                "powershell.exe");
            var pattern = new WindowPattern
            {
                Name = name + " - PowerShell",
                ModernApp = false,
                TitlePattern = title,
                TitleIgnoreCase = false,
                TitlePatternType = StringPatternType.Exact,
                WindowClassPattern = "ConsoleWindowClass",
                WindowClassIgnoreCase = false,
                WindowClassPatternType = StringPatternType.Exact,
                ProcessFileName = Path.GetFileName(exe),
                Command = exe,
                CommandArgs = "-NoExit -ExecutionPolicy ByPass -Command \"$Host.UI.RawUI.WindowTitle = '" + title + "'\"",
                WorkingDir = folderBrowser.SelectedPath
            };
            Core.Workspace.WindowPatterns.Add(pattern);
            SelectedWindowPattern = pattern;
            txtWindowPatternName.SelectAll();
            txtWindowPatternName.Focus();
        }

        private void DuplicateWindowPatternHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedWindowPattern = SelectedWindowPattern;
            if (selectedWindowPattern == null) return;
            var position = Core.Workspace.WindowPatterns.IndexOf(selectedWindowPattern) + 1;
            var copy = selectedWindowPattern.Clone();
            copy.Name += " Copy";
            Core.Workspace.WindowPatterns.Insert(position, copy);
            SelectedWindowPattern = copy;
            txtWindowPatternName.Focus();
            txtWindowPatternName.SelectAll();
        }

        private void DeleteWindowPatternHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedWindowPattern = SelectedWindowPattern;
            if (selectedWindowPattern == null) return;
            Core.Workspace.WindowPatterns.Remove(selectedWindowPattern);
        }

        private void MoveUpWindowPatternHandler(object sender, EventArgs e)
            => MoveItemUp(windowPatternsBindingSource, Core?.Workspace?.WindowPatterns);

        private void MoveDownWindowPatternHandler(object sender, EventArgs e)
            => MoveItemDown(windowPatternsBindingSource, Core?.Workspace?.WindowPatterns);

        private void SortWindowPatternsHandler(object sender, EventArgs e)
            => SortItems(windowPatternsBindingSource, Core?.Workspace?.WindowPatterns);

        private void WindowPatternListChangedHandler(object sender, ListChangedEventArgs e)
            => UpdateWindowPatternReferenceList();

        private void WindowPatternSelectionChangedHandler(object sender, EventArgs e)
        {
            //RefreshWindowListHandler(sender, e);
            UpdateControlActivation();
            WatchedWindowPattern = SelectedWindowPattern;
        }

        private void SelectedWindowPatternChangedHandler(object sender, EventArgs e)
        {
            //RefreshWindowListHandler(sender, e);
        }

        #region Automatic Reference Update

        private WindowPattern _watchedWindowPattern;
        private string _lastWindowPatternName;

        private WindowPattern WatchedWindowPattern
        {
            get => _watchedWindowPattern;
            set
            {
                if (value == _watchedWindowPattern) return;
                if (_watchedWindowPattern != null)
                {
                    _watchedWindowPattern.NameChanged -= WatchedWindowPatternNameChangedHandler;
                    _lastWindowPatternName = null;
                }
                _watchedWindowPattern = value;
                if (_watchedWindowPattern != null)
                {
                    _lastWindowPatternName = _watchedWindowPattern.Name;
                    _watchedWindowPattern.NameChanged += WatchedWindowPatternNameChangedHandler;
                }
            }
        }

        private void WatchedWindowPatternNameChangedHandler(object sender, EventArgs e)
        {
            Core?.Workspace?.UpdateWindowPatternReferences(_lastWindowPatternName, _watchedWindowPattern.Name);
            _lastWindowPatternName = _watchedWindowPattern.Name;
            UpdateWindowPatternReferenceList();
        }

        private void UpdateWindowPatternReferenceList()
        {
            if (!HasCore || Core.Workspace == null) return;
            cmbWindowActionWindow.Items.Clear();
            cmbWindowActionWindow.Items.AddRange(Core.Workspace.WindowPatterns.Select(p => p.Name).ToArray());
        }

        #endregion

        #endregion

        #region ConfigurationPatterns

        private ConfigurationPattern SelectedConfigurationPattern
        {
            get => configurationPatternsBindingSource.Position >= 0
                ? configurationPatternsBindingSource.Current as ConfigurationPattern
                : null;
            set => configurationPatternsBindingSource.Position
                = Core?.Workspace?.ConfigurationPatterns.IndexOf(value) ?? -1;
        }

        private void RecordConfigurationHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var newConfigurationPattern = ConfigurationPattern.FromConfiguration(
                Screen.AllScreens, VirtualDesktop.GetDesktops().Length);
            Core.Workspace.ConfigurationPatterns.Add(newConfigurationPattern);
            SelectedConfigurationPattern = newConfigurationPattern;
            txtConfigurationName.Focus();
            txtConfigurationName.SelectAll();
        }

        private void MoveUpConfigurationHandler(object sender, EventArgs e)
            => MoveItemUp(configurationPatternsBindingSource, Core?.Workspace?.ConfigurationPatterns);

        private void MoveDownConfigurationHandler(object sender, EventArgs e)
            => MoveItemDown(configurationPatternsBindingSource, Core?.Workspace?.ConfigurationPatterns);

        private void SortConfigurationsHandler(object sender, EventArgs e)
            => SortItems(configurationPatternsBindingSource, Core?.Workspace?.ConfigurationPatterns);

        private void DeleteConfigurationHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedConfigPattern = SelectedConfigurationPattern;
            if (selectedConfigPattern == null) return;
            Core.Workspace.ConfigurationPatterns.Remove(selectedConfigPattern);
        }

        private void ConfigurationPatternsListChangedHandler(object sender, ListChangedEventArgs e)
            => UpdateConfigurationPatternReferenceList();

        private void ConfigurationPatternSelectionChangedHandler(object sender, EventArgs e)
        {
            RefreshConfigurationPreview();
            UpdateControlActivation();
        }

        private void SelectedConfigurationPatternChanged(object sender, EventArgs e)
        {
            RefreshConfigurationPreview();
            WatchedConfigurationPattern = SelectedConfigurationPattern;
        }

        private void RefreshConfigurationPreview()
        {
            previewConfiguration.Invalidate();
        }

        private void ConfigurationPreviewPaintHandler(object sender, PaintEventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var canvas = (Control)sender;
            var configPattern = SelectedConfigurationPattern;
            if (configPattern == null) return;
            _previewPainter.PaintScreenConfiguration(e.Graphics, canvas.ClientSize, configPattern, SelectedScreenPattern);
        }

        #region Automatic Reference Update

        private ConfigurationPattern _watchedConfigurationPattern;
        private string _lastConfigurationPatternName;

        private ConfigurationPattern WatchedConfigurationPattern
        {
            get => _watchedConfigurationPattern;
            set
            {
                if (value == _watchedConfigurationPattern) return;
                if (_watchedConfigurationPattern != null)
                {
                    _watchedConfigurationPattern.NameChanged -= WatchedConfigurationPatternNameChangedHandler;
                    _lastConfigurationPatternName = null;
                }
                _watchedConfigurationPattern = value;
                if (_watchedConfigurationPattern != null)
                {
                    _lastConfigurationPatternName = _watchedConfigurationPattern.Name;
                    _watchedConfigurationPattern.NameChanged += WatchedConfigurationPatternNameChangedHandler;
                }
            }
        }

        private void WatchedConfigurationPatternNameChangedHandler(object sender, EventArgs e)
        {
            Core?.Workspace?.UpdateConfigurationReferences(_lastConfigurationPatternName, _watchedConfigurationPattern.Name);
            _lastConfigurationPatternName = _watchedConfigurationPattern.Name;
            UpdateConfigurationPatternReferenceList();
        }

        private void UpdateConfigurationPatternReferenceList()
        {
            if (!HasCore || Core.Workspace == null) return;
            cmbLayoutConfiguration.Items.Clear();
            cmbLayoutConfiguration.Items.AddRange(Core.Workspace.ConfigurationPatterns.Select(p => p.Name).ToArray());
        }

        #endregion

        #endregion

        #region Screen Pattern

        private ScreenPattern SelectedScreenPattern
            => screensPatternsBindingSource.Position >= 0 && screensPatternsBindingSource.Count > screensPatternsBindingSource.Position
                ? screensPatternsBindingSource.Current as ScreenPattern
                : null;

        private void ScreenPatternSelectionChanged(object sender, EventArgs e)
        {
            SelectedScreenPatternChanged(sender, e);
            UpdateControlActivation();
            WatchedScreenPattern = SelectedScreenPattern;
        }

        private void SelectedScreenPatternChanged(object sender, EventArgs e)
        {
            RefreshConfigurationPreview();
        }

        #region Automatic Reference Update

        private ScreenPattern _watchedScreenPattern;
        private string _lastScreenPatternName;

        private ScreenPattern WatchedScreenPattern
        {
            get => _watchedScreenPattern;
            set
            {
                if (value == _watchedScreenPattern) return;
                if (_watchedScreenPattern != null)
                {
                    _watchedScreenPattern.NameChanged -= WatchedScreenPatternNameChangedHandler;
                    _lastScreenPatternName = null;
                }
                _watchedScreenPattern = value;
                if (_watchedScreenPattern != null)
                {
                    _lastScreenPatternName = _watchedScreenPattern.Name;
                    _watchedScreenPattern.NameChanged += WatchedScreenPatternNameChangedHandler;
                }
            }
        }

        private void WatchedScreenPatternNameChangedHandler(object sender, EventArgs e)
        {
            Core?.Workspace?.UpdateScreenPatternReferences(SelectedConfigurationPattern?.Name,
                _lastScreenPatternName, _watchedScreenPattern.Name);
            _lastScreenPatternName = _watchedScreenPattern.Name;
            RefreshWindowActionScreens();
        }

        #endregion

        #endregion

        #region Layouts

        private Layout SelectedLayout
        {
            get => layoutsBindingSource.Position >= 0 && layoutsBindingSource.Count > layoutsBindingSource.Position
                ? layoutsBindingSource.Current as Layout
                : null;
            set => layoutsBindingSource.Position
                = Core.Workspace.Layouts.IndexOf(value);
        }

        private void NewLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var newLayout = new Layout();
            Core.Workspace.Layouts.Add(newLayout);
            SelectedLayout = newLayout;
            txtLayoutName.Focus();
            txtLayoutName.SelectAll();
        }

        private void DuplicateLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var position = Core.Workspace.Layouts.IndexOf(selectedLayout) + 1;
            var copy = selectedLayout.Clone();
            copy.Name += " Copy";
            Core.Workspace.Layouts.Insert(position, copy);
            SelectedLayout = copy;
            txtLayoutName.Focus();
            txtLayoutName.SelectAll();
        }

        private void DeleteLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            Core.Workspace.Layouts.Remove(selectedLayout);
        }

        private void MoveUpLayoutHandler(object sender, EventArgs e)
            => MoveItemUp(layoutsBindingSource, Core?.Workspace?.Layouts);

        private void MoveDownLayoutHandler(object sender, EventArgs e)
            => MoveItemDown(layoutsBindingSource, Core?.Workspace?.Layouts);

        private void SortLayoutsHandler(object sender, EventArgs e)
            => SortItems(layoutsBindingSource, Core?.Workspace?.Layouts);

        private void ApplyCurrentLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;

            WindowWrapper.ClearCaches();
            selectedLayout.Apply(Core.Workspace, StatusMessageHandler, ApplyOverrides.None);
        }

        private void KillCurrentLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;

            WindowWrapper.ClearCaches();
            selectedLayout.Kill(Core.Workspace, StatusMessageHandler, KillOverrides.None);
        }

        private void LayoutSelectionChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
            RefreshWindowActionScreens();
            UpdateControlActivation();
        }

        private void SelectedLayoutChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
            RefreshWindowActionScreens();
        }

        private void RefreshWindowActionScreens()
        {
            if (!HasCore || Core.Workspace == null) return;
            cmbWindowActionScreen.Items.Clear();
            var selectedLayout = SelectedLayout;
            if (selectedLayout != null)
            {
                var configuration = Core.Workspace.FindConfigurationPattern(selectedLayout.Configuration);
                if (configuration != null)
                {
                    cmbWindowActionScreen.Items.AddRange(configuration.Screens.Select(s => s.Name).ToArray());
                }
            }
        }

        private void RefreshLayoutPreview()
        {
            previewLayout.Invalidate();
        }

        private readonly LayoutPreviewState _previewState;

        private void RasterChooserMouseEnterHandler(object sender, EventArgs e)
        {
            _previewState.ForceRaster = true;
            RefreshLayoutPreview();
        }

        private void RasterChooserMouseLeaveHandler(object sender, EventArgs e)
        {
            _previewState.ForceRaster = false;
            RefreshLayoutPreview();
        }

        private void PreviewLayoutPaintHandler(object sender, PaintEventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var canvas = (Control)sender;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction != null)
            {
                _previewPainter.PaintWindowActions(e.Graphics, canvas.ClientSize, Core.Workspace, selectedLayout, selectedWindowAction);
            }
            else
            {
                var configuration = Core.Workspace.FindConfigurationPattern(selectedLayout.Configuration);
                if (configuration == null) return;
                _previewPainter.PaintScreenConfiguration(e.Graphics, canvas.ClientSize, configuration);
            }

            var c = Core?.Workspace?.FindConfigurationPattern(selectedLayout.Configuration);
            if (c != null && c.Screens.Count > 0 && _previewState.Raster != null 
                && (_previewState.ScreenUnderCursor != null || _previewState.ForceRaster))
            {
                _previewPainter.PaintRaster(e.Graphics, canvas.ClientSize, Core.Workspace,
                    selectedLayout, _previewState.Raster, _previewState.ScreenUnderCursor,
                    _previewState.From, _previewState.To);
            }
        }

        private void UpdateLayoutPreviewTo(Control canvas, Point pos)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            if (_previewState.Raster == null) return;
            _previewPainter.TransformFromScreen(canvas.Size, Core.Workspace, selectedLayout,
                pos, out var screen, out var p);
            _previewState.ScreenUnderCursor = screen;
            if (screen != null)
            {
                var to = _previewState.Raster.GetPartition(
                    (float)p.X / (float)screen.Width, (float)p.Y / (float)screen.Height);
                _previewState.To = to;
                RefreshLayoutPreview();
            }
            else
            {
                if (_previewState.To.HasValue)
                {
                    _previewState.To = null;
                    RefreshLayoutPreview();
                }
            }
        }

        private void PreviewLayoutMouseMoveHandler(object sender, MouseEventArgs e)
        {
            UpdateLayoutPreviewTo((Control)sender, e.Location);
        }

        private void PreviewLayoutMouseLeaveHandler(object sender, EventArgs e)
        {
            _previewState.ScreenUnderCursor = null;
            RefreshLayoutPreview();
        }

        private void PreviewLayoutMouseDownHandler(object sender, MouseEventArgs e)
        {
            UpdateLayoutPreviewTo((Control)sender, e.Location);
            _previewState.From = _previewState.To;
        }

        private void PreviewLayoutMouseUpHandler(object sender, MouseEventArgs e)
        {
            UpdateLayoutPreviewTo((Control)sender, e.Location);
            UpdateWindowActionFromPreviewState();
            _previewState.From = null;
            RefreshLayoutPreview();
        }

        private void UpdateWindowActionFromPreviewState()
        {
            Debug.WriteLine($"{_previewState.From} -> {_previewState.To}");
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;

            if (_previewState.Raster == null) return;
            if (_previewState.ScreenUnderCursor == null) return;
            if (_previewState.From == null) return;
            if (_previewState.To == null) return;

            var s = _previewState.ScreenUnderCursor;
            var r = _previewState.Raster;
            var from = _previewState.From.Value;
            var to = _previewState.To.Value;

            WatchedWindowAction = null;
            selectedWindowAction.Screen = s.Name;
            selectedWindowAction.LeftUnit = ScreenUnit.Percent;
            selectedWindowAction.LeftInvert = false;
            selectedWindowAction.Left = (int)Math.Floor(r.X[from.X] * 100.0);
            selectedWindowAction.TopUnit = ScreenUnit.Percent;
            selectedWindowAction.TopInvert = false;
            selectedWindowAction.Top = (int)Math.Floor(r.Y[from.Y] * 100.0);
            selectedWindowAction.RightUnit = ScreenUnit.Percent;
            selectedWindowAction.RightInvert = false;
            selectedWindowAction.Right = (int)Math.Floor(r.X[to.X + 1] * 100.0);
            selectedWindowAction.BottomUnit = ScreenUnit.Percent;
            selectedWindowAction.BottomInvert = false;
            selectedWindowAction.Bottom = (int)Math.Floor(r.Y[to.Y + 1] * 100.0);
            WatchedWindowAction = selectedWindowAction;
        }

        #endregion

        #region Window Action

        private WindowAction SelectedWindowAction
        {
            get => windowActionsBindingSource.Position >= 0 && windowActionsBindingSource.Count > windowActionsBindingSource.Position
                ? windowActionsBindingSource.Current as WindowAction
                : null;
            set => windowActionsBindingSource.Position
                = SelectedLayout?.Windows.IndexOf(value) ?? -1;
        }

        private void NewWindowActionHandler(object sender, EventArgs e)
        {
            if (SelectedLayout == null) return;
            var newWindowAction = new WindowAction();
            SelectedLayout.Windows.Add(newWindowAction);
            SelectedWindowAction = newWindowAction;
            cmbWindowActionWindow.Focus();
            cmbWindowActionWindow.SelectAll();
            cmbWindowActionWindow.DroppedDown = true;
        }

        private void DuplicateWindowActionHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;
            var position = selectedLayout.Windows.IndexOf(selectedWindowAction) + 1;
            var copy = selectedWindowAction.Clone();
            selectedLayout.Windows.Insert(position, copy);
            SelectedWindowAction = copy;
            cmbWindowActionWindow.Focus();
            cmbWindowActionWindow.SelectAll();
            cmbWindowActionWindow.DroppedDown = true;
        }

        private void DeleteWindowActionHandler(object sender, EventArgs e)
        {
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;
            windowActionsBindingSource.Remove(selectedWindowAction);
        }

        private void MoveUpWindowActionHandler(object sender, EventArgs e)
            => MoveItemUp(windowActionsBindingSource, SelectedLayout?.Windows);

        private void MoveDownWindowActionHandler(object sender, EventArgs e)
            => MoveItemDown(windowActionsBindingSource, SelectedLayout?.Windows);

        private void SortWindowActionsHandler(object sender, EventArgs e)
            => SortItems(windowActionsBindingSource, SelectedLayout?.Windows);

        private void ApplyWindowActionHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;

            WindowWrapper.ClearCaches();
            selectedWindowAction.Apply(Core.Workspace, selectedLayout, StatusMessageHandler, ApplyOverrides.None);
        }

        private void KillWindowActionHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;

            WindowWrapper.ClearCaches();
            selectedWindowAction.Kill(Core.Workspace, StatusMessageHandler, KillOverrides.None);
        }

        private void WindowActionSelectionChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
            UpdateControlActivation();
            WatchedWindowAction = SelectedWindowAction;
        }

        private void SelectedWindowActionChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
        }

        private void RecordWindowPositionHandler(object sender, EventArgs e)
        {
            if (!HasCore) return;
            Core.ReloadWindows();
            var wa = SelectedWindowAction;
            if (wa == null) return;
            var layout = SelectedLayout;
            if (layout == null) return;
            wa.RecordPosition(Core.Workspace, SelectedLayout);
        }

        #region Unit Conversion

        private WindowAction _watchedWindowAction;

        private WindowAction WatchedWindowAction
        {
            get => _watchedWindowAction;
            set
            {
                if (_watchedWindowAction == value) return;
                if (_watchedWindowAction != null)
                {
                    _watchedWindowAction.LeftInvertChanged -= WatchedWindowActionLeftInvertChangedHandler;
                    _watchedWindowAction.LeftUnitChanged -= WatchedWindowActionLeftUnitChangedHandler;
                    _watchedWindowAction.TopInvertChanged -= WatchedWindowActionTopInvertChangedHandler;
                    _watchedWindowAction.TopUnitChanged -= WatchedWindowActionTopUnitChangedHandler;
                    _watchedWindowAction.RightInvertChanged -= WatchedWindowActionRightInvertChangedHandler;
                    _watchedWindowAction.RightUnitChanged -= WatchedWindowActionRightUnitChangedHandler;
                    _watchedWindowAction.BottomInvertChanged -= WatchedWindowActionBottomInvertChangedHandler;
                    _watchedWindowAction.BottomUnitChanged -= WatchedWindowActionBottomUnitChangedHandler;
                }
                _watchedWindowAction = value;
                if (_watchedWindowAction != null)
                {
                    _watchedWindowAction.LeftInvertChanged += WatchedWindowActionLeftInvertChangedHandler;
                    _watchedWindowAction.LeftUnitChanged += WatchedWindowActionLeftUnitChangedHandler;
                    _watchedWindowAction.TopInvertChanged += WatchedWindowActionTopInvertChangedHandler;
                    _watchedWindowAction.TopUnitChanged += WatchedWindowActionTopUnitChangedHandler;
                    _watchedWindowAction.RightInvertChanged += WatchedWindowActionRightInvertChangedHandler;
                    _watchedWindowAction.RightUnitChanged += WatchedWindowActionRightUnitChangedHandler;
                    _watchedWindowAction.BottomInvertChanged += WatchedWindowActionBottomInvertChangedHandler;
                    _watchedWindowAction.BottomUnitChanged += WatchedWindowActionBottomUnitChangedHandler;
                }
            }
        }

        private Rect GetScreenBoundsForWindowAction(WindowAction windowAction)
            => Core
                ?.Workspace
                ?.FindConfigurationPattern(SelectedLayout?.Configuration)
                ?.FindScreenPattern(windowAction.Screen)
                ?.Bounds;

        private void WatchedWindowActionLeftInvertChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.LeftUnit == ScreenUnit.Percent)
                _watchedWindowAction.Left = 100 - _watchedWindowAction.Left;
            else
                _watchedWindowAction.Left = bounds.Width - _watchedWindowAction.Left;
        }

        private void WatchedWindowActionLeftUnitChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.LeftUnit == ScreenUnit.Percent)
                _watchedWindowAction.Left = (int)Math.Round(
                    _watchedWindowAction.Left / (double)bounds.Width * 100.0);
            else
                _watchedWindowAction.Left = (int)Math.Round(
                    _watchedWindowAction.Left / 100.0 * (double)bounds.Width);
        }

        private void WatchedWindowActionTopInvertChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.TopUnit == ScreenUnit.Percent)
                _watchedWindowAction.Top = 100 - _watchedWindowAction.Top;
            else
                _watchedWindowAction.Top = bounds.Height - _watchedWindowAction.Top;
        }

        private void WatchedWindowActionTopUnitChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.TopUnit == ScreenUnit.Percent)
                _watchedWindowAction.Top = (int)Math.Round(
                    _watchedWindowAction.Top / (double)bounds.Height * 100.0);
            else
                _watchedWindowAction.Top = (int)Math.Round(
                    _watchedWindowAction.Top / 100.0 * (double)bounds.Height);
        }

        private void WatchedWindowActionRightInvertChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.RightUnit == ScreenUnit.Percent)
                _watchedWindowAction.Right = 100 - _watchedWindowAction.Right;
            else
                _watchedWindowAction.Right = bounds.Width - _watchedWindowAction.Right;
        }

        private void WatchedWindowActionRightUnitChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.RightUnit == ScreenUnit.Percent)
                _watchedWindowAction.Right = (int)Math.Round(
                    _watchedWindowAction.Right / (double)bounds.Width * 100.0);
            else
                _watchedWindowAction.Right = (int)Math.Round(
                    _watchedWindowAction.Right / 100.0 * (double)bounds.Width);
        }

        private void WatchedWindowActionBottomInvertChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.BottomUnit == ScreenUnit.Percent)
                _watchedWindowAction.Bottom = 100 - _watchedWindowAction.Bottom;
            else
                _watchedWindowAction.Bottom = bounds.Height - _watchedWindowAction.Bottom;
        }

        private void WatchedWindowActionBottomUnitChangedHandler(object sender, EventArgs e)
        {
            var bounds = GetScreenBoundsForWindowAction(_watchedWindowAction);
            if (bounds == null) return;
            if (_watchedWindowAction.BottomUnit == ScreenUnit.Percent)
                _watchedWindowAction.Bottom = (int)Math.Round(
                    _watchedWindowAction.Bottom / (double)bounds.Height * 100.0);
            else
                _watchedWindowAction.Bottom = (int)Math.Round(
                    _watchedWindowAction.Bottom / 100.0 * (double)bounds.Height);
        }

        #endregion

        #endregion

        #region Options

        private Options _options;

        private void BindOptions(Options options)
        {
            _options = options;
            if (_options == null) return;
            _options.RestorationTimeoutChanged += RestorationTimeoutChangedHandler;
            numRestorationTimeout.ValueChanged += NumRestorationTimeoutValueChangedHandler;
            RestorationTimeoutChangedHandler(_options, EventArgs.Empty);
        }

        private void ReleaseOptions()
        {
            if (_options == null) return;

            numRestorationTimeout.ValueChanged -= NumRestorationTimeoutValueChangedHandler;
            _options.RestorationTimeoutChanged -= RestorationTimeoutChangedHandler;
            _options = null;
        }

        private void RestorationTimeoutChangedHandler(object sender, EventArgs e)
        {
            numRestorationTimeout.Value = _options.RestorationTimeout;
        }

        private void NumRestorationTimeoutValueChangedHandler(object sender, EventArgs e)
        {
            if (_options == null) return;
            _options.RestorationTimeout = (int)numRestorationTimeout.Value;
        }

        private void BrowseShortcutDirectoryHandler(object sender, EventArgs e)
        {
            var workspaceDir = !string.IsNullOrWhiteSpace(_core.WorkspaceFileName)
                ? Path.GetDirectoryName(_core.WorkspaceFileName)
                : null;
            var currentPath = txtShortcutDirectory.Text;
            if (string.IsNullOrWhiteSpace(currentPath))
            {
                currentPath = "WinMan Shortcuts";
            }
            if (!Path.IsPathRooted(currentPath))
            {
                currentPath = Path.Combine(workspaceDir ?? Environment.CurrentDirectory, currentPath);
            }
            var dlg = new FolderBrowserDialog
            {
                Description = "Choose directory to create shortcuts in",
                SelectedPath = Directory.Exists(currentPath) ? currentPath : Path.GetDirectoryName(currentPath),
                ShowNewFolderButton = true,
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                currentPath = dlg.SelectedPath;
                if (workspaceDir != null &&
                    currentPath.ToLowerInvariant().StartsWith(
                        workspaceDir.ToLowerInvariant()))
                {
                    currentPath = currentPath.Substring(workspaceDir.Length)
                        .TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                }
                _options.ShortcutDirectory = currentPath;
            }
        }

        #endregion

        #region Helper

        private static void MoveItemUp<T>(BindingSource bindingSource, IList<T> list)
        {
            if (list == null) return;
            var pos = bindingSource.Position;
            if (pos < 1) return;
            var item = list[pos];
            list.RemoveAt(pos);
            list.Insert(pos - 1, item);
            bindingSource.Position = pos - 1;
        }

        private static void MoveItemDown<T>(BindingSource bindingSource, IList<T> list)
        {
            if (list == null) return;
            var pos = bindingSource.Position;
            if (pos >= list.Count - 1) return;
            var item = list[pos];
            list.RemoveAt(pos);
            list.Insert(pos + 1, item);
            bindingSource.Position = pos + 1;
        }

        private static void SortItems<T>(BindingSource bindingSource, IList<T> list)
        {
            if (list == null) return;
            var selectedItem = (T)bindingSource.Current;
            var sortedItems = list.OrderBy(o => o.ToString()).ToList();
            list.Clear();
            foreach (var item in sortedItems) list.Add(item);
            bindingSource.Position = list.IndexOf(selectedItem);
        }

        #endregion

        private void ClosingHandler(object sender, FormClosingEventArgs e)
        {
            if (Core.WorkspaceFileName == null && File.Exists(Core.DefaultWorkspaceFilePath))
            {
                Core.ShowSaveWorkspaceFileDialog(null, "Save Workspace...");
            }
            else if (Core.Workspace.IsChanged)
            {
                var result = MessageBox.Show(
                    "The workspace has unsaved changes.\n\nDo you want to save the workspace?",
                    "Exit WinMan",
                    e.CloseReason == CloseReason.UserClosing ? MessageBoxButtons.YesNoCancel : MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    Core.WriteWorkspaceToFile();
                }
            }
        }
    }
}
