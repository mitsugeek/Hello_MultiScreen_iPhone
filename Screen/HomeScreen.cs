
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_MultiScreen_iPhone
{
	public partial class HomeScreen : UIViewController
	{
		HelloWorldScreen helloWorldScreen;
		HelloUniverseScreen helloUniverseScreen;

		public HomeScreen () : base ("HomeScreen", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib.
			//---- when the hello world button is clicked
			this.btnHelloWorld.TouchUpInside += (sender, e) => {
				//---- instantiate a new hello world screen, if it's null
				// (it may not be null if they've navigated backwards
				if(this.helloWorldScreen == null)
				{ this.helloWorldScreen = new HelloWorldScreen(); }
				//---- push our hello world screen onto the navigation
				//controller and pass a true so it navigates
				this.NavigationController.PushViewController(this.helloWorldScreen, true);
			};
			
			//---- same thing, but for the hello universe screen
			this.btnHelloUniverse.TouchUpInside += (sender, e) => {
				if(this.helloUniverseScreen == null) {
					this.helloUniverseScreen = new HelloUniverseScreen();
				} 
				
				this.NavigationController.PushViewController(this.helloUniverseScreen, true);
			};
		}
	}
}

