using ClinicaSePrice.Data;
using ClinicaSePrice.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice.Classes
{
    internal class Supply
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Amount { get; set; }
        public bool ReStock { get; set; }

        #region Database methods

        /// <summary>
        /// Selects all the records existing in supplies table without filtering
        /// </summary>
        /// <returns>
        /// A list of Supplies instances
        /// </returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal static List<Supply> SelectAllForDisplay()
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            List<Supply> supply = new();
            
            try
            {
                string query = "SELECT ID, Name, Amount, ReStock FROM insumos;";

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    supply.Add(SupplyFromReader(reader));

                }

                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Cannot execute select all from supplies:\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }


            return supply;
        }

        

        /// <summary>
        /// Selects a single record from supplies table filtering by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// The instance of Supply if record was found, null otherwise
        /// </returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal static Supply? SelectFromID(int id)
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            Supply? supply = null;
                        try
            {
                string query = "SELECT * FROM insumos WHERE ID = @ID";

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", id);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    supply = Supply.SupplyFromReader(reader);
                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Cannot execute select from supplies:\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }


            return supply;
        }

        /// <summary>
        /// Updates a record in database that corresponds to the current instance of the Supply class
        /// </summary>
        /// <returns>
        /// True if update was successful, false otherwise
        /// </returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal bool Update()
        {
            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            int affected = 0;

            try
            {
                string query = "UPDATE insumos SET ReStock = @ReStock WHERE ID = @ID;";

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@ReStock", this.ReStock);
                command.Parameters.AddWithValue("@ID", this.ID);

                affected = command.ExecuteNonQuery();

                // Registro para confirmar actualización
                Debug.WriteLine($"Actualizado ReStock para ID: {this.ID} - ReStock: {this.ReStock}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Cannot update Stock:\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            return (affected > 0);
        }



        /// <summary>
        /// Creates an instance of Supply from a reader, reading a single record from said object
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// The instance of current class
        /// </returns>
        static Supply SupplyFromReader(MySqlDataReader reader)
        {
            Supply post = new Supply();

            post.ID = reader.GetInt32("ID");
            post.Name = reader.GetString("Name");
            post.Amount = reader.GetInt32("Amount");
            post.ReStock = reader.GetBoolean("ReStock");

            return post;
        }

        #endregion

        public static List<string> getNameSupply()
        {
            List<string> nameSupplyList = new List<string>();
            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            string query = $"SELECT Name FROM insumos";

            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                ManageSupplies manageSupplies = new ManageSupplies();            
                        
                        nameSupplyList = new List<string>();
                        while (reader.Read())
                        {
                            nameSupplyList.Add(reader["Name"].ToString() ?? "No disponible");

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

            return nameSupplyList;
        }

        public static void updateSupplies(ManageSupplies manageSupplies)
        {
            string supply = manageSupplies.cboSupply?.SelectedItem?.ToString() ?? "No hay elemento seleccionado";
            int amount = (int)manageSupplies.nudManageSupplies.Value;

            MySqlConnection conn = Connection.GetInstance().CreateConnection();
            string query = "SELECT Amount FROM insumos WHERE Name = @supply";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@supply", supply);

                int currentAmount = Convert.ToInt32(command.ExecuteScalar() ?? 0);

                // Verifica que el resultado de la operación no sea negativo
                int newAmount = currentAmount + amount;
                if (newAmount < 0)
                {
                    MessageBox.Show("No es posible retirar más insumos de los disponibles.");
                    return;
                }

                // Actualiza la cantidad en la base de datos
                query = "UPDATE insumos SET Amount = @newAmount WHERE Name = @supply";
                command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@newAmount", newAmount);
                command.Parameters.AddWithValue("@supply", supply);

                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Cantidad actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el insumo especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar insumos: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }






    }
}
