// Westin Curtis - CIS 237 - 3/20/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    interface IQueue<T>
    {
        void Enqueue(T data);
        T Dequeue();

        bool IsEmpty { get; }

        int Size { get; }
    }
}
