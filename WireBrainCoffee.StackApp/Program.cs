using System;

namespace WireBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.WriteLine();
        }

       

        private static void StackDoubles()
        {
            var stack = new SimpleStackDouble();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);
         
            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
        private static void StackStrings()

        {
            var stack = new SimpleStackString();
            stack.Push("Wired Brain Coffee");
            stack.Push("PluralSight");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
}
}
