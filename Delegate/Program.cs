using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var eu = new Worker("Andrei", Coding);
            eu.StartWork();

            var john = new Worker("John", () => Console.WriteLine("Is a shitfag"));
            john.StartWork();
        }

        static void Coding()
        {
            Console.WriteLine("Is coding.");
        }
    }
}
