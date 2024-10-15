namespace ClinicaSePrice.Forms
{
    partial class StudyConfirm
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
            label1 = new Label();
            labelIDPatient = new Label();
            txtDni = new TextBox();
            btnSearchDni_Click = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(335, 23);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar Estudio";
            // 
            // labelIDPatient
            // 
            labelIDPatient.AutoSize = true;
            labelIDPatient.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            labelIDPatient.Location = new Point(191, 130);
            labelIDPatient.Name = "labelIDPatient";
            labelIDPatient.Size = new Size(180, 20);
            labelIDPatient.TabIndex = 1;
            labelIDPatient.Text = "Ingrese el DNI del paciente";
            //labelIDPatient.Click += label2_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(191, 153);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(400, 23);
            txtDni.TabIndex = 2;
            //txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnSearchDni_Click
            // 
            btnSearchDni_Click.BackColor = Color.FromArgb(100, 181, 246);
            btnSearchDni_Click.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearchDni_Click.Location = new Point(338, 271);
            btnSearchDni_Click.Name = "btnSearchDni_Click";
            btnSearchDni_Click.Size = new Size(130, 36);
            btnSearchDni_Click.TabIndex = 3;
            btnSearchDni_Click.Text = "ACEPTAR";
            btnSearchDni_Click.UseVisualStyleBackColor = false;
            btnSearchDni_Click.Click += button1_Click;
            // 
            // StudyConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchDni_Click);
            Controls.Add(txtDni);
            Controls.Add(labelIDPatient);
            Controls.Add(label1);
            Name = "StudyConfirm";
            Text = "StudyConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelIDPatient;
        private TextBox txtDni;
        private Button btnSearchDni_Click;
    }
}