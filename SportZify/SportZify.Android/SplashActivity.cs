using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SportZify.Droid
{
    [Activity(Label = "SplashActivity", MainLauncher = true, 
        Theme = "@style/Theme.Splash", NoHistory = true, Icon = "@drawable/icon")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Display Splash Screen for 4 Sec  
            Thread.Sleep(2000);
            //Start Activity1 Activity  
            StartActivity(typeof(MainActivity));
        }
    }
}