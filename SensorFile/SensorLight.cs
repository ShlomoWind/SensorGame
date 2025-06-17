using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorLight: Sensor
    {
        public SensorLight() : base("Light") { }
        public override void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine("Sensor Light is activated!");
            base.Activate(attachedSensors);
        }
    }
}
