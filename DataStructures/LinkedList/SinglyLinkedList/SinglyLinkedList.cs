using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
   public class SinglyLinkedList<T>:IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull=> Head == null;
        public void AddFirst(T value )
        {
            var newNode = new SinglyLinkedListNode<T>( value );
            newNode.Next = Head;
            Head = newNode;
        }
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if(Head==null)
                Head = newNode;
            var curr = Head;
            while(curr.Next!=null)
                curr = curr.Next;
            curr.Next = newNode;
        }
        public void AddAfter(SinglyLinkedListNode<T> node,
            T value)
        {
            if(node == null)
            {
                throw new ArgumentNullException();
            }
            if(isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var curr = Head;    
            while(curr != null)
            {
                if(curr.Equals(node))
                {
                    newNode.Next=curr.Next;
                    curr.Next=newNode;
                    return;
                }
                curr=curr.Next;
            }
            throw new ArgumentException("node is not found");
        }
        public void AddBefore(SinglyLinkedListNode<T> node,
            T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var curr = Head;
            var prev = curr;

            while (curr != null)
            {
                if (curr.Equals(node))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }
            throw new ArgumentException("There is no such a node in the linked list.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
