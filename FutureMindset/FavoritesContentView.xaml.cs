using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FutureMindset
{
    public partial class FavoritesContentView : ContentView
    {
        public FavoritesContentView()
        {
            InitializeComponent();
        }


        public ImageSource Icon
        {
            get { return SwitchboardIcon.Source; }
            set { SwitchboardIcon.Source = value; }
        }

        public string Label
        {
            get { return SwitchboardLabel.Text; }
            set { SwitchboardLabel.Text = value; }
        }


        public Xamarin.Forms.Thickness Margins
        {
            get { return SwitchboardLabel.Margin; }
            set { SwitchboardLabel.Margin = value; }

        }

    }
}
