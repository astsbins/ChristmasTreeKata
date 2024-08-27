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
        public void CheckLightGridTest()
        {
            int[][] lightGrid = _tree.getGrid();
            Assert.Equal(1000, lightGrid.Length);
            Assert.Equal(1000, lightGrid[0].Length);
            Assert.Equal(0, lightGrid[0].Sum());
        }

        [Fact]
        public void TurnOnAllTest()
        {
            _tree.turnOn();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[0].Sum());
            }
        }

        [Fact]
        public void turnOffAllTest()
        {
            _tree.turnOff();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(0, lightGrid[0].Sum());
            }
        }

        [Fact]
        public void toggleOnAllTest()
        {
            _tree.togglOnOff();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[0].Sum());
            }

            _tree.togglOnOff();
            lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(0, lightGrid[0].Sum());
            }
        }


    }
}