using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DoublyLinkedlList
{
    public class DoublyLinkedList<T>:IEnumerable
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        private bool isHeadNull => Head == null;

        public DoublyLinkedList()
        {

        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                AddFirst(item);
            

        }
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
        public void AddLast(T value)
        {
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;            
            newNode.Prev = Tail; 
            Tail = newNode;
        }  
        public void AddAfter(DoublyLinkedListNode<T> refNode,DoublyLinkedListNode<T> newNode)
        {
            if(refNode == null)
                throw new ArgumentNullException();
            if (refNode == Head && refNode==Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev = refNode;
                newNode.Next = null;
                Head = refNode;
                Tail = newNode;
                return;
            }
            if(refNode!=Tail)
            {
                newNode.Prev = refNode;
                newNode.Next = refNode.Next;
                refNode.Next.Prev = newNode;
                refNode.Next= newNode;
            }
            else
            {
                newNode.Next = refNode;
                newNode.Prev = null;
                refNode.Next = newNode;
                Tail = newNode; 
            }
        }
        public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
        {
            if (refNode == null)
                throw new ArgumentNullException();
            if (refNode == Head && refNode == Tail)
            {
                refNode.Prev = newNode;
                refNode.Next = null;

                newNode.Prev = null;
                newNode.Next = refNode;
                Head = newNode;
                Tail = refNode;
                return;
            }
            if (refNode != Tail)
            {
                newNode.Next = refNode;
                newNode.Prev = refNode.Prev;
                refNode.Prev.Next = newNode;
                refNode.Prev = newNode;
            }
            else
            {
                newNode.Next = refNode;
                refNode.Prev.Next= newNode;
                refNode.Next = null;
                Tail = refNode;
            }
        }
        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
             var list = new List<DoublyLinkedListNode<T>>();
            var current=Head;
            while (current!=null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator(); 
        }
        public T RemoveFirst()
        {
            var temp = Head.Value;
            if (isHeadNull)
                throw new ArgumentNullException();
            if (Head == Tail)
            {
                Head = null;
                Tail=null;  
            }
            else
            {
                Head.Next=Head;
                Head.Prev = null;
            }
            return temp;
            
        }
        public T RemoveLast()
        {
            var temp = Tail.Value;
            if (isHeadNull)
                throw new ArgumentNullException();
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            return temp;

        }
        public void Remove(T value)
        {
            if (isHeadNull)
                throw new ArgumentNullException();
            if (Head == Tail)
            {
                if(Head.Value.Equals(value))
                    RemoveFirst();
                return;
            }
            var current = Head;
            while (current!=null)
            {
                if(current.Value.Equals(value))
                {
                    if(current.Prev == null)
                    {
                        current.Next.Prev = null;
                        Head = current.Next;
                    }
                    else if(current.Next == null)
                    {
                        current.Prev.Next = null;
                        Tail=current.Prev;
                    }
                    else
                    {
                        current.Prev.Next=current.Next;
                        current.Next.Prev = current.Prev;   
                    }
                    break;
                }
                current = current.Next;
            }
            {

            }
        }

    }
}
