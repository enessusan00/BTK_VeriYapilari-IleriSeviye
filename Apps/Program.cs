using Apps;
using DataStructures.LinkedList.DoublyLinkedlList;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Stack;
using DataStructures.Tree.BinarySearchTree;
using DataStructures.Tree.BinaryTree;
//Array
#region
////Array
//var arrChar = new char[3] {'a','v','d'};
//Console.WriteLine(arrChar.Length);

////ArrayList
//var arrObj = new ArrayList();
//arrObj.Add(10);
//arrObj.Add("b");
//Console.WriteLine(arrObj.Count);

////List<T>
//var arrInt = new List<int>();
//arrInt.Add(10);
//arrInt.Add(15);
//arrInt.RemoveAt(0);
//Console.WriteLine(arrInt.Count);
//foreach (var item in arrInt)
//{
//    Console.WriteLine(item);
//}
//Console.ReadKey();
#endregion
//GenericArray
#region
//var p1 = new int[] { 1, 2, 3, 4 };
//var p2 = new List<int> { 1, 2, 3, 4 };
//var p3 = new DataStructures.Array.Array<int>(1, 2, 3, 4, 5, 6,7);
//var arr = new DataStructures
//    .Array
//    .Array<int>();
//arr.Add(10);
//arr.Add(15);
//arr.Add(30);
//arr.Add(35);
//arr.Add(35);
//arr.Remove();
//Console.WriteLine($"{arr.Count}/{arr.Capacity}");
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}
//var array = new DataStructures.Array.Array<int>(new int[] {1,2,3,4,5,6,7}).Reverse();
//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}
/////////////
//var realArr = new DataStructures.Array.Array<int>(1, 2, 3, 4, 5, 6);
//var copyArr = realArr.Clone() as DataStructures.Array.Array<int>;
//foreach (var item in copyArr)
//{
//    Console.WriteLine(item);
//}
#endregion
//LinkedList
#region
/// <summary>
/// Singly
/// </summary>
//var linkedList = new SinglyLinkedList<int>();
//linkedList.AddFirst(10);
//linkedList.AddFirst(15);
//linkedList.AddFirst(30);
//linkedList.AddFirst(5);
//linkedList.AddFirst(5);
//linkedList.AddFirst(5);
//linkedList.AddFirst(5);
//linkedList.AddLast(331);
//linkedList.AddLast(331);
//linkedList.AddAfter(linkedList.Head.Next, 50);
//linkedList.AddBefore(linkedList.Head.Next, 30);
//linkedList.RemoveFirst();
//linkedList.RemoveFirst();
//linkedList.RemoveFirst();
//linkedList.RemoveFirst();
//linkedList.RemoveFirst();
//linkedList.RemoveLast();
//linkedList.Remove(331);
//foreach (var item in linkedList)
//{
//    Console.WriteLine(item);
//}
//var clinkedList = new SinglyLinkedList<int>(linkedList);
///Doubly
//var list = new DoublyLinkedList<int>();
//list.AddFirst(10);
//list.AddFirst(20);
//list.AddFirst(30);
//list.AddAfter(list.Head.Next, new DoublyLinkedListNode<int>(25));
//list.AddBefore(list.Tail, new DoublyLinkedListNode<int>(9));
//list.RemoveFirst();
//list.RemoveLast();
//list.Remove(25);
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
//var aList = new DoublyLinkedList<char>( new List<char>() { 'a','b','c'});
//foreach (var item in aList)
//{
//    Console.WriteLine(item);
//}
#endregion
//LINQ
#region

//var dlinkedList= new SinglyLinkedList<int>(linkedList);
//dlinkedList.AddFirst(10);
//dlinkedList.AddFirst(15);
//dlinkedList.AddFirst(30);

//dlinkedList.ToList().ForEach(x => Console.WriteLine(x+ " "));
#endregion
//Stack
#region
//var charset = new char[] { 'a', 'b', 'c', 'd' };
//var stack1 = new DataStructures.Stack.Stack<char>();
//var stack2 = new DataStructures.Stack.Stack<char>(StackType.LinkedList);
//foreach (var item in charset)
//{
//    Console.WriteLine(item);
//    stack1.Push(item);
//    stack2.Push(item);
//}
//Console.WriteLine(stack1.Peek());
//Console.WriteLine(stack2.Peek());
#endregion
//PostFixExample,
#region
//Console.WriteLine(PostFixExample.Run("231*+9-"));
#endregion
//Queue
#region
//var numbers = new int[] { 10, 20, 30 };
//var q1 = new DataStructures.Queue.Queue<int>();
//var q2 = new DataStructures.Queue.Queue<int>(DataStructures.Queue.QueueType.LinkedList);

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//    q1.EnQueue(number);
//    q2.EnQueue(number);
//}

//Console.WriteLine($"q1 Count : {q1.Count}");
//Console.WriteLine($"q2 Count : {q2.Count}");

//Console.WriteLine($"{q1.DeQueue()} has been removed from q1.");
//Console.WriteLine($"{q2.DeQueue()} has been removed from q2.");

//Console.WriteLine($"q1 Count : {q1.Count}");
//Console.WriteLine($"q2 Count : {q2.Count}");

//Console.WriteLine($"q1 Peek : {q1.Peek()}");
//Console.WriteLine($"q2 Peek : {q2.Peek()}");
#endregion
//BST
#region
//var BST = new BST<int>(new List<int>() { 60, 40, 70, 20, 45, 65, 85 });
//var bt = new DataStructures.Tree.BinaryTree.BinaryTree<int>();

//bt.InOrder(BST.Root)
//    .ForEach(node => Console.Write($"{node,-3} "));

//BST.Remove(BST.Root, 20);
//BST.Remove(BST.Root, 40);
//BST.Remove(BST.Root, 60);

//Console.WriteLine();
//bt.ClearList();

//bt.InOrder(BST.Root)
//   .ForEach(node => Console.Write($"{node,-3} "));

//var bst = new BST<byte>(new byte[] { 60, 40, 70, 20, 45, 65, 85, 90 });

//var list = new DataStructures
//    .Tree
//    .BinaryTree
//    .BinaryTree<byte>().InOrder(bst.Root);

//foreach (var node in list)
//{
//    Console.Write($"{node,-3} ");
//}
//Console.WriteLine();
//Console.WriteLine($"Min     : {bst.FindMin(bst.Root)}");
//Console.WriteLine($"Max     : {bst.FindMax(bst.Root)}");
//Console.WriteLine($"Depth   : {DataStructures.Tree.BinaryTree.BinaryTree<byte>.MaxDepth(bst.Root)}");
//Console.WriteLine();

//Console.WriteLine($"Minimum value : {BST.FindMin(BST.Root)}");
//Console.WriteLine($"Maximum value : {BST.FindMax(BST.Root)}");

//var keyNode = BST.Find(BST.Root, 100);

//if (keyNode != null)
//    Console.WriteLine($"{keyNode.Value} - " +
//    $"Left: {keyNode.Left.Value} - " +
//    $"Right : {keyNode.Right.Value}");
#endregion
//PriorityQueue
#region
var heap = new DataStructures
               .Heap
               .MinHeap<int>(new int[] { 4, 1, 10, 8, 7, 5, 9, 3, 2 });

Console.WriteLine(heap.DeleteMinMax() + " has been removed.");

foreach (var item in heap)
{
    Console.WriteLine(item);
}
#endregion


Console.ReadKey();
