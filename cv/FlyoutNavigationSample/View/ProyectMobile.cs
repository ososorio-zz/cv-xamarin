using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Sample
{
	public partial class ProyectMobile : UIViewController
	{
		String _Url="";

		public ProyectMobile () : base ("ProyectMobile", null)
		{
			LoadInfo information = new LoadInfo ();
			_Url=information.GetString ("prmobile","cv-oscar", "url-proyectos-moviles");
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

			UIAlertView mensaje = new UIAlertView ("Carrousel", "Puedes cambiar de foto deslizando hacia la  izquierda", null, "Ok", null);
			mensaje.Show ();

			//UIAlertView alerta=	UIAlertView("Carrousel", "Puedes cambiar de foto deslizando hacia la  izquierda  (<-----)", null, "ok", null);
		//	alerta.Show();
			WebLoad.LoadRequest(new NSUrlRequest(new NSUrl(_Url.Trim())));
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

