using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EnterNameForm());


            //Dices dices = new Dices();
            //RandomDiceValue.GetNewDiceValues(dices.DiceMass);

            //for (int i = 0; i < dices.DiceMass.Length; i++)
            //{
            //    Console.WriteLine(dices.DiceMass[i].Num);
            //}

            //RandomDiceValue.GetNewDiceValues(dices.DiceMass);

            //for (int i = 0; i < dices.DiceMass.Length; i++)
            //{
            //    Console.WriteLine(dices.DiceMass[i].Num);
            //}
            //Console.ReadLine();
        }
    }
}
