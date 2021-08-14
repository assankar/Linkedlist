using System;

namespace LinkedList
{

    public class MyLinkedList
    {
        private Node head;
        int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
            myLinkedList.Get(1);              // return 2
            myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
            myLinkedList.Get(1);              // return 3
        }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index >= count)
            {
                return -1;
            }
            else
            {
                var curr = head;
                for (int i = 0; i < index; i++)
                {
                    curr = curr.next;
                }
                return curr.val;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node n = new Node(val);
            n.next = head;
            head = n;
            count++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {

            if (head == null)
            {
                AddAtHead(val);
                return;
            }

            //Node n = new Node(val);
            var curr = head;
            for (int i = 0; i < count - 1; i++)
            {
                curr = curr.next;
            }

            curr.next = new Node(val);
            count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            Node n = new Node(val);
            var curr = head;
            for (int i = 0; i < index - 1; i++)
            {
                curr = curr.next;
            }
            n.next = curr.next;
            curr.next = n;
            count++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var curr = head;
            for (int i = 0; i < index - 1; i++)
            {
                curr = curr.next;
            }
            var nextNode = curr.next;
            nextNode = nextNode.next;

            curr.next = nextNode;
            count--;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node(int n)
        {
            val = n;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */