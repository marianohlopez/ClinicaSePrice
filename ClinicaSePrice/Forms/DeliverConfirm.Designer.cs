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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            radioButton1.Location = new Point(293, 141);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(214, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Especialidad: RX - Sección B2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            radioButton2.Location = new Point(292, 183);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(217, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Especialidad: RM - Sección A1";
            radioButton2.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(100, 181, 246);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Location = new Point(338, 271);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 3;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // DeliverConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "DeliverConfirm";
            Text = "DeliverConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Button button1;
    }
}