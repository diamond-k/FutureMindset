using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
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
            //Device.OpenUri(new Uri("tel:+447976632975"));
            // Device.OpenUri(new Uri("sms:+447976632975"));
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms("+447976632975", "");

            // Make Phone Call
            //var phoneDialer = CrossMessaging.Current.PhoneDialer;
            //if (phoneDialer.CanMakePhoneCall)
            //phoneDialer.MakePhoneCall("+447976632975");

        }

        void Website_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://future-mindset.com/"));
        }

        void Email_Tapped(object sender, System.EventArgs e)
        {
            //Device.OpenUri(new Uri("mailto:futuremindset@mail.com"));


            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // Send simple e-mail to single receiver without attachments, bcc, cc etc.
                emailMessenger.SendEmail("to.futuremindset@mail.com", "Contact me", "");

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc. 
                //var email = new EmailMessageBuilder()
                  //.To("to.plugins@xamarin.com")
                  //.Cc("cc.plugins@xamarin.com")
                  //.Bcc(new[] { "bcc1.plugins@xamarin.com", "bcc2.plugins@xamarin.com" })
                  //.Subject("Xamarin Messaging Plugin")
                  //.Body("Well hello there from Xam.Messaging.Plugin")
                  //.Build();

                //emailMessenger.SendEmail(email);
            }
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
