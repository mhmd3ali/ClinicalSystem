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
    public partial class CreateReservation : Form
    {
        int secretary_id;
        public CreateReservation(int id)
        {
            InitializeComponent();
            secretary_id = id;
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;


        public void updateList(string query)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT account_id, account_name, account_type FROM account WHERE account_type = 2 AND (account_name LIKE @query OR account_phone LIKE @query)";
            command.Parameters.AddWithValue("@query", query + "%");
            con.Open();

            listBox1.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(new Account(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1)));
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Please select a patient");
                return;
            }
            if(comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a slot");
                return;
            }

            int patient_id = ((Account)listBox1.SelectedItem ).getId();
            int slot = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;

            command = con.CreateCommand();
            command.CommandText = "INSERT INTO reservation (reservation_secretary_id, reservation_patient_id, reservation_visit_date, reservation_visit_slot, reservation_date) VALUES (@secretary_id, @patient_id, @visit_date, @visit_slot, @date)";
            command.Parameters.AddWithValue("@secretary_id", secretary_id);
            command.Parameters.AddWithValue("@patient_id", patient_id);
            command.Parameters.AddWithValue("@visit_date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@visit_slot", slot);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            con.Open();

            if(command.ExecuteNonQuery() > 0)
            {
                command.CommandText = "SELECT reservation_id FROM reservation WHERE reservation_visit_date = @visit_date AND reservation_visit_slot = @visit_slot";
                int reservation_id = (int)command.ExecuteScalar();

                MessageBox.Show("Reservation created successfully ");
                MessageBox.Show("Reservation ID: " + reservation_id.ToString());
            }
            else
            {
                MessageBox.Show("Failed to create reservation");
            }
            con.Close();
            updateSlots();


        }
    }
}
