using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class BinarySearchTree<T> : Tree<T> where T: IComparable
    {
        BinaryTreeNode<T> head;

        public BinarySearchTree()
        {
            this.head = null;
        }

        public void AddNode(T data)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>() { Data = data, Left = null, Right = null };
            BinaryTreeNode<T> temp = this.head;
            if(temp == null)
            {
                this.head = newNode;
            }
            else
            {
                while (true)
                {
                    if (newNode.Data.CompareTo(temp.Data) < 0)
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                    else
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                }
            }

        }

        public void Print()
        {
            if(this.head != null)
            {
                printNode(this.head);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The tree is empty!");
            }
        }

        private void printNode(BinaryTreeNode<T> node)
        {
            if(node.Left != null){
                printNode(node.Left);
            }   
            Console.Write("{0} ", node.Data);
            if (node.Right != null){
                printNode(node.Right);
            }

        }

        public bool Contains(T data)
        {
            if (this.head == null)
            {
                return false;
            }
            BinaryTreeNode<T> temp = this.head;
            while(temp != null)
            {
                if(temp.Data.CompareTo(data) == 0)
                {
                    return true;
                }
                else if(temp.Data.CompareTo(data) < 0)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return false;
        }
    }
}
