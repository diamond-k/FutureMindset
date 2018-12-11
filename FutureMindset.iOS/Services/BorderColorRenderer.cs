using FutureMindset.iOS;
using UIKit;
using FutureMindset.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(BorderColorEntry), typeof(CustomEntryRenderer))]
[assembly: ExportRenderer(typeof(BorderColorEditor), typeof(CustomEditorRenderer))]
namespace FutureMindset.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.BorderColor = UIColor.FromRGB(189, 196, 201).CGColor;
                Control.Layer.BorderWidth = 1;
                Control.TextColor = UIColor.Red;
                Control.Layer.CornerRadius = 5;
                //Control.BorderStyle = UITextBorderStyle.None

            }
        }
    }
    public class CustomEditorRenderer : EditorRenderer
    {
        
        private string Placeholder { get; set; }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            var element = this.Element as BorderColorEditor;

            if (Control != null && element != null)
            {
                Control.Layer.CornerRadius = 5;
                Control.Layer.BorderColor = Color.FromHex("bdc4c9").ToCGColor();
                Control.Layer.BorderWidth = 1;

                Placeholder = element.Placeholder;
                Control.TextColor = UIColor.LightGray;
                Control.Text = Placeholder;

                Control.AutocorrectionType = UITextAutocorrectionType.No;
                Control.SpellCheckingType = UITextSpellCheckingType.No;

                Control.ShouldBeginEditing += (UITextView textView) =>
                {
                    if (textView.Text == Placeholder)
                    {
                        textView.Text = "";
                        textView.TextColor = UIColor.Red; // Text Color
                    }

                    return true;
                };

                Control.ShouldEndEditing += (UITextView textView) =>
                {
                    if (textView.Text == "")
                    {
                        textView.Text = Placeholder;
                        textView.TextColor = UIColor.LightGray; // Placeholder Color
                    }

                    return true;
                };
            }
        }
    }
}