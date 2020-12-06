using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTestAppointment.Models
{
    public class TestAppointment
    {
        public int BookingId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PaymentType { get; set; }
    }
}
