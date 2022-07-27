using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    interface IMovable
    {
        public const int minSpeed = 0;
        private static int maxSpeed = 60;
        static double GetTime(double distance, double speed)
        {
            GetTime (double distance / double speed; 
        }
        static int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;
            }
    }
}
    class Program
    {
        static void Main(string [] args)
        {
        Console.WriteLine(IMovable.MaxSpeed);
        IMovable.MaxSpeed = 65;
        Console.WriteLine(IMovable.MaxSpeed);
        double time = IMovable.GetTime(100, 1);
        Console.WriteLine(time);
        }
    }
}