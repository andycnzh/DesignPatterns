using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractImplement
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public string Dough { get; set; }

        public string Sauce { get; set; }

        public ArrayList Toppings = new ArrayList();

        public void Prepare()
        {
            Console.WriteLine($"Preparing ${Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < Toppings.Count; i++)
            {
                Console.WriteLine("  " + Toppings[i]);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
