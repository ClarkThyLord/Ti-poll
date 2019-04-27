using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ti_poll.Clases
{
    public class Profile
    {
        public int ID;
        public string Question = "";
        public struct Response
        {
            int Owner;
            bool Answer;

            public Response(int Owner, bool Answer)
            {
                this.Owner = Owner;
                this.Answer = Answer;
            }
        }
        public List<Response> Responses = new List<Response>();
        
        public Image Image = null;

        public Profile() { }

        // FOR CREATION
        public Profile(string Question)
        {
            ID = Database.data.ProfileCount;
            this.Question = Question;
        }

        public Profile(string Question, Image Image) : this(Question)
        {
            this.Image = Image;
        }

        public Profile(string Question, Image Image, List<Response> Responses) : this(Question, Image)
        {
            this.Responses = Responses;
        }

        // FOR LOADING
        public Profile(int ID, string Question)
        {
            this.ID = ID;
            this.Question = Question;
        }

        public Profile(int ID, string Question, Image Image) : this(ID, Question)
        {
            this.Image = Image;
        }

        [JsonConstructor]
        public Profile(int ID, string Question, Image Image, List<Response> Responses) : this(ID, Question, Image)
        {
            this.Responses = Responses;
        }
    }
}
