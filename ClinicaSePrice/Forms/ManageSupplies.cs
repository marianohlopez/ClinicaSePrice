using ClinicaSePrice.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Forms
{
    public partial class ManageSupplies : Form
    {
        public ManageSupplies()
        {
            InitializeComponent();
            this.AcceptButton = btnAceptSupplies;
        }

        private void ManageSupplies_Load(object sender, EventArgs e)
        {
            LoadGrid();
            loadCBO();
        }


        private void LoadGrid()
        {
            // Limpia las filas del DataGridView para evitar duplicados
            dtgvManageSupplies.Rows.Clear();

            try
            {
                List<Supply> supplies = Supply.SelectAllForDisplay();

                if (supplies.Count == 0)
                {
                    MessageBox.Show("No hay insumos cargados");
                    return;
                }

                foreach (Supply supply in supplies)
                {
                    // Verificar y actualizar ReStock según la cantidad
                    if (supply.Amount <= 20 && !supply.ReStock)
                    {
                        supply.ReStock = true;
                        supply.Update(); // Llama a Update() si es necesario
                    }
                    else if (supply.Amount > 20 && supply.ReStock)
                    {
                        supply.ReStock = false;
                        supply.Update(); // Cambia ReStock a false si es necesario
                    }

                    // Añadir la fila al DataGridView con el estado actualizado
                    int row = dtgvManageSupplies.Rows.Add();
                    dtgvManageSupplies.Rows[row].Cells[0].Value = supply.ID;
                    dtgvManageSupplies.Rows[row].Cells[1].Value = supply.Name;
                    dtgvManageSupplies.Rows[row].Cells[2].Value = supply.Amount;
                    dtgvManageSupplies.Rows[row].Cells[3].Value = supply.ReStock ? "Sí" : "No";

                    // Cambiar el color de fondo si ReStock es true
                    if (supply.ReStock)
                    {
                        dtgvManageSupplies.Rows[row].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dtgvManageSupplies.Rows[row].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }





        public void loadCBO()
        {
            List<string> namesSupplies = Supply.getNameSupply();

            // Agrega todos los elementos a cboSupply
            cboSupply.Items.AddRange(namesSupplies.ToArray());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Supply.updateSupplies(this);
            LoadGrid();
        }

        private void nudManageSupplies_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
