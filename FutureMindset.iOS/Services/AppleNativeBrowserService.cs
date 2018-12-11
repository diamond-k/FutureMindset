using Foundation;
using SafariServices;
using UIKit;
using FutureMindset.iOS.Services;
using Xamarin.Forms;
 

[assembly: Dependency(typeof(AppleNativeBrowserService))]
namespace FutureMindset.iOS.Services
{
    public class AppleNativeBrowserService : INativeBrowserService
    {
        public void LaunchNativeEmbeddedBrowser(string url)
        {
            var destination = new NSUrl(url);
            var sfViewController = new SFSafariViewController(destination);

            var window = UIApplication.SharedApplication.KeyWindow;

            var controller = window.RootViewController;

            controller.PresentViewController(sfViewController, true, null);
        }
    }
}