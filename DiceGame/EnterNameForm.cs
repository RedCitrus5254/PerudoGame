using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class EnterNameForm : Form
    {
        public EnterNameForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ClientForm clientForm = new ClientForm(nameTextBox.Text, Int32.Parse(portTextBox.Text));
            clientForm.Show();
            

        }
    }
}
