﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalExercise
{
    public class MyOptional
    {
        public int Opt(int a, int b = 0)
        {
            return a + b;
        }
    }
}