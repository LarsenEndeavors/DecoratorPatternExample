namespace DecoratorPatternExample
{
    public class PlainPizza : Pizza
    {
        public string Description => "Thin Dough";
        public double Cost => 10.00;
        
        public string GetDescription()
        {
            return Description;
        }

        public double GetCost()
        {
            return Cost;
        }
    }
}