using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    interface Tree<T> where T : IComparable
    {
        void Print();
        void AddNode(T data);
        bool Contains(T data);
    }
}
