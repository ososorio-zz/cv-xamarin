using System;
using System.Linq;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

using FlyoutNavigation;

namespace Sample
{
	public class MainController : UIViewController
	{
		FlyoutNavigationController navigation;
				
		public override void ViewDidLoad ()
		{

			base.ViewDidLoad ();
			 navigation = new FlyoutNavigationController {
				// Create the navigation menu
				NavigationRoot = new RootElement ("Navigation") {
					new Section ("CV") {
						new StringElement ("Inicio"),
						new StringElement ("Acerca"),
						new StringElement ("Proyectos moviles"),
						new StringElement ("Proyectos web"),
						new StringElement ("Contacto"),
					}
				},

				ViewControllers = new UIViewController[] {
					new Home(),
					new About(),
					new ProyectMobile(),
					new ProyectWeb(),
					new ContactMe(),
				},

			};

			// Show the navigation view
			//navigation.ToggleMenu ();
			View.AddSubview (navigation.View);


		}
		
		class TaskPageController : DialogViewController
		{
			public TaskPageController (FlyoutNavigationController navigation, string title) : base (null)
			{
				Root = new RootElement (title) {
					new Section {
						new CheckboxElement (title)
					}
				};
				NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
					navigation.ToggleMenu ();
				});
			}
		}


	
	}
}

