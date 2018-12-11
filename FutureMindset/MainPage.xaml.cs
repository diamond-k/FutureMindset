using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FutureMindset
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();     
        }
     

        void Phone_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:+44 7976 632975"));
        }

        void Website_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://future-mindset.com/"));
        }

        void Email_Tapped(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:futuremindset@mail.com"));
        }

        public async void CameraButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PhotosPage());
        }

        public async void FavoriteButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FavoritesPage());
        }

        public async void SubscribeButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SubscribePage());
        }

    }
}
