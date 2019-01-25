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
    public partial class Booker : Form
    {
        String username, chosenDate;
        bool firstTime;
        public Booker(String name)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.username = name;
            firstTime = true;
        }

        private void Booker_Load(object sender, EventArgs e)
        {

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(3);
            chosenDate = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd");
            dataGridView1.RowCount = 8;
            int count = 0;
            for (int i = 540; i <= 1020; i += 60)
            {
                int hour = i / 60;
                int mins = i % 60;
                String startTime = hour.ToString("00") + ":" + mins.ToString("00") + "\n";
                hour = (i + 60) / 60;
                mins = (i + 60) % 60;
                String endTime = hour.ToString("00") + ":" + mins.ToString("00");
                String time = startTime + endTime;
                dataGridView1.Rows[count].HeaderCell.Value = time;
                if (count == 7)
                {
                    break;
                }
                count += 1;
            }
            dataGridView1.AutoResizeRows();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            showSchedule.PerformClick();
            userWelcome.Text = username;
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String currentCell = dataGridView1.CurrentCell.Value.ToString();
            String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
            bool req = require.Checked;
            Events events = new Events(username, slot_id,req);
            events.ShowDialog();
        }

        private void showSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT slot_id,block,date,startTime,endTime,status FROM slots WHERE date = @param1;", conn);
                cmd.CommandText = "SELECT slot_id,block,date,startTime,endTime,status FROM slots WHERE date = @param1;";
                cmd.Parameters.AddWithValue("@param1", chosenDate);
                cmd.ExecuteNonQuery();
                bool check = false;
                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    int slotIndex = reader.GetOrdinal("slot_id");
                    int blockIndex = reader.GetOrdinal("block");
                    int fromIndex = reader.GetOrdinal("startTime");
                    int toIndex = reader.GetOrdinal("endTime");
                    int statusIndex = reader.GetOrdinal("status");
                    while (reader.Read())  // one loop iteration per record returned from SELECT
                    {
                        check = true;
                        string slotID = reader.GetString(slotIndex);
                        string block = reader.GetString(blockIndex);
                        int status = reader.GetInt32(statusIndex);
                        int fromHour = reader.GetInt32(fromIndex) / 60;
                        int fromMins = reader.GetInt32(fromIndex) % 60;
                        int toHour = reader.GetInt32(toIndex) / 60;
                        int toMins = reader.GetInt32(toIndex) % 60;
                        String from = fromHour.ToString("00") + ":" + fromMins.ToString("00") + "\n";
                        String to = toHour.ToString("00") + ":" + toMins.ToString("00");
                        String time = from + to;
                        for (int i = 0; i < 8; i++)
                        {
                            if (dataGridView1.Rows[i].HeaderCell.Value.Equals(time))
                            {
                                String nl = Environment.NewLine;
                                switch (block)
                                {
                                    case "Block B":
                                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                                        if (status == 0)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.WhiteSmoke;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Unavailable";
                                        }
                                        else if (status == 1)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.PaleGreen;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Available";
                                        }
                                        else if (status == 2)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.Tomato;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Booked";
                                        }
                                        else if (status == 3)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.Aquamarine;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Pending";
                                        }
                                        break;
                                    case "Block D":
                                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                                        if (status == 0)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.WhiteSmoke;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Unavailable";
                                        }
                                        else if (status == 1)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.PaleGreen;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Available";
                                        }
                                        else if (status == 2)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.Tomato;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Booked";
                                        }
                                        else if (status == 3)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.Aquamarine;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Pending";
                                        }
                                        break;
                                    case "Block E":
                                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[2];
                                        if (status == 0)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.WhiteSmoke;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Unavailable";
                                        }
                                        else if (status == 1)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.PaleGreen;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Available";
                                        }
                                        else if (status == 2)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.Tomato;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Booked";
                                        }
                                        else if (status == 3)
                                        {
                                            dataGridView1.CurrentCell.Style.BackColor = Color.Aquamarine;
                                            dataGridView1.CurrentCell.Value = slotID + nl + "Pending";
                                        }
                                        break;
                                    default:
                                        MessageBox.Show("Block Location Does Not Exist!");
                                        break;
                                }
                            }
                        }
                    }
                }
                if (check == false)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[k];
                            dataGridView1.CurrentCell.Value = "Unavailable";
                            dataGridView1.CurrentCell.Style.BackColor = Color.WhiteSmoke;
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chosenDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (firstTime && (chosenDate.Equals(DateTime.Now.AddDays(3).ToString("yyyy-MM-dd"))))
            {
            }
            else
            {
                firstTime = false;
                showSchedule.PerformClick();
            }
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            username = String.Empty;
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void bookings_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings(username);
            bookings.ShowDialog();
        }

        private void require_CheckedChanged(object sender, EventArgs e)
        {
            if (require.Checked)
            {
                dateTimePicker1.MinDate = DateTime.Now.AddDays(7);
            }
            else
            {
                dateTimePicker1.MinDate = DateTime.Now.AddDays(3);
                dateTimePicker1.Value = dateTimePicker1.MinDate;
            }
        }
    }
}
