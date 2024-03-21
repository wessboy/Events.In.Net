using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3;

     public interface IEventHandler<T> where T : class 
    {
    public event EventHandler<T> EventHandler; 
    }

