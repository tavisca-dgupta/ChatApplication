using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp
{
    public class Display
    {
        public string userAlias { get; set; }
        public string peerAlias { get; set; }

        public void MyMessage(string message)
        {

            Console.WriteLine($"{userAlias}: {message}");
         
        }

        public void PeerMessage(string message)
        {

            Console.WriteLine($"{peerAlias}: {message}");
        }




























































    }
}
