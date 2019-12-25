using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Npgsql;

namespace crud_apis.tests
{
    public class PostgresDriver
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private ConnectionString _connectionString;
        public PostgresDriver(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateTable(string tableName, List<ColumnSchema> columns)
        {
            var conn = new NpgsqlConnection(_connectionString.ToString());
            conn.Open();
            string query = $"CREATE TABLE {tableName}( {string.Join(',', columns)})";
            var da = new NpgsqlDataAdapter(query, conn);
            da.Fill(ds);
            conn.Close();
        }

        internal void DropTable(string tableName)
        {
            var conn = new NpgsqlConnection(_connectionString.ToString());
            conn.Open();
            string query = $"DROP TABLE {tableName}";
            var da = new NpgsqlDataAdapter(query, conn);
            da.Fill(ds);
            conn.Close();
        }
    }

    public class ColumnSchema
    {
        public ColumnSchema(string name, string type, string constriants = null)
        {
            Name = name;
            Type = type;
            Constraints = constriants;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Constraints { get; set; }

        public override string ToString() => $"{Name} {Type} {Constraints}";
    }
    public class ConnectionString
    {
        public ConnectionString(string database)
        {
            Database = database;
        }
        public string Server { get; set; } = "localhost";
        public string Port { get; set; } = "5432";
        public string UserId { get; set; } = "admin";
        public string Password { get; set; } = "admin";
        public string Database { get; set; }

        public override string ToString()
        {
            return $"Server={Server};Port={Port};User Id={UserId};Password={Password};Database={Database};";
        }
    }
}