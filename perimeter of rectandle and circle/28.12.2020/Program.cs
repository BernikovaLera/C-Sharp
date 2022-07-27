using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._12._2020
{
    abstract class Figure
    {
        public abstract void Figura();
    }
    class Rectangle : Figure
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public double Perimeter { get; set; }
        public Rectangle(int x, int y)
        {
            this.Length = x;
            this.Width = y;
            this.Perimeter = 2 * (x + y);
        }
        public override void Figura()
        {
            Console.WriteLine("Периметр прямоугольника");
            Console.WriteLine("Длина: " + Length);
            Console.WriteLine("Ширина: " + Width);
            Console.WriteLine("Ответ: " + Perimeter);
        }
    }
    class Circle : Figure
    {
        public int Radius { get; set; }
        public double Perimeter { get; set; }
        public Circle(int r)
        {
            this.Radius = r;
            this.Perimeter = r * 2 * Math.PI;
        }
        public override void Figura()
        {
            Console.WriteLine("Периметр круга");
            Console.WriteLine("Радиус окружности: " + Radius);
            Console.WriteLine("Ответ: " + Perimeter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figura = new List<Figure>();
            figura.Add(new Rectangle(8, 3));
            foreach (Figure figurs in figura)
            {
                if (figurs is Rectangle)
                    (figurs as Rectangle).Figura();
            }
            figura.Add(new Circle(4));
            foreach (Figure figurs in figura)
            {
                if (figurs is Circle)
                    (figurs as Circle).Figura();
            }
            Console.ReadKey();
        }
    }
}