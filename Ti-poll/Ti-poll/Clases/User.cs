using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll
{
    class User
    {
        public bool Registered { get; set; }
        public int Age { get; set; }
        public Dictionary<string, dynamic> Background = new Dictionary<string, dynamic>();

        public User(bool Registered, int Age, Dictionary<string, dynamic> Background)
        {
            this.Registered = Registered;
            this.Age = Age;
            this.Background = Background;
        }
    }
}
