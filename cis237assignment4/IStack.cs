using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    interface IStack<T>
    {
        void Push(T data);
        T Pop(T data);

        bool IsEmpty { get; }

        int Size { get; }
    }
}
