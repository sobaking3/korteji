using System;

namespace corteji
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Console.WriteLine(tuple.aga);
            Console.WriteLine(tuple.count);
            Console.WriteLine(tuple.sum);

            Console.Read();
        }
        private static (string aga, int count, int sum) GetNamedValues(int[] numbers)
        {
            var result = (aga: "Получили", count: 0, sum: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.aga = "Посчитано:";
                result.count++; 
                result.sum += numbers[i];
            }
            return result;
        }
    }
}
