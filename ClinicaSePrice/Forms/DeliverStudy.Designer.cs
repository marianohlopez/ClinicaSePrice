namespace ClinicaSePrice.Forms
{
    partial class DeliverStudy
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
            labelTitleDeliverForm = new Label();
            labelIDPatient = new Label();
            textBox1 = new TextBox();
            btnDelivStudy = new Button();
            SuspendLayout();
            // 
            // labelTitleDeliverForm
            // 
            labelTitleDeliverForm.AutoSize = true;
            labelTitleDeliverForm.Font = new Font("Segoe UI", 14.25F);
            labelTitleDeliverForm.Location = new Point(336, 26);
            labelTitleDeliverForm.Name = "labelTitleDeliverForm";
            labelTitleDeliverForm.Size = new Size(134, 25);
            labelTitleDeliverForm.TabIndex = 0;
            labelTitleDeliverForm.Text = "Retirar Estudio";
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 23);
            textBox1.TabIndex = 2;
            // 
            // btnDelivStudy
            // 
            btnDelivStudy.BackColor = Color.FromArgb(100, 181, 246);
            btnDelivStudy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelivStudy.Location = new Point(338, 271);
            btnDelivStudy.Name = "btnDelivStudy";
            btnDelivStudy.Size = new Size(130, 36);
            btnDelivStudy.TabIndex = 3;
            btnDelivStudy.Text = "ACEPTAR";
            btnDelivStudy.UseVisualStyleBackColor = false;
            btnDelivStudy.Click += btnDelivStudy_Click;
            // 
            // DeliverStudy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelivStudy);
            Controls.Add(textBox1);
            Controls.Add(labelIDPatient);
            Controls.Add(labelTitleDeliverForm);
            Name = "DeliverStudy";
            Text = "DeliverStudy";
            Load += DeliverStudy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleDeliverForm;
        private Label labelIDPatient;
        private TextBox textBox1;
        private Button btnDelivStudy;
    }
}