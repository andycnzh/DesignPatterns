using System;

namespace FactoryPattern.InterfaceImplement
{
    public class Pizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Pizza Prepare operation done.");
        }

        public void Bake()
        {
            Console.WriteLine("Pizza Bake operation done.");
        }

        public void Cut()
        {
            Console.WriteLine("Pizza Cut operation done.");
        }

        public void Box()
        {
            Console.WriteLine("Pizza Box operation done.");
        }
    }
}
