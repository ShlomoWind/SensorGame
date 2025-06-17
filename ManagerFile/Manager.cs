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
            while (!this.Agent.IsRevealed())
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("Enter sensor type to attach: ");
                string SensorInput = Console.ReadLine();
                Sensor sensor = new Sensor(SensorInput);
                sensor.Activate(this.Agent.AttachedSensors);
                int MatchesNumber = this.Agent.Investigation();
                Console.WriteLine($"\nNumber of matches so far: {MatchesNumber}/3");
            }
            Console.WriteLine("\n\nAgent is revealed!");
            Console.WriteLine("***********************\n");
        }
    }
}