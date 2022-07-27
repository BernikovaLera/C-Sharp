using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Figure
    {
        public
          virtual double GetSquare() = 0;
          virtual double GetPerimeter() = 0;
    }
    class Rectangle : Figure
    {
        protected
          double a, b;
        public
          Rectangle(double a, double b);
          double GetSquare(){return a * b;}
          double GetPerimeter(){return (a + b) * 2;}
    }
 
    Rectangle :: Rectangle(double a, double b)
    {
      this -> a = a;
      this -> b = b;
    }
 
    class Circle:Figure
    {
      double r;
      public
      Circle(double r);
      double GetSquare(){return (3.141592 * (r * r));}
      double GetPerimeter(){return (2 * 3.141592 * r);}
    };
 
    Circle :: Circle(double r)
    {
      this -> r = r;
    }
    class Program
    {
        static void Main(string[] args)
        {
          Figure = new Rectangle(10, 20);
          Console.WriteLine( "Square of Rectangle: " + f -> GetSquare());
          Console.WriteLine("Perimeter of Rectangle: " +  f -> GetPerimeter());
  
          double f = new Circle(5);
          Console.WriteLine("Square of Circle: " + f -> GetSquare());
          Console.WriteLine("Perimeter of Circle: " + f -> GetPerimeter());

          Console.ReadKey();
        }
    }
}