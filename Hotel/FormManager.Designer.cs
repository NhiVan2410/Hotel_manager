namespace Hotel
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.LblReceptionistName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabBookingMN = new System.Windows.Forms.TabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.PageCustomerMN = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PageBookingMN = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataBookingHistoryList = new System.Windows.Forms.DataGridView();
            this.LblBookingHistory = new System.Windows.Forms.Label();
            this.PageEmployeeManagement = new System.Windows.Forms.TabPage();
            this.PageRoomManagement = new System.Windows.Forms.TabPage();
            this.PageServiceManagement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GrBoxGender = new System.Windows.Forms.GroupBox();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TabBookingMN.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.PageCustomerMN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PageBookingMN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingHistoryList)).BeginInit();
            this.PageEmployeeManagement.SuspendLayout();
            this.GrBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.BtnLogout.Location = new System.Drawing.Point(1908, 121);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(115, 37);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.Text = "Log out";
            this.BtnLogout.UseVisualStyleBackColor = false;
            // 
            // LblReceptionistName
            // 
            this.LblReceptionistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReceptionistName.Location = new System.Drawing.Point(1779, 62);
            this.LblReceptionistName.Name = "LblReceptionistName";
            this.LblReceptionistName.Size = new System.Drawing.Size(253, 26);
            this.LblReceptionistName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1969, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(241, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hotel && Resort";
            // 
            // TabBookingMN
            // 
            this.TabBookingMN.Controls.Add(this.Dashboard);
            this.TabBookingMN.Controls.Add(this.PageEmployeeManagement);
            this.TabBookingMN.Controls.Add(this.PageCustomerMN);
            this.TabBookingMN.Controls.Add(this.PageBookingMN);
            this.TabBookingMN.Controls.Add(this.PageRoomManagement);
            this.TabBookingMN.Controls.Add(this.PageServiceManagement);
            this.TabBookingMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabBookingMN.ItemSize = new System.Drawing.Size(500, 34);
            this.TabBookingMN.Location = new System.Drawing.Point(237, 163);
            this.TabBookingMN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabBookingMN.Name = "TabBookingMN";
            this.TabBookingMN.SelectedIndex = 0;
            this.TabBookingMN.Size = new System.Drawing.Size(1794, 1286);
            this.TabBookingMN.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.label7);
            this.Dashboard.Location = new System.Drawing.Point(8, 42);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(1778, 1236);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = global::Hotel.Properties.Resources.icons8_neighbor_50;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(597, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(664, 71);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dashboard";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PageCustomerMN
            // 
            this.PageCustomerMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PageCustomerMN.Controls.Add(this.label5);
            this.PageCustomerMN.Controls.Add(this.label4);
            this.PageCustomerMN.Controls.Add(this.BtnSearch);
            this.PageCustomerMN.Controls.Add(this.TxtSearch);
            this.PageCustomerMN.Controls.Add(this.dataGridView1);
            this.PageCustomerMN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PageCustomerMN.Location = new System.Drawing.Point(8, 42);
            this.PageCustomerMN.Name = "PageCustomerMN";
            this.PageCustomerMN.Padding = new System.Windows.Forms.Padding(3);
            this.PageCustomerMN.Size = new System.Drawing.Size(1778, 1236);
            this.PageCustomerMN.TabIndex = 5;
            this.PageCustomerMN.Text = "CustomerMN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "CustomerManagement";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1217, 125);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(177, 45);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(489, 135);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(626, 44);
            this.TxtSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1739, 616);
            this.dataGridView1.TabIndex = 0;
            // 
            // PageBookingMN
            // 
            this.PageBookingMN.BackColor = System.Drawing.Color.OliveDrab;
            this.PageBookingMN.BackgroundImage = global::Hotel.Properties.Resources._2ecf9b191b582f7cdd650c624ca14bad;
            this.PageBookingMN.Controls.Add(this.button3);
            this.PageBookingMN.Controls.Add(this.button2);
            this.PageBookingMN.Controls.Add(this.textBox1);
            this.PageBookingMN.Controls.Add(this.label6);
            this.PageBookingMN.Controls.Add(this.DataBookingHistoryList);
            this.PageBookingMN.Controls.Add(this.LblBookingHistory);
            this.PageBookingMN.Location = new System.Drawing.Point(8, 42);
            this.PageBookingMN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageBookingMN.Name = "PageBookingMN";
            this.PageBookingMN.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageBookingMN.Size = new System.Drawing.Size(1778, 1236);
            this.PageBookingMN.TabIndex = 3;
            this.PageBookingMN.Text = "BookingMN";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(978, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit Status";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(730, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 44);
            this.textBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(482, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "ReservationID";
            // 
            // DataBookingHistoryList
            // 
            this.DataBookingHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBookingHistoryList.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DataBookingHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingHistoryList.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataBookingHistoryList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataBookingHistoryList.Location = new System.Drawing.Point(181, 456);
            this.DataBookingHistoryList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataBookingHistoryList.Name = "DataBookingHistoryList";
            this.DataBookingHistoryList.RowHeadersVisible = false;
            this.DataBookingHistoryList.RowHeadersWidth = 62;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingHistoryList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataBookingHistoryList.Size = new System.Drawing.Size(1509, 592);
            this.DataBookingHistoryList.TabIndex = 1;
            // 
            // LblBookingHistory
            // 
            this.LblBookingHistory.BackColor = System.Drawing.Color.Transparent;
            this.LblBookingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblBookingHistory.Image = global::Hotel.Properties.Resources.icons8_booking_48__1_;
            this.LblBookingHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBookingHistory.Location = new System.Drawing.Point(651, 109);
            this.LblBookingHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookingHistory.Name = "LblBookingHistory";
            this.LblBookingHistory.Size = new System.Drawing.Size(640, 83);
            this.LblBookingHistory.TabIndex = 0;
            this.LblBookingHistory.Text = "Booking Managerment";
            this.LblBookingHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageEmployeeManagement
            // 
            this.PageEmployeeManagement.Controls.Add(this.button6);
            this.PageEmployeeManagement.Controls.Add(this.button5);
            this.PageEmployeeManagement.Controls.Add(this.label9);
            this.PageEmployeeManagement.Controls.Add(this.button4);
            this.PageEmployeeManagement.Controls.Add(this.textBox2);
            this.PageEmployeeManagement.Controls.Add(this.dataGridView2);
            this.PageEmployeeManagement.Controls.Add(this.label8);
            this.PageEmployeeManagement.Controls.Add(this.button1);
            this.PageEmployeeManagement.Controls.Add(this.BtnDelete);
            this.PageEmployeeManagement.Controls.Add(this.BtnAdd);
            this.PageEmployeeManagement.Controls.Add(this.GrBoxGender);
            this.PageEmployeeManagement.Controls.Add(this.TxtAddress);
            this.PageEmployeeManagement.Controls.Add(this.TxtUserName);
            this.PageEmployeeManagement.Controls.Add(this.LblAddress);
            this.PageEmployeeManagement.Controls.Add(this.label2);
            this.PageEmployeeManagement.Controls.Add(this.LblUserName);
            this.PageEmployeeManagement.Location = new System.Drawing.Point(8, 42);
            this.PageEmployeeManagement.Name = "PageEmployeeManagement";
            this.PageEmployeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.PageEmployeeManagement.Size = new System.Drawing.Size(1778, 1236);
            this.PageEmployeeManagement.TabIndex = 7;
            this.PageEmployeeManagement.Text = "EmployeeManagement";
            this.PageEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // PageRoomManagement
            // 
            this.PageRoomManagement.Location = new System.Drawing.Point(8, 42);
            this.PageRoomManagement.Name = "PageRoomManagement";
            this.PageRoomManagement.Padding = new System.Windows.Forms.Padding(3);
            this.PageRoomManagement.Size = new System.Drawing.Size(1778, 1236);
            this.PageRoomManagement.TabIndex = 8;
            this.PageRoomManagement.Text = "RoomManagement";
            this.PageRoomManagement.UseVisualStyleBackColor = true;
            // 
            // PageServiceManagement
            // 
            this.PageServiceManagement.Location = new System.Drawing.Point(8, 42);
            this.PageServiceManagement.Name = "PageServiceManagement";
            this.PageServiceManagement.Size = new System.Drawing.Size(1778, 1236);
            this.PageServiceManagement.TabIndex = 9;
            this.PageServiceManagement.Text = "ServiceManagement";
            this.PageServiceManagement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Hotel.Properties.Resources.icons8_edit_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(690, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 61);
            this.button1.TabIndex = 22;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Image = global::Hotel.Properties.Resources.icons8_delete_24;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(1218, 470);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(403, 61);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = " Delete ";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Image = global::Hotel.Properties.Resources.icons8_add_24;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(191, 470);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(403, 61);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add ";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // GrBoxGender
            // 
            this.GrBoxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GrBoxGender.Controls.Add(this.RadFemale);
            this.GrBoxGender.Controls.Add(this.RadMale);
            this.GrBoxGender.ForeColor = System.Drawing.SystemColors.Window;
            this.GrBoxGender.Location = new System.Drawing.Point(872, 235);
            this.GrBoxGender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GrBoxGender.Name = "GrBoxGender";
            this.GrBoxGender.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GrBoxGender.Size = new System.Drawing.Size(645, 68);
            this.GrBoxGender.TabIndex = 21;
            this.GrBoxGender.TabStop = false;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadFemale.ForeColor = System.Drawing.Color.Black;
            this.RadFemale.Location = new System.Drawing.Point(431, 28);
            this.RadFemale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(181, 30);
            this.RadFemale.TabIndex = 6;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Receiptionist";
            this.RadFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMale.ForeColor = System.Drawing.Color.Black;
            this.RadMale.Location = new System.Drawing.Point(32, 28);
            this.RadMale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(135, 30);
            this.RadMale.TabIndex = 6;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Manager";
            this.RadMale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(872, 346);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(641, 44);
            this.TxtAddress.TabIndex = 17;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(872, 158);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(641, 44);
            this.TxtUserName.TabIndex = 19;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.ForeColor = System.Drawing.Color.Black;
            this.LblAddress.Location = new System.Drawing.Point(328, 357);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(232, 37);
            this.LblAddress.TabIndex = 11;
            this.LblAddress.Text = "Contact Info : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(328, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Position : ";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Black;
            this.LblUserName.Location = new System.Drawing.Point(328, 170);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(137, 37);
            this.LblUserName.TabIndex = 15;
            this.LblUserName.Text = "Name : ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Image = global::Hotel.Properties.Resources.icons8_neighbor_50;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(180, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(778, 71);
            this.label8.TabIndex = 23;
            this.label8.Text = "Employee Management";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(191, 671);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1430, 506);
            this.dataGridView2.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(992, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(446, 44);
            this.textBox2.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1486, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 44);
            this.button4.TabIndex = 26;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 580);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 37);
            this.label9.TabIndex = 27;
            this.label9.Text = "Filter by :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(746, 575);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 47);
            this.button5.TabIndex = 28;
            this.button5.Text = "Manager";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1029, 575);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(268, 47);
            this.button6.TabIndex = 29;
            this.button6.Text = "Receiptionist";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2258, 1503);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblReceptionistName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabBookingMN);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.TabBookingMN.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.PageCustomerMN.ResumeLayout(false);
            this.PageCustomerMN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PageBookingMN.ResumeLayout(false);
            this.PageBookingMN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingHistoryList)).EndInit();
            this.PageEmployeeManagement.ResumeLayout(false);
            this.PageEmployeeManagement.PerformLayout();
            this.GrBoxGender.ResumeLayout(false);
            this.GrBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LblReceptionistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabBookingMN;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage PageCustomerMN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage PageBookingMN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataBookingHistoryList;
        private System.Windows.Forms.Label LblBookingHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage PageEmployeeManagement;
        private System.Windows.Forms.TabPage PageRoomManagement;
        private System.Windows.Forms.TabPage PageServiceManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox GrBoxGender;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
    }
}