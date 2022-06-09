using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DoublyLinkedlList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;
            if(Tail == null)
            {
                Tail = Head;
            }
        } 
            
    }
}
