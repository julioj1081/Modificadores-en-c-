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
        //Ingresa a la clase A y la subclase B y trae el valor
    }
}
