﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    public class User
    {
        public string Name;
        public int Score;
        public int sizeForm;
        public User(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
