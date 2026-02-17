using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzazo
{
    internal class PizzaKemence
    {
        private readonly SzinkronPuffer<Pizza> puffer;

        public PizzaKemence(int meret)
        {
            puffer = new SzinkronPuffer<Pizza>(meret);
        }

        public void FeladPizza(Pizza pizza)
        {
            puffer.Hozzaad(pizza);
        }

        public Pizza KiveszPizza()
        {
            return puffer.Kivesz();
        }
    }
}
