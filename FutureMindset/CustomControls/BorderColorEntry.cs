using System;
using Xamarin.Forms;
namespace FutureMindset.CustomControls
{
    public class BorderColorEntry : Entry
    {
        public BorderColorEntry()
        {

        }
    }

    public class BorderColorEditor : Editor
    {
        public BorderColorEditor()
        {

        }

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create("Placeholder", typeof(string), typeof(string), "");

        public string Placeholder
        {
            get
            {
                return (string)GetValue(PlaceholderProperty);
            }

            set
            {
                SetValue(PlaceholderProperty, value);
            }
        }
    }
}

