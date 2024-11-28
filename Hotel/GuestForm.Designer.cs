﻿using Hotel.Hotel_ManagerDataSet4TableAdapters;

namespace Hotel
{
    partial class GuestForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabRequestServices = new System.Windows.Forms.TabControl();
            this.PageCustomerInformation = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GrBoxGender = new System.Windows.Forms.GroupBox();
            this.RadOther = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.DataCustomerList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet4 = new Hotel.Hotel_ManagerDataSet4();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblGuestInformation = new System.Windows.Forms.Label();
            this.PageBookng = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataBookingList = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet5 = new Hotel.Hotel_ManagerDataSet5();
            this.BtnEditBooking = new System.Windows.Forms.Button();
            this.BtnCancelBooking = new System.Windows.Forms.Button();
            this.BtnAddBooking = new System.Windows.Forms.Button();
            this.DtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.DtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.CmbRoom = new System.Windows.Forms.ComboBox();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.LblRoom = new System.Windows.Forms.Label();
            this.LblCheckIn = new System.Windows.Forms.Label();
            this.LblCheckOut = new System.Windows.Forms.Label();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.LblBooking = new System.Windows.Forms.Label();
            this.PageViewRoom = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAvliableRooms = new System.Windows.Forms.Button();
            this.DataViewRoomList = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet6 = new Hotel.Hotel_ManagerDataSet6();
            this.LblViewRoom = new System.Windows.Forms.Label();
            this.PageBookingHistory = new System.Windows.Forms.TabPage();
            this.BtnEditFeedBack = new System.Windows.Forms.Button();
            this.DataBookingHistoryList = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet7 = new Hotel.Hotel_ManagerDataSet7();
            this.LblBookingHistory = new System.Windows.Forms.Label();
            this.PageRequestServices = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnAddServices = new System.Windows.Forms.Button();
            this.DataRequestServices = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet8 = new Hotel.Hotel_ManagerDataSet8();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.CmbServices = new System.Windows.Forms.ComboBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblService = new System.Windows.Forms.Label();
            this.LblRequestServices = new System.Windows.Forms.Label();
            this.hotel_ManagerDataSet = new Hotel.Hotel_ManagerDataSet();
            this.hotelManagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Hotel.Hotel_ManagerDataSet4TableAdapters.GuestsTableAdapter();
            this.reservationsTableAdapter = new Hotel.Hotel_ManagerDataSet5TableAdapters.ReservationsTableAdapter();
            this.roomTableAdapter = new Hotel.Hotel_ManagerDataSet6TableAdapters.RoomTableAdapter();
            this.reservationsTableAdapter1 = new Hotel.Hotel_ManagerDataSet7TableAdapters.ReservationsTableAdapter();
            this.servicesTableAdapter = new Hotel.Hotel_ManagerDataSet8TableAdapters.ServicesTableAdapter();
            this.TabRequestServices.SuspendLayout();
            this.PageCustomerInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet4)).BeginInit();
            this.PageBookng.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet5)).BeginInit();
            this.PageViewRoom.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet6)).BeginInit();
            this.PageBookingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingHistoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet7)).BeginInit();
            this.PageRequestServices.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataRequestServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabRequestServices
            // 
            this.TabRequestServices.Controls.Add(this.PageCustomerInformation);
            this.TabRequestServices.Controls.Add(this.PageBookng);
            this.TabRequestServices.Controls.Add(this.PageViewRoom);
            this.TabRequestServices.Controls.Add(this.PageBookingHistory);
            this.TabRequestServices.Controls.Add(this.PageRequestServices);
            this.TabRequestServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabRequestServices.Location = new System.Drawing.Point(144, 60);
            this.TabRequestServices.Name = "TabRequestServices";
            this.TabRequestServices.SelectedIndex = 0;
            this.TabRequestServices.Size = new System.Drawing.Size(1196, 840);
            this.TabRequestServices.TabIndex = 1;
            // 
            // PageCustomerInformation
            // 
            this.PageCustomerInformation.BackColor = System.Drawing.Color.Lime;
            this.PageCustomerInformation.BackgroundImage = global::Hotel.Properties.Resources._0e83fe416785d8c995f664d65a68a73e;
            this.PageCustomerInformation.Controls.Add(this.groupBox1);
            this.PageCustomerInformation.ForeColor = System.Drawing.Color.Silver;
            this.PageCustomerInformation.Location = new System.Drawing.Point(4, 29);
            this.PageCustomerInformation.Name = "PageCustomerInformation";
            this.PageCustomerInformation.Padding = new System.Windows.Forms.Padding(3);
            this.PageCustomerInformation.Size = new System.Drawing.Size(1188, 807);
            this.PageCustomerInformation.TabIndex = 0;
            this.PageCustomerInformation.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.GrBoxGender);
            this.groupBox1.Controls.Add(this.DataCustomerList);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.TxtPhoneNumber);
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.LblAddress);
            this.groupBox1.Controls.Add(this.LblPhoneNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Controls.Add(this.LblUserName);
            this.groupBox1.Controls.Add(this.LblGuestInformation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 801);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Hotel.Properties.Resources.icons8_edit_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(771, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Image = global::Hotel.Properties.Resources.icons8_delete_24;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(771, 434);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(201, 41);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = " Delete ";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnUpdate.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdate.Image = global::Hotel.Properties.Resources.icons8_installing_updates_32;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.Location = new System.Drawing.Point(771, 340);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(201, 41);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Image = global::Hotel.Properties.Resources.icons8_add_24;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(771, 142);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(201, 41);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add ";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // GrBoxGender
            // 
            this.GrBoxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GrBoxGender.Controls.Add(this.RadOther);
            this.GrBoxGender.Controls.Add(this.RadFemale);
            this.GrBoxGender.Controls.Add(this.RadMale);
            this.GrBoxGender.ForeColor = System.Drawing.SystemColors.Window;
            this.GrBoxGender.Location = new System.Drawing.Point(320, 168);
            this.GrBoxGender.Name = "GrBoxGender";
            this.GrBoxGender.Size = new System.Drawing.Size(323, 35);
            this.GrBoxGender.TabIndex = 5;
            this.GrBoxGender.TabStop = false;
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadOther.ForeColor = System.Drawing.Color.Black;
            this.RadOther.Location = new System.Drawing.Point(232, 14);
            this.RadOther.Name = "RadOther";
            this.RadOther.Size = new System.Drawing.Size(56, 17);
            this.RadOther.TabIndex = 6;
            this.RadOther.TabStop = true;
            this.RadOther.Text = "Other";
            this.RadOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadOther.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadFemale.ForeColor = System.Drawing.Color.Black;
            this.RadFemale.Location = new System.Drawing.Point(118, 15);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(65, 17);
            this.RadFemale.TabIndex = 6;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMale.ForeColor = System.Drawing.Color.Black;
            this.RadMale.Location = new System.Drawing.Point(16, 14);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(52, 17);
            this.RadMale.TabIndex = 6;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // DataCustomerList
            // 
            this.DataCustomerList.AutoGenerateColumns = false;
            this.DataCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCustomerList.BackgroundColor = System.Drawing.Color.Linen;
            this.DataCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DataCustomerList.DataSource = this.guestsBindingSource;
            this.DataCustomerList.Location = new System.Drawing.Point(229, 557);
            this.DataCustomerList.Name = "DataCustomerList";
            this.DataCustomerList.RowHeadersVisible = false;
            this.DataCustomerList.RowHeadersWidth = 62;
            this.DataCustomerList.RowTemplate.Height = 28;
            this.DataCustomerList.Size = new System.Drawing.Size(765, 150);
            this.DataCustomerList.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.hotel_ManagerDataSet4;
            // 
            // hotel_ManagerDataSet4
            // 
            this.hotel_ManagerDataSet4.DataSetName = "Hotel_ManagerDataSet4";
            this.hotel_ManagerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(320, 475);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(323, 26);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(320, 399);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(323, 26);
            this.TxtAddress.TabIndex = 2;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(320, 318);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(323, 26);
            this.TxtPhoneNumber.TabIndex = 2;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(320, 107);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(323, 26);
            this.TxtUserName.TabIndex = 2;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblEmail.Location = new System.Drawing.Point(48, 481);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(68, 20);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email : ";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblAddress.Location = new System.Drawing.Point(48, 405);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(90, 20);
            this.LblAddress.TabIndex = 1;
            this.LblAddress.Text = "Address : ";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumber.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblPhoneNumber.Location = new System.Drawing.Point(48, 321);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(142, 20);
            this.LblPhoneNumber.TabIndex = 1;
            this.LblPhoneNumber.Text = "Phone Number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(48, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender : ";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblDate.Location = new System.Drawing.Point(48, 255);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(120, 20);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "Date of birth :";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblUserName.Location = new System.Drawing.Point(48, 113);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(70, 20);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Name : ";
            // 
            // LblGuestInformation
            // 
            this.LblGuestInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuestInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblGuestInformation.Image = global::Hotel.Properties.Resources.icons8_neighbor_50;
            this.LblGuestInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblGuestInformation.Location = new System.Drawing.Point(349, 31);
            this.LblGuestInformation.Name = "LblGuestInformation";
            this.LblGuestInformation.Size = new System.Drawing.Size(443, 46);
            this.LblGuestInformation.TabIndex = 0;
            this.LblGuestInformation.Text = "Guest Information";
            this.LblGuestInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBookng
            // 
            this.PageBookng.BackgroundImage = global::Hotel.Properties.Resources._9689e526b6e6b1ac527e8e436d797dbb;
            this.PageBookng.Controls.Add(this.groupBox2);
            this.PageBookng.Location = new System.Drawing.Point(4, 29);
            this.PageBookng.Name = "PageBookng";
            this.PageBookng.Padding = new System.Windows.Forms.Padding(3);
            this.PageBookng.Size = new System.Drawing.Size(1188, 807);
            this.PageBookng.TabIndex = 1;
            this.PageBookng.Text = "Booking";
            this.PageBookng.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataBookingList);
            this.groupBox2.Controls.Add(this.BtnEditBooking);
            this.groupBox2.Controls.Add(this.BtnCancelBooking);
            this.groupBox2.Controls.Add(this.BtnAddBooking);
            this.groupBox2.Controls.Add(this.DtpCheckIn);
            this.groupBox2.Controls.Add(this.DtpCheckOut);
            this.groupBox2.Controls.Add(this.CmbRoom);
            this.groupBox2.Controls.Add(this.CmbCustomer);
            this.groupBox2.Controls.Add(this.LblRoom);
            this.groupBox2.Controls.Add(this.LblCheckIn);
            this.groupBox2.Controls.Add(this.LblCheckOut);
            this.groupBox2.Controls.Add(this.LblCustomer);
            this.groupBox2.Controls.Add(this.LblBooking);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 801);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // DataBookingList
            // 
            this.DataBookingList.AutoGenerateColumns = false;
            this.DataBookingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataBookingList.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBookingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn});
            this.DataBookingList.DataSource = this.reservationsBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingList.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataBookingList.Location = new System.Drawing.Point(219, 488);
            this.DataBookingList.Name = "DataBookingList";
            this.DataBookingList.RowHeadersVisible = false;
            this.DataBookingList.RowHeadersWidth = 30;
            this.DataBookingList.RowTemplate.Height = 28;
            this.DataBookingList.Size = new System.Drawing.Size(724, 163);
            this.DataBookingList.TabIndex = 1;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 136;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 127;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.Width = 128;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.Width = 140;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.hotel_ManagerDataSet5;
            // 
            // hotel_ManagerDataSet5
            // 
            this.hotel_ManagerDataSet5.DataSetName = "Hotel_ManagerDataSet5";
            this.hotel_ManagerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnEditBooking
            // 
            this.BtnEditBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEditBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEditBooking.Image = global::Hotel.Properties.Resources.icons8_edit_26;
            this.BtnEditBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditBooking.Location = new System.Drawing.Point(817, 223);
            this.BtnEditBooking.Name = "BtnEditBooking";
            this.BtnEditBooking.Size = new System.Drawing.Size(206, 44);
            this.BtnEditBooking.TabIndex = 4;
            this.BtnEditBooking.Text = "Edit";
            this.BtnEditBooking.UseVisualStyleBackColor = false;
            // 
            // BtnCancelBooking
            // 
            this.BtnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCancelBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCancelBooking.Image = global::Hotel.Properties.Resources.icons8_delete_24;
            this.BtnCancelBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelBooking.Location = new System.Drawing.Point(817, 315);
            this.BtnCancelBooking.Name = "BtnCancelBooking";
            this.BtnCancelBooking.Size = new System.Drawing.Size(206, 44);
            this.BtnCancelBooking.TabIndex = 4;
            this.BtnCancelBooking.Text = "Cancel";
            this.BtnCancelBooking.UseVisualStyleBackColor = false;
            // 
            // BtnAddBooking
            // 
            this.BtnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAddBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAddBooking.Image = global::Hotel.Properties.Resources.icons8_add_24;
            this.BtnAddBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddBooking.Location = new System.Drawing.Point(817, 136);
            this.BtnAddBooking.Name = "BtnAddBooking";
            this.BtnAddBooking.Size = new System.Drawing.Size(206, 44);
            this.BtnAddBooking.TabIndex = 4;
            this.BtnAddBooking.Text = "Add";
            this.BtnAddBooking.UseVisualStyleBackColor = false;
            // 
            // DtpCheckIn
            // 
            this.DtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckIn.Location = new System.Drawing.Point(317, 273);
            this.DtpCheckIn.Name = "DtpCheckIn";
            this.DtpCheckIn.Size = new System.Drawing.Size(339, 23);
            this.DtpCheckIn.TabIndex = 3;
            // 
            // DtpCheckOut
            // 
            this.DtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckOut.Location = new System.Drawing.Point(317, 362);
            this.DtpCheckOut.Name = "DtpCheckOut";
            this.DtpCheckOut.Size = new System.Drawing.Size(339, 23);
            this.DtpCheckOut.TabIndex = 3;
            // 
            // CmbRoom
            // 
            this.CmbRoom.FormattingEnabled = true;
            this.CmbRoom.Location = new System.Drawing.Point(317, 193);
            this.CmbRoom.Name = "CmbRoom";
            this.CmbRoom.Size = new System.Drawing.Size(339, 28);
            this.CmbRoom.TabIndex = 2;
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(317, 119);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(339, 28);
            this.CmbCustomer.TabIndex = 2;
            // 
            // LblRoom
            // 
            this.LblRoom.AutoSize = true;
            this.LblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoom.ForeColor = System.Drawing.Color.Bisque;
            this.LblRoom.Location = new System.Drawing.Point(99, 201);
            this.LblRoom.Name = "LblRoom";
            this.LblRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblRoom.Size = new System.Drawing.Size(71, 20);
            this.LblRoom.TabIndex = 1;
            this.LblRoom.Text = "Room : ";
            // 
            // LblCheckIn
            // 
            this.LblCheckIn.AutoSize = true;
            this.LblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckIn.ForeColor = System.Drawing.Color.Bisque;
            this.LblCheckIn.Location = new System.Drawing.Point(99, 279);
            this.LblCheckIn.Name = "LblCheckIn";
            this.LblCheckIn.Size = new System.Drawing.Size(95, 20);
            this.LblCheckIn.TabIndex = 1;
            this.LblCheckIn.Text = "Check In : ";
            // 
            // LblCheckOut
            // 
            this.LblCheckOut.AutoSize = true;
            this.LblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckOut.ForeColor = System.Drawing.Color.Bisque;
            this.LblCheckOut.Location = new System.Drawing.Point(99, 362);
            this.LblCheckOut.Name = "LblCheckOut";
            this.LblCheckOut.Size = new System.Drawing.Size(108, 20);
            this.LblCheckOut.TabIndex = 1;
            this.LblCheckOut.Text = "Check Out : ";
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblCustomer.ForeColor = System.Drawing.Color.Bisque;
            this.LblCustomer.Location = new System.Drawing.Point(99, 127);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(96, 20);
            this.LblCustomer.TabIndex = 1;
            this.LblCustomer.Text = "Customer :";
            // 
            // LblBooking
            // 
            this.LblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBooking.ForeColor = System.Drawing.Color.Bisque;
            this.LblBooking.Image = global::Hotel.Properties.Resources.icons8_booking_48;
            this.LblBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBooking.Location = new System.Drawing.Point(420, 31);
            this.LblBooking.Name = "LblBooking";
            this.LblBooking.Size = new System.Drawing.Size(271, 46);
            this.LblBooking.TabIndex = 0;
            this.LblBooking.Text = "Booking";
            this.LblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageViewRoom
            // 
            this.PageViewRoom.BackgroundImage = global::Hotel.Properties.Resources.aea3013e3c66280a50d37ff741d47eb7;
            this.PageViewRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageViewRoom.Controls.Add(this.groupBox3);
            this.PageViewRoom.Location = new System.Drawing.Point(4, 29);
            this.PageViewRoom.Name = "PageViewRoom";
            this.PageViewRoom.Padding = new System.Windows.Forms.Padding(3);
            this.PageViewRoom.Size = new System.Drawing.Size(1188, 807);
            this.PageViewRoom.TabIndex = 2;
            this.PageViewRoom.Text = "ViewRoom";
            this.PageViewRoom.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAvliableRooms);
            this.groupBox3.Controls.Add(this.DataViewRoomList);
            this.groupBox3.Controls.Add(this.LblViewRoom);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1182, 801);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // BtnAvliableRooms
            // 
            this.BtnAvliableRooms.AutoSize = true;
            this.BtnAvliableRooms.BackColor = System.Drawing.Color.Cornsilk;
            this.BtnAvliableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvliableRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAvliableRooms.Image = global::Hotel.Properties.Resources.icons8_check_mark_48;
            this.BtnAvliableRooms.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAvliableRooms.Location = new System.Drawing.Point(456, 526);
            this.BtnAvliableRooms.Name = "BtnAvliableRooms";
            this.BtnAvliableRooms.Size = new System.Drawing.Size(276, 54);
            this.BtnAvliableRooms.TabIndex = 1;
            this.BtnAvliableRooms.Text = "Available Rooms";
            this.BtnAvliableRooms.UseVisualStyleBackColor = false;
            // 
            // DataViewRoomList
            // 
            this.DataViewRoomList.AutoGenerateColumns = false;
            this.DataViewRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewRoomList.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DataViewRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn1,
            this.roomTypeDataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewTextBoxColumn});
            this.DataViewRoomList.DataSource = this.roomBindingSource;
            this.DataViewRoomList.GridColor = System.Drawing.Color.Cornsilk;
            this.DataViewRoomList.Location = new System.Drawing.Point(137, 198);
            this.DataViewRoomList.Name = "DataViewRoomList";
            this.DataViewRoomList.RowHeadersVisible = false;
            this.DataViewRoomList.RowHeadersWidth = 68;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewRoomList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataViewRoomList.RowTemplate.Height = 28;
            this.DataViewRoomList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewRoomList.Size = new System.Drawing.Size(919, 287);
            this.DataViewRoomList.TabIndex = 2;
            // 
            // roomIDDataGridViewTextBoxColumn1
            // 
            this.roomIDDataGridViewTextBoxColumn1.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.Name = "roomIDDataGridViewTextBoxColumn1";
            this.roomIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            // 
            // isAvailableDataGridViewTextBoxColumn
            // 
            this.isAvailableDataGridViewTextBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.HeaderText = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.Name = "isAvailableDataGridViewTextBoxColumn";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotel_ManagerDataSet6;
            // 
            // hotel_ManagerDataSet6
            // 
            this.hotel_ManagerDataSet6.DataSetName = "Hotel_ManagerDataSet6";
            this.hotel_ManagerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblViewRoom
            // 
            this.LblViewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblViewRoom.Image = global::Hotel.Properties.Resources.icons8_view_50__1_;
            this.LblViewRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblViewRoom.Location = new System.Drawing.Point(455, 31);
            this.LblViewRoom.Name = "LblViewRoom";
            this.LblViewRoom.Size = new System.Drawing.Size(277, 53);
            this.LblViewRoom.TabIndex = 0;
            this.LblViewRoom.Text = "View Room";
            this.LblViewRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBookingHistory
            // 
            this.PageBookingHistory.BackColor = System.Drawing.Color.OliveDrab;
            this.PageBookingHistory.BackgroundImage = global::Hotel.Properties.Resources._2ecf9b191b582f7cdd650c624ca14bad;
            this.PageBookingHistory.Controls.Add(this.BtnEditFeedBack);
            this.PageBookingHistory.Controls.Add(this.DataBookingHistoryList);
            this.PageBookingHistory.Controls.Add(this.LblBookingHistory);
            this.PageBookingHistory.Location = new System.Drawing.Point(4, 29);
            this.PageBookingHistory.Name = "PageBookingHistory";
            this.PageBookingHistory.Padding = new System.Windows.Forms.Padding(3);
            this.PageBookingHistory.Size = new System.Drawing.Size(1188, 807);
            this.PageBookingHistory.TabIndex = 3;
            this.PageBookingHistory.Text = "BookingHistory";
            // 
            // BtnEditFeedBack
            // 
            this.BtnEditFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditFeedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEditFeedBack.Image = global::Hotel.Properties.Resources.icons8_feedback_48;
            this.BtnEditFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditFeedBack.Location = new System.Drawing.Point(442, 606);
            this.BtnEditFeedBack.Name = "BtnEditFeedBack";
            this.BtnEditFeedBack.Size = new System.Drawing.Size(346, 64);
            this.BtnEditFeedBack.TabIndex = 2;
            this.BtnEditFeedBack.Text = "Edit FeedBack";
            this.BtnEditFeedBack.UseVisualStyleBackColor = true;
            // 
            // DataBookingHistoryList
            // 
            this.DataBookingHistoryList.AutoGenerateColumns = false;
            this.DataBookingHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBookingHistoryList.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DataBookingHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBookingHistoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn1,
            this.guestIDDataGridViewTextBoxColumn1,
            this.roomIDDataGridViewTextBoxColumn2,
            this.bookingDateDataGridViewTextBoxColumn1,
            this.checkInDateDataGridViewTextBoxColumn1,
            this.checkOutDateDataGridViewTextBoxColumn1,
            this.feedbackDataGridViewTextBoxColumn});
            this.DataBookingHistoryList.DataSource = this.reservationsBindingSource1;
            this.DataBookingHistoryList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataBookingHistoryList.Location = new System.Drawing.Point(170, 183);
            this.DataBookingHistoryList.Name = "DataBookingHistoryList";
            this.DataBookingHistoryList.RowHeadersVisible = false;
            this.DataBookingHistoryList.RowHeadersWidth = 62;
            this.DataBookingHistoryList.Size = new System.Drawing.Size(840, 385);
            this.DataBookingHistoryList.TabIndex = 1;
            // 
            // reservationIDDataGridViewTextBoxColumn1
            // 
            this.reservationIDDataGridViewTextBoxColumn1.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn1.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn1.Name = "reservationIDDataGridViewTextBoxColumn1";
            this.reservationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn1
            // 
            this.guestIDDataGridViewTextBoxColumn1.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn1.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn1.Name = "guestIDDataGridViewTextBoxColumn1";
            // 
            // roomIDDataGridViewTextBoxColumn2
            // 
            this.roomIDDataGridViewTextBoxColumn2.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn2.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn2.Name = "roomIDDataGridViewTextBoxColumn2";
            // 
            // bookingDateDataGridViewTextBoxColumn1
            // 
            this.bookingDateDataGridViewTextBoxColumn1.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn1.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn1.Name = "bookingDateDataGridViewTextBoxColumn1";
            // 
            // checkInDateDataGridViewTextBoxColumn1
            // 
            this.checkInDateDataGridViewTextBoxColumn1.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn1.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn1.Name = "checkInDateDataGridViewTextBoxColumn1";
            // 
            // checkOutDateDataGridViewTextBoxColumn1
            // 
            this.checkOutDateDataGridViewTextBoxColumn1.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn1.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn1.Name = "checkOutDateDataGridViewTextBoxColumn1";
            // 
            // feedbackDataGridViewTextBoxColumn
            // 
            this.feedbackDataGridViewTextBoxColumn.DataPropertyName = "Feedback";
            this.feedbackDataGridViewTextBoxColumn.HeaderText = "Feedback";
            this.feedbackDataGridViewTextBoxColumn.Name = "feedbackDataGridViewTextBoxColumn";
            // 
            // reservationsBindingSource1
            // 
            this.reservationsBindingSource1.DataMember = "Reservations";
            this.reservationsBindingSource1.DataSource = this.hotel_ManagerDataSet7;
            // 
            // hotel_ManagerDataSet7
            // 
            this.hotel_ManagerDataSet7.DataSetName = "Hotel_ManagerDataSet7";
            this.hotel_ManagerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblBookingHistory
            // 
            this.LblBookingHistory.BackColor = System.Drawing.Color.Transparent;
            this.LblBookingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblBookingHistory.Image = global::Hotel.Properties.Resources.icons8_booking_48__1_;
            this.LblBookingHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBookingHistory.Location = new System.Drawing.Point(434, 71);
            this.LblBookingHistory.Name = "LblBookingHistory";
            this.LblBookingHistory.Size = new System.Drawing.Size(427, 54);
            this.LblBookingHistory.TabIndex = 0;
            this.LblBookingHistory.Text = "Booking History";
            this.LblBookingHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageRequestServices
            // 
            this.PageRequestServices.BackgroundImage = global::Hotel.Properties.Resources.b84517d81f7ee3cb0ceff696c74e91b5;
            this.PageRequestServices.Controls.Add(this.groupBox4);
            this.PageRequestServices.Location = new System.Drawing.Point(4, 29);
            this.PageRequestServices.Name = "PageRequestServices";
            this.PageRequestServices.Padding = new System.Windows.Forms.Padding(3);
            this.PageRequestServices.Size = new System.Drawing.Size(1188, 807);
            this.PageRequestServices.TabIndex = 4;
            this.PageRequestServices.Text = "Request Services";
            this.PageRequestServices.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnAddServices);
            this.groupBox4.Controls.Add(this.DataRequestServices);
            this.groupBox4.Controls.Add(this.NumQuantity);
            this.groupBox4.Controls.Add(this.CmbServices);
            this.groupBox4.Controls.Add(this.LblQuantity);
            this.groupBox4.Controls.Add(this.LblService);
            this.groupBox4.Controls.Add(this.LblRequestServices);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1182, 801);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // BtnAddServices
            // 
            this.BtnAddServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddServices.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnAddServices.Image = global::Hotel.Properties.Resources.icons8_add_48;
            this.BtnAddServices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddServices.Location = new System.Drawing.Point(894, 186);
            this.BtnAddServices.Name = "BtnAddServices";
            this.BtnAddServices.Size = new System.Drawing.Size(220, 53);
            this.BtnAddServices.TabIndex = 6;
            this.BtnAddServices.Text = "Add";
            this.BtnAddServices.UseVisualStyleBackColor = true;
            // 
            // DataRequestServices
            // 
            this.DataRequestServices.AutoGenerateColumns = false;
            this.DataRequestServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataRequestServices.BackgroundColor = System.Drawing.Color.White;
            this.DataRequestServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRequestServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.Quantity,
            this.servicePriceDataGridViewTextBoxColumn});
            this.DataRequestServices.DataSource = this.servicesBindingSource;
            this.DataRequestServices.Location = new System.Drawing.Point(328, 381);
            this.DataRequestServices.Name = "DataRequestServices";
            this.DataRequestServices.RowHeadersVisible = false;
            this.DataRequestServices.RowHeadersWidth = 62;
            this.DataRequestServices.RowTemplate.Height = 28;
            this.DataRequestServices.Size = new System.Drawing.Size(516, 247);
            this.DataRequestServices.TabIndex = 5;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // servicePriceDataGridViewTextBoxColumn
            // 
            this.servicePriceDataGridViewTextBoxColumn.DataPropertyName = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.HeaderText = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.Name = "servicePriceDataGridViewTextBoxColumn";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hotel_ManagerDataSet8;
            // 
            // hotel_ManagerDataSet8
            // 
            this.hotel_ManagerDataSet8.DataSetName = "Hotel_ManagerDataSet8";
            this.hotel_ManagerDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(337, 249);
            this.NumQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(403, 26);
            this.NumQuantity.TabIndex = 4;
            this.NumQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbServices
            // 
            this.CmbServices.FormattingEnabled = true;
            this.CmbServices.Location = new System.Drawing.Point(337, 159);
            this.CmbServices.Name = "CmbServices";
            this.CmbServices.Size = new System.Drawing.Size(403, 28);
            this.CmbServices.TabIndex = 3;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblQuantity.Location = new System.Drawing.Point(158, 248);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(98, 24);
            this.LblQuantity.TabIndex = 2;
            this.LblQuantity.Text = "Quantity :";
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblService.Location = new System.Drawing.Point(144, 164);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(98, 24);
            this.LblService.TabIndex = 1;
            this.LblService.Text = "Service : ";
            // 
            // LblRequestServices
            // 
            this.LblRequestServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequestServices.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.LblRequestServices.Image = global::Hotel.Properties.Resources.icons8_services_50;
            this.LblRequestServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRequestServices.Location = new System.Drawing.Point(385, 58);
            this.LblRequestServices.Name = "LblRequestServices";
            this.LblRequestServices.Size = new System.Drawing.Size(472, 46);
            this.LblRequestServices.TabIndex = 0;
            this.LblRequestServices.Text = "Request Services";
            this.LblRequestServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hotel_ManagerDataSet
            // 
            this.hotel_ManagerDataSet.DataSetName = "Hotel_ManagerDataSet";
            this.hotel_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelManagerDataSetBindingSource
            // 
            this.hotelManagerDataSetBindingSource.DataSource = this.hotel_ManagerDataSet;
            this.hotelManagerDataSetBindingSource.Position = 0;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // reservationsTableAdapter1
            // 
            this.reservationsTableAdapter1.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.TabRequestServices);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.TabRequestServices.ResumeLayout(false);
            this.PageCustomerInformation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrBoxGender.ResumeLayout(false);
            this.GrBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet4)).EndInit();
            this.PageBookng.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet5)).EndInit();
            this.PageViewRoom.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet6)).EndInit();
            this.PageBookingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingHistoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet7)).EndInit();
            this.PageRequestServices.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataRequestServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabRequestServices;
        private System.Windows.Forms.TabPage PageCustomerInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox GrBoxGender;
        private System.Windows.Forms.RadioButton RadOther;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.DataGridView DataCustomerList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblGuestInformation;
        private System.Windows.Forms.TabPage PageBookng;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataBookingList;
        private System.Windows.Forms.Button BtnEditBooking;
        private System.Windows.Forms.Button BtnCancelBooking;
        private System.Windows.Forms.Button BtnAddBooking;
        private System.Windows.Forms.DateTimePicker DtpCheckIn;
        private System.Windows.Forms.DateTimePicker DtpCheckOut;
        private System.Windows.Forms.ComboBox CmbRoom;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.Label LblRoom;
        private System.Windows.Forms.Label LblCheckIn;
        private System.Windows.Forms.Label LblCheckOut;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.Label LblBooking;
        private System.Windows.Forms.TabPage PageViewRoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnAvliableRooms;
        private System.Windows.Forms.DataGridView DataViewRoomList;
        private System.Windows.Forms.Label LblViewRoom;
        private System.Windows.Forms.TabPage PageBookingHistory;
        private System.Windows.Forms.Button BtnEditFeedBack;
        private System.Windows.Forms.DataGridView DataBookingHistoryList;
        private System.Windows.Forms.Label LblBookingHistory;
        private System.Windows.Forms.TabPage PageRequestServices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAddServices;
        private System.Windows.Forms.DataGridView DataRequestServices;
        private System.Windows.Forms.NumericUpDown NumQuantity;
        private System.Windows.Forms.ComboBox CmbServices;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblRequestServices;
        private System.Windows.Forms.BindingSource hotelManagerDataSetBindingSource;
        private Hotel_ManagerDataSet hotel_ManagerDataSet;
        private Hotel_ManagerDataSet4 hotel_ManagerDataSet4;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private Hotel_ManagerDataSet4TableAdapters.GuestsTableAdapter guestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Hotel_ManagerDataSet5 hotel_ManagerDataSet5;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private Hotel_ManagerDataSet5TableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private Hotel_ManagerDataSet6 hotel_ManagerDataSet6;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Hotel_ManagerDataSet6TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailableDataGridViewTextBoxColumn;
        private Hotel_ManagerDataSet7 hotel_ManagerDataSet7;
        private System.Windows.Forms.BindingSource reservationsBindingSource1;
        private Hotel_ManagerDataSet7TableAdapters.ReservationsTableAdapter reservationsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackDataGridViewTextBoxColumn;
        private Hotel_ManagerDataSet8 hotel_ManagerDataSet8;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private Hotel_ManagerDataSet8TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}