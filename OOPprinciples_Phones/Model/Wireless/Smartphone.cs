﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprinciples_Phones.Model.Wireless
{
    public class Smartphone : CellPhone
    {
        private string _operationSystem;

        public Smartphone(int year, int batteryTime, string operationSystem, SimCard simCard) : base(year, batteryTime, simCard)
        {
            _operationSystem = operationSystem;
        }

        public void SetUpProgram(string programName)
        {
            Console.WriteLine("Устанавливается программа '" + programName + "' для ОС '" + _operationSystem + "'.");
        }
    }
}
