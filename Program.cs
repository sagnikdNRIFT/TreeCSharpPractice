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
            BinaryTree<int> tree = new BinarySearchTree<int>();
            List<char> menuOptions = new List<char>() { '1', '2', '3', '4'};
            //Contains the console key that was pressed (char +state of ALT,SHIFT,CTRL)
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                Console.WriteLine("Enter an option");
                Console.WriteLine("1. Add Node");
                Console.WriteLine("2. Inorder traversal");
                Console.WriteLine("3. Search for data");
                Console.WriteLine("4. Exit");
                Console.WriteLine();//for \n?
                try
                {
                    keyInfo = Console.ReadKey();
                    Console.WriteLine();
                    int val;
                    char option = keyInfo.KeyChar;// or keyInfo.Key.ToString()
                    if (menuOptions.Contains(option))
                    {
                        switch(option)
                        {
                            case '1':Console.WriteLine();
                                    Console.WriteLine("Enter value of node");
                                    val = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    tree.Add(val);
                                    break;
                            case '2': Console.WriteLine();
                                      tree.Print();
                                    break;
                            case '3':Console.WriteLine();
                                    Console.WriteLine("Enter value of node");
                                    val = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (tree.Contains(val))
                                    {
                                        Console.WriteLine("Value exists in the tree");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Value does not exist in the tree");
                                    }
                                    break;
                            case '4': break;
                            default:throw new Exception();
                                break;
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        
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
