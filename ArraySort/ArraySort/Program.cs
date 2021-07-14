using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 55, 0, -3, 17, 22, 68, 5, 1 };
            SortByAscending(numbers);
            Console.WriteLine("Array sorted in an ascending order:");
            Display(numbers);
            SortByDescending(numbers);
            Console.WriteLine("Array sorted in a descending order:");
            Display(numbers);
        }

        static void SortByAscending(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
        }

        static void SortByDescending(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
        }

        static void Display(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("");
        }
    }
}
