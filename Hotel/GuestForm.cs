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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet10.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter2.Fill(this.hotel_ManagerDataSet10.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet8.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.hotel_ManagerDataSet8.Services);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet7.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter1.Fill(this.hotel_ManagerDataSet7.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet6.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagerDataSet6.Room);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet5.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ManagerDataSet5.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet4.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotel_ManagerDataSet4.Guests);

        }
    }
}
