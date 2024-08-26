
using System;
using System.Collections.Generic;
using System.Linq;
namespace ChristmasTreeKata;

public class ChristmasTree
{
    private int[][] lightGrid;
    private int lightGridSize;
    public ChristmasTree(int gridSize) {
        lightGridSize = gridSize;
    lightGrid = Enumerable.Range(0, lightGridSize)
      .Select(x => Enumerable.Range(0, lightGridSize)
           .Select(y => 0).ToArray()).ToArray();
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


    }

    public void turnOn()
    {
        lightGrid = Enumerable.Range(0, lightGridSize)
           .Select(x => Enumerable.Range(0, lightGridSize)
            .Select(y => 1).ToArray()).ToArray();
    }

   

    public int[][] getGrid()
    {
        // int[] light_grid = from number in Enumerable.Range(0,10) select 0;
        return lightGrid;
    }


}