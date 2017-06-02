using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    partial class Core
    {
        private const string DEFAULT_WORKSPACE_FILENAME = "winman_workspace.json";

        public static string DefaultWorkspaceFilePath =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                DEFAULT_WORKSPACE_FILENAME);

        public void ReloadWindows()
        {
            WindowWrapper.ClearCaches();
            WindowWrappers = WindowWrapper.AllWindows();
        }

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

        public void LoadWorkspaceFromFile(string fileName = null)
        {
            fileName = fileName ?? _workspaceFileName ?? DefaultWorkspaceFilePath;
            if (!File.Exists(fileName))
            {
                Workspace = new Workspace
                {
                    ConfigurationPatterns = new BindingList<ConfigurationPattern>(),
                    WindowPatterns = new BindingList<WindowPattern>(),
                    Layouts = new BindingList<Layout>(),
                };
            }
            else
            {
                var json = File.ReadAllText(fileName, new UTF8Encoding(false));
                Workspace = JsonConvert.DeserializeObject<Workspace>(json, CreateJsonSerializerSettings());
            }
            WorkspaceFileName = fileName;
        }

        public bool ShowOpenWorkspaceFileDialog(IWin32Window owner, string title)
        {
            var openDlg = new OpenFileDialog
            {
                Title = title,
                InitialDirectory = Path.GetDirectoryName(DefaultWorkspaceFilePath),
                FileName = Path.GetFileName(DefaultWorkspaceFilePath),
            };
            var dlgResult = openDlg.ShowDialog(owner);
            if (dlgResult != DialogResult.OK) return false;
            try
            {
                LoadWorkspaceFromFile(openDlg.FileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void WriteWorkspaceToFile(string fileName = null)
        {
            fileName = fileName ?? DefaultWorkspaceFilePath;
            File.WriteAllText(fileName,
                JsonConvert.SerializeObject(_workspace, CreateJsonSerializerSettings()),
                new UTF8Encoding(false));
            WorkspaceFileName = fileName;
        }

        public bool ShowSaveWorkspaceFileDialog(IWin32Window owner, string title)
        {
            var saveDlg = new SaveFileDialog
            {
                Title = title,
                InitialDirectory = Path.GetDirectoryName(DefaultWorkspaceFilePath),
                FileName = Path.GetFileName(DefaultWorkspaceFilePath),
                OverwritePrompt = true,
            };
            var dlgResult = saveDlg.ShowDialog(owner);
            if (dlgResult != DialogResult.OK) return false;
            try
            {
                WriteWorkspaceToFile(saveDlg.FileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void CreateNewWorkspace()
        {
            Workspace = new Workspace
            {
                ConfigurationPatterns = new BindingList<ConfigurationPattern>(),
                WindowPatterns = new BindingList<WindowPattern>(),
                Layouts = new BindingList<Layout>(),
            };
            WorkspaceFileName = null;
        }

        public void ApplyWorkspace()
        {
            if (Workspace == null) throw new InvalidOperationException("No workspace laoded.");
            WindowWrapper.ClearCaches();
            Workspace.Apply();
        }
    }
}
