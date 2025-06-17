using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorMotion : Sensor
    {
        public SensorMotion() : base("Motion") { }
        public override void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine("Sensor Motion is activated!");
            base.Activate(attachedSensors);
        }
    }
}
