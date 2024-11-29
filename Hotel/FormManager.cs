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
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet25.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ManagerDataSet25.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet24.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotel_ManagerDataSet24.Guests);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet23.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hotel_ManagerDataSet23.Employees);

        }
    }
}
