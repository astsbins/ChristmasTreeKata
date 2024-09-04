using Xunit;
using ChristmasTreeKata;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;


namespace ChristmasTreeTests
{
    public class UnitTest1
    {
        private readonly ChristmasTree _tree;
        private string _instruction;
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

            _tree.togglOnOff();
           lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(3000, lightGrid[i].Sum());
            }
        }

        [Fact]
        public void turnOffAllTest()
        {
            _tree.turnOn();
            _tree.turnOff();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(0, lightGrid[i].Sum());
            }

            _tree.turnOn();
            _tree.turnOn();
            _tree.turnOff();
            lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[i].Sum());
            }
        }

        [Fact]
        public void toggleOnAllTest()
        {
            _tree.togglOnOff();
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(2000, lightGrid[i].Sum());
            }

            _tree.togglOnOff();
            lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(4000, lightGrid[i].Sum());
            }
        }

        [Fact]
        public void examplesTest()
        {
            // turn on 0,0 through 999,999 would turn on (or leave on) every light.
            _tree.turnOn([0, 0], [999, 999]);
            int[][] lightGrid = _tree.getGrid();
            for (int i = 0; i < lightGrid.Length; i++)
            {
                Assert.Equal(1000, lightGrid[0].Sum());
            }

            // toggle 0,0 through 999,0 would toggle the first line of 1000 lights, turning off the ones that were on, and turning on the ones that were off.
            _tree.togglOnOff([0, 0], [999, 0]);
            lightGrid = _tree.getGrid();
            Assert.Equal(3000 , lightGrid[0].Sum()); //first line
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

        //[Fact]
        //public void instructionsTest()
        //{
        //    _tree.turnOn([887, 9], [959, 629]);
        //    Assert.Equal(45333, total());
        //    _tree.turnOn([454, 398], [844, 448]);
        //    Assert.Equal(65274, total());
        //    _tree.turnOff([539, 243], [559, 965]);
        //    _tree.turnOff([370, 819], [676, 868]);
        //    _tree.turnOff([145, 40], [370, 997]);
        //    _tree.turnOff([301, 3], [808, 453]);
        //    _tree.turnOn([351, 678], [951, 908]);
        //    _tree.togglOnOff([720, 196], [897, 994]);
        //    _tree.togglOnOff([831, 394], [904, 860]);
        //    Assert.Equal(230022, total());
        //}

        [Fact]
        public void parseInstructionTurnOnTest()
        {
            _instruction = "turn on 887,9 through 959,629";
            int[][] output = _tree.parseInstruction(_instruction);
            //string[] output = _tree.parseInstruction(_instruction);
            Assert.Equal([[887, 9], [959, 629]], output);
            //Assert.Equal(new string[] { "887,9", "959,629" }, output);

            _instruction = "turn on 454,398 through 844,448";
            output = _tree.parseInstruction(_instruction);
            Assert.Equal([[454, 398], [844, 448]], output);
        }

        public int total()
        {
            int[][] lightGrid = _tree.getGrid();
            int total = 0;
            foreach (int[] row in lightGrid)
            {
                total += row.Sum();
            }
            return (total);
        }

    }

}