using ClinicaSePrice.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Classes
{
    internal class CancelAppointment
    {
    
     // Obtiene los turnos de la DB
        public static List<string> GetAppointments(string dni)
        {
            List<string> activeappointments = new List<string>();

            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = @"SELECT tr.ID, tr.Fecha_Turno, tr.Hora_Turno, m.Nombre, m.Apellido, e.Especialidad
                            FROM Turnos_Reservados tr
                            INNER JOIN Pacientes p ON tr.ID_Paciente = p.ID
                            INNER JOIN Medicos m ON tr.ID_Medico = m.ID
                            INNER JOIN Especialidades e ON m.ID_Especialidad = e.ID
                             WHERE p.DNI = @dni";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@dni", dni);
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string activeappointment = $"{reader["ID"]} - {reader["Fecha_Turno"]} - {reader["Hora_Turno"]} HS - {reader["Nombre"]} {reader["Apellido"]} - {reader["Especialidad"]}";
                    activeappointments.Add(activeappointment);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving schedules: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return activeappointments; 
        }

        public void DeleteAppointments(int id)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = @"DELETE FROM turnos_reservados
                            WHERE id = @id;";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving schedules: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
                        
        }

    }
}