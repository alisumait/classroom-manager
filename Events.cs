using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduling_System
{
    public partial class Events : Form
    {
        String username, slot;
        public Events(String username, String slot, bool require)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.username = username;
            this.slot = slot;
            if (!require)
            {
                additionals.Enabled = false;
            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            bookerN.Text = username;
            eventT.Text = "Auditorium";
        }

        private void phoneN_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void book_Click(object sender, EventArgs e)
        {
            if (eventN.Text != "" && eventT.Text != "" && attendeesN.Value > 0 && phoneN.Text != "")
            {
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO events(bookerName,slot_id,eventType,eventName,attendees,phoneNumber,additionals) values(@param1,@param2,@param3,@param4,@param5,@param6,@param7);", conn);

                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = username;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = slot;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = eventT.Text;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = eventN.Text;
                cmd.Parameters.Add("@param5", SqlDbType.Int).Value = attendeesN.Value;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = phoneN.Text;
                cmd.Parameters.Add("@param7", SqlDbType.Text).Value = additionals.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd = new SqlCommand("UPDATE slots SET status = @param1 WHERE slot_id = @param2", conn);

                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = 3;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = slot;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
        }
    }
}