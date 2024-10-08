using ClinicaSePrice.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Classes
{
    internal class User
    {
        private string? username;
        private string? firstName;
        private string? lastName;
        private string? pass;
        private string? phone;
        private string? email;
        private string? role;
        private DateTime birthDate;

        public static User? LogUserIn(string inputName, string inputPass)
        {

            DataTable table = ExecLoginStoredProc(inputName, inputPass);
            User? newUser;

            //  If there was a User match, extract data
            if (table.Rows.Count > 0)
            {
                //  If a user is found, overwrite newUser, otherwis, it'll be null
                User user = new User();

                user.Username = table.Rows[0]["Username"].ToString();
                user.FirstName = table.Rows[0]["FirstName"].ToString();
                user.LastName = table.Rows[0]["LastName"].ToString();
                user.Phone = table.Rows[0]["Phone"].ToString();
                user.Email = table.Rows[0]["Email"].ToString();
                user.BirthDate = Convert.ToDateTime(table.Rows[0]["Birthdate"].ToString());
                user.UserRole = table.Rows[0]["UserRole"].ToString();

                return newUser = user;
            }
            else
            {
                return null;
            }
        }

        private static DataTable ExecLoginStoredProc(string inputUsername, string inputPass)
        {

            MySqlDataReader result;
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn = Connection.GetInstance().CreateConnection();

                MySqlCommand command = new MySqlCommand("Login", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("InputUsername", MySqlDbType.VarChar).Value = inputUsername;
                command.Parameters.Add("InputPass", MySqlDbType.VarChar).Value = inputPass;

                conn.Open();
                result = command.ExecuteReader();

                dt.Load(result);

                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                Debug.WriteLine($"Error executing Login SP: {ex.Message}");
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public string? Username { get => username; set => username = value; }
        public string? FirstName { get => firstName; set => firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public string? Pass { get => pass; set => pass = value; }

        public string? Phone { get => phone; set => phone = value; }
        public string? Email { get => email; set => email = value; }
        public string? UserRole { get => role; set => role = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

    }
}
