using System;
using System.Runtime.InteropServices;

namespace WindowsDesktop.Interop
{
	[ComImport]
	[Guid("1841c6d7-4f9d-42c0-af41-8747538f10e5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IApplicationViewCollection
	{
		int GetViews(out IObjectArray array);

		int GetViewsByZOrder(out IObjectArray array);

		int GetViewsByAppUserModelId(string id, out IObjectArray array);

		int GetViewForHwnd(IntPtr hwnd, out IApplicationView view);

		int GetViewForApplication(object application, out IApplicationView view);

		int GetViewForAppUserModelId(string id, out IApplicationView view);

		int GetViewInFocus(out IntPtr view);

		void outreshCollection();

		int RegisterForApplicationViewChanges(object listener, out int cookie);

		int RegisterForApplicationViewPositionChanges(object listener, out int cookie);

		int UnregisterForApplicationViewChanges(int cookie);
	}
}
