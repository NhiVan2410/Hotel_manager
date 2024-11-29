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
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet31.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter1.Fill(this.hotel_ManagerDataSet31.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet20.ReservationServices' table. You can move, or remove it, as needed.
            this.reservationServicesTableAdapter2.Fill(this.hotel_ManagerDataSet20.ReservationServices);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet19.ReservationServices' table. You can move, or remove it, as needed.
            this.reservationServicesTableAdapter1.Fill(this.hotel_ManagerDataSet19.ReservationServices);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet18.ReservationServices' table. You can move, or remove it, as needed.
            this.reservationServicesTableAdapter.Fill(this.hotel_ManagerDataSet18.ReservationServices);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet17.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.hotel_ManagerDataSet17.Services);

            // TODO: This line of code loads data into the 'hotel_ManagerDataSet14.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagerDataSet14.Room);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet13.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ManagerDataSet13.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet12.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotel_ManagerDataSet12.Guests);

        }
    }
}
