using Hotel.Hotel_ManagerDataSet4TableAdapters;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabRequestServicesGuest = new System.Windows.Forms.TabControl();
            this.PageCustomerInformation = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAddGuest = new System.Windows.Forms.Button();
            this.GrBoxGenderGuest = new System.Windows.Forms.GroupBox();
            this.RadOther = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.DataCustomerGuest = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet4 = new Hotel.Hotel_ManagerDataSet4();
            this.DtpDateGuest = new System.Windows.Forms.DateTimePicker();
            this.TxtEmailGuest = new System.Windows.Forms.TextBox();
            this.TxtAddressGuest = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumberGuest = new System.Windows.Forms.TextBox();
            this.TxtUserNameGuest = new System.Windows.Forms.TextBox();
            this.LblEmailGuest = new System.Windows.Forms.Label();
            this.LblAddressGuest = new System.Windows.Forms.Label();
            this.LblPhoneNumberGuest = new System.Windows.Forms.Label();
            this.LblGenderGuest = new System.Windows.Forms.Label();
            this.LblDateGuest = new System.Windows.Forms.Label();
            this.LblUserNameGuest = new System.Windows.Forms.Label();
            this.LblGuestInformation = new System.Windows.Forms.Label();
            this.PageBookngGuest = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataBookingGuest = new System.Windows.Forms.DataGridView();
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
            this.CmbRoomGuest = new System.Windows.Forms.ComboBox();
            this.CmbCustomerGuest = new System.Windows.Forms.ComboBox();
            this.LblRoomGuest = new System.Windows.Forms.Label();
            this.LblCheckInGuest = new System.Windows.Forms.Label();
            this.LblCheckOutGuest = new System.Windows.Forms.Label();
            this.LblCustomerGuest = new System.Windows.Forms.Label();
            this.LblBookingGuest = new System.Windows.Forms.Label();
            this.PageViewRoomGuest = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataViewRoomGuest = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet6 = new Hotel.Hotel_ManagerDataSet6();
            this.LblViewRoomGuest = new System.Windows.Forms.Label();
            this.PageBookingHistoryGuest = new System.Windows.Forms.TabPage();
            this.BtnEditFeedBack = new System.Windows.Forms.Button();
            this.DataBookingHistoryGuest = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet10 = new Hotel.Hotel_ManagerDataSet10();
            this.LblBookingHistoryGuest = new System.Windows.Forms.Label();
            this.PageRequestServicesGuest = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataRequestServicesGuest = new System.Windows.Forms.DataGridView();
            this.reservationServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationServicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet22 = new Hotel.Hotel_ManagerDataSet22();
            this.BtnEditGuest = new System.Windows.Forms.Button();
            this.BtnAddServices = new System.Windows.Forms.Button();
            this.NumQuantityGuest = new System.Windows.Forms.NumericUpDown();
            this.CmbServicesGuest = new System.Windows.Forms.ComboBox();
            this.LblQuantityGuest = new System.Windows.Forms.Label();
            this.LblServiceGuest = new System.Windows.Forms.Label();
            this.LblRequestServicesGuest = new System.Windows.Forms.Label();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet8 = new Hotel.Hotel_ManagerDataSet8();
            this.reservationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet7 = new Hotel.Hotel_ManagerDataSet7();
            this.hotel_ManagerDataSet = new Hotel.Hotel_ManagerDataSet();
            this.hotelManagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Hotel.Hotel_ManagerDataSet4TableAdapters.GuestsTableAdapter();
            this.reservationsTableAdapter = new Hotel.Hotel_ManagerDataSet5TableAdapters.ReservationsTableAdapter();
            this.roomTableAdapter = new Hotel.Hotel_ManagerDataSet6TableAdapters.RoomTableAdapter();
            this.reservationsTableAdapter1 = new Hotel.Hotel_ManagerDataSet7TableAdapters.ReservationsTableAdapter();
            this.servicesTableAdapter = new Hotel.Hotel_ManagerDataSet8TableAdapters.ServicesTableAdapter();
            this.hotel_ManagerDataSet9 = new Hotel.Hotel_ManagerDataSet9();
            this.hotelManagerDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsTableAdapter2 = new Hotel.Hotel_ManagerDataSet10TableAdapters.ReservationsTableAdapter();
            this.hotel_ManagerDataSet21 = new Hotel.Hotel_ManagerDataSet21();
            this.reservationServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationServicesTableAdapter = new Hotel.Hotel_ManagerDataSet21TableAdapters.ReservationServicesTableAdapter();
            this.reservationServicesTableAdapter1 = new Hotel.Hotel_ManagerDataSet22TableAdapters.ReservationServicesTableAdapter();
            this.TabRequestServicesGuest.SuspendLayout();
            this.PageCustomerInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrBoxGenderGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomerGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet4)).BeginInit();
            this.PageBookngGuest.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet5)).BeginInit();
            this.PageViewRoomGuest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRoomGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet6)).BeginInit();
            this.PageBookingHistoryGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingHistoryGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet10)).BeginInit();
            this.PageRequestServicesGuest.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataRequestServicesGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationServicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantityGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationServicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabRequestServicesGuest
            // 
            this.TabRequestServicesGuest.Controls.Add(this.PageCustomerInformation);
            this.TabRequestServicesGuest.Controls.Add(this.PageBookngGuest);
            this.TabRequestServicesGuest.Controls.Add(this.PageViewRoomGuest);
            this.TabRequestServicesGuest.Controls.Add(this.PageBookingHistoryGuest);
            this.TabRequestServicesGuest.Controls.Add(this.PageRequestServicesGuest);
            this.TabRequestServicesGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabRequestServicesGuest.Location = new System.Drawing.Point(216, 92);
            this.TabRequestServicesGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabRequestServicesGuest.Name = "TabRequestServicesGuest";
            this.TabRequestServicesGuest.SelectedIndex = 0;
            this.TabRequestServicesGuest.Size = new System.Drawing.Size(1794, 1292);
            this.TabRequestServicesGuest.TabIndex = 1;
            // 
            // PageCustomerInformation
            // 
            this.PageCustomerInformation.BackColor = System.Drawing.Color.Lime;
            this.PageCustomerInformation.BackgroundImage = global::Hotel.Properties.Resources._0e83fe416785d8c995f664d65a68a73e;
            this.PageCustomerInformation.Controls.Add(this.groupBox1);
            this.PageCustomerInformation.ForeColor = System.Drawing.Color.Silver;
            this.PageCustomerInformation.Location = new System.Drawing.Point(4, 38);
            this.PageCustomerInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageCustomerInformation.Name = "PageCustomerInformation";
            this.PageCustomerInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageCustomerInformation.Size = new System.Drawing.Size(1786, 1250);
            this.PageCustomerInformation.TabIndex = 0;
            this.PageCustomerInformation.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnEdit);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnAddGuest);
            this.groupBox1.Controls.Add(this.GrBoxGenderGuest);
            this.groupBox1.Controls.Add(this.DataCustomerGuest);
            this.groupBox1.Controls.Add(this.DtpDateGuest);
            this.groupBox1.Controls.Add(this.TxtEmailGuest);
            this.groupBox1.Controls.Add(this.TxtAddressGuest);
            this.groupBox1.Controls.Add(this.TxtPhoneNumberGuest);
            this.groupBox1.Controls.Add(this.TxtUserNameGuest);
            this.groupBox1.Controls.Add(this.LblEmailGuest);
            this.groupBox1.Controls.Add(this.LblAddressGuest);
            this.groupBox1.Controls.Add(this.LblPhoneNumberGuest);
            this.groupBox1.Controls.Add(this.LblGenderGuest);
            this.groupBox1.Controls.Add(this.LblDateGuest);
            this.groupBox1.Controls.Add(this.LblUserNameGuest);
            this.groupBox1.Controls.Add(this.LblGuestInformation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1778, 1240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Image = global::Hotel.Properties.Resources.icons8_edit_26;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(1156, 371);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(302, 63);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Image = global::Hotel.Properties.Resources.icons8_delete_24;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(1156, 668);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(302, 63);
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
            this.BtnUpdate.Location = new System.Drawing.Point(1156, 523);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(302, 63);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnAddGuest
            // 
            this.BtnAddGuest.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnAddGuest.ForeColor = System.Drawing.Color.Black;
            this.BtnAddGuest.Image = global::Hotel.Properties.Resources.icons8_add_24;
            this.BtnAddGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddGuest.Location = new System.Drawing.Point(1156, 218);
            this.BtnAddGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddGuest.Name = "BtnAddGuest";
            this.BtnAddGuest.Size = new System.Drawing.Size(302, 63);
            this.BtnAddGuest.TabIndex = 1;
            this.BtnAddGuest.Text = "Add ";
            this.BtnAddGuest.UseVisualStyleBackColor = false;
            // 
            // GrBoxGenderGuest
            // 
            this.GrBoxGenderGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GrBoxGenderGuest.Controls.Add(this.RadOther);
            this.GrBoxGenderGuest.Controls.Add(this.RadFemale);
            this.GrBoxGenderGuest.Controls.Add(this.RadMale);
            this.GrBoxGenderGuest.ForeColor = System.Drawing.SystemColors.Window;
            this.GrBoxGenderGuest.Location = new System.Drawing.Point(480, 258);
            this.GrBoxGenderGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrBoxGenderGuest.Name = "GrBoxGenderGuest";
            this.GrBoxGenderGuest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrBoxGenderGuest.Size = new System.Drawing.Size(484, 54);
            this.GrBoxGenderGuest.TabIndex = 5;
            this.GrBoxGenderGuest.TabStop = false;
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadOther.ForeColor = System.Drawing.Color.Black;
            this.RadOther.Location = new System.Drawing.Point(348, 22);
            this.RadOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadOther.Name = "RadOther";
            this.RadOther.Size = new System.Drawing.Size(79, 24);
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
            this.RadFemale.Location = new System.Drawing.Point(177, 23);
            this.RadFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(93, 24);
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
            this.RadMale.Location = new System.Drawing.Point(24, 22);
            this.RadMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(72, 24);
            this.RadMale.TabIndex = 6;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // DataCustomerGuest
            // 
            this.DataCustomerGuest.AutoGenerateColumns = false;
            this.DataCustomerGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCustomerGuest.BackgroundColor = System.Drawing.Color.Linen;
            this.DataCustomerGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCustomerGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DataCustomerGuest.DataSource = this.guestsBindingSource;
            this.DataCustomerGuest.Location = new System.Drawing.Point(344, 857);
            this.DataCustomerGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataCustomerGuest.Name = "DataCustomerGuest";
            this.DataCustomerGuest.RowHeadersVisible = false;
            this.DataCustomerGuest.RowHeadersWidth = 62;
            this.DataCustomerGuest.RowTemplate.Height = 28;
            this.DataCustomerGuest.Size = new System.Drawing.Size(1148, 231);
            this.DataCustomerGuest.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
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
            // DtpDateGuest
            // 
            this.DtpDateGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateGuest.Location = new System.Drawing.Point(480, 385);
            this.DtpDateGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpDateGuest.Name = "DtpDateGuest";
            this.DtpDateGuest.Size = new System.Drawing.Size(482, 26);
            this.DtpDateGuest.TabIndex = 4;
            // 
            // TxtEmailGuest
            // 
            this.TxtEmailGuest.Location = new System.Drawing.Point(480, 731);
            this.TxtEmailGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmailGuest.Name = "TxtEmailGuest";
            this.TxtEmailGuest.Size = new System.Drawing.Size(482, 35);
            this.TxtEmailGuest.TabIndex = 2;
            // 
            // TxtAddressGuest
            // 
            this.TxtAddressGuest.Location = new System.Drawing.Point(480, 614);
            this.TxtAddressGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAddressGuest.Name = "TxtAddressGuest";
            this.TxtAddressGuest.Size = new System.Drawing.Size(482, 35);
            this.TxtAddressGuest.TabIndex = 2;
            // 
            // TxtPhoneNumberGuest
            // 
            this.TxtPhoneNumberGuest.Location = new System.Drawing.Point(480, 489);
            this.TxtPhoneNumberGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPhoneNumberGuest.Name = "TxtPhoneNumberGuest";
            this.TxtPhoneNumberGuest.Size = new System.Drawing.Size(482, 35);
            this.TxtPhoneNumberGuest.TabIndex = 2;
            // 
            // TxtUserNameGuest
            // 
            this.TxtUserNameGuest.Location = new System.Drawing.Point(480, 165);
            this.TxtUserNameGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUserNameGuest.Name = "TxtUserNameGuest";
            this.TxtUserNameGuest.Size = new System.Drawing.Size(482, 35);
            this.TxtUserNameGuest.TabIndex = 2;
            // 
            // LblEmailGuest
            // 
            this.LblEmailGuest.AutoSize = true;
            this.LblEmailGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblEmailGuest.Location = new System.Drawing.Point(72, 740);
            this.LblEmailGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmailGuest.Name = "LblEmailGuest";
            this.LblEmailGuest.Size = new System.Drawing.Size(100, 29);
            this.LblEmailGuest.TabIndex = 1;
            this.LblEmailGuest.Text = "Email : ";
            // 
            // LblAddressGuest
            // 
            this.LblAddressGuest.AutoSize = true;
            this.LblAddressGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblAddressGuest.Location = new System.Drawing.Point(72, 623);
            this.LblAddressGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddressGuest.Name = "LblAddressGuest";
            this.LblAddressGuest.Size = new System.Drawing.Size(130, 29);
            this.LblAddressGuest.TabIndex = 1;
            this.LblAddressGuest.Text = "Address : ";
            // 
            // LblPhoneNumberGuest
            // 
            this.LblPhoneNumberGuest.AutoSize = true;
            this.LblPhoneNumberGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumberGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblPhoneNumberGuest.Location = new System.Drawing.Point(72, 494);
            this.LblPhoneNumberGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoneNumberGuest.Name = "LblPhoneNumberGuest";
            this.LblPhoneNumberGuest.Size = new System.Drawing.Size(209, 29);
            this.LblPhoneNumberGuest.TabIndex = 1;
            this.LblPhoneNumberGuest.Text = "Phone Number : ";
            // 
            // LblGenderGuest
            // 
            this.LblGenderGuest.AutoSize = true;
            this.LblGenderGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenderGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblGenderGuest.Location = new System.Drawing.Point(72, 274);
            this.LblGenderGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGenderGuest.Name = "LblGenderGuest";
            this.LblGenderGuest.Size = new System.Drawing.Size(121, 29);
            this.LblGenderGuest.TabIndex = 1;
            this.LblGenderGuest.Text = "Gender : ";
            // 
            // LblDateGuest
            // 
            this.LblDateGuest.AutoSize = true;
            this.LblDateGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblDateGuest.Location = new System.Drawing.Point(72, 392);
            this.LblDateGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateGuest.Name = "LblDateGuest";
            this.LblDateGuest.Size = new System.Drawing.Size(169, 29);
            this.LblDateGuest.TabIndex = 1;
            this.LblDateGuest.Text = "Date of birth :";
            // 
            // LblUserNameGuest
            // 
            this.LblUserNameGuest.AutoSize = true;
            this.LblUserNameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserNameGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblUserNameGuest.Location = new System.Drawing.Point(72, 174);
            this.LblUserNameGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserNameGuest.Name = "LblUserNameGuest";
            this.LblUserNameGuest.Size = new System.Drawing.Size(103, 29);
            this.LblUserNameGuest.TabIndex = 1;
            this.LblUserNameGuest.Text = "Name : ";
            // 
            // LblGuestInformation
            // 
            this.LblGuestInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuestInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblGuestInformation.Image = global::Hotel.Properties.Resources.icons8_neighbor_50;
            this.LblGuestInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblGuestInformation.Location = new System.Drawing.Point(524, 48);
            this.LblGuestInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGuestInformation.Name = "LblGuestInformation";
            this.LblGuestInformation.Size = new System.Drawing.Size(664, 71);
            this.LblGuestInformation.TabIndex = 0;
            this.LblGuestInformation.Text = "Guest Information";
            this.LblGuestInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBookngGuest
            // 
            this.PageBookngGuest.BackgroundImage = global::Hotel.Properties.Resources._9689e526b6e6b1ac527e8e436d797dbb;
            this.PageBookngGuest.Controls.Add(this.groupBox2);
            this.PageBookngGuest.Location = new System.Drawing.Point(4, 38);
            this.PageBookngGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageBookngGuest.Name = "PageBookngGuest";
            this.PageBookngGuest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageBookngGuest.Size = new System.Drawing.Size(1786, 1250);
            this.PageBookngGuest.TabIndex = 1;
            this.PageBookngGuest.Text = "Booking";
            this.PageBookngGuest.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataBookingGuest);
            this.groupBox2.Controls.Add(this.BtnEditBooking);
            this.groupBox2.Controls.Add(this.BtnCancelBooking);
            this.groupBox2.Controls.Add(this.BtnAddBooking);
            this.groupBox2.Controls.Add(this.DtpCheckIn);
            this.groupBox2.Controls.Add(this.DtpCheckOut);
            this.groupBox2.Controls.Add(this.CmbRoomGuest);
            this.groupBox2.Controls.Add(this.CmbCustomerGuest);
            this.groupBox2.Controls.Add(this.LblRoomGuest);
            this.groupBox2.Controls.Add(this.LblCheckInGuest);
            this.groupBox2.Controls.Add(this.LblCheckOutGuest);
            this.groupBox2.Controls.Add(this.LblCustomerGuest);
            this.groupBox2.Controls.Add(this.LblBookingGuest);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1778, 1240);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // DataBookingGuest
            // 
            this.DataBookingGuest.AutoGenerateColumns = false;
            this.DataBookingGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataBookingGuest.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataBookingGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBookingGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn});
            this.DataBookingGuest.DataSource = this.reservationsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingGuest.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataBookingGuest.Location = new System.Drawing.Point(328, 751);
            this.DataBookingGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataBookingGuest.Name = "DataBookingGuest";
            this.DataBookingGuest.RowHeadersVisible = false;
            this.DataBookingGuest.RowHeadersWidth = 30;
            this.DataBookingGuest.RowTemplate.Height = 28;
            this.DataBookingGuest.Size = new System.Drawing.Size(1086, 251);
            this.DataBookingGuest.TabIndex = 1;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.Width = 135;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 137;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 188;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.Width = 186;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.Width = 205;
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
            this.BtnEditBooking.Location = new System.Drawing.Point(1226, 343);
            this.BtnEditBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditBooking.Name = "BtnEditBooking";
            this.BtnEditBooking.Size = new System.Drawing.Size(309, 68);
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
            this.BtnCancelBooking.Location = new System.Drawing.Point(1226, 485);
            this.BtnCancelBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelBooking.Name = "BtnCancelBooking";
            this.BtnCancelBooking.Size = new System.Drawing.Size(309, 68);
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
            this.BtnAddBooking.Location = new System.Drawing.Point(1226, 209);
            this.BtnAddBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddBooking.Name = "BtnAddBooking";
            this.BtnAddBooking.Size = new System.Drawing.Size(309, 68);
            this.BtnAddBooking.TabIndex = 4;
            this.BtnAddBooking.Text = "Add";
            this.BtnAddBooking.UseVisualStyleBackColor = false;
            // 
            // DtpCheckIn
            // 
            this.DtpCheckIn.CustomFormat = "dd/MM/yyyy hh : mm : ss";
            this.DtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCheckIn.Location = new System.Drawing.Point(476, 420);
            this.DtpCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpCheckIn.Name = "DtpCheckIn";
            this.DtpCheckIn.Size = new System.Drawing.Size(506, 30);
            this.DtpCheckIn.TabIndex = 3;
            // 
            // DtpCheckOut
            // 
            this.DtpCheckOut.CustomFormat = "dd/MM/yyyy hh : mm : ss";
            this.DtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCheckOut.Location = new System.Drawing.Point(476, 557);
            this.DtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpCheckOut.Name = "DtpCheckOut";
            this.DtpCheckOut.Size = new System.Drawing.Size(506, 30);
            this.DtpCheckOut.TabIndex = 3;
            // 
            // CmbRoomGuest
            // 
            this.CmbRoomGuest.FormattingEnabled = true;
            this.CmbRoomGuest.Location = new System.Drawing.Point(476, 297);
            this.CmbRoomGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbRoomGuest.Name = "CmbRoomGuest";
            this.CmbRoomGuest.Size = new System.Drawing.Size(506, 37);
            this.CmbRoomGuest.TabIndex = 2;
            // 
            // CmbCustomerGuest
            // 
            this.CmbCustomerGuest.FormattingEnabled = true;
            this.CmbCustomerGuest.Location = new System.Drawing.Point(476, 183);
            this.CmbCustomerGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbCustomerGuest.Name = "CmbCustomerGuest";
            this.CmbCustomerGuest.Size = new System.Drawing.Size(506, 37);
            this.CmbCustomerGuest.TabIndex = 2;
            // 
            // LblRoomGuest
            // 
            this.LblRoomGuest.AutoSize = true;
            this.LblRoomGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblRoomGuest.Location = new System.Drawing.Point(148, 309);
            this.LblRoomGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRoomGuest.Name = "LblRoomGuest";
            this.LblRoomGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblRoomGuest.Size = new System.Drawing.Size(103, 29);
            this.LblRoomGuest.TabIndex = 1;
            this.LblRoomGuest.Text = "Room : ";
            // 
            // LblCheckInGuest
            // 
            this.LblCheckInGuest.AutoSize = true;
            this.LblCheckInGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckInGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblCheckInGuest.Location = new System.Drawing.Point(148, 429);
            this.LblCheckInGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCheckInGuest.Name = "LblCheckInGuest";
            this.LblCheckInGuest.Size = new System.Drawing.Size(135, 29);
            this.LblCheckInGuest.TabIndex = 1;
            this.LblCheckInGuest.Text = "Check In : ";
            // 
            // LblCheckOutGuest
            // 
            this.LblCheckOutGuest.AutoSize = true;
            this.LblCheckOutGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckOutGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblCheckOutGuest.Location = new System.Drawing.Point(148, 557);
            this.LblCheckOutGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCheckOutGuest.Name = "LblCheckOutGuest";
            this.LblCheckOutGuest.Size = new System.Drawing.Size(155, 29);
            this.LblCheckOutGuest.TabIndex = 1;
            this.LblCheckOutGuest.Text = "Check Out : ";
            // 
            // LblCustomerGuest
            // 
            this.LblCustomerGuest.AutoSize = true;
            this.LblCustomerGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblCustomerGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblCustomerGuest.Location = new System.Drawing.Point(148, 195);
            this.LblCustomerGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerGuest.Name = "LblCustomerGuest";
            this.LblCustomerGuest.Size = new System.Drawing.Size(139, 29);
            this.LblCustomerGuest.TabIndex = 1;
            this.LblCustomerGuest.Text = "Customer :";
            // 
            // LblBookingGuest
            // 
            this.LblBookingGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblBookingGuest.Image = global::Hotel.Properties.Resources.icons8_booking_48;
            this.LblBookingGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBookingGuest.Location = new System.Drawing.Point(630, 48);
            this.LblBookingGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookingGuest.Name = "LblBookingGuest";
            this.LblBookingGuest.Size = new System.Drawing.Size(406, 71);
            this.LblBookingGuest.TabIndex = 0;
            this.LblBookingGuest.Text = "Booking";
            this.LblBookingGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageViewRoomGuest
            // 
            this.PageViewRoomGuest.BackgroundImage = global::Hotel.Properties.Resources.aea3013e3c66280a50d37ff741d47eb7;
            this.PageViewRoomGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageViewRoomGuest.Controls.Add(this.groupBox3);
            this.PageViewRoomGuest.Location = new System.Drawing.Point(4, 38);
            this.PageViewRoomGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageViewRoomGuest.Name = "PageViewRoomGuest";
            this.PageViewRoomGuest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageViewRoomGuest.Size = new System.Drawing.Size(1786, 1250);
            this.PageViewRoomGuest.TabIndex = 2;
            this.PageViewRoomGuest.Text = "ViewRoom";
            this.PageViewRoomGuest.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataViewRoomGuest);
            this.groupBox3.Controls.Add(this.LblViewRoomGuest);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1778, 1240);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // DataViewRoomGuest
            // 
            this.DataViewRoomGuest.AutoGenerateColumns = false;
            this.DataViewRoomGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewRoomGuest.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DataViewRoomGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewRoomGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn1,
            this.roomTypeDataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewTextBoxColumn});
            this.DataViewRoomGuest.DataSource = this.roomBindingSource;
            this.DataViewRoomGuest.GridColor = System.Drawing.Color.Cornsilk;
            this.DataViewRoomGuest.Location = new System.Drawing.Point(206, 305);
            this.DataViewRoomGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataViewRoomGuest.Name = "DataViewRoomGuest";
            this.DataViewRoomGuest.RowHeadersVisible = false;
            this.DataViewRoomGuest.RowHeadersWidth = 68;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewRoomGuest.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewRoomGuest.RowTemplate.Height = 28;
            this.DataViewRoomGuest.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewRoomGuest.Size = new System.Drawing.Size(1378, 771);
            this.DataViewRoomGuest.TabIndex = 2;
            // 
            // roomIDDataGridViewTextBoxColumn1
            // 
            this.roomIDDataGridViewTextBoxColumn1.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.roomIDDataGridViewTextBoxColumn1.Name = "roomIDDataGridViewTextBoxColumn1";
            this.roomIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            // 
            // isAvailableDataGridViewTextBoxColumn
            // 
            this.isAvailableDataGridViewTextBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.HeaderText = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.MinimumWidth = 8;
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
            // LblViewRoomGuest
            // 
            this.LblViewRoomGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewRoomGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblViewRoomGuest.Image = global::Hotel.Properties.Resources.icons8_view_50__1_;
            this.LblViewRoomGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblViewRoomGuest.Location = new System.Drawing.Point(682, 48);
            this.LblViewRoomGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblViewRoomGuest.Name = "LblViewRoomGuest";
            this.LblViewRoomGuest.Size = new System.Drawing.Size(416, 82);
            this.LblViewRoomGuest.TabIndex = 0;
            this.LblViewRoomGuest.Text = "View Room";
            this.LblViewRoomGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBookingHistoryGuest
            // 
            this.PageBookingHistoryGuest.BackColor = System.Drawing.Color.OliveDrab;
            this.PageBookingHistoryGuest.BackgroundImage = global::Hotel.Properties.Resources._2ecf9b191b582f7cdd650c624ca14bad;
            this.PageBookingHistoryGuest.Controls.Add(this.BtnEditFeedBack);
            this.PageBookingHistoryGuest.Controls.Add(this.DataBookingHistoryGuest);
            this.PageBookingHistoryGuest.Controls.Add(this.LblBookingHistoryGuest);
            this.PageBookingHistoryGuest.Location = new System.Drawing.Point(4, 38);
            this.PageBookingHistoryGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageBookingHistoryGuest.Name = "PageBookingHistoryGuest";
            this.PageBookingHistoryGuest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageBookingHistoryGuest.Size = new System.Drawing.Size(1786, 1250);
            this.PageBookingHistoryGuest.TabIndex = 3;
            this.PageBookingHistoryGuest.Text = "BookingHistory";
            // 
            // BtnEditFeedBack
            // 
            this.BtnEditFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditFeedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEditFeedBack.Image = global::Hotel.Properties.Resources.icons8_feedback_48;
            this.BtnEditFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditFeedBack.Location = new System.Drawing.Point(663, 932);
            this.BtnEditFeedBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditFeedBack.Name = "BtnEditFeedBack";
            this.BtnEditFeedBack.Size = new System.Drawing.Size(519, 98);
            this.BtnEditFeedBack.TabIndex = 2;
            this.BtnEditFeedBack.Text = "FeedBack";
            this.BtnEditFeedBack.UseVisualStyleBackColor = true;
            // 
            // DataBookingHistoryGuest
            // 
            this.DataBookingHistoryGuest.AutoGenerateColumns = false;
            this.DataBookingHistoryGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBookingHistoryGuest.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DataBookingHistoryGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBookingHistoryGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn1,
            this.guestIDDataGridViewTextBoxColumn1,
            this.roomIDDataGridViewTextBoxColumn2,
            this.bookingDateDataGridViewTextBoxColumn1,
            this.checkInDateDataGridViewTextBoxColumn1,
            this.checkOutDateDataGridViewTextBoxColumn1,
            this.feedbackScoreDataGridViewTextBoxColumn});
            this.DataBookingHistoryGuest.DataSource = this.reservationsBindingSource2;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingHistoryGuest.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataBookingHistoryGuest.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataBookingHistoryGuest.Location = new System.Drawing.Point(153, 235);
            this.DataBookingHistoryGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataBookingHistoryGuest.Name = "DataBookingHistoryGuest";
            this.DataBookingHistoryGuest.RowHeadersVisible = false;
            this.DataBookingHistoryGuest.RowHeadersWidth = 62;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingHistoryGuest.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataBookingHistoryGuest.Size = new System.Drawing.Size(1509, 592);
            this.DataBookingHistoryGuest.TabIndex = 1;
            // 
            // reservationIDDataGridViewTextBoxColumn1
            // 
            this.reservationIDDataGridViewTextBoxColumn1.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn1.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn1.Name = "reservationIDDataGridViewTextBoxColumn1";
            this.reservationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn1
            // 
            this.guestIDDataGridViewTextBoxColumn1.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn1.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.guestIDDataGridViewTextBoxColumn1.Name = "guestIDDataGridViewTextBoxColumn1";
            // 
            // roomIDDataGridViewTextBoxColumn2
            // 
            this.roomIDDataGridViewTextBoxColumn2.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn2.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.roomIDDataGridViewTextBoxColumn2.Name = "roomIDDataGridViewTextBoxColumn2";
            // 
            // bookingDateDataGridViewTextBoxColumn1
            // 
            this.bookingDateDataGridViewTextBoxColumn1.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn1.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.bookingDateDataGridViewTextBoxColumn1.Name = "bookingDateDataGridViewTextBoxColumn1";
            // 
            // checkInDateDataGridViewTextBoxColumn1
            // 
            this.checkInDateDataGridViewTextBoxColumn1.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn1.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.checkInDateDataGridViewTextBoxColumn1.Name = "checkInDateDataGridViewTextBoxColumn1";
            // 
            // checkOutDateDataGridViewTextBoxColumn1
            // 
            this.checkOutDateDataGridViewTextBoxColumn1.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn1.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.checkOutDateDataGridViewTextBoxColumn1.Name = "checkOutDateDataGridViewTextBoxColumn1";
            // 
            // feedbackScoreDataGridViewTextBoxColumn
            // 
            this.feedbackScoreDataGridViewTextBoxColumn.DataPropertyName = "FeedbackScore";
            this.feedbackScoreDataGridViewTextBoxColumn.HeaderText = "FeedbackScore";
            this.feedbackScoreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.feedbackScoreDataGridViewTextBoxColumn.Name = "feedbackScoreDataGridViewTextBoxColumn";
            // 
            // reservationsBindingSource2
            // 
            this.reservationsBindingSource2.DataMember = "Reservations";
            this.reservationsBindingSource2.DataSource = this.hotel_ManagerDataSet10;
            // 
            // hotel_ManagerDataSet10
            // 
            this.hotel_ManagerDataSet10.DataSetName = "Hotel_ManagerDataSet10";
            this.hotel_ManagerDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblBookingHistoryGuest
            // 
            this.LblBookingHistoryGuest.BackColor = System.Drawing.Color.Transparent;
            this.LblBookingHistoryGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingHistoryGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblBookingHistoryGuest.Image = global::Hotel.Properties.Resources.icons8_booking_48__1_;
            this.LblBookingHistoryGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBookingHistoryGuest.Location = new System.Drawing.Point(651, 109);
            this.LblBookingHistoryGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookingHistoryGuest.Name = "LblBookingHistoryGuest";
            this.LblBookingHistoryGuest.Size = new System.Drawing.Size(640, 83);
            this.LblBookingHistoryGuest.TabIndex = 0;
            this.LblBookingHistoryGuest.Text = "Booking History";
            this.LblBookingHistoryGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageRequestServicesGuest
            // 
            this.PageRequestServicesGuest.BackgroundImage = global::Hotel.Properties.Resources.b84517d81f7ee3cb0ceff696c74e91b5;
            this.PageRequestServicesGuest.Controls.Add(this.groupBox4);
            this.PageRequestServicesGuest.Location = new System.Drawing.Point(4, 38);
            this.PageRequestServicesGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageRequestServicesGuest.Name = "PageRequestServicesGuest";
            this.PageRequestServicesGuest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageRequestServicesGuest.Size = new System.Drawing.Size(1786, 1250);
            this.PageRequestServicesGuest.TabIndex = 4;
            this.PageRequestServicesGuest.Text = "Request Services";
            this.PageRequestServicesGuest.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataRequestServicesGuest);
            this.groupBox4.Controls.Add(this.BtnEditGuest);
            this.groupBox4.Controls.Add(this.BtnAddServices);
            this.groupBox4.Controls.Add(this.NumQuantityGuest);
            this.groupBox4.Controls.Add(this.CmbServicesGuest);
            this.groupBox4.Controls.Add(this.LblQuantityGuest);
            this.groupBox4.Controls.Add(this.LblServiceGuest);
            this.groupBox4.Controls.Add(this.LblRequestServicesGuest);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(4, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1778, 1240);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // DataRequestServicesGuest
            // 
            this.DataRequestServicesGuest.AutoGenerateColumns = false;
            this.DataRequestServicesGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRequestServicesGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationServiceIDDataGridViewTextBoxColumn,
            this.reservationIDDataGridViewTextBoxColumn2,
            this.serviceIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.DataRequestServicesGuest.DataSource = this.reservationServicesBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataRequestServicesGuest.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataRequestServicesGuest.EnableHeadersVisualStyles = false;
            this.DataRequestServicesGuest.Location = new System.Drawing.Point(537, 560);
            this.DataRequestServicesGuest.Name = "DataRequestServicesGuest";
            this.DataRequestServicesGuest.RowHeadersVisible = false;
            this.DataRequestServicesGuest.RowHeadersWidth = 62;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataRequestServicesGuest.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataRequestServicesGuest.RowTemplate.Height = 28;
            this.DataRequestServicesGuest.Size = new System.Drawing.Size(584, 443);
            this.DataRequestServicesGuest.TabIndex = 7;
            // 
            // reservationServiceIDDataGridViewTextBoxColumn
            // 
            this.reservationServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationServiceID";
            this.reservationServiceIDDataGridViewTextBoxColumn.HeaderText = "ReservationServiceID";
            this.reservationServiceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationServiceIDDataGridViewTextBoxColumn.Name = "reservationServiceIDDataGridViewTextBoxColumn";
            this.reservationServiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationServiceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationIDDataGridViewTextBoxColumn2
            // 
            this.reservationIDDataGridViewTextBoxColumn2.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn2.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn2.Name = "reservationIDDataGridViewTextBoxColumn2";
            this.reservationIDDataGridViewTextBoxColumn2.Width = 150;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationServicesBindingSource1
            // 
            this.reservationServicesBindingSource1.DataMember = "ReservationServices";
            this.reservationServicesBindingSource1.DataSource = this.hotel_ManagerDataSet22;
            // 
            // hotel_ManagerDataSet22
            // 
            this.hotel_ManagerDataSet22.DataSetName = "Hotel_ManagerDataSet22";
            this.hotel_ManagerDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnEditGuest
            // 
            this.BtnEditGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditGuest.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnEditGuest.Image = global::Hotel.Properties.Resources.icons8_edit_26;
            this.BtnEditGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditGuest.Location = new System.Drawing.Point(1341, 392);
            this.BtnEditGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditGuest.Name = "BtnEditGuest";
            this.BtnEditGuest.Size = new System.Drawing.Size(201, 43);
            this.BtnEditGuest.TabIndex = 6;
            this.BtnEditGuest.Text = "Edit";
            this.BtnEditGuest.UseVisualStyleBackColor = true;
            // 
            // BtnAddServices
            // 
            this.BtnAddServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddServices.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnAddServices.Image = global::Hotel.Properties.Resources.icons8_add_48;
            this.BtnAddServices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddServices.Location = new System.Drawing.Point(1341, 281);
            this.BtnAddServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddServices.Name = "BtnAddServices";
            this.BtnAddServices.Size = new System.Drawing.Size(201, 53);
            this.BtnAddServices.TabIndex = 6;
            this.BtnAddServices.Text = "Add";
            this.BtnAddServices.UseVisualStyleBackColor = true;
            // 
            // NumQuantityGuest
            // 
            this.NumQuantityGuest.Location = new System.Drawing.Point(506, 383);
            this.NumQuantityGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumQuantityGuest.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumQuantityGuest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumQuantityGuest.Name = "NumQuantityGuest";
            this.NumQuantityGuest.Size = new System.Drawing.Size(604, 35);
            this.NumQuantityGuest.TabIndex = 4;
            this.NumQuantityGuest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbServicesGuest
            // 
            this.CmbServicesGuest.FormattingEnabled = true;
            this.CmbServicesGuest.Location = new System.Drawing.Point(506, 245);
            this.CmbServicesGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbServicesGuest.Name = "CmbServicesGuest";
            this.CmbServicesGuest.Size = new System.Drawing.Size(602, 37);
            this.CmbServicesGuest.TabIndex = 3;
            // 
            // LblQuantityGuest
            // 
            this.LblQuantityGuest.AutoSize = true;
            this.LblQuantityGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantityGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblQuantityGuest.Location = new System.Drawing.Point(237, 382);
            this.LblQuantityGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblQuantityGuest.Name = "LblQuantityGuest";
            this.LblQuantityGuest.Size = new System.Drawing.Size(146, 32);
            this.LblQuantityGuest.TabIndex = 2;
            this.LblQuantityGuest.Text = "Quantity :";
            // 
            // LblServiceGuest
            // 
            this.LblServiceGuest.AutoSize = true;
            this.LblServiceGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblServiceGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblServiceGuest.Location = new System.Drawing.Point(216, 252);
            this.LblServiceGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblServiceGuest.Name = "LblServiceGuest";
            this.LblServiceGuest.Size = new System.Drawing.Size(141, 32);
            this.LblServiceGuest.TabIndex = 1;
            this.LblServiceGuest.Text = "Service : ";
            // 
            // LblRequestServicesGuest
            // 
            this.LblRequestServicesGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequestServicesGuest.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.LblRequestServicesGuest.Image = global::Hotel.Properties.Resources.icons8_services_50;
            this.LblRequestServicesGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRequestServicesGuest.Location = new System.Drawing.Point(578, 89);
            this.LblRequestServicesGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRequestServicesGuest.Name = "LblRequestServicesGuest";
            this.LblRequestServicesGuest.Size = new System.Drawing.Size(708, 71);
            this.LblRequestServicesGuest.TabIndex = 0;
            this.LblRequestServicesGuest.Text = "Request Services";
            this.LblRequestServicesGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // hotel_ManagerDataSet9
            // 
            this.hotel_ManagerDataSet9.DataSetName = "Hotel_ManagerDataSet9";
            this.hotel_ManagerDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelManagerDataSet9BindingSource
            // 
            this.hotelManagerDataSet9BindingSource.DataSource = this.hotel_ManagerDataSet9;
            this.hotelManagerDataSet9BindingSource.Position = 0;
            // 
            // reservationsTableAdapter2
            // 
            this.reservationsTableAdapter2.ClearBeforeFill = true;
            // 
            // hotel_ManagerDataSet21
            // 
            this.hotel_ManagerDataSet21.DataSetName = "Hotel_ManagerDataSet21";
            this.hotel_ManagerDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationServicesBindingSource
            // 
            this.reservationServicesBindingSource.DataMember = "ReservationServices";
            this.reservationServicesBindingSource.DataSource = this.hotel_ManagerDataSet21;
            // 
            // reservationServicesTableAdapter
            // 
            this.reservationServicesTableAdapter.ClearBeforeFill = true;
            // 
            // reservationServicesTableAdapter1
            // 
            this.reservationServicesTableAdapter1.ClearBeforeFill = true;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2258, 1503);
            this.Controls.Add(this.TabRequestServicesGuest);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.TabRequestServicesGuest.ResumeLayout(false);
            this.PageCustomerInformation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrBoxGenderGuest.ResumeLayout(false);
            this.GrBoxGenderGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomerGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet4)).EndInit();
            this.PageBookngGuest.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet5)).EndInit();
            this.PageViewRoomGuest.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRoomGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet6)).EndInit();
            this.PageBookingHistoryGuest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBookingHistoryGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet10)).EndInit();
            this.PageRequestServicesGuest.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataRequestServicesGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationServicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantityGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationServicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabRequestServicesGuest;
        private System.Windows.Forms.TabPage PageCustomerInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAddGuest;
        private System.Windows.Forms.GroupBox GrBoxGenderGuest;
        private System.Windows.Forms.RadioButton RadOther;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.DataGridView DataCustomerGuest;
        private System.Windows.Forms.DateTimePicker DtpDateGuest;
        private System.Windows.Forms.TextBox TxtEmailGuest;
        private System.Windows.Forms.TextBox TxtAddressGuest;
        private System.Windows.Forms.TextBox TxtPhoneNumberGuest;
        private System.Windows.Forms.TextBox TxtUserNameGuest;
        private System.Windows.Forms.Label LblEmailGuest;
        private System.Windows.Forms.Label LblAddressGuest;
        private System.Windows.Forms.Label LblPhoneNumberGuest;
        private System.Windows.Forms.Label LblGenderGuest;
        private System.Windows.Forms.Label LblDateGuest;
        private System.Windows.Forms.Label LblUserNameGuest;
        private System.Windows.Forms.Label LblGuestInformation;
        private System.Windows.Forms.TabPage PageBookngGuest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataBookingGuest;
        private System.Windows.Forms.Button BtnEditBooking;
        private System.Windows.Forms.Button BtnCancelBooking;
        private System.Windows.Forms.Button BtnAddBooking;
        private System.Windows.Forms.DateTimePicker DtpCheckIn;
        private System.Windows.Forms.DateTimePicker DtpCheckOut;
        private System.Windows.Forms.ComboBox CmbRoomGuest;
        private System.Windows.Forms.ComboBox CmbCustomerGuest;
        private System.Windows.Forms.Label LblRoomGuest;
        private System.Windows.Forms.Label LblCheckInGuest;
        private System.Windows.Forms.Label LblCheckOutGuest;
        private System.Windows.Forms.Label LblCustomerGuest;
        private System.Windows.Forms.Label LblBookingGuest;
        private System.Windows.Forms.TabPage PageViewRoomGuest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataViewRoomGuest;
        private System.Windows.Forms.Label LblViewRoomGuest;
        private System.Windows.Forms.TabPage PageBookingHistoryGuest;
        private System.Windows.Forms.Button BtnEditFeedBack;
        private System.Windows.Forms.DataGridView DataBookingHistoryGuest;
        private System.Windows.Forms.Label LblBookingHistoryGuest;
        private System.Windows.Forms.TabPage PageRequestServicesGuest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAddServices;
        private System.Windows.Forms.NumericUpDown NumQuantityGuest;
        private System.Windows.Forms.ComboBox CmbServicesGuest;
        private System.Windows.Forms.Label LblQuantityGuest;
        private System.Windows.Forms.Label LblServiceGuest;
        private System.Windows.Forms.Label LblRequestServicesGuest;
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
        private Hotel_ManagerDataSet8 hotel_ManagerDataSet8;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private Hotel_ManagerDataSet8TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.Button BtnEdit;
        private Hotel_ManagerDataSet9 hotel_ManagerDataSet9;
        private System.Windows.Forms.BindingSource hotelManagerDataSet9BindingSource;
        private Hotel_ManagerDataSet10 hotel_ManagerDataSet10;
        private System.Windows.Forms.BindingSource reservationsBindingSource2;
        private Hotel_ManagerDataSet10TableAdapters.ReservationsTableAdapter reservationsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditGuest;
        private Hotel_ManagerDataSet21 hotel_ManagerDataSet21;
        private System.Windows.Forms.BindingSource reservationServicesBindingSource;
        private Hotel_ManagerDataSet21TableAdapters.ReservationServicesTableAdapter reservationServicesTableAdapter;
        private System.Windows.Forms.DataGridView DataRequestServicesGuest;
        private Hotel_ManagerDataSet22 hotel_ManagerDataSet22;
        private System.Windows.Forms.BindingSource reservationServicesBindingSource1;
        private Hotel_ManagerDataSet22TableAdapters.ReservationServicesTableAdapter reservationServicesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationServiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}