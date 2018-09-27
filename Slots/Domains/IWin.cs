using Slots.Models;
using System.Collections.Generic;

namespace Slots.Domains
{
    public interface IWin
    {
        string[] GetWinningPayLine(int win);

        decimal ComputeWinnings(List<Winnings> winningResultsList, decimal betAmount);

        List<Odds> GetOddsTable();
    }
}
