using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Slots.Domains;
using Slots.Models;

namespace Slots
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(new Reel(), new Win());

            const int playerId = 1;
            const int betAmount = 10;

            var response = game.Spin(playerId, betAmount);

            Console.WriteLine(response.Transaction);
            Console.WriteLine(response.WinAmount);
            Console.WriteLine(response.SlotResult);

            Console.ReadKey();
        }

    }
}
