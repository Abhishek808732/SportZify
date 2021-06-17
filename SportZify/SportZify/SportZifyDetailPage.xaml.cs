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
    public partial class SportZifyDetailPage : ContentPage
    {
        public SportZifyDetailPage(BadmintonCourt court)
        {
            InitializeComponent();
            Court = court;
            this.Title = Court.CourtName;
        }

        public BadmintonCourt Court { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = Court;
        }

        async private void BadmintonVideo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new YoutubeVideo(Court.CourtVideoURL));
        }

        async private void BadmintonBook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BookSlot(Court.GameName, Court.CourtName));
        }
    }
}