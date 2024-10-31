using ClinicaSePrice.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Forms
{
    public partial class RatifyAppointConfirm : Form
    {
        public string dni { get; set; } = ""; // Asignando un valor por defecto
        public RatifyAppointConfirm(string dni)
        {
            InitializeComponent();
            this.AcceptButton = rbRatifyAppoint;

            this.dni = dni;
        }

        private void btnAppointRatify_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBoxRatify.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    int ID = (int)radioButton.Tag;

                    // Mostrar un mensaje de confirmación
                    if (MessageBox.Show("¿Estás seguro de que deseas acreditar este turno?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RatifyAppointment ratifyAppointment = new RatifyAppointment();
                        ratifyAppointment.RatifyAppointments(ID);
                        // Actualizar la interfaz gráfica, por ejemplo, eliminar el RadioButton
                        groupBoxRatify.Controls.Remove(radioButton);
                        MessageBox.Show($"El turno ha sido acreditado exitosamente", "Acreditacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    break;

                }
            }


            this.Close();
        }
    }
}
