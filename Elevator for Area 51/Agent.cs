using System;
using System.Threading;

namespace Elevator_for_Area_51
{
    class Agent
    {
        enum NotInElevator { Walk,EnterElevator,WorkOver};
        enum InElevator { PressButton, Arrive, GoOut };

        Random random = new Random();

        public string Name { get; set; }
        public int Rank { get; set; }
        public int SpawnFloor { get; set; }
        public int NewFloor { get; set; }
        public Facility Facility { get; set; }

        private NotInElevator NotInElevatorRandomActivity()
        {
            int n = random.Next(10);
            if (n < 3) return NotInElevator.Walk;
            if (n < 7) return NotInElevator.EnterElevator;
            {
                InElevatorRandomActivity(agents);
            }
            return NotInElevator.WorkOver;
        }

        private InElevator InElevatorRandomActivity(Agent agen)
        {
            Console.WriteLine($"{Name} is entering the elevator\n");
            return InElevator.PressButton;
            Console.WriteLine($"{Name} has pressed a button.\n");
            Thread.Sleep(1000);
            //alot of stuff needed
            CurrentElvFloor();
            ChangeFloor();
            //elevator stuff
            return InElevator.Arrive;
            Console.WriteLine("The Elevator has arrived at the chosen floor\n");
            Console.WriteLine("The agent is being scanned for Rank\n");
            
            if (agen.Rank < agen.NewFloor)
            {
                Console.WriteLine("This Agent does not have the rank to enter\n");
                return InElevator.PressButton;
            }
            return InElevator.GoOut;
            Console.WriteLine("The agent has arrived at the floor\n");
            int n = random.Next(10);
                if (n < 3) 
            {
                bool InFacility = false;
            }
            Console.WriteLine("Ägent's shift is over\n");
            WalkOut();
        }

        private void WalkOut()
        {
            Console.WriteLine($"{Name} is walking around.\n");
            Thread.Sleep(300);
        }

        
        public void Start()
        {
            WalkOut();
            bool InFacility = true;
            while (InFacility)
            {
                NotInElevatorRandomActivity();
            }
                Console.WriteLine($"{Name} is going back home.\n");
            Facility.Leave(this);
        }
        public Agent(string name)
        {
            Name = name;
        }
    }
}