using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // var singleton = Singleton.Singleton.Instance;

            var log = Singleton.Log.Instance;
            log.Save("a");

            Console.ReadKey();
        }
    }
}
