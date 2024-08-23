using Xunit;
using ChristmasTreeKata;



namespace ChristmasTreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void TurnOnTest()
        {
            var tree = new ChristmasTree();
            bool lights = tree.turnOn();
            Assert.True(lights);
        }

        [Fact]
        public void CheckLightGrid()
        {
            var tree = new ChristmasTree();
            int[][] light_grid = tree.getGrid();
            Assert.Equal(10, light_grid.Length);
            

        }
    }
}