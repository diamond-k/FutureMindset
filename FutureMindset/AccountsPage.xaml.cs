using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FutureMindset
{
    public partial class AccountsPage : ContentPage
    {
        public AccountsPage()
        {
            InitializeComponent();

           // Browser.Source = "https://www.mipic.co/futuremindset/";
            // Device.OpenUri(new Uri(url));
            //Browser.VerticalOptions = LayoutOptions.FillAndExpand;
            //Browser.HorizontalOptions = LayoutOptions.FillAndExpand;
        }


        private void backClicked(object sender, EventArgs e)
        {
            // Check to see if there is anywhere to go back to
            //if (Browser.CanGoBack)
            //{
             //   Browser.GoBack();

           // }
            //else
            //{ // If not, leave the view
            //    Navigation.PopModalAsync();
            //}
        }

        private void forwardClicked(object sender, EventArgs e)
        {
          //  if (Browser.CanGoForward)
            //{
        //        Browser.GoForward();
            //}
        }
    }
}
