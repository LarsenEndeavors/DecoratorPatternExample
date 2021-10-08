using System;

namespace DecoratorPatternExample
{
    /*
     * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
     * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
     * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
     * I'm happy that you're here and here's proof that I have at least heard of this particular
     * pattern!
     *
     * Author: Nicholas Larsen
     * Date: 2021/10/07
     */
    internal static class DecoratorPatternExample
    {
        private static void Main()
        {
            // This is the crux of the decorator pattern, each of these objects inherits from a similar
            // super class
            Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            // Then when called upon they build from the object's methods, calling recursively until they hit the end.
            Console.WriteLine(basicPizza.GetCost());
            Console.WriteLine(basicPizza.GetDescription());
        }
    }
}