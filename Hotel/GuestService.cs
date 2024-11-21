using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class GuestService // quản lí Guest từ linQ add vào
    {
        private readonly HotelDbContext _context;

        public GuestService()
        {
            _context = new HotelDbContext();
        }

        public List<Guest> GetAllGuests()
        {
            return _context.Guests.Where(g => g.IsDeleted == false).ToList();
        }

        public void AddGuest(Guest guest)
        {
            _context.Guests.InsertOnSubmit(guest);
            _context.SubmitChanges();
        }

        public void DeleteGuest(int guestId)
        {
            var guest = _context.Guests.FirstOrDefault(g => g.GuestID == guestId);
            if (guest != null)
            {
                guest.IsDeleted = true;
                _context.SubmitChanges();
            }
        }
    }
}
