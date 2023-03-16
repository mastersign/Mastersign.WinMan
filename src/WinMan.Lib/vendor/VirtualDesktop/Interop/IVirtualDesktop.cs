using System;
using System.Runtime.InteropServices;

namespace WindowsDesktop.Interop
{
	[ComImport]
	[Guid("ff72ffdd-be7e-43fc-9c03-ad81681e88e4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVirtualDesktop
	{
		bool IsViewVisible(object pView);

		Guid GetID();
	}

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("536D3495-B208-4CC9-AE26-DE8111275BF8")]
    public interface IVirtualDesktop22000
    {
        bool IsViewVisible(IApplicationView view);

        Guid GetId();

        IntPtr Unknown1();
        [return: MarshalAs(UnmanagedType.HString)]

        string GetName();
        [return: MarshalAs(UnmanagedType.HString)]

        string GetWallpaperPath();
    }

    public readonly struct VirtualDesktopHandle
    {
        private readonly IVirtualDesktop vd;
        private readonly IVirtualDesktop22000 vd2;

        public IVirtualDesktop VirtualDesktop => vd;
        public IVirtualDesktop22000 VirtualDesktop22000 => vd2;

        public VirtualDesktopHandle(IVirtualDesktop vd)
        {
            this.vd = vd;
            this.vd2 = null;
        }

        public VirtualDesktopHandle(IVirtualDesktop22000 vd)
        {
            this.vd = null;
            this.vd2 = vd;
        }

        public bool IsViewVisible(IApplicationView pView)
        {
            if (vd2 != null) return vd2.IsViewVisible(pView);
            return vd.IsViewVisible(pView);
        }

        public Guid GetID()
        {
            if (vd2 != null) return vd2.GetId();
            return vd.GetID();
        }
    }
}
