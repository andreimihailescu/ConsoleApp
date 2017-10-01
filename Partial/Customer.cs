using System;

namespace Partial
{
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("Hi! My name is {0} {1} and i am {2} years old.", FirstName, LastName, Age);
        }
    }

    public partial class Person
    {
        public bool Subscribed { get; set; }

        public void GetDetails(string hobby)
        {
            Console.WriteLine("Hi! My name is {0} {1} and i am {2} years old and my hobby is {3}", FirstName, LastName, Age, hobby);
        }
    }
}
