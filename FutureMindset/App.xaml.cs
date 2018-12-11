using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FutureMindset
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

          //  MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());

            //Background color
          
            //MainPage.SetValue(NavigationPage.BarBackgroundColorProperty,Color.Yellow);

            //Title color
           // MainPage.SetValue(NavigationPage.BarTextColorProperty, "#222222");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
