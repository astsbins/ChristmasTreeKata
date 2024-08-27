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
                Assert.Equal(1000, lightGrid[i].Sum());
            }
        }

        [Fact]
        public void turnOffAllTest()
        {
            _tree.turnOff();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(0, lightGrid[i].Sum());
            }
        }

        [Fact]
        public void toggleOnAllTest()
        {
            _tree.togglOnOff();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[i].Sum());
            }

            _tree.togglOnOff();
            lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(0, lightGrid[i].Sum());
            }
        }

        [Fact]
        public void examplesTest()
        {
            // turn on 0,0 through 999,999 would turn on (or leave on) every light.
            _tree.turnOn([0, 0], [999,999]);
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[0].Sum());
            }

            // toggle 0,0 through 999,0 would toggle the first line of 1000 lights, turning off the ones that were on, and turning on the ones that were off.
            _tree.togglOnOff([0, 0], [999, 0]);
            lightGrid = _tree.getGrid();
            Assert.Equal(0, lightGrid[0].Sum());
            for (int i = 1; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[i].Sum());
            }

            // turn off 499,499 through 500,500 would turn off (or leave off) the middle four lights.
            _tree.turnOff([499, 499], [500, 500]);
            lightGrid = _tree.getGrid();
            Assert.Equal(1000, lightGrid[498].Sum());
            Assert.Equal(998, lightGrid[499].Sum());
            Assert.Equal(998, lightGrid[500].Sum());
            Assert.Equal(1000, lightGrid[501].Sum());
            Assert.Equal([0, 0, 0, 0], [lightGrid[499][499], lightGrid[499][500], lightGrid[500][499], lightGrid[500][500]]);
        }

    }
}