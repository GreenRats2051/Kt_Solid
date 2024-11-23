using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SmartThermostat : ISmartDevice
    {
        private bool isOn;
        private int temperature;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Умный термостат включен.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Умный термостат выключен.");
        }

        public void SetTemperature(int temp)
        {
            if (isOn)
            {
                temperature = temp;
                Console.WriteLine($"Температура установлена на {temperature}°C.");
            }
            else
            {
                Console.WriteLine("Необходимо включить термостат перед установкой температуры.");
            }
        }

        public string GetStatus()
        {
            return isOn ? $"Умный термостат включен. Температура: {temperature}°C." : "Умный термостат выключен.";
        }
    }

}
