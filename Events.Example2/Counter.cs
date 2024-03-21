﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Example2;

     public class Counter
    {
        private int threshold;
        private int totlal;
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;  

        public Counter(int passedThreshold)
        {
          threshold = passedThreshold;  
           
        }

        public void Add(int x)
        {
                totlal += x;
                if(totlal >= threshold) 
                { 
                   ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                   
                   args.Threshold = threshold;
                   args.TimeReached = DateTime.Now;
                   OnThresholdReached(args);

                }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e) 
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
          if(handler != null)
        {
            handler(this, e);
        }

        }


}

