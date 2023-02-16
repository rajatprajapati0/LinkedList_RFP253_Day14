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
     
        public bool insertAfter(T value, T data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node node = new Node(value);
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    node.next = node.next;
                    temp.next = node;
                    return true;
                }
                temp = temp.next;
            }
            throw new NullReferenceException("Given data not present");
        }

        public bool Search(T data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                    return true;
                temp = temp.next;
            }
            return false;
        }
        public T Pop()
        {
            if (head == null)
            {
                throw new NullReferenceException("List is Empty");
            }
            Node temp = head;

              Node pop = head;
            while (temp.next != null)
            {
                pop = temp;
                temp = temp.next;
            }
            T obj = temp.data;
            if (head.next == null)
            {
                head = null;
            }
            pop.next = null;
            return obj;
        }
        

        public bool Insert(int ind, T data)
        {
            Node node = new Node(data);
            if (ind == 0)
            {
                node.next = head;
                head = node ;
                return true;
            }
            Node temp = head;
            Node pre = null;
            while (ind > 0 && temp != null) 
            {
                ind--;
                pre = temp;
                temp = temp.next;
            }
            if (ind == 0)
            {
                pre.next = node;
                node.next = temp;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }
        public bool Append(T data)
        {
          Node node=new Node(data);
            if (head==null)
            {
                head = node;
                return true;
            }
            Node temp=head;
            while(temp.next!=null)
            {
              temp=temp.next;

            }
            temp.next=node;
            return true;
        
        }
      
        public bool Add(T data)
        {
            Node node= new Node(data);
            
            if (head == null)
            {
                head = node;
                return true;

            }
            node.next = head;
            head = node;

            return true;

        }

        public override string ToString()
        {
            if (head == null)
            {
                return null;
            }
            Node temp = head;
            string s = "";
            while (temp != null)
            {
                s = s + temp.data + " ";
                temp = temp.next;
            }
            return s;
        }


    }
}
