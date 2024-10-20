namespace ClinicaSePrice.Forms
{
    partial class RatifyAppointConfirm
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
            radioButton1 = new RadioButton();
            rbRatifyAppoint = new Button();
            SuspendLayout();
            // 
            // lblRatifyAppoint
            // 
            lblRatifyAppoint.AutoSize = true;
            lblRatifyAppoint.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblRatifyAppoint.Location = new Point(335, 40);
            lblRatifyAppoint.Name = "lblRatifyAppoint";
            lblRatifyAppoint.Size = new Size(153, 25);
            lblRatifyAppoint.TabIndex = 11;
            lblRatifyAppoint.Text = "Acreditar turno";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            radioButton1.Location = new Point(307, 106);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(214, 24);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Especialidad: RX - Sección B2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbRatifyAppoint
            // 
            rbRatifyAppoint.BackColor = Color.FromArgb(100, 181, 246);
            rbRatifyAppoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbRatifyAppoint.Location = new Point(348, 282);
            rbRatifyAppoint.Name = "rbRatifyAppoint";
            rbRatifyAppoint.Size = new Size(130, 36);
            rbRatifyAppoint.TabIndex = 20;
            rbRatifyAppoint.Text = "ACEPTAR";
            rbRatifyAppoint.UseVisualStyleBackColor = false;
            // 
            // RatifyAppointConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 344);
            Controls.Add(rbRatifyAppoint);
            Controls.Add(radioButton1);
            Controls.Add(lblRatifyAppoint);
            Name = "RatifyAppointConfirm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRatifyAppoint;
        private RadioButton radioButton1;
        private Button rbRatifyAppoint;
    }
}