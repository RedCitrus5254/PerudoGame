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

        public delegate void UpdateForm(string str);
        

        ClientForm form;

        public bool Alive { get; set; } = false; // будет ли работать поток для приема

        public Client(ClientForm form1)
        {
            form = form1;
            EndPoint localPoint = new IPEndPoint(IPAddress.Parse(localAddress), localPort);
            socket.Bind(localPoint);

            serverEndPoint = new IPEndPoint(IPAddress.Parse(remoteAddress), remotePort);

            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start();

            
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

                ProcessingResponse(message);
            }
            catch (ObjectDisposedException)
            {
                if (!Alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                socket.Close();
            }
        }

        private void ProcessingResponse(string message) //TODO
        {
            string[] mass = message.Split(' ');
            if (mass[0].Equals($"ход"))
            {
                form.Invoke(new UpdateForm(form.ShowWhoseTurn), mass[1]);
            }
            else if (mass[0].Equals("ставка"))
            {

            }
            else if(mass[0].Equals($"выбыл"))
            {

            }
            else if (mass[0].Equals("верю"))
            {

            }
            else if (mass[0].Equals("не"))//не верю
            {

            }
            else if (mass[0].Equals("кости"))
            {

            }
            else if (mass[0].Equals("твои"))
            {

            }

        }

        public void Exit()
        {
            Alive = false;
            //if (sender != null)
            //{
            //    sender.Close();
            //}
            //if (receiver != null)
            //{
            //    receiver.Close();
            //}
            if (socket != null)
            {
                socket.Close();
            }
        }



        
    }
}
