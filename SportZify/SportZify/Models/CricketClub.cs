using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.Models
{
    public class CricketClub
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubCity { get; set; }
        public string ClubLocation { get; set; }
        public decimal ClubCharge { get; set; }
        public string ClubImageURL { get; set; }
        public string ClubVideoURL { get; set; }
        public long ClubContact { get; set; }
        public string GameName { get; set; }
    }
}
