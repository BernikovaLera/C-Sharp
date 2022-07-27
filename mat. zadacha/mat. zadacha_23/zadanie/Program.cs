using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Month
    {
        private int month {get; set;}
        public Month(int m)
        {
            month = m;
        }
        public void MonthNazvanie()
        {
            Console.WriteLine("Месяц " + month);
        }
        public void Nomer()
        {
            if(month==12)
            {
                month = 1;
            }
            else
            {
                month++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Month January = new Month(1);
            January.Nomer();
            January.MonthNazvanie();

            Month April = new Month(4);
            April.Nomer();
            April.MonthNazvanie();

            Month June = new Month(6);
            June.Nomer();
            June.MonthNazvanie();

            Month September = new Month(9);
            September.Nomer();
            September.MonthNazvanie();

            Month December = new Month(12);
            December.Nomer();
            December.MonthNazvanie();

            Console.ReadKey();
        }
    }
}
