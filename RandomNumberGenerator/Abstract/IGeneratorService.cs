namespace RandomNumberGenerator.Abstract
{
    public interface IGeneratorService
    {
        public double Generate(params double[] args);
        public string Name { get; }
    }
}