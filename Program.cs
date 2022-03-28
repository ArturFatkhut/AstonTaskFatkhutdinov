using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstonTask_Fatkhutdinov_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Выберите номер задания: ");
                var j = Console.ReadLine();
                int task = 0;

                try
                {
                    task = Convert.ToInt32(j);
                }
                catch
                {
                    Console.WriteLine("Неверное число. Разрешено 1-3");
                    Console.WriteLine("Для выхода нажмите любую кнопку");
                    Console.ReadLine();
                    exit = true;
                }
                

                switch (task)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    default:
                        Console.WriteLine("Неверное число. Разрешено 1-3");
                        Console.WriteLine("Для выхода нажмите любую кнопку");
                        Console.ReadLine();
                        exit = true;
                        break;
                }
                void task1()
                {
                    Console.WriteLine("Задание 1\n");
                    Console.Write("Введите число: ");
                    int? n = Convert.ToInt32(Console.ReadLine());

                    if (n >= 7)
                    {
                        Console.WriteLine("Привет");
                    }
                    else
                    {
                        Console.WriteLine("Число меньше семи");
                    }

                    Console.ReadKey();
                }

                void task2()
                {
                    Console.WriteLine("Задание 2\n");
                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();

                    if (name == "Вячеслав")
                    {
                        Console.WriteLine("Привет, " + name);
                    }
                    else
                    {
                        Console.WriteLine("Нет такого имени");
                    }

                    Console.ReadKey();
                }

                void task3()
                {
                    Console.WriteLine("Задание 3\n");
                    Console.WriteLine("Задайте массив(например 3 4 6 7 0 1): ");
                    string data = Console.ReadLine();

                    var array = data.Split(' ').Select(Int32.Parse).ToArray();

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 3 == 0)
                        {
                            Console.Write(array[i] + " ");
                        }
                    }

                    Console.ReadKey();
                }

            }

        }


    }

}
