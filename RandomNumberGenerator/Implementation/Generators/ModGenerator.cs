using System;
using RandomNumberGenerator.Abstract;

namespace RandomNumberGenerator.Implementation.Generators
{
    public class ModGenerator : AbstractGenerator
    {
        private readonly Random _random;
        public ModGenerator(string name) : base(name)
        {
            _random = new Random();
        }
        /// <summary>
        /// Generate random number by this formula: z(i+1)=bzi("mod"(a)), r(i+1)=z(i+1)⁄c
        /// </summary>
        /// <param name="args[0]">Stands for b</param>
        /// <param name="args[1]">Stands for c</param>
        /// <returns>Result as double</returns>
        public override double Generate(params double[] args)
        {
            return args[0] * _random.NextDouble() % args[1] / args[1];
        }
    }
}