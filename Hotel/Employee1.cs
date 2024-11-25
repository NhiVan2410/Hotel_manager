using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Employee1 : Person1
    {   
        public string Position { get; set; }
        public string Password { get; set; }
        public string ContactInfo { get; set; }
        public bool IsDeleted { get; set; }
    }

}
