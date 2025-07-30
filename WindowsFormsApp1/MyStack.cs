using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MyStack<T>
    {
        private T[] _items;
        private int _count;

        public MyStack()
        {
            _items = new T[4];
            _count = 0;
        }

        public int Count => _count;

        public bool IsEmpty => _count == 0;

        public void Push(T item)
        {
            if (_count == _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[_count++] = item;
        }

        public T Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty");

            T item = _items[--_count];
            _items[_count] = default;
            return item;
        }

        public T Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty");
            return _items[_count - 1];
        }

        public void Clear()
        {
            _count = 0;
            _items = new T[4];
        }
    }
}
