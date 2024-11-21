using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class BookingService // quản lí bookingg
    {
        private readonly HotelDbContext _context;

        public BookingService()
        {
            _context = new HotelDbContext();
        }

        public List<Reservation> GetAllReservations()
        {
            return _context.Reservations.Where(r => r.IsDeleted == 0).ToList();
        }

        public void AddReservation(Reservation reservation)
        {
            _context.Reservations.InsertOnSubmit(reservation);
            _context.SubmitChanges();
        }

        public void UpdateReservation(Reservation updatedReservation)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationID == updatedReservation.ReservationID);
            if (reservation != null)
            {
                reservation.CheckInDate = updatedReservation.CheckInDate;
                reservation.CheckOutDate = updatedReservation.CheckOutDate;
                _context.SubmitChanges();
            }
        }
    }
}
