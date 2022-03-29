using System;
using System.Collections.Generic;
using IronPython.Hosting;
using RandomNumberGenerator.Abstract;
using RandomNumberGenerator.Implementation;
using RandomNumberGenerator.Implementation.Generators;
using RandomNumberGenerator.PythonModule;

namespace RandomNumberGenerator
{
    public static class Startup
    {
        public static void Main(string[] args)
        {
            var pythonAnalyser = new PythonAnalyser();
            IGeneratorService sumGenerator = new SumGenerator("sumGenerator");
            IGeneratorService modGenerator = new ModGenerator("modGenerator");
            IGeneratorService expGenerator = new ExpGenerator("expGenerator");

            var generators = new List<IGeneratorService> {sumGenerator, modGenerator, expGenerator};
            foreach(var generator in generators)
            {
                var res = new List<double>();
                for (var i = 0; i < 10000; i++)
                {
                    res.Add(generator.Generate(1, 100));
                }
                ResulstsSerialization.Serialize(generator.Name, res);
            }
            pythonAnalyser.Analyse();
        }
    }
}