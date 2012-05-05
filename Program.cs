using System;

namespace IocContainer
{
    internal class Program
    {
        private static void Main()
        {
            var container = new IocContainer();
            container.Register<SonyWalkman, SonyWalkman>();
            container.Register<ITapeCassette, MyPoliceTape>();

            var walkman = container.Resolve<SonyWalkman>();

            Console.WriteLine(walkman.Play());

            Console.ReadLine();
        }
    }
}