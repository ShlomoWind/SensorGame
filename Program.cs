﻿using SensorGame.ManagerFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("junior");
            manager.StartGame();
        }
    }
}
