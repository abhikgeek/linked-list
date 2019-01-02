using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            
        }

        private Node head = null;
        
        //Insert into new list
        public Node InsertIntoLinkedListEnd(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;
            if (head == null)
            {  
                //returning a new node
                head = newNode;
            }
            else
            {
                Node traveller = head;
                while (traveller.next != null)// Reach till the pointer which is pointing the last node
                {
                    traveller = traveller.next;
                }
                traveller.next = newNode;
            }
            return head;
        }

        //Insert into begining 

        public Node InsertInTheBegining(int data,Node head)
        {
            Node newNode = new Node();
            newNode.data = data;
            if(head==null)
            {
                newNode.next = null;
                this.head = newNode;
            }
            else
            {
                newNode.next = head;
                this.head = newNode;
            }
            return head;
        }
        // Insert in nth position
        public void InsertInNthPosition(int data,Node head,int position)
        {
            Node traveller = head;
            Node newNode = new Node();
            newNode.data = data;
            if(position==0)// Insert at the beinging
            {
                newNode.next = head;
                this.head = newNode;
                return;
            }
            int k = position - 1;
            while (k > 0 && traveller.next != null)
            {
                traveller = traveller.next;
                k--;
            }
            //for(int i = 0; i < position-1; i++)
            //{
            //    traveller = traveller.next;
            //}
            newNode.next = traveller.next;
            traveller.next = newNode;
            return;
        }


        // Deleting a node from nth Position 
        public Node DeleteNthNode(Node head, int position)
        {
            Node traveller = head;
            if(position == 0)
            {
                this.head = traveller.next;
                
            }
            else
            {
                int k = position - 1;
                while (k > 0 && traveller.next != null)
                {
                    traveller = traveller.next;
                    k--;
                }
                traveller.next = traveller.next.next;

            }
            
            return null;
        }

        // Reverse a linkedList
        public Node Reverse(Node head)
        {
            Node current, prev=null, next;
            current = head;
            while(current != null)
            {
                next = current.next; // keeping next node data
                
                current.next = prev;
                prev = current; // keeping previous data

                current = next;
                
            }
            return this.head = prev;
        }
        //Reverse list recursively
        public Node ReverseRecursively(Node head)
        {
            if (head.next == null)
            {
                this.head = head;
                return this.head;
            }
            ReverseRecursively(head.next);
            Node temp = head.next;
            temp.next = head;
            head.next = null;
            return this.head;
            
        }

        //Printing linked list 
        public void PrintLinkedList(Node traveller)
        {
            while (traveller != null)
            {
                Console.Write(traveller.data+"=>");
                traveller = traveller.next;
            }
        }

        //printing recursively
        public void PrintRecursive(Node traveller)
        {
            if (traveller == null) { return; }
            Console.Write(traveller.data+"=>");
            PrintRecursive(traveller.next);
            
        }

        // Printing in reverse order
        public void PrintRecursiveReverse(Node traveller)
        {
            if (traveller == null) { return; }
            
            PrintRecursive(traveller.next);
            Console.Write(traveller.data + "=>");

        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            
            Console.ReadKey();
        }

    }
}
