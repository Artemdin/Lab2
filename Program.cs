using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DraftForLab2
{
    class Program
    {
        static void DoBlock_1()
        {

            Console.WriteLine("Виберiть метод для пiдрахунку кiлькостi елементiв, кратних K:");
            Console.WriteLine("1. Цикл for");
            Console.WriteLine("2. Цикл while");
            Console.WriteLine("3. Цикл do while");

            int choice_1 = 0;
            bool isCorrect;
            do
            {
                choice_1 = int.Parse(Console.ReadLine());
                isCorrect = choice_1 != 1 && choice_1 != 2 && choice_1 != 3;
                if (isCorrect)
                {
                    Console.WriteLine("Вибраний не правильний цикл");

                }
            }
            while (isCorrect);



            Console.Write("Введiть число K: ");
            int K = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiлькiсть елементiв n: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            switch (choice_1)
            {
                case 1:
                    for (int i = 0; i < n; i++)//Ініціалізація;Умова;Оновлення
                    {
                        Console.Write($"Введiть число {i + 1}: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % K == 0)
                        {
                            count++;
                        }
                    }
                    break;

                case 2:
                    int j = 0;
                    while (j < n)
                    {
                        Console.Write($"Введiть число {j + 1}: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % K == 0)
                        {
                            count++;
                        }

                        j++;
                    }
                    break;

                case 3:
                    int k = 0;
                    do
                    {
                        Console.Write($"Введiть число {k + 1}: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % K == 0)
                        {
                            count++;
                        }

                        k++;
                    }
                    while (k < n);
                    break;


                default:
                    Console.WriteLine("Невірний вибір.");
                    return;
            }

            Console.WriteLine($"Кількість елементів, кратних {K}: {count}");
        }

        static void DoBlock_2()
        {
            Console.WriteLine("Оберіть цикл для виконання: ");
            Console.WriteLine("1. Цикл for");
            Console.WriteLine("2. Цикл while");
            Console.WriteLine("3. Цикл do while");

            int min = int.MaxValue;
            int max = int.MinValue;
            int choice_2 = 0;
            bool isCorrect;
            do
            {
                choice_2 = int.Parse(Console.ReadLine());
               isCorrect = choice_2 != 1 && choice_2 != 2 && choice_2 != 3;
                if (isCorrect) {
                    Console.WriteLine("Вибраний не правильний цикл");
                    
                }
            }
            while (isCorrect);
            Console.Write("Введiть число: ");
            int number = int.Parse(Console.ReadLine());

            switch (choice_2)
            {
                case 1:
                    for (; number != 0;) //Ініціалізація;Умова;Оновлення
                    {
                        if (number < min)
                        {
                            min = number;
                        }
                        if (number > max)
                        { max = number; }

                        Console.Write("Введiть число: ");
                        number = int.Parse(Console.ReadLine());
                    }
                    break;

                case 2:
                    while (number != 0)
                    {

                        if (number < min)
                            min = number;
                        if (number > max)
                            max = number;
                        Console.Write("Введiть число: ");
                        number = int.Parse(Console.ReadLine());
                    }

                    break;
            
                case 3:
                    do
                    {

                        if (number != 0)

                        { 
                            if (number < min)
                                min = number;
                            if (number > max)
                                max = number;
                        }

                        Console.Write("Введiть число: ");
                        number = int.Parse(Console.ReadLine());
                    } while (number !=0);
                    break;

                
            }

            
            if (min != int.MaxValue && max != int.MinValue)
            {
                int sum = min + max;
                Console.WriteLine($"Сума мiнiмального ({min}) i максимального ({max}): {sum}");
            }
            else
            {
                Console.WriteLine("Не введено жодного числа.");
            }
        }
       




        static void DoBlock_3()
        {
            Console.WriteLine("Виберiть метод для пiдрахунку кiлькостi елементiв, кратних K:");
            Console.WriteLine("1. Цикл for");
            Console.WriteLine("2. Цикл while");
            Console.WriteLine("3. Цикл do while");


            int choice_3 = 0; ;
            bool isCorrect;
            do
            {
                choice_3 = int.Parse(Console.ReadLine());
                isCorrect = choice_3 != 1 && choice_3 != 2 && choice_3 != 3;
                if (isCorrect)
                {
                    Console.WriteLine("Вибраний не правильний цикл");

                }
            }
            while (isCorrect);
            Console.WriteLine("Введiть натуральне число: ");
            int k1 = int.Parse(Console.ReadLine());
            int c = 0;

            switch (choice_3)
           {
               case 1:

                    for (; k1 > 0; k1 /= 10) //Ініціалізація;Умова;Оновлення
                    {
                        c++;
                    }
                    break ;
                
                case 2:
                    while (k1 > 0)
                    {
                        k1 /= 10;  
                        c++;   
                    }
                    break; 
                
                case 3:
                    do
                    {
                        c++;   
                        k1 /= 10;  
                    } while (k1 > 0);  
                    break;

                default:
                    Console.WriteLine("Невірний вибір циклу.");
                    return;
            }

            Console.WriteLine($"Кiлькiсть цифр: {c}");
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Для виконання блоку 1 (варiант 14) введiть 1");
                Console.WriteLine("Для виконання блоку 2 (варiант 27) введiть 2");
                Console.WriteLine("Для виконання блоку 3 (варiант 47) введiть 3");
                Console.WriteLine("Для виходу з програми введiть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую блок 1");
                        DoBlock_1();
                        break;
                    case 2:
                        Console.WriteLine("Виконую блок 2");
                        DoBlock_2();
                        break;
                    case 3:
                        Console.WriteLine("Виконую блок 3");
                        DoBlock_3();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
} //test
