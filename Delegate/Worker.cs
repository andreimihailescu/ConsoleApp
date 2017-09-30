using System;

namespace Delegate
{
    public class Worker {

        public delegate void Task();

        private string _name;
        private Task _task;


        public Worker(string name, Task task)
        {
            _name = name;
            _task = task;
        }

        public void StartWork()
        {
            Console.WriteLine(_name + " started working.");

            _task();

            Console.WriteLine(_name + " finished working.");
        }
    }
}
