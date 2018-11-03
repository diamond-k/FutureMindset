using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer (typeof(ContentPage), typeof(FutureMindset.iOS.NavigationPageRendereriOS))]
namespace FutureMindset.iOS
{
    public class NavigationPageRendereriOS : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.NavigationController.NavigationBar.TintColor = UIColor.Red;
        }
    }
}
