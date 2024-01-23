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
        public T value;
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
        {
            tail.next = newNode;
            tail = newNode;
            
        }
        
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            tail.value = head.value;
            head = head.next;
            count--;
            return tail.value;
        }
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            tail = head;
            while (tail != null)
            {
                Console.WriteLine(tail.value);
                tail = tail.next;
            }
        }
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }
        else
        {
            int i = 0;
            string s = "";
            tail = head;
            if (typeof(T) == typeof(char))
            {
                while (tail != null)
                {
                    s += tail.value;
                    tail = tail.next;
                }
            }
            else if (typeof(T) == typeof(string))
            {
                while (tail != null)
                {
                    if (i != 0)
                        s += " ";
                    s += tail.value;
                    tail = tail.next;
                    i++;
                }
            }
            return s;
        }
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