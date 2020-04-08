using DiceGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    class Client
    {
        private string remoteAddress = "127.0.0.1"; // хост для отправки данных
        private string localAddress = "127.0.0.1";
        private int remotePort = 8004; // порт для отправки данных
        private int localPort = 8005; // локальный порт для прослушивания входящих подключений

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint serverEndPoint;

        private List<Player> opponents = new List<Player>();
        private List<Player> players = new List<Player>();

        private Player thisPlayer = new Player();


        public delegate void UpdateForm<T>(T str);
        public delegate void SendDataToForm<T>(List<T> list);

        ClientForm form;

        public bool Alive { get; set; } = false; // будет ли работать поток для приема

        private bool isNewRound = false;

        public Client(ClientForm form1, int port)
        {
            Alive = true;
            localPort = port;

            thisPlayer.Name = form1.playerName;
            thisPlayer.location = Location.bottom;
            players.Add(thisPlayer);

            form = form1;
            EndPoint localPoint = new IPEndPoint(IPAddress.Parse(localAddress), localPort);
            socket.Bind(localPoint);

            serverEndPoint = new IPEndPoint(IPAddress.Parse(remoteAddress), remotePort);

            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start();

            SendMessage($"подключился {form.playerName}");
            
        }

        public void SendMessage(string message)
        {
            try
            {
                byte[] byteMass = Encoding.Unicode.GetBytes(message);
                socket.SendTo(byteMass, serverEndPoint);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ReceiveMessage()
        {
            EndPoint remoteEP = serverEndPoint;
            try
            {
                while (Alive)
                {
                    StringBuilder builder = new StringBuilder();

                    byte[] data = new byte[256]; //socket.Receive(ref remoteIp); // получаем данные
                    int bytes = 0; // количество полученных байтов
                    do
                    {
                        bytes = socket.ReceiveFrom(data, ref remoteEP);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (socket.Available > 0);

                    string message = builder.ToString();
                    string[] messages = message.Split(';');
                    
                    foreach(string m in messages)
                    {
                        ProcessingResponse(m);
                    }

                    
                }
                
            }
            catch (ObjectDisposedException)
            {
                if (!Alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                if(socket != null)
                {

                    Exit();
                }
            }
        }

        private void ProcessingResponse(string message) 
        {
            try
            {
                string[] mass = message.Split(' ');
                if (mass[0].Equals($"ход"))
                {
                    Player player = players.Find(x => x.Name.Equals(mass[1]));
                    if (player==thisPlayer)
                    {
                        if (isNewRound)
                        {
                            form.Invoke(new MethodInvoker(form.ShowBetPanel));
                        }
                        else
                        {
                            form.Invoke(new MethodInvoker(form.ShowBetAndTrustPanel));
                        }
                        
                    }
                    isNewRound = false;
                    form.Invoke(new UpdateForm<Player>(form.ShowWhoseTurn), player);
                }
                else if (mass[0].Equals("ставка"))
                {
                    Player player;
                    if (mass[1].Equals(thisPlayer.Name))
                    {
                        player = thisPlayer;
                    }
                    else
                    {
                        player = players.Find(x => x.Name.Equals(mass[1]));
                    }

                    Bet bet = new Bet() { betType = BetType.bet, CountOfDices = Int32.Parse(mass[2]), DiceValue = Int32.Parse(mass[3]) };

                    form.Invoke(new SendDataToForm<object>(form.ShowBetNotification), new List<object>() { bet, player });
                }
                else if (mass[0].Equals($"выбыл"))
                {
                    Player player = players.Find(x => x.Name.Equals(mass[1]));
                    Label label = players.Find(x => x.Name.Equals(mass[1])).NameLabel;
                    if (mass[1].Equals(thisPlayer.Name))
                    {
                        Alive = false;
                    }
                    else
                    {
                        opponents.Remove(player);
                    }
                    form.Invoke(new UpdateForm<Label>(form.SetLabelColorToRed), label);
                }
                else if (mass[0].Equals("верю"))
                {
                    Player player;
                    if (mass[1].Equals(thisPlayer.Name))
                    {
                        player = thisPlayer;
                    }
                    else
                    {
                        player = players.Find(x => x.Name.Equals(mass[1]));
                    }
                    Bet bet = new Bet() { betType = BetType.trust };

                    form.Invoke(new SendDataToForm<object>(form.ShowBetNotification), new List<object>() { bet, player });
                }
                else if (mass[0].Equals("не"))//не верю
                {
                    Player player;
                    if (mass[2].Equals(thisPlayer.Name))
                    {
                        player = thisPlayer;
                    }
                    else
                    {
                        player = players.Find(x => x.Name.Equals(mass[2]));
                    }
                    Bet bet = new Bet() { betType = BetType.notTrust };

                    form.Invoke(new SendDataToForm<object>(form.ShowBetNotification), new List<object>() { bet, player });
                }
                else if (mass[0].Equals("кости"))
                {
                    for (int i = 1; i < mass.Length; i++)
                    {
                        if (thisPlayer.Name.Equals(mass[i]))
                        {
                            i += thisPlayer.dices.Count;
                        }
                        else
                        {
                            Player p = opponents.Find(x => x.Name.Equals(mass[i]));
                            for (int j = 0; j < p.dices.Count; j++)
                            {
                                i++;
                                p.dices[j].Num = Int32.Parse(mass[i]);
                            }
                        }
                    }
                    string log = "кости игроков:";
                    //log += dices.Where(x => x!=null);
                    foreach (var p in opponents)
                    {
                        log += " " + p;
                        foreach (var d in p.dices)
                        {
                            log += " " + d.Num;
                        }
                    }
                    LogMessage(log);

                    form.Invoke(new SendDataToForm<Player>(form.ShowPlayersDices), opponents);
                    Thread.Sleep(4000);
                }
                else if (mass[0].Equals("твои"))
                {
                    try
                    {
                        for (int i = 2; i < mass.Length; i++)
                        {
                            thisPlayer.dices[i - 2].Num = Int32.Parse(mass[i]);
                        }
                        form.Invoke(new UpdateForm<Player>(form.ChangeDicesOnTable), thisPlayer);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    string log = "твои кости:";
                    //log += dices.Where(x => x!=null);
                    foreach (var d in thisPlayer.dices)
                    {
                        log += d;
                    }
                    LogMessage(log);

                    //form.Invoke(new SendDataToForm<Dice>(form.ChangeDicesOnTable), thisPlayer.dices);
                }
                else if (mass[0].Equals("проиграл"))
                {
                    Player player = players.Find(x => x.Name.Equals(mass[1]));
                    player.dices.RemoveAt(player.dices.Count - 1);
                    form.Invoke(new UpdateForm<Player>(form.RemovePlayersDice), player);
                }
                else if (mass[0].Equals("количество"))
                {
                    int n = Int32.Parse(mass[2]);
                    string[] arr = new string[n];
                    Array.Copy(mass, 3, arr, 0, n);
                    SetPlayersOnTable(n, arr);

                    form.Invoke(new SendDataToForm<Player>(form.SetPlayersNames), players);
                }
                else if (mass[0].Equals("игра") || mass[0].Equals("новый"))
                {
                    isNewRound = true;
                    form.Invoke(new MethodInvoker(form.HidePlayersDices));
                }
                else if (mass[0].Equals("выиграл"))
                {
                    form.Invoke(new UpdateForm<string>(form.ShowWinner), $"Поздравляем {mass[1]}!");
                    if (mass[1].Equals(thisPlayer.Name))
                    {
                        Alive = false;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(message);
            }

        }

        private void SetPlayersOnTable(int countOfPlayers, string[] playersNames) //добавляем игроков в правильном порядке   || TODO переписать функцию нормально
        {
            if (countOfPlayers == 2)
            {
                Player p1 = new Player();
                p1.location = Location.top;
                foreach(var p in playersNames)
                {
                    if (p != form.playerName)
                    {
                        p1.Name = p;
                    }
                }
                opponents.Add(p1);
            }
            else if(countOfPlayers == 3)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (playersNames[i].Equals(form.playerName))
                    {
                        i++;
                        opponents.Add(new Player() { Name = playersNames[i % 3], location = Location.left });
                        i++;
                        opponents.Add(new Player() { Name = playersNames[i % 3], location = Location.top });
                    }
                }
            }
            else if(countOfPlayers == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (playersNames[i].Equals(form.playerName))
                    {
                        i++;
                        opponents.Add(new Player() { Name = playersNames[i % 4], location = Location.left });
                        i++;
                        opponents.Add(new Player() { Name = playersNames[i % 4], location = Location.top });
                        i++;
                        opponents.Add(new Player() { Name = playersNames[i % 4], location = Location.right });
                    }
                }
            }

            players.AddRange(opponents);

            string log = "Добавление игроков на стол";
            foreach(var p in opponents)
            {
                log += p;
            }
            LogMessage(log);
        }

        private void LogMessage(string mes)
        {
            form.Invoke(new UpdateForm<string>(form.GetLog), mes);
        }

        public void Exit()
        {
            Alive = false;
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }



        
    }
}
