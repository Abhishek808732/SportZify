using SportZify.Models;
using SportZify.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.ViewModels
{
    public class CricketViewModel: BaseViewModel
    {
        public List<CricketClub> Clubs { get; set; }

        public CricketViewModel()
        {
            Clubs = new CricketService().GetCricketClubs();
        }
    }
}
