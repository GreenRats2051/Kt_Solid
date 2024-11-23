using ConsoleApp1;

SmartHomeController homeController = new SmartHomeController();

SmartLight light = new SmartLight();
SmartThermostat thermostat = new SmartThermostat();
SmartMediaSystem mediaSystem = new SmartMediaSystem();

homeController.AddDevice(light);
homeController.AddDevice(thermostat);
homeController.AddDevice(mediaSystem);

homeController.TurnOnDevice(0);
homeController.TurnOnDevice(1);
thermostat.SetTemperature(22);
homeController.TurnOnDevice(2);

homeController.ShowStatus();