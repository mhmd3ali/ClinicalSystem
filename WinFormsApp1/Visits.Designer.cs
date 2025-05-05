namespace WinFormsApp1
{
    partial class Visits
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
            panelAddVisit = new Panel();
            buttonAddVisit = new Button();
            textBoxNotes = new TextBox();
            labelNotes = new Label();
            textBoxDiagnosis = new TextBox();
            labelDiagnosis = new Label();
            textBoxReasons = new TextBox();
            labelReasons = new Label();
            labelAddVisitHeader = new Label();
            panelPreviousVisits = new Panel();
            listBoxPreviousVisits = new ListBox();
            labelPreviousVisitsHeader = new Label();
            panelVisitDetails = new Panel();
            buttonEditVisit = new Button();
            textBoxVisitNotes = new TextBox();
            labelVisitNotes = new Label();
            textBoxVisitDiagnosis = new TextBox();
            labelVisitDiagnosis = new Label();
            textBoxVisitReasons = new TextBox();
            labelVisitReasons = new Label();
            textBoxDate = new TextBox();
            labelDoctorName = new Label();
            textBoxDoc = new TextBox();
            labelPatientName = new Label();
            textBoxSec = new TextBox();
            labelVisitDate = new Label();
            textBoxPatient = new TextBox();
            labelVisitTime = new Label();
            textBoxID = new TextBox();
            labelVisitID = new Label();
            labelVisitDetailsHeader = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelHeader.SuspendLayout();
            panelAddVisit.SuspendLayout();
            panelPreviousVisits.SuspendLayout();
            panelVisitDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 55, 77);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1208, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(185, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Patient Visits";
            // 
            // panelAddVisit
            // 
            panelAddVisit.BackColor = Color.FromArgb(221, 230, 237);
            panelAddVisit.BorderStyle = BorderStyle.FixedSingle;
            panelAddVisit.Controls.Add(buttonAddVisit);
            panelAddVisit.Controls.Add(textBoxNotes);
            panelAddVisit.Controls.Add(labelNotes);
            panelAddVisit.Controls.Add(textBoxDiagnosis);
            panelAddVisit.Controls.Add(labelDiagnosis);
            panelAddVisit.Controls.Add(textBoxReasons);
            panelAddVisit.Controls.Add(labelReasons);
            panelAddVisit.Controls.Add(labelAddVisitHeader);
            panelAddVisit.Location = new Point(30, 80);
            panelAddVisit.Name = "panelAddVisit";
            panelAddVisit.Size = new Size(400, 598);
            panelAddVisit.TabIndex = 1;
            // 
            // buttonAddVisit
            // 
            buttonAddVisit.BackColor = Color.FromArgb(82, 109, 130);
            buttonAddVisit.FlatAppearance.BorderSize = 0;
            buttonAddVisit.FlatStyle = FlatStyle.Flat;
            buttonAddVisit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddVisit.ForeColor = Color.White;
            buttonAddVisit.Location = new Point(128, 542);
            buttonAddVisit.Name = "buttonAddVisit";
            buttonAddVisit.Size = new Size(143, 45);
            buttonAddVisit.TabIndex = 7;
            buttonAddVisit.Text = "Add Visit";
            buttonAddVisit.UseVisualStyleBackColor = false;
            buttonAddVisit.Click += buttonAddVisit_Click;
            // 
            // textBoxNotes
            // 
            textBoxNotes.BackColor = Color.White;
            textBoxNotes.BorderStyle = BorderStyle.FixedSingle;
            textBoxNotes.Location = new Point(20, 427);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(358, 100);
            textBoxNotes.TabIndex = 6;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotes.ForeColor = Color.FromArgb(39, 55, 77);
            labelNotes.Location = new Point(20, 401);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(61, 23);
            labelNotes.TabIndex = 5;
            labelNotes.Text = "Notes:";
            // 
            // textBoxDiagnosis
            // 
            textBoxDiagnosis.BackColor = Color.White;
            textBoxDiagnosis.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiagnosis.Location = new Point(20, 252);
            textBoxDiagnosis.Multiline = true;
            textBoxDiagnosis.Name = "textBoxDiagnosis";
            textBoxDiagnosis.Size = new Size(358, 137);
            textBoxDiagnosis.TabIndex = 4;
            // 
            // labelDiagnosis
            // 
            labelDiagnosis.AutoSize = true;
            labelDiagnosis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiagnosis.ForeColor = Color.FromArgb(39, 55, 77);
            labelDiagnosis.Location = new Point(20, 226);
            labelDiagnosis.Name = "labelDiagnosis";
            labelDiagnosis.Size = new Size(92, 23);
            labelDiagnosis.TabIndex = 3;
            labelDiagnosis.Text = "Diagnosis:";
            // 
            // textBoxReasons
            // 
            textBoxReasons.BackColor = Color.White;
            textBoxReasons.BorderStyle = BorderStyle.FixedSingle;
            textBoxReasons.Location = new Point(20, 76);
            textBoxReasons.Multiline = true;
            textBoxReasons.Name = "textBoxReasons";
            textBoxReasons.Size = new Size(358, 137);
            textBoxReasons.TabIndex = 2;
            // 
            // labelReasons
            // 
            labelReasons.AutoSize = true;
            labelReasons.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReasons.ForeColor = Color.FromArgb(39, 55, 77);
            labelReasons.Location = new Point(20, 50);
            labelReasons.Name = "labelReasons";
            labelReasons.Size = new Size(78, 23);
            labelReasons.TabIndex = 1;
            labelReasons.Text = "Reasons:";
            // 
            // labelAddVisitHeader
            // 
            labelAddVisitHeader.AutoSize = true;
            labelAddVisitHeader.BackColor = Color.FromArgb(82, 109, 130);
            labelAddVisitHeader.Dock = DockStyle.Top;
            labelAddVisitHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddVisitHeader.ForeColor = Color.White;
            labelAddVisitHeader.Location = new Point(0, 0);
            labelAddVisitHeader.Name = "labelAddVisitHeader";
            labelAddVisitHeader.Padding = new Padding(10);
            labelAddVisitHeader.Size = new Size(118, 48);
            labelAddVisitHeader.TabIndex = 0;
            labelAddVisitHeader.Text = "Add Visit";
            // 
            // panelPreviousVisits
            // 
            panelPreviousVisits.BackColor = Color.FromArgb(221, 230, 237);
            panelPreviousVisits.BorderStyle = BorderStyle.FixedSingle;
            panelPreviousVisits.Controls.Add(listBoxPreviousVisits);
            panelPreviousVisits.Controls.Add(labelPreviousVisitsHeader);
            panelPreviousVisits.Location = new Point(446, 80);
            panelPreviousVisits.Name = "panelPreviousVisits";
            panelPreviousVisits.Size = new Size(320, 598);
            panelPreviousVisits.TabIndex = 2;
            // 
            // listBoxPreviousVisits
            // 
            listBoxPreviousVisits.FormattingEnabled = true;
            listBoxPreviousVisits.Location = new Point(15, 65);
            listBoxPreviousVisits.Name = "listBoxPreviousVisits";
            listBoxPreviousVisits.Size = new Size(290, 504);
            listBoxPreviousVisits.TabIndex = 2;
            listBoxPreviousVisits.SelectedIndexChanged += listBoxPreviousVisits_SelectedIndexChanged;
            // 
            // labelPreviousVisitsHeader
            // 
            labelPreviousVisitsHeader.AutoSize = true;
            labelPreviousVisitsHeader.BackColor = Color.FromArgb(82, 109, 130);
            labelPreviousVisitsHeader.Dock = DockStyle.Top;
            labelPreviousVisitsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPreviousVisitsHeader.ForeColor = Color.White;
            labelPreviousVisitsHeader.Location = new Point(0, 0);
            labelPreviousVisitsHeader.Name = "labelPreviousVisitsHeader";
            labelPreviousVisitsHeader.Padding = new Padding(10);
            labelPreviousVisitsHeader.Size = new Size(170, 48);
            labelPreviousVisitsHeader.TabIndex = 1;
            labelPreviousVisitsHeader.Text = "Previous Visits";
            // 
            // panelVisitDetails
            // 
            panelVisitDetails.BackColor = Color.FromArgb(221, 230, 237);
            panelVisitDetails.BorderStyle = BorderStyle.FixedSingle;
            panelVisitDetails.Controls.Add(buttonEditVisit);
            panelVisitDetails.Controls.Add(textBoxVisitNotes);
            panelVisitDetails.Controls.Add(labelVisitNotes);
            panelVisitDetails.Controls.Add(textBoxVisitDiagnosis);
            panelVisitDetails.Controls.Add(labelVisitDiagnosis);
            panelVisitDetails.Controls.Add(textBoxVisitReasons);
            panelVisitDetails.Controls.Add(labelVisitReasons);
            panelVisitDetails.Controls.Add(textBoxDate);
            panelVisitDetails.Controls.Add(labelDoctorName);
            panelVisitDetails.Controls.Add(textBoxDoc);
            panelVisitDetails.Controls.Add(labelPatientName);
            panelVisitDetails.Controls.Add(textBoxSec);
            panelVisitDetails.Controls.Add(labelVisitDate);
            panelVisitDetails.Controls.Add(textBoxPatient);
            panelVisitDetails.Controls.Add(labelVisitTime);
            panelVisitDetails.Controls.Add(textBoxID);
            panelVisitDetails.Controls.Add(labelVisitID);
            panelVisitDetails.Controls.Add(labelVisitDetailsHeader);
            panelVisitDetails.Location = new Point(780, 80);
            panelVisitDetails.Name = "panelVisitDetails";
            panelVisitDetails.Size = new Size(400, 598);
            panelVisitDetails.TabIndex = 3;
            // 
            // buttonEditVisit
            // 
            buttonEditVisit.BackColor = Color.FromArgb(82, 109, 130);
            buttonEditVisit.FlatAppearance.BorderSize = 0;
            buttonEditVisit.FlatStyle = FlatStyle.Flat;
            buttonEditVisit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditVisit.ForeColor = Color.White;
            buttonEditVisit.Location = new Point(128, 542);
            buttonEditVisit.Name = "buttonEditVisit";
            buttonEditVisit.Size = new Size(143, 45);
            buttonEditVisit.TabIndex = 19;
            buttonEditVisit.Text = "Edit Visit";
            buttonEditVisit.UseVisualStyleBackColor = false;
            buttonEditVisit.Click += buttonEditVisit_Click;
            // 
            // textBoxVisitNotes
            // 
            textBoxVisitNotes.BackColor = Color.White;
            textBoxVisitNotes.BorderStyle = BorderStyle.FixedSingle;
            textBoxVisitNotes.Location = new Point(116, 455);
            textBoxVisitNotes.Multiline = true;
            textBoxVisitNotes.Name = "textBoxVisitNotes";
            textBoxVisitNotes.Size = new Size(264, 73);
            textBoxVisitNotes.TabIndex = 18;
            // 
            // labelVisitNotes
            // 
            labelVisitNotes.AutoSize = true;
            labelVisitNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitNotes.ForeColor = Color.FromArgb(39, 55, 77);
            labelVisitNotes.Location = new Point(25, 457);
            labelVisitNotes.Name = "labelVisitNotes";
            labelVisitNotes.Size = new Size(55, 20);
            labelVisitNotes.TabIndex = 17;
            labelVisitNotes.Text = "Notes:";
            // 
            // textBoxVisitDiagnosis
            // 
            textBoxVisitDiagnosis.BackColor = Color.White;
            textBoxVisitDiagnosis.BorderStyle = BorderStyle.FixedSingle;
            textBoxVisitDiagnosis.Location = new Point(116, 366);
            textBoxVisitDiagnosis.Multiline = true;
            textBoxVisitDiagnosis.Name = "textBoxVisitDiagnosis";
            textBoxVisitDiagnosis.Size = new Size(264, 73);
            textBoxVisitDiagnosis.TabIndex = 16;
            // 
            // labelVisitDiagnosis
            // 
            labelVisitDiagnosis.AutoSize = true;
            labelVisitDiagnosis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitDiagnosis.ForeColor = Color.FromArgb(39, 55, 77);
            labelVisitDiagnosis.Location = new Point(12, 368);
            labelVisitDiagnosis.Name = "labelVisitDiagnosis";
            labelVisitDiagnosis.Size = new Size(81, 20);
            labelVisitDiagnosis.TabIndex = 15;
            labelVisitDiagnosis.Text = "Diagnosis:";
            // 
            // textBoxVisitReasons
            // 
            textBoxVisitReasons.BackColor = Color.White;
            textBoxVisitReasons.BorderStyle = BorderStyle.FixedSingle;
            textBoxVisitReasons.Location = new Point(116, 277);
            textBoxVisitReasons.Multiline = true;
            textBoxVisitReasons.Name = "textBoxVisitReasons";
            textBoxVisitReasons.Size = new Size(264, 73);
            textBoxVisitReasons.TabIndex = 14;
            // 
            // labelVisitReasons
            // 
            labelVisitReasons.AutoSize = true;
            labelVisitReasons.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitReasons.ForeColor = Color.FromArgb(39, 55, 77);
            labelVisitReasons.Location = new Point(15, 279);
            labelVisitReasons.Name = "labelVisitReasons";
            labelVisitReasons.Size = new Size(71, 20);
            labelVisitReasons.TabIndex = 13;
            labelVisitReasons.Text = "Reasons:";
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.White;
            textBoxDate.BorderStyle = BorderStyle.FixedSingle;
            textBoxDate.Location = new Point(116, 232);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(264, 27);
            textBoxDate.TabIndex = 12;
            // 
            // labelDoctorName
            // 
            labelDoctorName.AutoSize = true;
            labelDoctorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDoctorName.ForeColor = Color.FromArgb(39, 55, 77);
            labelDoctorName.Location = new Point(23, 197);
            labelDoctorName.Name = "labelDoctorName";
            labelDoctorName.Size = new Size(62, 20);
            labelDoctorName.TabIndex = 11;
            labelDoctorName.Text = "Doctor:";
            // 
            // textBoxDoc
            // 
            textBoxDoc.BackColor = Color.White;
            textBoxDoc.BorderStyle = BorderStyle.FixedSingle;
            textBoxDoc.Location = new Point(116, 190);
            textBoxDoc.Name = "textBoxDoc";
            textBoxDoc.Size = new Size(264, 27);
            textBoxDoc.TabIndex = 10;
            // 
            // labelPatientName
            // 
            labelPatientName.AutoSize = true;
            labelPatientName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPatientName.ForeColor = Color.FromArgb(39, 55, 77);
            labelPatientName.Location = new Point(25, 239);
            labelPatientName.Name = "labelPatientName";
            labelPatientName.Size = new Size(50, 20);
            labelPatientName.TabIndex = 9;
            labelPatientName.Text = "Date :";
            // 
            // textBoxSec
            // 
            textBoxSec.BackColor = Color.White;
            textBoxSec.BorderStyle = BorderStyle.FixedSingle;
            textBoxSec.Location = new Point(116, 148);
            textBoxSec.Name = "textBoxSec";
            textBoxSec.Size = new Size(264, 27);
            textBoxSec.TabIndex = 8;
            // 
            // labelVisitDate
            // 
            labelVisitDate.AutoSize = true;
            labelVisitDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitDate.ForeColor = Color.FromArgb(39, 55, 77);
            labelVisitDate.Location = new Point(15, 155);
            labelVisitDate.Name = "labelVisitDate";
            labelVisitDate.Size = new Size(87, 20);
            labelVisitDate.TabIndex = 7;
            labelVisitDate.Text = "Secretary : ";
            // 
            // textBoxPatient
            // 
            textBoxPatient.BackColor = Color.White;
            textBoxPatient.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatient.Location = new Point(116, 106);
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.Size = new Size(264, 27);
            textBoxPatient.TabIndex = 6;
            // 
            // labelVisitTime
            // 
            labelVisitTime.AutoSize = true;
            labelVisitTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitTime.ForeColor = Color.FromArgb(39, 55, 77);
            labelVisitTime.Location = new Point(19, 108);
            labelVisitTime.Name = "labelVisitTime";
            labelVisitTime.Size = new Size(67, 20);
            labelVisitTime.TabIndex = 5;
            labelVisitTime.Text = "Patient :";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.White;
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(116, 64);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(264, 27);
            textBoxID.TabIndex = 4;
            // 
            // labelVisitID
            // 
            labelVisitID.AutoSize = true;
            labelVisitID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitID.ForeColor = Color.FromArgb(39, 55, 77);
            labelVisitID.Location = new Point(52, 66);
            labelVisitID.Name = "labelVisitID";
            labelVisitID.Size = new Size(29, 20);
            labelVisitID.TabIndex = 3;
            labelVisitID.Text = "ID:";
            // 
            // labelVisitDetailsHeader
            // 
            labelVisitDetailsHeader.AutoSize = true;
            labelVisitDetailsHeader.BackColor = Color.FromArgb(82, 109, 130);
            labelVisitDetailsHeader.Dock = DockStyle.Top;
            labelVisitDetailsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVisitDetailsHeader.ForeColor = Color.White;
            labelVisitDetailsHeader.Location = new Point(0, 0);
            labelVisitDetailsHeader.Name = "labelVisitDetailsHeader";
            labelVisitDetailsHeader.Padding = new Padding(10);
            labelVisitDetailsHeader.Size = new Size(146, 48);
            labelVisitDetailsHeader.TabIndex = 2;
            labelVisitDetailsHeader.Text = "Visit Details";
            // 
            // Visits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 231, 239);
            ClientSize = new Size(1208, 702);
            Controls.Add(panelVisitDetails);
            Controls.Add(panelPreviousVisits);
            Controls.Add(panelAddVisit);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Visits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Visits";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelAddVisit.ResumeLayout(false);
            panelAddVisit.PerformLayout();
            panelPreviousVisits.ResumeLayout(false);
            panelPreviousVisits.PerformLayout();
            panelVisitDetails.ResumeLayout(false);
            panelVisitDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelAddVisit;
        private Label labelAddVisitHeader;
        private TextBox textBoxReasons;
        private Label labelReasons;
        private TextBox textBoxNotes;
        private Label labelNotes;
        private TextBox textBoxDiagnosis;
        private Label labelDiagnosis;
        private Button buttonAddVisit;
        private Panel panelPreviousVisits;
        private Label labelPreviousVisitsHeader;
        private ListBox listBoxPreviousVisits;
        private Panel panelVisitDetails;
        private Label labelVisitDetailsHeader;
        private TextBox textBoxID;
        private Label labelVisitID;
        private TextBox textBoxPatient;
        private Label labelVisitTime;
        private TextBox textBoxSec;
        private Label labelVisitDate;
        private TextBox textBoxDoc;
        private Label labelPatientName;
        private TextBox textBoxDate;
        private Label labelDoctorName;
        private TextBox textBoxVisitNotes;
        private Label labelVisitNotes;
        private TextBox textBoxVisitDiagnosis;
        private Label labelVisitDiagnosis;
        private TextBox textBoxVisitReasons;
        private Label labelVisitReasons;
        private Button buttonEditVisit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}