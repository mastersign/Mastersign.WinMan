using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;

namespace Mastersign.WinMan
{
    public partial class MainForm : Form
    {
        private Workspace _workspace;
        private WindowWrapper[] _windows;
        private PreviewPainter _previewPainter;
        private string _workspaceFileName;

        public MainForm()
        {
            _previewPainter = new PreviewPainter();
            InitializeComponent();
        }

        private void FormLoadHandler(object sender, EventArgs e)
        {
            cmbTitlePatternType.DataSource = Enum.GetValues(typeof(StringPatternType));
            cmbWindowClassPatternType.DataSource = Enum.GetValues(typeof(StringPatternType));
            cmbWindowState.DataSource = Enum.GetValues(typeof(WindowState));
            cmbWindowActionLeftUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));
            cmbWindowActionTopUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));
            cmbWindowActionRightUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));
            cmbWindowActionBottomUnit.DataSource = Enum.GetValues(typeof(ScreenUnit));

            ReloadWindowListHandler(this, EventArgs.Empty);
            LoadWorkspaceFromFile();
        }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            WriteWorkspaceToFile();
        }

        private void UpdateGlobals()
        {
            tsslFileName.Text = _workspaceFileName;
        }

        #region Workspace

        private const string DEFAULT_WORKSPACE_FILENAME = "winman_workspace.json";

        private string DefaultWorkspaceFilePath =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                DEFAULT_WORKSPACE_FILENAME);

        private JsonSerializerSettings CreateJsonSerializerSettings()
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include,
            };
            settings.Converters.Add(new StringEnumConverter());
            return settings;
        }

        private void LoadWorkspaceFromFile(string fileName = null)
        {
            fileName = fileName ?? _workspaceFileName ?? DefaultWorkspaceFilePath;
            if (!File.Exists(fileName))
            {
                _workspace = new Workspace
                {
                    ConfigurationPatterns = new BindingList<ConfigurationPattern>(),
                    WindowPatterns = new BindingList<WindowPattern>(),
                    Layouts = new BindingList<Layout>(),
                };
            }
            else
            {
                var json = File.ReadAllText(fileName, new UTF8Encoding(false));
                _workspace = JsonConvert.DeserializeObject<Workspace>(json, CreateJsonSerializerSettings());
            }
            workspaceBindingSource.DataSource = _workspace;
            _workspaceFileName = fileName;
            UpdateGlobals();
        }

        private void WriteWorkspaceToFile(string fileName = null)
        {
            fileName = fileName ?? DefaultWorkspaceFilePath;
            File.WriteAllText(fileName,
                JsonConvert.SerializeObject(_workspace, CreateJsonSerializerSettings()),
                new UTF8Encoding(false));
            _workspaceFileName = fileName;
            UpdateGlobals();
        }

        private void NewWorkspaceHandler(object sender, EventArgs e)
        {
            _workspace = new Workspace
            {
                ConfigurationPatterns = new BindingList<ConfigurationPattern>(),
                WindowPatterns = new BindingList<WindowPattern>(),
                Layouts = new BindingList<Layout>(),
            };
            workspaceBindingSource.DataSource = _workspace;
            _workspaceFileName = null;
            UpdateGlobals();
        }

        private void OpenWorkspaceHandler(object sender, EventArgs e)
        {
            var openDlg = new OpenFileDialog
            {
                Title = "Open Workspace...",
                InitialDirectory = Path.GetDirectoryName(DefaultWorkspaceFilePath),
                FileName = Path.GetFileName(DefaultWorkspaceFilePath),
            };
            var dlgResult = openDlg.ShowDialog(this);
            if (dlgResult == DialogResult.OK)
            {
                LoadWorkspaceFromFile(openDlg.FileName);
            }
        }

        private void SaveWorkspaceHandler(object sender, EventArgs e)
        {
            var saveDlg = new SaveFileDialog
            {
                Title = "Save Workspace...",
                InitialDirectory = Path.GetDirectoryName(DefaultWorkspaceFilePath),
                FileName = Path.GetFileName(DefaultWorkspaceFilePath),
                OverwritePrompt = true,
            };
            var dlgResult = saveDlg.ShowDialog(this);
            if (dlgResult == DialogResult.OK)
            {
                WriteWorkspaceToFile(saveDlg.FileName);
            }
        }

        private void ApplyWorkspaceHandler(object sender, EventArgs e)
        {
            WindowWrapper.ClearCaches();
            _workspace.Apply();
        }

        #endregion

        #region Window List

        private WindowWrapper[] LoadWindows()
        {
            WindowWrapper.ClearCaches();
            return WindowWrapper.AllWindows();
        }

        private ListViewItem ListViewItemFromWindow(WindowWrapper w)
        {
            var selectedPattern = SelectedWindowPattern;
            var item = new ListViewItem(new string[]
                    {
                        selectedPattern != null ? (selectedPattern.IsMatch(w) ? "Yes" : "No") : string.Empty,
                        w.Title,
                        w.WindowClass,
                        Path.GetFileName(w.ProcessFileName),
                        w.Screen.DeviceName,
                        (VirtualDesktopHelper.GetVirtualDesktopNumber(w.VirtualDesktop?.Id ?? Guid.Empty) + 1).ToString(),
                        w.NormalPosition.ToString(),
                        w.ShowCommand.ToString(),
                    });
            item.Tag = w;
            return item;
        }

        private void ReloadWindowListHandler(object sender, EventArgs e)
        {
            _windows = LoadWindows();
            RefreshWindowListHandler(sender, e);
        }

        private void RefreshWindowListHandler(object sender, EventArgs e)
        {
            listWindows.Items.Clear();
            listWindows.Items.AddRange(_windows.Select(ListViewItemFromWindow).ToArray());
        }

        private WindowWrapper SelectedWindow
        {
            get
            {
                if (listWindows.SelectedItems.Count == 0) return null;
                return listWindows.SelectedItems[0].Tag as WindowWrapper;
            }
        }

        #endregion

        #region Window Patterns

        private WindowPattern SelectedWindowPattern => windowPatternsBindingSource.Current as WindowPattern;

        private void NewWindowPatternHandler(object sender, EventArgs e)
        {
            var selectedWindow = SelectedWindow;
            WindowPattern windowPattern;
            if (selectedWindow != null)
            {
                windowPattern = WindowPattern.FromWindow(selectedWindow);
            }
            else
            {
                windowPattern = new WindowPattern();
            }
            _workspace.WindowPatterns.Add(windowPattern);
        }

        private void DeleteWindowPatternHandler(object sender, EventArgs e)
        {
            var selectedWindowPattern = SelectedWindowPattern;
            if (selectedWindowPattern == null) return;
            _workspace.WindowPatterns.Remove(selectedWindowPattern);
        }

        private void CurrentWindowPatternChangedHandler(object sender, EventArgs e)
        {
            RefreshWindowListHandler(sender, e);
            listWindowPatterns.DataSource = listWindowPatterns.DataSource;
        }

        private void WindowPatternListChangedHandler(object sender, ListChangedEventArgs e)
        {
            if (_workspace == null) return;
            cmbWindowActionWindow.Items.Clear();
            cmbWindowActionWindow.Items.AddRange(_workspace.WindowPatterns.Select(p => p.Name).ToArray());
        }

        #endregion

        #region ConfigurationPatterns

        private ConfigurationPattern SelectedConfigurationPattern
            => configurationPatternsBindingSource.Current as ConfigurationPattern;

        private void RecordConfigurationHandler(object sender, EventArgs e)
        {
            if (_workspace == null) return;
            _workspace.ConfigurationPatterns.Add(ConfigurationPattern.FromConfiguration(
                Screen.AllScreens, VirtualDesktop.GetDesktops().Length));
        }

        private void DeleteConfigurationHandler(object sender, EventArgs e)
        {
            var selectedConfigPattern = SelectedConfigurationPattern;
            if (selectedConfigPattern == null) return;
            _workspace.ConfigurationPatterns.Remove(selectedConfigPattern);
        }

        private void ConfigurationPatternsListChangedHandler(object sender, ListChangedEventArgs e)
        {
            if (_workspace == null) return;
            cmbLayoutConfiguration.Items.Clear();
            cmbLayoutConfiguration.Items.AddRange(_workspace.ConfigurationPatterns.Select(p => p.Name).ToArray());
        }

        private void SelectedConfigurationPatternChanged(object sender, EventArgs e)
        {
            RefreshConfigurationPreview();
        }

        private void RefreshConfigurationPreview()
        {
            previewConfiguration.Invalidate();
        }

        private void ConfigurationPreviewPaintHandler(object sender, PaintEventArgs e)
        {
            var canvas = (Control)sender;
            if (_workspace == null) return;
            var configPattern = SelectedConfigurationPattern;
            if (configPattern == null) return;
            _previewPainter.PaintScreenConfiguration(e.Graphics, canvas.ClientSize, configPattern, SelectedScreenPattern);
        }

        #endregion

        #region Screen Pattern

        private ScreenPattern SelectedScreenPattern => screensPatternsBindingSource.Current as ScreenPattern;

        private void SelectedScreenPatternChanged(object sender, EventArgs e)
        {
            var screenPattern = screensPatternsBindingSource.Current as ScreenPattern;
            if (screenPattern == null)
            {
                numScreenLeft.Value = 0;
                numScreenTop.Value = 0;
                numScreenWidth.Value = 0;
                numScreenHeight.Value = 0;
            }
            else
            {
                numScreenLeft.Value = screenPattern.Bounds.Left;
                numScreenTop.Value = screenPattern.Bounds.Top;
                numScreenWidth.Value = screenPattern.Bounds.Width;
                numScreenHeight.Value = screenPattern.Bounds.Height;
            }
            RefreshConfigurationPreview();
        }

        #endregion

        #region Layouts

        private Layout SelectedLayout => layoutsBindingSource.Current as Layout;

        private void NewLayoutHandler(object sender, EventArgs e)
        {
            _workspace.Layouts.Add(new Layout()
            {
                Windows = new BindingList<WindowAction>(),
            });
        }

        private void DeleteLayoutHandler(object sender, EventArgs e)
        {
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            _workspace.Layouts.Remove(selectedLayout);
        }

        private void ApplyCurrentLayoutHandler(object sender, EventArgs e)
        {
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;

            WindowWrapper.ClearCaches();
            selectedLayout.Apply(_workspace);
        }

        private void SelectedLayoutChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
        }

        private void RefreshLayoutPreview()
        {
            previewLayout.Invalidate();
        }

        private void LayoutPreviewPaintHandler(object sender, PaintEventArgs e)
        {
            var canvas = (Control)sender;
            if (_workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction != null)
            {
                _previewPainter.PaintWindowActions(e.Graphics, canvas.ClientSize, _workspace, selectedLayout, selectedWindowAction);
            }
            else
            {
                var configuration = _workspace.FindConfigurationPattern(selectedLayout.Configuration);
                if (configuration == null) return;
                _previewPainter.PaintScreenConfiguration(e.Graphics, canvas.ClientSize, configuration);
            }
        }

        #endregion

        #region Window Action

        private WindowAction SelectedWindowAction => windowActionsBindingSource.Current as WindowAction;

        private void NewWindowActionHandler(object sender, EventArgs e)
        {
            windowActionsBindingSource.Add(new WindowAction()
            {
                Window = "Unknown"
            });
        }

        private void DeleteWindowActionHandler(object sender, EventArgs e)
        {
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;
            windowActionsBindingSource.Remove(selectedWindowAction);
        }

        private void ApplyWindowActionHandler(object sender, EventArgs e)
        {
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;

            WindowWrapper.ClearCaches();
            selectedWindowAction.Apply(_workspace, selectedLayout);
        }

        private void SelectedWindowActionChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
        }

        #endregion

    }
}
