using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Msg;

namespace TicTacToe
{
    public class ConnectionHandler
    {
        private string ip;
        private int port;

        private TcpClient connection;

        public ConnectionHandler(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }
        public void Connect()
        {
            connection = new TcpClient(ip, port);
        }

        public void Send(Message message)
        {
            connection.GetStream().Write(MessageEncoder.Encode(message), (int)connection.GetStream().Position, Constants.MESSAGE_SIZE);
            connection.GetStream().Flush();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
