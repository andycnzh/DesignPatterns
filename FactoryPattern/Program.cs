using FactoryPattern.AbstractImplement;
using FactoryPattern.Factory;
using FactoryPattern.InterfaceImplement;
using FactoryPattern.SimpleFactory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTestDrive test = new PizzaTestDrive();
            test.Test();
            //IPizza pizza = new Pizza();

            //pizza.Prepare();

            //pizza.Bake();

            //CheesePizza cheesePizza = new CheesePizza();

            //cheesePizza.Prepare();

            //cheesePizza.Bake();

            //PizzaSimpleFactory pizzaFactory = new PizzaSimpleFactory();
            //SimpleFactory.PizzaStore store = new SimpleFactory.PizzaStore(pizzaFactory);

            //store.OrderPizza("veggie");

            //NYPizzaStore nyPizzaStore = new NYPizzaStore();
            //nyPizzaStore.OrderPizza("cheese");

            //ChicagoPizzaStore chPizzaStore = new ChicagoPizzaStore();
            //chPizzaStore.OrderPizza("veggie");

            Console.ReadLine();
        }
    }
}
