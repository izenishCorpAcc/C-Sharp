using System;
using OpenHardwareMonitor.Hardware;

class Program
{
    static void Main()
    {
        Computer computer = new Computer();
        computer.Open();

        foreach (var hardware in computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.CPU)
            {
                hardware.Update();

                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Core")
                    {
                        Console.WriteLine("CPU Temperature: {0}°C", sensor.Value);
                    }
                }
            }
        }

        computer.Close();

        Console.ReadKey();
    }
}
