using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Elevator_for_Area_51
{
    class Elevator
    {
        int floorCount = 0;
        FloorsList floorList = new FloorsList();
        List<Floors> floors;
        int CurrentFloor { get; set; }
        int NewFloor { get; set; }

        public Elevator(int currentFloor, int newFloor, int personLimit)
        {
            floors = floorList.GetFloor();
            CurrentFloor = currentFloor;
            NewFloor = newFloor;
        }

        public void CurrentElvFloor(List<Agent> agent)
        {

            if (floorCount == 0)
            {
                Console.WriteLine("The elevator is on floor {0}\n", floors[agent[0].SpawnFloor].Floor);
                CurrentFloor = agent[0].NewFloor;
                floorCount++;
            }
            else
            {
                Console.WriteLine("The elevator is on floor: {0}\n", floors[CurrentFloor].Floor);
            }

        }
        public void ChangeFloor(List<Agent> agent)
        {
            NewFloor = agent[0].NewFloor;
            Console.WriteLine("The elevator is traveling from {0} to {1}\n", floors[agent[0].SpawnFloor].Floor,
              floors[agent[0].NewFloor].Floor);
            CurrentFloor = NewFloor;
        }
    }
}
