using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var activitiesList = new List<IActivity>
            {
                new Scanner(),
                new Printer()
            };

            var myengine = new Engine(activitiesList);

            myengine.Run();
        }
    }
}
