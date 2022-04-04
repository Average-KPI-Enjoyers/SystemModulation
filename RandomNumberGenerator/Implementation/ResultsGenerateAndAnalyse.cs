using RabbitMQ.Client;
using RandomNumberGenerator.Abstract;
using RandomNumberGenerator.RabbitMQModule;

namespace RandomNumberGenerator.Implementation
{
    public static class ResultsGenerateAndAnalyse
    {
        public static void GenerateAndAnalyse(IEnumerable<AbstractGenerator> generators)
        {
            var queue = new QueueCore(new ConnectionFactory() {HostName = "localhost"});
            foreach(var generator in generators)
            {
                var res = new List<double>();
                for (var i = 0; i < 10000; i++)
                {
                    res.Add(generator.Generate(1, 100));
                }
                var convertedResult = DoubleToStringListConverter.Convert(res).ToList();
                ResultsSerialization.Serialize(generator.Name, convertedResult);
                queue.Analyze(generator, convertedResult);
            }
        }
    }  
}