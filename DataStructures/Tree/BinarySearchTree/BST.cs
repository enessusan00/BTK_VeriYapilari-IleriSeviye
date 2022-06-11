using DataStructures.Tree.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinarySearchTree
{
     public class BST<T> : IEnumerable<T>
        where T :IComparable
    {
        public Node<T> Root { get; set; }
        public BST()
        {
                
        }
        public BST(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Add(T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException();
            }
                
            var newNode= new Node<T>(value);
            if(Root == null)
            {
                Root = newNode;
            }
                
            else
            {
                var curr = Root;
                Node<T> parent;
                while(true)
                {
                    parent = curr;
                    if(value.CompareTo(curr.Value) < 0)
                    {
                        curr = curr.Left;
                        if (curr == null)
                        {
                            parent.Left = newNode;
                            break;
                        } 
                            
                    }
                    else
                    {
                        curr = curr.Right;
                        
                        if (curr == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }                        
            }
        }
    }
}
