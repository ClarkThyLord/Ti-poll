using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    public class Survey
    {
        private int _id = 0;
        public int ID { get; }
        public bool Public = false;
        public List<Profile> profiles = new List<Profile>();

        public Survey(int ID, bool Public)
        {
            this.ID = _id;
            _id++;
            this.Public = Public;
        }

        public Survey (int ID, bool Public, List<Profile> profiles) : this(ID, Public)
        {
            this.ID = ID;
            this.profiles = profiles;
        }
    }
}
