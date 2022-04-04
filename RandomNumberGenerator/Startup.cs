using RandomNumberGenerator.Abstract;
using RandomNumberGenerator.Implementation;
using RandomNumberGenerator.Implementation.Generators;


namespace RandomNumberGenerator
{
    public static class Startup
    {
        public static void Main(string[] args)
        {
            AbstractGenerator sumGenerator = new SumGenerator(nameof(sumGenerator));
            AbstractGenerator modGenerator = new ModGenerator(nameof(modGenerator));
            AbstractGenerator expGenerator = new ExpGenerator(nameof(expGenerator));
            
            var generators = new List<AbstractGenerator> {sumGenerator, modGenerator, expGenerator};
            ResultsGenerateAndAnalyse.GenerateAndAnalyse(generators);
        }
    }
}