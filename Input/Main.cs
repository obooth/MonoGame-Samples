using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoGame.Samples.Input
{
	[Register ("AppDelegate")]
	class Program : UIApplicationDelegate 
	{
		private Game1 game;

		public override void FinishedLaunching (UIApplication app)
		{
			// Fun begins..
			game = new Game1();
			game.Run();
		}

		static void Main (string [] args)
		{
			UIApplication.Main (args,null,"AppDelegate");
		}
	}
}
