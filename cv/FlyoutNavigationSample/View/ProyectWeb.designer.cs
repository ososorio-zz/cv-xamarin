// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Sample
{
	[Register ("ProyectWeb")]
	partial class ProyectWeb
	{
		[Outlet]
		MonoTouch.UIKit.UITextView textPRWeb { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textPRWeb != null) {
				textPRWeb.Dispose ();
				textPRWeb = null;
			}
		}
	}
}
