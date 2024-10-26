namespace ClinicaSePrice.Forms
{
    partial class RatifyAppoint
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
            lblRatifyAppoint = new Label();
            btnSearchDniRatify = new Button();
            txtDniRatify = new TextBox();
            lblDniRatify = new Label();
            SuspendLayout();
            // 
            // lblRatifyAppoint
            // 
            lblRatifyAppoint.AutoSize = true;
            lblRatifyAppoint.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblRatifyAppoint.Location = new Point(335, 40);
            lblRatifyAppoint.Name = "lblRatifyAppoint";
            lblRatifyAppoint.Size = new Size(153, 25);
            lblRatifyAppoint.TabIndex = 10;
            lblRatifyAppoint.Text = "Acreditar turno";
            // 
            // btnSearchDniRatify
            // 
            btnSearchDniRatify.BackColor = Color.FromArgb(100, 181, 246);
            btnSearchDniRatify.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchDniRatify.Location = new Point(348, 282);
            btnSearchDniRatify.Name = "btnSearchDniRatify";
            btnSearchDniRatify.Size = new Size(130, 36);
            btnSearchDniRatify.TabIndex = 19;
            btnSearchDniRatify.Text = "ACEPTAR";
            btnSearchDniRatify.UseVisualStyleBackColor = false;
            btnSearchDniRatify.Click += btnSearchDniRatify_Click;
            // 
            // txtDniRatify
            // 
            txtDniRatify.Location = new Point(277, 137);
            txtDniRatify.Name = "txtDniRatify";
            txtDniRatify.Size = new Size(258, 23);
            txtDniRatify.TabIndex = 18;
            // 
            // lblDniRatify
            // 
            lblDniRatify.AutoSize = true;
            lblDniRatify.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDniRatify.Location = new Point(307, 106);
            lblDniRatify.Name = "lblDniRatify";
            lblDniRatify.Size = new Size(201, 20);
            lblDniRatify.TabIndex = 17;
            lblDniRatify.Text = "Ingrese el DNI del paciente";
            // 
            // RatifyAppoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 344);
            Controls.Add(btnSearchDniRatify);
            Controls.Add(txtDniRatify);
            Controls.Add(lblDniRatify);
            Controls.Add(lblRatifyAppoint);
            Name = "RatifyAppoint";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRatifyAppoint;
        private Button btnSearchDniRatify;
        private TextBox txtDniRatify;
        private Label lblDniRatify;
    }
}