using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Work
{

    public class Link_List<T>
    {
        private Node head;
        public class Node
        {
            public T data;
            public Node next;
            public Node(T data) 
            {
                this.data = data;
            }
        }
      
        public bool Add(T data)
        {
            Node node= new Node(data);
            
            if (head != null)
            {
                head = node;
                return true;

            }
            node.next = head;
            head = node;

            return true;

        }
       

    }
}
