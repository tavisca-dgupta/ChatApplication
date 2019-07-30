using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatApp
{
    public class Listener
    {
        private static ConnectionManager _connectionManager;
        //private static int _limit;
        //private static int _count;
        public Listener(ConnectionManager connectionManager)
        {
            //_limit = 10;
            //_count = 0;
            _connectionManager = connectionManager;
        }

        public void StartListening()
        { 
            Socket listenerSocket = _connectionManager.GetConnection("ipaddress");
            _connectionManager.BindSocket(listenerSocket);
            listenerSocket.Listen(1);

            Console.WriteLine("Waiting for connection ... ");
            Socket clientSocket = listenerSocket.Accept();

            //while (_count<_limit)
            //{
            //    Console.WriteLine("Waiting for connection ... ");
            //    Socket clientSocket = listenerSocket.Accept();

            //    ThreadPool.QueueUserWorkItem(_ =>
            //   {
            //       Peer peer = new Peer(clientSocket);

            //   });


        }
    }
    }
}
