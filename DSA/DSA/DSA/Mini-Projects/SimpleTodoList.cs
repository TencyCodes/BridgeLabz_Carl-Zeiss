    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DSA.Mini_Projects
    {
        internal class SimpleTodoList
        {
            public class Node
            {
                public string Task;
                public Node next;

                public Node(string task)
                {
                    Task = task;
                    next = null;

                }

            }
            Node head = null;
            public void AddTask(string task)
            {
                Node newNode = new Node(task);
                if(head == null)
                {
                    head = newNode;
                    return;
                }
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                    
            }
        public void DisplayTasks()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Task);
                temp = temp.next;
            }

        }
        public void DeleteTask(int position)
        {
            Node temp = head;
        }



        }
    }
