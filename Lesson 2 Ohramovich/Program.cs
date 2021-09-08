using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Ohramovich
{
    class Program
    {
        static void Pause()
        {
            Console.ReadLine();
        }
        
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
        static void Task4(string login, string password)
        {
            int score = 0;
            while(score<=3)
            {

                if (login != "root" && password != "geekbrains")
                {
                    Console.Write($"Неверный логин или пароль! Осталость попыток:  {3 -score}\n");
                    score++;
                    login =Console.ReadLine();
                    password = Console.ReadLine();
                }
                else if (login == "root" && password == "geekbrains")
                {
                    Console.Write("Все верно!");
                    break;
                }
            }
            while (score <= 3);

            Console.Write("Логин или пароль были введены не правильно! Программа завершает работу");
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
                Console.Write("1 - задание 1\n2 - Задание 2\n3 - задание 3\n4 - Задание 4\n5 - Задание 5\n6 - Задание 6\n=====================\n");
                taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    case 0:
                        Console.Write("Завершение работы программы!");
                        break;
                    #region  Задача 1
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
                    #endregion
                    #region Задача 2
                    case 2:
                        {
                            Console.WriteLine("Написать метод подсчета количества цифр числа.");
                            Console.Write("\nПосчитаем сколько цифр в нем : ");
                            string a = (Console.ReadLine());

                            Task2(a);

                            break;


                        }
                    #endregion
                    #region Задача 3
                    case 3:
                        {
                            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
                            Console.Write("\nВведите целое число\n");
                            int a = int.Parse(Console.ReadLine());
                            int chet = 0;
                            while (a != 0)
                            {
                                if (a % 2 == 0)
                                {
                                    chet = a + chet;
                                    Console.Write(+a + " - Число четное\n");
                                    a = int.Parse(Console.ReadLine());
                                }
                                else if (a % 2 != 0)
                                {
                                    Console.Write(+a + " - Число не четное\n");
                                    a = int.Parse(Console.ReadLine());
                                }


                            }
                            while (a != 0) ;
                            Console.WriteLine($"Сумма четных числе = {chet}\n\n");
                            break;
                        }
                    #endregion
                    #region Задача 4
                    case 4:
                        Console.Write("Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.\nНа выходе истина, если прошел авторизацию, и ложь, если не прошел\n (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь\nвводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
                        Console.Write("\nВведите Логин: ");
                        string log = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        string pas = Console.ReadLine();
                        Task4(log, pas);
                        break;
                    #endregion
                    #region Задача 5
                    case 5:
                        Console.Write("Введите ваш рост в метрах через запятую :");
                        double h = double.Parse(Console.ReadLine());
                        Console.Write("Введите ваш вес в кг :");
                        double m = double.Parse(Console.ReadLine());
                        double i = m / (h * h);
                        Console.WriteLine("Ваш ИМТ = "+"{0:F2}",i);
                            if (i < 18.5)
                        {
                            Console.Write($"Вам нужно набрать вес : "+ "{ 0:2f}"+(18.5 -i));
                        }
                            else if (i > 25)
                        {
                            Console.Write("Вам нужно похудеть на "+(i-25)+"кг");

                        }   else
                            Console.Write("У вас идеальный вес");
                        Console.ReadLine();
                        break;
                    #endregion
                    #region Задача 6
                        case 6: 
                        int num =1;
                        int sumNum=0;
                        int score=0;
                        int div = 0;
                        DateTime start = DateTime.Now;
                        Console.Write("Текущие время начало программы :" + start);
                        System.Threading.Thread.Sleep(1);
                        Console.Write("\nПрограмма работает.....");
                        for (var j = 1; j <= 1000000000; j++)
                        {
                            div = j;
                            while (div != 0)
                            {
                                sumNum += div % 10;
                                div /= 10;
                                score++;
                            }

                        }
                            
                                Console.WriteLine(score);
                                DateTime finish = DateTime.Now;
                                Console.WriteLine(finish - start);
                                Console.WriteLine(score);
                                break;
                            
                    #endregion
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