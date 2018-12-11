using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SafariServices;
using System.Linq;

namespace FutureMindset
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Image> Images { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private INativeBrowserService service;

        // ICommand implementations
        public ICommand OpenUrlCommand { protected set; get; }

        public ImageViewModel()
        {
            OpenUrlCommand = new Command<string>((url) =>
            {
               // Application.Current.MainPage.DisplayAlert("Login", url, "Ok");
                //Device.OpenUri(new Uri(url));

                // this relies on the built-in service locator, but i could also just
                // as easily locate this service using DI and launch from your ViewModel
                service = DependencyService.Get<INativeBrowserService>();
                {
                    if (service == null) return;

                    service.LaunchNativeEmbeddedBrowser(url);
                };
            });

            Images = new ObservableCollection<Image>
            {
                new Image
                {
                    Url = "http://image4.photobiz.com/2581/34_20130612192346_982504_xlarge.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"                
                },              
                new Image
                {
                    Url = "https://i.pinimg.com/originals/94/ab/ca/94abcae3f3a1a0e19ae8f480f662e785.png ",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
                },
                new Image
                { 
                    Url = "https://i.pinimg.com/originals/21/f8/e1/21f8e1813b70f4cfb68e18cac3e71f61.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"              
                },
                new Image
                {
                    Url =  "http://www.goformore.click/wp-content/uploads/2016/12/F6HpXu.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/3TfqEJLzke6hbjIp/"
                },
            };
        }

        protected void OnPropertyChanged(string propertyName)
        {     
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}









//if (PropertyChanged != null)
//{
//    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//}
//new Image
//{
//    Url = "http://www.j-safe.co.uk/wp-content/uploads/revslider/NiceAndClean_Projects/carousel4-500x800.jpg",
//    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
//}
//new Image
//{
//    Url = "http://www.desktop-screens.com/data/out/71/3128717-marvel-heroes-wallpapers.png",
//    BuyMeUrl = "https://www.mipic.co/image/3TfqEJLzke6hbjIp/"
//},