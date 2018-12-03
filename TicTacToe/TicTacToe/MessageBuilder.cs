using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class MessageBuilder
    {
        public static int Build(Player player, GameAction action, int data)
        {
            int result = (int)player;
            result <<= 8;
            result += action.id;

            result <<= Constants.DATA_SIZE * 8;
            result += data;
            return result;
        }

        public enum Player
        {
            X,
            Y
        }


        public class GameAction
        {
            public static readonly GameAction QUIT = new GameAction(0);
            public static readonly GameAction SET_NAME = new GameAction(1);
            public static readonly GameAction SET_POSITION = new GameAction(2);


            public readonly byte id;

            private GameAction(byte id)
            {
                this.id = id;
            }
        }

        public class DataGen
        {
            public static int GetASCIIName(string name)
            {
                if(name.Length > 16 || name.Length == 0)
                {
                    throw new Exception("Name must be 1 to 16 characters long!");
                }
                return BitConverter.ToInt32(Encoding.ASCII.GetBytes(name), 0);
            }
        }
    }
}
