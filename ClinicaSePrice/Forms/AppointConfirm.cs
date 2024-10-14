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
    public partial class AppointConfirm : Form
    {
        public AppointConfirm(string specialty, DateTime date, string schedule)
        {
            InitializeComponent();

            lblEspecialty.Text = specialty;
            lblDateAppoint.Text = $"{date.ToString("dd/MM/yyyy")}";
            lblSchedule.Text = schedule;
        }

        private void btnSearchDni_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

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
                // Aquí puedes usar el objeto paciente para acceder a sus propiedades, por ejemplo:
                //RegistrarTurno(paciente.Id);
                MessageBox.Show($"Turno registrado para el paciente: {patient.Name} {patient.LastName}", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
