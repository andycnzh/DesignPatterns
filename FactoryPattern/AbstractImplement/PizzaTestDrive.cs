using FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractImplement
{
    class PizzaTestDrive
    {
        public void Test()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan orderd a {pizza.Name} {Environment.NewLine}");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel orderd a {pizza.Name} {Environment.NewLine}");
        }
    }
}
