using System;
using System.Collections.Generic;
using System.Text;

namespace dz1_oop
{
    class Weather
    {
        double temperature;
        double humidity;
        double windSpeed;

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }

        public Weather() { }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }
        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }
        public double GetTemperature()
        {
            return this.temperature;
        }
        public double GetHumidity()
        {
            return this.humidity;
        }
        public double GetWindSpeed()
        {
            return this.windSpeed;
        }
        public double CalculateFeelsLikeTemperature()
        {
            return -8.78469475556 + 1.61139411 * temperature + 2.33854883889 * humidity - 0.14611605 * temperature * humidity - 0.012308094 * (temperature * temperature) - 0.0164248277778 * (humidity * humidity) + 0.002211732 * (temperature * temperature) * humidity + 0.00072546 * temperature * (humidity * humidity) - 0.000003582 * (temperature * temperature) * (humidity * humidity);
        }
        public double CalculateWindChill()
        {
            if (temperature <= 10 && windSpeed > 4.8)
            {
                return 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
            }
            else
            {
                return 0;
            }
        }
        
    }
}
