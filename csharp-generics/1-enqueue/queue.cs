using System;

/// <summary>
/// class Queue t
/// </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    /// <summary> creation of node </summary>
    public class Node
    {
        private T value;
        public Node next = null;

        public Node(T stri)
        {
            value = stri;
        }

    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }

        else
            tail = newNode;
            tail.next = newNode;
        
        count++;

    }

    /// <summary> Check type of T </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> returns count </summary>
    public int Count()
    {
        return count;
    }
}