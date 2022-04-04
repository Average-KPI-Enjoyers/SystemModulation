using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RandomNumberGenerator.Abstract;

namespace RandomNumberGenerator.RabbitMQModule;

public class QueueCore : IQueueService
{
    private readonly ConnectionFactory _factory;

    public QueueCore(ConnectionFactory factory)
    {
        _factory = factory;
    }


    public void Analyze(AbstractGenerator abstractGenerator,IEnumerable<string> results)
    {
        using var connection = _factory.CreateConnection();
        using var channel = connection.CreateModel();
        channel.QueueDeclare(queue: "results_to_analyze",
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null);
        //TODO: finish body encoding
        var body = Encoding.UTF8.GetBytes(results.ToString());
        channel.BasicPublish(exchange: "",
            routingKey: "results_to_analyze",
            basicProperties: null,
            body: body);
        Console.WriteLine($"[x] Results sent for {abstractGenerator.Name}");
    }
}