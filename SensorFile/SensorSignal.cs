using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorSignal : Sensor
    {
        public SensorSignal() : base("Signal") { }
        public override void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine("Sensor Signal is activated!");
            base.Activate(attachedSensors);
        }
    }
}
