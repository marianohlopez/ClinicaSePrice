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
            btnRegAppoint = new Button();
            btnDelivAppoint = new Button();
            lblWelcome = new Label();
            btnRfAppoint = new Button();
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
            btnClAppoint.Click += btnClAppoint_Click;
            // 
            // btnRegAppoint
            // 
            btnRegAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnRegAppoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnRegAppoint.Location = new Point(32, 230);
            btnRegAppoint.Name = "btnRegAppoint";
            btnRegAppoint.Size = new Size(230, 69);
            btnRegAppoint.TabIndex = 4;
            btnRegAppoint.Text = "Registrar estudio";
            btnRegAppoint.UseVisualStyleBackColor = false;
            // 
            // btnDelivAppoint
            // 
            btnDelivAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnDelivAppoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnDelivAppoint.Location = new Point(289, 230);
            btnDelivAppoint.Name = "btnDelivAppoint";
            btnDelivAppoint.Size = new Size(230, 69);
            btnDelivAppoint.TabIndex = 5;
            btnDelivAppoint.Text = "Entregar estudio";
            btnDelivAppoint.UseVisualStyleBackColor = false;
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
            // btnRfAppoint
            // 
            btnRfAppoint.BackColor = Color.FromArgb(100, 181, 246);
            btnRfAppoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btnRfAppoint.Location = new Point(546, 134);
            btnRfAppoint.Name = "btnRfAppoint";
            btnRfAppoint.Size = new Size(230, 69);
            btnRfAppoint.TabIndex = 7;
            btnRfAppoint.Text = "Acreditar turno";
            btnRfAppoint.UseVisualStyleBackColor = false;
            btnRfAppoint.Click += btnRfAppoint_Click;
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
            Controls.Add(btnRfAppoint);
            Controls.Add(lblWelcome);
            Controls.Add(btnDelivAppoint);
            Controls.Add(btnRegAppoint);
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
        private Button btnRegAppoint;
        private Button btnDelivAppoint;
        private Label lblWelcome;
        private Button btnRfAppoint;
        private Button btnMngSuppl;
        private Button btnClose;
    }
}
