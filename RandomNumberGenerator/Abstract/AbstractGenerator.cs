namespace RandomNumberGenerator.Abstract
{
    public abstract class AbstractGenerator : IGeneratorService
    {
        protected string _name;
        public abstract string Name { get; }
        public abstract double Generate(params double[] args);
    }
}