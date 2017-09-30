using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push("Andrei");
            stack.Push(2);
            stack.Push(5.5f);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
