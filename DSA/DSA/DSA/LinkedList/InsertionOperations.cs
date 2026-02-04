using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    internal class InsertionOperations
    {
        public class ListNode
        {
            public int data;
            public ListNode next;
            public ListNode(int data)
            {
                this.data = data;
                this.next = null;
            }

        }
        public class Solution
        {
            /*Insert at Head of Linked List
            Problem Statement: Given the head of a singly linked list and an integer val, 
            insert a new node with this value at the beginning of the list. Return the new head.

            Example 1:
            Input: head = [1, 2, 3], val = 5
            Output: [5, 1, 2, 3] 
            */
            public ListNode InsertAtHead(ListNode head,int val)
            {
                ListNode newhead = new ListNode(val);
                newhead.next = head;
                return newhead;
            }

            /*Insert at Tail of Linked List
              Problem Statement: Given the head of a singly linked list and an integer val,
              insert a new node with this value at the end of the list. Return the head of the modified list.

              Example 1:
              Input: head = [1, 2, 3], val = 4
              Output: [1, 2, 3, 4]
            */
            public ListNode InsertAtTail(ListNode head,int val)
            {
                ListNode newtail = new ListNode(val);
                if(head==null)
                {
                    return newtail;
                }
                ListNode temp = head;
                while (temp != null)
                {
                    temp = temp.next;
                }
                
                temp.next = newtail;
                return head;
            }
            /* 
                 

             */
            public ListNode InsertAtKthPosition(ListNode head,int val,int k)
            {
                if(head == null && k==1)
                {
                    ListNode el = new ListNode(val);
                    el.next = head;
                    return el;
                }
                ListNode temp = head;
                int posi = 1;

                while(temp!=null && posi<k-1 )
                {
                    temp = temp.next;
                    posi++;
                }

                ListNode node = new ListNode(val);
                node.next = temp.next;
                temp.next = node;

                return head;

            }
            public ListNode InsertBeforeX(ListNode head,int value,int el)
            {

                if(head==null)
                {
                    return null;
                }
                if(head.data == value)
                {
                    ListNode node = new ListNode(el);
                    node.next = head;
                    return node;
                }
                
                ListNode temp = head;
                while (temp != null)
                {
                    if (temp.next.data == value)
                    {
                        ListNode node = new ListNode(el);
                        node.next = temp.next;
                        temp.next = node;
                        return head;
                    }

                    temp = temp.next;

                }
                return head;

            }
        }
    }
}
