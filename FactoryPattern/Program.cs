using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            pizza.Prepare();

            pizza.Bake();

            CheesePizza cheesePizza = new CheesePizza();

            cheesePizza.Prepare();

            cheesePizza.Bake();

            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(pizzaFactory);

            store.OrderPizza("veggie");

            Console.ReadLine();
        }
    }
}
