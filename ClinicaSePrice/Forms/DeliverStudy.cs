using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicaSePrice.Forms
{
    public partial class DeliverStudy : Form
    {
        public DeliverStudy()
        {
            InitializeComponent();
        }

        private void DeliverStudy_Load(object sender, EventArgs e)
        {

        }

        private void btnDelivStudy_Click(object sender, EventArgs e)
        {
            // DNI ingresado
            string dni = textBox1.Text;

            // Validar que campo no esté vacío
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, ingrese el DNI del paciente.", "Campo vacío.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar DNI en base de datos
            if (CheckPatientExists(dni))
            {
                // Si el paciente existe y tiene estudios, abrir DeliverConfirm
                DeliverConfirm deliverConfirm = new DeliverConfirm(dni);
                deliverConfirm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontraron estudios para este DNI.", "Paciente no encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para verificar si el paciente existe y tiene estudios pendientes
        private bool CheckPatientExists(string dni)
        {
            bool exists = false;

            MySqlConnection connection = ClinicaSePrice.Data.Connection.GetInstance().CreateConnection();

            // Consulta SQL para verificar la existencia
            string queryGetPatientId = "SELECT ID FROM Pacientes WHERE DNI = @DNI";

            try
            {
                connection.Open();
                // Obtener Id del paciente
                MySqlCommand cmdGetPatientId = new MySqlCommand(queryGetPatientId, connection);
                cmdGetPatientId.Parameters.AddWithValue("@DNI", dni);

                // Ejecutor de consulta
                object result = cmdGetPatientId.ExecuteScalar();
                if (result == null)
                {
                    // Si no se encuentra al paciente
                    MessageBox.Show("Paciente no encontrado en la base de datos.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                int patientId = Convert.ToInt32(result);

                // Consulta SQL para verificar si el paciente tiene estudios
                string queryCheckStudies = "SELECT COUNT(*) FROM Estudios WHERE PacienteID = @PacienteID AND EstadoEstudio = 1";

                MySqlCommand cmdCheckStudies = new MySqlCommand(queryCheckStudies, connection);
                cmdCheckStudies.Parameters.AddWithValue("@PacienteID", patientId);

                // Ejecutor de verificacion de estudios
                int count = Convert.ToInt32(cmdCheckStudies.ExecuteScalar());
                exists = (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el paciente: {ex.Message}", "Error de conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return exists;

        }
    }
}
