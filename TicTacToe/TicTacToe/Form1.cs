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
            new Msg.Message(Player.X, GameAction.SET_POSITION, 1024);
            //connection = new ConnectionHandler(Constants.IP, Constants.PORT);
            //connection.Send(new Msg.Message(Player.X, GameAction.SET_POSITION, 7));
            //connection.Close();
        }
    }
}
