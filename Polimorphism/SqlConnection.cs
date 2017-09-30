using System;

namespace Polimorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL connection closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL connection opened");
        }
    }
}
