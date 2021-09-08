using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Task2(string s)
        {
            int counter = 0;


            foreach (char c in s)
            {
                counter++;
            }
            Console.Write("{0} ", counter);
            Console.ReadLine();

        }
        
        static void Task1(int a, int b, int c)
        {
            Console.WriteLine("Введите 3 целых числа ");


            int max;

            max = a > b ? b : a > c ? c : a;
            Console.Write($"Число с минимальным значением {max}");
            Console.ReadLine();



        }
        static void Main(string[] args)
        {
            int taskNumber = 0;
            do
            {
                Console.WriteLine("Введите номер задачи");
            Console.Write("1 - задание 1\n2 - Задание 2\n3 - задание 3\n4 - Задание 4\n5 - Задание 5\n=====================\n");
               taskNumber = int.Parse(Console.ReadLine());
            
                switch (taskNumber)
                {
                    case 0:
                        Console.Write("Завершение работы программы!");
                        break;
                    case 1:
                        {
                            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.\n\nВведите 3 целых числа ");
                            Console.Write("\nВведите первое число: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("\nВведите второе число: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("\nВведите третье число: ");
                            int c = int.Parse(Console.ReadLine());
                            Task1(a, b, c);
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Написать метод подсчета количества цифр числа.");
                            Console.Write("\nПосчитаем сколько цифр в нем : ");
                            string a = (Console.ReadLine());

                            Task2(a);
                            break;


                        }
                    default:

                        Console.Write("Неккоректный ввод задачи попробуйте снова");
                        return;

                }
            }
            while (taskNumber != 0);
            Console.ReadLine();
        }
    }
}

            
    

