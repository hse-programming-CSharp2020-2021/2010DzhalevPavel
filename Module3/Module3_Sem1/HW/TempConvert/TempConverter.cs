using System;

namespace TempConvert
{
    public delegate double ConvertTemperature(double n);

    //Non-static class creation
    class TemperatureConverImp
    {
        /// <summary>
        /// Converts degrees Celsius to Fahrenheit
        /// </summary>
        /// <param name="n">degrees Celsius</param>
        /// <returns></returns>
        public double CelsiusToFahrenheit(double n)
        {
            return n * 9 / 5 + 32;
        }

        /// <summary>
        /// Converts degrees Fahrenheit to Celsius
        /// </summary>
        /// <param name="n">degrees Fahrenheit</param>
        /// <returns></returns>
        public double FahrenheitToCelsius(double n)
        {
            return (n - 32) * 5 / 9;
        }
    }

    static class StaticTempConverters
    {
        public static double CelsiusToFahrenheit(double n)
        {
            return n * 9 / 5 + 32;
        }
        public static double CelsiusToKelvins(double n)
        {
            return n - 273.15;
        }
        public static double CelsiusToRemoir(double n)
        {
            return n/1.25;
        }
    }

    static class Program
    {
        
        static void Main(string[] args)
        {
            //Initializing of the delegates
            ConvertTemperature del1 = new TemperatureConverImp().CelsiusToFahrenheit;
            ConvertTemperature del2 = new TemperatureConverImp().FahrenheitToCelsius;

            //Testing
            int degrees;
            do
            {
                Console.WriteLine("Enter degrees in Celsius: ");
            } while (!int.TryParse(Console.ReadLine(), out degrees));

            
            Console.WriteLine($"This temperature can also be represented by " +
                              $"{del1(degrees)} degree Fahrenheit.");
            Console.WriteLine($"Initial temperature is " +
                              $"{del2(del1(degrees))} degree Celsius.");

            ConvertTemperature[] delArray =
            {
                StaticTempConverters.CelsiusToFahrenheit,
                StaticTempConverters.CelsiusToKelvins,
                StaticTempConverters.CelsiusToRemoir,
                new TemperatureConverImp().FahrenheitToCelsius
            };
            //and so on and so on ultil all temperatures needed are added.

            for (int i = 0; i < delArray.Length; i++)
            {
                Console.WriteLine($"Method: {delArray[i].Method}" +
                                  $"Target: {delArray[i].Target}" +
                                  $"Result: {delArray[i](degrees)}");
            }
            //Creating an array of delegates    
        }
    }
}