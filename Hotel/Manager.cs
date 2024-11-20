using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
   public  class Manager : Person
    {
        public Manager(int id, string name, string username, string password, string contactInfo)
           : base(id, name, username, password, contactInfo)
        {
        }
        // Method QLIKS
        public void ManageHotel()
        {
            Console.WriteLine("Managing the hotel...");
        }
    }
}
