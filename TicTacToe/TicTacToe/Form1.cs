using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ConnectionHandler connection;

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new ConnectionHandler(Constants.IP, Constants.PORT);
            Console.WriteLine(MessageBuilder.Build(MessageBuilder.Player.X, MessageBuilder.GameAction.SET_NAME, MessageBuilder.DataGen.GetASCIIName("Hello!")));
            connection.Send(MessageBuilder.Build(MessageBuilder.Player.X, MessageBuilder.GameAction.SET_NAME, MessageBuilder.DataGen.GetASCIIName("Hello!")));
            //connection.Close();
        }
    }
}
