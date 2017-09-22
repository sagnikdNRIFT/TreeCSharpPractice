using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new BinarySearchTree<int>();
            List<char> menuOptions = new List<char>() { '1', '2', '3', '4'  };
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                Console.WriteLine("Enter an option");
                Console.WriteLine("1. Add Node");
                Console.WriteLine("2. Inorder traversal");
                Console.WriteLine("3. Search for data");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                try
                {
                    keyInfo = Console.ReadKey();
                    Console.WriteLine();
                    char option = keyInfo.KeyChar;
                    if (menuOptions.Contains(option))
                    {
                        if (option == '1')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter value of node");
                            int val = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            tree.AddNode(val);
                        }
                        else if (option == '2')
                        {
                            Console.WriteLine();
                            tree.Print();
                        }
                        else if (option == '3')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter value of node");
                            int val = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (tree.Contains(val))
                            {
                                Console.WriteLine("Value exsists in the tree");
                            }
                            else
                            {
                                Console.WriteLine("Value does not exist in the tree");
                            }
                        }
                        else if (option == '4')
                        {
                            break;
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid value");
                    Console.WriteLine();
                }

            }
        }
    }
}
