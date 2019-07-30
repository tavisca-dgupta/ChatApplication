using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    public class ConnectionManager
    {
        IPEndPoint localEndPoint;
        public Socket GetConnection(string address)
        {
            //IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
             
            IPAddress ipAddr = IPAddress.Parse(address);
            localEndPoint = new IPEndPoint(ipAddr, 11111);
            return new Socket(ipAddr.AddressFamily,
                 SocketType.Stream, ProtocolType.Tcp);
        }

        public void ConnectSender(Socket sender)
        {
            sender.Connect(localEndPoint);
        }

        public void BindSocket(Socket listenerSocket)
        {
             listenerSocket.Bind(localEndPoint);
        }

        public void CloseConnection(Socket socket)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        
    }
}
