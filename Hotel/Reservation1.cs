using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel
{
    public class Reservation1
    {
        public void AddReservation(AddReservation1 reservation1)
        {
            using (var context = new HotelDbContext())
            {
                var reservation = new servation // viết lộn reservation == servation
                {
                    GuestID = reservation1.GuestID,
                    RoomID = reservation1.RoomID,
                    BookingDate = reservation1.BookingDate,
                    CheckInDate = reservation1.CheckInDate,
                    CheckOutDate = reservation1.CheckOutDate,
                    Feedback = reservation1.Feedback,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = 0 // Đặt mặc định là chưa bị xóa
                };

                context.Reservations.InsertOnSubmit(reservation);
                context.SubmitChanges();
            }
        }
        // lấy danh sách Servation
        public IQueryable<servation> GetReservations()
        {
            using (var context = new HotelDbContext())
            {
                return context.Reservations.Where(r => r.IsDeleted == 0);
            }
        }
        public IQueryable<servation> GetReservationsByGuest(int guestId)
        {
            using (var context = new HotelDbContext())
            {
                return context.Reservations.Where(r => r.GuestID == guestId && r.IsDeleted == 0);
            }
        }
        public void Updateservation(int reservationId, DateTime checkInDate, DateTime checkOutDate, string feedback)
        {
            using (var context = new HotelDbContext())
            {
                var reservation = context.Reservations.FirstOrDefault(r => r.ReservationID == reservationId);
                if (reservation != null)
                {
                    reservation.CheckInDate = checkInDate;
                    reservation.CheckOutDate = checkOutDate;
                    reservation.Feedback = feedback;
                    reservation.UpdatedAt = DateTime.Now;

                    context.SubmitChanges();
                }
            }
        }
    }
    }
        
           
   
        

