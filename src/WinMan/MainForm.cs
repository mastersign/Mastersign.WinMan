﻿using Newtonsoft.Json;
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
    public partial class MainForm : ImprovedForm
    {
        private Core _core;
        private PreviewPainter _previewPainter;

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

            Core = Program.Core;
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
        }

        private void CoreWorkspaceChangedHandler(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((EventHandler)CoreWorkspaceChangedHandler, sender, e);
                return;
            }
            workspaceBindingSource.DataSource = Core?.Workspace;
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
            Core.ApplyWorkspace();
        }

        #endregion

        #region Window List

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
            => windowPatternsBindingSource.Position >= 0
                ? windowPatternsBindingSource.Current as WindowPattern
                : null;

        private void NewWindowPatternHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
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
            Core.Workspace.WindowPatterns.Add(windowPattern);
        }

        private void DeleteWindowPatternHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedWindowPattern = SelectedWindowPattern;
            if (selectedWindowPattern == null) return;
            Core.Workspace.WindowPatterns.Remove(selectedWindowPattern);
        }

        private void CurrentWindowPatternChangedHandler(object sender, EventArgs e)
        {
            RefreshWindowListHandler(sender, e);
            listWindowPatterns.DataSource = listWindowPatterns.DataSource;
        }

        private void WindowPatternListChangedHandler(object sender, ListChangedEventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            cmbWindowActionWindow.Items.Clear();
            cmbWindowActionWindow.Items.AddRange(Core.Workspace.WindowPatterns.Select(p => p.Name).ToArray());
        }

        #endregion

        #region ConfigurationPatterns

        private ConfigurationPattern SelectedConfigurationPattern
            => configurationPatternsBindingSource.Position >= 0
                ? configurationPatternsBindingSource.Current as ConfigurationPattern
                : null;

        private void RecordConfigurationHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            Core.Workspace.ConfigurationPatterns.Add(ConfigurationPattern.FromConfiguration(
                Screen.AllScreens, VirtualDesktop.GetDesktops().Length));
        }

        private void DeleteConfigurationHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedConfigPattern = SelectedConfigurationPattern;
            if (selectedConfigPattern == null) return;
            Core.Workspace.ConfigurationPatterns.Remove(selectedConfigPattern);
        }

        private void ConfigurationPatternsListChangedHandler(object sender, ListChangedEventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            cmbLayoutConfiguration.Items.Clear();
            cmbLayoutConfiguration.Items.AddRange(Core.Workspace.ConfigurationPatterns.Select(p => p.Name).ToArray());
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
            if (!HasCore || Core.Workspace == null) return;
            var canvas = (Control)sender;
            var configPattern = SelectedConfigurationPattern;
            if (configPattern == null) return;
            _previewPainter.PaintScreenConfiguration(e.Graphics, canvas.ClientSize, configPattern, SelectedScreenPattern);
        }

        #endregion

        #region Screen Pattern

        private ScreenPattern SelectedScreenPattern
            => screensPatternsBindingSource.Position >= 0
                ? screensPatternsBindingSource.Current as ScreenPattern
                : null;

        private void SelectedScreenPatternChanged(object sender, EventArgs e)
        {
            var screenPattern = SelectedScreenPattern;
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

        private Layout SelectedLayout
            => layoutsBindingSource.Position >= 0
                ? layoutsBindingSource.Current as Layout
                : null;

        private void NewLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            Core.Workspace.Layouts.Add(new Layout()
            {
                Windows = new BindingList<WindowAction>(),
            });
        }

        private void DeleteLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            Core.Workspace.Layouts.Remove(selectedLayout);
        }

        private void ApplyCurrentLayoutHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;

            WindowWrapper.ClearCaches();
            selectedLayout.Apply(Core.Workspace);
        }

        private void SelectedLayoutChangedHandler(object sender, EventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            RefreshLayoutPreview();
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

        private void LayoutPreviewPaintHandler(object sender, PaintEventArgs e)
        {
            if (!HasCore || Core.Workspace == null) return;
            var canvas = (Control)sender;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
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
        }

        #endregion

        #region Window Action

        private WindowAction SelectedWindowAction
            => windowActionsBindingSource.Position >= 0
                ? windowActionsBindingSource.Current as WindowAction
                : null;

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
            if (!HasCore || Core.Workspace == null) return;
            var selectedLayout = SelectedLayout;
            if (selectedLayout == null) return;
            var selectedWindowAction = SelectedWindowAction;
            if (selectedWindowAction == null) return;

            WindowWrapper.ClearCaches();
            selectedWindowAction.Apply(Core.Workspace, selectedLayout);
        }

        private void SelectedWindowActionChangedHandler(object sender, EventArgs e)
        {
            RefreshLayoutPreview();
        }

        #endregion
    }
}
