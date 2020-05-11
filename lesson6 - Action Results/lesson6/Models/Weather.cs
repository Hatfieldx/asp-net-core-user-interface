
using System;

namespace lesson6.Models
{
    [Serializable]
    public class Weather : IWeather
    {
        public string Region { get; set; }
        public int Temp { get; set; }
    }
}
