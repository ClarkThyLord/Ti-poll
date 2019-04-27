using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ti_poll.Clases
{
    public class Profile // PREGUNTA
    {
        public int ID;
        public int Views = 0;
        public string Question = "";
        public struct Response
        {
            int Owner; // If -1 then it's a anonymous entry
            bool Answer;

            public Response(int Owner, bool Answer)
            {
                this.Owner = Owner;
                this.Answer = Answer;
            }
        }
        public List<Response> Responses = new List<Response>();
        
        public string Image = null;

        public Profile() { }

        // FOR CREATION
        public Profile(string Question)
        {
            ID = Database.data.ProfileCount;
            this.Question = Question;
        }

        public Profile(string Question, string Image) : this(Question)
        {
            this.Image = Image;
        }

        public Profile(string Question, string Image, List<Response> Responses) : this(Question, Image)
        {
            this.Responses = Responses;
        }

        // FOR LOADING
        public Profile(int ID, string Question)
        {
            this.ID = ID;
            this.Question = Question;
        }

        public Profile(int ID, string Question, string Image) : this(ID, Question)
        {
            this.Image = Image;
        }

        [JsonConstructor]
        public Profile(int ID, string Question, string Image, List<Response> Responses) : this(ID, Question, Image)
        {
            this.Responses = Responses;
        }
    }
}
