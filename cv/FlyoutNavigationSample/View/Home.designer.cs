// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Sample
{
	[Register ("Home")]
	partial class Home
	{
		[Outlet]
		MonoTouch.UIKit.UITextView textoHome { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textoHome != null) {
				textoHome.Dispose ();
				textoHome = null;
			}
		}
	}
}
