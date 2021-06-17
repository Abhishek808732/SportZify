using SportZify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.Services
{
    public class GymService
    {
        public List<GymPlace> GetGymPlaces()
        {
            return new List<GymPlace>()
            {
                new GymPlace()
                {
                    GymId=1,
                    GymName="Gold's Gym",
                    GymCity="Bhilai",
                    GymLocation="Risali",
                    GymCharge=800,
                    GymImageURL="https://threebestrated.in/images/GoldsGym-Bhilai-CG.jpeg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4",
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=2,
                    GymName="Fitness 24x7",
                    GymCity="Bhilai",
                    GymLocation="Civic Centre",
                    GymCharge=2000,
                    GymImageURL="https://lh5.googleusercontent.com/-L1H-Zy5KULw/WGC8rBIuNKI/AAAAAAAADJg/ZW29AlnR7hQpjf0WS09dHv1mfU1j_1MAwCLIB/photo.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=3,
                    GymName="Steel Club",
                    GymCity="Bhilai",
                    GymLocation="Sector-8",
                    GymCharge=1000,
                    GymImageURL="https://sstc.ac.in/Mininano/photos/Infrastructure/GYM/2.JPG",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=4,
                    GymName="Workout Paradise",
                    GymCity="Durg",
                    GymLocation="Indira Nagar",
                    GymCharge=1200,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/nitrrogym_hq78.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=5,
                    GymName="World Gym-1",
                    GymCity="Bhilai",
                    GymLocation="Ispat Nagar",
                    GymCharge=600,
                    GymImageURL="https://s24526.pcdn.co/wp-content/uploads/2021/06/127137615_web1_127137615-79e70fa6cb0e4c77ac9f9aa64901ceae.jpg.optimal.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=6,
                    GymName="World Gym-2",
                    GymCity="Bhilai",
                    GymLocation="Nehru Nagar",
                    GymCharge=900,
                    GymImageURL="https://sm.askmen.com/askmen_in/photo/default/talwalkar_nzuw.jpg",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
                new GymPlace()
                {
                    GymId=7,
                    GymName="Fitness 24x7",
                    GymCity="Raipur",
                    GymLocation="Samta Colony",
                    GymCharge=1000,
                    GymImageURL="https://www.smergers.com/media/businessphoto/519625-93235257987.JPG",
                    GymVideoURL="https://www.youtube.com/embed/gey73xiS8F4" ,
                    GymContact=6666655555,
                    GameName="Gym"
                },
            };
        }
    }
}
