namespace Pizzazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaKemence kemence = new PizzaKemence(5);

            Sef sef1 = new Sef(kemence);
            Sef sef2 = new Sef(kemence);
            Futar futar = new Futar(kemence);

            Thread sefThread1 = new Thread(sef1.Keszit);
            Thread sefThread2 = new Thread(sef2.Keszit);
            Thread futarThread = new Thread(futar.Szallit);

            sefThread1.Start();
            sefThread2.Start();
            futarThread.Start();

            sefThread1.Join();
            sefThread2.Join();
            futarThread.Join();
        }
    }
}
