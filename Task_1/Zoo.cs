﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Zoo
    {
        public List<Animal> Animals {  get; set; }
        public Zoo ()
        {
            Animals = new List<Animal> ();
        }
    }
}
