namespace ClinicaSePrice.Forms
{
    partial class CancelAppoint
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
            lblCancelAppoint = new Label();
            lblDniCancel = new Label();
            txtDniCancel = new TextBox();
            btnSearchDniCancel = new Button();
            SuspendLayout();
            // 
            // lblCancelAppoint
            // 
            lblCancelAppoint.AutoSize = true;
            lblCancelAppoint.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblCancelAppoint.Location = new Point(335, 40);
            lblCancelAppoint.Name = "lblCancelAppoint";
            lblCancelAppoint.Size = new Size(153, 25);
            lblCancelAppoint.TabIndex = 9;
            lblCancelAppoint.Text = "Cancelar turno";
            // 
            // lblDniCancel
            // 
            lblDniCancel.AutoSize = true;
            lblDniCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDniCancel.Location = new Point(307, 106);
            lblDniCancel.Name = "lblDniCancel";
            lblDniCancel.Size = new Size(201, 20);
            lblDniCancel.TabIndex = 14;
            lblDniCancel.Text = "Ingrese el DNI del paciente";
            // 
            // txtDniCancel
            // 
            txtDniCancel.Location = new Point(277, 137);
            txtDniCancel.Name = "txtDniCancel";
            txtDniCancel.Size = new Size(258, 23);
            txtDniCancel.TabIndex = 15;
            // 
            // btnSearchDniCancel
            // 
            btnSearchDniCancel.BackColor = Color.FromArgb(100, 181, 246);
            btnSearchDniCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchDniCancel.Location = new Point(348, 282);
            btnSearchDniCancel.Name = "btnSearchDniCancel";
            btnSearchDniCancel.Size = new Size(130, 36);
            btnSearchDniCancel.TabIndex = 16;
            btnSearchDniCancel.Text = "ACEPTAR";
            btnSearchDniCancel.UseVisualStyleBackColor = false;
            btnSearchDniCancel.Click += btnSearchDniCancel_Click;
            // 
            // CancelAppoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 344);
            Controls.Add(btnSearchDniCancel);
            Controls.Add(txtDniCancel);
            Controls.Add(lblDniCancel);
            Controls.Add(lblCancelAppoint);
            Name = "CancelAppoint";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCancelAppoint;
        private Label lblDniCancel;
        private TextBox txtDniCancel;
        private Button btnSearchDniCancel;
    }
}