using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            if (celsius < -273.15)
            {
                throw new ArgumentOutOfRangeException(nameof(celsius), "Temperature cannot be below absolute zero.");
            }

            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            if (fahrenheit < -459.67)
            {
                throw new ArgumentOutOfRangeException(nameof(fahrenheit), "Temperature cannot be below absolute zero.");
            }

            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
