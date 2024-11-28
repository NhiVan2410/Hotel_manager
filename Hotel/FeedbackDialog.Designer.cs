namespace Hotel
{
    partial class FeedbackDialog
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
            this.LblFeedBack = new System.Windows.Forms.Label();
            this.TxtFeedBack = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblFeedbackScore = new System.Windows.Forms.Label();
            this.LblReservationID = new System.Windows.Forms.Label();
            this.NumFeedbackScore = new System.Windows.Forms.NumericUpDown();
            this.CmbReservationIDFeedback = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumFeedbackScore)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFeedBack
            // 
            this.LblFeedBack.AutoSize = true;
            this.LblFeedBack.BackColor = System.Drawing.Color.Transparent;
            this.LblFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFeedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblFeedBack.Location = new System.Drawing.Point(140, 344);
            this.LblFeedBack.Name = "LblFeedBack";
            this.LblFeedBack.Size = new System.Drawing.Size(344, 36);
            this.LblFeedBack.TabIndex = 0;
            this.LblFeedBack.Text = "Write Your FeedBack : ";
            this.LblFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtFeedBack
            // 
            this.TxtFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFeedBack.Location = new System.Drawing.Point(462, 283);
            this.TxtFeedBack.Name = "TxtFeedBack";
            this.TxtFeedBack.Size = new System.Drawing.Size(354, 189);
            this.TxtFeedBack.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Linen;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSave.Location = new System.Drawing.Point(200, 461);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(207, 37);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Linen;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCancel.Location = new System.Drawing.Point(618, 461);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(207, 37);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Image = global::Hotel.Properties.Resources.icons8_heart_48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 171);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thank you for staying and using our hotel\'s services. If you have any questions o" +
    "r concerns, feel free to provide feedback below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFeedbackScore
            // 
            this.LblFeedbackScore.AutoSize = true;
            this.LblFeedbackScore.BackColor = System.Drawing.Color.Transparent;
            this.LblFeedbackScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFeedbackScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblFeedbackScore.Location = new System.Drawing.Point(195, 246);
            this.LblFeedbackScore.Name = "LblFeedbackScore";
            this.LblFeedbackScore.Size = new System.Drawing.Size(275, 36);
            this.LblFeedbackScore.TabIndex = 4;
            this.LblFeedbackScore.Text = "FeedBack Score : ";
            this.LblFeedbackScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblReservationID
            // 
            this.LblReservationID.AutoSize = true;
            this.LblReservationID.BackColor = System.Drawing.Color.Transparent;
            this.LblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReservationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblReservationID.Location = new System.Drawing.Point(196, 189);
            this.LblReservationID.Name = "LblReservationID";
            this.LblReservationID.Size = new System.Drawing.Size(252, 36);
            this.LblReservationID.TabIndex = 5;
            this.LblReservationID.Text = "Reservation ID : ";
            this.LblReservationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumFeedbackScore
            // 
            this.NumFeedbackScore.Location = new System.Drawing.Point(462, 246);
            this.NumFeedbackScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumFeedbackScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumFeedbackScore.Name = "NumFeedbackScore";
            this.NumFeedbackScore.Size = new System.Drawing.Size(120, 30);
            this.NumFeedbackScore.TabIndex = 6;
            this.NumFeedbackScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbReservationIDFeedback
            // 
            this.CmbReservationIDFeedback.FormattingEnabled = true;
            this.CmbReservationIDFeedback.Location = new System.Drawing.Point(462, 189);
            this.CmbReservationIDFeedback.Name = "CmbReservationIDFeedback";
            this.CmbReservationIDFeedback.Size = new System.Drawing.Size(120, 33);
            this.CmbReservationIDFeedback.TabIndex = 7;
            // 
            // FeedbackDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources._7a86fbeeb9b812b527f0e07d5ff3f0c1;
            this.ClientSize = new System.Drawing.Size(991, 563);
            this.Controls.Add(this.CmbReservationIDFeedback);
            this.Controls.Add(this.NumFeedbackScore);
            this.Controls.Add(this.LblReservationID);
            this.Controls.Add(this.LblFeedbackScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtFeedBack);
            this.Controls.Add(this.LblFeedBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FeedbackDialog";
            this.Text = "FeedbackDialog";
            this.Load += new System.EventHandler(this.FeedbackDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumFeedbackScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFeedBack;
        private System.Windows.Forms.TextBox TxtFeedBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFeedbackScore;
        private System.Windows.Forms.Label LblReservationID;
        private System.Windows.Forms.NumericUpDown NumFeedbackScore;
        private System.Windows.Forms.ComboBox CmbReservationIDFeedback;
    }
}