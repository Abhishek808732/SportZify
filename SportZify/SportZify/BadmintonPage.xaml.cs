using SportZify.Models;
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
    public partial class BadmintonPage : ContentPage
    {
        public BadmintonPage()
        {
            InitializeComponent();
        }

        async private void CourtsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var court = e.CurrentSelection.FirstOrDefault() as BadmintonCourt;
            await Navigation.PushAsync(new SportZifyDetailPage(court));
        }
    }
}