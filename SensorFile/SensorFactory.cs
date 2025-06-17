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
                default:
                    return null;
            }
        }
    }
}
