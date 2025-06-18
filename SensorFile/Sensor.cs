using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class Sensor
    {
        public string Type { get; private set; }

        public Sensor(string type)
        {
            this.Type = type;
        }

        public void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine($"sensor {this.Type} is activate!");
            if (attachedSensors.ContainsKey(this.Type))
            {
                attachedSensors[this.Type]++;
            }
            else
            {
                attachedSensors[this.Type] = 1;
            }
        }
    }
}
