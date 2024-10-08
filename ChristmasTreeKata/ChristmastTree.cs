﻿
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
        Console.WriteLine("Hello, World?!");


    }

    public int[][] getGrid()
    {
        // int[] light_grid = from number in Enumerable.Range(0,10) select 0;
        return lightGrid;
    }

    public void turnOn(int[]? startCorner = null, int[]? EndCorner = null)
    {
        //      Initialise default values
        startCorner = startCorner ?? new int[] { 0, 0 };
        EndCorner = EndCorner ?? new int[] { 999, 999 };

        for (int i = startCorner[0]; i <= EndCorner[0]; i++)
        {
            for (int j = startCorner[1]; j<= EndCorner[1]; j++)
            {
                lightGrid[j][i] += 1;
            }
        }
    }

   

    public void turnOff(int[]? startCorner = null, int[]? EndCorner = null)
    {
        //      Initialise default values
        startCorner = startCorner ?? new int[] { 0, 0 };
        EndCorner = EndCorner ?? new int[] { 999, 999 };
        for (int i = startCorner[0]; i <= EndCorner[0]; i++)
            {
                for (int j = startCorner[1]; j <= EndCorner[1]; j++)
                {
                    lightGrid[j][i] -= 1;
                }
            }

    }

    public void togglOnOff(int[]? startCorner = null, int[]? EndCorner = null)
    {
        //      Initialise default values
        startCorner = startCorner ?? new int[] { 0, 0 };
        EndCorner = EndCorner ?? new int[] { 999, 999 };
        for (int i = startCorner[0]; i <= EndCorner[0]; i++)
        {
            for (int j = startCorner[1]; j <= EndCorner[1]; j++)
            {
                lightGrid[j][i] = (lightGrid[j][i] + 2); // if 0 +1 = 1 = on, if 1 + 1 = 2; 2%2=0 = off
            }
        }
    }

    public int[][] parseInstruction(string instruction)
    //public string[] parseInstruction(string instruction)
    {
        if (instruction.Contains("turn on"))
        {
            string[] sliced = instruction.Substring("turn on".Length + 1).Split(" through ");
            int[][] corners = sliced
                .Select(subArray => subArray
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray())
                .ToArray();
            return corners;
        }
        //return [[0], [0]];
        return [[0]];
    }
}