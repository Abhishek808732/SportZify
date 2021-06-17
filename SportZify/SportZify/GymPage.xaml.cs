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
    public partial class GymPage : ContentPage
    {
        public GymPage()
        {
            InitializeComponent();
        }

        async private void GymsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gym = e.CurrentSelection.FirstOrDefault() as GymPlace;
            await Navigation.PushAsync(new SportZifyGymPage(gym));
        }
    }
}