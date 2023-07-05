using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    internal class Quality
    {
        public string Name { get; private set; }
        public int Day { get; private set; }
        public int NumRoom { get; private set; }
        public Quality(string name, int day, int numRoom)
        {
            Name = name;
            Day = day;
            NumRoom = numRoom;
        }
    }
}
