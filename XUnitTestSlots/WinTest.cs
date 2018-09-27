using System;
using System.Collections.Generic;
using System.Text;
using Slots.Domains;
using Slots.Models;
using Xunit;

namespace XUnitTestSlots
{
    public class WinTest
    {
        [Fact]
        public void Player_Win_1000()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
               new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S7" }
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(1000, winAmount);
        }

        [Fact]
        public void Player_Win_1080()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S7" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S1" }
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(1080, winAmount);
        }

        [Fact]
        public void Player_Win_45()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
                new Winnings() { MatchLine = 3, PayLine = 1, Symbol = "S0" },
                new Winnings() { MatchLine = 4, PayLine = 1, Symbol = "S3" }
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(45, winAmount);
        }

        [Fact]
        public void Player_Win_1800()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S0" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S1" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S2" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S3" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S4" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S5" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S6" },
                new Winnings() { MatchLine = 5, PayLine = 1, Symbol = "S7" },
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(1800, winAmount);
        }

        [Fact]
        public void Player_Win_0()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
                new Winnings() { MatchLine = 2, PayLine = 1, Symbol = "S0" },
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(0, winAmount);
        }

        [Fact]
        public void Player_Win_40()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
                new Winnings() { MatchLine = 4, PayLine = 1, Symbol = "S4" },
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(40, winAmount);
        }

        [Fact]
        public void Player_Win_130()
        {
            var win = new Win();

            var winnings = new List<Winnings>()
            {
                new Winnings() { MatchLine = 4, Symbol = "S3" },
                new Winnings() { MatchLine = 3, Symbol = "S5" },
                new Winnings() { MatchLine = 5, Symbol = "S0" },
            };

            var betAmount = 1;

            var winAmount = win.ComputeWinnings(winnings, betAmount);

            Assert.Equal(130, winAmount);
        }

    }
}
