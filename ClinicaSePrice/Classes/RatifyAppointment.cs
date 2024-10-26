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
    internal class RatifyAppointment
    {
        public void RatifyAppointments(int id)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = @"UPDATE turnos_reservados
                            SET acreditado = 1
                            WHERE ID = @id;";

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
