using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            var db = new OracleConnection(null);

            db.OpenConnection();
            System.Threading.Thread.Sleep(5000);
            db.CloseConnection();
        }
    }
}
