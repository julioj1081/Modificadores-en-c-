using System;

namespace Modificadores
{
    class A
    {
        private void mostrar()
        {
            Console.WriteLine("privado");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.mostrar();
            Console.ReadKey();
        }
        //Error No es accesible debido a su nivel de proteccion
    }
}
