using System;
using System.Collections.Generic;

namespace LinkedList_Work
{
  public class Program
  {
    public static void Main(string[] args) 
    {
        Console.WriteLine("Data Structure\r\nProblems using\r\nC# Generics");
       
        
        Link_List<int>list = new Link_List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine("done");
         
           
    }
        

  }
}