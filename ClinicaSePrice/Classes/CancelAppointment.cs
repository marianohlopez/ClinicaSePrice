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
    

    // Registra el turno en la base de datos

    public static void SelectAppointment(int idPaciente, int idMedico, DateTime selectedDate, string selectedSchedule)
    {
        MySqlConnection conn = Connection.GetInstance().CreateConnection();
        string query = @"INSERT INTO Turnos_Reservados (ID_Medico, Fecha_Turno, Hora_Turno, ID_Paciente) 
                     VALUES (@idMedico, @fechaTurno, @horaTurno, @idPaciente)";

        try
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@idMedico", idMedico);
            command.Parameters.AddWithValue("@fechaTurno", selectedDate.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@horaTurno", TimeSpan.Parse(selectedSchedule.Split('-')[0])); // Extraer la hora de inicio del rango
            command.Parameters.AddWithValue("@idPaciente", idPaciente);

            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error al registrar el turno: {ex.Message}");
            MessageBox.Show("Ocurrió un error al intentar registrar el turno. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }
    }
}
}