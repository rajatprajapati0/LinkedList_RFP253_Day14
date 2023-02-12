// See https://aka.ms/new-console-template for more information
using LinkedList_Work;

Console.WriteLine("Hello, World!");
Link_List<int>list= new Link_List<int>();
list.Add(56);
list.Add(30);
list.Add(70);
Console.WriteLine(list.ToString());

//it helps to find the input value presnt in list or not
Console.WriteLine(list.Search(30));
//out puttrue
Console.WriteLine(list.Search(60));
//output false




