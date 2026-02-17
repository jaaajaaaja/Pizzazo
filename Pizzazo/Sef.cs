using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzazo
{
    internal class Sef
    {
        private readonly PizzaKemence kemence;
        private readonly Random random = new Random();
        private readonly string[] pizzak = { "Margherita", "Sonkás", "Hawaii", "Pepperoni" };

        public Sef(PizzaKemence kemence)
        {
            this.kemence = kemence;
        }

        public void Keszit()
        {
            while (true)
            {
                string nev = pizzak[random.Next(pizzak.Length)];
                int meret = random.Next(20, 41);
                Pizza pizza = new Pizza(nev, meret);
                kemence.FeladPizza(pizza);
                Console.WriteLine($"Séf készítette: {pizza}");
                Thread.Sleep(random.Next(2000, 3001));
            }
        }
    }
}
