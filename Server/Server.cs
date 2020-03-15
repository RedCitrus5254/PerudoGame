﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DiceGameLibrary;

namespace Server
{
    enum Answer
    {
        Trust,
        NotTrust
    }
    class Server
    {
        static string remoteAddress = "127.0.0.1"; // хост для отправки данных
        //static int remotePort = 8005; // порт для отправки данных
        static int localPort = 8004; // локальный порт для прослушивания входящих подключений

        private int newId = 0;

        //List<PlayerForServer> players = new List<PlayerForServer>();
        PlayersTable playersTable = new PlayersTable();

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        public delegate void MessageProcessing(string message, IPEndPoint ePoint);
        static MessageProcessing messageProcessing;

        private int playersReady = 0;

        private int currentBetCountOfDices = 0;
        private int currentBetValueOfDices = 2;
        
        public Server()
        {
            messageProcessing = ConnectingProcessing;
        }
        public void Start()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), localPort);
                socket.Bind(endPoint);

                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StartGame()
        {
            SendCountOfPlayersToAllPlayers();

            playersTable.SetNewDiceValues(); //задаём начальные значения костей
            SendPlayersDices();

            SendMessageToAllPlayers("игра началась");

            PlayerForServer player = playersTable.GetNextPlayer();
            SendMessageToAllPlayers($"ход игрока {player.Name}");
        }

        private void SendMessageToAllPlayers(string message)
        {
            foreach (var player in playersTable.players)
            {
                SendMessage(message, player.ipEndPoint);
            }
        }

        private void SendMessage(string message, IPEndPoint ePoint)
        {
            try
            {
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.SendTo(data, ePoint); // отправка
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SendCountOfPlayersToAllPlayers()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"количество игроков {playersTable.players.Count}");

            foreach(var p in playersTable.players)
            {
                sb.Append($" {p.Name}");
            }

            SendMessageToAllPlayers(sb.ToString());
        }
        private void SendPlayersDicesToAllPlayers()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var p in playersTable.players)
            {
                sb.Append($"кости игрока {playersTable.players}: ");
                foreach(var d in p.DiceList)
                {
                    sb.Append($"{d.Num} ");
                }
                sb.Append("; ");
            }
            SendMessageToAllPlayers(sb.ToString());
        }
        private void SendPlayersDices()
        {
            foreach(var p in playersTable.players)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("твои кости");
                foreach(var d in p.DiceList)
                {
                    sb.Append($" {d.Num}");
                }
                SendMessage(sb.ToString(), p.ipEndPoint);
            }
        }

        private void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    StringBuilder builder = new StringBuilder();
                    EndPoint remoteIp = null; // адрес входящего подключения

                    byte[] data = new byte[256]; //socket.Receive(ref remoteIp); // получаем данные
                    int bytes = 0; // количество полученных байтов
                    do
                    {
                        bytes = socket.ReceiveFrom(data, ref remoteIp);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (socket.Available > 0);

                    string message = builder.ToString();
                    messageProcessing(message, (IPEndPoint)remoteIp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                socket.Close();
            }
        }

        private void ConnectingProcessing(string message, IPEndPoint ePoint)
        {
            string[] mass = message.Split(' '); //mass[0] - подключился или готов, mass[1] - имя игрока   

            if (mass[0].Equals("подключился"))
            {
                var pl = from p in playersTable.players
                         where p.Name.Equals(mass[1])
                         select p;
                if (pl.Count() == 0)
                {
                    playersTable.Add(mass[1], ePoint);
                    //оповестить других игроков 
                }
            }
            else if (mass[0].Equals("готов"))
            {
                var player = from p in playersTable.players
                             where (p.Name.Equals(mass[1])) && (p.IsReady == false)
                             select p;
                foreach(var p in player)
                {
                    p.IsReady = true;
                }             

                if(playersReady == playersTable.players.Count())
                {
                    messageProcessing = GameProcessing;
                    StartGame();
                }
            }
            
        }

        private void GameProcessing(string message, IPEndPoint ePoint)
        {
            string[] mass = message.Split(' ');
            if (mass[0].Equals("ставка"))
            {
                bool flag = false; //проверка выполнения условий ставки

                int newCountOfDices = Convert.ToInt32(mass[2]);
                int newValueOfDices = Convert.ToInt32(mass[3]);
                if (currentBetValueOfDices!=1 && newValueOfDices != 1)
                {
                    if(newCountOfDices>currentBetCountOfDices||
                        newValueOfDices > currentBetValueOfDices && newCountOfDices == currentBetCountOfDices)
                    {
                        flag = true;
                    }
                }
                else if (currentBetValueOfDices == 1 && newValueOfDices == 1)
                {
                    if (newCountOfDices > currentBetCountOfDices)
                    {
                        flag = true;
                    }
                }
                else if(currentBetValueOfDices == 1 && newValueOfDices != 1)
                {
                    if(newCountOfDices > currentBetCountOfDices * 2)
                    {
                        flag = true;
                    }
                }
                else if (currentBetValueOfDices != 1 && newValueOfDices == 1)
                {
                    int shouldBeCountOfDices = currentBetCountOfDices / 2;
                    if(currentBetCountOfDices % 2 == 1)
                    {
                        shouldBeCountOfDices++;
                    }

                    if(newCountOfDices >= shouldBeCountOfDices)
                    {
                        flag = true;
                    }
                }
                else
                {
                    throw new Exception($"Пришла неверная ставка: {mass[1]} {mass[2]}");
                    //Console.WriteLine("Пришла неверная ставка");
                }

                if (flag == true) //если условия ставки выполнены, сообщаем ставку и передаём ход
                {
                    currentBetCountOfDices = Int32.Parse(mass[1]);
                    currentBetValueOfDices = Int32.Parse(mass[2]);

                    PlayerForServer player = playersTable.GetNextPlayer();
                    SendMessageToAllPlayers($"ставка {playersTable.GetCurrentPlayer()} {mass[1]} {mass[2]}");
                    SendMessageToAllPlayers($"ход {player.Name}");
                }

            }
            else if (mass[0].Equals("не")) //не верю
            {
                CheckResults(Answer.NotTrust);
            }
            else if (mass[0].Equals("верю"))
            {
                CheckResults(Answer.Trust);
            }
            else
            {
                throw new Exception("неверный формат сообщения серверу");
            }

        }

        private void CheckResults(Answer answer)
        {
            PlayerForServer loser = SearchLoser(answer);
            SendMessageToAllPlayers($"верю {playersTable.GetCurrentPlayer().Name}");

            SendPlayersDicesToAllPlayers();

            SendMessageToAllPlayers($"проиграл {loser.Name}");

            if (playersTable.DeleteDice(loser)) //если у игрока остались кости
            {
                NewRound($"ход {loser.Name}");
            }
            else //если у игрока не осталось костей
            {
                SendMessageToAllPlayers($"выбыл {loser.Name}");
                playersTable.Delete(loser.Name);

                if (playersTable.players.Count > 1)
                {
                    NewRound($"ход {playersTable.GetNextPlayer().Name}");
                }
                else
                {
                    SendMessageToAllPlayers($"выиграл {playersTable.players[0].Name}");
                }
                
            }
            
        }

        private PlayerForServer SearchLoser(Answer answer)
        {
            int num = playersTable.GetNumOfDefiniteDices(currentBetValueOfDices);

            if (answer == Answer.NotTrust) //не верю
            {
                if (currentBetCountOfDices > num) //если ставка больше, чем костей на столе
                {
                    return playersTable.GetBeforePLayer(); //берём предыдущего игрока
                }
                else
                {
                    return playersTable.players[playersTable.currentPlayer]; //иначе текущего игрока 
                }
            }
            else //верю
            {
                if (currentBetCountOfDices != num)
                {
                    return playersTable.players[playersTable.currentPlayer];
                }
                else
                {
                    return playersTable.GetBeforePLayer();
                }
            }
        }

        private void NewRound(string playerName)
        {
            SendMessageToAllPlayers("новый раунд");
            playersTable.SetNewDiceValues();
            SendPlayersDices();
            SendMessageToAllPlayers($"ход {playerName}");
        }
    }
}
