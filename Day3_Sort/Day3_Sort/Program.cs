using System;

namespace Day3_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Input size of the array:");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];

            //ArrayFilling
            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                int randomValue = random.Next(1, 100);
                array[i] = randomValue;
                Console.Write($"[{array[i]}]");
            }
            Console.WriteLine($"");

            int counterUpward = 0;
            int counterDownward = array.Length;

            //ArraySortingUpward
            for (int i = 0; counterUpward < counterDownward ; i++, counterUpward++, counterDownward--)
            {
                Console.WriteLine($"Sort(Upward). Cycle №{i+1}");
                for (int k = 0; k < array.Length - 1; k++)
                {
                    int arrayTemporaryNumber1 = array[k];
                    Console.Write($"[{array[k]}]");
                    int arrayTemporaryNumber2 = array[k + 1];
                    Console.WriteLine($"[{array[k + 1]}]");
                    if (array[k] > array[k + 1])
                    {
                        array[k] = arrayTemporaryNumber2;
                        array[k + 1] = arrayTemporaryNumber1;
                    }
                }

                Console.WriteLine($"Sort(Downward). Cycle №{i + 1}");

                for (int j = array.Length - 1; j > 0; j--)
                {

                    int arrayTemporaryNumber1 = array[j];
                    Console.Write($"[{array[j]}]");
                    int arrayTemporaryNumber2 = array[j - 1];
                    Console.WriteLine($"[{array[j - 1]}]");
                    if (array[j] < array[j - 1])
                    {
                        array[j] = arrayTemporaryNumber2;
                        array[j - 1] = arrayTemporaryNumber1;
                    }
                }
            }

            //ShowArray
            Console.WriteLine($"");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{array[i]}]");
            }
            Console.WriteLine($"");
        }

        static void ArrayFilling()
        {

        }

        public static int ArraySortingUpward(int counterUpward, params int [] array)
        {

            return 0;
        }

        public int ArraySortingDownward()
        {

            return 0;
        }

        static void Randomizer()
        {

        }
    }
}

