// See https://aka.ms/new-console-template for more information
using LinkedList_Work;

Console.WriteLine("Hello, World!");
Link_List<int>list= new Link_List<int>();
list.Add(56);

list.Add(70);
Console.WriteLine(list.ToString());
//out put is -70  56
// if we add new value in list like 60 by list.Add(); so out put will be 30 70 56 30

// but if we use insert metod so it will insert aour data at desired index
// like in between  70 and 56
list.Insert(1, 30);
//out put will be 70 30 56
Console.WriteLine(list.ToString());


