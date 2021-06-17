using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportZify
{
    public partial class BookSlot : ContentPage
    {
        public BookSlot(string gamename, string centrename )
        {
            InitializeComponent();
            Game = gamename;
            Centre = centrename;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            sportnamelabel.Text = Game;
            centrenamelabel.Text = Centre;
        }

        public string Game { get; }
        public string Centre { get; }

        private void BookSlotBtn_Clicked(object sender, EventArgs e)
        {
            //Add Platform (button_click)
            try
            {
                var cn = DependencyService.Get<ISQLite>().GetConnection();


                var info = cn.GetTableInfo("RegDB.db3");
                if (!info.Any())
                {
                    cn.CreateTable<SlotBooking>();
                }

                var obj = new SlotBooking()
                {
                    FullName = NameEntry.Text,
                    Phone = long.Parse(ContactDetails.Text),
                    GameName = Game,
                    CentreName = Centre,
                    TimeSlot = slotpicker.Items[slotpicker.SelectedIndex],
                    PaymentMethod = paymentradio.Value.ToString()
                };

                cn.Insert(obj);
                cn.Close();

                DisplayAlert("Booking", "Slot Booked Successfully", "OK");
                BacktoHome.IsVisible = true;
            }

            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        async private void BacktoHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}