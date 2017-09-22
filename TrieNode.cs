using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class TrieNode<T> where T:IComparable
    {
        char Key { get; set; }
        T Data { get; set; }
        bool IsTerminal { get; set; }
        List< TrieNode<T> > children { get; set; }
    }
}
