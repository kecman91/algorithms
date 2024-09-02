namespace Domain.Models.Graphs;

public class Graph
{
    public Node[]? Nodes { get; set; }

    public void DepthFirstSearch(string name)
    {
        if (Nodes == null)
        {
            return;
        }

        foreach (var node in Nodes)
        {
            DepthFirstSearchRecursion(node, name);
        }
    }

    public Node? BreadthFirstSearch(string name)
    {
        if (Nodes == null)
        {
            return null;
        }

        var queue = new Queue<Node>();
        foreach (var node in Nodes)
        {
            queue.Enqueue(node);
        }

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.Name == name)
            {
                return node;
            }

            foreach (var child in node.Children)
            {
                queue.Enqueue(child);
            }
        }

        return null;
    }

    private static void DepthFirstSearchRecursion(Node node, string name)
    {
        if (node == null)
        {
            return;
        }

        // visit node
        foreach (var child in node.Children)
        {
            DepthFirstSearchRecursion(child, name);
        }
    }
}