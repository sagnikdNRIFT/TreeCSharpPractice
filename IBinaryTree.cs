using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    interface BinaryTree<T> where T : IComparable
    {
        void Print();
        void Add(T data);
        bool Contains(T data);
    }
}
