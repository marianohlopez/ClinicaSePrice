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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ClinicaSePrice.Forms
{
    public partial class DeliverConfirm : Form
    {
        private string dni;
        public DeliverConfirm(string dni)
        {
            InitializeComponent();
            this.dni = dni;

            this.TopMost = true;
            LoadStudies();
        }

        private void LoadStudies()
        {
            // Instancia de conexión
            MySqlConnection connection = ClinicaSePrice.Data.Connection.GetInstance().CreateConnection();

            // Consulta SQL para obtener los estudios pendientes de retiro del paciente
            string query = @"
                SELECT e.ID, e.EspecialidadID, e.SeccionID 
                FROM Estudios e 
                JOIN Pacientes p ON e.PacienteID = p.ID 
                WHERE p.DNI = @DNI AND e.EstadoEstudio = 1";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DNI", dni);
                MySqlDataReader reader = cmd.ExecuteReader();

                int radioButtonY = 20; // Desplazamiento inicial dentro del groupBoxStudy

                // Cargar los estudios
                while (reader.Read())
                {
                    string specialty = reader["EspecialidadId"].ToString();
                    string section = reader["SeccionId"].ToString();

                    System.Windows.Forms.RadioButton rb = new System.Windows.Forms.RadioButton
                    {
                        // Creación de radiobutton para cada estudio
                        Text = $"Especialidad: {specialty}, Sección: {section}",
                        Tag = reader["ID"], // ID del estudio en tabla
                        AutoSize = false,
                        Width = 450, // Tamaño personalizado para texto largo
                        Location = new Point(10, radioButtonY) // Posición del RadioButton
                    };

                    // Agregar RadioButton en la interfaz
                    groupBoxStudy.Controls.Add(rb);

                    // Incrementa la posición vertical para el siguiente RadioButton
                    radioButtonY += 30; // Ajusta el espaciado entre RadioButtons según sea necesario
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estudios: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelivConfirm_Click(object sender, EventArgs e)
        {
            // Verificar si el radioButton está seleccionado
            System.Windows.Forms.RadioButton selectedRadioButton = groupBoxStudy.Controls
                .OfType<System.Windows.Forms.RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selectedRadioButton != null)
            {
                // Se obtiene ID del estudio del Tag del radioButton seleccionado
                int estudioID = (int)selectedRadioButton.Tag as int? ?? -1;

                if (estudioID != -1)
                {
                    // Conexion a base de datos
                    MySqlConnection connection = ClinicaSePrice.Data.Connection.GetInstance().CreateConnection();

                    // Consulta para actualizar el estado del booleano (Entregado)
                    string updateQuery = "UPDATE Estudios SET EstadoEstudio = 0 WHERE ID = @EstudioID";

                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        cmd.Parameters.AddWithValue("@EstudioID", estudioID);

                        // Ejecucion de la consulta (actualizacion)
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Se verifica si se realizo la actualizacion
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Estudio seleccionado fue entregado al paciente. El estado del estudio pasa a 'Entregado'",
                                "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Se desactiva el radioButton entregado
                            selectedRadioButton.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el estado del estudio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar el estado del estudio: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un estudio para confirmar la entrega.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
