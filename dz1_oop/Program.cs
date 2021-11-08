using System;

namespace dz1_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDemoForHW1();
        }
        private static void RunDemoForHW1()
        {
            Weather current = new Weather();
            current.SetTemperature(24.12);
            current.SetWindSpeed(3.5);
            current.SetHumidity(0.56);
            Console.WriteLine("Weather info:\n"
                + "\ttemperature: " + current.GetTemperature() + "\n"
                + "\thumidity: " + current.GetHumidity() + "\n"
                + "\twind speed: " + current.GetWindSpeed() + "\n");
            Console.WriteLine("Feels like: " + current.CalculateFeelsLikeTemperature());

            Console.WriteLine("Finding weather info with largest windchill!");
            const int Count = 5;
            double[] temperatures = new double[Count] { 8.33, -1.45, 5.00, 12.37, 7.67 };
            double[] humidities = new double[Count] { 0.3790, 0.4555, 0.743, 0.3750, 0.6612 };
            double[] windSpeeds = new double[Count] { 4.81, 1.5, 5.7, 4.9, 1.2 };

            Weather[] weathers = new Weather[Count];
            
            for (int i = 0; i < weathers.Length; i++)
            {
                weathers[i] = new Weather(temperatures[i], humidities[i], windSpeeds[i]);
                Console.WriteLine("Windchill for weathers[" + i + "] is: " + weathers[i].CalculateWindChill());
            }
            
            Weather largestWindchill = FindWeatherWithLargestWindchill(weathers);
            Console.WriteLine(
                "Weather info:" + largestWindchill.GetTemperature() + ", " +
                largestWindchill.GetHumidity() + ", " + largestWindchill.GetWindSpeed()
            );
        }
        private static Weather FindWeatherWithLargestWindchill(Weather [] weathers)
        {
            int i, x = 0;
            double najveci = weathers[0].CalculateWindChill();
            for (i = 0; i < weathers.Length; i++)
            {
                if(weathers[i].CalculateWindChill()>najveci)
                {
                    najveci = weathers[i].CalculateWindChill();
                    x = i;
                }
            }
            return weathers[x];
        }
    }
}
