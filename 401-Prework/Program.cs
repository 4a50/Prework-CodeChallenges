using System;

namespace PreWorkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            fiveNumbers();

        }
        static void fiveNumbers()
        {
            Console.WriteLine("Enter 5 number between 1 and 10");
            string userInput = Console.ReadLine();
            string[] userNums = userInput.Split(' ');


            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(userNums[i]);
                Console.Write(nums[i].ToString() + " ");
            }

            Console.WriteLine("Enter a number to search for:");
            string searchString = Console.ReadLine();
            int numberCounted = 0;
            foreach (int q in nums)
            {
                if (q == int.Parse(searchString))
                {
                    numberCounted++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The number {searchString} appears {numberCounted} times");
        }
    }
}
