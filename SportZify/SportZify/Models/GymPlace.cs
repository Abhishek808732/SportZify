using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify.Models
{
    public class GymPlace
    {
        public int GymId { get; set; }
        public string GymName { get; set; }
        public string GymCity { get; set; }
        public string GymLocation { get; set; }
        public decimal GymCharge { get; set; }
        public string GymImageURL { get; set; }
        public string GymVideoURL { get; set; }
        public long GymContact { get; set; }
        public string GameName { get; set; }
    }
}
