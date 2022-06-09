using DataStructures.LinkedList.DoublyLinkedlList;
using DataStructures.LinkedList.SinglyLinkedList;

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
var list = new DoublyLinkedList<int>();
list.AddFirst(10);
list.AddFirst(20);
list.AddFirst(30);
list.AddAfter(list.Head.Next, new DoublyLinkedListNode<int>(25));
list.AddBefore(list.Tail, new DoublyLinkedListNode<int>(9));
foreach (var item in list)
{
    Console.WriteLine(item);
}
#endregion
//LINQ
#region

//var dlinkedList= new SinglyLinkedList<int>(linkedList);
//dlinkedList.AddFirst(10);
//dlinkedList.AddFirst(15);
//dlinkedList.AddFirst(30);

//dlinkedList.ToList().ForEach(x => Console.WriteLine(x+ " "));
#endregion

Console.ReadKey();
