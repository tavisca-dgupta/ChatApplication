using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    class Peer
    {
        //conversation object 

        private Conversation _conversation;
        private Display _display;

        public Peer(Socket clientSocket)
        {
            _display = new Display();

            _conversation = new Conversation(_display, clientSocket);

        }

    }
}
