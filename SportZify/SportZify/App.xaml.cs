using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportZify
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new HomeShell();
            //MainPage = new DiscoverPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
