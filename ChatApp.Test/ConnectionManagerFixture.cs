using System;
using System.Linq;
using Xunit;
using ChatApp;
using System.Net;
using System.Net.Sockets;

namespace ChatApp.Test
{
    public class ConnectionManagerFixture
    {
        [Fact]
        public void Test_Connection_Establish()
        {

            //Arrange
            ConnectionManager connectionManager = new ConnectionManager();

            //act
            IPAddress ipAddr = IPAddress.Parse(Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString());
            IPEndPoint expectedEndPoint = new IPEndPoint(ipAddr, 11111);
            Socket expectedSocket= new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //Assert
            var actualSocket = connectionManager.GetConnection(Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString());
            Assert.Equal(expectedSocket.GetType(), actualSocket.GetType());
        }

    }
}
