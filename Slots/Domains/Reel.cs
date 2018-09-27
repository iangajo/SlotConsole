using System.Collections.Generic;

namespace Slots.Domains
{
    public class Reel : IReel
    {
        public List<KeyValuePair<int, string>> GetReelWheel(int reelNumber)
        {
            switch (reelNumber)
            {
                case 0:
                    return new List<KeyValuePair<int, string>>
                    {
                        new KeyValuePair<int, string>(1, "S0"),
                        new KeyValuePair<int, string>(2, "S1"),
                        new KeyValuePair<int, string>(3, "S0"),
                        new KeyValuePair<int, string>(4, "S2"),
                        new KeyValuePair<int, string>(5, "S3"),
                        new KeyValuePair<int, string>(6, "S1"),
                        new KeyValuePair<int, string>(7, "S3"),
                        new KeyValuePair<int, string>(8, "S0"),
                        new KeyValuePair<int, string>(9, "S0"),
                        new KeyValuePair<int, string>(10, "S2"),
                        new KeyValuePair<int, string>(11, "S4"),
                        new KeyValuePair<int, string>(12, "S2"),
                        new KeyValuePair<int, string>(13, "S1"),
                        new KeyValuePair<int, string>(14, "S1"),
                        new KeyValuePair<int, string>(15, "S4"),
                        new KeyValuePair<int, string>(16, "S2"),
                        new KeyValuePair<int, string>(17, "S5"),
                        new KeyValuePair<int, string>(18, "S6"),
                        new KeyValuePair<int, string>(19, "S7"),
                        new KeyValuePair<int, string>(20, "Bonus"),
                        new KeyValuePair<int, string>(21, "S6"),
                        new KeyValuePair<int, string>(22, "S0"),
                        new KeyValuePair<int, string>(23, "S5"),
                        new KeyValuePair<int, string>(24, "Bonus"),
                        new KeyValuePair<int, string>(25, "S0"),
                    };
                case 1:
                    return new List<KeyValuePair<int, string>>
                    {
                        new KeyValuePair<int, string>(1, "S0"),
                        new KeyValuePair<int, string>(2, "S1"),
                        new KeyValuePair<int, string>(3, "S2"),
                        new KeyValuePair<int, string>(4, "S0"),
                        new KeyValuePair<int, string>(5, "S0"),
                        new KeyValuePair<int, string>(6, "S3"),
                        new KeyValuePair<int, string>(7, "S4"),
                        new KeyValuePair<int, string>(8, "S1"),
                        new KeyValuePair<int, string>(9, "S5"),
                        new KeyValuePair<int, string>(10, "Bonus"),
                        new KeyValuePair<int, string>(11, "S1"),
                        new KeyValuePair<int, string>(12, "Bonus"),
                        new KeyValuePair<int, string>(13, "S6"),
                        new KeyValuePair<int, string>(14, "S5"),
                        new KeyValuePair<int, string>(15, "S0"),
                        new KeyValuePair<int, string>(16, "S0"),
                        new KeyValuePair<int, string>(17, "S0"),
                        new KeyValuePair<int, string>(18, "S2"),
                        new KeyValuePair<int, string>(19, "S1"),
                        new KeyValuePair<int, string>(20, "S7"),
                        new KeyValuePair<int, string>(21, "S0"),
                        new KeyValuePair<int, string>(22, "Bonus"),
                        new KeyValuePair<int, string>(23, "S1"),
                        new KeyValuePair<int, string>(24, "S4"),
                        new KeyValuePair<int, string>(25, "Wild"),

                    };
                case 2:
                    return new List<KeyValuePair<int, string>>
                    {
                        new KeyValuePair<int, string>(1, "S0"),
                        new KeyValuePair<int, string>(2, "S2"),
                        new KeyValuePair<int, string>(3, "S3"),
                        new KeyValuePair<int, string>(4, "S4"),
                        new KeyValuePair<int, string>(5, "S1"),
                        new KeyValuePair<int, string>(6, "S1"),
                        new KeyValuePair<int, string>(7, "S5"),
                        new KeyValuePair<int, string>(8, "S7"),
                        new KeyValuePair<int, string>(9, "S1"),
                        new KeyValuePair<int, string>(10, "Bonus"),
                        new KeyValuePair<int, string>(11, "S2"),
                        new KeyValuePair<int, string>(12, "S1"),
                        new KeyValuePair<int, string>(13, "Bonus"),
                        new KeyValuePair<int, string>(14, "Wild"),
                        new KeyValuePair<int, string>(15, "Wild"),
                        new KeyValuePair<int, string>(16, "S2"),
                        new KeyValuePair<int, string>(17, "S2"),
                        new KeyValuePair<int, string>(18, "S1"),
                        new KeyValuePair<int, string>(19, "S1"),
                        new KeyValuePair<int, string>(20, "Bonus"),
                        new KeyValuePair<int, string>(21, "S1"),
                        new KeyValuePair<int, string>(22, "S3"),
                        new KeyValuePair<int, string>(23, "S3"),
                        new KeyValuePair<int, string>(24, ""),
                        new KeyValuePair<int, string>(25, ""),

                    };
                case 3:
                    return new List<KeyValuePair<int, string>>
                    {
                        new KeyValuePair<int, string>(1, "S3"),
                        new KeyValuePair<int, string>(2, "S3"),
                        new KeyValuePair<int, string>(3, "S4"),
                        new KeyValuePair<int, string>(4, "S5"),
                        new KeyValuePair<int, string>(5, "S1"),
                        new KeyValuePair<int, string>(6, "S1"),
                        new KeyValuePair<int, string>(7, "Wild"),
                        new KeyValuePair<int, string>(8, "Bonus"),
                        new KeyValuePair<int, string>(9, "Bonus"),
                        new KeyValuePair<int, string>(10, "S2"),
                        new KeyValuePair<int, string>(11, "S2"),
                        new KeyValuePair<int, string>(12, "S1"),
                        new KeyValuePair<int, string>(13, "Wild"),
                        new KeyValuePair<int, string>(14, "S6"),
                        new KeyValuePair<int, string>(15, "S7"),
                        new KeyValuePair<int, string>(16, "S2"),
                        new KeyValuePair<int, string>(17, "S5"),
                        new KeyValuePair<int, string>(18, "S2"),
                        new KeyValuePair<int, string>(19, "Wild"),
                        new KeyValuePair<int, string>(20, "S1"),
                        new KeyValuePair<int, string>(21, "S1"),
                        new KeyValuePair<int, string>(22, "S2"),
                        new KeyValuePair<int, string>(23, ""),
                        new KeyValuePair<int, string>(24, ""),
                        new KeyValuePair<int, string>(25, ""),
                    };
                case 4:
                    return new List<KeyValuePair<int, string>>
                    {
                        new KeyValuePair<int, string>(1, "S5"),
                        new KeyValuePair<int, string>(2, "S5"),
                        new KeyValuePair<int, string>(3, "S6"),
                        new KeyValuePair<int, string>(4, "S7"),
                        new KeyValuePair<int, string>(5, "S2"),
                        new KeyValuePair<int, string>(6, "S3"),
                        new KeyValuePair<int, string>(7, "S3"),
                        new KeyValuePair<int, string>(8, "S3"),
                        new KeyValuePair<int, string>(9, "S2"),
                        new KeyValuePair<int, string>(10, "S1"),
                        new KeyValuePair<int, string>(11, "S1"),
                        new KeyValuePair<int, string>(12, "S2"),
                        new KeyValuePair<int, string>(13, "S3"),
                        new KeyValuePair<int, string>(14, "S4"),
                        new KeyValuePair<int, string>(15, "S5"),
                        new KeyValuePair<int, string>(16, "S7"),
                        new KeyValuePair<int, string>(17, "S1"),
                        new KeyValuePair<int, string>(18, "S2"),
                        new KeyValuePair<int, string>(19, "S4"),
                        new KeyValuePair<int, string>(20, "S1"),
                        new KeyValuePair<int, string>(21, "S1"),
                        new KeyValuePair<int, string>(22, "S3"),
                        new KeyValuePair<int, string>(23, "S4"),
                        new KeyValuePair<int, string>(24, "S1"),
                        new KeyValuePair<int, string>(25, "S2"),

                    };
                default:
                    return new List<KeyValuePair<int, string>>();
            }
        }
    }
}
