using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
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
            return new BSTEnumerator<T>(Root);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
        public  Node<T> FindMin(Node<T> root)
        {
            var curr = root;
            while(curr.Left != null)
                curr=curr.Left;
            return curr;

        }
        public Node<T> FindMax(Node<T> root)
        {
            var curr = root;
            while (curr.Right != null)
                curr = curr.Right;
            return curr;
        }
        public Node<T> Find(Node<T> root,T key)
        {
            var current = root;
            while (key.CompareTo(current.Value) != 0)
            {
                if (key.CompareTo(current.Value) < 0)
                    current = current.Left;
                else
                    current = current.Right;
                if (current == null)
                    // throw new Exception("Could not found!");
                    return default(Node<T>);
            }
            return current; 
        }
        public Node<T> Remove(Node<T> root, T key)
        {
            if (root == null)
                return root; // throw new ArgumentNullException();

            // rekürsif ilerle 
            if (key.CompareTo(root.Value) < 0)
            {
                root.Left = Remove(root.Left, key);
            }
            else if (key.CompareTo(root.Value) > 0)
            {
                root.Right = Remove(root.Right, key);
            }
            else
            {
                // silme işlevini uygulayabiliriz. 
                // tek cocuk ya da cocuksuz
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                // iki cocuk 
                root.Value = FindMin(root.Right).Value;
                root.Right = Remove(root.Right, root.Value);
            }
            return root;
        }

    }
}
