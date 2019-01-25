namespace Appointment_Scheduling_System
{
    partial class Manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showSchedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.additionals = new System.Windows.Forms.Label();
            this.eventType = new System.Windows.Forms.Label();
            this.bookerName = new System.Windows.Forms.Label();
            this.bookerPhone = new System.Windows.Forms.Label();
            this.attendees = new System.Windows.Forms.Label();
            this.reject = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.eventName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.bookings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(288, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(394, 525);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Block B";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Block D";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Block E";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // showSchedule
            // 
            this.showSchedule.BackColor = System.Drawing.Color.FloralWhite;
            this.showSchedule.FlatAppearance.BorderSize = 2;
            this.showSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSchedule.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSchedule.Location = new System.Drawing.Point(71, 241);
            this.showSchedule.Name = "showSchedule";
            this.showSchedule.Size = new System.Drawing.Size(123, 102);
            this.showSchedule.TabIndex = 3;
            this.showSchedule.Text = " Show  Schedules";
            this.showSchedule.UseVisualStyleBackColor = false;
            this.showSchedule.Click += new System.EventHandler(this.showSchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome:";
            // 
            // userWelcome
            // 
            this.userWelcome.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWelcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.userWelcome.Location = new System.Drawing.Point(36, 62);
            this.userWelcome.Name = "userWelcome";
            this.userWelcome.Size = new System.Drawing.Size(200, 27);
            this.userWelcome.TabIndex = 5;
            this.userWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please Choose a Date";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Tomato;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.logout.FlatAppearance.BorderSize = 2;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(71, 455);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(123, 37);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(704, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(704, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Booker Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(704, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attendees No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(704, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(704, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Additionals:";
            // 
            // additionals
            // 
            this.additionals.AutoSize = true;
            this.additionals.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.additionals.Location = new System.Drawing.Point(802, 293);
            this.additionals.MaximumSize = new System.Drawing.Size(150, 120);
            this.additionals.Name = "additionals";
            this.additionals.Size = new System.Drawing.Size(0, 18);
            this.additionals.TabIndex = 13;
            this.additionals.Click += new System.EventHandler(this.label7_Click);
            // 
            // eventType
            // 
            this.eventType.AutoSize = true;
            this.eventType.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventType.Location = new System.Drawing.Point(802, 50);
            this.eventType.MaximumSize = new System.Drawing.Size(150, 0);
            this.eventType.Name = "eventType";
            this.eventType.Size = new System.Drawing.Size(0, 18);
            this.eventType.TabIndex = 17;
            // 
            // bookerName
            // 
            this.bookerName.AutoSize = true;
            this.bookerName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookerName.Location = new System.Drawing.Point(802, 147);
            this.bookerName.MaximumSize = new System.Drawing.Size(150, 0);
            this.bookerName.Name = "bookerName";
            this.bookerName.Size = new System.Drawing.Size(0, 18);
            this.bookerName.TabIndex = 18;
            // 
            // bookerPhone
            // 
            this.bookerPhone.AutoSize = true;
            this.bookerPhone.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookerPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookerPhone.Location = new System.Drawing.Point(802, 196);
            this.bookerPhone.MaximumSize = new System.Drawing.Size(150, 0);
            this.bookerPhone.Name = "bookerPhone";
            this.bookerPhone.Size = new System.Drawing.Size(0, 18);
            this.bookerPhone.TabIndex = 19;
            // 
            // attendees
            // 
            this.attendees.AutoSize = true;
            this.attendees.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attendees.Location = new System.Drawing.Point(802, 244);
            this.attendees.MaximumSize = new System.Drawing.Size(150, 0);
            this.attendees.Name = "attendees";
            this.attendees.Size = new System.Drawing.Size(0, 18);
            this.attendees.TabIndex = 20;
            // 
            // reject
            // 
            this.reject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reject.BackColor = System.Drawing.Color.Tomato;
            this.reject.FlatAppearance.BorderSize = 0;
            this.reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reject.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject.ForeColor = System.Drawing.Color.White;
            this.reject.Location = new System.Drawing.Point(794, 457);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(75, 37);
            this.reject.TabIndex = 21;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = false;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // approve
            // 
            this.approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.approve.BackColor = System.Drawing.Color.DodgerBlue;
            this.approve.FlatAppearance.BorderSize = 0;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.Location = new System.Drawing.Point(697, 457);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(91, 37);
            this.approve.TabIndex = 22;
            this.approve.Text = "Approve";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventName.Location = new System.Drawing.Point(802, 97);
            this.eventName.MaximumSize = new System.Drawing.Size(150, 0);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(0, 18);
            this.eventName.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(704, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Event Name:";
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(41, 356);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(180, 23);
            this.warning.TabIndex = 25;
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(875, 457);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 37);
            this.cancel.TabIndex = 26;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookings
            // 
            this.bookings.BackColor = System.Drawing.Color.FloralWhite;
            this.bookings.FlatAppearance.BorderSize = 2;
            this.bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookings.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings.Location = new System.Drawing.Point(71, 401);
            this.bookings.Name = "bookings";
            this.bookings.Size = new System.Drawing.Size(123, 37);
            this.bookings.TabIndex = 27;
            this.bookings.Text = "Bookings";
            this.bookings.UseVisualStyleBackColor = false;
            this.bookings.Click += new System.EventHandler(this.bookings_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.bookings);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.attendees);
            this.Controls.Add(this.bookerPhone);
            this.Controls.Add(this.bookerName);
            this.Controls.Add(this.eventType);
            this.Controls.Add(this.additionals);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSchedule);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button showSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label additionals;
        private System.Windows.Forms.Label eventType;
        private System.Windows.Forms.Label bookerName;
        private System.Windows.Forms.Label bookerPhone;
        private System.Windows.Forms.Label attendees;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button bookings;
    }
}