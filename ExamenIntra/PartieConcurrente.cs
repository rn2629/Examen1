using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ExamenIntra
{
    class Syracuse
    {
        public readonly object verrou = new object();
        public long Iteration { get; set; }
        public void Next()
        {
            lock (verrou)
            {
                if (Iteration % 2 == 0)
                    Iteration /= 2;
                else
                    Iteration = Iteration * 3 + 1;
            }
        }

    }
    class PartieConcurrente
    {
        Syracuse syracuse;
        public static void Start()
        {
            Syracuse r = new Syracuse();
            r.Iteration = 989_345_275_647;

            const int NB_THREADS = 5;
            Thread[] threads = new Thread[NB_THREADS];

            for (int i = 0; i < NB_THREADS; i++)
                threads[i] = new Thread(() => new PartieConcurrente(r).Run());

            foreach (Thread t in threads)
                t.Start();

            foreach (Thread t in threads)
                t.Join();
        }

        public PartieConcurrente(Syracuse r)
        {
            this.syracuse = r;
        }

        void Run()
        {
            for (int i = 0; i < 1000; i++)
            {
                syracuse.Next();
                Thread.Sleep(10);
                lock (syracuse.verrou)
                {
                    i++;
                }
            }
        }
        void modif()
        {
            Stopwatch stopwatch = new Stopwatch();
            while (stopwatch.ElapsedMilliseconds < 1000)
            {
                Console.WriteLine(syracuse.Iteration);
                Thread.Sleep(10);
            }
        }
    }
}
