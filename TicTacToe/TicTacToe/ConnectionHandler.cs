using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ConnectionHandler
    {
        private string ip;
        private int port;

        private TcpClient connection;
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public ConnectionHandler(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }
        public void Connect()
        {
            connection = new TcpClient(ip, port);
            streamReader = new StreamReader(connection.GetStream());
            streamWriter = new StreamWriter(connection.GetStream());
        }

        public void Send(int data)
        {
            streamWriter.WriteLine(data);
            streamWriter.Flush();
        }

        public void Close()
        {
            streamWriter.Close();
            streamReader.Close();
            connection.Close();
        }



    }
}
