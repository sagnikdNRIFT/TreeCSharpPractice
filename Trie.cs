using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class Trie<T> where T : IComparable
    {
        TrieNode<T> head;
        public Trie()
        {

            this.head = new TrieNode<T>(){};
        }
        public void Add(string key, T value)
        {           
            this.addNode(key, value, this.head);        
        }

        private void addNode(string key, T value, TrieNode<T> node)
        {

        }
        public bool Contains(T data)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
