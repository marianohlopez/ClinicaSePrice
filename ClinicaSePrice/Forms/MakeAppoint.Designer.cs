namespace ClinicaSePrice.Forms
{
    partial class MakeAppoint
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
            lblMakeAppoint = new Label();
            btnSetAppoint = new Button();
            cboSpecialty = new ComboBox();
            cboShifts = new ComboBox();
            dtpAbleDays = new DateTimePicker();
            SuspendLayout();
            // 
            // lblMakeAppoint
            // 
            lblMakeAppoint.AutoSize = true;
            lblMakeAppoint.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblMakeAppoint.Location = new Point(341, 31);
            lblMakeAppoint.Name = "lblMakeAppoint";
            lblMakeAppoint.Size = new Size(148, 25);
            lblMakeAppoint.TabIndex = 7;
            lblMakeAppoint.Text = "Agendar turno";
            // 
            // btnSetAppoint
            // 
            btnSetAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnSetAppoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetAppoint.Location = new Point(350, 255);
            btnSetAppoint.Name = "btnSetAppoint";
            btnSetAppoint.Size = new Size(130, 36);
            btnSetAppoint.TabIndex = 8;
            btnSetAppoint.Text = "ACEPTAR";
            btnSetAppoint.UseVisualStyleBackColor = false;
            btnSetAppoint.Click += btnSetAppoint_Click;
            // 
            // cboSpecialty
            // 
            cboSpecialty.FormattingEnabled = true;
            cboSpecialty.Items.AddRange(new object[] { "Cardiología", "Dermatología", "Neurología" });
            cboSpecialty.Location = new Point(66, 142);
            cboSpecialty.Name = "cboSpecialty";
            cboSpecialty.Size = new Size(205, 23);
            cboSpecialty.TabIndex = 9;
            cboSpecialty.SelectedIndexChanged += cboSpecialty_SelectedIndexChanged;
            // 
            // cboShifts
            // 
            cboShifts.FormattingEnabled = true;
            cboShifts.Items.AddRange(new object[] { "Cardiología", "\t", "Dermatología\t", "Neurología" });
            cboShifts.Location = new Point(562, 142);
            cboShifts.Name = "cboShifts";
            cboShifts.Size = new Size(205, 23);
            cboShifts.TabIndex = 10;
            // 
            // dtpAbleDays
            // 
            dtpAbleDays.Location = new Point(300, 142);
            dtpAbleDays.Name = "dtpAbleDays";
            dtpAbleDays.ShowCheckBox = true;
            dtpAbleDays.Size = new Size(233, 23);
            dtpAbleDays.TabIndex = 11;
            // 
            // MakeAppoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 326);
            Controls.Add(dtpAbleDays);
            Controls.Add(cboShifts);
            Controls.Add(cboSpecialty);
            Controls.Add(btnSetAppoint);
            Controls.Add(lblMakeAppoint);
            Name = "MakeAppoint";
            Text = "MakeAppoint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMakeAppoint;
        private Button btnSetAppoint;
        private ComboBox cboSpecialty;
        private ComboBox cboShifts;
        private DateTimePicker dtpAbleDays;
    }
}