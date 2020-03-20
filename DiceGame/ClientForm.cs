using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceGameLibrary;
namespace DiceGame
{
    public partial class ClientForm : Form
    {
        public string playerName { get; set; }
        private int currentCountOfDices = 1;
        private int currentDiceValue = 2;

        List<Bitmap> diceImages = new List<Bitmap>() { Resource1._1_dots_removebg_preview, Resource1._2_dots_removebg_preview, Resource1._3_dots_removebg_preview,
            Resource1._4_dots_removebg_preview, Resource1._5_dots_removebg_preview, Resource1._6_dots_removebg_preview };

        List<Player> opponents = new List<Player>();

        Client client;

        List<PictureBox> dicePictureBoxes;

        public ClientForm(string name, int port)
        {
            InitializeComponent();

            dicePictureBoxes = new List<PictureBox>() { firstDicePictureBox, secondDicePictureBox, thirdDicePictureBox, fourthDicePictureBox, fifthDicePictureBox };

            playerName = name;
            player1NameLabel.Text = name;

            client = new Client(this, port);
        }

        public void HidePlayersDices()
        {
            currentCountOfDicesLabel.Text = 1.ToString();
            currentCountOfDices = 1;
            currentDiceValuePictureBox.Image = diceImages[1];
            currentDiceValue = 2;

            readyButton.Hide();

            topPlayerPanel.Hide();
            leftPlayerPanel.Hide();
            rightPlayerPanel.Hide();
        }
        public void HideBetAndTrustPanels()
        {
            trustPanel.Hide();
            betPanel.Hide();
        }
        public void ShowBetAndTrustPanel()
        {
            trustPanel.Show();
            betPanel.Show();
        }

        public void RemovePlayersDice(Player player)
        {
            Control control = player.dicePanel.Controls[player.dicePanel.Controls.Count - 1]; 

            //player.dicePanel.Controls.Remove(control);
            control.Dispose();
        }
        public void ChangeDicesOnTable(Player player)
        {
            for(int i = 0; i < player.dices.Count(); i++)
            {
                dicePictureBoxes[i].Image = diceImages[player.dices[i].Num - 1];
            }
        }

        public void SetPlayersNames(List<Player> players)
        {
            foreach(var p in players)
            {
                if(p.location == DiceGame.Location.left)
                {
                    player2NameLabel.Text = p.Name;
                    p.NameLabel = player2NameLabel;
                    p.dicePanel = leftPlayerPanel;
                }
                else if(p.location == DiceGame.Location.top)
                {
                    player3NameLabel.Text = p.Name;
                    p.NameLabel = player3NameLabel;
                    p.dicePanel = topPlayerPanel;
                }
                else if(p.location == DiceGame.Location.right)
                {
                    player4NameLabel.Text = p.Name;
                    p.NameLabel = player4NameLabel;
                    p.dicePanel = rightPlayerPanel;
                }
                else if(p.location == DiceGame.Location.bottom)
                {
                    p.NameLabel = player1NameLabel;
                    p.dicePanel = dicesPanel;
                }

                p.NameLabel.Show();
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (client.Alive)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    client.Exit();
                }));
            }
            Form ifrm = Application.OpenForms[0];
            ifrm.Close();
        }

        private void IncreaseDiceCountButton_Click(object sender, EventArgs e)
        {
            currentCountOfDices += 1;
            currentCountOfDicesLabel.Text = currentCountOfDices.ToString();
        }

        private void DecreaseDiceCountButton_Click(object sender, EventArgs e)
        {
            currentCountOfDices -= 1;
            currentCountOfDicesLabel.Text = currentCountOfDices.ToString();
        }

        private void IncreaseDiceValueButton_Click(object sender, EventArgs e)
        {
            if (currentDiceValue < 6)
            {
                currentDiceValue += 1;
            }
            else
            {
                currentDiceValue = 1;
            }

            currentDiceValuePictureBox.Image = diceImages[currentDiceValue - 1];
        }

        private void DecreaseDiceValueButton_Click(object sender, EventArgs e)
        {
            if (currentDiceValue > 1)
            {
                currentDiceValue -= 1;
            }
            else
            {
                currentDiceValue = 6;
            }

            currentDiceValuePictureBox.Image = diceImages[currentDiceValue - 1];
        }

        private void TrustButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("верю");
            HideBetAndTrustPanels();
        }

        private void NoTrustButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("не верю");
            HideBetAndTrustPanels();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            readyButton.BackColor = Color.Yellow;
            readyButton.Text = "Ждём";
            readyButton.Enabled = false;

            client.SendMessage($"готов {playerName}");
        }

        public void SetLabelColorToRed(Label label)
        {
            label.ForeColor = Color.Red;
        }
        public void ShowWhoseTurn(Player player) 
        {
            foreach (var c in this.Controls.OfType<Label>())
            {
                if(c.ForeColor == Color.Green)
                    c.ForeColor = Color.Black;
            }
            player.NameLabel.ForeColor = Color.Green;
            
        }
        public void ShowBetNotification(List<object> list)
        {
            NotificationBetPanel.Hide(); //сткрываем текст оповещения ставка
            trustNotificationLabel.Hide(); //сткрываем текст оповещения верю/не верю 

            Bet bet = (Bet)list[0];
            Player player = (Player)list[1];
            Control notification;
            if (bet.betType == BetType.bet)
            {
                currentCountOfDices = bet.CountOfDices;
                currentCountOfDicesLabel.Text = currentCountOfDices.ToString();
                currentDiceValue = bet.DiceValue;
                currentDiceValuePictureBox.Image = diceImages[currentDiceValue - 1];

                CountOfDicesLabel.Text = bet.CountOfDices.ToString();
                diceValuePictureBox.Image = diceImages[bet.DiceValue - 1];
                notification = NotificationBetPanel;

            }
            else if(bet.betType == BetType.notTrust)
            {
                trustNotificationLabel.Text = "Не верю";
                notification = trustNotificationLabel;

            }
            else 
            {
                trustNotificationLabel.Text = "Верю";
                notification = trustNotificationLabel;

            }

            if (player.location == DiceGame.Location.right)
            {
                Point p = new Point(player.NameLabel.Location.X - notification.Width - 5, player.NameLabel.Location.Y);
                notification.Location = p;
            }
            else if(player.location == DiceGame.Location.top)
            {
                Point p = new Point(player.NameLabel.Location.X , player.NameLabel.Location.Y + player.NameLabel.Height + 5);
                notification.Location = p;
            }
            else if(player.location == DiceGame.Location.left)
            {
                Point p = new Point(player.NameLabel.Location.X + player.NameLabel.Width + 5, player.NameLabel.Location.Y);
                notification.Location = p;
            }
            else if(player.location == DiceGame.Location.bottom)
            {
                Point p = new Point(player.NameLabel.Location.X, player.NameLabel.Location.Y - notification.Height - 5);
                notification.Location = p;
            }
            notification.Show();

        }

        public void ShowPlayersDices(List<Player> players)
        {
            foreach(var p in players)
            {
                for(int i = 0; i < p.dices.Count; i++)
                {
                    ((PictureBox)p.dicePanel.Controls[i]).Image = diceImages[p.dices[i].Num - 1];
                }
            }

            foreach (var p in players)
            {
                if (p.location == DiceGame.Location.top)
                {
                    topPlayerPanel.Show();
                }
                else if (p.location == DiceGame.Location.left)
                {
                    leftPlayerPanel.Show();
                }
                else if (p.location == DiceGame.Location.right)
                {
                    rightPlayerPanel.Show();
                }
            }
        }

        

        private void MakeBetButton_Click(object sender, EventArgs e)
        {
            client.SendMessage($"ставка {currentCountOfDices} {currentDiceValue}");
            HideBetAndTrustPanels();
        }

        public void GetLog(string mes)
        {
            logLabel.Text = $"{logLabel.Text}/n {mes}";
        }
    }
}
