using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class BinaryTreeNode<T> where T : IComparable
    {
        /*The compiler auto-generates the equivalent :
         get { return Data; }
         set { Data = value; }
        */
        public T Data { get; set; }
        public BinaryTreeNode<T> Left{ get; set; }
        public BinaryTreeNode<T> Right { get; set; }
    }
}
