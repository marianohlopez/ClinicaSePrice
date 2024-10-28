namespace ClinicaSePrice.Forms
{
    partial class RegisterStudy
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
            comboSpecialty = new ComboBox();
            comboSection = new ComboBox();
            btnRegisterStudy = new Button();
            labelTitleForm = new Label();
            labelSpecialty = new Label();
            labelSection = new Label();
            SuspendLayout();
            // 
            // comboSpecialty
            // 
            comboSpecialty.DropDownWidth = 180;
            comboSpecialty.FormattingEnabled = true;
            comboSpecialty.Location = new Point(191, 153);
            comboSpecialty.Name = "comboSpecialty";
            comboSpecialty.Size = new Size(177, 23);
            comboSpecialty.TabIndex = 0;
            comboSpecialty.Text = "Seleccione una opción";
            // 
            // comboSection
            // 
            comboSection.DropDownWidth = 180;
            comboSection.FormattingEnabled = true;
            comboSection.Location = new Point(450, 153);
            comboSection.Name = "comboSection";
            comboSection.Size = new Size(181, 23);
            comboSection.TabIndex = 1;
            comboSection.Text = "Seleccione una opción";
            // 
            // btnRegisterStudy
            // 
            btnRegisterStudy.BackColor = Color.FromArgb(100, 181, 246);
            btnRegisterStudy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegisterStudy.Location = new Point(338, 271);
            btnRegisterStudy.Name = "btnRegisterStudy";
            btnRegisterStudy.Size = new Size(130, 36);
            btnRegisterStudy.TabIndex = 2;
            btnRegisterStudy.Text = "ACEPTAR";
            btnRegisterStudy.UseVisualStyleBackColor = false;
            btnRegisterStudy.Click += btnRegisterStudy_Click;
            // 
            // labelTitleForm
            // 
            labelTitleForm.AutoSize = true;
            labelTitleForm.Font = new Font("Segoe UI", 14.25F);
            labelTitleForm.Location = new Point(335, 23);
            labelTitleForm.Name = "labelTitleForm";
            labelTitleForm.Size = new Size(153, 25);
            labelTitleForm.TabIndex = 3;
            labelTitleForm.Text = "Registrar Estudio";
            labelTitleForm.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSpecialty
            // 
            labelSpecialty.AutoSize = true;
            labelSpecialty.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            labelSpecialty.Location = new Point(191, 130);
            labelSpecialty.Name = "labelSpecialty";
            labelSpecialty.Size = new Size(88, 20);
            labelSpecialty.TabIndex = 4;
            labelSpecialty.Text = "Especialidad";
            // 
            // labelSection
            // 
            labelSection.AutoSize = true;
            labelSection.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            labelSection.Location = new Point(450, 130);
            labelSection.Name = "labelSection";
            labelSection.Size = new Size(57, 20);
            labelSection.TabIndex = 5;
            labelSection.Text = "Sección";
            // 
            // RegisterStudy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSection);
            Controls.Add(labelSpecialty);
            Controls.Add(labelTitleForm);
            Controls.Add(btnRegisterStudy);
            Controls.Add(comboSection);
            Controls.Add(comboSpecialty);
            Name = "RegisterStudy";
            Text = "Form1";
            Load += RegisterStudy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboSpecialty;
        private ComboBox comboSection;
        private Button btnRegisterStudy;
        private Label labelTitleForm;
        private Label labelSpecialty;
        private Label labelSection;
    }
}