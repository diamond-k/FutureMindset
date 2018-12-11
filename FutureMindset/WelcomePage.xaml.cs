using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FutureMindset
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
       
        }

        public async void CameraButtonTapped(object sender, EventArgs args)
        {
            //var layout = (Frame)sender;
           // layout.Opacity = 0.5;

            await Navigation.PushAsync(new PhotosPage());
          //  layout.Opacity = 1;
        }

        public async void FavoriteButtonTapped(object sender, EventArgs args)
        {
         //   var layout = (Frame)sender;
          //  layout.Opacity = 0.5;

            await Navigation.PushAsync(new FavoritesPage());
          //  layout.Opacity = 1;
        }

        public async void SubscribeButtonTapped(object sender, EventArgs args)
        {
          //  var layout = (Frame)sender;
          //  layout.Opacity = 0.5;

            await Navigation.PushAsync(new SubscribePage());
          //  layout.Opacity = 1;
        }

    }
}
