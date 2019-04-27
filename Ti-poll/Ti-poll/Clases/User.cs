using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ti_poll.Clases;

namespace Ti_poll
{
    public class User
    {
        public int ID { set; get; } = 0;
        public string Name = "";
        public string Nickname = "";
        public string Password = "";
        public int Age = 0;
        public bool Registered = false;
        public enum Backgrounds { Gender, Ethnicity, Income, Sexuality, Relationship, Country }
        public Dictionary<Backgrounds, dynamic> Background = new Dictionary<Backgrounds, dynamic>();

        // FOR CREATING
        public User(string Name, string Nickname, int Age, string Password, bool Registered)
        {
            ID = Database.data.UserCount;
            this.Name = Name;
            this.Nickname = Nickname;
            this.Age = Age;
            this.Password = Password;
            this.Registered = Registered;
        }

        public User(string Name, string Nickname, int Age, string Password, bool Registered, Dictionary<Backgrounds, dynamic> Background) : this(Name, Nickname, Age, Password, Registered)
        {
            this.Background = Background;
        }

        // FOR LOADING
        public User(int ID, string Name, string Nickname, int Age, string Password, bool Registered)
        {
            this.ID = ID;
            this.Name = Name;
            this.Nickname = Nickname;
            this.Age = Age;
            this.Password = Password;
            this.Registered = Registered;
        }

        [JsonConstructor]
        public User(int ID, string Name, string Nickname, int Age, string Password, bool Registered, Dictionary<Backgrounds, dynamic> Background) : this(ID, Name, Nickname, Age, Password, Registered)
        {
            this.Background = Background;
        }

        public User()
        {
        }
    }
}
