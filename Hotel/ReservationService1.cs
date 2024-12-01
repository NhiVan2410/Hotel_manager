using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class ReservationService1
    {
        public int ReservationServiceID { get; set; }
        public int ReservationID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public string  GuestID { get; set; }
        public int Bill { get; set; }

        // kết nối 
        public Reservations1 Reservation { get; set; }
        public Service1 Service { get; set; }
    }
}
