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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newaccess.Text = "Student"; 
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(newpassword.Text);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into users(username,pass,type) values (@param1,@param2,@param3)", conn);
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = newusername.Text;
                cmd.Parameters.Add("@param2", SqlDbType.NChar, 10).Value = hash;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = newaccess.Text;
                cmd.CommandType = CommandType.Text;
                if (newusername.Text == "")
                {
                    error.ForeColor = System.Drawing.Color.Red;
                    error.Text = "Please fill in the username";
                }
                else if (newpassword.TextLength < 5)
                {
                    error.ForeColor = System.Drawing.Color.Red;
                    error.Text = "Password must be 5 characters\nat least";
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        newusername.Text = String.Empty;
                        newpassword.Text = String.Empty;
                        newaccess.Text = String.Empty;
                        error.ForeColor = System.Drawing.Color.Green;
                        error.Text = "Your registeration was succssful";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("exception occured while creating table:" + err.Message + "\t" + err.GetType());
                        error.ForeColor = System.Drawing.Color.Red;
                        error.Text = "Username has been used before";
                    }
                    cmd = new SqlCommand("select * from users", conn);
                    Console.WriteLine(cmd.ExecuteNonQuery());
                    conn.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password.Text);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionReader.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from users where username=@param1 AND pass =@param2", conn);
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = username.Text;
                cmd.Parameters.Add("@param2", SqlDbType.NChar, 10).Value = hash;
                cmd.CommandType = CommandType.Text;
                
                cmd.ExecuteNonQuery();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        username.Text = String.Empty;
                        password.Text = String.Empty;
                        loginerr.Text = "";
                        String type = String.Format("{0}", reader["type"]);
                        String name = String.Format("{0}", reader["username"]);
                        Console.WriteLine(name);
                        switch (type)
                        {
                            case "Student":
                            case "Lecturer":
                                Booker booker = new Booker(name);
                                this.Hide();
                                booker.Closed += (s, args) => this.Close();
                                booker.Show();
                                break;
                            case "Manager":
                                Manager manager = new Manager(name);
                                this.Hide();
                                manager.Closed += (s, args) => this.Close();
                                manager.Show();
                                break;
                        }
                        
                    }
                    else
                    {
                        loginerr.ForeColor = System.Drawing.Color.Red;
                        loginerr.Text = "Username or Password Error";
                    }
                }
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("exception occured while creating table:" + err.Message + "\t" + err.GetType());
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginerr_Click(object sender, EventArgs e)
        {

        }
    }
    
}