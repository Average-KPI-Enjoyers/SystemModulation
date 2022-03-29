using System;
using RandomNumberGenerator.Abstract;

namespace RandomNumberGenerator.Implementation.Generators
{
    public class ExpGenerator : IGeneratorService
    {
        private readonly Random _random;
        public string Name { get; }
        
        public ExpGenerator(string name)
        {
            Name = name;
            _random = new Random();
        }
        /// <summary>
        /// Generate random number by this formula: ri=-1/λ * ln(ζi)
        /// </summary>
        /// <param name="args[0]">Stands for λ</param>
        /// <returns>Result as double</returns>
        public double Generate(params double[] args)
        {
            var result = (-1 / args[0]) * Math.Log2(_random.NextDouble());
            return result;
        }
    }
}