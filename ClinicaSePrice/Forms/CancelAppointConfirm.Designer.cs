namespace ClinicaSePrice.Forms
{
    partial class CancelAppointConfirm
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
            btnCancelAppoint = new Button();
            groupBoxCancel = new GroupBox();
            SuspendLayout();
            // 
            // lblCancelAppoint
            // 
            lblCancelAppoint.AutoSize = true;
            lblCancelAppoint.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblCancelAppoint.Location = new Point(335, 40);
            lblCancelAppoint.Name = "lblCancelAppoint";
            lblCancelAppoint.Size = new Size(153, 25);
            lblCancelAppoint.TabIndex = 10;
            lblCancelAppoint.Text = "Cancelar turno";
            // 
            // btnCancelAppoint
            // 
            btnCancelAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnCancelAppoint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelAppoint.Location = new Point(348, 282);
            btnCancelAppoint.Name = "btnCancelAppoint";
            btnCancelAppoint.Size = new Size(130, 36);
            btnCancelAppoint.TabIndex = 17;
            btnCancelAppoint.Text = "ACEPTAR";
            btnCancelAppoint.UseVisualStyleBackColor = false;
            btnCancelAppoint.Click += btnAppointCancel_Click;
            // 
            // groupBoxCancel
            // 
            groupBoxCancel.Location = new Point(153, 89);
            groupBoxCancel.Name = "groupBoxCancel";
            groupBoxCancel.Size = new Size(528, 133);
            groupBoxCancel.TabIndex = 18;
            groupBoxCancel.TabStop = false;
            groupBoxCancel.Text = "Elija el turno a cancelar";
            // 
            // CancelAppointConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 344);
            Controls.Add(groupBoxCancel);
            Controls.Add(btnCancelAppoint);
            Controls.Add(lblCancelAppoint);
            Name = "CancelAppointConfirm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCancelAppoint;
        private Button btnCancelAppoint;
        public GroupBox groupBoxCancel;
    }
    
}