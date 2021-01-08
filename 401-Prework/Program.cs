using System;
using System.Text;

namespace PreWorkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 3, 2 };
            //fiveNumbers();
            //leapYear(2000);
            //Console.WriteLine(perfectSequence(intArray));

            
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[] sumArray = sumOfRows(myArray);
            //For displaying the sumOfRows Exercise
            StringBuilder display = new StringBuilder("Sum of the Array: [ ");
            foreach (int i in sumArray) { display.Append(i + " "); }
            display.Append("]");
            Console.WriteLine(display.ToString());
            
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
            };
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

        static string perfectSequence(int[] intArray)
        {
            string str;
            int sumArray = 0;
            int productArray = 1;
            bool isPerfect = false;
            bool hasNegative = false;

            foreach (int i in intArray)
            {
                if (i < 0)
                {
                    hasNegative = true;
                }
                sumArray += i;
                productArray *= i;
            }
            if (sumArray == productArray) { isPerfect = true; }
            if (isPerfect == true && hasNegative == false) { str = "Yes"; }
            else { str = "No"; }

            ///Perfect Sequence: 
            /// (1) non-negative ints.  
            /// (2) product of sequence is = thier sum

            return str;
        }

        static int[] sumOfRows(int[,] multiArray)
        {
            int length = multiArray.GetLength(0);
            int width = multiArray.GetLength(1);
            int[] sumArray = new int[length];
               
                int rowSum = 0;                
                for (int i = 0; i < length; i++)
                {                    
                    for (int j = 0; j < width; j++)
                    {
                        rowSum += multiArray[i, j];
                    }
                    sumArray[i] = rowSum;
                    rowSum = 0;
                }                
            return sumArray;
        }
        static int[,] randomArrayGenerator(int length, int width)
        {
            Random rand = new Random();            
            int randNumber;
            int[,] multiArray = new int[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    randNumber = rand.Next(1, 20);
                    multiArray[i, j] = randNumber;                    
                }
            }
            return multiArray;
        }
    }
}
