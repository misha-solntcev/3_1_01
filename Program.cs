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
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
