using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace FutureMindset.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            // Color of the tabbar background:
            UITabBar.Appearance.BarTintColor = UIColor.FromRGB(255, 255, 255);
            // #1D1C20
            //#0B0B0D
            //UITabBar.Appearance.BarTintColor = UIColor.FromRGB(241, 242, 242);


            // Color of the selected tab icon:
            UITabBar.Appearance.SelectedImageTintColor = UIColor.FromRGB(255, 0, 0);
   
            // Color of the selected tab text color:
            UITabBarItem.Appearance.SetTitleTextAttributes(new UITextAttributes()
            {
                TextColor = UIColor.FromRGB(255, 0, 0)
                //("#FF9500")89, 86, 214);
            },
            UIControlState.Selected);
            
            // Color of the unselected tab icon & text:
            UITabBarItem.Appearance.SetTitleTextAttributes(
                new UITextAttributes()
                { 
                    //TextColor = UIColor.FromRGB(19, 23, 26)
                    //146, 146, 146)
                    //(139,139,139)
                },
                UIControlState.Normal);
    
            return base.FinishedLaunching(app, options);
        }
    }
}
