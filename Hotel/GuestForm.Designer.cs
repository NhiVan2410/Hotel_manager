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
            this.TabGuest = new System.Windows.Forms.TabControl();
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
            this.TxtReservationIDRS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagerDataSet6 = new Hotel.Hotel_ManagerDataSet6();
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
            this.LblNameGF = new System.Windows.Forms.Label();
            this.BtnLogoutGF = new System.Windows.Forms.Button();
            this.LblRoleGF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PageViewRoomGuest = new System.Windows.Forms.TabPage();
            this.LblViewRoomGuest = new System.Windows.Forms.Label();
            this.CmbRoomTypeVR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSubmitVR = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblSubmitPassWordRegister = new System.Windows.Forms.Label();
            this.LblAddressRegister = new System.Windows.Forms.Label();
            this.LblPhoneNumberRegister = new System.Windows.Forms.Label();
            this.LblDateOfBirthRegister = new System.Windows.Forms.Label();
            this.LblGenderRegister = new System.Windows.Forms.Label();
            this.LnkRegister = new System.Windows.Forms.LinkLabel();
            this.LblUserNameRegister = new System.Windows.Forms.Label();
            this.LblPassWordRegister = new System.Windows.Forms.Label();
            this.LblNameRoom = new System.Windows.Forms.Label();
            this.LblBedType = new System.Windows.Forms.Label();
            this.LblAvailableRooms = new System.Windows.Forms.Label();
            this.LblCapacityRoom = new System.Windows.Forms.Label();
            this.LblAmenities = new System.Windows.Forms.Label();
            this.LblBathroomType = new System.Windows.Forms.Label();
            this.LblIncludedServices = new System.Windows.Forms.Label();
            this.TabGuest.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet6)).BeginInit();
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
            this.PageViewRoomGuest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGuest
            // 
            this.TabGuest.Controls.Add(this.PageCustomerInformation);
            this.TabGuest.Controls.Add(this.PageBookngGuest);
            this.TabGuest.Controls.Add(this.PageBookingHistoryGuest);
            this.TabGuest.Controls.Add(this.PageViewRoomGuest);
            this.TabGuest.Controls.Add(this.PageRequestServicesGuest);
            this.TabGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGuest.Location = new System.Drawing.Point(351, 195);
            this.TabGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TabGuest.Name = "TabGuest";
            this.TabGuest.SelectedIndex = 0;
            this.TabGuest.Size = new System.Drawing.Size(2392, 1615);
            this.TabGuest.TabIndex = 1;
            // 
            // PageCustomerInformation
            // 
            this.PageCustomerInformation.BackColor = System.Drawing.Color.Lime;
            this.PageCustomerInformation.BackgroundImage = global::Hotel.Properties.Resources._0e83fe416785d8c995f664d65a68a73e;
            this.PageCustomerInformation.Controls.Add(this.groupBox1);
            this.PageCustomerInformation.ForeColor = System.Drawing.Color.Silver;
            this.PageCustomerInformation.Location = new System.Drawing.Point(8, 51);
            this.PageCustomerInformation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageCustomerInformation.Name = "PageCustomerInformation";
            this.PageCustomerInformation.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageCustomerInformation.Size = new System.Drawing.Size(2376, 1556);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(2366, 1544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Image = global::Hotel.Properties.Resources.icons8_edit_26;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(1541, 464);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(403, 79);
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
            this.BtnDelete.Location = new System.Drawing.Point(1541, 835);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(403, 79);
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
            this.BtnUpdate.Location = new System.Drawing.Point(1541, 654);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(403, 79);
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
            this.BtnAddGuest.Location = new System.Drawing.Point(1541, 272);
            this.BtnAddGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddGuest.Name = "BtnAddGuest";
            this.BtnAddGuest.Size = new System.Drawing.Size(403, 79);
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
            this.GrBoxGenderGuest.Location = new System.Drawing.Point(640, 322);
            this.GrBoxGenderGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GrBoxGenderGuest.Name = "GrBoxGenderGuest";
            this.GrBoxGenderGuest.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GrBoxGenderGuest.Size = new System.Drawing.Size(645, 68);
            this.GrBoxGenderGuest.TabIndex = 5;
            this.GrBoxGenderGuest.TabStop = false;
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadOther.ForeColor = System.Drawing.Color.Black;
            this.RadOther.Location = new System.Drawing.Point(464, 28);
            this.RadOther.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RadOther.Name = "RadOther";
            this.RadOther.Size = new System.Drawing.Size(102, 30);
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
            this.RadFemale.Location = new System.Drawing.Point(236, 29);
            this.RadFemale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(122, 30);
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
            this.RadMale.Location = new System.Drawing.Point(32, 28);
            this.RadMale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(94, 30);
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
            this.DataCustomerGuest.Location = new System.Drawing.Point(459, 1071);
            this.DataCustomerGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DataCustomerGuest.Name = "DataCustomerGuest";
            this.DataCustomerGuest.RowHeadersVisible = false;
            this.DataCustomerGuest.RowHeadersWidth = 62;
            this.DataCustomerGuest.RowTemplate.Height = 28;
            this.DataCustomerGuest.Size = new System.Drawing.Size(1531, 289);
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
            this.DtpDateGuest.Location = new System.Drawing.Point(640, 481);
            this.DtpDateGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DtpDateGuest.Name = "DtpDateGuest";
            this.DtpDateGuest.Size = new System.Drawing.Size(641, 32);
            this.DtpDateGuest.TabIndex = 4;
            // 
            // TxtEmailGuest
            // 
            this.TxtEmailGuest.Location = new System.Drawing.Point(640, 914);
            this.TxtEmailGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtEmailGuest.Name = "TxtEmailGuest";
            this.TxtEmailGuest.Size = new System.Drawing.Size(641, 44);
            this.TxtEmailGuest.TabIndex = 2;
            // 
            // TxtAddressGuest
            // 
            this.TxtAddressGuest.Location = new System.Drawing.Point(640, 768);
            this.TxtAddressGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtAddressGuest.Name = "TxtAddressGuest";
            this.TxtAddressGuest.Size = new System.Drawing.Size(641, 44);
            this.TxtAddressGuest.TabIndex = 2;
            // 
            // TxtPhoneNumberGuest
            // 
            this.TxtPhoneNumberGuest.Location = new System.Drawing.Point(640, 611);
            this.TxtPhoneNumberGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtPhoneNumberGuest.Name = "TxtPhoneNumberGuest";
            this.TxtPhoneNumberGuest.Size = new System.Drawing.Size(641, 44);
            this.TxtPhoneNumberGuest.TabIndex = 2;
            // 
            // TxtUserNameGuest
            // 
            this.TxtUserNameGuest.Location = new System.Drawing.Point(640, 206);
            this.TxtUserNameGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtUserNameGuest.Name = "TxtUserNameGuest";
            this.TxtUserNameGuest.Size = new System.Drawing.Size(641, 44);
            this.TxtUserNameGuest.TabIndex = 2;
            // 
            // LblEmailGuest
            // 
            this.LblEmailGuest.AutoSize = true;
            this.LblEmailGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblEmailGuest.Location = new System.Drawing.Point(96, 925);
            this.LblEmailGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEmailGuest.Name = "LblEmailGuest";
            this.LblEmailGuest.Size = new System.Drawing.Size(132, 37);
            this.LblEmailGuest.TabIndex = 1;
            this.LblEmailGuest.Text = "Email : ";
            // 
            // LblAddressGuest
            // 
            this.LblAddressGuest.AutoSize = true;
            this.LblAddressGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblAddressGuest.Location = new System.Drawing.Point(96, 779);
            this.LblAddressGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblAddressGuest.Name = "LblAddressGuest";
            this.LblAddressGuest.Size = new System.Drawing.Size(172, 37);
            this.LblAddressGuest.TabIndex = 1;
            this.LblAddressGuest.Text = "Address : ";
            // 
            // LblPhoneNumberGuest
            // 
            this.LblPhoneNumberGuest.AutoSize = true;
            this.LblPhoneNumberGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumberGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblPhoneNumberGuest.Location = new System.Drawing.Point(96, 618);
            this.LblPhoneNumberGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPhoneNumberGuest.Name = "LblPhoneNumberGuest";
            this.LblPhoneNumberGuest.Size = new System.Drawing.Size(275, 37);
            this.LblPhoneNumberGuest.TabIndex = 1;
            this.LblPhoneNumberGuest.Text = "Phone Number : ";
            // 
            // LblGenderGuest
            // 
            this.LblGenderGuest.AutoSize = true;
            this.LblGenderGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenderGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblGenderGuest.Location = new System.Drawing.Point(96, 342);
            this.LblGenderGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGenderGuest.Name = "LblGenderGuest";
            this.LblGenderGuest.Size = new System.Drawing.Size(159, 37);
            this.LblGenderGuest.TabIndex = 1;
            this.LblGenderGuest.Text = "Gender : ";
            // 
            // LblDateGuest
            // 
            this.LblDateGuest.AutoSize = true;
            this.LblDateGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblDateGuest.Location = new System.Drawing.Point(96, 490);
            this.LblDateGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDateGuest.Name = "LblDateGuest";
            this.LblDateGuest.Size = new System.Drawing.Size(225, 37);
            this.LblDateGuest.TabIndex = 1;
            this.LblDateGuest.Text = "Date of birth :";
            // 
            // LblUserNameGuest
            // 
            this.LblUserNameGuest.AutoSize = true;
            this.LblUserNameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserNameGuest.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LblUserNameGuest.Location = new System.Drawing.Point(96, 218);
            this.LblUserNameGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblUserNameGuest.Name = "LblUserNameGuest";
            this.LblUserNameGuest.Size = new System.Drawing.Size(137, 37);
            this.LblUserNameGuest.TabIndex = 1;
            this.LblUserNameGuest.Text = "Name : ";
            // 
            // LblGuestInformation
            // 
            this.LblGuestInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuestInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblGuestInformation.Image = global::Hotel.Properties.Resources.icons8_neighbor_50;
            this.LblGuestInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblGuestInformation.Location = new System.Drawing.Point(699, 60);
            this.LblGuestInformation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGuestInformation.Name = "LblGuestInformation";
            this.LblGuestInformation.Size = new System.Drawing.Size(885, 89);
            this.LblGuestInformation.TabIndex = 0;
            this.LblGuestInformation.Text = "Guest Information";
            this.LblGuestInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBookngGuest
            // 
            this.PageBookngGuest.BackgroundImage = global::Hotel.Properties.Resources._9689e526b6e6b1ac527e8e436d797dbb;
            this.PageBookngGuest.Controls.Add(this.groupBox2);
            this.PageBookngGuest.Location = new System.Drawing.Point(8, 51);
            this.PageBookngGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageBookngGuest.Name = "PageBookngGuest";
            this.PageBookngGuest.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageBookngGuest.Size = new System.Drawing.Size(2376, 1556);
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
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(2366, 1544);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // DataBookingGuest
            // 
            this.DataBookingGuest.AutoGenerateColumns = false;
            this.DataBookingGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DataBookingGuest.Location = new System.Drawing.Point(437, 939);
            this.DataBookingGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DataBookingGuest.Name = "DataBookingGuest";
            this.DataBookingGuest.RowHeadersVisible = false;
            this.DataBookingGuest.RowHeadersWidth = 30;
            this.DataBookingGuest.RowTemplate.Height = 28;
            this.DataBookingGuest.Size = new System.Drawing.Size(1448, 314);
            this.DataBookingGuest.TabIndex = 1;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
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
            this.BtnEditBooking.Location = new System.Drawing.Point(1635, 429);
            this.BtnEditBooking.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnEditBooking.Name = "BtnEditBooking";
            this.BtnEditBooking.Size = new System.Drawing.Size(412, 85);
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
            this.BtnCancelBooking.Location = new System.Drawing.Point(1635, 606);
            this.BtnCancelBooking.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnCancelBooking.Name = "BtnCancelBooking";
            this.BtnCancelBooking.Size = new System.Drawing.Size(412, 85);
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
            this.BtnAddBooking.Location = new System.Drawing.Point(1635, 261);
            this.BtnAddBooking.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddBooking.Name = "BtnAddBooking";
            this.BtnAddBooking.Size = new System.Drawing.Size(412, 85);
            this.BtnAddBooking.TabIndex = 4;
            this.BtnAddBooking.Text = "Add";
            this.BtnAddBooking.UseVisualStyleBackColor = false;
            // 
            // DtpCheckIn
            // 
            this.DtpCheckIn.CustomFormat = "dd/MM/yyyy hh : mm : ss";
            this.DtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCheckIn.Location = new System.Drawing.Point(635, 525);
            this.DtpCheckIn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DtpCheckIn.Name = "DtpCheckIn";
            this.DtpCheckIn.Size = new System.Drawing.Size(673, 38);
            this.DtpCheckIn.TabIndex = 3;
            // 
            // DtpCheckOut
            // 
            this.DtpCheckOut.CustomFormat = "dd/MM/yyyy hh : mm : ss";
            this.DtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCheckOut.Location = new System.Drawing.Point(635, 696);
            this.DtpCheckOut.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DtpCheckOut.Name = "DtpCheckOut";
            this.DtpCheckOut.Size = new System.Drawing.Size(673, 38);
            this.DtpCheckOut.TabIndex = 3;
            // 
            // CmbRoomGuest
            // 
            this.CmbRoomGuest.FormattingEnabled = true;
            this.CmbRoomGuest.Location = new System.Drawing.Point(635, 371);
            this.CmbRoomGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CmbRoomGuest.Name = "CmbRoomGuest";
            this.CmbRoomGuest.Size = new System.Drawing.Size(673, 45);
            this.CmbRoomGuest.TabIndex = 2;
            // 
            // CmbCustomerGuest
            // 
            this.CmbCustomerGuest.FormattingEnabled = true;
            this.CmbCustomerGuest.Location = new System.Drawing.Point(635, 229);
            this.CmbCustomerGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CmbCustomerGuest.Name = "CmbCustomerGuest";
            this.CmbCustomerGuest.Size = new System.Drawing.Size(673, 45);
            this.CmbCustomerGuest.TabIndex = 2;
            // 
            // LblRoomGuest
            // 
            this.LblRoomGuest.AutoSize = true;
            this.LblRoomGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoomGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblRoomGuest.Location = new System.Drawing.Point(197, 386);
            this.LblRoomGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRoomGuest.Name = "LblRoomGuest";
            this.LblRoomGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblRoomGuest.Size = new System.Drawing.Size(136, 37);
            this.LblRoomGuest.TabIndex = 1;
            this.LblRoomGuest.Text = "Room : ";
            // 
            // LblCheckInGuest
            // 
            this.LblCheckInGuest.AutoSize = true;
            this.LblCheckInGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckInGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblCheckInGuest.Location = new System.Drawing.Point(197, 536);
            this.LblCheckInGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCheckInGuest.Name = "LblCheckInGuest";
            this.LblCheckInGuest.Size = new System.Drawing.Size(180, 37);
            this.LblCheckInGuest.TabIndex = 1;
            this.LblCheckInGuest.Text = "Check In : ";
            // 
            // LblCheckOutGuest
            // 
            this.LblCheckOutGuest.AutoSize = true;
            this.LblCheckOutGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckOutGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblCheckOutGuest.Location = new System.Drawing.Point(197, 696);
            this.LblCheckOutGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCheckOutGuest.Name = "LblCheckOutGuest";
            this.LblCheckOutGuest.Size = new System.Drawing.Size(207, 37);
            this.LblCheckOutGuest.TabIndex = 1;
            this.LblCheckOutGuest.Text = "Check Out : ";
            // 
            // LblCustomerGuest
            // 
            this.LblCustomerGuest.AutoSize = true;
            this.LblCustomerGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblCustomerGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblCustomerGuest.Location = new System.Drawing.Point(197, 244);
            this.LblCustomerGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCustomerGuest.Name = "LblCustomerGuest";
            this.LblCustomerGuest.Size = new System.Drawing.Size(184, 37);
            this.LblCustomerGuest.TabIndex = 1;
            this.LblCustomerGuest.Text = "Customer :";
            // 
            // LblBookingGuest
            // 
            this.LblBookingGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingGuest.ForeColor = System.Drawing.Color.Bisque;
            this.LblBookingGuest.Image = global::Hotel.Properties.Resources.icons8_booking_48;
            this.LblBookingGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBookingGuest.Location = new System.Drawing.Point(840, 60);
            this.LblBookingGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblBookingGuest.Name = "LblBookingGuest";
            this.LblBookingGuest.Size = new System.Drawing.Size(541, 89);
            this.LblBookingGuest.TabIndex = 0;
            this.LblBookingGuest.Text = "Booking";
            this.LblBookingGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBookingHistoryGuest
            // 
            this.PageBookingHistoryGuest.BackColor = System.Drawing.Color.OliveDrab;
            this.PageBookingHistoryGuest.BackgroundImage = global::Hotel.Properties.Resources._2ecf9b191b582f7cdd650c624ca14bad;
            this.PageBookingHistoryGuest.Controls.Add(this.BtnEditFeedBack);
            this.PageBookingHistoryGuest.Controls.Add(this.DataBookingHistoryGuest);
            this.PageBookingHistoryGuest.Controls.Add(this.LblBookingHistoryGuest);
            this.PageBookingHistoryGuest.Location = new System.Drawing.Point(8, 51);
            this.PageBookingHistoryGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageBookingHistoryGuest.Name = "PageBookingHistoryGuest";
            this.PageBookingHistoryGuest.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageBookingHistoryGuest.Size = new System.Drawing.Size(2376, 1556);
            this.PageBookingHistoryGuest.TabIndex = 3;
            this.PageBookingHistoryGuest.Text = "BookingHistory";
            // 
            // BtnEditFeedBack
            // 
            this.BtnEditFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditFeedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEditFeedBack.Image = global::Hotel.Properties.Resources.icons8_feedback_48;
            this.BtnEditFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditFeedBack.Location = new System.Drawing.Point(884, 1165);
            this.BtnEditFeedBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnEditFeedBack.Name = "BtnEditFeedBack";
            this.BtnEditFeedBack.Size = new System.Drawing.Size(692, 122);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingHistoryGuest.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataBookingHistoryGuest.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataBookingHistoryGuest.Location = new System.Drawing.Point(204, 294);
            this.DataBookingHistoryGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DataBookingHistoryGuest.Name = "DataBookingHistoryGuest";
            this.DataBookingHistoryGuest.RowHeadersVisible = false;
            this.DataBookingHistoryGuest.RowHeadersWidth = 62;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBookingHistoryGuest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataBookingHistoryGuest.Size = new System.Drawing.Size(2012, 740);
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
            this.LblBookingHistoryGuest.Location = new System.Drawing.Point(868, 136);
            this.LblBookingHistoryGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblBookingHistoryGuest.Name = "LblBookingHistoryGuest";
            this.LblBookingHistoryGuest.Size = new System.Drawing.Size(853, 104);
            this.LblBookingHistoryGuest.TabIndex = 0;
            this.LblBookingHistoryGuest.Text = "Booking History";
            this.LblBookingHistoryGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageRequestServicesGuest
            // 
            this.PageRequestServicesGuest.BackgroundImage = global::Hotel.Properties.Resources.b84517d81f7ee3cb0ceff696c74e91b5;
            this.PageRequestServicesGuest.Controls.Add(this.groupBox4);
            this.PageRequestServicesGuest.Location = new System.Drawing.Point(8, 51);
            this.PageRequestServicesGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageRequestServicesGuest.Name = "PageRequestServicesGuest";
            this.PageRequestServicesGuest.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageRequestServicesGuest.Size = new System.Drawing.Size(2376, 1556);
            this.PageRequestServicesGuest.TabIndex = 4;
            this.PageRequestServicesGuest.Text = "Request Services";
            this.PageRequestServicesGuest.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtReservationIDRS);
            this.groupBox4.Controls.Add(this.label6);
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
            this.groupBox4.Location = new System.Drawing.Point(5, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Size = new System.Drawing.Size(2366, 1544);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // TxtReservationIDRS
            // 
            this.TxtReservationIDRS.Location = new System.Drawing.Point(675, 392);
            this.TxtReservationIDRS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtReservationIDRS.Name = "TxtReservationIDRS";
            this.TxtReservationIDRS.Size = new System.Drawing.Size(805, 44);
            this.TxtReservationIDRS.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(291, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reservation ID : ";
            // 
            // DataRequestServicesGuest
            // 
            this.DataRequestServicesGuest.AutoGenerateColumns = false;
            this.DataRequestServicesGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataRequestServicesGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRequestServicesGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationServiceIDDataGridViewTextBoxColumn,
            this.reservationIDDataGridViewTextBoxColumn2,
            this.serviceIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.DataRequestServicesGuest.DataSource = this.reservationServicesBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataRequestServicesGuest.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataRequestServicesGuest.EnableHeadersVisualStyles = false;
            this.DataRequestServicesGuest.Location = new System.Drawing.Point(296, 700);
            this.DataRequestServicesGuest.Margin = new System.Windows.Forms.Padding(4);
            this.DataRequestServicesGuest.Name = "DataRequestServicesGuest";
            this.DataRequestServicesGuest.RowHeadersVisible = false;
            this.DataRequestServicesGuest.RowHeadersWidth = 62;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataRequestServicesGuest.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataRequestServicesGuest.RowTemplate.Height = 28;
            this.DataRequestServicesGuest.Size = new System.Drawing.Size(1760, 554);
            this.DataRequestServicesGuest.TabIndex = 7;
            // 
            // reservationServiceIDDataGridViewTextBoxColumn
            // 
            this.reservationServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationServiceID";
            this.reservationServiceIDDataGridViewTextBoxColumn.HeaderText = "ReservationServiceID";
            this.reservationServiceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationServiceIDDataGridViewTextBoxColumn.Name = "reservationServiceIDDataGridViewTextBoxColumn";
            this.reservationServiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationIDDataGridViewTextBoxColumn2
            // 
            this.reservationIDDataGridViewTextBoxColumn2.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn2.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn2.Name = "reservationIDDataGridViewTextBoxColumn2";
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
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
            this.BtnEditGuest.Location = new System.Drawing.Point(1788, 490);
            this.BtnEditGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnEditGuest.Name = "BtnEditGuest";
            this.BtnEditGuest.Size = new System.Drawing.Size(268, 54);
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
            this.BtnAddServices.Location = new System.Drawing.Point(1788, 351);
            this.BtnAddServices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddServices.Name = "BtnAddServices";
            this.BtnAddServices.Size = new System.Drawing.Size(268, 66);
            this.BtnAddServices.TabIndex = 6;
            this.BtnAddServices.Text = "Add";
            this.BtnAddServices.UseVisualStyleBackColor = true;
            // 
            // NumQuantityGuest
            // 
            this.NumQuantityGuest.Location = new System.Drawing.Point(675, 479);
            this.NumQuantityGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.NumQuantityGuest.Size = new System.Drawing.Size(805, 44);
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
            this.CmbServicesGuest.Location = new System.Drawing.Point(675, 306);
            this.CmbServicesGuest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CmbServicesGuest.Name = "CmbServicesGuest";
            this.CmbServicesGuest.Size = new System.Drawing.Size(801, 45);
            this.CmbServicesGuest.TabIndex = 3;
            // 
            // LblQuantityGuest
            // 
            this.LblQuantityGuest.AutoSize = true;
            this.LblQuantityGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantityGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblQuantityGuest.Location = new System.Drawing.Point(288, 475);
            this.LblQuantityGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblQuantityGuest.Name = "LblQuantityGuest";
            this.LblQuantityGuest.Size = new System.Drawing.Size(193, 44);
            this.LblQuantityGuest.TabIndex = 2;
            this.LblQuantityGuest.Text = "Quantity :";
            // 
            // LblServiceGuest
            // 
            this.LblServiceGuest.AutoSize = true;
            this.LblServiceGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblServiceGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblServiceGuest.Location = new System.Drawing.Point(288, 315);
            this.LblServiceGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblServiceGuest.Name = "LblServiceGuest";
            this.LblServiceGuest.Size = new System.Drawing.Size(187, 44);
            this.LblServiceGuest.TabIndex = 1;
            this.LblServiceGuest.Text = "Service : ";
            // 
            // LblRequestServicesGuest
            // 
            this.LblRequestServicesGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequestServicesGuest.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.LblRequestServicesGuest.Image = global::Hotel.Properties.Resources.icons8_services_50;
            this.LblRequestServicesGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRequestServicesGuest.Location = new System.Drawing.Point(771, 111);
            this.LblRequestServicesGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRequestServicesGuest.Name = "LblRequestServicesGuest";
            this.LblRequestServicesGuest.Size = new System.Drawing.Size(944, 89);
            this.LblRequestServicesGuest.TabIndex = 0;
            this.LblRequestServicesGuest.Text = "Request Services";
            this.LblRequestServicesGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LblNameGF
            // 
            this.LblNameGF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameGF.Location = new System.Drawing.Point(2247, 90);
            this.LblNameGF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNameGF.Name = "LblNameGF";
            this.LblNameGF.Size = new System.Drawing.Size(475, 36);
            this.LblNameGF.TabIndex = 19;
            this.LblNameGF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnLogoutGF
            // 
            this.BtnLogoutGF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnLogoutGF.ForeColor = System.Drawing.Color.DimGray;
            this.BtnLogoutGF.Location = new System.Drawing.Point(2604, 187);
            this.BtnLogoutGF.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogoutGF.Name = "BtnLogoutGF";
            this.BtnLogoutGF.Size = new System.Drawing.Size(114, 38);
            this.BtnLogoutGF.TabIndex = 18;
            this.BtnLogoutGF.Text = "Log out";
            this.BtnLogoutGF.UseVisualStyleBackColor = false;
            // 
            // LblRoleGF
            // 
            this.LblRoleGF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRoleGF.Location = new System.Drawing.Point(2464, 135);
            this.LblRoleGF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRoleGF.Name = "LblRoleGF";
            this.LblRoleGF.Size = new System.Drawing.Size(254, 44);
            this.LblRoleGF.TabIndex = 17;
            this.LblRoleGF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(340, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hotel && Resort";
            // 
            // PageViewRoomGuest
            // 
            this.PageViewRoomGuest.BackgroundImage = global::Hotel.Properties.Resources._7a86fbeeb9b812b527f0e07d5ff3f0c1;
            this.PageViewRoomGuest.Controls.Add(this.groupBox3);
            this.PageViewRoomGuest.Controls.Add(this.BtnSubmitVR);
            this.PageViewRoomGuest.Controls.Add(this.CmbRoomTypeVR);
            this.PageViewRoomGuest.Controls.Add(this.label2);
            this.PageViewRoomGuest.Controls.Add(this.LblViewRoomGuest);
            this.PageViewRoomGuest.Location = new System.Drawing.Point(8, 51);
            this.PageViewRoomGuest.Name = "PageViewRoomGuest";
            this.PageViewRoomGuest.Padding = new System.Windows.Forms.Padding(3);
            this.PageViewRoomGuest.Size = new System.Drawing.Size(2376, 1556);
            this.PageViewRoomGuest.TabIndex = 5;
            this.PageViewRoomGuest.Text = "View Room";
            this.PageViewRoomGuest.UseVisualStyleBackColor = true;
            // 
            // LblViewRoomGuest
            // 
            this.LblViewRoomGuest.BackColor = System.Drawing.Color.Transparent;
            this.LblViewRoomGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewRoomGuest.ForeColor = System.Drawing.Color.Transparent;
            this.LblViewRoomGuest.Image = global::Hotel.Properties.Resources.icons8_hotel_room_50;
            this.LblViewRoomGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblViewRoomGuest.Location = new System.Drawing.Point(817, 83);
            this.LblViewRoomGuest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblViewRoomGuest.Name = "LblViewRoomGuest";
            this.LblViewRoomGuest.Size = new System.Drawing.Size(853, 104);
            this.LblViewRoomGuest.TabIndex = 1;
            this.LblViewRoomGuest.Text = "View Room";
            this.LblViewRoomGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbRoomTypeVR
            // 
            this.CmbRoomTypeVR.FormattingEnabled = true;
            this.CmbRoomTypeVR.Location = new System.Drawing.Point(935, 262);
            this.CmbRoomTypeVR.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CmbRoomTypeVR.Name = "CmbRoomTypeVR";
            this.CmbRoomTypeVR.Size = new System.Drawing.Size(938, 45);
            this.CmbRoomTypeVR.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(553, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(220, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Type : ";
            // 
            // BtnSubmitVR
            // 
            this.BtnSubmitVR.Location = new System.Drawing.Point(1149, 385);
            this.BtnSubmitVR.Name = "BtnSubmitVR";
            this.BtnSubmitVR.Size = new System.Drawing.Size(175, 57);
            this.BtnSubmitVR.TabIndex = 5;
            this.BtnSubmitVR.Text = "Submit";
            this.BtnSubmitVR.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LblIncludedServices);
            this.groupBox3.Controls.Add(this.LblBathroomType);
            this.groupBox3.Controls.Add(this.LblAmenities);
            this.groupBox3.Controls.Add(this.LblCapacityRoom);
            this.groupBox3.Controls.Add(this.LblAvailableRooms);
            this.groupBox3.Controls.Add(this.LblBedType);
            this.groupBox3.Controls.Add(this.LblNameRoom);
            this.groupBox3.Controls.Add(this.LblSubmitPassWordRegister);
            this.groupBox3.Controls.Add(this.LblAddressRegister);
            this.groupBox3.Controls.Add(this.LblPhoneNumberRegister);
            this.groupBox3.Controls.Add(this.LblDateOfBirthRegister);
            this.groupBox3.Controls.Add(this.LblGenderRegister);
            this.groupBox3.Controls.Add(this.LnkRegister);
            this.groupBox3.Controls.Add(this.LblUserNameRegister);
            this.groupBox3.Controls.Add(this.LblPassWordRegister);
            this.groupBox3.Location = new System.Drawing.Point(560, 522);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(1313, 916);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // LblSubmitPassWordRegister
            // 
            this.LblSubmitPassWordRegister.AutoSize = true;
            this.LblSubmitPassWordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubmitPassWordRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblSubmitPassWordRegister.Location = new System.Drawing.Point(133, 348);
            this.LblSubmitPassWordRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSubmitPassWordRegister.Name = "LblSubmitPassWordRegister";
            this.LblSubmitPassWordRegister.Size = new System.Drawing.Size(301, 37);
            this.LblSubmitPassWordRegister.TabIndex = 21;
            this.LblSubmitPassWordRegister.Text = "Available Rooms : ";
            // 
            // LblAddressRegister
            // 
            this.LblAddressRegister.AutoSize = true;
            this.LblAddressRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblAddressRegister.Location = new System.Drawing.Point(133, 800);
            this.LblAddressRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblAddressRegister.Name = "LblAddressRegister";
            this.LblAddressRegister.Size = new System.Drawing.Size(313, 37);
            this.LblAddressRegister.TabIndex = 16;
            this.LblAddressRegister.Text = "Included Services : ";
            // 
            // LblPhoneNumberRegister
            // 
            this.LblPhoneNumberRegister.AutoSize = true;
            this.LblPhoneNumberRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumberRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblPhoneNumberRegister.Location = new System.Drawing.Point(133, 690);
            this.LblPhoneNumberRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPhoneNumberRegister.Name = "LblPhoneNumberRegister";
            this.LblPhoneNumberRegister.Size = new System.Drawing.Size(279, 37);
            this.LblPhoneNumberRegister.TabIndex = 14;
            this.LblPhoneNumberRegister.Text = "Bathroom Type : ";
            // 
            // LblDateOfBirthRegister
            // 
            this.LblDateOfBirthRegister.AutoSize = true;
            this.LblDateOfBirthRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfBirthRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblDateOfBirthRegister.Location = new System.Drawing.Point(133, 583);
            this.LblDateOfBirthRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDateOfBirthRegister.Name = "LblDateOfBirthRegister";
            this.LblDateOfBirthRegister.Size = new System.Drawing.Size(196, 37);
            this.LblDateOfBirthRegister.TabIndex = 12;
            this.LblDateOfBirthRegister.Text = "Amenities : ";
            // 
            // LblGenderRegister
            // 
            this.LblGenderRegister.AutoSize = true;
            this.LblGenderRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenderRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblGenderRegister.Location = new System.Drawing.Point(133, 466);
            this.LblGenderRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGenderRegister.Name = "LblGenderRegister";
            this.LblGenderRegister.Size = new System.Drawing.Size(190, 37);
            this.LblGenderRegister.TabIndex = 7;
            this.LblGenderRegister.Text = "Bed Type : ";
            // 
            // LnkRegister
            // 
            this.LnkRegister.AutoSize = true;
            this.LnkRegister.LinkColor = System.Drawing.Color.OliveDrab;
            this.LnkRegister.Location = new System.Drawing.Point(396, 415);
            this.LnkRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LnkRegister.Name = "LnkRegister";
            this.LnkRegister.Size = new System.Drawing.Size(0, 37);
            this.LnkRegister.TabIndex = 4;
            // 
            // LblUserNameRegister
            // 
            this.LblUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserNameRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblUserNameRegister.Location = new System.Drawing.Point(133, 105);
            this.LblUserNameRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblUserNameRegister.Name = "LblUserNameRegister";
            this.LblUserNameRegister.Size = new System.Drawing.Size(333, 65);
            this.LblUserNameRegister.TabIndex = 4;
            this.LblUserNameRegister.Text = "Name : ";
            // 
            // LblPassWordRegister
            // 
            this.LblPassWordRegister.AutoSize = true;
            this.LblPassWordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassWordRegister.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblPassWordRegister.Location = new System.Drawing.Point(133, 221);
            this.LblPassWordRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPassWordRegister.Name = "LblPassWordRegister";
            this.LblPassWordRegister.Size = new System.Drawing.Size(179, 37);
            this.LblPassWordRegister.TabIndex = 4;
            this.LblPassWordRegister.Text = "Capacity : ";
            // 
            // LblNameRoom
            // 
            this.LblNameRoom.AutoSize = true;
            this.LblNameRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNameRoom.Location = new System.Drawing.Point(582, 105);
            this.LblNameRoom.Name = "LblNameRoom";
            this.LblNameRoom.Size = new System.Drawing.Size(0, 37);
            this.LblNameRoom.TabIndex = 22;
            // 
            // LblBedType
            // 
            this.LblBedType.AutoSize = true;
            this.LblBedType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblBedType.Location = new System.Drawing.Point(582, 466);
            this.LblBedType.Name = "LblBedType";
            this.LblBedType.Size = new System.Drawing.Size(0, 37);
            this.LblBedType.TabIndex = 23;
            // 
            // LblAvailableRooms
            // 
            this.LblAvailableRooms.AutoSize = true;
            this.LblAvailableRooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAvailableRooms.Location = new System.Drawing.Point(582, 348);
            this.LblAvailableRooms.Name = "LblAvailableRooms";
            this.LblAvailableRooms.Size = new System.Drawing.Size(0, 37);
            this.LblAvailableRooms.TabIndex = 24;
            // 
            // LblCapacityRoom
            // 
            this.LblCapacityRoom.AutoSize = true;
            this.LblCapacityRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCapacityRoom.Location = new System.Drawing.Point(582, 221);
            this.LblCapacityRoom.Name = "LblCapacityRoom";
            this.LblCapacityRoom.Size = new System.Drawing.Size(0, 37);
            this.LblCapacityRoom.TabIndex = 25;
            // 
            // LblAmenities
            // 
            this.LblAmenities.AutoSize = true;
            this.LblAmenities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAmenities.Location = new System.Drawing.Point(582, 583);
            this.LblAmenities.Name = "LblAmenities";
            this.LblAmenities.Size = new System.Drawing.Size(0, 37);
            this.LblAmenities.TabIndex = 26;
            // 
            // LblBathroomType
            // 
            this.LblBathroomType.AutoSize = true;
            this.LblBathroomType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblBathroomType.Location = new System.Drawing.Point(582, 690);
            this.LblBathroomType.Name = "LblBathroomType";
            this.LblBathroomType.Size = new System.Drawing.Size(0, 37);
            this.LblBathroomType.TabIndex = 27;
            // 
            // LblIncludedServices
            // 
            this.LblIncludedServices.AutoSize = true;
            this.LblIncludedServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblIncludedServices.Location = new System.Drawing.Point(582, 800);
            this.LblIncludedServices.Name = "LblIncludedServices";
            this.LblIncludedServices.Size = new System.Drawing.Size(0, 37);
            this.LblIncludedServices.TabIndex = 28;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(3011, 1879);
            this.Controls.Add(this.LblNameGF);
            this.Controls.Add(this.BtnLogoutGF);
            this.Controls.Add(this.LblRoleGF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabGuest);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.TabGuest.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagerDataSet6)).EndInit();
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
            this.PageViewRoomGuest.ResumeLayout(false);
            this.PageViewRoomGuest.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabGuest;
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
        private System.Windows.Forms.Label LblNameGF;
        private System.Windows.Forms.Button BtnLogoutGF;
        private System.Windows.Forms.Label LblRoleGF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReservationIDRS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage PageViewRoomGuest;
        private System.Windows.Forms.Label LblViewRoomGuest;
        private System.Windows.Forms.Button BtnSubmitVR;
        private System.Windows.Forms.ComboBox CmbRoomTypeVR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblSubmitPassWordRegister;
        private System.Windows.Forms.Label LblAddressRegister;
        private System.Windows.Forms.Label LblPhoneNumberRegister;
        private System.Windows.Forms.Label LblDateOfBirthRegister;
        private System.Windows.Forms.Label LblGenderRegister;
        private System.Windows.Forms.LinkLabel LnkRegister;
        private System.Windows.Forms.Label LblUserNameRegister;
        private System.Windows.Forms.Label LblPassWordRegister;
        private System.Windows.Forms.Label LblIncludedServices;
        private System.Windows.Forms.Label LblBathroomType;
        private System.Windows.Forms.Label LblAmenities;
        private System.Windows.Forms.Label LblCapacityRoom;
        private System.Windows.Forms.Label LblAvailableRooms;
        private System.Windows.Forms.Label LblBedType;
        private System.Windows.Forms.Label LblNameRoom;
    }
}