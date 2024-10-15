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
            lblDni = new Label();
            label1 = new Label();
            label2 = new Label();
            cboSpont = new ComboBox();
            lblSpont = new Label();
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
            cboSpecialty.Location = new Point(62, 124);
            cboSpecialty.Name = "cboSpecialty";
            cboSpecialty.Size = new Size(205, 23);
            cboSpecialty.TabIndex = 9;
            cboSpecialty.SelectedIndexChanged += cboSpecialty_SelectedIndexChanged;
            // 
            // cboShifts
            // 
            cboShifts.FormattingEnabled = true;
            cboShifts.Items.AddRange(new object[] { "Cardiología", "\t", "Dermatología\t", "Neurología" });
            cboShifts.Location = new Point(558, 124);
            cboShifts.Name = "cboShifts";
            cboShifts.Size = new Size(205, 23);
            cboShifts.TabIndex = 10;
            // 
            // dtpAbleDays
            // 
            dtpAbleDays.Location = new Point(296, 124);
            dtpAbleDays.Name = "dtpAbleDays";
            dtpAbleDays.ShowCheckBox = true;
            dtpAbleDays.Size = new Size(233, 23);
            dtpAbleDays.TabIndex = 11;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(62, 101);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(99, 20);
            lblDni.TabIndex = 14;
            lblDni.Text = "Especialidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 101);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 15;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(558, 101);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 16;
            label2.Text = "Horario";
            // 
            // cboSpont
            // 
            cboSpont.FormattingEnabled = true;
            cboSpont.Items.AddRange(new object[] { "Radiografía", "Tomografía", "Resonancia", "Laboratorio" });
            cboSpont.Location = new Point(62, 205);
            cboSpont.Name = "cboSpont";
            cboSpont.Size = new Size(205, 23);
            cboSpont.TabIndex = 17;
            cboSpont.SelectedIndexChanged += cboSpont_SelectedIndexChanged;
            // 
            // lblSpont
            // 
            lblSpont.AutoSize = true;
            lblSpont.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpont.Location = new Point(62, 182);
            lblSpont.Name = "lblSpont";
            lblSpont.Size = new Size(168, 20);
            lblSpont.TabIndex = 18;
            lblSpont.Text = "Demanda espontánea";
            // 
            // MakeAppoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 326);
            Controls.Add(lblSpont);
            Controls.Add(cboSpont);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDni);
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
        private Label lblDni;
        private Label label1;
        private Label label2;
        private ComboBox cboSpont;
        private Label lblSpont;
    }
}