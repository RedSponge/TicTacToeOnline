using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Msg;

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
            connection.Connect();
            connection.Send(new PacketMessage(Player.O, GameAction.SET_NAME, Encoding.ASCII.GetBytes("RadSpoon        ")));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
