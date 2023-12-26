using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec25_2PM
{
    public  class LinkedList
    {
        public Node Head;
        public LinkedList()
        {
            Head = null;
        }
        public void insert(int data)
        {
            Node nN = new Node(data);
            if (Head == null)
            {
                Head = nN;
            }
            else 
            { 
                Node current =Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = nN;
            }
        }
        public void display()
        {
            Node current=Head;
            while(current!=null) 
            {
                Console.Write(current.Data+" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.insert(1);
            l.insert(2);
            l.insert(3);
            l.insert(4);
            l.insert(5);
            l.display();
        }
    }
}
