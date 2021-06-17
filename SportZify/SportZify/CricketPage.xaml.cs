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
    public partial class CricketPage : ContentPage
    {
        public CricketPage()
        {
            InitializeComponent();
        }

        async private void ClubsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var club = e.CurrentSelection.FirstOrDefault() as CricketClub;
            await Navigation.PushAsync(new SportZifyCricketDetail(club));
        }
    }
}