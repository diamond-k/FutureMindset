using Android.App;
using Android.Support.CustomTabs;
using FutureMindset.Droid.Services;
using Xamarin.Forms;


[assembly: Dependency(typeof(AndroidNativeBrowserService))]
namespace FutureMindset.Droid.Services
{
    public class AndroidNativeBrowserService : INativeBrowserService
    {
      //CustomTabsActivityManager customTabs;

        public void LaunchNativeEmbeddedBrowser(string url)
        {
            // TODO: We need the current actiivty. Forms.Context is deprecated, but I had issues
            // trying to use Android.App.Appllication.Context
            var activity = Forms.Context as Activity;

            if (activity == null) return;

            var mgr = new CustomTabsActivityManager(activity);
            mgr.CustomTabsServiceConnected += delegate {
                mgr.LaunchUrl(url);
            };

            mgr.BindService();
        }
    }
}
