using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace HandleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var game = new Game();

                game.Run();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("Game stopped.");
            }
        }
    }
}
