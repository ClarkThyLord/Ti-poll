using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    class Profile
    {
        public int ID { get; }
        public bool Public = false;
        public enum Types { Image, Text}
        public Types Type;
        public Dictionary<string, dynamic> Data = new Dictionary<string, dynamic>();

    }
}
