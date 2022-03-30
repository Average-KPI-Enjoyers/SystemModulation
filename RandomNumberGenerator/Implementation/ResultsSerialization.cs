using System;
using System.Collections.Generic;

namespace RandomNumberGenerator.Implementation
{
    public static class ResultsSerialization
    {
        public static void Serialize(string filename, IEnumerable<double> result)
        {
            var convertedResult = DoubleToStringListConverter.Convert(result);
            System.IO.File.WriteAllLines(filename + ".txt", convertedResult);
            Console.WriteLine($"Successfully saved to {filename}.txt");
        }
    }
}