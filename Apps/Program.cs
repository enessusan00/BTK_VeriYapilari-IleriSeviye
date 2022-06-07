using System.Collections;

//Array
var arrChar = new char[3] {'a','v','d'};
Console.WriteLine(arrChar.Length);

//ArrayList
var arrObj = new ArrayList();
arrObj.Add(10);
arrObj.Add("b");
Console.WriteLine(arrObj.Count);

//List<T>
var arrInt = new List<int>();
arrInt.Add(10);
arrInt.Add(15);
arrInt.RemoveAt(0);
Console.WriteLine(arrInt.Count);
foreach (var item in arrInt)
{
    Console.WriteLine(item);
}
Console.ReadKey();