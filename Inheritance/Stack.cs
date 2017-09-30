using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Parameter should not be null.");
            }

            _list.Add(obj);
        }

        public object Pop()
        {
            var popElement = _list.Last();

            //Console.WriteLine(popElement);

            _list.Remove(_list.Last());

            return popElement;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
