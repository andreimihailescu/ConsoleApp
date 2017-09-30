using System;

namespace Generic
{
    public class Notepad<T>
    {
        private T _note;

        public Notepad(T note)
        {
            _note = note;
        }

        public void GetNote()
        {
            Console.WriteLine("You note is: {0} and it's type is {1}", _note, typeof(T).Name);
        }
    }
}
