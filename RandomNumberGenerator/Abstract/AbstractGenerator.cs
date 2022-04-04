namespace RandomNumberGenerator.Abstract
{
    public abstract class AbstractGenerator : IGeneratorService
    {
        public readonly string Name;
        protected AbstractGenerator(string name)
        {
            Name = name;
        }
        public abstract double Generate(params double[] args);
    }
}