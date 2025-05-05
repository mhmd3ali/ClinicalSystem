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
    public partial class Visits : Form
    {
        int account_id, patient_id, reservation_id;
        public Visits(int account_id, int patient_id, int reservation_id)
        {
            InitializeComponent();
            this.account_id = account_id;
            this.patient_id = patient_id;
            this.reservation_id = reservation_id;

            command = con.CreateCommand();
            command.CommandText = "SELECT visit_id FROM visit WHERE visit_reservation_id = @reservation_id";
            command.Parameters.AddWithValue("@reservation_id", reservation_id);
            con.Open();

            var result = command.ExecuteScalar();

            if (result == null)
            {
                panelAddVisit.Enabled = true;
            }
            else
            {
                panelAddVisit.Enabled = false;
            }

            con.Close();
            updateList();
        }


        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void updateList()
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT visit_id, patient.account_id, patient.account_name, secretary.account_id, secretary.account_name, doctor.account_id, doctor.account_name, visit_date, visit_reasons, visit_diagonsis, visit_notes FROM visit, reservation, account as patient, account as secretary, account as doctor WHERE visit_reservation_id = reservation_id AND reservation_patient_id = patient.account_id AND reservation_secretary_id = secretary.account_id AND visit_doctor_id = doctor.account_id AND patient.account_id = @patient_id";
            command.Parameters.AddWithValue("@patient_id", patient_id);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            listBoxPreviousVisits.Items.Clear();

            while (reader.Read())
            {
                int visit_id = reader.GetInt32(0);
                int patient_id = reader.GetInt32(1);
                string patient_name = reader.GetString(2);
                int secretary_id = reader.GetInt32(3);
                string secretary_name = reader.GetString(4);
                int doctor_id = reader.GetInt32(5);
                string doctor_name = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                string reason = reader.GetString(8);
                string diagonsis = reader.GetString(9);
                string notes = reader.GetString(10);

                listBoxPreviousVisits.Items.Add(new visit(visit_id, patient_id, patient_name, secretary_id, secretary_name, doctor_id, doctor_name, date, reason, diagonsis, notes));

            }
            con.Close();


        }

        private void listBoxPreviousVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPreviousVisits.SelectedIndex < 0 || listBoxPreviousVisits.SelectedIndex >= listBoxPreviousVisits.Items.Count)
            {
                MessageBox.Show("Please select a visit.");
                return;
            }

            visit v = (visit)listBoxPreviousVisits.SelectedItem;
            textBoxID.Text = v.visit_id.ToString();
            textBoxPatient.Text = v.patient.ToString();
            textBoxSec.Text = v.secretary.ToString();
            textBoxDoc.Text = v.doctor.ToString();
            textBoxDate.Text = v.date.ToString("yyyy-MM-dd");
            textBoxVisitReasons.Text = v.reason;
            textBoxVisitDiagnosis.Text = v.diagnosis;
            textBoxVisitNotes.Text = v.notes;



        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            if (textBoxReasons.Text == "" || textBoxDiagnosis.Text == "")
            {
                MessageBox.Show("Please fill Reasons and Diagnosis.");
                return;
            }

            command = con.CreateCommand();
            con.Open();
            command.CommandText = "INSERT INTO visit (visit_reservation_id, visit_reasons, visit_diagonsis, visit_notes, visit_doctor_id, visit_date) VALUES (@id, @reasons, @diagonsis, @notes, @doctor_id, @date)";
            command.Parameters.AddWithValue("@id", reservation_id);
            command.Parameters.AddWithValue("@reasons", textBoxReasons.Text);
            command.Parameters.AddWithValue("@diagonsis", textBoxDiagnosis.Text);
            command.Parameters.AddWithValue("@notes", textBoxNotes.Text);
            command.Parameters.AddWithValue("@doctor_id", account_id);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Visit added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add visit.");
            }
            con.Close();
            updateList();

        }

        private void buttonEditVisit_Click(object sender, EventArgs e)
        {
            if(textBoxVisitReasons.Text == "" || textBoxVisitDiagnosis.Text == "")
            {
                MessageBox.Show("Please fill Reasons and Diagnosis.");
                return;
            }

            command = con.CreateCommand();
            con.Open();
            command.CommandText = "UPDATE visit SET visit_reasons = @reasons, visit_diagonsis = @diagonsis, visit_notes = @notes WHERE visit_id = @id";
            command.Parameters.AddWithValue("@id", textBoxID.Text);
            command.Parameters.AddWithValue("@reasons", textBoxVisitReasons.Text);
            command.Parameters.AddWithValue("@diagonsis", textBoxVisitDiagnosis.Text);
            command.Parameters.AddWithValue("@notes", textBoxVisitNotes.Text);

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Visit updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update visit.");
            }
            con.Close();
            updateList();
        }
    }
}
