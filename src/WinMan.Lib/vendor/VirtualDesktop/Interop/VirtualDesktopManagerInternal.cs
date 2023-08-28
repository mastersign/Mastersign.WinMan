using System;

namespace WindowsDesktop.Interop
{
	internal class VirtualDesktopManagerInternal
	{
		private IVirtualDesktopManagerInternal10130 _manager10130;
		private IVirtualDesktopManagerInternal10240 _manager10240;
		private IVirtualDesktopManagerInternal14328 _manager14328;
        private IVirtualDesktopManagerInternal22000 _manager22000;
        private IVirtualDesktopManagerInternal22631 _manager22621;

        public static VirtualDesktopManagerInternal GetInstance()
		{
            var v22622 = GetInstanceCore<IVirtualDesktopManagerInternal22631>();
            if (v22622 != null) return new VirtualDesktopManagerInternal() { _manager22621 = v22622 };

            var v22000 = GetInstanceCore<IVirtualDesktopManagerInternal22000>();
            if (v22000 != null) return new VirtualDesktopManagerInternal() { _manager22000 = v22000 };

            var v14328 = GetInstanceCore<IVirtualDesktopManagerInternal14328>();
			if (v14328 != null) return new VirtualDesktopManagerInternal() { _manager14328 = v14328, };

			var v10240 = GetInstanceCore<IVirtualDesktopManagerInternal10240>();
			if (v10240 != null) return new VirtualDesktopManagerInternal() { _manager10240 = v10240, };

			var v10130 = GetInstanceCore<IVirtualDesktopManagerInternal10130>();
			if (v10130 != null) return new VirtualDesktopManagerInternal() { _manager10130 = v10130, };

            throw new NotSupportedException();
		}

		private static T GetInstanceCore<T>()
		{
			var shellType = Type.GetTypeFromCLSID(CLSID.ImmersiveShell);
			var shell = (IServiceProvider)Activator.CreateInstance(shellType);

			object ppvObject;
			shell.QueryService(CLSID.VirtualDesktopAPIUnknown, typeof(T).GUID, out ppvObject);

			return (T)ppvObject;
		}

		public void MoveViewToDesktop(IApplicationView pView, VirtualDesktopHandle desktop)
		{
            if (this._manager22621 != null)
            {
                this._manager22621?.MoveViewToDesktop(pView, desktop.VirtualDesktop22631);
                return;
            }

            if (this._manager22000 != null)
            {
                this._manager22000?.MoveViewToDesktop(pView, desktop.VirtualDesktop22000);
                return;
            }

            if (this._manager14328 != null)
            {
                this._manager14328?.MoveViewToDesktop(pView, desktop.VirtualDesktop);
                return;
            }

            if (this._manager10240 != null)
			{
				this._manager10240?.MoveViewToDesktop(pView, desktop.VirtualDesktop);
				return;
			}

			if (this._manager10130 != null)
			{
				this._manager10130.MoveViewToDesktop(pView, desktop.VirtualDesktop);
				return;
			}

			throw new NotSupportedException();
		}

		public bool CanViewMoveDesktops(IApplicationView pView)
		{
            if (this._manager22621 != null)
            {
                return this._manager22621.CanViewMoveDesktops(pView);
            }

            if (this._manager22000 != null)
            {
                return this._manager22000.CanViewMoveDesktops(pView);
            }

            if (this._manager14328 != null)
            {
                return this._manager14328.CanViewMoveDesktops(pView);
            }

            if (this._manager10240 != null)
			{
				return this._manager10240.CanViewMoveDesktops(pView);
			}

			if (this._manager10130 != null)
			{
				return this._manager10130.CanViewMoveDesktops(pView);
			}

			throw new NotSupportedException();
		}

		public VirtualDesktopHandle GetCurrentDesktop()
		{
            if (this._manager22621 != null)
            {
                return new VirtualDesktopHandle(this._manager22621.GetCurrentDesktop());
            }

            if (this._manager22000 != null)
            {
                return new VirtualDesktopHandle(this._manager22000.GetCurrentDesktop(IntPtr.Zero));
            }

            if (this._manager14328 != null)
			{
				return new VirtualDesktopHandle(this._manager14328.GetCurrentDesktop());
			}

			if (this._manager10240 != null)
			{
				return new VirtualDesktopHandle(this._manager10240.GetCurrentDesktop());
			}

			if (this._manager10130 != null)
			{
				return new VirtualDesktopHandle(this._manager10130.GetCurrentDesktop());
			}

			throw new NotSupportedException();
		}

		public IObjectArray GetDesktops()
		{
            if (this._manager22621 != null)
            {
                return this._manager22621.GetDesktops();
            }

            if (this._manager22000 != null)
            {
                return this._manager22000.GetDesktops(IntPtr.Zero);
            }

            if (this._manager14328 != null)
			{
				return this._manager14328.GetDesktops();
			}

			if (this._manager10240 != null)
			{
				return this._manager10240.GetDesktops();
			}

			if (this._manager10130 != null)
			{
				return this._manager10130.GetDesktops();
			}

			throw new NotSupportedException();
		}

		public VirtualDesktopHandle GetAdjacentDesktop(VirtualDesktopHandle desktopReference, AdjacentDesktop uDirection)
		{
            if (this._manager22621 != null)
            {
                return new VirtualDesktopHandle(
					this._manager22621.GetAdjacentDesktop(desktopReference.VirtualDesktop22631, uDirection));
            }

            if (this._manager22000 != null)
            {
                return new VirtualDesktopHandle(
                    this._manager22000.GetAdjacentDesktop(desktopReference.VirtualDesktop22000, uDirection));
            }

            if (this._manager14328 != null)
			{
				return new VirtualDesktopHandle(
					this._manager14328.GetAdjacentDesktop(desktopReference.VirtualDesktop, uDirection));
			}

			if (this._manager10240 != null)
			{
				return new VirtualDesktopHandle(
                    this._manager10240.GetAdjacentDesktop(desktopReference.VirtualDesktop, uDirection));
			}

			if (this._manager10130 != null)
			{
				return new VirtualDesktopHandle(
                    this._manager10130.GetAdjacentDesktop(desktopReference.VirtualDesktop, uDirection));
			}

			throw new NotSupportedException();
		}

		public void SwitchDesktop(VirtualDesktopHandle desktop)
		{
            if (this._manager22621 != null)
            {
                this._manager22621?.SwitchDesktop(desktop.VirtualDesktop22631);
                return;
            }

            if (this._manager22000 != null)
            {
                this._manager22000?.SwitchDesktop(IntPtr.Zero, desktop.VirtualDesktop22000);
                return;
            }

            if (this._manager14328 != null)
			{
				this._manager14328?.SwitchDesktop(desktop.VirtualDesktop);
				return;
			}

			if (this._manager10240 != null)
			{
				this._manager10240?.SwitchDesktop(desktop.VirtualDesktop);
				return;
			}

			if (this._manager10130 != null)
			{
				this._manager10130.SwitchDesktop(desktop.VirtualDesktop);
				return;
			}

			throw new NotSupportedException();
		}

		public VirtualDesktopHandle CreateDesktopW()
		{
            if (this._manager22621 != null)
            {
                return new VirtualDesktopHandle(this._manager22621.CreateDesktopW());
            }

            if (this._manager22000 != null)
            {
                return new VirtualDesktopHandle(this._manager22000.CreateDesktop(IntPtr.Zero));
            }

            if (this._manager14328 != null)
			{
				return new VirtualDesktopHandle(this._manager14328.CreateDesktopW());
			}

			if (this._manager10240 != null)
			{
				return new VirtualDesktopHandle(this._manager10240.CreateDesktopW());
			}

			if (this._manager10130 != null)
			{
				return new VirtualDesktopHandle(this._manager10130.CreateDesktopW());
			}

			throw new NotSupportedException();
		}

		public void RemoveDesktop(VirtualDesktopHandle pRemove, VirtualDesktopHandle pFallbackDesktop)
		{
            if (this._manager22621 != null)
            {
                this._manager22621.RemoveDesktop(pRemove.VirtualDesktop22631, pFallbackDesktop.VirtualDesktop22631);
                return;
            }

            if (this._manager22000 != null)
            {
                this._manager22000.RemoveDesktop(pRemove.VirtualDesktop22000, pFallbackDesktop.VirtualDesktop22000);
                return;
            }

            if (this._manager14328 != null)
			{
				this._manager14328.RemoveDesktop(pRemove.VirtualDesktop, pFallbackDesktop.VirtualDesktop);
				return;
			}

			if (this._manager10240 != null)
			{
				this._manager10240.RemoveDesktop(pRemove.VirtualDesktop, pFallbackDesktop.VirtualDesktop);
				return;
			}

			if (this._manager10130 != null)
			{
				this._manager10130.RemoveDesktop(pRemove.VirtualDesktop, pFallbackDesktop.VirtualDesktop);
				return;
			}

			throw new NotSupportedException();
		}

		public VirtualDesktopHandle FindDesktop(ref Guid desktopId)
		{
            if (this._manager22621 != null)
            {
                return new VirtualDesktopHandle(this._manager22621.FindDesktop(ref desktopId));
            }

            if (this._manager22000 != null)
            {
                return new VirtualDesktopHandle(this._manager22000.FindDesktop(ref desktopId));
            }

            if (this._manager14328 != null)
			{
				return new VirtualDesktopHandle(this._manager14328.FindDesktop(ref desktopId));
			}

			if (this._manager10240 != null)
			{
				return new VirtualDesktopHandle(this._manager10240.FindDesktop(ref desktopId));
			}

			if (this._manager10130 != null)
			{
				return new VirtualDesktopHandle(this._manager10130.FindDesktop(ref desktopId));
			}

			throw new NotSupportedException();
		}
    }
}
