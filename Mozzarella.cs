using System;

namespace DecoratorPatternExample
{
    public class Mozzarella : ToppingDecorator
    {

        public Mozzarella(Pizza newPizza) : base(newPizza)
        { 
            Console.WriteLine("Adding dough");
            Console.WriteLine("Adding Moz");
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", mozzarella";
        }

        public override double GetCost()
        {
            return Pizza.GetCost() + 0.50;
        }
    }
}