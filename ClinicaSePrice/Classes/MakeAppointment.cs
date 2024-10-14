using ClinicaSePrice.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Classes
{
    internal class MakeAppointment
    {

        // Método para obtener los dias en que la especialidad opera desde la base de datos
        public static List<string> GetDataTimeFromDatabase(string selectedSpecialty)
        {
            List<string> availableDays = new List<string>();

            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = @"SELECT DISTINCT Dia_Semana 
                     FROM Horarios_Turnos 
                     JOIN Medicos ON Horarios_Turnos.ID_Medico = Medicos.ID
                     JOIN Especialidades ON Medicos.ID_Especialidad = Especialidades.ID
                     WHERE Especialidades.Especialidad = @especialidad";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@especialidad", selectedSpecialty);

                MySqlDataReader reader = command.ExecuteReader();

                availableDays = new List<string>();

                while (reader.Read())
                {
                    availableDays.Add(reader["Dia_Semana"].ToString() ?? "No disponible");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error executing GetDateTimeFromDatabase query: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return availableDays;
        }

        public static string GetDayInSpanish(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "Lunes";
                case DayOfWeek.Tuesday: return "Martes";
                case DayOfWeek.Wednesday: return "Miércoles";
                case DayOfWeek.Thursday: return "Jueves";
                case DayOfWeek.Friday: return "Viernes";
                case DayOfWeek.Saturday: return "Sábado";
                case DayOfWeek.Sunday: return "Domingo";
                default: return "";
            }
        }

        // Obtiene horarios segun dias y especialidad, luego retorna una lista de tuplas con las horas de inicio y fin
        public static List<(TimeSpan StartTime, TimeSpan EndTime)> GetSchedulesFromDatabase(string selectedSpecialty, string selectedDay)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = @"SELECT Hora_Inicio, Hora_Fin 
                         FROM Horarios_Turnos 
                         JOIN Medicos ON Horarios_Turnos.ID_Medico = Medicos.ID
                         JOIN Especialidades ON Medicos.ID_Especialidad = Especialidades.ID
                         WHERE Especialidades.Especialidad = @especialidad AND Dia_Semana = @dia";
            List<(TimeSpan, TimeSpan)> horarios = new List<(TimeSpan, TimeSpan)>();

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@especialidad", selectedSpecialty);
                command.Parameters.AddWithValue("@dia", selectedDay);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpan startTime = reader.GetTimeSpan("Hora_Inicio");
                    TimeSpan endTime = reader.GetTimeSpan("Hora_Fin");
                    horarios.Add((startTime, endTime));
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

            return horarios; 
        }

        // Filtrar los horarios que ya están reservados
        public static List<string> FilterReservedSchedules(List<string> availableSchedules, DateTime selectedDate, string selectedSpecialty)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            List<string> reservedSchedules = new List<string>();

            string query = @"SELECT Hora_Turno 
                         FROM Turnos_Reservados 
                         JOIN Medicos ON Turnos_Reservados.ID_Medico = Medicos.ID
                         JOIN Especialidades ON Medicos.ID_Especialidad = Especialidades.ID
                         WHERE Especialidades.Especialidad = @especialidad 
                         AND Fecha_Turno = @fecha";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@especialidad", selectedSpecialty);
                command.Parameters.AddWithValue("@fecha", selectedDate);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Convertir la hora del turno reservado al formato de 30 minutos
                    TimeSpan reservedTime = reader.GetTimeSpan("Hora_Turno");
                    string reservedSchedule = $"{reservedTime:hh\\:mm} - {reservedTime.Add(TimeSpan.FromMinutes(30)):hh\\:mm}";
                    reservedSchedules.Add(reservedSchedule);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving reserved schedules: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return availableSchedules.Where(schedule => !reservedSchedules.Contains(schedule)).ToList();
        }

        // Generar los horarios disponibles en intervalos de 30 minutos
        public static List<string> MakeSchedule(TimeSpan startTime, TimeSpan endTime)
        {
            List<string> schedules = new List<string>();
            while (startTime < endTime)
            {
                string schedule = $"{startTime:hh\\:mm} - {startTime.Add(TimeSpan.FromMinutes(30)):hh\\:mm}";
                schedules.Add(schedule);
                startTime = startTime.Add(TimeSpan.FromMinutes(30));
            }
            return schedules;
        }
    }

}
