using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    class Survey
    {
        public int ID { get; }
        public bool Public = false;
        public List<Profile> profiles = new List<Profile>();

        public Survey (int ID, bool Public, List<Profile> profiles)
        {
            this.ID = ID;
            this.Public = Public;
            this.profiles = profiles;
        }
    }
}
