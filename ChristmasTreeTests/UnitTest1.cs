using Xunit;
using ChristmasTreeKata;
using System.Collections.Generic;


namespace ChristmasTreeTests
{
    public class UnitTest1
    {
        private readonly ChristmasTree _tree;
        public UnitTest1()
        {
            _tree = new ChristmasTree(1000);
        }
        [Fact]
        public void TurnOnTest()
        {
            bool lights = _tree.turnOn();
            Assert.True(lights);
        }

        [Fact]
        public void CheckLightGrid()
        {
            int[][] light_grid = _tree.getGrid();
            Assert.Equal(1000, light_grid.Length);
            Assert.Equal(1000, light_grid[0].Length);
            Assert.Equal(0, light_grid[0].Sum())
;
    
        }
    }
}