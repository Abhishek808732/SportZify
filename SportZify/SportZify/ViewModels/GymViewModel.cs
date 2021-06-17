using SportZify.Models;
using SportZify.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.ViewModels
{
    public class GymViewModel : BaseViewModel
    {
        public List<GymPlace> Gyms { get; set; }

        public GymViewModel()
        {
            Gyms = new GymService().GetGymPlaces();
        }
    }
}
