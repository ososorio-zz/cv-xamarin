using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;


namespace Sample
{
	public partial class Home : UIViewController
	{
		String _TextControl="";

		public Home () : base ("Home", null)
		{
			//LoadInfo ();
			LoadInfo information = new LoadInfo ();
			_TextControl=information.GetString ("home","cv-home", "home");
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
			textoHome.Text =_TextControl;
		}
	}
}

