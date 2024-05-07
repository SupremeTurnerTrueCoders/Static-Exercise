using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
      public static double FahrenheitToCelsius(double TempInFahrenheit)
        {
            // C = (F - 32) * 5/9;
            return (TempInFahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double TempInCelsius)
        {
            // F = (C*9)/5 + 32;
            return (TempInCelsius * 9) / 5 + 32;
        }


    }
}
