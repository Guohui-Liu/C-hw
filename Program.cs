using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.Read();


        }
    }

    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

    }

    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Cirle : Shape
    {
        private double r;
        private double PI = Math.PI;
        public Cirle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            Console.WriteLine("Circular area is:");
            return PI * r * r;
        }
    }
    public class Rectangle : Shape
    {
        private double w, h;
        public Rectangle(double w, double h)
        {
            this.w = w;
            this.h = h;
        }
        public override double Area()
        {
            Console.WriteLine("The area of ​​the rectangle is:");
            return w * h;
        }
    }


}
