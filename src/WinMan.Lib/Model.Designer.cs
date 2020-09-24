using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Globalization;

namespace Mastersign.WinMan
{
    #region Scaleton Model Designer generated code
    
    // Scaleton Version: 0.3.0
    
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
    
    public partial class Margin : IEquatable<Margin>
    {
        public Margin()
        {
        }
        
        public Margin(int left, int top, int right, int bottom)
        {
            this._left = left;
            this._top = top;
            this._right = right;
            this._bottom = bottom;
        }
        
        #region Equatability
        
        public bool Equals(Margin o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return (
                (this._left == o._left) && 
                (this._top == o._top) && 
                (this._right == o._right) && 
                (this._bottom == o._bottom));
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(Margin)))
            {
                return false;
            }
            return this.Equals((Margin)o);
        }
        
        public static bool operator ==(Margin a, Margin b)
        {
            if ((ReferenceEquals(a, null) && ReferenceEquals(b, null)))
            {
                return true;
            }
            if ((ReferenceEquals(a, null) || ReferenceEquals(b, null)))
            {
                return false;
            }
            return a.Equals(b);
        }
        
        public static bool operator !=(Margin a, Margin b)
        {
            return !(a == b);
        }
        
        public override int GetHashCode()
        {
            return (this.GetType().GetHashCode() ^ 
                this._left.GetHashCode() ^ 
                this._top.GetHashCode() ^ 
                this._right.GetHashCode() ^ 
                this._bottom.GetHashCode());
        }
        
        #endregion
        
        #region Property Left
        
        private int _left;
        
        public virtual int Left
        {
            get { return _left; }
        }
        
        #endregion
        
        #region Property Top
        
        private int _top;
        
        public virtual int Top
        {
            get { return _top; }
        }
        
        #endregion
        
        #region Property Right
        
        private int _right;
        
        public virtual int Right
        {
            get { return _right; }
        }
        
        #endregion
        
        #region Property Bottom
        
        private int _bottom;
        
        public virtual int Bottom
        {
            get { return _bottom; }
        }
        
        #endregion
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
        
        public static bool operator ==(Rect a, Rect b)
        {
            if ((ReferenceEquals(a, null) && ReferenceEquals(b, null)))
            {
                return true;
            }
            if ((ReferenceEquals(a, null) || ReferenceEquals(b, null)))
            {
                return false;
            }
            return a.Equals(b);
        }
        
        public static bool operator !=(Rect a, Rect b)
        {
            return !(a == b);
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
    
    public partial class WindowPattern : IEquatable<WindowPattern>, INotifyPropertyChanged, IChangeTracking
    {
        public WindowPattern()
        {
            this._name = DEF_NAME;
            this._titlePatternType = DEF_TITLEPATTERNTYPE;
            this._windowClassPatternType = DEF_WINDOWCLASSPATTERNTYPE;
            this._restorationTimeout = DEF_RESTORATIONTIMEOUT;
            
            this.IsChanged = false;
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            this.IsChanged = true;
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"New Window Pattern";
        
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
        
        #region Property OverrideRestorationTimeout
        
        private bool _overrideRestorationTimeout;
        
        public event EventHandler OverrideRestorationTimeoutChanged;
        
        protected virtual void OnOverrideRestorationTimeoutChanged()
        {
            this.IsChanged = true;
            EventHandler handler = OverrideRestorationTimeoutChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"OverrideRestorationTimeout");
        }
        
        public virtual bool OverrideRestorationTimeout
        {
            get { return _overrideRestorationTimeout; }
            set
            {
                if ((value == _overrideRestorationTimeout))
                {
                    return;
                }
                _overrideRestorationTimeout = value;
                this.OnOverrideRestorationTimeoutChanged();
            }
        }
        
        #endregion
        
        #region Property RestorationTimeout
        
        private int _restorationTimeout;
        
        public event EventHandler RestorationTimeoutChanged;
        
        protected virtual void OnRestorationTimeoutChanged()
        {
            this.IsChanged = true;
            EventHandler handler = RestorationTimeoutChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RestorationTimeout");
        }
        
        private const int DEF_RESTORATIONTIMEOUT = 30;
        
        [DefaultValue(DEF_RESTORATIONTIMEOUT)]
        public virtual int RestorationTimeout
        {
            get { return _restorationTimeout; }
            set
            {
                if ((value == _restorationTimeout))
                {
                    return;
                }
                _restorationTimeout = value;
                this.OnRestorationTimeoutChanged();
            }
        }
        
        #endregion
        
        #region Property ModernApp
        
        private bool _modernApp;
        
        public event EventHandler ModernAppChanged;
        
        protected virtual void OnModernAppChanged()
        {
            this.IsChanged = true;
            EventHandler handler = ModernAppChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ModernApp");
        }
        
        public virtual bool ModernApp
        {
            get { return _modernApp; }
            set
            {
                if ((value == _modernApp))
                {
                    return;
                }
                _modernApp = value;
                this.OnModernAppChanged();
            }
        }
        
        #endregion
        
        #region Property Command
        
        private string _command;
        
        public event EventHandler CommandChanged;
        
        protected virtual void OnCommandChanged()
        {
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
        
        #region Property AppId
        
        private string _appId;
        
        public event EventHandler AppIdChanged;
        
        protected virtual void OnAppIdChanged()
        {
            this.IsChanged = true;
            EventHandler handler = AppIdChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"AppId");
        }
        
        public virtual string AppId
        {
            get { return _appId; }
            set
            {
                if (string.Equals(value, _appId))
                {
                    return;
                }
                _appId = value;
                this.OnAppIdChanged();
            }
        }
        
        #endregion
    }
    
    public partial class ScreenPattern : IEquatable<ScreenPattern>, INotifyPropertyChanged, IChangeTracking
    {
        public ScreenPattern()
        {
            this._name = DEF_NAME;
            this._respectPosition = DEF_RESPECTPOSITION;
            this._respectSize = DEF_RESPECTSIZE;
            this.Initialize();
            
            this.IsChanged = false;
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
        
        #region Property RespectPosition
        
        private bool _respectPosition;
        
        public event EventHandler RespectPositionChanged;
        
        protected virtual void OnRespectPositionChanged()
        {
            this.IsChanged = true;
            EventHandler handler = RespectPositionChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RespectPosition");
        }
        
        private const bool DEF_RESPECTPOSITION = true;
        
        [DefaultValue(DEF_RESPECTPOSITION)]
        public virtual bool RespectPosition
        {
            get { return _respectPosition; }
            set
            {
                if ((value == _respectPosition))
                {
                    return;
                }
                _respectPosition = value;
                this.OnRespectPositionChanged();
            }
        }
        
        #endregion
        
        #region Property RespectSize
        
        private bool _respectSize;
        
        public event EventHandler RespectSizeChanged;
        
        protected virtual void OnRespectSizeChanged()
        {
            this.IsChanged = true;
            EventHandler handler = RespectSizeChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RespectSize");
        }
        
        private const bool DEF_RESPECTSIZE = true;
        
        [DefaultValue(DEF_RESPECTSIZE)]
        public virtual bool RespectSize
        {
            get { return _respectSize; }
            set
            {
                if ((value == _respectSize))
                {
                    return;
                }
                _respectSize = value;
                this.OnRespectSizeChanged();
            }
        }
        
        #endregion
    }
    
    public partial class ConfigurationPattern : IEquatable<ConfigurationPattern>, INotifyPropertyChanged, IChangeTracking
    {
        public ConfigurationPattern()
        {
            this._name = DEF_NAME;
            this._screens = new BindingList<ScreenPattern>();
            this._virtualDesktopCount = DEF_VIRTUALDESKTOPCOUNT;
            this._respectVirtualDesktopCount = DEF_RESPECTVIRTUALDESKTOPCOUNT;
            
            this.IsChanged = false;
        }
        
        [OnDeserialized]
        internal void AfterDeserializingConfigurationPattern(StreamingContext serializationContext)
        {
            if (!ReferenceEquals(_screens, null))
            {
                _screens.ListChanged += this.ScreensListChangedHandler;
            }
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            if (!ReferenceEquals(_screens, null))
            {
                foreach (ScreenPattern item in _screens)
                {
                    if (!ReferenceEquals(item, null))
                    {
                        item.AcceptChanges();
                    }
                }
            }
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            this.IsChanged = true;
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"New Configuration Pattern";
        
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
            this.IsChanged = true;
            EventHandler handler = ScreensChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Screens");
        }
        
        private void ScreensListChangedHandler(object sender, ListChangedEventArgs ea)
        {
            this.OnScreensChanged();
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
                if (!ReferenceEquals(_screens, null))
                {
                    _screens.ListChanged -= this.ScreensListChangedHandler;
                }
                _screens = value;
                if (!ReferenceEquals(_screens, null))
                {
                    _screens.ListChanged += this.ScreensListChangedHandler;
                }
                this.OnScreensChanged();
            }
        }
        
        #endregion
        
        #region Property VirtualDesktopCount
        
        private int _virtualDesktopCount;
        
        public event EventHandler VirtualDesktopCountChanged;
        
        protected virtual void OnVirtualDesktopCountChanged()
        {
            this.IsChanged = true;
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
            this.IsChanged = true;
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
    
    public partial class WindowAction : IEquatable<WindowAction>, INotifyPropertyChanged, IChangeTracking
    {
        public WindowAction()
        {
            this._window = DEF_WINDOW;
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
            
            this.IsChanged = false;
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Window
        
        private string _window;
        
        public event EventHandler WindowChanged;
        
        protected virtual void OnWindowChanged()
        {
            this.IsChanged = true;
            EventHandler handler = WindowChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Window");
        }
        
        private const string DEF_WINDOW = @"Not Set";
        
        [DefaultValue(DEF_WINDOW)]
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
            this.IsChanged = true;
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
        
        #region Property OverrideVirtualDesktop
        
        private bool _overrideVirtualDesktop;
        
        public event EventHandler OverrideVirtualDesktopChanged;
        
        protected virtual void OnOverrideVirtualDesktopChanged()
        {
            this.IsChanged = true;
            EventHandler handler = OverrideVirtualDesktopChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"OverrideVirtualDesktop");
        }
        
        public virtual bool OverrideVirtualDesktop
        {
            get { return _overrideVirtualDesktop; }
            set
            {
                if ((value == _overrideVirtualDesktop))
                {
                    return;
                }
                _overrideVirtualDesktop = value;
                this.OnOverrideVirtualDesktopChanged();
            }
        }
        
        #endregion
        
        #region Property VirtualDesktop
        
        private int _virtualDesktop;
        
        public event EventHandler VirtualDesktopChanged;
        
        protected virtual void OnVirtualDesktopChanged()
        {
            this.IsChanged = true;
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
        
        #region Property AllVirtualDesktops
        
        private bool _allVirtualDesktops;
        
        public event EventHandler AllVirtualDesktopsChanged;
        
        protected virtual void OnAllVirtualDesktopsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = AllVirtualDesktopsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"AllVirtualDesktops");
        }
        
        public virtual bool AllVirtualDesktops
        {
            get { return _allVirtualDesktops; }
            set
            {
                if ((value == _allVirtualDesktops))
                {
                    return;
                }
                _allVirtualDesktops = value;
                this.OnAllVirtualDesktopsChanged();
            }
        }
        
        #endregion
        
        #region Property Screen
        
        private string _screen;
        
        public event EventHandler ScreenChanged;
        
        protected virtual void OnScreenChanged()
        {
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
    
    public partial class Layout : IEquatable<Layout>, INotifyPropertyChanged, IChangeTracking
    {
        public Layout()
        {
            this._name = DEF_NAME;
            this._defaultLayout = DEF_DEFAULTLAYOUT;
            this._defaultVirtualDesktop = DEF_DEFAULTVIRTUALDESKTOP;
            this._createShortcut = DEF_CREATESHORTCUT;
            this._windows = new BindingList<WindowAction>();
            
            this.IsChanged = false;
        }
        
        [OnDeserialized]
        internal void AfterDeserializingLayout(StreamingContext serializationContext)
        {
            if (!ReferenceEquals(_windows, null))
            {
                _windows.ListChanged += this.WindowsListChangedHandler;
            }
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            if (!ReferenceEquals(_windows, null))
            {
                foreach (WindowAction item in _windows)
                {
                    if (!ReferenceEquals(item, null))
                    {
                        item.AcceptChanges();
                    }
                }
            }
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Name
        
        private string _name;
        
        public event EventHandler NameChanged;
        
        protected virtual void OnNameChanged()
        {
            this.IsChanged = true;
            EventHandler handler = NameChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Name");
        }
        
        private const string DEF_NAME = @"New Layout";
        
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
            this.IsChanged = true;
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
            this.IsChanged = true;
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
        
        #region Property DefaultVirtualDesktop
        
        private int _defaultVirtualDesktop;
        
        public event EventHandler DefaultVirtualDesktopChanged;
        
        protected virtual void OnDefaultVirtualDesktopChanged()
        {
            this.IsChanged = true;
            EventHandler handler = DefaultVirtualDesktopChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"DefaultVirtualDesktop");
        }
        
        private const int DEF_DEFAULTVIRTUALDESKTOP = 1;
        
        [DefaultValue(DEF_DEFAULTVIRTUALDESKTOP)]
        public virtual int DefaultVirtualDesktop
        {
            get { return _defaultVirtualDesktop; }
            set
            {
                if ((value == _defaultVirtualDesktop))
                {
                    return;
                }
                _defaultVirtualDesktop = value;
                this.OnDefaultVirtualDesktopChanged();
            }
        }
        
        #endregion
        
        #region Property CreateShortcut
        
        private bool _createShortcut;
        
        public event EventHandler CreateShortcutChanged;
        
        protected virtual void OnCreateShortcutChanged()
        {
            this.IsChanged = true;
            EventHandler handler = CreateShortcutChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"CreateShortcut");
        }
        
        private const bool DEF_CREATESHORTCUT = true;
        
        [DefaultValue(DEF_CREATESHORTCUT)]
        public virtual bool CreateShortcut
        {
            get { return _createShortcut; }
            set
            {
                if ((value == _createShortcut))
                {
                    return;
                }
                _createShortcut = value;
                this.OnCreateShortcutChanged();
            }
        }
        
        #endregion
        
        #region Property Windows
        
        private BindingList<WindowAction> _windows;
        
        public event EventHandler WindowsChanged;
        
        protected virtual void OnWindowsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = WindowsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Windows");
        }
        
        private void WindowsListChangedHandler(object sender, ListChangedEventArgs ea)
        {
            this.OnWindowsChanged();
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
                if (!ReferenceEquals(_windows, null))
                {
                    _windows.ListChanged -= this.WindowsListChangedHandler;
                }
                _windows = value;
                if (!ReferenceEquals(_windows, null))
                {
                    _windows.ListChanged += this.WindowsListChangedHandler;
                }
                this.OnWindowsChanged();
            }
        }
        
        #endregion
    }
    
    public partial class Options : IEquatable<Options>, INotifyPropertyChanged, IChangeTracking
    {
        public Options()
        {
            this._restorationTimeout = DEF_RESTORATIONTIMEOUT;
            this._shortcutDirectory = DEF_SHORTCUTDIRECTORY;
            this._shortcutApplyTerm = DEF_SHORTCUTAPPLYTERM;
            this._shortcutKillTerm = DEF_SHORTCUTKILLTERM;
            
            this.IsChanged = false;
        }
        
        #region Equatability
        
        public bool Equals(Options o)
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
            if (!(o.GetType() == typeof(Options)))
            {
                return false;
            }
            return this.Equals((Options)o);
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property OsWindowMargin
        
        private Margin _osWindowMargin;
        
        public event EventHandler OsWindowMarginChanged;
        
        protected virtual void OnOsWindowMarginChanged()
        {
            this.IsChanged = true;
            EventHandler handler = OsWindowMarginChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"OsWindowMargin");
        }
        
        public virtual Margin OsWindowMargin
        {
            get { return _osWindowMargin; }
            set
            {
                if ((value == _osWindowMargin))
                {
                    return;
                }
                _osWindowMargin = value;
                this.OnOsWindowMarginChanged();
            }
        }
        
        #endregion
        
        #region Property RestorationTimeout
        
        private int _restorationTimeout;
        
        public event EventHandler RestorationTimeoutChanged;
        
        protected virtual void OnRestorationTimeoutChanged()
        {
            this.IsChanged = true;
            EventHandler handler = RestorationTimeoutChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"RestorationTimeout");
        }
        
        private const int DEF_RESTORATIONTIMEOUT = 30;
        
        [DefaultValue(DEF_RESTORATIONTIMEOUT)]
        public virtual int RestorationTimeout
        {
            get { return _restorationTimeout; }
            set
            {
                if ((value == _restorationTimeout))
                {
                    return;
                }
                _restorationTimeout = value;
                this.OnRestorationTimeoutChanged();
            }
        }
        
        #endregion
        
        #region Property ShortcutDirectory
        
        private string _shortcutDirectory;
        
        public event EventHandler ShortcutDirectoryChanged;
        
        protected virtual void OnShortcutDirectoryChanged()
        {
            this.IsChanged = true;
            EventHandler handler = ShortcutDirectoryChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ShortcutDirectory");
        }
        
        private const string DEF_SHORTCUTDIRECTORY = @"WinMan Layouts";
        
        [DefaultValue(DEF_SHORTCUTDIRECTORY)]
        public virtual string ShortcutDirectory
        {
            get { return _shortcutDirectory; }
            set
            {
                if (string.Equals(value, _shortcutDirectory))
                {
                    return;
                }
                _shortcutDirectory = value;
                this.OnShortcutDirectoryChanged();
            }
        }
        
        #endregion
        
        #region Property CreateShortcuts
        
        private bool _createShortcuts;
        
        public event EventHandler CreateShortcutsChanged;
        
        protected virtual void OnCreateShortcutsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = CreateShortcutsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"CreateShortcuts");
        }
        
        public virtual bool CreateShortcuts
        {
            get { return _createShortcuts; }
            set
            {
                if ((value == _createShortcuts))
                {
                    return;
                }
                _createShortcuts = value;
                this.OnCreateShortcutsChanged();
            }
        }
        
        #endregion
        
        #region Property CleanUpShortcuts
        
        private bool _cleanUpShortcuts;
        
        public event EventHandler CleanUpShortcutsChanged;
        
        protected virtual void OnCleanUpShortcutsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = CleanUpShortcutsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"CleanUpShortcuts");
        }
        
        public virtual bool CleanUpShortcuts
        {
            get { return _cleanUpShortcuts; }
            set
            {
                if ((value == _cleanUpShortcuts))
                {
                    return;
                }
                _cleanUpShortcuts = value;
                this.OnCleanUpShortcutsChanged();
            }
        }
        
        #endregion
        
        #region Property ShortcutApplyTerm
        
        private string _shortcutApplyTerm;
        
        public event EventHandler ShortcutApplyTermChanged;
        
        protected virtual void OnShortcutApplyTermChanged()
        {
            this.IsChanged = true;
            EventHandler handler = ShortcutApplyTermChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ShortcutApplyTerm");
        }
        
        private const string DEF_SHORTCUTAPPLYTERM = @"apply";
        
        [DefaultValue(DEF_SHORTCUTAPPLYTERM)]
        public virtual string ShortcutApplyTerm
        {
            get { return _shortcutApplyTerm; }
            set
            {
                if (string.Equals(value, _shortcutApplyTerm))
                {
                    return;
                }
                _shortcutApplyTerm = value;
                this.OnShortcutApplyTermChanged();
            }
        }
        
        #endregion
        
        #region Property ShortcutKillTerm
        
        private string _shortcutKillTerm;
        
        public event EventHandler ShortcutKillTermChanged;
        
        protected virtual void OnShortcutKillTermChanged()
        {
            this.IsChanged = true;
            EventHandler handler = ShortcutKillTermChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ShortcutKillTerm");
        }
        
        private const string DEF_SHORTCUTKILLTERM = @"kill";
        
        [DefaultValue(DEF_SHORTCUTKILLTERM)]
        public virtual string ShortcutKillTerm
        {
            get { return _shortcutKillTerm; }
            set
            {
                if (string.Equals(value, _shortcutKillTerm))
                {
                    return;
                }
                _shortcutKillTerm = value;
                this.OnShortcutKillTermChanged();
            }
        }
        
        #endregion
    }
    
    public partial class Workspace : IEquatable<Workspace>, INotifyPropertyChanged, IChangeTracking
    {
        public Workspace()
        {
            this._windowPatterns = new BindingList<WindowPattern>();
            this._configurationPatterns = new BindingList<ConfigurationPattern>();
            this._layouts = new BindingList<Layout>();
            
            this.IsChanged = false;
        }
        
        [OnDeserialized]
        internal void AfterDeserializingWorkspace(StreamingContext serializationContext)
        {
            if (!ReferenceEquals(_options, null))
            {
                _options.PropertyChanged += this.OptionsPropertyChangedHandler;
            }
            if (!ReferenceEquals(_windowPatterns, null))
            {
                _windowPatterns.ListChanged += this.WindowPatternsListChangedHandler;
            }
            if (!ReferenceEquals(_configurationPatterns, null))
            {
                _configurationPatterns.ListChanged += this.ConfigurationPatternsListChangedHandler;
            }
            if (!ReferenceEquals(_layouts, null))
            {
                _layouts.ListChanged += this.LayoutsListChangedHandler;
            }
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            if (!ReferenceEquals(_options, null))
            {
                _options.AcceptChanges();
            }
            if (!ReferenceEquals(_windowPatterns, null))
            {
                foreach (WindowPattern item in _windowPatterns)
                {
                    if (!ReferenceEquals(item, null))
                    {
                        item.AcceptChanges();
                    }
                }
            }
            if (!ReferenceEquals(_configurationPatterns, null))
            {
                foreach (ConfigurationPattern item in _configurationPatterns)
                {
                    if (!ReferenceEquals(item, null))
                    {
                        item.AcceptChanges();
                    }
                }
            }
            if (!ReferenceEquals(_layouts, null))
            {
                foreach (Layout item in _layouts)
                {
                    if (!ReferenceEquals(item, null))
                    {
                        item.AcceptChanges();
                    }
                }
            }
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Options
        
        private Options _options;
        
        public event EventHandler OptionsChanged;
        
        protected virtual void OnOptionsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = OptionsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Options");
        }
        
        private void OptionsPropertyChangedHandler(object sender, PropertyChangedEventArgs ea)
        {
            if (!string.Equals(ea.PropertyName, @"IsChanged"))
            {
                this.OnOptionsChanged();
            }
        }
        
        public virtual Options Options
        {
            get { return _options; }
            set
            {
                if ((value == _options))
                {
                    return;
                }
                if (!ReferenceEquals(_options, null))
                {
                    _options.PropertyChanged -= this.OptionsPropertyChangedHandler;
                }
                _options = value;
                if (!ReferenceEquals(_options, null))
                {
                    _options.PropertyChanged += this.OptionsPropertyChangedHandler;
                }
                this.OnOptionsChanged();
            }
        }
        
        #endregion
        
        #region Property WindowPatterns
        
        private BindingList<WindowPattern> _windowPatterns;
        
        public event EventHandler WindowPatternsChanged;
        
        protected virtual void OnWindowPatternsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = WindowPatternsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"WindowPatterns");
        }
        
        private void WindowPatternsListChangedHandler(object sender, ListChangedEventArgs ea)
        {
            this.OnWindowPatternsChanged();
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
                if (!ReferenceEquals(_windowPatterns, null))
                {
                    _windowPatterns.ListChanged -= this.WindowPatternsListChangedHandler;
                }
                _windowPatterns = value;
                if (!ReferenceEquals(_windowPatterns, null))
                {
                    _windowPatterns.ListChanged += this.WindowPatternsListChangedHandler;
                }
                this.OnWindowPatternsChanged();
            }
        }
        
        #endregion
        
        #region Property ConfigurationPatterns
        
        private BindingList<ConfigurationPattern> _configurationPatterns;
        
        public event EventHandler ConfigurationPatternsChanged;
        
        protected virtual void OnConfigurationPatternsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = ConfigurationPatternsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"ConfigurationPatterns");
        }
        
        private void ConfigurationPatternsListChangedHandler(object sender, ListChangedEventArgs ea)
        {
            this.OnConfigurationPatternsChanged();
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
                if (!ReferenceEquals(_configurationPatterns, null))
                {
                    _configurationPatterns.ListChanged -= this.ConfigurationPatternsListChangedHandler;
                }
                _configurationPatterns = value;
                if (!ReferenceEquals(_configurationPatterns, null))
                {
                    _configurationPatterns.ListChanged += this.ConfigurationPatternsListChangedHandler;
                }
                this.OnConfigurationPatternsChanged();
            }
        }
        
        #endregion
        
        #region Property Layouts
        
        private BindingList<Layout> _layouts;
        
        public event EventHandler LayoutsChanged;
        
        protected virtual void OnLayoutsChanged()
        {
            this.IsChanged = true;
            EventHandler handler = LayoutsChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Layouts");
        }
        
        private void LayoutsListChangedHandler(object sender, ListChangedEventArgs ea)
        {
            this.OnLayoutsChanged();
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
                if (!ReferenceEquals(_layouts, null))
                {
                    _layouts.ListChanged -= this.LayoutsListChangedHandler;
                }
                _layouts = value;
                if (!ReferenceEquals(_layouts, null))
                {
                    _layouts.ListChanged += this.LayoutsListChangedHandler;
                }
                this.OnLayoutsChanged();
            }
        }
        
        #endregion
    }
    
    public partial class Core : IEquatable<Core>, INotifyPropertyChanged, IChangeTracking
    {
        public Core()
        {
            this._windowWrappers = new WindowWrapper[0];
            
            this.IsChanged = false;
        }
        
        [OnDeserialized]
        internal void AfterDeserializingCore(StreamingContext serializationContext)
        {
            if (!ReferenceEquals(_workspace, null))
            {
                _workspace.PropertyChanged += this.WorkspacePropertyChangedHandler;
            }
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
        
        private bool _isChanged = false;
        
        [Browsable(false)]
        [XmlIgnore]
        public bool IsChanged
        {
            get { return this._isChanged; }
            protected set
            {
                if ((this._isChanged == value))
                {
                    return;
                }
                this._isChanged = value;
                this.OnPropertyChanged(@"IsChanged");
            }
        }
        
        public virtual void AcceptChanges()
        {
            if (!ReferenceEquals(_workspace, null))
            {
                _workspace.AcceptChanges();
            }
            this.IsChanged = false;
        }
        
        #endregion
        
        #region Property Workspace
        
        private Workspace _workspace;
        
        public event EventHandler WorkspaceChanged;
        
        protected virtual void OnWorkspaceChanged()
        {
            this.IsChanged = true;
            EventHandler handler = WorkspaceChanged;
            if (!ReferenceEquals(handler, null))
            {
                handler(this, EventArgs.Empty);
            }
            this.OnPropertyChanged(@"Workspace");
        }
        
        private void WorkspacePropertyChangedHandler(object sender, PropertyChangedEventArgs ea)
        {
            if (!string.Equals(ea.PropertyName, @"IsChanged"))
            {
                this.OnWorkspaceChanged();
            }
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
                if (!ReferenceEquals(_workspace, null))
                {
                    _workspace.PropertyChanged -= this.WorkspacePropertyChangedHandler;
                }
                _workspace = value;
                if (!ReferenceEquals(_workspace, null))
                {
                    _workspace.PropertyChanged += this.WorkspacePropertyChangedHandler;
                }
                this.OnWorkspaceChanged();
            }
        }
        
        #endregion
        
        #region Property WindowWrappers
        
        private WindowWrapper[] _windowWrappers;
        
        public event EventHandler WindowWrappersChanged;
        
        protected virtual void OnWindowWrappersChanged()
        {
            this.IsChanged = true;
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
            this.IsChanged = true;
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