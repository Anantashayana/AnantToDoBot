﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnantToDoBot
{
    public class User
    {
        public List<string> TasksList = new List<string>();
        public static string UserID { get; set; }
    }
}
