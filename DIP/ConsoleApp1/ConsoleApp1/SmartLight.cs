using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SmartLight : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Умный свет включен.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Умный свет выключен.");
        }

        public string GetStatus()
        {
            return isOn ? "Умный свет включен." : "Умный свет выключен.";
        }
    }

}
