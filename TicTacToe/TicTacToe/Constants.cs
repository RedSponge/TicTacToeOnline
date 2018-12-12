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
        public static readonly string IP = "localhost";
        
        public const int PLAYER_SIZE = 1;
        public const int ACTION_SIZE = 1;
        public const int DATA_SIZE = 16;
        public const int MESSAGE_SIZE = PLAYER_SIZE + ACTION_SIZE + DATA_SIZE;

    }
}
