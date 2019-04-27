using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    public class Survey
    {
        public int ID;
        public int[] Owners; // Array of ID(s) belonging to User(s)
        public string Name = "";
        public string Category = "";
        public bool Public = false;
        public int ViewsH = 0;
        public int ViewsM = 0;
        public List<int> profiles = new List<int>();

        public Survey()
        {
        }


        // TO CREATE
        public Survey(bool Public)
        {
            ID = Database.data.SurveyCount;
            this.Public = Public;
        }

        // TO LOAD
        [JsonConstructor]
        public Survey (int ID, bool Public, List<int> profiles)
        {
            this.ID = ID;
            this.profiles = profiles;
        }
    }
}
