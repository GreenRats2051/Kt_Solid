using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SmartMediaSystem : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Умная мультимедийная система включена.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Умная мультимедийная система выключена.");
        }

        public string GetStatus()
        {
            return isOn ? "Умная мультимедийная система включена." : "Умная мультимедийная система выключена.";
        }
    }

}
