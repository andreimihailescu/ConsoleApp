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
            Action<string> TestingAction = name => Console.WriteLine("{0} is testing stuff.", name);

            var eu = new Worker("Andrei", Coding);
            eu.StartWork();

            var john = new Worker("John", () => Console.WriteLine("Is cleaning."));
            john.StartWork();


            TestingAction("Mihai");
        }

        static void Coding()
        {
            Console.WriteLine("Is coding.");
        }
    }
}
