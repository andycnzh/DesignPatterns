
using FactoryPattern.AbstractImplement;

namespace FactoryPattern.Factory
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
