using System;
using System.Collections.Generic;
using System.Text;

namespace Elevator_for_Area_51
{
    class FloorsList
    {
        List<Floors> floors = new List<Floors>();
        public FloorsList()
        {
            Floors G = new Floors("G", 0);
            Floors S = new Floors("S", 1);
            Floors T1 = new Floors("T1", 2);
            Floors T2 = new Floors("T2", 3);

            floors.Add(G);
            floors.Add(S);
            floors.Add(T1);
            floors.Add(T2);

        }

        public List<Floors> GetFloor()
        {
            return floors;
        }
    }
}
