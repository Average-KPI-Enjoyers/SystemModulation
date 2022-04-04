using System;
using System.Collections.Generic;

namespace RandomNumberGenerator.Implementation
{
    public static class ResultsSerialization
    {
        public static void Serialize(string filename, IEnumerable<string> result)
        {
            File.WriteAllLines(filename + ".txt", result);
            Console.WriteLine($"Successfully saved to {filename}.txt");
        }
    }
}