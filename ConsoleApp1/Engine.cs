using System;
using System.Collections.Generic;

namespace Interface
{
    public class Engine
    {
        private readonly List<IActivity> _activities;

        public Engine(List<IActivity> activities)
        {
            _activities = activities;
        }

        public void Run()
        {
            Console.WriteLine("Engine start.");

            foreach(var activity in _activities)
            {
                activity.Execute();
            }

            Console.WriteLine("Engine stopped.");
        }
    }
}
