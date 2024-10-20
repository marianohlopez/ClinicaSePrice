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
    public partial class CancelAppoint : Form
    {
        public CancelAppoint()
        {
            InitializeComponent();
        }

        private void btnSearchDniCancel_Click(object sender, EventArgs e)
        {
            string dni = txtDniCancel.Text.Trim();

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

                CancelAppointConfirm cancelAppointConfirm = new CancelAppointConfirm(dni);                
                cancelAppointConfirm.Show();
                // Registrar turno
                // MakeAppointment.RegisterAppointment(patient.Id, newDoctor.Id, selectedDate, selectedSchedule);

                //MessageBox.Show($"Turno registrado para el paciente: {patient.Name} {patient.LastName}", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.Close();
            }
        }
    }

    
}   

