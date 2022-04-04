using RandomNumberGenerator.Abstract;
using RandomNumberGenerator.PythonModule;

namespace RandomNumberGenerator.Implementation
{
    public static class ResultsGenerateAndAnalyse
    {
        public static void GenerateAndAnalyse(IEnumerable<AbstractGenerator> generators)
        {
            var pythonAnalyser = new PythonAnalyser();
            foreach(var generator in generators)
            {
                var res = new List<double>();
                for (var i = 0; i < 10000; i++)
                {
                    res.Add(generator.Generate(1, 100));
                }
                ResultsSerialization.Serialize(generator.Name, res);
            }
            pythonAnalyser.Analyse();
        }
    }  
}