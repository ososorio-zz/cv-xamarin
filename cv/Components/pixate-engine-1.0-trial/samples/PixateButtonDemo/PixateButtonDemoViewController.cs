using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using PixateLib;

namespace PixateButtonDemo
{
	public partial class PixateButtonDemoViewController : UIViewController
	{
		public PixateButtonDemoViewController () : base (null, null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.View.SetStyleId ("main");

			// Perform any additional setup after loading the view, typically from a nib.
			UIButton button1 = UIButton.FromType (UIButtonType.RoundedRect);
			button1.SetStyleId ("button1");

			UIButton button2 = UIButton.FromType (UIButtonType.RoundedRect);
			button2.SetStyleId ("button2");

			this.View.AddSubview (button1);
			this.View.AddSubview (button2);
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

