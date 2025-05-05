namespace WinFormsApp1
{
    partial class EditProfile
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
            mainPanel = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panelHeader.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 55, 77);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(160, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Edit Profile";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(221, 230, 237);
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(dateTimePicker1);
            mainPanel.Controls.Add(textBox8);
            mainPanel.Controls.Add(label8);
            mainPanel.Controls.Add(textBox7);
            mainPanel.Controls.Add(label7);
            mainPanel.Controls.Add(textBox6);
            mainPanel.Controls.Add(label6);
            mainPanel.Controls.Add(textBox5);
            mainPanel.Controls.Add(label5);
            mainPanel.Controls.Add(label4);
            mainPanel.Controls.Add(textBox3);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(textBox2);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(25, 80);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(550, 576);
            mainPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 109, 130);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(180, 507);
            button1.Name = "button1";
            button1.Size = new Size(171, 41);
            button1.TabIndex = 17;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(173, 460);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(310, 27);
            textBox8.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(39, 55, 77);
            label8.Location = new Point(45, 464);
            label8.Name = "label8";
            label8.Size = new Size(116, 23);
            label8.TabIndex = 14;
            label8.Text = "Created On : ";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(173, 345);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(310, 95);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(39, 55, 77);
            label7.Location = new Point(45, 347);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 12;
            label7.Text = "Notes : ";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(173, 295);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(310, 27);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(39, 55, 77);
            label6.Location = new Point(45, 299);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 10;
            label6.Text = "Type :";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(173, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(310, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(39, 55, 77);
            label5.Location = new Point(45, 244);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 8;
            label5.Text = "Phone :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(39, 55, 77);
            label4.Location = new Point(45, 189);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 6;
            label4.Text = "DOB :";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(173, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(39, 55, 77);
            label3.Location = new Point(45, 134);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 4;
            label3.Text = "Name :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(173, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(39, 55, 77);
            label2.Location = new Point(45, 79);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(173, 25);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(310, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(39, 55, 77);
            label1.Location = new Point(45, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 0;
            label1.Text = "Account ID :";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 231, 239);
            ClientSize = new Size(600, 680);
            Controls.Add(mainPanel);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Profile";
            Load += EditProfile_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel mainPanel;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}