using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ArrayMethods
    {
        // Сортировка по возрастанию
        public static int[] SortAscending(int[] arr)
        {
            return arr.OrderBy(x => x).ToArray();
        }

        // Сортировка по убыванию
        public static int[] SortDescending(int[] arr)
        {
            return arr.OrderByDescending(x => x).ToArray();
        }

        // Объединение двух массивов
        public static int[] ConcatenateArrays(int[] arr1, int[] arr2)
        {
            return arr1.Concat(arr2).ToArray();
        }

        public static void Main(string[] args)
        {
            int[] array1 = { 5, 2, 9, 1, 5, 6 };
            int[] array2 = { 3, 8, 4, 7, 2 };

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array1));

            Console.WriteLine("\nОтсортированный по возрастанию:");
            int[] sortedAsc = SortAscending(array1);
            Console.WriteLine(string.Join(", ", sortedAsc));

            Console.WriteLine("\nОтсортированный по убыванию:");
            int[] sortedDesc = SortDescending(array1);
            Console.WriteLine(string.Join(", ", sortedDesc));

            Console.WriteLine("\nОбъединенные массивы:");
            int[] concatenated = ConcatenateArrays(array1, array2);
            Console.WriteLine(string.Join(", ", concatenated));
        }
    }
}
