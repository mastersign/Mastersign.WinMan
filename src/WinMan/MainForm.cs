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

        public MainForm()
        {
            InitializeComponent();
        }

        private void FormLoadHandler(object sender, EventArgs e)
        {
            cmbTitlePatternType.DataSource = Enum.GetValues(typeof(StringPatternType));
            cmbWindowClassPatternType.DataSource = Enum.GetValues(typeof(StringPatternType));
            cmbWindowPositioning.DataSource = Enum.GetValues(typeof(Positioning));
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
            fileName = fileName ?? DefaultWorkspaceFilePath;
            if (!File.Exists(fileName))
            {
                _workspace = new Workspace
                {
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
        }
        private void WriteWorkspaceToFile(string fileName = null)
        {
            fileName = fileName ?? DefaultWorkspaceFilePath;
            File.WriteAllText(fileName,
                JsonConvert.SerializeObject(_workspace, CreateJsonSerializerSettings()),
                new UTF8Encoding(false));
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

        #endregion

        #region Window List

        private WindowWrapper[] LoadWindows()
        {
            var windows = WindowWrapper.AllWindows()
                .Where(w => w.IsVisible && w.VirtualDesktop != null)
                .ToArray();
            Array.ForEach(windows, w => w.Refresh());
            return windows;
        }

        private ListViewItem ListViewItemFromWindow(WindowWrapper w)
        {
            var selectedPattern = SelectedWindowPattern;
            var item = new ListViewItem(new string[]
                    {
                        selectedPattern != null ? (selectedPattern.IsMatch(w) ? "Yes" : "No") : string.Empty,
                        w.Title,
                        w.Handle.ToString(),
                        w.WindowClass,
                        w.ShowCommand.ToString(),
                        w.NormalPosition.ToString(),
                        w.Screen.DeviceName,
                        (VirtualDesktopHelper.GetVirtualDesktopNumber(w.VirtualDesktop?.Id ?? Guid.Empty) + 1).ToString(),
                        w.ProcessFileName,
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

        #endregion

        #region Layouts


        private Layout SelectedLayout => layoutsBindingSource.Current as Layout;

        private void NewLayoutHandler(object sender, EventArgs e)
        {
            _workspace.Layouts.Add(new Layout()
            {
                Configurations = new BindingList<ConfigurationPattern>(),
                Windows = new BindingList<WindowAction>(),
            });
        }

        private void DeleteLayoutHandler(object sender, EventArgs e)
        {
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            _workspace.Layouts.Remove(selectedLayout);
        }

        #endregion

        #region Configurations

        private void RecordConfigurationHandler(object sender, EventArgs e)
        {
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            selectedLayout.Configurations.Add(ConfigurationPattern.FromConfiguration(
                Screen.AllScreens, VirtualDesktop.GetDesktops().Length));
        }

        #endregion

        #region Screen Pattern

        private void CurrentScreenPatternChanged(object sender, EventArgs e)
        {
            var screenPattern = screensBindingSource.Current as ScreenPattern;
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
        }

        #endregion

        #region Window Action

        private WindowAction SelectedWindowAction => windowsBindingSource.Current as WindowAction;

        private void NewWindowActionHandler(object sender, EventArgs e)
        {
            windowsBindingSource.Add(new WindowAction()
            {
                Window = "Unknown"
            });
        }

        private void DeleteWindowActionHandler(object sender, EventArgs e)
        {
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;
            windowsBindingSource.Remove(selectedWindowAction);
        }

        private void TestWindowActionHandler(object sender, EventArgs e)
        {
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;
            selectedWindowAction.Apply(_workspace, selectedLayout);
        }

        #endregion
    }
}
