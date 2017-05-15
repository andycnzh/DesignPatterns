using FactoryPattern.InterfaceImplement;

namespace FactoryPattern.SimpleFactory
{
    internal class PizzaSimpleFactory
    {
        internal IPizza CreatePizza(string type)
        {
            IPizza pizza = new Pizza();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}