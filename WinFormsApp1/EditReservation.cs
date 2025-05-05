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
    public partial class EditReservation : Form
    {
        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;
        public EditReservation(Reservation res)
        {
            InitializeComponent();


            dateTimePickerDate.Value = res.visit_date;

            textBoxID.Text = res.id.ToString();
            textBoxPatient.Text = res.patient.ToString();
            textBoxSecretary.Text = res.secretary.ToString();
            textBoxNotes.Text = res.date.ToString("yyyy-MM-dd");

            dateTimePickerDate.MinDate = DateTime.Today;

            updateCombo(res.slot);

        }

        private void updateCombo(int visit_slot)
        {
            Dictionary<int, string> slots = Utils.getSlots();

            command = con.CreateCommand();
            command.CommandText = "SELECT reservation_visit_slot FROM reservation WHERE reservation_visit_date = @date AND reservation_id <> @id";
            command.Parameters.AddWithValue("@date", dateTimePickerDate.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@id", textBoxID.Text);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));
            }
            comboBoxSlot.Items.Clear();

            foreach (KeyValuePair<int, string> slot in slots)
            {
                comboBoxSlot.Items.Add(slot);
                if (slot.Key == visit_slot)
                {
                    comboBoxSlot.SelectedItem = slot;
                }
            }
            con.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "UPDATE reservation SET reservation_visit_date = @visit_date, reservation_visit_slot = @visit_slot WHERE reservation_id = @id";
            command.Parameters.AddWithValue("@visit_date", dateTimePickerDate.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@visit_slot", ((KeyValuePair<int, string>)comboBoxSlot.SelectedItem).Key);
            command.Parameters.AddWithValue("@id", textBoxID.Text);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Reservation updated successfully");
            }
            else
            {
                MessageBox.Show("Failed to update reservation");
            }
            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "DELETE FROM reservation WHERE reservation_id = @id";
            command.Parameters.AddWithValue("@id", textBoxID.Text);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Reservation deleted successfully");
            }
            else
            {
                MessageBox.Show("Failed to delete reservation");
            }
            con.Close();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            updateCombo(1);
        }
    }
}
