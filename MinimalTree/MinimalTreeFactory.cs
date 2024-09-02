using Domain.Models.Graphs;

namespace MinimalTree;

public static class MinimalTreeFactory<T> where T : IComparable<T>
{
    public static BinaryTreeNode<T>? CreateMinimalBinarySearchTree(T[] array)
    {
        return CreateMinimalBinarySearchTree(array, 0, array.Length - 1);
    }

    private static BinaryTreeNode<T>? CreateMinimalBinarySearchTree(T[] array, int start, int end)
    {
        if (end < start)
        {
            return null;
        }

        var mid = (start + end) / 2;
        var node = new BinaryTreeNode<T>(array[mid]);
        var child1 = CreateMinimalBinarySearchTree(array, start, mid - 1);
        var child2 = CreateMinimalBinarySearchTree(array, mid + 1, end);
        node.Children[0] = child1;
        node.Children[1] = child2;
        
        return node;
    }
}