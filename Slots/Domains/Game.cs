using Slots.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Slots.Domains
{
    public class Game : IGame
    {
        private readonly IReel _reel;
        private readonly IWin _win;

        public Game(IReel reel, IWin win)
        {
            _reel = reel;
            _win = win;
        }

        static readonly Wheels _wheels = new Wheels()
        {
            Wheel = new List<List<int>>()
            {
                new List<int>(){ 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                new List<int>(){ 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                new List<int>(){ 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                new List<int>(){ 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                new List<int>(){ 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
            }

        };

        private readonly string[] _symbols = { "S7", "S6", "S5", "S4", "S3", "S2", "S1", "S0" };

        private const int MaxWheelNumber = 5;



        public Response Spin(int playerId, decimal betAmount)
        {
            var slots = new string[3, 5];

            WheelSpin();

            var winnings = new List<Winnings>();
            var winAmount = 0.00m;
            var win = false;
            do
            {
                Cascade(winnings);

                for (var line = 0; line < 3; line++)
                {
                    for (var wheel = 0; wheel < 5; wheel++)
                    {
                        var index = _wheels.Wheel[wheel].Skip(2 - line).First(); //get symbol index
                        var symbol = _reel.GetReelWheel(wheel).First(r => r.Key == index).Value; //get symbol base on the index

                        slots[line, wheel] = symbol; // assign / reassign the slot symbol
                    }
                }

                winnings = CheckPlayerWin(slots);

                if (winnings.Any()) win = true;

                winAmount += _win.ComputeWinnings(winnings, betAmount);

            } while (winnings.Any());

            var str = string.Join(",", slots.OfType<string>()
                .Select((value, index) => new { value, index })
                .GroupBy(x => x.index / slots.GetLength(1))
                .Select(x => $"{{{string.Join(",", x.Select(y => y.value))}}}"));

            return new Response()
            {
                SlotResult = str,
                WinAmount = winAmount,
                Transaction = win ? "Win" : "Lose"
            };
        }

        public List<Winnings> CheckPlayerWin(string[,] slots)
        {
            var winningLines = new List<Winnings>();

            for (var payLines = 1; payLines <= 30; payLines++) //paylines
            {
                var winningPayLine = _win.GetWinningPayLine(payLines);

                foreach (var symbol in _symbols) //symbols
                {
                    var matchCounter = 0;
                    foreach (var lines in winningPayLine)//slot results base on payline
                    {
                        var currentSymbol = GetSymbol(slots, lines);
                        if (currentSymbol == symbol || currentSymbol == "Wild") matchCounter += 1;
                        else break;
                    }

                    if (matchCounter > 2)
                    {
                        winningLines.Add(new Winnings()
                        {
                            MatchLine = matchCounter,
                            PayLine = payLines,
                            Symbol = symbol
                        });
                    }
                }
            }

            return winningLines;
        }

        public void Cascade(List<Winnings> winnings)
        {
            if (!winnings.Any()) return;

            var forDeletion = new List<string>();
            foreach (var item in winnings)
            {
                var payLine = _win.GetWinningPayLine(item.PayLine);
                for (int i = 0; i < item.MatchLine; i++)
                {

                    if (!forDeletion.Contains(payLine[i]))
                    {
                        forDeletion.Add(payLine[i]);
                    }
                }
            }

            foreach (var item in forDeletion.Distinct())
            {
                var concatenatedSymbols = item.Split(',');

                var row = Convert.ToInt32(concatenatedSymbols[0]);
                var col = Convert.ToInt32(concatenatedSymbols[1]);

                var index = _wheels.Wheel[col].Skip(row).First(); //get the index base on the row and col (array position)

                _wheels.Wheel[col].Remove(index); //remove the item in the array
            }

        }


        #region PrivateMethods

        private string GetSymbol(string[,] slots, string lines)
        {
            var concatenatedSymbols = lines.Split(',');

            var row = Convert.ToInt32(concatenatedSymbols[0]); //get line
            var col = Convert.ToInt32(concatenatedSymbols[1]); //get wheel

            var currentSymbol = slots[row, col];

            return currentSymbol;
        }

        private byte GenerateRandomNumber()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var numberOfSymbols = new int[25];
                var randomNumber = new byte[1];

                do
                {
                    rng.GetBytes(randomNumber);

                } while (!IsFairSpin(randomNumber[0], (byte)numberOfSymbols.Length));

                return (byte)((randomNumber[0] % (byte)numberOfSymbols.Length) + 1);
            } //dispose the rng
        }

        private bool IsFairSpin(byte spin, byte numberOfSymbols)
        {
            var fullSetsOfValues = Byte.MaxValue / numberOfSymbols;

            return spin < numberOfSymbols * fullSetsOfValues;
        }

        private void WheelSpin()
        {
            for (var i = 0; i < MaxWheelNumber; i++)
            {
                var randomNumber = (int)GenerateRandomNumber();

                //rotate the array based on the roll
                _wheels.Wheel[i] = _wheels.Wheel[i].Skip(randomNumber).Concat(_wheels.Wheel[i].Take(randomNumber))
                    .ToList();
            }
        }

        #endregion
    }
}
