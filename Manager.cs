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
    public partial class Manager : Form
    {
        String username;
        String chosenDate;
        bool enteredBookings = false;
        public Manager(String name)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.username = name;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            approve.Enabled = false;
            reject.Enabled = false;
            cancel.Enabled = false;
            approve.BackColor = Color.Gray;
            reject.BackColor = Color.Gray;
            cancel.BackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            chosenDate = DateTime.Now.ToString("yyyy-MM-dd");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String currentCell = dataGridView1.CurrentCell.Value.ToString();
            if (currentCell.Contains("Available"))
            {
                reject.Enabled = false;
                reject.BackColor = Color.Gray;
                approve.Enabled = false;
                approve.BackColor = Color.Gray;
                cancel.Enabled = true;
                cancel.Text = "Close";
                cancel.BackColor = Color.DodgerBlue;
                bookerName.Text = String.Empty;
                eventType.Text = String.Empty;
                eventName.Text = String.Empty;
                attendees.Text = String.Empty;
                bookerPhone.Text = String.Empty;
                additionals.Text = String.Empty;
            }
            else if (currentCell.Contains("Booked") || currentCell.Contains("Pending"))
            {
                reject.Enabled = false;
                reject.BackColor = Color.Gray;
                approve.Enabled = false;
                approve.BackColor = Color.Gray;
                cancel.Enabled = true;
                cancel.Text = "Cancel";
                cancel.BackColor = Color.DodgerBlue;
                String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
                try
                {
                    SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT bookerName,slot_id,eventType,eventName,attendees,phoneNumber,additionals FROM events WHERE slot_id = @param1;", conn);
                    cmd.CommandText = "SELECT bookerName,slot_id,eventType,eventName,attendees,phoneNumber,additionals FROM events WHERE slot_id = @param1;";
                    cmd.Parameters.AddWithValue("@param1", slot_id);
                    cmd.ExecuteNonQuery();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        int bookerIndex = reader.GetOrdinal("bookerName");
                        int eventTypeIndex = reader.GetOrdinal("eventType");
                        int eventNameIndex = reader.GetOrdinal("eventName");
                        int attendeesIndex = reader.GetOrdinal("attendees");
                        int phoneIndex = reader.GetOrdinal("phoneNumber");
                        int addIndex = reader.GetOrdinal("additionals");
                        while (reader.Read())  // one loop iteration per record returned from SELECT
                        {
                            string booker = reader.GetString(bookerIndex);
                            string event_Type = reader.GetString(eventTypeIndex);
                            string event_Name = reader.GetString(eventNameIndex);
                            int attendees_Number = reader.GetInt32(attendeesIndex);
                            string phone = reader.GetString(phoneIndex);
                            string additional_requests = reader.GetString(addIndex).ToString();
                            bookerName.Text = booker;
                            eventType.Text = event_Type;
                            eventName.Text = event_Name;
                            attendees.Text = attendees_Number.ToString();
                            bookerPhone.Text = phone;
                            additionals.Text = additional_requests;
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (currentCell.Contains("Pending"))
                {
                    reject.Enabled = true;
                    reject.BackColor = Color.Tomato;
                    approve.Enabled = true;
                    approve.BackColor = Color.DodgerBlue;
                    cancel.Enabled = false;
                    cancel.Text = "Close";
                    cancel.BackColor = Color.Gray;
                }

            }
            else if (currentCell.Contains("Unavailable"))
            {
                reject.Enabled = false;
                reject.BackColor = Color.Gray;
                approve.Enabled = false;
                approve.BackColor = Color.Gray;
                cancel.Enabled = true;
                cancel.Text = "Open";
                cancel.BackColor = Color.DodgerBlue;
                bookerName.Text = String.Empty;
                eventType.Text = String.Empty;
                eventName.Text = String.Empty;
                attendees.Text = String.Empty;
                bookerPhone.Text = String.Empty;
                additionals.Text = String.Empty;
            }
            else
            {
                reject.Enabled = false;
                reject.BackColor = Color.Gray;
                approve.Enabled = false;
                approve.BackColor = Color.Gray;
                cancel.Enabled = false;
                cancel.BackColor = Color.Gray;
                bookerName.Text = String.Empty;
                eventType.Text = String.Empty;
                eventName.Text = String.Empty;
                attendees.Text = String.Empty;
                bookerPhone.Text = String.Empty;
                additionals.Text = String.Empty;
            }
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chosenDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            showSchedule.PerformClick();
        }

        private void showSchedule_Click(object sender, EventArgs e)
        {
            enteredBookings = false;
            dataGridView1.Columns[0].HeaderText = "Block B";
            dataGridView1.Columns[1].HeaderText = "Block D";
            dataGridView1.Columns[2].HeaderText = "Block E";
            dataGridView1.Rows.Clear();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
                                            dataGridView1.CurrentCell.Style.BackColor = Color.SpringGreen;
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
                                            dataGridView1.CurrentCell.Style.BackColor = Color.SpringGreen;
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
                                            dataGridView1.CurrentCell.Style.BackColor = Color.SpringGreen;
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

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            username = String.Empty;
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void approve_Click(object sender, EventArgs e)
        {
            String nl = Environment.NewLine;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                String currentCell = cell.Value.ToString();
                String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
                cell.Value = slot_id + nl + "Booked";
                cell.Style.BackColor = Color.Tomato;
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE slots SET status = @param1 WHERE slot_id = @param2;", conn);
                cmd.Parameters.AddWithValue("@param1", 2);
                cmd.Parameters.AddWithValue("@param2", slot_id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd = new SqlCommand("INSERT INTO history SELECT * FROM events WHERE slot_id = @param1", conn);
                cmd.Parameters.AddWithValue("@param1", slot_id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cancel.Text == "Cancel")
            {
                String nl = Environment.NewLine;
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    String currentCell = cell.Value.ToString();
                    String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
                    cell.Value = slot_id + nl + "Available";
                    SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE slots SET status = @param1 WHERE slot_id = @param2;", conn);
                    cmd.Parameters.AddWithValue("@param1", 1);
                    cmd.Parameters.AddWithValue("@param2", slot_id);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd = new SqlCommand("DELETE FROM [events] WHERE slot_id = @param1", conn);
                    cmd.Parameters.AddWithValue("@param1", slot_id);
                    cmd.ExecuteNonQuery();
                    cell.Style.BackColor = Color.PaleGreen;
                }
            }
            else if (cancel.Text == "Close")
            {
                String nl = Environment.NewLine;
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    String currentCell = cell.Value.ToString();
                    String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
                    cell.Value = slot_id + nl + "Unavailable";
                    SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE slots SET status = @param1 WHERE slot_id = @param2;", conn);
                    cmd.Parameters.AddWithValue("@param1", 0);
                    cmd.Parameters.AddWithValue("@param2", slot_id);
                    cmd.ExecuteNonQuery();
                    cell.Style.BackColor = Color.WhiteSmoke;
                }
            }
            else if (cancel.Text == "Open")
            {
                String nl = Environment.NewLine;
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    String currentCell = cell.Value.ToString();
                    String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
                    cell.Value = slot_id + nl + "Available";
                    SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE slots SET status = @param1 WHERE slot_id = @param2;", conn);
                    cmd.Parameters.AddWithValue("@param1", 1);
                    cmd.Parameters.AddWithValue("@param2", slot_id);
                    cmd.ExecuteNonQuery();
                    cell.Style.BackColor = Color.PaleGreen;
                }
            }
        }

        private void reject_Click(object sender, EventArgs e)
        {
            String nl = Environment.NewLine;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                String currentCell = cell.Value.ToString();
                String slot_id = currentCell.Substring(0, currentCell.IndexOf(Environment.NewLine));
                cell.Value = slot_id + nl + "Available";
                cell.Style.BackColor = Color.PaleGreen;
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE slots SET status = @param1 WHERE slot_id = @param2;", conn);
                cmd.Parameters.AddWithValue("@param1", 1);
                cmd.Parameters.AddWithValue("@param2", slot_id);
                cmd.ExecuteNonQuery();
            }
        }

        private void bookings_Click(object sender, EventArgs e)
        {
            if (enteredBookings == false)
            {
                for (int k = 0; k < 8; k++)
                {
                    dataGridView1.Rows[k].Cells[0].Value = "";
                    dataGridView1.Rows[k].Cells[1].Value = "";
                    dataGridView1.Rows[k].Cells[2].Value = "";
                }
                dataGridView1.Columns[0].HeaderText = "Status";
                dataGridView1.Columns[1].HeaderText = "Date";
                dataGridView1.Columns[2].HeaderText = "Block";
                try
                {
                    SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                    conn.Open();
                    SqlCommand cmdCount = new SqlCommand("SELECT COUNT(slot_id) FROM slots WHERE status = @param1 OR status = @param2;", conn);
                    cmdCount.CommandText = "SELECT COUNT(slot_id) FROM slots WHERE status = @param1 OR status = @param2;";
                    cmdCount.Parameters.AddWithValue("@param1", 2);
                    cmdCount.Parameters.AddWithValue("@param2", 3);
                    Int32 count = (Int32)cmdCount.ExecuteScalar();
                    cmdCount.Parameters.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT slot_id,block,date,startTime,endTime,status FROM slots WHERE status = @param1 OR status = @param2;", conn);
                    cmd.CommandText = "SELECT slot_id,block,date,startTime,endTime,status FROM slots WHERE status = @param1 OR status = @param2;";
                    cmd.Parameters.AddWithValue("@param1", 2);
                    cmd.Parameters.AddWithValue("@param2", 3);
                    cmd.ExecuteNonQuery();
                    bool check = false;
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        int slotIndex = reader.GetOrdinal("slot_id");
                        int blockIndex = reader.GetOrdinal("block");
                        int fromIndex = reader.GetOrdinal("startTime");
                        int toIndex = reader.GetOrdinal("endTime");
                        int dateIndex = reader.GetOrdinal("date");
                        int statusIndex = reader.GetOrdinal("status");
                        while (reader.Read())  // one loop iteration per record returned from SELECT
                        {
                            check = true;
                            enteredBookings = true;
                            string slotID = reader.GetString(slotIndex);
                            string block = reader.GetString(blockIndex);
                            string date = reader.GetDateTime(dateIndex).ToString("yyyy-MM-dd");
                            int status = reader.GetInt32(statusIndex);
                            int fromHour = reader.GetInt32(fromIndex) / 60;
                            int fromMins = reader.GetInt32(fromIndex) % 60;
                            int toHour = reader.GetInt32(toIndex) / 60;
                            int toMins = reader.GetInt32(toIndex) % 60;
                            String from = fromHour.ToString("00") + ":" + fromMins.ToString("00") + "\n";
                            String to = toHour.ToString("00") + ":" + toMins.ToString("00");
                            String time = from + to;
                            List<int> intList = new List<int>();
                            String rowslot = "";
                            for (int i = 0; i < 8; i++)
                            {
                                if (dataGridView1.Rows[i].HeaderCell.Value.Equals(time))
                                {
                                    String nl = Environment.NewLine;
                                   
                                        if (!dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(""))
                                        {
                                            rowslot = dataGridView1.Rows[i].Cells[0].Value.ToString().Substring(0, dataGridView1.Rows[i].Cells[0].Value.ToString().IndexOf(Environment.NewLine));
                                            Console.WriteLine(rowslot);

                                            if (!slotID.Contains(rowslot))
                                            {
                                                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                                                if (status == 2)
                                                {
                                                    row.Cells[0].Value = slotID + nl + "Booked";
                                                    row.Cells[0].Style.BackColor = Color.Tomato;
                                                }
                                                else if (status == 3)
                                                {
                                                    row.Cells[0].Value = slotID + nl + "Pending";
                                                    row.Cells[0].Style.BackColor = Color.SpringGreen;
                                                }
                                                row.Cells[1].Value = date;
                                                row.Cells[2].Value = block;
                                                dataGridView1.Rows.Add(row);
                                            }
                                        }
                                        else
                                        {
                                            switch (status)
                                            {
                                                case 2:
                                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                                                    dataGridView1.CurrentCell.Value = slotID + nl + "Booked";
                                                    dataGridView1.CurrentCell.Style.BackColor = Color.Tomato;
                                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                                                    dataGridView1.CurrentCell.Value = date;
                                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[2];
                                                    dataGridView1.CurrentCell.Value = block;
                                                    break;
                                                case 3:
                                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                                                    dataGridView1.CurrentCell.Value = slotID + nl + "Pending";
                                                    dataGridView1.CurrentCell.Style.BackColor = Color.SpringGreen;
                                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                                                    dataGridView1.CurrentCell.Value = date;
                                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[2];
                                                    dataGridView1.CurrentCell.Value = block;
                                                    break;
                                            }
                                        }
                                }
                                else
                                {
                                }
                            }
                        }
                        for (int k = 0; k < dataGridView1.RowCount; k++)
                        {
                            Console.WriteLine("------- "+dataGridView1.RowCount);
                            if (dataGridView1.Rows[k].Cells[0].Value.ToString().Equals("") || dataGridView1.Rows[k].Cells[0].Value.ToString().Equals(Environment.NewLine) || dataGridView1.Rows[k].Cells[0].Value.ToString().Equals(String.Empty) || dataGridView1.Rows[k].Cells[0].Value.ToString().Equals(null))
                            {
                                Console.WriteLine(k);
                                dataGridView1.Rows.RemoveAt(k);
                                k--;
                            }
                            Console.WriteLine(dataGridView1.RowCount);
                        }
                    }
                    if (check == false)
                    {
                        MessageBox.Show("No Bookings Available");
                        showSchedule.PerformClick();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
