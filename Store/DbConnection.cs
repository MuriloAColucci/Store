using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    internal class DbConnection
    {

        //Conexão com o banco de dados através da string de conexão
        private static string getConnectionString()
        {
            string connectionString = "Host=localhost;Port=5432;Database=store;User Id=postgres;Password=admin;";

            return connectionString;
        }

        public static NpgsqlConnection connection = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        //Executa conexão com o banco de dados
        public static DataTable executeConnection(NpgsqlCommand command)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Connection Failed!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataTable = null;
            }

            return dataTable;
        }
    }
}
