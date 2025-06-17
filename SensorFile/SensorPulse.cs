using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorPulse : Sensor
    {
        public SensorPulse() : base("Pulse") { }
        public override void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine("Sensor Pulse is activated!");
            base.Activate(attachedSensors);
        }
    }
}
