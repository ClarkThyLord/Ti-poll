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
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public List<Survey> surveys = new List<Survey>();

        public Client (int ID, string Name, int Age, string Username, string Password, int Points, Dictionary<string, dynamic> Background, List<Survey> surveys) : base(true, Age, Background)
        {
            this.ID = ID;
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.Points = Points;
        }
    }
}
