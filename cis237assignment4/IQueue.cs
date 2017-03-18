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
        T Dequeue(T data);

        bool IsEmpty { get; }

        int Size { get; }
    }
}
