namespace ClinicaSePrice.Forms
{
    partial class DeliverConfirm
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
            btnDelivConfirm = new Button();
            groupBoxStudy = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(333, 22);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 2;
            label1.Text = "Retirar Estudio";
            // 
            // btnDelivConfirm
            // 
            btnDelivConfirm.BackColor = Color.FromArgb(100, 181, 246);
            btnDelivConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelivConfirm.Location = new Point(338, 271);
            btnDelivConfirm.Name = "btnDelivConfirm";
            btnDelivConfirm.Size = new Size(130, 36);
            btnDelivConfirm.TabIndex = 3;
            btnDelivConfirm.Text = "ACEPTAR";
            btnDelivConfirm.UseVisualStyleBackColor = false;
            btnDelivConfirm.Click += btnDelivConfirm_Click;
            // 
            // groupBoxStudy
            // 
            groupBoxStudy.Location = new Point(230, 50);
            groupBoxStudy.Name = "groupBoxStudy";
            groupBoxStudy.Size = new Size(323, 215);
            groupBoxStudy.TabIndex = 4;
            groupBoxStudy.TabStop = false;
            groupBoxStudy.Text = "Estudios del paciente:";
            // 
            // DeliverConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxStudy);
            Controls.Add(btnDelivConfirm);
            Controls.Add(label1);
            Name = "DeliverConfirm";
            Text = "DeliverConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnDelivConfirm;
        private GroupBox groupBoxStudy;
    }
}