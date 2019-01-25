namespace Appointment_Scheduling_System
{
    partial class Booker
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
            this.warning = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showSchedule = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.require = new System.Windows.Forms.CheckBox();
            this.bookings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(48, 385);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(180, 23);
            this.warning.TabIndex = 33;
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Tomato;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.logout.FlatAppearance.BorderSize = 2;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(78, 455);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(123, 37);
            this.logout.TabIndex = 32;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Please Choose a Date";
            // 
            // userWelcome
            // 
            this.userWelcome.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWelcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.userWelcome.Location = new System.Drawing.Point(43, 62);
            this.userWelcome.Name = "userWelcome";
            this.userWelcome.Size = new System.Drawing.Size(200, 27);
            this.userWelcome.TabIndex = 30;
            this.userWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Welcome:";
            // 
            // showSchedule
            // 
            this.showSchedule.BackColor = System.Drawing.Color.FloralWhite;
            this.showSchedule.FlatAppearance.BorderSize = 2;
            this.showSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSchedule.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSchedule.Location = new System.Drawing.Point(78, 270);
            this.showSchedule.Name = "showSchedule";
            this.showSchedule.Size = new System.Drawing.Size(123, 102);
            this.showSchedule.TabIndex = 28;
            this.showSchedule.Text = " Show  Schedules";
            this.showSchedule.UseVisualStyleBackColor = false;
            this.showSchedule.Click += new System.EventHandler(this.showSchedule_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(295, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(487, 525);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
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
            // require
            // 
            this.require.AutoSize = true;
            this.require.Location = new System.Drawing.Point(48, 191);
            this.require.Name = "require";
            this.require.Size = new System.Drawing.Size(204, 21);
            this.require.TabIndex = 34;
            this.require.Text = "I need additional equipment";
            this.require.UseVisualStyleBackColor = true;
            this.require.CheckedChanged += new System.EventHandler(this.require_CheckedChanged);
            // 
            // bookings
            // 
            this.bookings.BackColor = System.Drawing.Color.DodgerBlue;
            this.bookings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bookings.FlatAppearance.BorderSize = 2;
            this.bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookings.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings.ForeColor = System.Drawing.Color.White;
            this.bookings.Location = new System.Drawing.Point(820, 390);
            this.bookings.Name = "bookings";
            this.bookings.Size = new System.Drawing.Size(123, 102);
            this.bookings.TabIndex = 35;
            this.bookings.Text = "My Bookings";
            this.bookings.UseVisualStyleBackColor = false;
            this.bookings.Click += new System.EventHandler(this.bookings_Click);
            // 
            // Booker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.bookings);
            this.Controls.Add(this.require);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSchedule);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Booker";
            this.Text = "Booker";
            this.Load += new System.EventHandler(this.Booker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox require;
        private System.Windows.Forms.Button bookings;
    }
}