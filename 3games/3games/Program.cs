using System;

namespace игры
{
    internal class Programm
    {
        public static int viborcase;

        static void Main()
        {
            Start();

            while (true)
            {
                viborcase = int.Parse(Console.ReadLine());
                SelectedCase(viborcase);
            }
        }

        public static void Start()
        {
            Console.WriteLine("Привет! Это меню выбора программы.");
            Console.WriteLine("Выбери программу, которую ты хочешь запустить: ");
            Console.WriteLine("\t1 - Игра угадай число");
            Console.WriteLine("\t2 - Таблица умножения");
            Console.WriteLine("\t3 - Вывод делителей числа");
            Console.WriteLine("\t4 - Выход");
        }

        public static void SelectedCase(int vibor)
        {
            switch (vibor)
            {
                case 1:
                    {
                        int rnd = new Random().Next(0, 100);
                        int chislo;

                        Console.WriteLine("Я загадал число от 1 до 100, попробуй его отгадать");

                        while (true)
                        {
                            chislo = int.Parse(Console.ReadLine());
                            if (chislo == rnd)
                            {
                                Console.WriteLine("Отлично! Ты угадал");
                                break;
                            }
                            else
                            {
                                if (chislo > rnd)
                                {
                                    Console.WriteLine("Упс... введи число меньше");
                                }
                                else if (chislo < rnd)
                                {
                                    Console.WriteLine("Упс... введи число больше");
                                }
                            }
                        }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Таблица умножения");
                        Console.WriteLine("------------------");
                        int[,] multTable = new int[10, 10];
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.Write("\n");
                        }
                        break;
                    }

                case 3:
                    {
                        Console.Write("Введи число: ");
                        int i = int.Parse(Console.ReadLine());
                        for (int a = 1; a <= i; a++)
                        {
                            if (i % a == 0)
                            {
                                Console.Write(a + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("Выход");
                        Environment.Exit(0);
                        break;
                    }
            }

            Start();
        }
    }
}