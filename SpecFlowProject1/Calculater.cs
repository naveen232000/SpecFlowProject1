﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class Calculater
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        public int Add() { 
        int res=Fnum+Snum;
            return res;
        }
    }
}
