using Domain.Models.Graphs;
using Domain.Models.Lists;

namespace ListOfDepths;

public static class ListOfDepths<T>
{
    public static Node<List<T>> CreateListOfDepths(BinaryTreeNode<T> tree)
    {
        var head = new Node<List<T>>(new List<T>());

        void CreateListOfDepths(BinaryTreeNode<T>? tree, int level)
        {
            if (tree == null)
            {
                return;
            }

            var i = level;
            var iterator = head;
            while (i > 0)
            {
                iterator.Next ??= new Node<List<T>>(new List<T>());

                iterator = iterator.Next;
                i--;
            }

            iterator.Data.Add(tree.Data);
            CreateListOfDepths(tree.Children[0], level + 1);
            CreateListOfDepths(tree.Children[1], level + 1);
        }

        CreateListOfDepths(tree, 0);

        return head;
    }

    public static int CountDepth(BinaryTreeNode<T> root)
    {
        static int CountDepth(BinaryTreeNode<T>? tree, int depth)
        {
            if (tree == null)
            {
                return depth;
            }

            depth++;
            var child1Depth = CountDepth(tree.Children[0], depth);
            var child2Depth = CountDepth(tree.Children[1], depth);

            if (child1Depth > child2Depth)
            {
                return child1Depth;
            }
            else
            {
                return child2Depth;
            }


        }

        return CountDepth(root, 0);
    }
}