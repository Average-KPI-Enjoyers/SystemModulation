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
            PythonAnalyser _pythonAnalyser = new PythonAnalyser();
            IGeneratorService sumGenerator = new SumGenerator();
            IGeneratorService modGenerator = new ModGenerator();
            IGeneratorService expGenerator = new ExpGenerator();
            
            var res = new List<double>();
            for (var i = 0; i < 10000; i++)
            {
                res.Add(modGenerator.Generate(1, 100));
            }
            ResulstsSerialization.Serialize(nameof(modGenerator), res);
            _pythonAnalyser.Analyse();
        }
    }
}