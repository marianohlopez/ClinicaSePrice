using ClinicaSePrice.Classes;
using MySql.Data.MySqlClient;
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
    public partial class StudyConfirm : Form
    {
        public StudyConfirm()
        {
            InitializeComponent();
        }

        private void btnValidateDni_Click(object sender, EventArgs e)
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
                // Registrar estudio
                //MakeAppointment.RegisterAppointment

                // MessageBox.Show($"Turno registrado para el paciente: {patient.Name} {patient.LastName}", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // this.Close();
            }
        }
    }
}
