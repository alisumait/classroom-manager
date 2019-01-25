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
    public partial class Bookings : Form
    {
        String username;
        int loopCounter = 0;
        public Bookings(String name)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.username = name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                bool check = false;
                SqlCommand cmd = new SqlCommand("SELECT COUNT(bookerName) FROM history WHERE bookerName = @param1", conn);
                cmd.CommandText = "SELECT COUNT(bookerName) FROM history WHERE bookerName = @param1";
                cmd.Parameters.AddWithValue("@param1", username);
                Int32 count = (Int32)cmd.ExecuteScalar();
                dataGridView1.RowCount = count;
                Console.WriteLine(count);
                cmd.Parameters.Clear();
                cmd = new SqlCommand("SELECT bookerName,slot_id,eventType,eventName,attendees,phoneNumber,additionals FROM history WHERE bookerName = @param1;", conn);
                cmd.Parameters.AddWithValue("@param1", username);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    int eventTIndex = reader.GetOrdinal("eventType");
                    int eventNIndex = reader.GetOrdinal("eventName");
                    int attIndex = reader.GetOrdinal("attendees");
                    int addIndex = reader.GetOrdinal("additionals");
                    while (reader.Read())  // one loop iteration per record returned from SELECT
                    {
                        check = true;
                        for (int i = 0; i < count; i++)
                        {
                            string eventType = reader.GetString(eventTIndex);
                            string eventName = reader.GetString(eventNIndex);
                            int attendees = reader.GetInt32(attIndex);
                            string additionals = reader.GetString(addIndex).ToString();
                            if (additionals.Equals(""))
                            {
                                additionals = "NO ADDITIONAL REQUESTS";
                            }
                            for (int k = 0; k < 6; k++)
                            {
                                Console.WriteLine("--------- " + attendees);
                                dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[k];
                                Console.WriteLine("++++++++++++++");
                                switch (k)
                                {
                                    case 0:
                                        dataGridView1.CurrentCell.Value = eventType;
                                        break;
                                    case 1:
                                        dataGridView1.CurrentCell.Value = eventName;
                                        break;
                                    case 4:
                                        dataGridView1.CurrentCell.Value = attendees;
                                        break;
                                    case 5:
                                        dataGridView1.CurrentCell.Value = additionals;
                                        break;
                                }
                            }
                            reader.Read();
                        }
                        loopCounter++;
                    }
                }
                conn.Open();
                cmd = new SqlCommand("SELECT startTime, endTime, date, bookerName FROM slots, history WHERE slots.slot_id = history.slot_id", conn);
                cmd.ExecuteNonQuery();
                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    int startIndex = reader.GetOrdinal("startTime");
                    int endIndex = reader.GetOrdinal("endTime");
                    int dateIndex = reader.GetOrdinal("date");

                    while (reader.Read())  // one loop iteration per record returned from SELECT
                    {
                        int fromHour = reader.GetInt32(startIndex) / 60;
                        int fromMins = reader.GetInt32(startIndex) % 60;
                        DateTime dateformat = reader.GetDateTime(dateIndex);
                        int toHour = reader.GetInt32(endIndex) / 60;
                        int toMins = reader.GetInt32(endIndex) % 60;
                        String from = fromHour.ToString("00") + ":" + fromMins.ToString("00") + " - ";
                        String to = toHour.ToString("00") + ":" + toMins.ToString("00");
                        String time = from + to;
                        Console.WriteLine("------------- " + time);
                        String date = dateformat.ToString("yyyy-MM-dd");

                        for (int i = 0; i < count; i++)
                        {
                            for (int k = 0; k < 6; k++)
                            {
                                dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[k];
                                switch (k)
                                {
                                    case 2:
                                        dataGridView1.CurrentCell.Value = date;
                                        break;
                                    case 3:
                                        dataGridView1.CurrentCell.Value = time;
                                        break;
                                }
                            }
                        }
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("No History Available");
                    this.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
