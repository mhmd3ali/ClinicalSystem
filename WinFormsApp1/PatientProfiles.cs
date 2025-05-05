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
    public partial class PatientProfiles : Form
    {
        public PatientProfiles()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void updateList(string query)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT account_id, account_name, account_type FROM account WHERE account_type = 2 AND (account_name LIKE @query OR account_phone LIKE @query)";
            command.Parameters.AddWithValue("@query", query + "%");
            con.Open();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            command = con.CreateCommand();
            command.CommandText = "INSERT INTO account (account_name , account_phone, account_notes , account_type , account_creation_date) VALUES (@name, @phone, @notes, 2, @date)";
            command.Parameters.AddWithValue("@name", textBox1.Text);
            command.Parameters.AddWithValue("@phone", textBox2.Text);
            command.Parameters.AddWithValue("@notes", textBox4.Text);
            command.Parameters.AddWithValue("@date", DateTime.Now);
            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Patient added successfully");

            }
            else
            {
                MessageBox.Show("Error adding patient");
            }
            con.Close();
            updateList("");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                return;
            }
            int account_id = ((Account)listBox1.SelectedItem).getId();
            command = con.CreateCommand();
            command.CommandText = "SELECT account_name , account_dob , account_phone , account_notes, account_type  , account_creation_date FROM account WHERE  account_id = @id";
            command.Parameters.AddWithValue("@id", account_id);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox9.Text = account_id.ToString();
                textBox10.Text = reader.GetString(0);
                DateTime dob = new DateTime();
                if (DateTime.TryParse(reader.GetValue(1).ToString(), out dob))
                {
                    dateTimePicker1.Value = dob;

                }
                textBox12.Text = reader.GetString(2);
                textBox5.Text = reader.GetString(3);
                textBox13.Text = DateTime.Parse(reader.GetValue(5).ToString()).ToString("MM/dd/yyyy");


            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox10.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Please Check your Inputs");
                return;
            }

            command = con.CreateCommand();
            command.CommandText = "UPDATE account SET account_name = @name, account_phone = @phone , account_dob = @dob, account_notes = @notes WHERE account_id = @id";
            command.Parameters.AddWithValue("@name", textBox10.Text);
            command.Parameters.AddWithValue("@phone", textBox12.Text);
            command.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@notes", textBox5.Text);
            command.Parameters.AddWithValue("@id", textBox9.Text);

            con.Open();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Patient updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating patient");
            }
            con.Close();
            updateList("");


        }
    }
}
