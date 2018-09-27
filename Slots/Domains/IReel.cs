using System;
using System.Collections.Generic;
using System.Text;

namespace Slots.Domains
{
    public interface IReel
    {
        List<KeyValuePair<int, string>> GetReelWheel(int reelNumber);
    }
}
