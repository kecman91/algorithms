namespace Domain.Models.Graphs;

public class Node
{
    public string Name { get; set; }

    public Node[] Children { get; set; }

    public Node(string name)
    {
        Name = name;
        Children = [];
    }
}