// See https://aka.ms/new-console-template for more information
using LinkedList_Work;

Console.WriteLine("Hello, World!");
Link_List<int>list= new Link_List<int>();
list.Add(56);
list.Add(30);
list.Add(70);
Console.WriteLine(list.ToString());
//output will 70 30 56

//but after calling Pop method it will remove first   value
list.Pop();
Console.WriteLine(list.ToString());
//output will be 70 30

