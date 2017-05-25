using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mastersign.WinMan
{
    #region Scaleton Model Designer generated code
    
    public enum Positioning
    {
        Free,
        DockLeft,
        DockRight,
        DockTop,
        DockBottom,
        DockHeight,
        DockWidth,
        DockTopLeft,
        DockTopRight,
        DockBottomLeft,
        DockBottomRight,
    }
    
    public partial class WindowPattern : IEquatable<WindowPattern>
    {
        public WindowPattern()
        {
        }
        
        #region Equatability
        
        public bool Equals(WindowPattern o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return true;
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
        
        #region Property Name
        
        private string _name;
        
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.Equals(value, _name))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Command
        
        private string _command;
        
        public virtual string Command
        {
            get { return _command; }
            set
            {
                if (string.Equals(value, _command))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property CommandArgs
        
        private string _commandArgs;
        
        public virtual string CommandArgs
        {
            get { return _commandArgs; }
            set
            {
                if (string.Equals(value, _commandArgs))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Restore
        
        private bool _restore;
        
        public virtual bool Restore
        {
            get { return _restore; }
            set
            {
                if ((value == _restore))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property TitlePattern
        
        private string _titlePattern;
        
        public virtual string TitlePattern
        {
            get { return _titlePattern; }
            set
            {
                if (string.Equals(value, _titlePattern))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property IsTitleRegex
        
        private bool _isTitleRegex;
        
        public virtual bool IsTitleRegex
        {
            get { return _isTitleRegex; }
            set
            {
                if ((value == _isTitleRegex))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property WindowClassPattern
        
        private string _windowClassPattern;
        
        public virtual string WindowClassPattern
        {
            get { return _windowClassPattern; }
            set
            {
                if (string.Equals(value, _windowClassPattern))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property IsWindowClassRegex
        
        private bool _isWindowClassRegex;
        
        public virtual bool IsWindowClassRegex
        {
            get { return _isWindowClassRegex; }
            set
            {
                if ((value == _isWindowClassRegex))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property ProcessFileName
        
        private string _processFileName;
        
        public virtual string ProcessFileName
        {
            get { return _processFileName; }
            set
            {
                if (string.Equals(value, _processFileName))
                {
                    return;
                }
            }
        }
        
        #endregion
    }
    
    public partial class ScreenPattern : IEquatable<ScreenPattern>
    {
        public ScreenPattern()
        {
        }
        
        #region Equatability
        
        public bool Equals(ScreenPattern o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return true;
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
        
        #region Property Name
        
        private string _name;
        
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.Equals(value, _name))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Bounds
        
        private global::System.Drawing.Rectangle _bounds;
        
        public virtual global::System.Drawing.Rectangle Bounds
        {
            get { return _bounds; }
            set
            {
                if (value.Equals(_bounds))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property DeviceName
        
        private string _deviceName;
        
        public virtual string DeviceName
        {
            get { return _deviceName; }
            set
            {
                if (string.Equals(value, _deviceName))
                {
                    return;
                }
            }
        }
        
        #endregion
    }
    
    public partial class ConfigurationPattern : IEquatable<ConfigurationPattern>
    {
        public ConfigurationPattern()
        {
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
            return true;
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
        
        #region Property Screens
        
        private List<ScreenPattern> _screens;
        
        public virtual List<ScreenPattern> Screens
        {
            get { return _screens; }
            set
            {
                if ((value == _screens))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property VirtualDesktopCount
        
        private int _virtualDesktopCount;
        
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
            }
        }
        
        #endregion
        
        #region Property RespectVirtualDesktopCount
        
        private bool _respectVirtualDesktopCount;
        
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
            }
        }
        
        #endregion
    }
    
    public partial class WindowTarget : IEquatable<WindowTarget>
    {
        public WindowTarget()
        {
            this._positioning = DEF_POSITIONING;
        }
        
        #region Equatability
        
        public bool Equals(WindowTarget o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return true;
        }
        
        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            if (!(o.GetType() == typeof(WindowTarget)))
            {
                return false;
            }
            return this.Equals((WindowTarget)o);
        }
        
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        
        #endregion
        
        #region Property ScreenName
        
        private ScreenPattern _screenName;
        
        public virtual ScreenPattern ScreenName
        {
            get { return _screenName; }
            set
            {
                if ((value == _screenName))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property VirtualDesktop
        
        private int _virtualDesktop;
        
        public virtual int VirtualDesktop
        {
            get { return _virtualDesktop; }
            set
            {
                if ((value == _virtualDesktop))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Positioning
        
        private Positioning _positioning;
        
        private const Positioning DEF_POSITIONING = Positioning.Free;
        
        [DefaultValue(DEF_POSITIONING)]
        public virtual Positioning Positioning
        {
            get { return _positioning; }
            set
            {
                if ((value == _positioning))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Left
        
        private float _left;
        
        public virtual float Left
        {
            get { return _left; }
            set
            {
                if ((Math.Abs(value - _left) < float.Epsilon))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Top
        
        private float _top;
        
        public virtual float Top
        {
            get { return _top; }
            set
            {
                if ((Math.Abs(value - _top) < float.Epsilon))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Right
        
        private float _right;
        
        public virtual float Right
        {
            get { return _right; }
            set
            {
                if ((Math.Abs(value - _right) < float.Epsilon))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Bottom
        
        private float _bottom;
        
        public virtual float Bottom
        {
            get { return _bottom; }
            set
            {
                if ((Math.Abs(value - _bottom) < float.Epsilon))
                {
                    return;
                }
            }
        }
        
        #endregion
    }
    
    public partial class WindowAction : IEquatable<WindowAction>
    {
        public WindowAction()
        {
        }
        
        #region Equatability
        
        public bool Equals(WindowAction o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return true;
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
        
        #region Property Window
        
        private string _window;
        
        public virtual string Window
        {
            get { return _window; }
            set
            {
                if (string.Equals(value, _window))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Target
        
        private WindowTarget _target;
        
        public virtual WindowTarget Target
        {
            get { return _target; }
            set
            {
                if ((value == _target))
                {
                    return;
                }
            }
        }
        
        #endregion
    }
    
    public partial class Layout : IEquatable<Layout>
    {
        public Layout()
        {
        }
        
        #region Equatability
        
        public bool Equals(Layout o)
        {
            if (ReferenceEquals(o, null))
            {
                return false;
            }
            return true;
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
        
        #region Property Configurations
        
        private List<ConfigurationPattern> _configurations;
        
        public virtual List<ConfigurationPattern> Configurations
        {
            get { return _configurations; }
            set
            {
                if ((value == _configurations))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Windows
        
        private List<WindowAction> _windows;
        
        public virtual List<WindowAction> Windows
        {
            get { return _windows; }
            set
            {
                if ((value == _windows))
                {
                    return;
                }
            }
        }
        
        #endregion
    }
    
    public partial class Workspace : IEquatable<Workspace>
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
            return true;
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
        
        #region Property WindowPatterns
        
        private List<WindowPattern> _windowPatterns;
        
        public virtual List<WindowPattern> WindowPatterns
        {
            get { return _windowPatterns; }
            set
            {
                if ((value == _windowPatterns))
                {
                    return;
                }
            }
        }
        
        #endregion
        
        #region Property Layouts
        
        private List<Layout> _layouts;
        
        public virtual List<Layout> Layouts
        {
            get { return _layouts; }
            set
            {
                if ((value == _layouts))
                {
                    return;
                }
            }
        }
        
        #endregion
    }
    
    #endregion
}