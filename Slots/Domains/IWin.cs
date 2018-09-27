using Slots.Models;
using System.Collections.Generic;

namespace Slots.Domains
{
    public interface IWin
    {
        string[] GetWinningPayLine(int win);

        decimal ComputerWinnings(List<Winnings> winningResultsList, decimal betAmount);

        List<Odds> GetOddsTable();
    }
}
