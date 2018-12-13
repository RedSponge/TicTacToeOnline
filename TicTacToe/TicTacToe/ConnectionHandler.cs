using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Msg;

namespace TicTacToe
{
    public class ConnectionHandler
    {
        private string ip;
        private int port;

        private TcpClient connection;

        private BinaryWriter bWriter;
        private BinaryReader bReader;

        private bool listening;
        private Thread listenThread;

        private Action<PacketMessage> messageHandler;

        public ConnectionHandler(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }
        public void Connect()
        {
            connection = new TcpClient(ip, port);

            bWriter = new BinaryWriter(connection.GetStream());
            bReader = new BinaryReader(connection.GetStream());

            listening = true;

            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.Start();
        }


        public void SetMessageHandler(Action<PacketMessage> handler)
        {
            this.messageHandler = handler;
        }
        public void Send(PacketMessage message)
        {
            bWriter.Write(MessageEncoder.Encode(message));
            Console.WriteLine("[" + string.Join(",", MessageEncoder.Encode(message)) + "]");
            bWriter.Flush();
        }

        public void Close()
        {
            connection.Close();
            bWriter.Close();
            bReader.Close();

            listening = false;
            listenThread.Join();
        }

        public void Listen()
        {
            while(listening)
            {
                byte[] data = bReader.ReadBytes(Constants.MESSAGE_LENGTH);
                Console.WriteLine("[NETWORK] Got Packet!");
                if(messageHandler != null)
                {
                    messageHandler.Invoke(MessageDecoder.Decode(data));
                    Console.WriteLine("[NETWORK] Passed Packet to Handler");
                }
                else
                {
                    Console.WriteLine("[NETWORK] No Handler Set! Ignoring Packet!");
                }
            }
        }
    }
}
