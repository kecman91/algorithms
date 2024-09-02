using System.Text;
using Domain.Models.Graphs;

namespace Utils.Tree;

public static class TreeUtils<T>
{
    public static void PrintTree(BinaryTreeNode<T>? tree)
    {
        static void Print(BinaryTreeNode<T>? tree, int level)
        {
            if (tree == null)
            {
                return;
            }

            var indentation = string.Join("", Enumerable.Range(0, level).Select(x => "\t"));
            Console.WriteLine($"{indentation}{tree.Data}");

            Print(tree.Children[0], level + 1);
            Print(tree.Children[1], level + 1);
        }

        Print(tree, 0);
    }

    public static BinaryTreeNode<T>? CreateMinimalBinarySearchTree(T[] array)
    {
        static BinaryTreeNode<T>? CreateMinimalBinarySearchTree(T[] array, int start, int end)
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

        return CreateMinimalBinarySearchTree(array, 0, array.Length - 1);
    }

    public static bool CheckBalanced(BinaryTreeNode<T>? tree)
    {
        static (bool, int) CheckBalanced(BinaryTreeNode<T>? tree, int depth)
        {
            if (tree == null)
            {
                return (true, depth);
            }

            var (isLeftBalanced, leftDepth) = CheckBalanced(tree.Children[0], depth + 1);
            var (isRightBalanced, rightDepth) = CheckBalanced(tree.Children[0], depth + 1);

            if (!isLeftBalanced)
            {
                return (false, -1);
            }

            if (!isRightBalanced)
            {
                return (false, -1);
            }

            return (Math.Abs(leftDepth - rightDepth) <= 1, Math.Max(leftDepth, rightDepth));
        }

        var (isBalanced, _) = CheckBalanced(tree, 0);
        return isBalanced;
    }
}