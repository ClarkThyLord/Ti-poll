using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    class Client : User
    {
        public int ID { get; }
        public bool Registered = true;
        public string Nombre { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public List<Survey> surveys = new List<Survey>();
    }
}
