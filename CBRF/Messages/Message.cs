using System.Collections;
using CBRF.Interfaces;

namespace CBRF.Messages
{
    sealed public class Message : IMessage
    {
        public Message(string str)
        {
            Str = str;
        }
        public string Str { get; set; }
    }
}
