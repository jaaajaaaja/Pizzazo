using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzazo
{
    internal class Pizza
    {
        private string nev;
        private int meret;

        public Pizza(string nev, int meret)
        {
            this.nev = nev;
            this.meret = meret;
        }

        public override string ToString()
        {
            return $"{this.nev} ({this.meret} cm)";
        }
    }
}
