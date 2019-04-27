using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    public class Profile
    {
        public int ID { get; }
        public bool Public = false;
        public enum Types { Image, Text}
        public Types @Type;
        public Dictionary<string, dynamic> Data = new Dictionary<string, dynamic>();

        public Profile (int ID, bool Public, Types @Type, Dictionary<string, dynamic> Data)
        {
            this.ID = ID;
            this.Public = Public;
            this.@Type = @Type;
            this.Data = Data;
        }
    }
}
