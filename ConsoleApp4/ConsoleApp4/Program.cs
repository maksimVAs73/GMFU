using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class AbsoluteDifference
    {
        public static int CalculateDifference(int n)
        {
            int baseNumber = 123;
            int absoluteDifference = Math.Abs(n - baseNumber);

            if (n > baseNumber)
            {
                return absoluteDifference * 3;
            }
            else
            {
                return absoluteDifference;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n))
            {
                int difference = CalculateDifference(n);
                Console.WriteLine($"Абсолютная разность между {n} и 123: {difference}");
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }
        }
    }
}
