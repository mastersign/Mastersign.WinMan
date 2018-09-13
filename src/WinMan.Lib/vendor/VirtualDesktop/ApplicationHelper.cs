using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsDesktop.Interop;

namespace WindowsDesktop
{
	public static class ApplicationHelper
	{
		internal static IApplicationView GetApplicationView(this IntPtr hWnd)
		{
		    try
		    {
		        ComObjects.ApplicationViewCollection.GetViewForHwnd(hWnd, out var view);
		        return view;
		    }
            catch (COMException e)
            {
                if (e.ErrorCode == -2147319765) return null;
                throw;
            }
        }

		public static string GetAppId(this IntPtr hWnd)
		{
            var appView = hWnd.GetApplicationView();
		    if (appView == null) return null;
		    try
		    {
		        appView.GetAppUserModelId(out var appId);
		        return appId;
		    }
		    catch (COMException e)
		    {
		        if (e.ErrorCode == -2147023728) return null;
		        throw;
		    }
		}
	}
}
