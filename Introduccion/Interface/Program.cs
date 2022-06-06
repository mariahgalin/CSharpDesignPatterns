using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVolador> aves = new List<IVolador>();

            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            var gallina = new Gallina();

            aves.Add(pato1);
            aves.Add(pato2);
            aves.Add(pato3);
            aves.Add(gallina);

            AVolar(aves);

            Console.ReadLine();
        }

        static void AVolar(List<IVolador> aves)
        {
            foreach (var ave in aves)
            {
                ave.Vuela();
            }
        }

        interface IVolador
        {
             void Vuela();

        }

        interface ICaminador
        {
            void Camina();
        }

        public class Pato : IVolador, ICaminador
        {
            public void Vuela()
            {
                Console.WriteLine("Pato vuela");
            }

            public void Camina()
            {
                Console.WriteLine("Pato camina");
            }
        }

        public class Gallina : IVolador
        {
            public void Vuela()
            {
                Console.WriteLine("Gallina vuela");
            }
        }
    }
}
