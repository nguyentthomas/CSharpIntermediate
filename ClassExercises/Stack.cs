using System;
using System.Collections.Generic;

namespace ClassExercises
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Can't place null object");
            }
            else
            {
                _list.Add(obj);
                Console.WriteLine(obj);
            }
        }


        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("No elements in the stack at the moment.");

            var index = _list.Count - 1;
            var listPopItem = _list[index];

            _list.RemoveAt(index);

            return (listPopItem);
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
