using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGameLibrary
{
    public class Dices
    {
        public List<Dice> DiceList { get; set; } = new List<Dice>(5);
        public Dices()
        {
            for (int i = 0; i < DiceList.Count; i++)
            {
                DiceList[i] = new Dice();
            }
        }
    }
    public class Dice
    {
        public int Num { get; set; }
    }

    public static class RandomDiceValue
    {
        static Random random = new Random();
        public static void GetNewDiceValues(List<Dice> dices)
        {
            for (int i = 0; i < dices.Count; i++)
            {
                dices[i].Num = random.Next(1, 7);
            }
        }
        public static int GetRandomNum(int num)
        {
            return random.Next(num);
        }
    }
}
