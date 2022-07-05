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

            // Сумма элементов с нечетными номерами:
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0)
                    sum += nums[i];
            }                
            Console.WriteLine($"sum = {sum}");

            // Первый отрицательный элемент:
            int first = 0;
            int last = 0;
            double summ = 0;            
            for (int i = 0; i < nums.Length; i++)            
                if (nums[i] < 0)
                {
                    first = i;
                    break;
                }                
            Console.WriteLine($"first = {first}");

            // Последний отрицательный элемент:
            for (int i = first; i < nums.Length; i++)            
                if (nums[i] < 0)                
                    last = i;                
            Console.WriteLine($"last = {last}");

            // Сумма элементов между отрицательными элементами:
            for (int i = first + 1; i < last; i++)
                summ += nums[i];                
            Console.WriteLine($"summ = {summ}");
            Console.ReadLine();
        }
    }
}
