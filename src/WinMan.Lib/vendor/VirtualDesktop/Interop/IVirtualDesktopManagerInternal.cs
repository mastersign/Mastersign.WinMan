using System;
using System.Runtime.InteropServices;

namespace WindowsDesktop.Interop
{
	[ComImport]
	[Guid("ef9f1a6c-d3cc-4358-b712-f84b635bebe7")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface IVirtualDesktopManagerInternal10130
	{
		int GetCount();

		void MoveViewToDesktop(IApplicationView pView, IVirtualDesktop desktop);

		bool CanViewMoveDesktops(IApplicationView pView);

		IVirtualDesktop GetCurrentDesktop();

		IObjectArray GetDesktops();

		IVirtualDesktop GetAdjacentDesktop(IVirtualDesktop pDesktopReference, AdjacentDesktop uDirection);

		void SwitchDesktop(IVirtualDesktop desktop);

		IVirtualDesktop CreateDesktopW();

		void RemoveDesktop(IVirtualDesktop pRemove, IVirtualDesktop pFallbackDesktop);

		IVirtualDesktop FindDesktop(ref Guid desktopId);
	}

	[ComImport]
	[Guid("af8da486-95bb-4460-b3b7-6e7a6b2962b5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface IVirtualDesktopManagerInternal10240
	{
		int GetCount();

		void MoveViewToDesktop(IApplicationView pView, IVirtualDesktop desktop);

		bool CanViewMoveDesktops(IApplicationView pView);

		IVirtualDesktop GetCurrentDesktop();

		IObjectArray GetDesktops();

		IVirtualDesktop GetAdjacentDesktop(IVirtualDesktop pDesktopReference, AdjacentDesktop uDirection);

		void SwitchDesktop(IVirtualDesktop desktop);

		IVirtualDesktop CreateDesktopW();

		void RemoveDesktop(IVirtualDesktop pRemove, IVirtualDesktop pFallbackDesktop);

		IVirtualDesktop FindDesktop(ref Guid desktopId);
	}

	[ComImport]
	[Guid("f31574d6-b682-4cdc-bd56-1827860abec6")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface IVirtualDesktopManagerInternal14328
	{
		int GetCount();

		void MoveViewToDesktop(IApplicationView pView, IVirtualDesktop desktop);

		bool CanViewMoveDesktops(IApplicationView pView);

		IVirtualDesktop GetCurrentDesktop();

		IObjectArray GetDesktops();

		IVirtualDesktop GetAdjacentDesktop(IVirtualDesktop pDesktopReference, AdjacentDesktop uDirection);

		void SwitchDesktop(IVirtualDesktop desktop);

		IVirtualDesktop CreateDesktopW();

		void RemoveDesktop(IVirtualDesktop pRemove, IVirtualDesktop pFallbackDesktop);

		IVirtualDesktop FindDesktop(ref Guid desktopId);
	}

    /*
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("0f3a72b0-4566-487e-9a33-4ed302f6d6ce")]
    internal interface IVirtualDesktopManagerInternal2
    {
        int GetCount();

        void MoveViewToDesktop(IApplicationView view, IVirtualDesktop desktop);

        bool CanViewMoveDesktops(IApplicationView view);

        IVirtualDesktop GetCurrentDesktop();

        void GetDesktops(out IObjectArray desktops);

        [PreserveSig]
        int GetAdjacentDesktop(IVirtualDesktop from, AdjacentDesktop uDirection, out IVirtualDesktop desktop);

        void SwitchDesktop(IVirtualDesktop desktop);

        IVirtualDesktop CreateDesktop();

        void RemoveDesktop(IVirtualDesktop desktop, IVirtualDesktop fallback);

        IVirtualDesktop FindDesktop(ref Guid desktopid);

        void Unknown1(IVirtualDesktop desktop, out IntPtr unknown1, out IntPtr unknown2);

        void SetName(IVirtualDesktop desktop, [MarshalAs(UnmanagedType.HString)] string name);
    }
	*/

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("b2f925b9-5a0f-4d2e-9f4d-2b1507593c10")]
    internal interface IVirtualDesktopManagerInternal22000
    {
        int GetCount(IntPtr hWndOrMon);

        void MoveViewToDesktop(IApplicationView view, IVirtualDesktop22000 desktop);

        bool CanViewMoveDesktops(IApplicationView view);

        IVirtualDesktop22000 GetCurrentDesktop(IntPtr hWndOrMon);

        IObjectArray GetAllCurrentDesktops();

        IObjectArray GetDesktops(IntPtr hWndOrMon);

        [PreserveSig]
        IVirtualDesktop22000 GetAdjacentDesktop(IVirtualDesktop22000 from, AdjacentDesktop uDirection);

        void SwitchDesktop(IntPtr hWndOrMon, IVirtualDesktop22000 desktop);

        IVirtualDesktop22000 CreateDesktop(IntPtr hWndOrMon);

        void MoveDesktop(IVirtualDesktop22000 desktop, IntPtr hWndOrMon, int nIndex);

        void RemoveDesktop(IVirtualDesktop22000 desktop, IVirtualDesktop22000 fallback);

        IVirtualDesktop22000 FindDesktop(ref Guid desktopid);

        void GetDesktopSwitchIncludeExcludeViews(IVirtualDesktop22000 desktop, out IObjectArray unknown1, out IObjectArray unknown2);

        void SetDesktopName(IVirtualDesktop22000 desktop, [MarshalAs(UnmanagedType.HString)] string name);

        void SetDesktopWallpaper(IVirtualDesktop22000 desktop, [MarshalAs(UnmanagedType.HString)] string path);

        void UpdateWallpaperPathForAllDesktops([MarshalAs(UnmanagedType.HString)] string path);

        void CopyDesktopState(IApplicationView pView0, IApplicationView pView1);

        int GetDesktopIsPerMonitor();

        void SetDesktopIsPerMonitor(bool state);
    }

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("4970ba3d-fd4e-4647-bea3-d89076ef4b9c")]
    //[Guid("a3175f2d-239c-4bd2-8aa0-eeba8b0b138e")]
    internal interface IVirtualDesktopManagerInternal22631
    {
        int GetCount();

        void MoveViewToDesktop(IApplicationView view, IVirtualDesktop22631 desktop);

        bool CanViewMoveDesktops(IApplicationView view);

        IVirtualDesktop22631 GetCurrentDesktop();

        IObjectArray GetDesktops();

        [PreserveSig]
        IVirtualDesktop22631 GetAdjacentDesktop(IVirtualDesktop22631 from, AdjacentDesktop uDirection);

        void SwitchDesktop(IVirtualDesktop22631 desktop);

        void SwitchDesktopAndMoveForegroundView(IVirtualDesktop22631 desktop);

        IVirtualDesktop22631 CreateDesktopW();

        void MoveDesktop(IVirtualDesktop22631 desktop, int nIndex);

        void RemoveDesktop(IVirtualDesktop22631 desktop, IVirtualDesktop22631 fallback);

        IVirtualDesktop22631 FindDesktop(ref Guid desktopid);

        void GetDesktopSwitchIncludeExcludeViews(IVirtualDesktop22631 desktop, out IObjectArray unknown1, out IObjectArray unknown2);

        void SetDesktopName(IVirtualDesktop22631 desktop, [MarshalAs(UnmanagedType.HString)] string name);

        void SetDesktopWallpaper(IVirtualDesktop22631 desktop, [MarshalAs(UnmanagedType.HString)] string path);

        void UpdateWallpaperPathForAllDesktops([MarshalAs(UnmanagedType.HString)] string path);

        void CopyDesktopState(IApplicationView pView0, IApplicationView pView1);

        IVirtualDesktop22631 CreateRemoteDesktop([MarshalAs(UnmanagedType.HString)] string path);

        void SwitchRemoteDesktop(IVirtualDesktop22631 desktop);

        void SwitchDesktopWithAnimation(IVirtualDesktop22631 desktop);

        IVirtualDesktop22631 GetLastActiveDesktop();

        void WaitForAnimationToComplete();
    }

    public enum AdjacentDesktop
	{
		LeftDirection = 3,
		RightDirection = 4,
	}
}
