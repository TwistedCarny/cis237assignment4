// Westin Curtis - CIS 237 - 3/20/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Queue<T> : IQueue<T>
    {
        protected class Node // Node class that holds any generic data
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node _head; // Holds the head pointer of the linked list
        protected Node _tail; // Holds the tail pointer of the linked list
        protected int _size;

        public bool IsEmpty
        {
            get { return _head == null; }
        }

        public int Size
        {
            get { return _size; }
        }

        // Add item to the queue
        public void Enqueue(T data)
        {
            Node oldTail = _tail;

            _tail = new Node();

            _tail.Data = data;

            _tail.Next = null;

            if (IsEmpty)
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }

            _size++;
        }

        // Remove item from the queue
        public T Dequeue()
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
