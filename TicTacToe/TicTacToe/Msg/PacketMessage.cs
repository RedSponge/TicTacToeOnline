using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Msg
{
    public class PacketMessage
    {
        public readonly Player player;
        public readonly GameAction action;
        public readonly byte[] data;

        public PacketMessage(Player player, GameAction action, byte[] data)
        {
            this.player = player;
            this.action = action;
            this.data = data;
        }

        public PacketMessage(Player player, GameAction action, int data)
        {
            this.player = player;
            this.action = action;
            byte[] dt = new byte[Constants.DATA_LENGTH];
            byte[] num = BitConverter.GetBytes(data);
            for(int i = 0; i < 4; i++)
            {
                dt[Constants.DATA_LENGTH - (i + 1)] = num[4-(i+1)];
            }
            Console.WriteLine("[" + string.Join(",", dt) + "]");
            this.data = dt;
        }
    }
}
