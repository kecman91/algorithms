namespace Domain.Models.Lists;

public class Node<T>
{
    public T Data { get; set; }

    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }

    public void AppendToTail(T data)
    {
        var end = new Node<T>(data);
        var tail = this;
        
        while (tail.Next != null)
        {
            tail = tail.Next;
        }

        tail.Next = end;
    }

    public Node<T>? DeleteNode(Node<T>? head, T d)
    {
        if (head == null)
        {
            return null;
        }

        if (head.Data?.Equals(d) == true)
        {
            return head.Next;
        }

        var n = head;
        while (n.Next != null)
        {
            if (n.Next.Data?.Equals(d) == true)
            {
                n.Next = n.Next.Next;
                return head;
            }

            n = n.Next;
        }
        
        return head;
    }

    public Node<T> Reverse()
    {
        var head = new Node<T>(Data);
        var iterator = Next;
        while (iterator != null)
        {
            var temp = new Node<T>(iterator.Data)
            {
                Next = head
            };
            head = temp;
            iterator = iterator.Next;
        }

        return head;
    }

    public void PrintList()
    {
        var iterator = this;
        while (iterator != null)
        {
            Console.Write(iterator.Data + ",");
            iterator = iterator.Next;
        }
        Console.Write("\n");
    }
}