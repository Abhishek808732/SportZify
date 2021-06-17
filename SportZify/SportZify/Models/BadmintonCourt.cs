using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.Models
{
    public class BadmintonCourt
    {
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CourtCity { get; set; }
        public string CourtLocation { get; set; }
        public decimal CourtCharge { get; set; }
        public string CourtImageURL { get; set; }
        public string CourtVideoURL { get; set; }
        public long CourtContact { get; set; }
        public string GameName { get; set; }

    }
}
