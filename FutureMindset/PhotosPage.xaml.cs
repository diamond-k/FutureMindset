using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FutureMindset
{
    public partial class PhotosPage : ContentPage
    {
        

        public PhotosPage()
        {
            InitializeComponent();
            BindingContext = new ImageViewModel ();

        } 

        void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                DisplayAlert("haha", "hehe", "Bye");
                //Code to execute on tapped event
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
