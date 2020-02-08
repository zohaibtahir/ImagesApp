using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImagesApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<string> images = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            
            images.Add("https://images.unsplash.com/photo-1508558936510-0af1e3cccbab?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80");
            images.Add("https://images.unsplash.com/photo-1503023345310-bd7c1de61c7d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80");
            images.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcT11HMJfEHgPVGhZv0IEoUIe282-nadiB21gqGm6o4NMN2GyxgK");
            setImage(count);
        }
        public void setImage(int count)
        {
            var imageSource = new UriImageSource { Uri = new Uri(images[count]) };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
        }

        private void previous_btn_Clicked(object sender, EventArgs e)
        {
            
            if (count>0)
            {
                count--;
                setImage(count);
            }
        }

        private void next_btn_Clicked(object sender, EventArgs e)
        {
            
            if (count<images.Count-1)
            {
                count++;
                setImage(count);
            }
        }
    }
}
