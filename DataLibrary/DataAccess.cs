using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    /**
     * This class talks to MySQL
     */
    public class DataAccess : IDataAccess
    {

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            /**
             * This opens a connection to the MySQL database using the connection string passed in
             * 'using' makes sure that the connection always closes properly
             */
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public async Task<T> QuerySingle<T, U>(string sql, U parameters, string connectionString)
        {
            /**
             * This opens a connection to the MySQL database using the connection string passed in
             * 'using' makes sure that the connection always closes properly
             */
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var row = await connection.QuerySingleAsync<T>(sql, parameters);

                return row;
            }
        }

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            /**
             * This opens a connection to the MySQL database using the connection string passed in
             * 'using' makes sure that the connection always closes properly
             */
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
