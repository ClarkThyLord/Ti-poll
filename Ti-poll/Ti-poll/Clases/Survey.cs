﻿using System;
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
    }
}