
using System;
using System.Collections.Generic;
namespace ChristmasTreeKata;

public class ChristmasTree
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public bool turnOn()
    {
        return true;
    }

    public int[][] getGrid()
    {
# int[] light_grid = from number in Enumerable.Range(0,10) select 0;
        return [[0], [0], [0], [0], [0], [0], [0], [0], [0], [0]];
    }


}