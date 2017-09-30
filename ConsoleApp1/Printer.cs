using System;

namespace Interface
{
    public class Printer : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Printing files.");
        }
    }
}
