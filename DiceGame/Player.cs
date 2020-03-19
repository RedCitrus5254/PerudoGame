using DiceGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public enum Location
    {
        left,
        top,
        right,
        bottom
    }
    public class Player
    {
        public string Name { get; set; }
        public System.Windows.Forms.Label NameLabel { get; set; }

        public List<Dice> dices = new List<Dice>();
        public int notificationLocation;

        public int placeLocation;

        public Location location;
        public Panel dicePanel { get; set; }

        public Player()
        {
            for(int i = 0; i < 5; i++)
            {
                dices.Add(new Dice());
            }
        }

        public override string ToString()
        {
            return Name + location;
        }
    }
}
