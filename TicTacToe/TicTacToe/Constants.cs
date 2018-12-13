using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Constants
    {
        public const int PORT = 36763;
        public static readonly string IP = "10.27.208.56"; //"10.27.208.56";
        
        public const int PLAYER_SIZE = 1;
        public const int PLAYER_OFFSET = 0;

        public const int ACTION_SIZE = 1;
        public const int ACTION_OFFSET = 1;

        public const int DATA_LENGTH = 16;
        public const int DATA_OFFSET = 2;

        public const int MESSAGE_LENGTH = PLAYER_SIZE + ACTION_SIZE + DATA_LENGTH;

    }
}
