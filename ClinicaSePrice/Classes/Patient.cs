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
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Phone { get; set; }

        public Patient(int id, string name, string lastName, string dni, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Dni = dni;
            this.Phone = phone;
        }

        // Método para buscar un paciente por su DNI y devolver un objeto Paciente
        public static Patient? SearchPatientByDni(string dni)
        {
            Patient? patient = null;
            MySqlConnection conn = Connection.GetInstance().CreateConnection();

            string query = "SELECT * FROM Pacientes WHERE DNI = @dni";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@dni", dni);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string name = reader.GetString("Nombre");
                    string lastName = reader.GetString("Apellido");
                    string phone = reader.GetString("Telefono");

                    patient = new Patient(id, name, lastName, dni, phone);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al buscar el paciente por DNI: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return patient;
        }   
    }
}
