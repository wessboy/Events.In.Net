﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Example3;

     public class ThresholdReachedEventArgs : EventArgs 
    {
        public int Threshold {  get; set; } 
        public DateTime TimeReached { get; set; }   
    }

