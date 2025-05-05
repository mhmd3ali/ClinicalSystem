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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void updateList(string query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.CommandText = "SELECT account_id, account_name, account_type FROM account WHERE account_type in (0,1) AND (account_name LIKE @query OR account_phone LIKE @query) ORDER BY account_type";
            command.Parameters.AddWithValue("@query", query + "%");

            SqlDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(new Account(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1)));
            }

            con.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            updateList(textBox8.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int account_id;
            try
            {
                account_id = ((Account)listBox1.SelectedItem).getId();
            }
            catch (Exception)
            {
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();

            command.CommandText = "SELECT user_username , account_name , account_dob , account_phone, account_type , account_notes , account_creation_date FROM [user] , account WHERE user_id = account_user_id AND account_id = @id";
            command.Parameters.AddWithValue("@id", account_id);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox9.Text = account_id.ToString();
                textBox7.Text = reader.GetValue(0).ToString();
                textBox10.Text = reader.GetValue(1).ToString();
                textBox6.Text = reader.GetValue(2).ToString();
                textBox12.Text = reader.GetValue(3).ToString();

                if (reader.GetInt32(4) == 0)
                {
                    textBox11.Text = "Secretary";
                }
                else
                {
                    textBox11.Text = "Doctor";
                }
                textBox5.Text = reader.GetValue(5).ToString();
                textBox13.Text = reader.GetValue(6).ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!validateInputs())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO [user] (user_username , user_password) VALUES(@username, @password)";
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password", textBox2.Text);
            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                command.CommandText = "SELECT user_id FROM [user] WHERE user_username = @username";
                int user_id = (int)command.ExecuteScalar();

                command.CommandText = "INSERT INTO account (account_user_id , account_name , account_type , account_notes , account_creation_date) VALUES (@user_id , @name, @type, @notes, @date)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@name", textBox3.Text);
                command.Parameters.AddWithValue("@type", comboBox1.SelectedIndex);
                command.Parameters.AddWithValue("@notes", textBox4.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Account Was Successfully Created");
                    updateList("");
                }
                else
                {
                    MessageBox.Show("Error While creating account");
                }
            }
            else
            {
                MessageBox.Show("Error While creating account");
            }
            con.Close();

        }

        private bool validateInputs()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
              
                return false;
            }
            if (comboBox1.SelectedIndex < 0)
            {
              
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "DELETE FROM [user] WHERE user_username = @username";
            command.Parameters.AddWithValue("@username", textBox7.Text);
            con.Open();
            
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account Was Successfully Deleted");
                    
            }
            else
            {
                MessageBox.Show("Error While deleting account");

            }
            con.Close();
            updateList("");
            textBox9.Clear();
            textBox7.Clear();
            textBox10.Clear();
            textBox6.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox5.Clear();
            textBox13.Clear();
            
        }
    }
}
