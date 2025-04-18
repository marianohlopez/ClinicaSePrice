﻿using ClinicaSePrice.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Forms
{
    public partial class CancelAppointConfirm : Form
    {
        public string dni { get; set; } = ""; // Asignando un valor por defecto

        public CancelAppointConfirm(string dni)
        {
            InitializeComponent();
            this.AcceptButton = btnCancelAppoint;

            this.dni = dni;
        }

        private void btnAppointCancel_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBoxCancel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    int ID = (int)radioButton.Tag;

                    // Mostrar un mensaje de confirmación
                    if (MessageBox.Show("¿Estás seguro de que deseas cancelar este turno?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CancelAppointment cancelAppointment = new CancelAppointment();
                        cancelAppointment.DeleteAppointments(ID);
                        // Actualizar la interfaz gráfica, por ejemplo, eliminar el RadioButton
                        groupBoxCancel.Controls.Remove(radioButton);
                        MessageBox.Show($"El turno ha sido cancelado exitosamente", "Cancelacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    break;
                    
                }
            }
            

            this.Close();
        }
    }
        
    }

