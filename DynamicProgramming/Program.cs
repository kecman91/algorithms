// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using DynamicProgramming;
using Utils.Matrix;

Console.WriteLine("Hello, World!");

var sw = new Stopwatch();
sw.Start();
// Console.WriteLine(Fibonacci.FibonacciInefficient(50));
// sw.Stop();
// Console.WriteLine(sw.ElapsedMilliseconds);

// sw.Restart();
// Console.WriteLine(Fibonacci.FibonacciMemo(50));
// sw.Stop();
// Console.WriteLine(sw.ElapsedMilliseconds);

// sw.Restart();
// Console.WriteLine(Fibonacci.FibonacciTopDown(50));
// sw.Stop();
// Console.WriteLine(sw.ElapsedMilliseconds);

// Console.WriteLine(Staircase.CountStepsMemo(5));

int[,] matrix = {
    { 0, 0, 1, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 0 },
    { 0, 1, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 1, 0 }
};

var (thereIsAWay, result) = RobotInAGrid.FindWayMemo(matrix);

Console.WriteLine(thereIsAWay);

MatrixUtils.Print(result);

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);
