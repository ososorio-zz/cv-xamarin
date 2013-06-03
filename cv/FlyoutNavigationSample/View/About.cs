using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Sample
{
	public partial class About : UIViewController
	{
		String _TextControl="";

		public About () : base ("About", null)
		{
			LoadInfo information = new LoadInfo ();
			_TextControl=information.GetString ("about","cv-oscar", "about");
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
			textAbout.Text = _TextControl;
			// Perform any additional setup after loading the view, typically from a nib.
		}


	}
}

