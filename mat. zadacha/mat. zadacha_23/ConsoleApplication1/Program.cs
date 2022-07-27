using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

class Month
{
private int month { get; set; }
public Month(int m)
{
month = m;
}
public void Add()
{
if (month == 12)
{
month = 1;
}
else
{
month++;
}
Console.WriteLine("Месяц:" + month);
}
}
class Program
{
static void Main(string[] args)
{
Month Month1 = new Month(2);
Month Month2 = new Month(6);
Month Month3 = new Month(8);
Month Month4 = new Month(10);
Month Month5 = new Month(1);

Month1.Add();
Month2.Add();
Month3.Add();
Month4.Add();
Month5.Add();

Console.ReadKey();
}
}
}
