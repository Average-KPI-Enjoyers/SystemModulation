using System;
using RandomNumberGenerator.Abstract;

namespace RandomNumberGenerator.Implementation.Generators
{
    public class SumGenerator : AbstractGenerator
    {
        private readonly Random _random;
        public SumGenerator(string name) : base(name)
        {
            _random = new Random();
        }
        /// <summary>
        /// Generate random number by this formula: ri=σ((∑(i=1)^12)ζi -6)+μ
        /// </summary>
        /// <param name="args[0]">Stands for σ</param>
        /// <param name="args[1]">Stands for μ</param>
        /// <returns>Result as double</returns>
        public override double Generate(params double[] args)
        {
            double result = 0;
            for (int i = 0; i <= 12; i++)
            {
                result += _random.NextDouble() - 6d;
            }
            result *= args[0];
            result += args[1];
            return result;
        }
    }
}