using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzazo
{
    internal class SzinkronPuffer<T>
    {
        private readonly Queue<T> queue = new Queue<T>();
        private readonly int maxMeret;
        private readonly object lockObj = new object();

        public SzinkronPuffer(int maxMeret)
        {
            this.maxMeret = maxMeret;
        }

        public void Hozzaad(T elem)
        {
            lock (lockObj)
            {
                while (queue.Count >= maxMeret)
                {
                    Monitor.Wait(lockObj);
                }
                queue.Enqueue(elem);
                Monitor.PulseAll(lockObj);
            }
        }

        public T Kivesz()
        {
            lock (lockObj)
            {
                while (queue.Count == 0)
                {
                    Monitor.Wait(lockObj);
                }
                T elem = queue.Dequeue();
                Monitor.PulseAll(lockObj);
                return elem;
            }
        }
    }
}
