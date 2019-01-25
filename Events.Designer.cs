namespace Appointment_Scheduling_System
{
    partial class Events
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
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventN = new System.Windows.Forms.TextBox();
            this.additionals = new System.Windows.Forms.RichTextBox();
            this.eventT = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phoneN = new System.Windows.Forms.TextBox();
            this.bookerN = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.attendeesN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesN)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(44, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Event Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(44, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Additionals:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Attendees No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(44, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Booker Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Event Type:";
            // 
            // eventN
            // 
            this.eventN.Location = new System.Drawing.Point(146, 85);
            this.eventN.Name = "eventN";
            this.eventN.Size = new System.Drawing.Size(182, 22);
            this.eventN.TabIndex = 1;
            // 
            // additionals
            // 
            this.additionals.Location = new System.Drawing.Point(146, 278);
            this.additionals.Name = "additionals";
            this.additionals.Size = new System.Drawing.Size(322, 96);
            this.additionals.TabIndex = 4;
            this.additionals.Text = "";
            // 
            // eventT
            // 
            this.eventT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eventT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventT.Font = new System.Drawing.Font("Open Sans", 8F);
            this.eventT.FormattingEnabled = true;
            this.eventT.Items.AddRange(new object[] {
            "Auditorium",
            "Engineering Laboratory",
            "Computing Laboratory",
            "Normal Classroom"});
            this.eventT.Location = new System.Drawing.Point(146, 34);
            this.eventT.Name = "eventT";
            this.eventT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventT.Size = new System.Drawing.Size(182, 26);
            this.eventT.TabIndex = 0;
            // 
            // phoneN
            // 
            this.phoneN.Location = new System.Drawing.Point(146, 179);
            this.phoneN.Name = "phoneN";
            this.phoneN.Size = new System.Drawing.Size(182, 22);
            this.phoneN.TabIndex = 2;
            this.phoneN.TextChanged += new System.EventHandler(this.phoneN_TextChanged);
            // 
            // bookerN
            // 
            this.bookerN.AutoSize = true;
            this.bookerN.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookerN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookerN.Location = new System.Drawing.Point(143, 133);
            this.bookerN.Name = "bookerN";
            this.bookerN.Size = new System.Drawing.Size(0, 18);
            this.bookerN.TabIndex = 36;
            // 
            // book
            // 
            this.book.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.book.BackColor = System.Drawing.Color.DodgerBlue;
            this.book.FlatAppearance.BorderSize = 0;
            this.book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(170, 395);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(89, 37);
            this.book.TabIndex = 5;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.Tomato;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(318, 395);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 37);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // attendeesN
            // 
            this.attendeesN.Location = new System.Drawing.Point(146, 228);
            this.attendeesN.Name = "attendeesN";
            this.attendeesN.Size = new System.Drawing.Size(182, 22);
            this.attendeesN.TabIndex = 3;
            this.attendeesN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 451);
            this.Controls.Add(this.attendeesN);
            this.Controls.Add(this.book);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.bookerN);
            this.Controls.Add(this.phoneN);
            this.Controls.Add(this.eventT);
            this.Controls.Add(this.additionals);
            this.Controls.Add(this.eventN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventN;
        private System.Windows.Forms.RichTextBox additionals;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox eventT;
        private System.Windows.Forms.TextBox phoneN;
        private System.Windows.Forms.Label bookerN;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown attendeesN;
    }
}