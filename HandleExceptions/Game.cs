using System;

namespace HandleExceptions
{
    public class Game
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Game started.");

                throw new Exception("Sky texture couldn't be loaded.");
            }
            catch (Exception ex)
            {

                throw new GameException("Game crashed.", ex);
            }


        }
    }
}