using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    public class Sender
    {
        private static ConnectionManager _connectionManager;
        public Sender(ConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public void StartSending()
        {
            Socket sender = _connectionManager.GetConnection("ipaddress");
            _connectionManager.ConnectSender(sender);
            // he display madhe ala pahije
            //chalel ithe asla tari
            Console.WriteLine("Socket connected to -> {0} ",
                          sender.RemoteEndPoint.ToString());

        }
    }
}
