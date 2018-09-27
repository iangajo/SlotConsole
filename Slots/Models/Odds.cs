using System;
using System.Collections.Generic;
using System.Text;

namespace Slots.Models
{
    public class Odds
    {
        public string Symbol { get; set; }
        public int FiveKind { get; set; }
        public int FourKind { get; set; }
        public int ThreeKind { get; set; }
        public int TwoKind { get; set; }
    }
}
