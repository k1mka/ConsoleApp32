using System;

namespace ConsoleApp32
{
    internal class Program
    {
        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] GetRandomArray(uint lenght, int minValue, int maxValue)
        {
            int[] myArray = new int[lenght];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);

            Console.WriteLine("How element index you try to find?");
            int n = int.Parse(Console.ReadLine());

            int result = IndexOf(myArray, n);
            Console.WriteLine(result);
        }
    }
}
