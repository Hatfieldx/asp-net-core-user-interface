using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson6.Models
{
    public interface IWeather
    {
        public string Region { get; set; }
        int Temp { get; set; }
    }
}
