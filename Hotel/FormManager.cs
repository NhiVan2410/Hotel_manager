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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet32.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter1.Fill(this.hotel_ManagerDataSet32.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet28.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.hotel_ManagerDataSet28.Services);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet27.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagerDataSet27.Room);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet26.ReservationServices' table. You can move, or remove it, as needed.
            this.reservationServicesTableAdapter.Fill(this.hotel_ManagerDataSet26.ReservationServices);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet25.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ManagerDataSet25.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet24.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotel_ManagerDataSet24.Guests);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet23.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hotel_ManagerDataSet23.Employees);

        }
    }
}
