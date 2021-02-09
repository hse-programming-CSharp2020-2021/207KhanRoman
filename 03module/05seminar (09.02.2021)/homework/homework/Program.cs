using System;

namespace A
{
    class Node
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public Node Next { get; set; }
        public override string ToString()
        {
            return $"{Data}";
        }
    }

    class LinkedList
    {
        Node head;
        Node tail;
        int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }

        public void Print()
        {
            Node current = head;
            int i = 1;
            while (current != null)
            {
                Console.WriteLine($"{i} - {current}");
                i++;
                current = current.Next;
            }
        }

        public bool Remove(int data)
        {
            Node current = head;
            Node prev = null;
            while (current.Data != data && current != null)
            {
                prev = current;
                current = current.Next;
            }
            if (current == null) return false;
            if (prev == null) head = current.Next;
            else if (current.Next == null)
            {
                prev.Next = null;
                tail = prev;
            }
            else prev.Next = current.Next;
            if (head == null) tail = null;
            count--;
            return true;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(int data)
        {
            Node current = head;
            while (current?.Next != null && current.Data != data)
            {
                current = current.Next;
            }
            if (current.Next == null) return false;
            return true;
        }

        public void AppendFirst(int data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            count++;
        }

        public Node Max()
        {
            Node current = head;
            Node max = new Node(int.MinValue);
            while (current?.Next != null)
            {
                if (current.Data > max.Data)
                {
                    max = current;
                }
                current = current.Next;
            }
            if (current == null) return null;
            return max;
        }

        public Node Min()
        {
            Node current = head;
            Node min = new Node(int.MaxValue);
            while (current?.Next != null)
            {
                if (current.Data < min.Data)
                {
                    min = current;
                }
                current = current.Next;
            }
            if (current == null) return null;
            return min;
        }

        public Node Middle()
        {
            Node current = head;
            int middle = count % 2 == 0 ? count / 2 : count / 2 + 1;
            if (current == null) return null;
            for (int i = 0; i < middle; i++)
            {
                current = current.Next;
            }
            return current;

        }

        public void Reverse()
        {
            Node current = head;
            Node prev = null;
            for (int i = 0; i < count; i++)
            {
                prev = current;
                current = current.Next;
                (current.Next, prev.Next) = (prev.Next, current.Next);
            }
            (tail, head) = (head, tail);
        }
    }
    class MainClass
    {
        public static void Main()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(10);
            linkedList.Add(50);
            linkedList.Add(20);
            linkedList.Reverse();
            linkedList.Print();
        }
    }
}
