﻿namespace DEML.Temperaruta
{
    public class ConvertidorTemperaturas
    {
        public double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    }
}
