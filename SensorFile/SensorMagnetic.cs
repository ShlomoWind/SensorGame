using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorMagnetic : Sensor
    {
        public SensorMagnetic() : base("Magnetic") { }
        public override void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine("Sensor Magnetic is activated!");
            base.Activate(attachedSensors);
        }
    }
}
