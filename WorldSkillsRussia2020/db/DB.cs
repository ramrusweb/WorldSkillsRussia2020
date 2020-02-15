using System.Data;
using System.Data.SqlClient;

namespace WorldSkillsRussia2020.handlers
{
    class DB
    {
        // connection string
        static string connStr = @"Data Source=.\SQlEXPRESS; Initial Catalog=WSR2020; Integrated Security=True";
        // connection to the database
        SqlConnection sqlConnection = new SqlConnection(connStr);
        
        // connection opening method
        internal void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        // connection closure method
        internal void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        // connection return method
        internal SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
