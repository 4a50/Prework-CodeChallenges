using System;

namespace PreWorkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //fiveNumbers();
            for (int i = 1999; i < 2050; i++)
            {

                if (leapYear(i)) { Console.WriteLine($"Year: {i}  isLeapYear: {leapYear(i)}"); }
            }
        }
        static void fiveNumbers()
        {
            bool enoughNums = false;
            bool inRange = true;
            string userInput;
            string[] userNums;
            int[] nums = new int[5];


            while (!enoughNums || !inRange)
            {
            Console.WriteLine("Enter 5 numbers between 1 and 10");
                userInput = Console.ReadLine();
                userNums = userInput.Split(' ');
                if (userNums.Length == 5)
                {
                    enoughNums = true;
                }
                inRange = true;
                Console.Write("int Array: ");
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = int.Parse(userNums[i]);
                    if (nums[i] < 1 || nums[i] > 10)
                    {
                        inRange = false;
                    }
                    Console.Write(nums[i].ToString() + " ");
                }                
            } ;
            Console.WriteLine();
            Console.WriteLine("Enter a number to search for:");
            
            int searchVal = int.Parse(Console.ReadLine());
            int numberCounted = 0;
            
            foreach (int q in nums)
            {
                if (q == searchVal)
                {
                    numberCounted++;
                }
            }
            int score = numberCounted * searchVal;
            Console.WriteLine();
            Console.WriteLine($"Your Score based on {searchVal} is {score}");

        }
        static bool leapYear(int year)
        {
            
            bool isLeapYear = false;
            //if year is /4
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
            else
                {
                    isLeapYear = true;
                }

            }
                return isLeapYear;
        }
    }
}
