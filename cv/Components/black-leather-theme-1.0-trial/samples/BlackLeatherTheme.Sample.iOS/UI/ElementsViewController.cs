using System;
using MonoTouch.UIKit;
using System.Drawing;
using Xamarin.Themes;

namespace ThemeSample
{
	public class ElementsViewController : UIViewController
	{
		public ElementsViewController ()
		{
			this.Title = "Elements";
			this.TabBarItem = new UITabBarItem ("Elements", new UIImage ("elementsIcon.png"), 0);
		}

		public override void LoadView ()
		{
			View = new StackPanel ();			
			BlackLeatherTheme.Apply (View);
			//Add Label
			UILabel textLabel = new UILabel (new RectangleF (15, 40, 200, 30)){
				Text = "Label"
			};
			BlackLeatherTheme.Apply (textLabel);
			View.AddSubview (textLabel);

			//Add TextField
			UITextField textField = new UITextField (new RectangleF (10, 80, 268, 30)) {
				Placeholder = "Text Input",
				ShouldReturn = (field) => {
					field.ResignFirstResponder();
					return true;
				}
			};
			BlackLeatherTheme.Apply (textField);
			View.AddSubview (textField);

			AddButton ("", "Normal Button");
			AddButton ("cancel", "Cancel Button");
			AddButton ("confirm", "Confirm Button");

			//AddSlider();
			UISlider slider = new UISlider (new RectangleF (10, 330, 298, 10)){
				Value = 0.5f
			};			
			View.AddSubview (slider);
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return (toInterfaceOrientation == UIInterfaceOrientation.Portrait);
		}
		

		private void AddButton (string options, string title)
		{
			UIButton button = new UIButton (new RectangleF (10, 120, 298, 57));
			BlackLeatherTheme.Apply (button, options);
			
			button.SetTitle (title, UIControlState.Normal);
			
			View.AddSubview (button);
		}
	}
}
