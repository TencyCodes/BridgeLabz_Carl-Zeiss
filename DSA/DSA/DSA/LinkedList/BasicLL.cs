using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    internal class BasicLL
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

            public static Node convertLL(int[] arr)
            {
                if(arr.Length == 0)
                {
                    return null;
                }
                Node head = new Node(arr[0]);
                Node mover = head;
                for(int i = 1;i< arr.Length;i++)
                {
                    Node temp = new Node(arr[i]);
                    mover.next = temp;
                    mover = temp;
                }
                return head;

            }
            
            public static void Main(string[] args)
            {
                
                int [] arr = { 1, 2, 3 };
                Node head = convertLL(arr);
            }
        }
        
    }
}
