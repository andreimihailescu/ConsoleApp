using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{

    class Program
    {
        static void Main(string[] args)
        {
            var newCustomer = new Person()
            {
                FirstName = "Andrei",
                LastName = "Mihailescu",
                Age = 22
            };

            newCustomer.GetDetails();
            newCustomer.GetDetails("Basketball");
        }
    }


}
