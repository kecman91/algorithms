namespace Domain.Models.Graphs;

public class Node(string name)
{
    public string Name { get; set; } = name;

    public Node[] Children { get; set; } = [];
}

public class BinaryTreeNode<T>(T data)
{
    public T Data { get; set; } = data;

    public BinaryTreeNode<T>?[] Children { get; set; } = new BinaryTreeNode<T>[2];
}