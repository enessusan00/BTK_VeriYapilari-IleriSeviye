﻿using System;
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
        public void AddLast(T value)
        {
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = null;            ,
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
    }
}