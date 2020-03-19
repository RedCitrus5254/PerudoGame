using System;

namespace DiceGameLibrary
{
    public enum BetType
    {
        trust,
        notTrust,
        bet
    }
    public class Bet
    {
        public BetType betType { get; set; }
        public int CountOfDices { get; set; }
        public int DiceValue { get; set; }
    }
}
