namespace WinFormsApp1
{
    partial class EditReservation
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
            panelContent = new Panel();
            buttonDelete = new Button();
            buttonSave = new Button();
            comboBoxSlot = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            textBoxNotes = new TextBox();
            textBoxDate = new Label();
            textBoxSecretary = new TextBox();
            labelSecretary = new Label();
            textBoxPatient = new TextBox();
            labelPatient = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            labelContentHeader = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 55, 77);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(650, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(227, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Edit Reservation";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(221, 230, 237);
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Controls.Add(buttonDelete);
            panelContent.Controls.Add(buttonSave);
            panelContent.Controls.Add(comboBoxSlot);
            panelContent.Controls.Add(dateTimePickerDate);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(textBoxNotes);
            panelContent.Controls.Add(textBoxDate);
            panelContent.Controls.Add(textBoxSecretary);
            panelContent.Controls.Add(labelSecretary);
            panelContent.Controls.Add(textBoxPatient);
            panelContent.Controls.Add(labelPatient);
            panelContent.Controls.Add(textBoxID);
            panelContent.Controls.Add(labelID);
            panelContent.Controls.Add(labelContentHeader);
            panelContent.Location = new Point(30, 80);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(590, 490);
            panelContent.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(358, 379);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 40);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(39, 55, 77);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(159, 379);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 40);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxSlot
            // 
            comboBoxSlot.BackColor = Color.White;
            comboBoxSlot.FormattingEnabled = true;
            comboBoxSlot.Items.AddRange(new object[] { "9:00 AM", "10:00 AM", "11:00 AM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM" });
            comboBoxSlot.Location = new Point(159, 253);
            comboBoxSlot.Name = "comboBoxSlot";
            comboBoxSlot.Size = new Size(343, 28);
            comboBoxSlot.TabIndex = 12;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(159, 203);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(343, 27);
            dateTimePickerDate.TabIndex = 11;
            dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(39, 55, 77);
            label6.Location = new Point(48, 253);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 10;
            label6.Text = "Visit Slot:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(39, 55, 77);
            label5.Location = new Point(48, 206);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 9;
            label5.Text = "Visit Date:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.BackColor = Color.White;
            textBoxNotes.BorderStyle = BorderStyle.FixedSingle;
            textBoxNotes.Location = new Point(159, 305);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(343, 27);
            textBoxNotes.TabIndex = 8;
            // 
            // textBoxDate
            // 
            textBoxDate.AutoSize = true;
            textBoxDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDate.ForeColor = Color.FromArgb(39, 55, 77);
            textBoxDate.Location = new Point(68, 305);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(58, 23);
            textBoxDate.TabIndex = 7;
            textBoxDate.Text = "Date :";
            // 
            // textBoxSecretary
            // 
            textBoxSecretary.BackColor = Color.White;
            textBoxSecretary.BorderStyle = BorderStyle.FixedSingle;
            textBoxSecretary.Location = new Point(159, 153);
            textBoxSecretary.Name = "textBoxSecretary";
            textBoxSecretary.Size = new Size(343, 27);
            textBoxSecretary.TabIndex = 6;
            // 
            // labelSecretary
            // 
            labelSecretary.AutoSize = true;
            labelSecretary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSecretary.ForeColor = Color.FromArgb(39, 55, 77);
            labelSecretary.Location = new Point(48, 153);
            labelSecretary.Name = "labelSecretary";
            labelSecretary.Size = new Size(91, 23);
            labelSecretary.TabIndex = 5;
            labelSecretary.Text = "Secretary:";
            // 
            // textBoxPatient
            // 
            textBoxPatient.BackColor = Color.White;
            textBoxPatient.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatient.Location = new Point(159, 103);
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.Size = new Size(343, 27);
            textBoxPatient.TabIndex = 4;
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPatient.ForeColor = Color.FromArgb(39, 55, 77);
            labelPatient.Location = new Point(56, 103);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(72, 23);
            labelPatient.TabIndex = 3;
            labelPatient.Text = "Patient:";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.White;
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(159, 53);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(343, 27);
            textBoxID.TabIndex = 2;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.FromArgb(39, 55, 77);
            labelID.Location = new Point(85, 53);
            labelID.Name = "labelID";
            labelID.Size = new Size(33, 23);
            labelID.TabIndex = 1;
            labelID.Text = "ID:";
            // 
            // labelContentHeader
            // 
            labelContentHeader.AutoSize = true;
            labelContentHeader.BackColor = Color.FromArgb(82, 109, 130);
            labelContentHeader.Dock = DockStyle.Top;
            labelContentHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContentHeader.ForeColor = Color.White;
            labelContentHeader.Location = new Point(0, 0);
            labelContentHeader.Name = "labelContentHeader";
            labelContentHeader.Padding = new Padding(10);
            labelContentHeader.Size = new Size(264, 48);
            labelContentHeader.TabIndex = 0;
            labelContentHeader.Text = "Reservation Information";
            // 
            // EditReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 231, 239);
            ClientSize = new Size(650, 600);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EditReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Reservation";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private Label labelContentHeader;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxPatient;
        private Label labelPatient;
        private TextBox textBoxSecretary;
        private Label labelSecretary;
        private TextBox textBoxNotes;
        private Label textBoxDate;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxSlot;
        private Button buttonSave;
        private Button buttonDelete;
    }
}