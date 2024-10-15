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
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Especialty { get; set; }

        public Doctor(int id, string name, string lastName, string especialty)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Especialty = especialty;
        }

        // Encuentra el doctor teniendo en cuenta disponibilidad y especialidad
        public static Doctor? GetDoctor(string especialty, DateTime date, string schedule)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string startTime = schedule.Split('-')[0].Trim();

            string query = @"
                SELECT Medicos.ID, Medicos.Nombre, Medicos.Apellido, Especialidades.Especialidad 
                FROM Medicos
                JOIN Especialidades ON Medicos.ID_Especialidad = Especialidades.ID
                JOIN Horarios_Turnos ON Horarios_Turnos.ID_Medico = Medicos.ID
                WHERE Especialidades.Especialidad = @especialidad
                AND Horarios_Turnos.Dia_Semana = @diaSemana
                AND Horarios_Turnos.Hora_Inicio <= @horaInicio
                AND Horarios_Turnos.Hora_Fin > @horaInicio";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@especialidad", especialty);
                command.Parameters.AddWithValue("@diaSemana", MakeAppointment.GetDayInSpanish(date.DayOfWeek));
                command.Parameters.AddWithValue("@horaInicio", TimeSpan.Parse(startTime));

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string name = reader.GetString("Nombre");
                    string lastName = reader.GetString("Apellido");
                    string specialty = reader.GetString("Especialidad");

                    return new Doctor(id, name, lastName, specialty);
                }
                else
                {
                    return null; 
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error buscando el doctor: {ex.Message}");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static Doctor? GetSpontaneusDoctor(string especialty)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = @"
                SELECT Medicos.ID, Medicos.Nombre, Medicos.Apellido, Especialidades.Especialidad 
                FROM Medicos
                JOIN Especialidades ON Medicos.ID_Especialidad = Especialidades.ID
                WHERE Especialidades.Especialidad = @especialidad";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@especialidad", especialty);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string name = reader.GetString("Nombre");
                    string lastName = reader.GetString("Apellido");
                    string newEspecialty = reader.GetString("Especialidad");

                    // Retornar el objeto Doctor con los datos obtenidos
                    return new Doctor(id, name, lastName, newEspecialty);
                }
                else
                {
                    return null; // No se encontró un médico para la especialidad dada
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error buscando el doctor: {ex.Message}");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
