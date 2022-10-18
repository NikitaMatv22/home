using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.8
            //По По номеру дня недели вывести его название.

            Console.WriteLine("введите номер дня недели ");
            int a =Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
                case 7:
                    Console.WriteLine("воскресенье");
                    break;
               

                default:
                    Console.WriteLine("Нет такого дня недели");
                    break;
            }








        }
    }
}
