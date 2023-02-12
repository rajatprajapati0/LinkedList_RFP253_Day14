// See https://aka.ms/new-console-template for more information
using LinkedList_Work;

Console.WriteLine("Hello, World!");
Link_List<int>list= new Link_List<int>();
list.Add(56);
list.Add(30);
list.Add(70);
Console.WriteLine(list.ToString());
//out put is -70 30 56
// if we add new value in list like 60 by list.Add(); so out put will be 60 70 30 56
list.Append(60);
Console.WriteLine(list.ToString());
//but if we add new value in list by list.Append(); so output will we 70 30 56 60