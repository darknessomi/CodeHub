// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CodeHub.iOS.ViewControllers.App
{
	[Register ("EnablePushNotificationsViewController")]
	partial class EnablePushNotificationsViewController
	{
		[Outlet]
		UIKit.UIButton CancelButton { get; set; }

		[Outlet]
		UIKit.UIView ContainerView { get; set; }

		[Outlet]
		UIKit.UIButton EnableButton { get; set; }

		[Outlet]
		UIKit.UIImageView ImageView { get; set; }

		[Outlet]
		UIKit.UILabel PushLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}

			if (EnableButton != null) {
				EnableButton.Dispose ();
				EnableButton = null;
			}

			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (PushLabel != null) {
				PushLabel.Dispose ();
				PushLabel = null;
			}

			if (ContainerView != null) {
				ContainerView.Dispose ();
				ContainerView = null;
			}
		}
	}
}
