using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGameLibrary
{
    
    public class Dice
    {
        public int Num { get; set; }

        public override string ToString()
        {
            return Num.ToString();
        }
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
