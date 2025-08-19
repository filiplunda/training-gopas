using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._03._01_GenericTypes
{
    public class Stack<T>
    {
        //object[] _items;
        T[] _items;

        readonly int _size;

        int _currentIndex = 0;

        public Stack(int size)
        {
            _size = size;
            //_items = new object[_size];
            _items = new T[_size];

        }

        public Stack() : this(100) { }

        //public void Push(object item)
        public void Push(T item)
        {
            if (_currentIndex >= _size) throw new StackOverflowException();
            _items[_currentIndex] = item;
            _currentIndex++;
        }

        //public object Pop()
        public T Pop()
        {
            _currentIndex--;
            if(_currentIndex < 0)
            {
                _currentIndex = 0;
                throw new InvalidOperationException("Cannot pop an empty stack");

            }

            return _items[_currentIndex];
        }
    }
}
