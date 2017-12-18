using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mastersign.WinMan
{
    #region Scaleton Model Designer generated code
    
    public enum StringPatternType
    {
        Exact,
        Wildcard,
        Regex,
    }
    
    public enum WindowState
    {
        Minimized,
        Normal,
        Maximized,
    }
    
    public enum ScreenUnit
    {
        Pixel,
        Percent,
    }
    
    public partial class Rect : IEquatable<Rect>
    {
        public Rect()
        {
        }
        
        public Rect(int x, int y, int width, int height)
        {
            this._x = x;
            this._y = y;
            this._width = width;
            this._height = height;
        }
        
        #region Equatability
        
        public bool Equals(Rect o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return (
                (this._x == o._x) && 
                (this._y == o._y) && 
                (this._width == o._width) && 
                (this._height == o._height));
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(Rect)))
            {
                return false;
            }
            return this.Equals((Rect)o);
        }
        
        public override int GetHashCode()
        {
            return (this.GetType().GetHashCode() ^ 
                this._x.GetHashCode() ^ 
                this._y.GetHashCode() ^ 
                this._width.GetHashCode() ^ 
                this._height.GetHashCode());
        }
        
        #endregion
        
        #region Property X
        
        private int _x;
        
        public virtual int X
        {
            get { return _x; }
        }
        
        #endregion
        
        #region Property Y
        
        private int _y;
        
        public virtual int Y
        {
            get { return _y; }
        }
        
        #endregion
        
        #region Property Width
        
        private int _width;
        
        public virtual int Width
        {
            get { return _width; }
        }
        
        #endregion
        
        #region Property Height
        
        private int _height;
        
        public virtual int Height
        {
            get { return _height; }
        }
        
        #endregion
    }
    
    public partial class WindowPattern : IEquatable<WindowPattern>, INotifyPropertyChanged
    {
        public WindowPattern()
        {
            this._name = DEF_NAME;
            this._titlePatternType = DEF_TITLEPATTERNTYPE;
            this._windowClassPatternType = DEF_WINDOWCLASSPATTERNTYPE;
        }
        
        #region Equatability
        
        public bool Equals(WindowPattern o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(WindowPattern)))
            {
                return false;
            }
            return this.Equals((WindowPattern)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"No Name";
        
        [DefaultValue(DEF_NAME)]
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.Equals(value, _name))
                {
                    return;
                }
                _name = value;
                this.OnNameChanged();
            }
        }
        
        #endregion
        
        #region Property TitlePattern
        
        private string _titlePattern;
        
        public event EventHandler TitlePatternChanged;
        
        protected virtual void OnTitlePatternChanged()
        {
            EventHandler handler = TitlePatternChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"TitlePattern");
        }
        
        public virtual string TitlePattern
        {
            get { return _titlePattern; }
            set
            {
                if (string.Equals(value, _titlePattern))
                {
                    return;
                }
                _titlePattern = value;
                this.OnTitlePatternChanged();
            }
        }
        
        #endregion
        
        #region Property TitlePatternType
        
        private StringPatternType _titlePatternType;
        
        public event EventHandler TitlePatternTypeChanged;
        
        protected virtual void OnTitlePatternTypeChanged()
        {
            EventHandler handler = TitlePatternTypeChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"TitlePatternType");
        }
        
        private const StringPatternType DEF_TITLEPATTERNTYPE = StringPatternType.Wildcard;
        
        [DefaultValue(DEF_TITLEPATTERNTYPE)]
        public virtual StringPatternType TitlePatternType
        {
            get { return _titlePatternType; }
            set
            {
                if ((value == _titlePatternType))
                {
                    return;
                }
                _titlePatternType = value;
                this.OnTitlePatternTypeChanged();
            }
        }
        
        #endregion
        
        #region Property TitleIgnoreCase
        
        private bool _titleIgnoreCase;
        
        public event EventHandler TitleIgnoreCaseChanged;
        
        protected virtual void OnTitleIgnoreCaseChanged()
        {
            EventHandler handler = TitleIgnoreCaseChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"TitleIgnoreCase");
        }
        
        public virtual bool TitleIgnoreCase
        {
            get { return _titleIgnoreCase; }
            set
            {
                if ((value == _titleIgnoreCase))
                {
                    return;
                }
                _titleIgnoreCase = value;
                this.OnTitleIgnoreCaseChanged();
            }
        }
        
        #endregion
        
        #region Property WindowClassPattern
        
        private string _windowClassPattern;
        
        public event EventHandler WindowClassPatternChanged;
        
        protected virtual void OnWindowClassPatternChanged()
        {
            EventHandler handler = WindowClassPatternChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowClassPattern");
        }
        
        public virtual string WindowClassPattern
        {
            get { return _windowClassPattern; }
            set
            {
                if (string.Equals(value, _windowClassPattern))
                {
                    return;
                }
                _windowClassPattern = value;
                this.OnWindowClassPatternChanged();
            }
        }
        
        #endregion
        
        #region Property WindowClassPatternType
        
        private StringPatternType _windowClassPatternType;
        
        public event EventHandler WindowClassPatternTypeChanged;
        
        protected virtual void OnWindowClassPatternTypeChanged()
        {
            EventHandler handler = WindowClassPatternTypeChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowClassPatternType");
        }
        
        private const StringPatternType DEF_WINDOWCLASSPATTERNTYPE = StringPatternType.Exact;
        
        [DefaultValue(DEF_WINDOWCLASSPATTERNTYPE)]
        public virtual StringPatternType WindowClassPatternType
        {
            get { return _windowClassPatternType; }
            set
            {
                if ((value == _windowClassPatternType))
                {
                    return;
                }
                _windowClassPatternType = value;
                this.OnWindowClassPatternTypeChanged();
            }
        }
        
        #endregion
        
        #region Property WindowClassIgnoreCase
        
        private bool _windowClassIgnoreCase;
        
        public event EventHandler WindowClassIgnoreCaseChanged;
        
        protected virtual void OnWindowClassIgnoreCaseChanged()
        {
            EventHandler handler = WindowClassIgnoreCaseChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowClassIgnoreCase");
        }
        
        public virtual bool WindowClassIgnoreCase
        {
            get { return _windowClassIgnoreCase; }
            set
            {
                if ((value == _windowClassIgnoreCase))
                {
                    return;
                }
                _windowClassIgnoreCase = value;
                this.OnWindowClassIgnoreCaseChanged();
            }
        }
        
        #endregion
        
        #region Property ProcessFileName
        
        private string _processFileName;
        
        public event EventHandler ProcessFileNameChanged;
        
        protected virtual void OnProcessFileNameChanged()
        {
            EventHandler handler = ProcessFileNameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ProcessFileName");
        }
        
        public virtual string ProcessFileName
        {
            get { return _processFileName; }
            set
            {
                if (string.Equals(value, _processFileName))
                {
                    return;
                }
                _processFileName = value;
                this.OnProcessFileNameChanged();
            }
        }
        
        #endregion
        
        #region Property Restore
        
        private bool _restore;
        
        public event EventHandler RestoreChanged;
        
        protected virtual void OnRestoreChanged()
        {
            EventHandler handler = RestoreChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Restore");
        }
        
        public virtual bool Restore
        {
            get { return _restore; }
            set
            {
                if ((value == _restore))
                {
                    return;
                }
                _restore = value;
                this.OnRestoreChanged();
            }
        }
        
        #endregion
        
        #region Property Command
        
        private string _command;
        
        public event EventHandler CommandChanged;
        
        protected virtual void OnCommandChanged()
        {
            EventHandler handler = CommandChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Command");
        }
        
        public virtual string Command
        {
            get { return _command; }
            set
            {
                if (string.Equals(value, _command))
                {
                    return;
                }
                _command = value;
                this.OnCommandChanged();
            }
        }
        
        #endregion
        
        #region Property CommandArgs
        
        private string _commandArgs;
        
        public event EventHandler CommandArgsChanged;
        
        protected virtual void OnCommandArgsChanged()
        {
            EventHandler handler = CommandArgsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"CommandArgs");
        }
        
        public virtual string CommandArgs
        {
            get { return _commandArgs; }
            set
            {
                if (string.Equals(value, _commandArgs))
                {
                    return;
                }
                _commandArgs = value;
                this.OnCommandArgsChanged();
            }
        }
        
        #endregion
        
        #region Property WorkingDir
        
        private string _workingDir;
        
        public event EventHandler WorkingDirChanged;
        
        protected virtual void OnWorkingDirChanged()
        {
            EventHandler handler = WorkingDirChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WorkingDir");
        }
        
        public virtual string WorkingDir
        {
            get { return _workingDir; }
            set
            {
                if (string.Equals(value, _workingDir))
                {
                    return;
                }
                _workingDir = value;
                this.OnWorkingDirChanged();
            }
        }
        
        #endregion
    }
    
    public partial class ScreenPattern : IEquatable<ScreenPattern>, INotifyPropertyChanged
    {
        public ScreenPattern()
        {
            this._name = DEF_NAME;
        }
        
        #region Equatability
        
        public bool Equals(ScreenPattern o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(ScreenPattern)))
            {
                return false;
            }
            return this.Equals((ScreenPattern)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"Screen";
        
        [DefaultValue(DEF_NAME)]
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.Equals(value, _name))
                {
                    return;
                }
                _name = value;
                this.OnNameChanged();
            }
        }
        
        #endregion
        
        #region Property Bounds
        
        private Rect _bounds;
        
        public event EventHandler BoundsChanged;
        
        protected virtual void OnBoundsChanged()
        {
            EventHandler handler = BoundsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Bounds");
        }
        
        public virtual Rect Bounds
        {
            get { return _bounds; }
            set
            {
                if ((value == _bounds))
                {
                    return;
                }
                _bounds = value;
                this.OnBoundsChanged();
            }
        }
        
        #endregion
        
        #region Property DeviceName
        
        private string _deviceName;
        
        public event EventHandler DeviceNameChanged;
        
        protected virtual void OnDeviceNameChanged()
        {
            EventHandler handler = DeviceNameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"DeviceName");
        }
        
        public virtual string DeviceName
        {
            get { return _deviceName; }
            set
            {
                if (string.Equals(value, _deviceName))
                {
                    return;
                }
                _deviceName = value;
                this.OnDeviceNameChanged();
            }
        }
        
        #endregion
    }
    
    public partial class ConfigurationPattern : IEquatable<ConfigurationPattern>, INotifyPropertyChanged
    {
        public ConfigurationPattern()
        {
            this._name = DEF_NAME;
            this._virtualDesktopCount = DEF_VIRTUALDESKTOPCOUNT;
            this._respectVirtualDesktopCount = DEF_RESPECTVIRTUALDESKTOPCOUNT;
        }
        
        #region Equatability
        
        public bool Equals(ConfigurationPattern o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(ConfigurationPattern)))
            {
                return false;
            }
            return this.Equals((ConfigurationPattern)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"Configuration";
        
        [DefaultValue(DEF_NAME)]
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.Equals(value, _name))
                {
                    return;
                }
                _name = value;
                this.OnNameChanged();
            }
        }
        
        #endregion
        
        #region Property Screens
        
        private BindingList<ScreenPattern> _screens;
        
        public event EventHandler ScreensChanged;
        
        protected virtual void OnScreensChanged()
        {
            EventHandler handler = ScreensChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Screens");
        }
        
        public virtual BindingList<ScreenPattern> Screens
        {
            get { return _screens; }
            set
            {
                if ((value == _screens))
                {
                    return;
                }
                _screens = value;
                this.OnScreensChanged();
            }
        }
        
        #endregion
        
        #region Property VirtualDesktopCount
        
        private int _virtualDesktopCount;
        
        public event EventHandler VirtualDesktopCountChanged;
        
        protected virtual void OnVirtualDesktopCountChanged()
        {
            EventHandler handler = VirtualDesktopCountChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"VirtualDesktopCount");
        }
        
        private const int DEF_VIRTUALDESKTOPCOUNT = 1;
        
        [DefaultValue(DEF_VIRTUALDESKTOPCOUNT)]
        public virtual int VirtualDesktopCount
        {
            get { return _virtualDesktopCount; }
            set
            {
                if ((value == _virtualDesktopCount))
                {
                    return;
                }
                _virtualDesktopCount = value;
                this.OnVirtualDesktopCountChanged();
            }
        }
        
        #endregion
        
        #region Property RespectVirtualDesktopCount
        
        private bool _respectVirtualDesktopCount;
        
        public event EventHandler RespectVirtualDesktopCountChanged;
        
        protected virtual void OnRespectVirtualDesktopCountChanged()
        {
            EventHandler handler = RespectVirtualDesktopCountChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RespectVirtualDesktopCount");
        }
        
        private const bool DEF_RESPECTVIRTUALDESKTOPCOUNT = false;
        
        [DefaultValue(DEF_RESPECTVIRTUALDESKTOPCOUNT)]
        public virtual bool RespectVirtualDesktopCount
        {
            get { return _respectVirtualDesktopCount; }
            set
            {
                if ((value == _respectVirtualDesktopCount))
                {
                    return;
                }
                _respectVirtualDesktopCount = value;
                this.OnRespectVirtualDesktopCountChanged();
            }
        }
        
        #endregion
    }
    
    public partial class WindowAction : IEquatable<WindowAction>, INotifyPropertyChanged
    {
        public WindowAction()
        {
            this._virtualDesktop = DEF_VIRTUALDESKTOP;
            this._windowState = DEF_WINDOWSTATE;
            this._left = DEF_LEFT;
            this._leftUnit = DEF_LEFTUNIT;
            this._top = DEF_TOP;
            this._topUnit = DEF_TOPUNIT;
            this._right = DEF_RIGHT;
            this._rightUnit = DEF_RIGHTUNIT;
            this._bottom = DEF_BOTTOM;
            this._bottomUnit = DEF_BOTTOMUNIT;
            this._compensateOsMargin = DEF_COMPENSATEOSMARGIN;
        }
        
        #region Equatability
        
        public bool Equals(WindowAction o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(WindowAction)))
            {
                return false;
            }
            return this.Equals((WindowAction)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property Window
        
        private string _window;
        
        public event EventHandler WindowChanged;
        
        protected virtual void OnWindowChanged()
        {
            EventHandler handler = WindowChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Window");
        }
        
        public virtual string Window
        {
            get { return _window; }
            set
            {
                if (string.Equals(value, _window))
                {
                    return;
                }
                _window = value;
                this.OnWindowChanged();
            }
        }
        
        #endregion
        
        #region Property Restore
        
        private bool _restore;
        
        public event EventHandler RestoreChanged;
        
        protected virtual void OnRestoreChanged()
        {
            EventHandler handler = RestoreChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Restore");
        }
        
        public virtual bool Restore
        {
            get { return _restore; }
            set
            {
                if ((value == _restore))
                {
                    return;
                }
                _restore = value;
                this.OnRestoreChanged();
            }
        }
        
        #endregion
        
        #region Property VirtualDesktop
        
        private int _virtualDesktop;
        
        public event EventHandler VirtualDesktopChanged;
        
        protected virtual void OnVirtualDesktopChanged()
        {
            EventHandler handler = VirtualDesktopChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"VirtualDesktop");
        }
        
        private const int DEF_VIRTUALDESKTOP = 1;
        
        [DefaultValue(DEF_VIRTUALDESKTOP)]
        public virtual int VirtualDesktop
        {
            get { return _virtualDesktop; }
            set
            {
                if ((value == _virtualDesktop))
                {
                    return;
                }
                _virtualDesktop = value;
                this.OnVirtualDesktopChanged();
            }
        }
        
        #endregion
        
        #region Property Screen
        
        private string _screen;
        
        public event EventHandler ScreenChanged;
        
        protected virtual void OnScreenChanged()
        {
            EventHandler handler = ScreenChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Screen");
        }
        
        public virtual string Screen
        {
            get { return _screen; }
            set
            {
                if (string.Equals(value, _screen))
                {
                    return;
                }
                _screen = value;
                this.OnScreenChanged();
            }
        }
        
        #endregion
        
        #region Property WindowState
        
        private WindowState _windowState;
        
        public event EventHandler WindowStateChanged;
        
        protected virtual void OnWindowStateChanged()
        {
            EventHandler handler = WindowStateChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowState");
        }
        
        private const WindowState DEF_WINDOWSTATE = WindowState.Normal;
        
        [DefaultValue(DEF_WINDOWSTATE)]
        public virtual WindowState WindowState
        {
            get { return _windowState; }
            set
            {
                if ((value == _windowState))
                {
                    return;
                }
                _windowState = value;
                this.OnWindowStateChanged();
            }
        }
        
        #endregion
        
        #region Property Left
        
        private int _left;
        
        public event EventHandler LeftChanged;
        
        protected virtual void OnLeftChanged()
        {
            EventHandler handler = LeftChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Left");
        }
        
        private const int DEF_LEFT = 20;
        
        [DefaultValue(DEF_LEFT)]
        public virtual int Left
        {
            get { return _left; }
            set
            {
                if ((value == _left))
                {
                    return;
                }
                _left = value;
                this.OnLeftChanged();
            }
        }
        
        #endregion
        
        #region Property LeftUnit
        
        private ScreenUnit _leftUnit;
        
        public event EventHandler LeftUnitChanged;
        
        protected virtual void OnLeftUnitChanged()
        {
            EventHandler handler = LeftUnitChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"LeftUnit");
        }
        
        private const ScreenUnit DEF_LEFTUNIT = ScreenUnit.Percent;
        
        [DefaultValue(DEF_LEFTUNIT)]
        public virtual ScreenUnit LeftUnit
        {
            get { return _leftUnit; }
            set
            {
                if ((value == _leftUnit))
                {
                    return;
                }
                _leftUnit = value;
                this.OnLeftUnitChanged();
            }
        }
        
        #endregion
        
        #region Property LeftInvert
        
        private bool _leftInvert;
        
        public event EventHandler LeftInvertChanged;
        
        protected virtual void OnLeftInvertChanged()
        {
            EventHandler handler = LeftInvertChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"LeftInvert");
        }
        
        public virtual bool LeftInvert
        {
            get { return _leftInvert; }
            set
            {
                if ((value == _leftInvert))
                {
                    return;
                }
                _leftInvert = value;
                this.OnLeftInvertChanged();
            }
        }
        
        #endregion
        
        #region Property Top
        
        private int _top;
        
        public event EventHandler TopChanged;
        
        protected virtual void OnTopChanged()
        {
            EventHandler handler = TopChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Top");
        }
        
        private const int DEF_TOP = 20;
        
        [DefaultValue(DEF_TOP)]
        public virtual int Top
        {
            get { return _top; }
            set
            {
                if ((value == _top))
                {
                    return;
                }
                _top = value;
                this.OnTopChanged();
            }
        }
        
        #endregion
        
        #region Property TopUnit
        
        private ScreenUnit _topUnit;
        
        public event EventHandler TopUnitChanged;
        
        protected virtual void OnTopUnitChanged()
        {
            EventHandler handler = TopUnitChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"TopUnit");
        }
        
        private const ScreenUnit DEF_TOPUNIT = ScreenUnit.Percent;
        
        [DefaultValue(DEF_TOPUNIT)]
        public virtual ScreenUnit TopUnit
        {
            get { return _topUnit; }
            set
            {
                if ((value == _topUnit))
                {
                    return;
                }
                _topUnit = value;
                this.OnTopUnitChanged();
            }
        }
        
        #endregion
        
        #region Property TopInvert
        
        private bool _topInvert;
        
        public event EventHandler TopInvertChanged;
        
        protected virtual void OnTopInvertChanged()
        {
            EventHandler handler = TopInvertChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"TopInvert");
        }
        
        public virtual bool TopInvert
        {
            get { return _topInvert; }
            set
            {
                if ((value == _topInvert))
                {
                    return;
                }
                _topInvert = value;
                this.OnTopInvertChanged();
            }
        }
        
        #endregion
        
        #region Property Right
        
        private int _right;
        
        public event EventHandler RightChanged;
        
        protected virtual void OnRightChanged()
        {
            EventHandler handler = RightChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Right");
        }
        
        private const int DEF_RIGHT = 80;
        
        [DefaultValue(DEF_RIGHT)]
        public virtual int Right
        {
            get { return _right; }
            set
            {
                if ((value == _right))
                {
                    return;
                }
                _right = value;
                this.OnRightChanged();
            }
        }
        
        #endregion
        
        #region Property RightUnit
        
        private ScreenUnit _rightUnit;
        
        public event EventHandler RightUnitChanged;
        
        protected virtual void OnRightUnitChanged()
        {
            EventHandler handler = RightUnitChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RightUnit");
        }
        
        private const ScreenUnit DEF_RIGHTUNIT = ScreenUnit.Percent;
        
        [DefaultValue(DEF_RIGHTUNIT)]
        public virtual ScreenUnit RightUnit
        {
            get { return _rightUnit; }
            set
            {
                if ((value == _rightUnit))
                {
                    return;
                }
                _rightUnit = value;
                this.OnRightUnitChanged();
            }
        }
        
        #endregion
        
        #region Property RightInvert
        
        private bool _rightInvert;
        
        public event EventHandler RightInvertChanged;
        
        protected virtual void OnRightInvertChanged()
        {
            EventHandler handler = RightInvertChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RightInvert");
        }
        
        public virtual bool RightInvert
        {
            get { return _rightInvert; }
            set
            {
                if ((value == _rightInvert))
                {
                    return;
                }
                _rightInvert = value;
                this.OnRightInvertChanged();
            }
        }
        
        #endregion
        
        #region Property Bottom
        
        private int _bottom;
        
        public event EventHandler BottomChanged;
        
        protected virtual void OnBottomChanged()
        {
            EventHandler handler = BottomChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Bottom");
        }
        
        private const int DEF_BOTTOM = 80;
        
        [DefaultValue(DEF_BOTTOM)]
        public virtual int Bottom
        {
            get { return _bottom; }
            set
            {
                if ((value == _bottom))
                {
                    return;
                }
                _bottom = value;
                this.OnBottomChanged();
            }
        }
        
        #endregion
        
        #region Property BottomUnit
        
        private ScreenUnit _bottomUnit;
        
        public event EventHandler BottomUnitChanged;
        
        protected virtual void OnBottomUnitChanged()
        {
            EventHandler handler = BottomUnitChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"BottomUnit");
        }
        
        private const ScreenUnit DEF_BOTTOMUNIT = ScreenUnit.Percent;
        
        [DefaultValue(DEF_BOTTOMUNIT)]
        public virtual ScreenUnit BottomUnit
        {
            get { return _bottomUnit; }
            set
            {
                if ((value == _bottomUnit))
                {
                    return;
                }
                _bottomUnit = value;
                this.OnBottomUnitChanged();
            }
        }
        
        #endregion
        
        #region Property BottomInvert
        
        private bool _bottomInvert;
        
        public event EventHandler BottomInvertChanged;
        
        protected virtual void OnBottomInvertChanged()
        {
            EventHandler handler = BottomInvertChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"BottomInvert");
        }
        
        public virtual bool BottomInvert
        {
            get { return _bottomInvert; }
            set
            {
                if ((value == _bottomInvert))
                {
                    return;
                }
                _bottomInvert = value;
                this.OnBottomInvertChanged();
            }
        }
        
        #endregion
        
        #region Property CompensateOsMargin
        
        private bool _compensateOsMargin;
        
        public event EventHandler CompensateOsMarginChanged;
        
        protected virtual void OnCompensateOsMarginChanged()
        {
            EventHandler handler = CompensateOsMarginChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"CompensateOsMargin");
        }
        
        private const bool DEF_COMPENSATEOSMARGIN = true;
        
        [DefaultValue(DEF_COMPENSATEOSMARGIN)]
        public virtual bool CompensateOsMargin
        {
            get { return _compensateOsMargin; }
            set
            {
                if ((value == _compensateOsMargin))
                {
                    return;
                }
                _compensateOsMargin = value;
                this.OnCompensateOsMarginChanged();
            }
        }
        
        #endregion
    }
    
    public partial class Layout : IEquatable<Layout>, INotifyPropertyChanged
    {
        public Layout()
        {
            this._name = DEF_NAME;
            this._defaultLayout = DEF_DEFAULTLAYOUT;
        }
        
        #region Equatability
        
        public bool Equals(Layout o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(Layout)))
            {
                return false;
            }
            return this.Equals((Layout)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"Layout";
        
        [DefaultValue(DEF_NAME)]
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.Equals(value, _name))
                {
                    return;
                }
                _name = value;
                this.OnNameChanged();
            }
        }
        
        #endregion
        
        #region Property DefaultLayout
        
        private bool _defaultLayout;
        
        public event EventHandler DefaultLayoutChanged;
        
        protected virtual void OnDefaultLayoutChanged()
        {
            EventHandler handler = DefaultLayoutChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"DefaultLayout");
        }
        
        private const bool DEF_DEFAULTLAYOUT = true;
        
        [DefaultValue(DEF_DEFAULTLAYOUT)]
        public virtual bool DefaultLayout
        {
            get { return _defaultLayout; }
            set
            {
                if ((value == _defaultLayout))
                {
                    return;
                }
                _defaultLayout = value;
                this.OnDefaultLayoutChanged();
            }
        }
        
        #endregion
        
        #region Property Configuration
        
        private string _configuration;
        
        public event EventHandler ConfigurationChanged;
        
        protected virtual void OnConfigurationChanged()
        {
            EventHandler handler = ConfigurationChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Configuration");
        }
        
        public virtual string Configuration
        {
            get { return _configuration; }
            set
            {
                if (string.Equals(value, _configuration))
                {
                    return;
                }
                _configuration = value;
                this.OnConfigurationChanged();
            }
        }
        
        #endregion
        
        #region Property Windows
        
        private BindingList<WindowAction> _windows;
        
        public event EventHandler WindowsChanged;
        
        protected virtual void OnWindowsChanged()
        {
            EventHandler handler = WindowsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Windows");
        }
        
        public virtual BindingList<WindowAction> Windows
        {
            get { return _windows; }
            set
            {
                if ((value == _windows))
                {
                    return;
                }
                _windows = value;
                this.OnWindowsChanged();
            }
        }
        
        #endregion
    }
    
    public partial class Workspace : IEquatable<Workspace>, INotifyPropertyChanged
    {
        public Workspace()
        {
        }
        
        #region Equatability
        
        public bool Equals(Workspace o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(Workspace)))
            {
                return false;
            }
            return this.Equals((Workspace)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property WindowPatterns
        
        private BindingList<WindowPattern> _windowPatterns;
        
        public event EventHandler WindowPatternsChanged;
        
        protected virtual void OnWindowPatternsChanged()
        {
            EventHandler handler = WindowPatternsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowPatterns");
        }
        
        public virtual BindingList<WindowPattern> WindowPatterns
        {
            get { return _windowPatterns; }
            set
            {
                if ((value == _windowPatterns))
                {
                    return;
                }
                _windowPatterns = value;
                this.OnWindowPatternsChanged();
            }
        }
        
        #endregion
        
        #region Property ConfigurationPatterns
        
        private BindingList<ConfigurationPattern> _configurationPatterns;
        
        public event EventHandler ConfigurationPatternsChanged;
        
        protected virtual void OnConfigurationPatternsChanged()
        {
            EventHandler handler = ConfigurationPatternsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ConfigurationPatterns");
        }
        
        public virtual BindingList<ConfigurationPattern> ConfigurationPatterns
        {
            get { return _configurationPatterns; }
            set
            {
                if ((value == _configurationPatterns))
                {
                    return;
                }
                _configurationPatterns = value;
                this.OnConfigurationPatternsChanged();
            }
        }
        
        #endregion
        
        #region Property Layouts
        
        private BindingList<Layout> _layouts;
        
        public event EventHandler LayoutsChanged;
        
        protected virtual void OnLayoutsChanged()
        {
            EventHandler handler = LayoutsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Layouts");
        }
        
        public virtual BindingList<Layout> Layouts
        {
            get { return _layouts; }
            set
            {
                if ((value == _layouts))
                {
                    return;
                }
                _layouts = value;
                this.OnLayoutsChanged();
            }
        }
        
        #endregion
    }
    
    public partial class Core : IEquatable<Core>, INotifyPropertyChanged
    {
        public Core()
        {
            this._windowWrappers = new WindowWrapper[0];
        }
        
        #region Equatability
        
        public bool Equals(Core o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return object.ReferenceEquals(this, o);
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(Core)))
            {
                return false;
            }
            return this.Equals((Core)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Change Tracking
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        
        #endregion
        
        #region Property Workspace
        
        private Workspace _workspace;
        
        public event EventHandler WorkspaceChanged;
        
        protected virtual void OnWorkspaceChanged()
        {
            EventHandler handler = WorkspaceChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Workspace");
        }
        
        public virtual Workspace Workspace
        {
            get { return _workspace; }
            set
            {
                if ((value == _workspace))
                {
                    return;
                }
                _workspace = value;
                this.OnWorkspaceChanged();
            }
        }
        
        #endregion
        
        #region Property WindowWrappers
        
        private WindowWrapper[] _windowWrappers;
        
        public event EventHandler WindowWrappersChanged;
        
        protected virtual void OnWindowWrappersChanged()
        {
            EventHandler handler = WindowWrappersChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowWrappers");
        }
        
        public virtual WindowWrapper[] WindowWrappers
        {
            get { return _windowWrappers; }
            set
            {
                if ((value == _windowWrappers))
                {
                    return;
                }
                _windowWrappers = value;
                this.OnWindowWrappersChanged();
            }
        }
        
        #endregion
        
        #region Property WorkspaceFileName
        
        private string _workspaceFileName;
        
        public event EventHandler WorkspaceFileNameChanged;
        
        protected virtual void OnWorkspaceFileNameChanged()
        {
            EventHandler handler = WorkspaceFileNameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WorkspaceFileName");
        }
        
        public virtual string WorkspaceFileName
        {
            get { return _workspaceFileName; }
            set
            {
                if (string.Equals(value, _workspaceFileName))
                {
                    return;
                }
                _workspaceFileName = value;
                this.OnWorkspaceFileNameChanged();
            }
        }
        
        #endregion
    }
    
    #endregion
}