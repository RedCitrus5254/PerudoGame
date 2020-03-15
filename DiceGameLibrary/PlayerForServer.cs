using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DiceGameLibrary
{
    public class PlayerForServer
    {
        public string Name { get; set; }

        public IPEndPoint ipEndPoint { get; set; }

        public List<Dice> DiceList { get; set; } = new List<Dice>(5);

        public bool IsReady { get; set; } = false;

        public PlayerForServer()
        {
            for(int i=0;i<DiceList.Count; i++)
            {
                DiceList.Add(new Dice());
            }
        }

        public bool DeleteDice()
        {
            DiceList.RemoveAt(DiceList.Count - 1);
            if (DiceList.Count > 0)
            {
                return true;
            }

            return false;
        }

        
    }
}
