using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        delegate void AccountHandler(string message);
        event AccountHandler Notify;
        int Sum =100;
         public void Put(int sum)    
        {
            Sum += sum;
            Notify.Invoke("На счет поступило: " + sum);   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify.Invoke("Со счета снято: " + sum);   // 2.Вызов события
            }
            else
            {
                Notify.Invoke("Недостаточно денег на счете. Текущий баланс:" + Sum); ;
            }
        }
    
       static void Main(string[] args)
        {
            Program acc = new Program();
            acc.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
            acc.Put(20);    // добавляем на счет 20
            Console.WriteLine("Сумма на счете: " + acc.Sum);
            acc.Take(70);   // пытаемся снять со счета 70
            Console.WriteLine("Сумма на счете: "  + acc.Sum);
            acc.Take(180);  // пытаемся снять со счета 180
            Console.WriteLine("Сумма на счете: " + acc.Sum);
            Console.Read();
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}