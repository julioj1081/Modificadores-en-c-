using System;

namespace Modificadores
{
    public class Program : A
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.mostrar();
            Console.ReadKey();
        }
        //Error No es accesible debido a su nivel de proteccion
    }
}
