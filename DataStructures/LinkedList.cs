using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {

        public int info;
        public Node Link;
        public Node(int data)
        {
            info = data;//constructor is defaultly calling and it will initialize the data
            Link = null;
        }
    }
    public class LinkedList
    {
        private Node Head;
        public LinkedList()
        {
            Head = null;
        }
        
        public void Insert(int data)
        {
            Node temp = new Node(data);
           this.Head = temp;
            Console.WriteLine("insert the data" + this.Head.info);
        }
        public void AddLast(int data)
        {
            Node new_node = new Node(data);
            if(this.Head == null)
            {
                this.Head = new_node; 
            }
            else
            {
                Node temp = this.Head;
                while (temp.Link != null)
                {
                    temp = temp.Link;  
                }
                temp.Link = new_node;
                Console.WriteLine("adding the elements at  last:" + new_node.info);
            }
        }
       
        public void AddFront(int data)
        {
            Node new_node = new Node(data);
            new_node.Link = this.Head;
            this.Head = new_node;
            Console.WriteLine("add elements at front:" + new_node.info);
        }
        public void Display()
        {
            Node New_node = this.Head;
            if (New_node == null)
            {
                Console.WriteLine("if the node is empty");
            }
            else
            {
                while(New_node != null)
                {
                    Console.WriteLine("if the node is not empty:" + New_node.info);
                    New_node = New_node.Link;

                }
            }
        }
    }
    
}
