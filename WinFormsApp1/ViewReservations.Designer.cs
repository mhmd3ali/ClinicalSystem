namespace WinFormsApp1
{
    partial class ViewReservations
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
            panelSearch = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            labelSearchHeader = new Label();
            panelDetails = new Panel();
            button1 = new Button();
            buttonEdit = new Button();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            labelDetailsHeader = new Label();
            listBoxResults = new ListBox();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 55, 77);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1011, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(252, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "View Reservations";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(221, 230, 237);
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(radioButton3);
            panelSearch.Controls.Add(radioButton2);
            panelSearch.Controls.Add(radioButton1);
            panelSearch.Controls.Add(textBox1);
            panelSearch.Controls.Add(label3);
            panelSearch.Controls.Add(dateTimePicker1);
            panelSearch.Controls.Add(label2);
            panelSearch.Controls.Add(labelSearchHeader);
            panelSearch.Location = new Point(33, 80);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(457, 300);
            panelSearch.TabIndex = 1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.FromArgb(39, 55, 77);
            radioButton3.Location = new Point(55, 230);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 24);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Use Both";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(39, 55, 77);
            radioButton2.Location = new Point(55, 190);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(297, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Use Name / Phone / Reservation ID Only";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(39, 55, 77);
            radioButton1.Location = new Point(55, 150);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(124, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Use Date Only";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(247, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(39, 55, 77);
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(221, 23);
            label3.TabIndex = 3;
            label3.Text = "Name/Phone/Reservation:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(93, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(344, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(39, 55, 77);
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 1;
            label2.Text = "Date: ";
            // 
            // labelSearchHeader
            // 
            labelSearchHeader.AutoSize = true;
            labelSearchHeader.BackColor = Color.FromArgb(82, 109, 130);
            labelSearchHeader.Dock = DockStyle.Top;
            labelSearchHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchHeader.ForeColor = Color.White;
            labelSearchHeader.Location = new Point(0, 0);
            labelSearchHeader.Name = "labelSearchHeader";
            labelSearchHeader.Padding = new Padding(10);
            labelSearchHeader.Size = new Size(191, 48);
            labelSearchHeader.TabIndex = 0;
            labelSearchHeader.Text = "Find Reservation";
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.FromArgb(221, 230, 237);
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(button1);
            panelDetails.Controls.Add(buttonEdit);
            panelDetails.Controls.Add(textBox7);
            panelDetails.Controls.Add(label10);
            panelDetails.Controls.Add(textBox6);
            panelDetails.Controls.Add(label9);
            panelDetails.Controls.Add(textBox5);
            panelDetails.Controls.Add(label8);
            panelDetails.Controls.Add(textBox4);
            panelDetails.Controls.Add(label7);
            panelDetails.Controls.Add(textBox3);
            panelDetails.Controls.Add(label6);
            panelDetails.Controls.Add(textBox2);
            panelDetails.Controls.Add(label5);
            panelDetails.Controls.Add(labelDetailsHeader);
            panelDetails.Location = new Point(520, 80);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(457, 300);
            panelDetails.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 109, 130);
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(241, 248);
            button1.Name = "button1";
            button1.Size = new Size(135, 35);
            button1.TabIndex = 15;
            button1.Text = "Visits";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(82, 109, 130);
            buttonEdit.Enabled = false;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(70, 248);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 35);
            buttonEdit.TabIndex = 14;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(94, 215);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(242, 27);
            textBox7.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(39, 55, 77);
            label10.Location = new Point(35, 217);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 12;
            label10.Text = "Date: ";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(94, 182);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(242, 27);
            textBox6.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(39, 55, 77);
            label9.Location = new Point(35, 184);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 10;
            label9.Text = "Slot:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(94, 149);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(242, 27);
            textBox5.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(39, 55, 77);
            label8.Location = new Point(20, 151);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 8;
            label8.Text = "Visit On:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(94, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 27);
            textBox4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(39, 55, 77);
            label7.Location = new Point(17, 118);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Secretary:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(94, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 27);
            textBox3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(39, 55, 77);
            label6.Location = new Point(23, 85);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 4;
            label6.Text = "Patient:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(94, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(39, 55, 77);
            label5.Location = new Point(59, 52);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 2;
            label5.Text = "ID:";
            // 
            // labelDetailsHeader
            // 
            labelDetailsHeader.AutoSize = true;
            labelDetailsHeader.BackColor = Color.FromArgb(82, 109, 130);
            labelDetailsHeader.Dock = DockStyle.Top;
            labelDetailsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetailsHeader.ForeColor = Color.White;
            labelDetailsHeader.Location = new Point(0, 0);
            labelDetailsHeader.Name = "labelDetailsHeader";
            labelDetailsHeader.Padding = new Padding(10);
            labelDetailsHeader.Size = new Size(217, 48);
            labelDetailsHeader.TabIndex = 1;
            labelDetailsHeader.Text = "Reservation Details";
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.White;
            listBoxResults.BorderStyle = BorderStyle.FixedSingle;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(33, 400);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(944, 242);
            listBoxResults.TabIndex = 7;
            listBoxResults.SelectedIndexChanged += listBoxResults_SelectedIndexChanged;
            // 
            // ViewReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 231, 239);
            ClientSize = new Size(1011, 658);
            Controls.Add(listBoxResults);
            Controls.Add(panelDetails);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ViewReservations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Reservations";
            Load += ViewReservations_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelSearch;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label labelSearchHeader;
        private Panel panelDetails;
        private Button buttonEdit;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Label labelDetailsHeader;
        private ListBox listBoxResults;
        private Button button1;
    }
}