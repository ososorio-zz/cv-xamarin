using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Sample
{
	public partial class ProyectWeb : UIViewController
	{

		String _TextControl="";


		public ProyectWeb () : base ("ProyectWeb", null)
		{
			LoadInfo information = new LoadInfo ();
			_TextControl=information.GetString ("prweb","cv-oscar", "proyectos-web");
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
			textPRWeb.Text = _TextControl;
			//textPWeb.Text = "Algunos proyectos de aplicaciones web:\rGuiaMais:\r    http://mapas.guiamais.com.br/\rMundoTerpel (mapas): \r    http://www.mundoterpel.com/\rEcoperro:\r   http://econductoreschevrolet.com/\r\r";
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

