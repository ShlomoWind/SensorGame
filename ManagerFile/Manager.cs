using SensorGame.AgwntFile;
using SensorGame.SensorFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.ManagerFile
{
    internal class Manager
    {
        private Agent Agent;
        public string AgentType { get; private set; }
        public Manager(string type)
        {
            this.AgentType = type;
            this.Agent = new Agent(AgentType);
        }
        public void StartGame()
        {
            Console.WriteLine("Game started! Agent rank: " + Agent.Rank);
            Console.WriteLine("=====");
            Console.WriteLine("Available sensor types: Light, Motion, Thermal, Audio, Signal, Magnetic, Pulse.");
            while (!this.Agent.IsRevealed())
            {
                Console.WriteLine("\n=================================================");
                Console.WriteLine("Enter sensor type to attach: ");
                string SensorInput = Console.ReadLine();
                Sensor sensor = SensorFactory.CreateSensor(SensorInput);
                if (sensor == null)
                {
                    Console.WriteLine("Invalid sensor type. Please try again.");
                    continue;
                }
                sensor.Activate(this.Agent.AttachedSensors);
                int MatchesNumber = this.Agent.Investigation();
                Console.WriteLine($"\nNumber of matches so far: {MatchesNumber}/3");
            }
            Console.WriteLine("\n\nAgent is revealed!");
            Console.WriteLine("***********************\n");
        }
    }
}