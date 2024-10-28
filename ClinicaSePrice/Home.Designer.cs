namespace ClinicaSePrice
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRole = new Label();
            lblUserName = new Label();
            btnMkAppoint = new Button();
            btnClAppoint = new Button();
            btnRegStudy = new Button();
            btnDelivStudy = new Button();
            lblWelcome = new Label();
            btnAcrAppoint = new Button();
            btnMngSuppl = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblRole.Location = new Point(192, 20);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(70, 25);
            lblRole.TabIndex = 0;
            lblRole.Text = "label1";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblUserName.Location = new Point(125, 20);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            // 
            // btnMkAppoint
            // 
            btnMkAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnMkAppoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnMkAppoint.Location = new Point(32, 134);
            btnMkAppoint.Name = "btnMkAppoint";
            btnMkAppoint.Size = new Size(230, 69);
            btnMkAppoint.TabIndex = 2;
            btnMkAppoint.Text = "Agendar turno";
            btnMkAppoint.UseVisualStyleBackColor = false;
            btnMkAppoint.Click += btnMkAppoint_Click;
            // 
            // btnClAppoint
            // 
            btnClAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnClAppoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnClAppoint.Location = new Point(289, 134);
            btnClAppoint.Name = "btnClAppoint";
            btnClAppoint.Size = new Size(230, 69);
            btnClAppoint.TabIndex = 3;
            btnClAppoint.Text = "Cancelar turno";
            btnClAppoint.UseVisualStyleBackColor = false;
            // 
            // btnRegStudy
            // 
            btnRegStudy.BackColor = Color.FromArgb(100, 181, 246);
            btnRegStudy.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnRegStudy.Location = new Point(32, 230);
            btnRegStudy.Name = "btnRegStudy";
            btnRegStudy.Size = new Size(230, 69);
            btnRegStudy.TabIndex = 4;
            btnRegStudy.Text = "Registrar estudio";
            btnRegStudy.UseVisualStyleBackColor = false;
            btnRegStudy.Click += btnRegStudy_Click;
            // 
            // btnDelivStudy
            // 
            btnDelivStudy.BackColor = Color.FromArgb(100, 181, 246);
            btnDelivStudy.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnDelivStudy.Location = new Point(289, 230);
            btnDelivStudy.Name = "btnDelivStudy";
            btnDelivStudy.Size = new Size(230, 69);
            btnDelivStudy.TabIndex = 5;
            btnDelivStudy.Text = "Entregar estudio";
            btnDelivStudy.UseVisualStyleBackColor = false;
            btnDelivStudy.Click += btnDelivStudy_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblWelcome.Location = new Point(12, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(119, 25);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Bienvenido";
            // 
            // btnAcrAppoint
            // 
            btnAcrAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnAcrAppoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnAcrAppoint.Location = new Point(546, 134);
            btnAcrAppoint.Name = "btnAcrAppoint";
            btnAcrAppoint.Size = new Size(230, 69);
            btnAcrAppoint.TabIndex = 7;
            btnAcrAppoint.Text = "Acreditar turno";
            btnAcrAppoint.UseVisualStyleBackColor = false;
            // 
            // btnMngSuppl
            // 
            btnMngSuppl.BackColor = Color.FromArgb(100, 181, 246);
            btnMngSuppl.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnMngSuppl.Location = new Point(546, 230);
            btnMngSuppl.Name = "btnMngSuppl";
            btnMngSuppl.Size = new Size(230, 69);
            btnMngSuppl.TabIndex = 8;
            btnMngSuppl.Text = "Gestionar insumos";
            btnMngSuppl.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(100, 181, 246);
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnClose.Location = new Point(641, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 34);
            btnClose.TabIndex = 9;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnMngSuppl);
            Controls.Add(btnAcrAppoint);
            Controls.Add(lblWelcome);
            Controls.Add(btnDelivStudy);
            Controls.Add(btnRegStudy);
            Controls.Add(btnClAppoint);
            Controls.Add(btnMkAppoint);
            Controls.Add(lblUserName);
            Controls.Add(lblRole);
            Name = "Home";
            Text = "Home";
            FormClosing += Home_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRole;
        private Label lblUserName;
        private Button btnMkAppoint;
        private Button btnClAppoint;
        private Button btnRegStudy;
        private Button btnDelivStudy;
        private Label lblWelcome;
        private Button btnAcrAppoint;
        private Button btnMngSuppl;
        private Button btnClose;
    }
}
