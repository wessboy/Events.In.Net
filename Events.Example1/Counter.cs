using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Example1;

     public class Counter
    {
            private int threshold;
            private int total;
    public event EventHandler ThresholdReached; 


            public Counter(int passedThreshold)
            {
               threshold = passedThreshold;
            }
           
             public void Add(int x)
                {
                        total += x;
                        if(total >= threshold) 
                         {
                             ThresholdReached?.Invoke(this, EventArgs.Empty);
                         }
                }
    }

