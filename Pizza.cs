namespace DecoratorPatternExample
{
    public interface Pizza
    {
        public string Description { get; }
        public double Cost { get; }

        public string GetDescription();
        public double GetCost();
    }
}