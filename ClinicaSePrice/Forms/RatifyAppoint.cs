using ClinicaSePrice.Classes;
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
    public partial class RatifyAppoint : Form
    {
        public RatifyAppoint()
        {
            InitializeComponent();
        }

        private void btnSearchDniRatify_Click(object sender, EventArgs e)
        {
            string dni = txtDniRatify.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Patient? patient = Patient.SearchPatientByDni(dni);

            if (patient == null)
            {
                MessageBox.Show("El DNI ingresado no pertenece a un paciente registrado.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CancelAppointment cancelAppointment = new CancelAppointment();
                RatifyAppointConfirm ratifyAppointConfirm = new RatifyAppointConfirm(dni);
                ratifyAppointConfirm.Show();
                List<string> resultados = CancelAppointment.GetAppointments(dni);

                if (resultados.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene citas programadas.", "Sin citas encontradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Crea los Radio Buttons y los inserta en el Groupbox
                int radioButtonY = 20; // Offset dentro del Groupbox
                for (int i = 0; i < resultados.Count; i++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.AutoSize = false; // Desactiva tamaño automatico
                    radioButton.Width = 450;    //Tamaño personalizado para texto largo

                    //Usa el ID del String y se lo asigna como Tag al RB
                    string[] appointID = resultados[i].Split('-');
                    string idString = appointID[0].Trim();
                    int.TryParse(idString, out int id);
                    radioButton.Tag = id;

                    radioButton.Text = resultados[i]; // Agrega el resultado especifico de la lista
                    radioButton.Location = new Point(10, radioButtonY); // Posicion del RB
                    ratifyAppointConfirm.groupBoxRatify.Controls.Add(radioButton);
                    radioButtonY += 20; // Espaciado entre RB

                }
                //Selecciona automaticamente el primer RB de la lista
                ratifyAppointConfirm.groupBoxRatify.Controls[0].Select();

                ratifyAppointConfirm.Show();
                ratifyAppointConfirm.TopMost = true;
                this.Close();

            }

        }
    }
}
