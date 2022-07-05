using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 1
В одномерном массиве, состоящем из n вещественных элементов, вычислить:
 сумму элементов массива с нечетными номерами;
 сумму элементов массива, расположенных между первым и последним
отрицательными элементами.*/

namespace _3_1_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[] { 1, 2, -3, 4, 5, 6 ,-7, 8, 9 };
            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0)
                    sum += nums[i];
            }
                // Сумма элементов с нечетными номерами:
            Console.WriteLine($"sum = {sum}"); 
            
            int first = 0;
            int last = 0;
            double summ = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    first = i;
                    break;
                }
            }
                // Первый отрицательный элемент:
            Console.WriteLine($"first = {first}");

            for (int i = first; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    last = i;                    
                }
            }
                // Последний отрицательный элемент:
            Console.WriteLine($"last = {last}");

            for (int i = first + 1; i < last; i++)
                summ += nums[i];
                // Сумма элементов между отрицательными элементами:
            Console.WriteLine($"summ = {summ}");
            Console.ReadLine();
        }
    }
}
