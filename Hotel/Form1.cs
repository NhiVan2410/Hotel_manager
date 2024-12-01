using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassWord_TextChanged(object sender, EventArgs e)
        {

        }


        private bool IsEmail(string input)
        {

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, pattern);
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            string password = TxtPassWord.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new HotelDbContext())
            {
                var user = db.Persons
                             .Where(p => p.ID == username  && p.Password == password)
                             .FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsEmail(username))
                {
                    // email -> GuestForm
                    this.Hide();
                    GuestForm guestForm = new GuestForm();
                    guestForm.Show();
                }
                else if (username.StartsWith("RC"))
                {
                    // RC -> ReceptionistForm
                    this.Hide();
                    ReceptionistForm receptionistForm = new ReceptionistForm();
                    receptionistForm.Show();
                }
                else if (username.StartsWith("MN"))
                {
                    // MN -> ManagerForm
                    this.Hide();
                    FormManager managerForm = new FormManager();
                    managerForm.Show();
                }
                else
                {
                    MessageBox.Show("Không thể phân quyền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
