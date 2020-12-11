using System;

namespace Modificadores
{
    public class Program
    {
        static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());
            Console.ReadKey();
        }
        //Error No es accesible debido a su nivel de proteccion
    }
}
