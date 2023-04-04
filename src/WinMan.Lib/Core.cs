using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    partial class Core
    {
        private const string DEFAULT_WORKSPACE_FILENAME = "winman_workspace.json";

        public static Core DefaultCore { get; set; }

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
            fileName = Path.GetFullPath(fileName);
            if (!File.Exists(fileName))
            {
                Workspace = new Workspace
                {
                    ConfigurationPatterns = new BindingList<ConfigurationPattern>(),
                    WindowPatterns = new BindingList<WindowPattern>(),
                    Layouts = new BindingList<Layout>(),
                    Options = Options.Default(),
                };
            }
            else
            {
                var json = File.ReadAllText(fileName, new UTF8Encoding(false));
                Workspace = JsonConvert.DeserializeObject<Workspace>(json, CreateJsonSerializerSettings());
                Workspace.Upgrade();
            }
            Workspace.AcceptChanges();
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
            fileName = fileName ?? WorkspaceFileName ?? DefaultWorkspaceFilePath;
            File.WriteAllText(fileName,
                JsonConvert.SerializeObject(_workspace, CreateJsonSerializerSettings()),
                new UTF8Encoding(false));
            Workspace.AcceptChanges();
            WorkspaceFileName = fileName;

            var shortcutDir = Workspace.Options.ShortcutDirectory;
            if (Workspace.Options.CreateShortcuts && !string.IsNullOrWhiteSpace(shortcutDir))
            {
                if (!Path.IsPathRooted(shortcutDir))
                {
                    shortcutDir = Path.Combine(Path.GetDirectoryName(WorkspaceFileName), shortcutDir);
                }
                if (!Directory.Exists(shortcutDir))
                {
                    Directory.CreateDirectory(shortcutDir);
                }
                WriteShortcuts(shortcutDir, Workspace.Options.CleanUpShortcuts);
            }
        }

        private void WriteShortcuts(string targetDir, bool cleanUp)
        {
            if (!File.Exists(WorkspaceFileName)) return;
            var assemlby = Assembly.GetEntryAssembly();
            var exePath = new Uri(assemlby.GetName().CodeBase).LocalPath;
            var winManExePath = Path.Combine(Path.GetDirectoryName(exePath), "winman.exe");
            var winManGuiExePath = Path.Combine(Path.GetDirectoryName(exePath), "WinManGui.exe");

            if (cleanUp)
            {
                foreach (var link in Directory.GetFiles(targetDir, "*.lnk", SearchOption.TopDirectoryOnly))
                {
                    File.Delete(Path.Combine(targetDir, link));
                }
            }

            Shortcuts.Create(
                Path.Combine(targetDir, $"All Defaults {Workspace.Options.ShortcutApplyTerm}.lnk"),
                winManExePath,
                $"\"{WorkspaceFileName}\" --verbose --default-layouts",
                Path.GetDirectoryName(WorkspaceFileName),
                $"{winManGuiExePath},1",
                $"Apply all WinMan default layouts");

            Shortcuts.Create(
                Path.Combine(targetDir, $"All Defaults {Workspace.Options.ShortcutKillTerm}.lnk"),
                winManExePath,
                $"\"{WorkspaceFileName}\" --verbose --kill --default-layouts",
                Path.GetDirectoryName(WorkspaceFileName),
                $"{winManGuiExePath},2",
                $"Kill all WinMan default layouts");

            foreach (var layout in _workspace.Layouts)
            {
                if (!layout.CreateShortcut) continue;
                Shortcuts.Create(
                    Path.Combine(targetDir, $"{layout.Name} {Workspace.Options.ShortcutApplyTerm}.lnk"),
                    winManExePath,
                    $"\"{WorkspaceFileName}\" --verbose --switch-virtual-desktop {layout.DefaultVirtualDesktop} --layouts \"{layout.Name}\"",
                    Path.GetDirectoryName(WorkspaceFileName),
                    $"{winManGuiExePath},3",
                    $"Apply WinMan layout \"{layout.Name}\"");

                Shortcuts.Create(
                    Path.Combine(targetDir, $"{layout.Name} {Workspace.Options.ShortcutKillTerm}.lnk"),
                    winManExePath,
                    $"\"{WorkspaceFileName}\" --verbose --switch-virtual-desktop {layout.DefaultVirtualDesktop} --kill --layouts \"{layout.Name}\"",
                    Path.GetDirectoryName(WorkspaceFileName),
                    $"{winManGuiExePath},4",
                    $"Kill WinMan layout \"{layout.Name}\"");
            }
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
                Options = Options.Default(),
            };
            WorkspaceFileName = null;
        }

        public void ApplyWorkspace(StatusHandler statusHandler, ApplyOverrides overrides)
        {
            if (Workspace == null) throw new InvalidOperationException("No workspace laoded.");
            WindowWrapper.ClearCaches();
            Workspace.Apply(statusHandler, overrides);
        }

        public void KillWorkspace(StatusHandler statusHandler, KillOverrides overrides)
        {
            if (Workspace == null) throw new InvalidOperationException("No workspace laoded.");
            WindowWrapper.ClearCaches();
            Workspace.Kill(statusHandler, overrides);
        }
    }
}
