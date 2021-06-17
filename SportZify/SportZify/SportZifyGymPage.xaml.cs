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
    public partial class SportZifyGymPage : ContentPage
    {
        public SportZifyGymPage(GymPlace gym)
        {
            InitializeComponent();
            Gym = gym;
            this.Title = Gym.GymName;
        }

        public GymPlace Gym { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = Gym;
        }

        async private void GymVideo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new YoutubeVideo(Gym.GymVideoURL));
        }

        async private void GymBooking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BookSlot(Gym.GameName, Gym.GymName));
        }
    }
}