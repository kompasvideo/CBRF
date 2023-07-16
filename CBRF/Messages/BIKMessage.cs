using System.Collections;
using CBRF.Interfaces;

namespace CBRF.Messages
{
    sealed public class BIKMessage : IMessage
    {
        public BIKMessage(string str)
        {
            Str = str;
        }
        public string Str { get; set; }
    }
}
