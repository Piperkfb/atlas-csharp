using System;

/// <summary>
/// class Queue<t>
/// </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    /// <summary> creation of node </summary>
    public class Node
    {
        private T value = null;
        public Node next = null;

        public Node(T thing)
            value = thing;

    }

    public void Enqueue()
    {
        Node newNode = new Node(value);
        if (head == null)
            head = newNode;

        else
            tail.next = newNode;
        
        count++;

    }

    /// <summary> Check type of T </summary>
    public Type CheckType()
        return typeof(T);

    /// <summary> returns count </summary>
    public int Count()
        return count;
}