/*
 Author: Victor Minaya
 Date: 2/9/2023
*/

using System;

namespace Methods_Application
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Boolean done = false;

            while (!done)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Enter an integer between 5 and 15");
                        int input = int.Parse(Console.ReadLine());

                        int[] sample_Array = random_array(input);

                        if (input >= 5 && input <= 15)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("The element in the random array are: ");
                            foreach (int element in sample_Array)
                            {
                                Console.WriteLine(element + " ");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("The sum is: " + sum(sample_Array));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter a numeric value in between 5 and 15.");
                        }  
                    }
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Enter a numeric value in between 5 and 15.");
                }
            }  
        }
    }
}