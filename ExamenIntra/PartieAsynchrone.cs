using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{
    class PartieAsynchrone
    {
        public static void Start()
        {
            new PartieAsynchrone().DeveloppementWeb();
        }

        async void DeveloppementWeb()
        {
            Console.WriteLine("A. Développons une application web.");
            Task frontEnd = FrontEnd();
            await BaseDeDonnees();
            Task backEnd = BackEnd();
            await Task.WhenAll(frontEnd, backEnd);
            await Deploiement();
            Console.WriteLine("B. L'application web est complétée.");

        }

        async Task Multimedia()
        {
            Console.WriteLine("C. Commander des ressource multimédia.");
            await Task.Delay(50);
            Console.WriteLine("D. Recevoir des ressources multimédia.");
        }

        async Task FrontEnd()
        {
            Console.WriteLine("E. Début du développement Front End.");
            Task recevoirMultimedia = Multimedia();
            await Task.Delay(10);
            await recevoirMultimedia;
            Console.WriteLine("F. Fin du développement Front End.");

        }

        async Task BackEnd()
        {
            Console.WriteLine("G. Début du développement Back End.");
            await Task.Delay(20);
            Console.WriteLine("H. Fin du développement Back End.");

        }

        async Task BaseDeDonnees()
        {
            Console.WriteLine("K. Début du traitement de la  BD.");
            await Task.Delay(5);
            Console.WriteLine("L. Modification de la BD.");
            await Task.Delay(2);
            Console.WriteLine("M. Fin de traitement de la BD.");
        }

        async Task Deploiement()
        {
            Console.WriteLine("I. Début du déploiement.");
            await Task.Delay(10);
            Console.WriteLine("J. Fin du déploiement.");
        }
    }
}
