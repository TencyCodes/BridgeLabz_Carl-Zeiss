using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    internal class LengthCalc
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }
            

            public static int LengthLL(Node head)
            {
                int count = 0;
                Node temp = head;
                while(temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
            }
            public static bool Search(Node head,int value)
            {
                Node temp = head;
                while (temp != null)
                {
                    if(temp.data == value)
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }
        }
    }
}
