﻿using System;

namespace FactoryPattern.InterfaceImplement
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("CheesePizza Prepare operation done.");
        }

        public void Bake()
        {
            Console.WriteLine("CheesePizza Bake operation done.");
        }

        public void Cut()
        {
            Console.WriteLine("CheesePizza Cut operation done.");
        }

        public void Box()
        {
            Console.WriteLine("CheesePizza Box operation done.");
        }
    }
}
