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

        public struct Background
        {
            public double Income;
            public string Gender;
            public string Country;
            public string Ethnicity;
            public string Sexuality;
            public string Relationship;

            public Background(double Income=-1, string Gender="", string Country="", string Ethnicity="", string Sexuality="", string Relationship="")
            {
                this.Income = Income;
                this.Gender = Gender;
                this.Country = Country;
                this.Ethnicity = Ethnicity;
                this.Sexuality = Sexuality;
                this.Relationship = Relationship;
            }
        }
        public Background Backgrounds = new Background();

        public List<int> Surveys = new List<int>();

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

        public User(string Name, string Nickname, int Age, string Password, bool Registered, Background Background) : this(Name, Nickname, Age, Password, Registered)
        {
            this.Backgrounds = Background;
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
        public User(int ID, string Name, string Nickname, int Age, string Password, bool Registered, Background Background) : this(ID, Name, Nickname, Age, Password, Registered)
        {
            this.Backgrounds = Background;
        }
    }
}
