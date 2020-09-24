using IWshRuntimeLibrary;

namespace Mastersign.WinMan
{
    public static class Shortcuts
    {
        public static void Create(string linkPath, 
            string targetPath, string arguments, string workingDir,
            string iconLocation, string description = null)
        {
            var shell = new WshShell();
            var shortcut = (IWshShortcut)shell.CreateShortcut(linkPath);
            shortcut.TargetPath = targetPath;
            shortcut.Arguments = arguments;
            shortcut.WorkingDirectory = workingDir;
            shortcut.IconLocation = iconLocation;
            shortcut.Description = description;
            shortcut.Save();
        }
    }
}
