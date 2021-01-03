using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Напишите простейшую программу, которая выводит указанное(установленное) пользователем сообщение заданное количество раз.*/
namespace ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько раз мне напечать твою мессагу? ");
            int messageCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какую мессагу печатать, введи текст ");
            string teksOfMessage = Console.ReadLine();

            for (int i = 0; i < messageCount; i++)
            {
                Console.WriteLine(teksOfMessage);
            }
            Console.ReadLine();
        }
    }
}
