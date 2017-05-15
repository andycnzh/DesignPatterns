using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    class VeggiePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("VeggiePizza Prepare operation done.");
        }

        public void Bake()
        {
            Console.WriteLine("VeggiePizza Bake operation done.");
        }

        public void Cut()
        {
            Console.WriteLine("VeggiePizza Cut operation done.");
        }

        public void Box()
        {
            Console.WriteLine("VeggiePizza Box operation done.");
        }
    }
}
