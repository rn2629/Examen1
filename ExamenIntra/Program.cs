using System;
using System.Threading.Tasks;

namespace ExamenIntra
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Partie LINQ
            PartieLINQ.Start();
            Console.Read();
            Console.WriteLine("-------------------------");

            PartieLINQ linq1 = new PartieLINQ();
            linq1.Affichage();
            Console.ReadKey();
         

            Console.Read();
            Console.WriteLine("-------------------------");

            /// Partie concurrente
            PartieConcurrente.Start();
            
            /// Partie asynchrone
            PartieAsynchrone.Start();
        }
    
    }
}
