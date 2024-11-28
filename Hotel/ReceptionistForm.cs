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
           
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet14.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagerDataSet14.Room);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet13.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.hotel_ManagerDataSet13.Reservations);
            // TODO: This line of code loads data into the 'hotel_ManagerDataSet12.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotel_ManagerDataSet12.Guests);

        }
    }
}
