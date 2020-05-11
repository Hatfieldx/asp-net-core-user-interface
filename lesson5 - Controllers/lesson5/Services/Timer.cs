using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson5.Services
{
    public class Timer : ITimer
    {
        public string GetCurrentDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
