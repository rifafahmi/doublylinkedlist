using System;

namespace doublylinkedlist
{
    class Node
    {
        public int rollnumber;
        public string name;
        public Node next;
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int rollno;
            string nm;
            Console.Write("\nEnter the roll number of the student :");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollnumber = rollno;
            newnode.name = nm;

            if (START == null || rollno <= START.rollnumber)
            {
                if ((START != null) && (rollno <= START.rollnumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                newnode.next = START;
                if (START! = null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;

            }
            Node previous, current;
            for ( current = previous = START; current != null &&
                rollno >= current.rollnumber; previous = current, current =
                current.next)
            {
                if (rollno == current.rollnumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
            newnode.next = current;
            newnode.prev = previous;
            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
                return;
            }
        }
    }
     
}
