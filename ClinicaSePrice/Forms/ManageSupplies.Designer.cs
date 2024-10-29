using ClinicaSePrice.Classes;

namespace ClinicaSePrice.Forms
{
    partial class ManageSupplies
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblManageSupplies = new Label();
            dtgvManageSupplies = new DataGridView();
            cellID = new DataGridViewTextBoxColumn();
            cellName = new DataGridViewTextBoxColumn();
            cellAmount = new DataGridViewTextBoxColumn();
            cellReStock = new DataGridViewTextBoxColumn();
            lblStock = new Label();
            cboSupply = new ComboBox();
            nudManageSupplies = new NumericUpDown();
            btnAceptSupplies = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvManageSupplies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudManageSupplies).BeginInit();
            SuspendLayout();
            // 
            // lblManageSupplies
            // 
            lblManageSupplies.AutoSize = true;
            lblManageSupplies.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManageSupplies.Location = new Point(309, 29);
            lblManageSupplies.Name = "lblManageSupplies";
            lblManageSupplies.Size = new Size(191, 25);
            lblManageSupplies.TabIndex = 1;
            lblManageSupplies.Text = "Gestionar Insumos";
            lblManageSupplies.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtgvManageSupplies
            // 
            dtgvManageSupplies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvManageSupplies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvManageSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvManageSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvManageSupplies.Columns.AddRange(new DataGridViewColumn[] { cellID, cellName, cellAmount, cellReStock });
            dtgvManageSupplies.Location = new Point(2, 57);
            dtgvManageSupplies.Name = "dtgvManageSupplies";
            dtgvManageSupplies.Size = new Size(796, 181);
            dtgvManageSupplies.TabIndex = 2;
            // 
            // cellID
            // 
            cellID.HeaderText = "ID PRODUCTO";
            cellID.Name = "cellID";
            // 
            // cellName
            // 
            cellName.HeaderText = "INSUMO";
            cellName.Name = "cellName";
            // 
            // cellAmount
            // 
            cellAmount.HeaderText = "CANTIDAD";
            cellAmount.Name = "cellAmount";
            // 
            // cellReStock
            // 
            cellReStock.HeaderText = "PEDIR RE-STOCK";
            cellReStock.Name = "cellReStock";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(42, 250);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(149, 20);
            lblStock.TabIndex = 20;
            lblStock.Text = "Seleccionar Insumo";
            // 
            // cboSupply
            // 
            cboSupply.FormattingEnabled = true;
            cboSupply.Location = new Point(42, 273);
            cboSupply.Name = "cboSupply";
            cboSupply.Size = new Size(205, 23);
            cboSupply.TabIndex = 19;
            // 
            // nudManageSupplies
            // 
            nudManageSupplies.Location = new Point(272, 273);
            nudManageSupplies.Name = "nudManageSupplies";
            nudManageSupplies.Size = new Size(120, 23);
            nudManageSupplies.TabIndex = 21;
            nudManageSupplies.ValueChanged += nudManageSupplies_ValueChanged;
            nudManageSupplies.Minimum = -100; // Permite valores desde -100
            nudManageSupplies.Maximum = 100;   // Permite valores hasta 100
            // 
            // btnAceptSupplies
            // 
            btnAceptSupplies.BackColor = Color.FromArgb(100, 181, 246);
            btnAceptSupplies.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptSupplies.Location = new Point(536, 265);
            btnAceptSupplies.Name = "btnAceptSupplies";
            btnAceptSupplies.Size = new Size(130, 36);
            btnAceptSupplies.TabIndex = 22;
            btnAceptSupplies.Text = "ACEPTAR";
            btnAceptSupplies.UseVisualStyleBackColor = false;
            btnAceptSupplies.Click += btnActualizar_Click;
            // 
            // ManageSupplies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 344);
            Controls.Add(btnAceptSupplies);
            Controls.Add(nudManageSupplies);
            Controls.Add(lblStock);
            Controls.Add(cboSupply);
            Controls.Add(dtgvManageSupplies);
            Controls.Add(lblManageSupplies);
            Name = "ManageSupplies";
            Text = "ListMembers";
            Load += ManageSupplies_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvManageSupplies).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudManageSupplies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblManageSupplies;
        private DataGridView dtgvManageSupplies;
        private DataGridViewTextBoxColumn cellID;
        private DataGridViewTextBoxColumn cellName;
        private DataGridViewTextBoxColumn cellAmount;
        private DataGridViewTextBoxColumn cellReStock;
        private Label lblStock;
        public ComboBox cboSupply;
        private Button btnAceptSupplies;
        public NumericUpDown nudManageSupplies;
    }
}