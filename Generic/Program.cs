using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFirstNote = new Notepad<string>("C# is fun.");

            myFirstNote.GetNote();

            var mySecondNote = new Notepad<int>(5);

            mySecondNote.GetNote();
        }
    }
}
