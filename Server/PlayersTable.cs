using DiceGameLibrary;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class PlayersTable
    {
        public List<PlayerForServer> players = new List<PlayerForServer>();
        
        public int currentPlayer { get; set; } = 0;

        public void Add(string name, IPEndPoint ePoint)
        {
            players.Add(new PlayerForServer() { Name = name, ipEndPoint = ePoint });
        }
        public void Delete(string name)
        {
            foreach(var p in players)
            {
                if (p.Name.Equals(name))
                {
                    players.Remove(p);
                }
            }
            for(int i = 0; i < players.Count(); i++)
            {
                if (players[i].Name.Equals(name))
                {
                    players.RemoveAt(i);

                    if (currentPlayer >= i)
                    {
                        currentPlayer--;
                    }
                    break;
                }
            }
        }

        public PlayerForServer GetNextPlayer()
        {
            if (currentPlayer == players.Count - 1)
            {
                currentPlayer = 0;
            }
            else
            {
                currentPlayer++;
            }
            
            return players[currentPlayer];
        }

        public PlayerForServer GetBeforePLayer()
        {
            if (currentPlayer == 0)
            {
                return players[players.Count - 1];
            }
            else
            {
                return players[currentPlayer - 1];
            }
        }
        public PlayerForServer GetCurrentPlayer()
        {
            return players[currentPlayer];
        }

        public int GetNumOfDefiniteDices(int value)
        {
            int num = 0;
            foreach(PlayerForServer player in players)
            {
                foreach(Dice dice in player.DiceList)
                {
                    if (dice.Num == value||dice.Num == 1)
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        public void SetNewDiceValues()
        {
            foreach(var p in players)
            {
                RandomDiceValue.GetNewDiceValues(p.DiceList);
            }
        }

        public bool DeleteDice(PlayerForServer player)
        {
            if (player.DeleteDice() == true)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
