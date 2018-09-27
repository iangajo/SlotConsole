using System;
using System.Linq;
using Slots.Domains;
using Xunit;

namespace XUnitTestSlots
{
    public class PayLinesTest
    {
        [Fact]
        public void PayLine_1_Win()
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
            //line 1, 28 and 29
            Assert.Equal(3, resultCount);
        }

        [Fact]
        public void PayLine_2_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S7", "S7", "S7" },
                { "S3", "S4", "S5", "S6", "S7" },
                { "S1", "S2", "S3", "S4", "S5" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 2
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_3_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S3", "S4", "S5", "S6", "S7" },
                { "S7", "S7", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 3
            Assert.Equal(1, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_4_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S0", "S3", "S4" },
                { "S1", "S2", "S7", "S7", "S7" },
                { "S3", "S5", "S6", "S0", "S2" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 4
            Assert.Equal(1, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_5_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S1", "S2", "S7", "S7", "S7" },
                { "S7", "S7", "S0", "S1", "S2" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 5
            Assert.Equal(1, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_6_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S7", "S2", "S3", "S4" },
                { "S3", "S4", "S5", "S6", "S7" },
                { "S0", "S1", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 6
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_7_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S7", "S7", "S7" },
                { "S3", "S4", "S5", "S6", "S7" },
                { "S7", "S7", "S1", "S2", "S3" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 7
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_8_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S6", "S5", "S7", "S3", "S4" },
                { "S7", "S7", "S5", "S7", "S4" },
                { "S1", "S2", "S3", "S4", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 8
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_9_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S7" },
                { "S7", "S7", "S5", "S7", "S7" },
                { "S1", "S2", "S7", "S4", "5" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 9
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_10_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S7", "S7", "S7" },
                { "S0", "S7", "S1", "S2", "S3" },
                { "S2", "S3", "S4", "S5", "S6" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 10
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_11_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S3", "S7", "S5", "S6", "S7" },
                { "S7", "s4", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 11
            Assert.Equal(1, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_12_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S7", "S7", "S7", "S4" },
                { "S7", "S3", "S4", "S5", "S7" },
                { "S5", "S4", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 12
            Assert.Equal(1, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_13_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S7", "S3", "S4", "S5", "S7" },
                { "S5", "S7", "S7", "S7", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 13
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_14_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S7", "S2", "S7", "S7" },
                { "S7", "S3", "S7", "S5", "S6" },
                { "S5", "S4", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 14
            Assert.Equal(1, resultCount);
            Assert.Equal("S7", results.First().Symbol);
        }

        [Fact]
        public void PayLine_15_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S7", "S3", "S7", "S5", "S6" },
                { "S5", "S7", "S3", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 15
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_16_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S2", "S3", "S4" },
                { "S2", "S7", "S7", "S5", "S6" },
                { "S5", "S4", "S3", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 16
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_17_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S7", "S7" },
                { "S2", "S7", "S7", "S5", "S6" },
                { "S7", "S4", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 17
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_18_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S7", "S2", "S3", "S4" },
                { "S7", "S3", "S4", "S7", "S7" },
                { "S5", "S4", "S7", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 3
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_19_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S7", "S3", "S4" },
                { "S7", "S3", "S4", "S7", "S7" },
                { "S5", "S7", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 19
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_20_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S2", "S3", "S4" },
                { "S2", "S7", "S4", "S5", "S6" },
                { "S5", "S4", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 20
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_21_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S7", "S7", "S7" },
                { "S2", "S7", "S4", "S5", "S6" },
                { "S7", "S4", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 21
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_22_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S7", "S3", "S4" },
                { "S2", "S3", "S4", "S7", "S6" },
                { "S5", "S7", "S3", "S2", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 22
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_23_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S7", "S2", "S3", "S7" },
                { "S2", "S3", "S4", "S7", "S6" },
                { "S7", "S4", "S7", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 23
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_24_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S2", "S7", "S4" },
                { "S2", "S3", "S7", "S5", "S7" },
                { "S5", "S7", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 24
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_25_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S7", "S2", "S3", "S4" },
                { "S2", "S3", "S7", "S5", "S7" },
                { "S7", "S4", "S3", "S7", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 25
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_26_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S2", "S7", "S7" },
                { "S2", "S3", "S4", "S5", "S6" },
                { "S5", "S7", "S7", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 26 and 30
            Assert.Equal(2, resultCount);
        }

        [Fact]
        public void PayLine_27_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S7", "S7", "S3", "S4" },
                { "S2", "S3", "S4", "S5", "S6" },
                { "S7", "S4", "S3", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 27
            Assert.Equal(1, resultCount);
        }

        [Fact]
        public void PayLine_28_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S7", "S7" },
                { "S7", "S7", "S7", "S5", "S6" },
                { "S5", "S4", "S3", "S2", "S1" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 1, 28 and 29
            Assert.Equal(3, resultCount);
        }

        [Fact]
        public void PayLine_29_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S0", "S1", "S2", "S3", "S4" },
                { "S7", "S7", "S7", "S5", "S6" },
                { "S5", "S4", "S3", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 1, 28 and 29
            Assert.Equal(3, resultCount);
        }

        [Fact]
        public void PayLine_30_Win()
        {
            var game = new Game(new Reel(), new Win());

            var slots = new string[3, 5]
            {
                { "S7", "S1", "S2", "S3", "S4" },
                { "S2", "S3", "S4", "S5", "S6" },
                { "S5", "S7", "S7", "S7", "S7" }
            };

            var results = game.CheckPlayerWin(slots);
            var resultCount = results.Count;
            //line 26 and 30
            Assert.Equal(2, resultCount);
        }
    }
}
