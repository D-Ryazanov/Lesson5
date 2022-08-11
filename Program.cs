using System;

class Program
{
    public static void Main(string[] args)
    {

        void Task34()
        {
            // Задайте массив заполненный случайными положительными трёхзначными числами. 
            // Напишите программу, которая покажет количество чётных чисел в массиве.

            Console.WriteLine("Укажите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Random random = new Random();
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 1000);
                if (array[i]%2 == 0)
                {
                    summ++;
                }
            }
             for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
                Console.WriteLine("В данном массиве количество четных чисел равно " + summ + ".");
        }
        //  ______________________________________________________________________________________________________________
        // |Извиняюсь если в прошлой задаче решение было не совсем честным, но в условиях такое решение небыло запрещено. |
        // |______________________________________________________________________________________________________________|


        void Task36()
        {
            // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

            Console.WriteLine("Укажите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Random random = new Random();
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
                if (i%2 == 0)
                {
                    summ = summ + array[i];
                }
            }
             for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("Сумма элементов массива стоящих на нечетных позициях равна " + summ + ".");

        }

        void Task38()
        {
            //  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

            Console.WriteLine("Укажите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[size];
            Random random = new Random();
            double diff = 0, temporary = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble()*10 - 5, 1);
            }
                         for (int i = array.Length - 1; i > 0; i--)
            {
                for (int a = 0; a < i; a++)
                    if (array[a] > array[i])
                    {
                        temporary = array[a];
                        array[a] = array[i];
                        array[i] = temporary;
                    }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            diff = array[size-1] - array[0];
            Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + diff + ".");
        }

        //Меню для более легкой проверки.

        Console.WriteLine("Укажите какое задание хотите проверить (34, 36, 38)");
        int task = Convert.ToInt32(Console.ReadLine());
        if (task == 34)
        {
            Task34();
        }
        else if (task == 36)
        {
            Task36();
        }
        else if (task == 38)
        {
            Task38();
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }
    }
}