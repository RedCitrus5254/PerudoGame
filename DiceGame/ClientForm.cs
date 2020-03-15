using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceGameLibrary;
namespace DiceGame
{
    public partial class ClientForm : Form
    {
        private string playerName;
        private int currentCountOfDices = 1;
        private int currentDiceValue = 1;

        List<Bitmap> diceImages = new List<Bitmap>() { Resource1._1_dots_removebg_preview, Resource1._2_dots_removebg_preview, Resource1._3_dots_removebg_preview,
            Resource1._4_dots_removebg_preview, Resource1._5_dots_removebg_preview, Resource1._6_dots_removebg_preview };

        List<Player> opponents = new List<Player>();

        Client client;

        Dices dices = new Dices();

        public ClientForm(string name, int port)
        {
            InitializeComponent();

            playerName = name;
            player1NameLabel.Text = name;

            //client = new Client(this);
            //client.localPort = port;
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

        private void ChangeDicesOnTable()
        {

        }

        private void CloseForm(object sender, EventArgs e)
        {
            //if (client.Alive)
            //{
            //    this.Invoke(new MethodInvoker(() =>
            //    {
            //        client.Exit();
            //    }));
            //}
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

            currentDiceValuePictureBox.Image = diceImages[currentDiceValue-1];
            

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
        }

        private void NoTrustButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("не верю");
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            readyButton.BackColor = Color.Yellow;
            readyButton.Text = "Ждём";
            readyButton.Enabled = false;

            client.SendMessage($"{playerName} готов");
        }
        public void ShowWhoseTurn(string name) //мб сделать не по имени, а по id
        {
            foreach(var o in opponents)
            {
                if (o.Name.Equals(name))
                {
                    o.NameLabel.ForeColor = Color.Green;

                    if (o.Name.Equals(playerName))
                    {
                        ShowBetAndTrustPanel();
                    }
                }
            }
            
        }

        private void MakeBetButton_Click(object sender, EventArgs e)
        {
            client.SendMessage($"ставка {currentCountOfDices} {currentDiceValue}");
            HideBetAndTrustPanels();
        }
    }
}
