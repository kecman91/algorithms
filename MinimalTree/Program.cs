// See https://aka.ms/new-console-template for more information
using MinimalTree;
using Utils.Tree;

Console.WriteLine("Hello, World!");

var array = new int[]{-3,-2,0,1,4,6,7,7,8,12,24,25,26,27,28,30,55,56};

var tree = MinimalTreeFactory<int>.CreateMinimalBinarySearchTree(array);
Console.WriteLine("Is tree balanced: " + TreeUtils<int>.CheckBalanced(tree));

TreeUtils<int>.PrintTree(tree);
