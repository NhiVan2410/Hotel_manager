using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// uản lý riêng các dịch vụ bổ sung liên kết với đặt phòng
    public class ReservationServiceManager
    {
        private readonly HotelDbContext _context;

        public ReservationServiceManager()
        {
            _context = new HotelDbContext();
        }

        public List<ReservationService> GetAllReservationServices()
        {
            return _context.ReservationServices.Where(rs => rs.IsDeleted ==0).ToList();
        }

        public void AddServiceToReservation(int reservationId, int serviceId, int quantity)
        {
            var reservationService = new ReservationService
            {
                ReservationID = reservationId,
                ServiceID = serviceId,
                Quantity = quantity,
                CreatedAt = DateTime.Now,
                IsDeleted = 1 // false
            };

            _context.ReservationServices.InsertOnSubmit(reservationService);
            _context.SubmitChanges();
        }
    }
}
