using System.Collections;
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
var arr = new DataStructures
    .Array
    .Array<int>();
arr.Add(10);
arr.Add(15);
arr.Add(30);
arr.Add(35);
arr.Remove();
Console.WriteLine($"{arr.Count}/{arr.Capacity}");
Console.ReadLine();
