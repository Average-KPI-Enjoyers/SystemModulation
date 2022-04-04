namespace RandomNumberGenerator.Abstract;

public interface IQueueService
{
    void Analyze(AbstractGenerator abstractGenerator, IEnumerable<string> results);
}