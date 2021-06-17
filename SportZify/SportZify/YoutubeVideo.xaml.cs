using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportZify
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YoutubeVideo : ContentPage
    {
        public YoutubeVideo(string videourl)
        {
            InitializeComponent();

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = $"<html><body style='background-color:black'>" +
                $"<div style='position:relative; margin-top:50% '>+ <iframe  src="+videourl+" frameborder='0' width=100% height='250px' allowfullscreen></iframe></div></body></html>";
            VideoTrailor.Source = htmlSource;
                
        }
    }
}