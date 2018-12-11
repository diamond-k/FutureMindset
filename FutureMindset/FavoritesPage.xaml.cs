using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FutureMindset
{
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            InitializeComponent();

            var images = new List<string>(){
                //"http://www.goformore.click/wp-content/uploads/2016/12/F6HpXu.jpg",
                "http://www.lottiedesigns.com/wp-content/uploads/2016/11/tash_guy_488-500x800.jpg",
                "http://www.desktop-screens.com/data/out/71/3128717-marvel-heroes-wallpapers.png",
                //"https://static.zerochan.net/Spain.full.594626.jpg"
                //"http://www.lottiedesigns.com/wp-content/uploads/2016/11/tash_guy_488-500x800.jpg",
                //"http://www.j-safe.co.uk/wp-content/uploads/revslider/NiceAndClean_Projects/carousel4-500x800.jpg",

            };

 
        //    favCarouselView.ItemsSource = images;
        }

        void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                DisplayAlert("haha", "Enlarge me!", "Bye");
                //Code to execute on tapped event
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
