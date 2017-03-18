using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Stack<T> : IStack<T>
    {
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node _head;
        protected Node _tail;
        protected int _size;

        public bool IsEmpty
        {
            get { return _head == null; }
        }

        public int Size
        {
            get { return _size; }
        }

        public void Push(T data)
        {
            Node oldHead = _head;

            _head = new Node();

            _head.Data = data;

            _head.Next = oldHead;

            _size++;

            if(_size == 1)
            {
                _tail = _head;
            }
        }

        public T Pop(T data)
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            T returnData = _head.Data;

            _head = _head.Next;

            _size--;

            if (IsEmpty)
            {
                _tail = null;
            }

            return returnData;
        }

        
    }
}
