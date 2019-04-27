using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll
{
    public class User
    {
        public bool Registered { get; set; }
        public int Age { get; set; }
        public enum Backgrounds { Gender, Enticity, Income, Sexuality, Relationship, Country }
        public Dictionary<Backgrounds, dynamic> Background = new Dictionary<Backgrounds, dynamic>();

        public User(bool Registered, int Age)
        {
            this.Registered = Registered;
            this.Age = Age;
        }

        public User(bool Registered, int Age, Dictionary<Backgrounds, dynamic> Background) : this(Registered, Age)
        {
            this.Background = Background;
        }
    }
}
