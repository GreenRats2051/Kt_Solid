using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SmartHomeController
    {
        private readonly List<ISmartDevice> devices;

        public SmartHomeController()
        {
            devices = new List<ISmartDevice>();
        }

        public void AddDevice(ISmartDevice device)
        {
            devices.Add(device);
        }

        public void TurnOnDevice(int index)
        {
            if (index >= 0 && index < devices.Count)
            {
                devices[index].TurnOn();
            }
        }

        public void TurnOffDevice(int index)
        {
            if (index >= 0 && index < devices.Count)
            {
                devices[index].TurnOff();
            }
        }

        public void ShowStatus()
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.GetStatus());
            }
        }
    }

}
