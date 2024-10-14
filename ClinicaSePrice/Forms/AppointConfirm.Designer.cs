namespace ClinicaSePrice.Forms
{
    partial class AppointConfirm
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
            lblEspecialty = new Label();
            lblDateAppoint = new Label();
            lblSchedule = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            btnSearchDni = new Button();
            SuspendLayout();
            // 
            // lblMakeAppoint
            // 
            lblMakeAppoint.AutoSize = true;
            lblMakeAppoint.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblMakeAppoint.Location = new Point(339, 32);
            lblMakeAppoint.Name = "lblMakeAppoint";
            lblMakeAppoint.Size = new Size(148, 25);
            lblMakeAppoint.TabIndex = 8;
            lblMakeAppoint.Text = "Agendar turno";
            // 
            // lblEspecialty
            // 
            lblEspecialty.AutoSize = true;
            lblEspecialty.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEspecialty.Location = new Point(175, 99);
            lblEspecialty.Name = "lblEspecialty";
            lblEspecialty.Size = new Size(118, 24);
            lblEspecialty.TabIndex = 9;
            lblEspecialty.Text = "Especialidad";
            // 
            // lblDateAppoint
            // 
            lblDateAppoint.AutoSize = true;
            lblDateAppoint.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateAppoint.Location = new Point(369, 99);
            lblDateAppoint.Name = "lblDateAppoint";
            lblDateAppoint.Size = new Size(64, 24);
            lblDateAppoint.TabIndex = 10;
            lblDateAppoint.Text = "Fecha";
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchedule.Location = new Point(557, 99);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(72, 24);
            lblSchedule.TabIndex = 11;
            lblSchedule.Text = "Horario";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(278, 221);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(258, 23);
            txtDni.TabIndex = 12;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(308, 188);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(201, 20);
            lblDni.TabIndex = 13;
            lblDni.Text = "Ingrese el DNI del paciente";
            // 
            // btnSearchDni
            // 
            btnSearchDni.BackColor = Color.FromArgb(100, 181, 246);
            btnSearchDni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchDni.Location = new Point(348, 283);
            btnSearchDni.Name = "btnSearchDni";
            btnSearchDni.Size = new Size(130, 36);
            btnSearchDni.TabIndex = 14;
            btnSearchDni.Text = "ACEPTAR";
            btnSearchDni.UseVisualStyleBackColor = false;
            btnSearchDni.Click += btnSearchDni_Click;
            // 
            // AppointConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 344);
            Controls.Add(btnSearchDni);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblSchedule);
            Controls.Add(lblDateAppoint);
            Controls.Add(lblEspecialty);
            Controls.Add(lblMakeAppoint);
            Name = "AppointConfirm";
            Text = "AppointConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMakeAppoint;
        private Label lblEspecialty;
        private Label lblDateAppoint;
        private Label lblSchedule;
        private TextBox txtDni;
        private Label lblDni;
        private Button btnSearchDni;
    }
}