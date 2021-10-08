using System;

namespace DecoratorPatternExample
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding sauce");
        }
        
        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", sauce";
        }

        public override double GetCost()
        {
            return Pizza.GetCost() + 0.50;
        }
    }
}