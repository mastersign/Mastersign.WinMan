using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsDesktop.Interop;

namespace WindowsDesktop
{
	/// <summary>
	/// Encapsulates a virtual desktop on Windows 10.
	/// </summary>
	[DebuggerDisplay("{Id}")]
	public partial class VirtualDesktop
	{
		/// <summary>
		/// Gets the unique identifier for the virtual desktop.
		/// </summary>
		public Guid Id { get; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public VirtualDesktopHandle Handle => ComObjects.GetVirtualDesktop(this.Id);

		private VirtualDesktop(VirtualDesktopHandle handle)
		{
			ComObjects.Register(handle);
			this.Id = handle.GetID();
		}


		/// <summary>
		/// Display the virtual desktop.
		/// </summary>
		public void Switch()
		{
			ComObjects.VirtualDesktopManagerInternal.SwitchDesktop(this.Handle);
		}

		/// <summary>
		/// Remove the virtual desktop.
		/// </summary>
		public void Remove()
		{
			this.Remove(GetDesktopsInternal().FirstOrDefault(x => x.Id != this.Id) ?? Create());
		}

		/// <summary>
		/// Remove the virtual desktop, specifying a virtual desktop that display after destroyed.
		/// </summary>
		public void Remove(VirtualDesktop fallbackDesktop)
		{
			if (fallbackDesktop == null) throw new ArgumentNullException(nameof(fallbackDesktop));

			ComObjects.VirtualDesktopManagerInternal.RemoveDesktop(this.Handle, fallbackDesktop.Handle);
		}

		/// <summary>
		/// Returns a virtual desktop on the left.
		/// </summary>
		public VirtualDesktop GetLeft()
		{
			VirtualDesktopHandle desktop;
			try
			{
				desktop = ComObjects.VirtualDesktopManagerInternal.GetAdjacentDesktop(this.Handle, AdjacentDesktop.LeftDirection);
			}
			catch (COMException ex) when (ex.Match(HResult.TYPE_E_OUTOFBOUNDS))
			{
				return null;
			}
			var wrapper = _wrappers.GetOrAdd(desktop.GetID(), _ => new VirtualDesktop(desktop));

			return wrapper;
		}

		/// <summary>
		/// Returns a virtual desktop on the right.
		/// </summary>
		public VirtualDesktop GetRight()
		{
			VirtualDesktopHandle desktop;
			try
			{
				desktop = ComObjects.VirtualDesktopManagerInternal.GetAdjacentDesktop(this.Handle, AdjacentDesktop.RightDirection);
			}
			catch (COMException ex) when (ex.Match(HResult.TYPE_E_OUTOFBOUNDS))
			{
				return null;
			}
			var wrapper = _wrappers.GetOrAdd(desktop.GetID(), _ => new VirtualDesktop(desktop));

			return wrapper;
		}

        public bool MoveWindowHere(IntPtr hWnd)
        {
            IApplicationView appView = ApplicationHelper.GetApplicationView(hWnd);
            if (!ComObjects.VirtualDesktopManagerInternal.CanViewMoveDesktops(appView)) return false;
            ComObjects.VirtualDesktopManagerInternal.MoveViewToDesktop(appView, Handle);
            return true;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
