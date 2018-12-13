using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Msg;

namespace TicTacToe
{
    public class MessageDecoder
    {

        public static PacketMessage Decode(byte[] data)
        {
            Player player = (Player)data[Constants.PLAYER_OFFSET];
            GameAction action = (GameAction)data[Constants.ACTION_OFFSET];
            byte[] dt = data.SubArray(Constants.DATA_OFFSET, Constants.DATA_LENGTH);
            return new PacketMessage(player, action, dt);
        }

    }
}
