using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Msg;

namespace TicTacToe
{
    public class MessageEncoder
    {

        public static byte[] Encode(PacketMessage message)
        {
            byte[] result = new byte[Constants.MESSAGE_LENGTH];
            result[Constants.PLAYER_OFFSET] = (byte)message.player;
            result[Constants.ACTION_OFFSET] = (byte)message.action;

            for(int i = 0; i < Constants.DATA_LENGTH; i++)
            {
                result[i + Constants.DATA_OFFSET] = message.data[i];
            }
            return result;
        }
    }
}
