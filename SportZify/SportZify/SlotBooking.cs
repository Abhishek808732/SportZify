using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify
{
    [Table("SlotBooking")]
    class SlotBooking
    {
        [PrimaryKey, AutoIncrement]
        public int OrderId { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        [MaxLength(20)]
        public long Phone { get; set; }
        public string GameName { get; set; }
        public string CentreName { get; set; }
        public string TimeSlot { get; set; }
        public string PaymentMethod { get; set; }

    }
}
