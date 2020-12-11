using System;

namespace Modificadores
{
    public class Program
    {
        //Shape - Forma
        public class Shape
        {
            public const double PI = Math.PI; // constante
            protected double x, y; //protected las 2 variables
            //creamos un constructor
            public Shape() { }
            //agregamos el constructor a las variables
            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            //Este es el virtual cada vez que entre se rescriba en una nueva figura
            public virtual double Area()
            {
                return x * y;
            }
        }
        //Circulo extiende de su clase padre
        public class Circle : Shape
        {
            //Creacion de un nuevo metodo y figura
            public Circle(double r) : base(r, 0) { }
            public override double Area()
            {
                return PI * x * x;
            }
        }

        //Esfera extiende de su clase padre
        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0) { }
            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        //Cilindro extiende de su clase padre Figura
        class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h) { }
            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
            Console.ReadKey();
        }
        //Trae todos las areas de las figuras
        //usando virtual y override
    }
}
