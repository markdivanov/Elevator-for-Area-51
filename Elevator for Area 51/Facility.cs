using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Elevator_for_Area_51
{
    class Facility
    {
        List<Agent> agents = new List<Agent>();
        Semaphore door = new Semaphore(10, 10);

        public void Enter(Agent agent)
        {
            door.WaitOne();
            lock (agents)
            {
                agents.Add(agent);
            }
        }

        public void Leave(Agent agent)
        {
            lock (agents)
            {
                agents.Remove(agent);
            }
            door.Release();
        }
    }
}
