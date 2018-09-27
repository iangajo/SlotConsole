using System;
using System.Collections.Generic;
using System.Text;
using Slots.Models;

namespace Slots.Domains
{
    public interface IGame
    {
        Response Spin(int playerId, decimal betAmount);

        List<Winnings> CheckPlayerWin(string[,] slots);

        void Cascade(List<Winnings> winnings);
    }
}
