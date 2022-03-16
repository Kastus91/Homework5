using System;
using System.Linq;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача №1

            //Посчитать количества нечетных и четных элементов массива.
            //Не путать с нечетными и четными индексами.

            /*Console.WriteLine("Введите количество элементов массива : \t");
            int count = int.Parse(Console.ReadLine());
            int[] Myarray = new int[count];
            for (int i = 0; i < Myarray.Length; i++)
            {
                Console.WriteLine($"Введите значение для элемента массива с индексом  {i} :\t");
                Myarray[i] = int.Parse(Console.ReadLine());
            }
            int numberOdd = 0;
            for (int i = 0; i < Myarray.Length; i++)
            {
                if (Myarray[i] % 2 == 0)
                    continue;
                else
                    numberOdd++;
            }
            Console.WriteLine($"количество нечетных элементов массива :  {numberOdd}");

            int numberEven = 0;
            for (int i = 0; i < Myarray.Length; i++)
            {
                if (Myarray[i] % 2 != 0)
                    continue;
                else
                    numberEven++;
            }
            Console.WriteLine($"количество чётных элементов массива :  {numberEven}");*/
            #endregion


            #region Задача №4

            //Поменять местами первую и вторую половину массива.
            /*Console.Write("Введите количество элементов массива: ");
            int elements = int.Parse(Console.ReadLine());

            int[] array = new int[elements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите число индекса: {i} \t");

                array[i] = int.Parse(Console.ReadLine());
            }          

            int count1 = 0;
            int count2 = array.Length / 2;

            while (count1 < array.Length / 2)
            {
                int temp = array[count1];
                array[count1] = array[count2];
                array[count2] = temp;

                count1++; count2++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }*/
            #endregion


            #region Задача №5 гавнокод

            // Циклически двинуть массив вправо на 1 элемент

            /*int[] array = { 3, 5, 7, 9, 11, 13 };
            int k = 2;
            int[] arraynew = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arraynew[(i + k) % arraynew.Length] = array[i];
            }
            Console.WriteLine(string.Join(", ", arraynew));*/
            #endregion


            #region Задача №7

            //В массиве из целочисленных элементов (включая отрицательные) вычислить:
            //а) минимальный по модулю элемент массива

            /*int[] arr = new int[] { -1, 5, 3, 6, 9, 0, 4, 14 };
            
            int min = arr.Select(Math.Abs).Min();
            
            int sum = arr.SkipWhile(x => x != 0).Select(Math.Abs).Sum();*/
            #endregion


            #region Сортировка массива

            // Сортировка массива
            /*int[] nums = new int[] { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }*/
            #endregion


       

        }
    }
}
