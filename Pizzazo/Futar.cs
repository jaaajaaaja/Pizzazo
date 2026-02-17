using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzazo
{
    internal class Futar
    {
        private readonly PizzaKemence kemence;

        public Futar(PizzaKemence kemence)
        {
            this.kemence = kemence;
        }

        public void Szallit()
        {
            while (true)
            {
                Pizza pizza = kemence.KiveszPizza();
                Console.WriteLine($"Futár szállította: {pizza}");
                Thread.Sleep(3000);
            }
        }
    }
}
