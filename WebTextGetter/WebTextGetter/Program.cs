using System;

namespace WebTextGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var gc = new GetClient();
            gc.GetBody("n0757ey", 1).Wait();
        }
    }
}
