using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    public class Client : User
    {
        private int _id = 0;
        public int ID { get; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public List<Survey> surveys = new List<Survey>();

        public Client (string Name, int Age, string Username, string Password, int Points=0) : base(true, Age)
        {
            this.ID = _id;
            _id++;
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.Points = Points;
        }

        public Client (int ID, string Name, int Age, string Username, string Password, int Points, Dictionary<User.Backgrounds, dynamic> Background, List<Survey> surveys) : this(Name, Age, Username, Password, Points)
        {
            this.ID = ID;
        }
    }
}
