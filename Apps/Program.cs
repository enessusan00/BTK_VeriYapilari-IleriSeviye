using DataStructures.LinkedList.SinglyLinkedList;
using System.Collections;
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
var p1 = new int[] { 1, 2, 3, 4 };
var p2 = new List<int> { 1, 2, 3, 4 };
var p3 = new DataStructures.Array.Array<int>(1, 2, 3, 4, 5, 6,7);
var arr = new DataStructures
    .Array
    .Array<int>();
arr.Add(10);
arr.Add(15);
arr.Add(30);
arr.Add(35);
arr.Add(35);
arr.Remove();
Console.WriteLine($"{arr.Count}/{arr.Capacity}");
foreach (var item in arr)
{
    Console.WriteLine(item);
}
/////////////
var realArr = new DataStructures.Array.Array<int>(1, 2, 3, 4, 5, 6);
var copyArr = realArr.Clone() as DataStructures.Array.Array<int>;
foreach (var item in copyArr)
{
    Console.WriteLine(item);
}
#endregion
//LinkedList
#region
var linkedList = new SinglyLinkedList<int>();
linkedList.AddFirst(10);
linkedList.AddFirst(15);    
linkedList.AddFirst(30);
linkedList.AddFirst(5);
linkedList.AddLast(20);

#endregion
Console.ReadLine();
