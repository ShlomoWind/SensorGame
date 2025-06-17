using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame.SensorFile
{
    internal class SensorFactory
    {
        public static Sensor CreateSensor(string type) 
        {
            switch(type.ToLower())
            {
                case "light":
                    return new SensorLight();
                case "audio":
                    return new SensorAudio();
                case "thermal":
                    return new SensorThermal();
                case "motion":
                    return new SensorMotion();
                case "signal":
                    return new SensorSignal();
                case "magnetic":
                    return new SensorMagnetic();
                case "pulse":
                    return new SensorPulse();
                default:
                    return null;
            }
        }
    }
}
