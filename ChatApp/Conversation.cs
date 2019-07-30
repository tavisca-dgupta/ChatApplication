using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    public class Conversation
    {
        Display display;
        Socket socket;
        public Conversation(Display display,Socket socket)
        {
            this.display = display;
            this.socket = socket;

        }
        public void SendMessage(string message)
        {
            byte[] messageSent = Encoding.ASCII.GetBytes(message);
            socket.Send(messageSent);
            display.MyMessage(message);
        }

        public void ReceiveMessage(string message)
        {
            display.PeerMessage(message);
        }
    }
}
