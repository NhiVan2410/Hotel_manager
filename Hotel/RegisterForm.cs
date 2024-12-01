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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            // Set the form's size
            this.Size = new Size(1030, 1200); // Width: 800, Height: 600

        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // 1. Validate inputs
            if (!ValidateInputs())
            {
                return;
            }

            // 2. Lấy dữ liệu từ các điều khiển
            var name = TxtUserNameRegister.Text;
            var password = TxtPassWordRegister.Text;
            var gender = GetSelectedGender();
            var dateOfBirth = FormatDateForSQL(DTPickerRegister.Value);
            var phoneNumber = TxtPhoneNumberRegister.Text;
            var address = TxtAddressRegister.Text;
            var email = TxtEmailRegister.Text;

            // 3. Thêm dữ liệu vào database
            using (var context = new HotelDbContext())
            {
                try
                {
                    if (context.Persons.Any(p => p.Email == email))
                    {
                        MessageBox.Show("Email đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Thêm vào bảng Person
                    var person = new Person
                    {
                        Password = password,
                        ID = email,
                        Name = name,
                        Gender = gender,
                        DateOfBirth = DateTime.Parse(dateOfBirth),
                        PhoneNumber = phoneNumber,
                        Address = address,
                        Email = email,
                   
                    };
                    context.Persons.InsertOnSubmit(person);
                    context.SubmitChanges();

                    var guest = new Guest
                    {
                        ID = email,
                        Password = password // Gán mật khẩu vào Guest
                    };
                    context.Guests.InsertOnSubmit(guest);
                    context.SubmitChanges();


                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateInputs()
        {
            // Kiểm tra tên (chỉ chữ cái)
            if (!Regex.IsMatch(TxtUserNameRegister.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Tên phải chứa các chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra số điện thoại (10 số)
            if (!Regex.IsMatch(TxtPhoneNumberRegister.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra email
            if (!Regex.IsMatch(TxtEmailRegister.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra password
            if (TxtPassWordRegister.Text != TxtSubmitPassWordRegister.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtPassWordRegister.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private string GetSelectedGender()
        {
            foreach (var control in GrBxGenderRegister.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // Trả về text của radio button được chọn
                }
            }
            return null;
        }

        private string FormatDateForSQL(DateTime date)
        {
            return date.ToString("yyyy/MM/dd"); // Định dạng yyyy/MM/dd
        }

        private void TxtPassWordRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubmitPassWordRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassWordRegister_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }



 

