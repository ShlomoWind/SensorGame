using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.AgwntFile
{
    internal class Agent
    {
        private static Random random = new Random();
        public string Rank { get; private set; }
        public Dictionary<string, int> Weaknesses { get; private set; }
        public Dictionary<string, int> AttachedSensors { get; private set; }

        public Agent(string rank)
        {
            this.Rank = rank;
            this.AttachedSensors = new Dictionary<string, int>();
            this.Weaknesses = new Dictionary<string, int>();
            for (int i = 0; i < 3; i++)
            {
                string sensorType = RandomSensor();
                if (this.Weaknesses.ContainsKey(sensorType))
                {
                    this.Weaknesses[sensorType]++;
                }
                else
                {
                    this.Weaknesses[sensorType] = 1;
                }
            }
        }

        public int Investigation()
        {
            int counter = 0;
            foreach (var weakness in this.Weaknesses)
            {
                string type = weakness.Key;
                int needed = weakness.Value;
                if (this.AttachedSensors.ContainsKey(type))
                {
                    int Amount = this.AttachedSensors[type];
                    counter += Math.Min(Amount, needed);

                }
            }
            return counter;
        }
        public void RemoveSensor(string type)
        {
            if (!this.AttachedSensors.ContainsKey(type)) return;
            this.AttachedSensors[type]--;
            if (this.AttachedSensors[type] <= 0)
            {
                this.AttachedSensors.Remove(type);
            }
        }
        public bool IsRevealed()
        {
            foreach (var weakness in this.Weaknesses)
            {
                string type = weakness.Key;
                int needed = weakness.Value;
                if (!this.AttachedSensors.ContainsKey(type) || this.AttachedSensors[type] < needed)
                {
                    return false;
                }
            }
            return true;
        }
        public string RandomSensor()
        {
            List<string> sensorsTypes = new List<string> { "Light", "Signal", "Magnetic", "Motion", "Pulse", "Thermal", "Audio" };
            int index = random.Next(sensorsTypes.Count);
            string sensorType = sensorsTypes[index];
            return sensorType;
        }
    }
}
