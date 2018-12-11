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
            this.NavigationController.NavigationBar.TintColor = UIColor.FromRGB(246, 44, 44);
            this.TabBarController.TabBar.UnselectedItemTintColor = UIColor.FromRGB(58, 68, 77); //UIColor.FromRGB(0, 0, 0);

        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var att = new UITextAttributes
                {
                    Font = UIFont.FromName("Pacifico-Regular", 28),

                };
                UINavigationBar.Appearance.SetTitleTextAttributes(att);
            }
        }
    }
}
