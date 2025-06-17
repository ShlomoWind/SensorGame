using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorAudio : Sensor
    {
        public SensorAudio() : base("Audio") { }
        public override void Activate(Dictionary<string, int> attachedSensors)
        {
            Console.WriteLine("Sensor Audio is activated!");
            base.Activate(attachedSensors);
        }
    }
}
