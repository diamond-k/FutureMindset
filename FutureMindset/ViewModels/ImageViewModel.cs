using System;
using System.Collections.ObjectModel;

namespace FutureMindset
{
    public class ImageViewModel
    {
        public ObservableCollection<Image> Images { get; set; }
         
        public ImageViewModel()
        {
            Images = new ObservableCollection<Image>
            {
                new Image
                {
                    Url = "http://www.goformore.click/wp-content/uploads/2016/12/F6HpXu.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
                },
                new Image
                {
                    Url = "http://www.desktop-screens.com/data/out/71/3128717-marvel-heroes-wallpapers.png",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
                },
                new Image
                {
                    Url = "https://static.zerochan.net/Spain.full.594626.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
                },
                new Image
                {
                    Url =  "http://www.lottiedesigns.com/wp-content/uploads/2016/11/tash_guy_488-500x800.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
                },
                new Image
                {
                    Url = "http://www.j-safe.co.uk/wp-content/uploads/revslider/NiceAndClean_Projects/carousel4-500x800.jpg",
                    BuyMeUrl = "https://www.mipic.co/image/f3iEJFGeVmZST5br/"
                }
            };
        }
    }
}
