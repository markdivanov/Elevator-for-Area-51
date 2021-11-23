using System;
using System.Collections.Generic;
using System.Threading;

namespace Elevator_for_Area_51
{
    class Program
    {
        static void Main(string[] args)
        {
            Facility Facility = new Facility();
            List<Thread> agentThread = new List<Thread>();
            Random random = new Random();
            for (int i = 1; i < 100; i++)
            {
                Agent agent = new Agent(i.ToString());
                int agentNum = random.Next(1, 4);
                agent.Rank = agentNum;

                var thread = new Thread(agent.Start);
                thread.Start();
                agentThread.Add(thread);
            }

            foreach (var t in agentThread) t.Join();
            Console.WriteLine("Eveyone is done with work");
            Console.ReadLine();
        }
    }
}