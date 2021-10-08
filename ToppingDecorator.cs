using System;

namespace DecoratorPatternExample
{
    public abstract class ToppingDecorator : Pizza
    {
        public string Description => Pizza.Description;
        public double Cost => Pizza.Cost;

        public abstract string GetDescription();

        public abstract double GetCost();

        protected Pizza Pizza { get; set; }

        protected ToppingDecorator(Pizza newPizza)
        {
            Pizza = newPizza;
            Console.WriteLine("Bang Bang");
        }
    }
}