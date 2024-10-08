using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace ClinicaSePrice.Data
{
    public class Connection
    {
        private string database;
        private string server;
        private string port;
        private string user;
        private string key;
        private static Connection? con = null;

        private Connection()

        {
            this.database = "CLinicaSePrice";
            this.server = "localhost";
            this.port = "3306";
            this.user = "root";
            this.key = "";
        }

        public MySqlConnection CreateConnection()
        {
            MySqlConnection? newString = new MySqlConnection();
            try
            {
                newString.ConnectionString = "datasource=" + this.server +
                ";port=" + this.port +
                ";username=" + this.user +
                ";password=" + this.key +
                ";Database=" + this.database;

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error connecting to MySql: {ex.Message}");
                throw;
            }
            return newString;
        }
        public static Connection GetInstance()
        {
            if (con == null)
            {
                con = new Connection();
            }
            return con;
        }
    }
}
