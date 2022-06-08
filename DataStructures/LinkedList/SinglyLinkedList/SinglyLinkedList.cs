using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
   public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
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

    }
}
