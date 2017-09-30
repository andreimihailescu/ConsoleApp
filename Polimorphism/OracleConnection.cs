using System;

namespace Polimorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle close connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle open connection");
        }
    }
}
