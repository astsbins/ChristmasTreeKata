
using System;
using System.Collections.Generic;
using System.Linq;
namespace ChristmasTreeKata;

public class ChristmasTree
{
    private int[][] lightGrid;
    public ChristmasTree(int gridSize) {
    lightGrid = Enumerable.Range(0, gridSize)
      .Select(x => Enumerable.Range(0, gridSize)
           .Select(y => 0).ToArray()).ToArray();
    }
    
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
        // int[] light_grid = from number in Enumerable.Range(0,10) select 0;
        return lightGrid;
    }


}