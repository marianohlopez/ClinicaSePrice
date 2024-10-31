using ClinicaSePrice.Classes;
using ClinicaSePrice.Data;
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
        private int specialtyId;
        private string sectionId;
        private DateTime studyDate;
        public StudyConfirm(int specialtyId, string sectionId, DateTime studyDate)
        {
            InitializeComponent();

            this.specialtyId = specialtyId;
            this.sectionId = sectionId;
            this.studyDate = studyDate;

            this.AcceptButton = btnValidateDni;
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
                RegisterStudy(patient.Id, specialtyId, sectionId, studyDate);

                MessageBox.Show($"Estudio registrado para el paciente: {patient.Name} {patient.LastName}", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void RegisterStudy(int patientId, int specialtyId, string sectionId, DateTime date)
        {
            try
            {
                using (var connection = Connection.GetInstance().CreateConnection())
                {
                    connection.Open();

                    // Sentencia SQL para registrar el estudio
                    string query = "INSERT INTO Estudios (PacienteID, EspecialidadID, SeccionID, FechaEstudio) " +
                                   "VALUES (@PacienteID, @EspecialidadID, @SeccionID, @FechaEstudio)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        //Asignacion de valores
                        command.Parameters.AddWithValue("@PacienteID", patientId);
                        command.Parameters.AddWithValue("@EspecialidadID", specialtyId);
                        command.Parameters.AddWithValue("@SeccionID", sectionId);
                        command.Parameters.AddWithValue("@FechaEstudio", date);

                        // Ejecucion de consulta
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el estudio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
