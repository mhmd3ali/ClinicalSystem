using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    partial class CreateReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            listBox1 = new ListBox();
            textBox8 = new TextBox();
            label11 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 55, 77);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(556, 60);
            panelHeader.TabIndex = 7;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(261, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Create Reservation";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 230, 237);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 381);
            panel1.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(47, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 282);
            listBox1.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(187, 50);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(247, 27);
            textBox8.TabIndex = 7;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(39, 55, 77);
            label11.Location = new Point(47, 50);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 6;
            label11.Text = "Name / Phone :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(82, 109, 130);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(146, 48);
            label1.TabIndex = 0;
            label1.Text = "Find Patient";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(33, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 193);
            panel2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 109, 130);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(145, 144);
            button1.Name = "button1";
            button1.Size = new Size(184, 37);
            button1.TabIndex = 5;
            button1.Text = "Reserve Slot";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(39, 55, 77);
            label4.Location = new Point(35, 100);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 3;
            label4.Text = "Slot :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(39, 55, 77);
            label3.Location = new Point(32, 60);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 1;
            label3.Text = "Date : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(82, 109, 130);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(132, 48);
            label2.TabIndex = 0;
            label2.Text = "Select Slot";
            // 
            // CreateReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 231, 239);
            ClientSize = new Size(556, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CreateReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Reservation";
            Load += CreateReservation_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void CreateReservation_Load(object sender, EventArgs e)
        {
            // Initialize any data or controls when the form loads
            
            updateList("");
            updateSlots();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void UpdatePatientsList(string searchTerm)
        {
            // This method would populate the listBox1 with patient data
            // based on the search term
        }

        private void LoadTimeSlots()
        {
            // Populate the comboBox1 with available time slots
            comboBox1.Items.Clear();
            comboBox1.Items.Add("9:00 AM - 10:00 AM");
            comboBox1.Items.Add("10:00 AM - 11:00 AM");
            comboBox1.Items.Add("11:00 AM - 12:00 PM");
            comboBox1.Items.Add("1:00 PM - 2:00 PM");
            comboBox1.Items.Add("2:00 PM - 3:00 PM");
            comboBox1.Items.Add("3:00 PM - 4:00 PM");
            comboBox1.Items.Add("4:00 PM - 5:00 PM");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Update the patient list when search text changes
            updateList(textBox8.Text);
        }

        private void updateSlots() {
            command = con.CreateCommand();
            command.CommandText = "SELECT reservation_visit_slot FROM reservation WHERE reservation_visit_date = @date";
            command.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            Dictionary<int, string> slots = Utils.getSlots();
            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));
            }
            comboBox1.Items.Clear();
            foreach (object slot in slots.ToArray())
            {
                comboBox1.Items.Add(slot);
            }
            if(comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            con.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateSlots();

        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panel1;
        private ListBox listBox1;
        private TextBox textBox8;
        private Label label11;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
    }
}