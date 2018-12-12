using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Msg
{
    public class Message
    {
        public readonly Player player;
        public readonly GameAction action;
        public readonly byte[] data;

        public Message(Player player, GameAction action, byte[] data)
        {
            this.player = player;
            this.action = action;
            this.data = data;
        }

        public Message(Player player, GameAction action, int data)
        {
            byte[] dt = new byte[Constants.DATA_SIZE];
            byte[] num = BitConverter.GetBytes(data);
            Console.WriteLine("[" + string.Join(",", num) + "]");
        }
    }
}
