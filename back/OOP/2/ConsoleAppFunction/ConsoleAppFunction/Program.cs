using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Calculate Sum of 2 numbers

            //Console.Write("enter your first num : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("enter your second num : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine(getSum(a, b));

            #endregion

            #region 2- get absolute diffrence bettwen n and 51

            //Console.Write("enter your num : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine(getAbsoluteDiffrence(a));

            #endregion

            #region 3- check if one of them >= 30 our sum of there == 30

            //Console.Write("enter your first num : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("enter your second num : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine(IsEqualThirty(a, b));

            #endregion

            #region 4- check if given num is positive is multiple of 3 or 7

            //Console.Write("enter your num : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine(isPositiveAndMultipleThreeOrSeven(a));

            #endregion

            #region 5- check two int of them is in the range 100..200

            //Console.Write("enter your first num : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("enter your second num : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine(isNumbersBetweenOneHundredAndTwoHundred(a, b));

            #endregion

            #region 6- check tree int of them is in the range 20..50

            //Console.WriteLine(isNumbersBetweenTweentyAndFifteen(15, 12, 8));

            #endregion

            #region 7- get the largest number in 3 numbers

            //Console.WriteLine(getTheLargestNumber(1, 3, 2));

            #endregion

            #region 8- get the nearest to the valuw 100 among two int

            //Console.WriteLine(getTheNearestNumber(98, 95));

            #endregion

            #region 9- check two int of them is in the range 40..50 or 50..60

            //Console.WriteLine(isNumbersBetweenFiftyAndSixty(78, 95));

            #endregion

            #region 10- get the larger value from 20..30 or return 0

            //Console.WriteLine(getTheLargerNumber(21, 25));

            #endregion

            #region 11- get number of copies string

            //Console.WriteLine(getCopies("JS", 1));

            #endregion

            #region 12- check in 2 int of one is 5 or sum of there is 5
            //Console.WriteLine(isEqualFive(1, 4));
            #endregion

            #region 13- check if 2 numbers is multiple of 3 or 7 , but not both
            //Console.WriteLine(isMultipleThreeOrSeven(42));
            #endregion

            #region 14- check is divid by 3 or 5
            //Console.WriteLine(IsDivisbleByThreeOrFive(20));
            #endregion

            #region 15- check it is possible to add two int to get the third number
            //Console.WriteLine(isFirstTwoNumberEqualThirdNumber(-1, 1, 0));
            #endregion

            #region 16- check y>x & z>y
            //Console.WriteLine(isSecondGreaterthanFirstandThirdGreaterthanSecond(-1, 1, 0));
            #endregion

            #region 17- get multiplication table
            //getMultiplicationTable();
            #endregion

            #region 18- get max value and min value
            //Console.WriteLine(getMaxAndMinValue(10, 20, 30));
            #endregion

            #region 19- get sum if 400 or higher execute
            //getSum();
            #endregion

            #region 20- small calculator
            //getSmallCalculator(4, 4);
            #endregion

            getEvensAndOddsNumbers(1, 10);

            Console.ReadKey();
        }

        #region Calculate Sum of 2 numbers
        public static int getSum(int a, int b)
        {
            if (a == b) return (a + b) * 3;
            else return a + b;
        }
        #endregion

        #region get absolute diffrence bettwen n and 51
        public static int getAbsoluteDiffrence(int a)
        {
            if (a > 51) return (a - 51) * 3;
            return 51 - a;
        }
        #endregion

        #region check if one of them >= 30 our sum of there == 30
        public static bool IsEqualThirty(int a, int b)
        {
            if (a >= 30 || b >= 30 || a + b == 30) return true;
            return false;
        }
        #endregion

        #region check if given num is positive is multiple of 3 or 7
        public static bool isPositiveAndMultipleThreeOrSeven(int a)
        {
            if (a > 0 && (a % 3 == 0 || a % 7 == 0)) return true;
            return false;
        }
        #endregion

        #region check two int of them is in the range 100..200
        public static bool isNumbersBetweenOneHundredAndTwoHundred(int a, int b)
        {
            if ((a >= 100 && a < 200) || (b >= 100 && b < 200)) return true;
            return false;
        }
        #endregion

        #region check tree int of them is in the range 20..50
        public static bool isNumbersBetweenTweentyAndFifteen(int a, int b, int c)
        {
            if ((a >= 20 && a < 50) || (b >= 20 && b < 50) || (c >= 20 && c < 50)) return true;
            return false;
        }
        #endregion

        #region get the largest number in 3 numbers
        public static int getTheLargestNumber(int a, int b, int c)
        {
            int[] arr = new int[3];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;
            return arr.Max();
        }
        #endregion

        #region get the nearest to the valuw 100 among two int
        public static int getTheNearestNumber(int a, int b)
        {
            int subtractionOfFirstNum = 100 - a;
            int subtractionOfSecondNum = 100 - b;

            if (subtractionOfSecondNum == subtractionOfFirstNum) return 0;
            else if (subtractionOfSecondNum > subtractionOfFirstNum) return a;
            return b;
        }
        #endregion

        #region check two int of them is in the range 40..50 or 50..60
        public static bool isNumbersBetweenFiftyAndSixty(int a, int b)
        {
            if ((a >= 40 && a < 50) || (b >= 40 && b < 50)) return true;
            if ((a >= 50 && a < 60) || (b >= 50 && b < 60)) return true;
            return false;
        }
        #endregion

        #region get the larger value from 20..30 or return 0
        public static int getTheLargerNumber(int a, int b)
        {
            if ((a >= 20 && a < 30) || (b >= 20 && b < 30)) return a > b ? a : b;
            return 0;
        }
        #endregion

        #region get number of copies string
        public static string getCopies(string str, int num)
        {
            if (num < 1) return str;
            return String.Concat(Enumerable.Repeat(str, num));
        }
        #endregion

        #region check in 2 int of one is 5 or sum of there is 5
        public static bool isEqualFive(int a, int b)
        {
            if ((a == 5 || b == 5) || (a + b == 5)) return true;
            return false;
        }
        #endregion

        #region check if 2 numbers is multiple of 3 or 7 , but not both
        public static bool isMultipleThreeOrSeven(int num)
        {
            if (num % (3 * 7) == 0) return false;
            else if (num % 3 == 0 || num % 7 == 0) return true;
            return false;
        }
        #endregion

        #region check is divid by 3 or 5
        public static string IsDivisbleByThreeOrFive(int num)
        {
            if (num % 3 == 0 || num % 5 == 0)
            {
                if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
                else if (num % 3 == 0) return "Fizz";
                return "Buzz";
            }
            return " Number can't divid by 3 or 5 ";
        }
        #endregion

        #region check it is possible to add two int to get the third number
        public static bool isFirstTwoNumberEqualThirdNumber(int a, int b, int c)
        {
            return a + b == c ? true : false;
        }
        #endregion

        #region check y>x & z>y
        public static bool isSecondGreaterthanFirstandThirdGreaterthanSecond(int a, int b, int c)
        {
            if (b > a && c > b) return true;
            return false;
        }
        #endregion

        #region get multiplication table
        public static void getMultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} table");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} * {j} =  {i * j}");
                }
                Console.WriteLine("--------------------------------");
            }
        }
        #endregion

        #region get max value and min value
        public static string getMaxAndMinValue(int a, int b, int c)

        {
            int[] arr = new int[3];

            arr[0] = a;
            arr[1] = b;
            arr[2] = c;

            int min = arr.Min();
            int max = arr.Max();

            return $"Max = {max} , Min = {min}";
        }
        #endregion

        #region get sum if 400 or higher execute
        public static void getSum()
        {
            int sum = 0;
            do
            {
                Console.Write("enter your num : ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                Console.WriteLine(sum);
            } while (sum <= 400);
        }
        #endregion

        #region small calculator
        public static void getSmallCalculator(int a, int b)
        {
        e: Console.WriteLine("chose \nsum (+)\nsubtraction (-)\ndivision (/)\nmultiplication (*)\nExit (e)");
            string opr = Console.ReadLine();
            double num = 0;
            if (opr != "e" || opr != "E")
            {
                switch (opr)
                {
                    case "+":
                        num = a + b;
                        Console.WriteLine(num);
                        goto e;
                    case "-":
                        num = a - b;
                        Console.WriteLine(num);
                        goto e;
                    case "*":
                        num = a * b;
                        Console.WriteLine(num);
                        goto e;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Math Error");
                            goto e;
                        }
                        else
                        {
                            num = a / b;
                            Console.WriteLine(num);
                            goto e;
                        }

                    case "e":
                    case "E":
                        break;
                    default:
                        goto e;
                }

            }
        }
        #endregion

        #region even and ood numbers
        public static void getEvensAndOddsNumbers(int a, int b)
        {
            if (a != b)
            {
                int sumOfEven = 0;
                var evenArr = new List<int>();


                int sumOfOdd = 0;
                var oddArr = new List<int>();
                if (a < b)
                {
                    for (int i = a; i < b; i++)
                    {
                        if (i % 2 == 0)
                        {
                            sumOfEven += i;
                            evenArr.Add(i);
                        }
                        else
                        {
                            sumOfOdd += i;
                            oddArr.Add(i);
                        }
                    }
                }
                for (int i = b; i < a; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumOfEven += i;
                        evenArr.Add(i);
                    }
                    else
                    {
                        sumOfOdd += i;
                        oddArr.Add(i);
                    }
                }

                string allEven = "";
                for (int i = 0; i < evenArr.Count; i++)
                {
                    allEven += evenArr[i] + ",";
                }
                string allOdd = "";
                for (int i = 0; i < oddArr.Count; i++)
                {
                    allOdd += oddArr[i] + ",";
                }
                Console.WriteLine($"Even:{allEven}");
                Console.WriteLine($"Even Sum:{sumOfEven}");
                Console.WriteLine($"Odd:{allOdd}");
                Console.WriteLine($"Odd Sum:{sumOfOdd}");

                Console.WriteLine($"Even sum - Odd sum :{sumOfEven - sumOfOdd}");
            }
            else
            {
                Console.WriteLine("2 Numbers must be different");
            }

        }
        #endregion
    }
}
