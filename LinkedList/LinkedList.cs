using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node headNode;
        public Node tailNode;
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (this.headNode == null)
                this.headNode = newNode;
            else
            {
                Node tempNode = headNode;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }
        }


        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (headNode == null)
                tailNode = headNode = newNode;
            else
            {
                newNode.Next = headNode;
                headNode = newNode;
            }

        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (headNode == null)
                tailNode = headNode = newNode;
            else
            {
                tailNode.Next = newNode;
                tailNode = newNode;
            }
        }

        public void ReversOrder(int data)
        {
            Node newNode = new Node(data);

            if (this.headNode == null)
                this.headNode = newNode;
            else
            {
                Node tempNode = this.headNode;
                headNode = newNode;
                headNode.Next = tempNode;
            }
            Console.WriteLine(newNode.Data + " is inserted into the linked list");
        }
        public void RemoveFirstNode()
        {
            if (headNode == null)
            {
                Console.WriteLine("linked list is empty");
            }
            this.headNode = this.headNode.Next;
            Console.WriteLine("the first element is deleted");
        }
        public void RemoveLastNode()
        {
            if (headNode == null)
            {
                Console.WriteLine("lined list is empty");
            }
            if (headNode.Next == null)
            {
                headNode = null;
            }
            else
            {
                Node laastNode = this.headNode;
                while (laastNode.Next.Next != null)
                {
                    laastNode = laastNode.Next;
                }
                laastNode.Next = null;
                Console.WriteLine("the last element is deleted");
            }
        }
        public void Find(int FindData)
        {
            int count = 0;
            Node tempNode = this.headNode;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.Data.Equals(FindData))
                    {
                        count++;
                    }
                    tempNode = tempNode.Next;
                }
            }
            if (count > 0)
                Console.WriteLine(FindData + " data found " + count + ": time ");
            else
                Console.WriteLine(" data not found\n");
        }

        public void Size()
        {
            int size = 0;
            Node tempNode = this.headNode;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    tempNode = tempNode.Next;
                    size++;
                }
                Console.WriteLine("Size :" + size);
            }
        }
        public void Display()
        {
            Node tempNode = this.headNode;
            if (tempNode == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Console.Write("Linked list is: ");
                while (tempNode != null)
                {
                    Console.Write(tempNode.Data + " ");
                    tempNode = tempNode.Next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}