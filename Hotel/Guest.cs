using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet3.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.hotel_ManagerDataSet3.Services);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet2.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagerDataSet2.Room);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet1.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ManagerDataSet1.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotel_ManagerDataSet.Guests);

        }
    }
}
