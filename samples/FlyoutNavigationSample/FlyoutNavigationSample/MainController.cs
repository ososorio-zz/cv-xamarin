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
			/*base.ViewDidLoad ();

			// Create the flyout view controller, make it large,
			// and add it as a subview:
			navigation = new FlyoutNavigationController ();
			navigation.View.Frame = UIScreen.MainScreen.Bounds;
			View.AddSubview (navigation.View);
			
			// Create the menu:
			navigation.NavigationRoot = new RootElement ("Task List") {
				new Section ("Task List") {
					from page in Tasks
						select new StringElement (page) as Element
				}
			};
			
			// Create an array of UINavigationControllers that correspond to your
			// menu items:
			navigation.ViewControllers = Array.ConvertAll (Tasks, title =>
           		new UINavigationController (new TaskPageController (navigation, title))
			);*/

			base.ViewDidLoad ();
			 navigation = new FlyoutNavigationController {
				// Create the navigation menu
				NavigationRoot = new RootElement ("Navigation") {
					new Section ("CV") {
						new StringElement ("Home"),
						new StringElement ("Proyects Mobile's"),
						new StringElement ("Proyects web"),
						new StringElement ("About Me"),
						new StringElement ("Contact me"),
					}
				},

				/*var viewController1 = new FirstViewController ();
				var viewController2 = new SecondViewController ();
				tabBarController = new UITabBarController ();
				tabBarController.ViewControllers = new UIViewController [] {
					viewController1,
					viewController2,
				};*/

				ViewControllers = new UIViewController[] {
					new Home(),
					new ProyectMobile(),
					new ProyectWeb(),
					new About(),
					new ContactMe(),
				},

			};

			// Show the navigation view
			navigation.ToggleMenu ();
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

