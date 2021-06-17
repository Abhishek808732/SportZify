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
    public partial class SportZifyCricketDetail : ContentPage
    {
        public SportZifyCricketDetail(CricketClub club)
        {
            InitializeComponent();
            Club = club;
            this.Title = Club.ClubName;
        }

        public CricketClub Club { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = Club;
        }

        async private void CricketVideo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage (new YoutubeVideo(Club.ClubVideoURL)));
        }

        async private void CricketBook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage (new BookSlot(Club.GameName,Club.ClubName)));
        }
    }
}