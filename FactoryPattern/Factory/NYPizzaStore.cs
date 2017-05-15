
using FactoryPattern.AbstractImplement;

namespace FactoryPattern.Factory
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
