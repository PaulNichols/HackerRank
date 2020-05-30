using System;

internal class Node
{
    public int data;
    public Node next;

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

internal class Solution
{
    public static Node insert(Node head, int data)
    {
        var newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else if (head.next == null)
        {
            head.next = newNode;
        }
        else
        {
            var next = GetNext(head.next);

            next.next = newNode;
        }

        return head;
    }

    private static Node GetNext(Node next)
    {
        if (next.next == null)
        {
            return next;
        }
        return GetNext(next.next);
    }

    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }

    private static void Main(String[] args)
    {
        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        display(head);
    }
}