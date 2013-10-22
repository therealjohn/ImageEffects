using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ImageEffects;

namespace ImageEffects.Example
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UIViewController controller;
		UIImageView imageView;	
		UIButton button;

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			controller = new UIViewController ();
			imageView = new UIImageView(UIImage.FromFile("background.jpg"));

			button = UIButton.FromType (UIButtonType.System);
			button.Frame = new RectangleF (115, 175, 100, 44);
			button.SetTitle ("Hello Blur", UIControlState.Normal);

			controller.View.AddSubviews (imageView, button);

			// If you have defined a root view controller, set it here:
			window.RootViewController = controller;
			
			// make the window visible
			window.MakeKeyAndVisible ();

			ApplyBackgroundToView (button, controller.View);
			
			return true;
		}

		void ApplyBackgroundToView(UIButton button, UIView backgroundView)
		{
			// This makes sure we have the coordinates relative to the backgroundView. Without this, the image drawn
			// for the button would be at the incorrect place of the background. 
			RectangleF buttonRectInBGViewCoords = button.ConvertRectToView (button.Bounds, backgroundView);
			UIGraphics.BeginImageContextWithOptions (button.Frame.Size, false, window.Screen.Scale);

			// Make a new image of the backgroundView (basically a screenshot of the view)
			backgroundView.DrawViewHierarchy (new RectangleF (-buttonRectInBGViewCoords.X, -buttonRectInBGViewCoords.Y,
				backgroundView.Frame.Width, backgroundView.Frame.Height), true);
			UIImage newBGImage = UIGraphics.GetImageFromCurrentImageContext ();
			UIGraphics.EndImageContext ();

			// Apply the blur effect
			newBGImage = newBGImage.ApplyLightEffect ();

			// Set the blurred image as the background for the button
			button.SetBackgroundImage (newBGImage, UIControlState.Normal);
			button.Layer.CornerRadius = 4.0f;
			button.Layer.MasksToBounds = true;
		}
	}
}

