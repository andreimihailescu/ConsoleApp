using System;

namespace Polimorphism
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        private TimeSpan _timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null)
            {
                throw new System.ArgumentNullException("Connection string not valid");
            }

            _connectionString = connectionString;
            _timeout = TimeSpan.FromSeconds(30);
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
