﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{
    public abstract class BHeap<T>:IEnumerable<T>
        where T : IComparable<T>
    {
        public T[] Array { get; private set; }
        private int position;
        public int Count { get; set; }
        public BHeap()
        {
            Count = 0;
            Array = new T[128];
            position = 0;
        }
        public BHeap(int _size)
        {
            Count = 0;
            Array = new T[_size];
            position = 0;
        }
        public BHeap(IEnumerable<T> collection)
        {
            Count = 0;
            Array = new T[collection.ToArray().Length];
            position = 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        private int GetLeftChildIndex(int i) => 2 * i + 1;
        private int GetRightChildIndex(int i) => 2 * i + 2;
        private int GetParentIndex(int i) => i-1/2;
        private bool HasLeftChild(int i) => 
            GetLeftChildIndex(i) < position;
        private bool HasRightChild(int i) => 
            GetRightChildIndex(i) < position;
        private bool IsRoot(int i) => i == 0;
        private T GetLeftChild(int i) => Array[GetLeftChildIndex(i)];
        private T GetRightChild(int i) => Array[GetRightChildIndex(i)];
        private T GetParent(int i ) => Array[GetParentIndex(i)];    
        public bool IsEmpty()=> position == 0;
        public T Peek()
        {
            if(IsEmpty())
            {
                throw new Exception("Empty heap");
            }
            return Array[0];
        }
        public void Swap(int first,int second)
        {
            var temp=Array[first];
            Array[first]=Array[second];
            Array[second]=temp;
        }
        public void Add(T value)
        {
            if (position == Array.Length)
                throw new IndexOutOfRangeException("Overflow!");
            Array[position]=value;
            position++;
            Count++;
            HeapifyUp();
        }
        public T DeleteMinMax()
        {
            if (position == Array.Length)
                throw new IndexOutOfRangeException("Underflow!");
            var temp = Array[0];
            Array[0] = Array[position - 1];
            position--;
            Count--;
            HeapifyDown();
            return temp;

        }
        protected abstract void HeapifyUp();
        protected abstract void HeapifyDown();
        public IEnumerator<T> GetEnumerator()
        {
            return Array.Take(position).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class MinHeap<T> : BHeap<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        protected override void HeapifyDown()
        {
            throw new NotImplementedException();
        }

        protected override void HeapifyUp()
        {
            throw new NotImplementedException();
        }
    }
}
