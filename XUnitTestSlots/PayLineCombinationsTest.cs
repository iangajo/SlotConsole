using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slots.Domains;
using Xunit;

namespace XUnitTestSlots
{
    public class PayLineCombinationsTest
    {

        [Fact]
        public void PayLine_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S7", "S7", "S7" },
                { "S7", "S7", "S7", "S7", "S7" },
                { "S7", "S7", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;

            Assert.Equal(30, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_1_28_29_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S7", "S7", "S7", "S7", "S7" },
                { "S1", "S2", "S3", "S4", "S5" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            
            Assert.Equal(3, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_2_5_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S7", "S7", "S7" },
                { "S1", "S2", "S0", "S7", "S7" },
                { "S0", "S0", "S3", "S4", "S5" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;

            Assert.Equal(2, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_2_3_6_7_22_23_26_27_30_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S7", "S7", "S7" },
                { "S0", "S1", "S3", "S4", "S1" },
                { "S7", "S7", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;

            Assert.Equal(9, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_2_3_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S7", "S7", "S7" },
                { "S0", "S5", "S3", "S4", "S2" },
                { "S1", "S1", "S1", "S1", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;

            Assert.Equal(2, resultCount);     
            Assert.NotEmpty(results);
        }

        [Fact]
        public void PayLine_13_14_15_18_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S0", "S7", "S0", "S0" },
                { "S0", "S5", "S0", "S4", "S0" },
                { "S1", "S0", "S0", "S0", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;

            Assert.Equal(4, resultCount);
            Assert.NotEmpty(results);
        }
    }
}
