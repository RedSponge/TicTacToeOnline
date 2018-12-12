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

        public static byte[] Encode(Message message)
        {
            byte[] result = new byte[Constants.MESSAGE_SIZE];
            result[0] = (byte)message.player;
            result[1] = (byte)message.action;

            for(int i = 0; i < Constants.DATA_SIZE; i++)
            {
                result[i + 2] = message.data[i];
            }
            return result;
        }
    }
}
