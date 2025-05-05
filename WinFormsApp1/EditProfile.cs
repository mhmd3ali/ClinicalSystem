using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class EditProfile : Form
    {
        int account_id;
        public EditProfile(int account_id)
        {
            InitializeComponent();
            this.account_id = account_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "" )
            {
                MessageBox.Show("Please Enter a Name");
                return;
            }

            SqlCommand command = con.CreateCommand();
            command.CommandText = "UPDATE account SET account_name = @name , account_dob = @dob ,  account_notes = @notes , account_phone = @phone  WHERE account_id = @account_id";
            command.Parameters.AddWithValue("@name", textBox3.Text);
            command.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@phone", textBox5.Text);
            command.Parameters.AddWithValue("@notes", textBox7.Text);
            command.Parameters.AddWithValue("@account_id", account_id);

            con.Open();
            if(command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Profile updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating profile");
            }
            con.Close();


        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        private void EditProfile_Load(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT user_username , account_name , account_dob , account_phone, account_type , account_notes , account_creation_date FROM [user] , account WHERE account_user_id = user_id AND account_id = @account_id";
            command.Parameters.AddWithValue("@account_id", account_id);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) {
                textBox1.Text = account_id.ToString();
                textBox2.Text = reader.GetValue(0).ToString();
                textBox3.Text = reader.GetValue(1).ToString();

                try
                {
                    dateTimePicker1.Value = DateTime.Parse(reader.GetValue(2).ToString());
                }
                catch (Exception)
                {
                   
                }
                textBox5.Text = reader.GetValue(3).ToString();
                if(reader.GetInt32(4) == 0)
                {
                    textBox6.Text = "Secretary";
                }
                else if(reader.GetInt32(4) == 1)
                {
                    textBox6.Text = "Doctor";
                }
                else if(reader.GetInt32(4) == 2)
                {
                    textBox6.Text = "Patient";
                }
                textBox7.Text = reader.GetValue(5).ToString();
                textBox8.Text = reader.GetValue(6).ToString();

            }
            con.Close();

        }
    }
}
