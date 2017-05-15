using FactoryPattern.InterfaceImplement;

namespace FactoryPattern.SimpleFactory
{
    class PizzaStore
    {
        PizzaSimpleFactory factory;

        public PizzaStore(PizzaSimpleFactory factory)
        {
            this.factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza;

            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
