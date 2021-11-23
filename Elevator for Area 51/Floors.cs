using System;
using System.Collections.Generic;
using System.Text;

namespace Elevator_for_Area_51
{
    class Floors
    {
        public string Floor { get; set; }
        public int RankNeeded { get; set; }
        public Floors(string floor, int rankNeeded)
        {
            Floor = floor;
            RankNeeded = rankNeeded;
        }
    }
}
