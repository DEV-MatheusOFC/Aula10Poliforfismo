using System;

namespace Aula_10___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Pinguim");
            Pinguim pinguim = new Pinguim();
            pinguim.Correr();

            System.Console.WriteLine("Aguia");
            Aguia aguia = new Aguia();
            aguia.Voar();

        }
    }
}
