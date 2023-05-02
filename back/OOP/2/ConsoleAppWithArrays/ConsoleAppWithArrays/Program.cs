using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2- Operates in one dimension array
            //doOpsOnArr();
            #endregion

            #region 3,4- Ops on 2d arr and calc sum of row and avg for col
            //opsOnTwoDimentionsArr();
            #endregion

            #region 5- Concat two array of 1d on new one array
            //initTwoArrays();
            #endregion

            #region 6- Count repeating element in array
            //getCountElemnt();
            #endregion

            #region 7- Check Uniqueness
            //initArray();
            #endregion

            #region 8- Get Power
            //getPower(2, 3);
            #endregion

            Console.ReadKey();
        }

        #region Operates in one dimension array
        public static void doOpsOnArr()
        {
            int[] arr = new int[setSize()];

            setValueInArray(arr);
            getArray(arr);
            getSumOfArr(arr);
            getEven(arr);
            getOdd(arr);
            getMax(arr);
            getMin(arr);
            getAvrage(arr);
        }

        #region Set Size from User
        public static int setSize()
        {
            Console.Write("Enter Array Size : ");
            int arrSize = int.Parse(Console.ReadLine());
            return arrSize;
        }
        #endregion

        #region Set Value in array
        public static int[] setValueInArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter the {i + 1} number : ");
                int num = int.Parse(Console.ReadLine());

                arr[i] = num;
            }
            return arr;
        }
        #endregion

        #region Display array
        public static int[] getArray(int[] arr)
        {
            string AllElemnts = "";
            for (int i = 0; i < arr.Length; i++)
            {
                AllElemnts += arr[i] + ",";
            }
            Console.WriteLine($"Elemnts is {AllElemnts}");
            return arr;
        }
        #endregion

        #region Get Sum of array
        public static int getSumOfArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"sum: {sum}");
            return sum;
        }
        #endregion

        #region get Even
        public static string getEven(int[] arr)
        {
            string allEven = "";
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    allEven += arr[i] + ",";
                }
            }
            Console.WriteLine($"odd : {allEven}");
            return allEven;
        }
        #endregion

        #region get Odd
        public static string getOdd(int[] arr)
        {
            string allOdd = "";
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    allOdd += arr[i] + ",";
                }
            }
            Console.WriteLine($"odd : {allOdd}");
            return allOdd;
        }
        #endregion

        #region get Max number
        public static int getMax(int[] arr)
        {
            Console.WriteLine($"Max = {arr.Max()}");
            return arr.Max();
        }
        #endregion

        #region get Min number
        public static int getMin(int[] arr)
        {
            Console.WriteLine($"Min = {arr.Min()}");
            return arr.Min();
        }
        #endregion

        #region get Avrage number
        public static double getAvrage(int[] arr)
        {
            Console.WriteLine($"Avrage = {arr.Average()}");
            return arr.Average();
        }
        #endregion

        #endregion

        #region Ops on 2d arr and calc sum of row and avg for col
        public static void opsOnTwoDimentionsArr()
        {
            Console.Write("Enter Number of Row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Col: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr = new int[row, col];



            fillTowDimArray(arr);
            displayArray(arr);
            getRowSummation(arr);
            getColSummation(arr);
        }


        #region Fill Two Dim Array
        public static int[,] fillTowDimArray(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the [{i + 1},{j + 1}] number : ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"**********************");
            }

            return arr;
        }
        #endregion

        #region Display Array
        public static void displayArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Sum of Row [{i},{j}] = {arr[i, j]}");
                }

            }
        }
        #endregion

        #region Get Row Summation
        public static void getRowSummation(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                    rowSum += arr[i, j];
                }
                Console.WriteLine($"Sum of Row {i + 1} = {rowSum}");
            }
        }
        #endregion

        #region Get Col Summation
        public static void getColSummation(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int colSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    colSum += arr[j, i];
                }
                Console.WriteLine($"AVG of Row {i + 1} = {colSum / arr.GetLength(1)}");
            }
        }
        #endregion

        #endregion

        #region Concat two array of 1d on new one array
        public static void initTwoArrays()
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 20, 30, 40, 50 };

            concateTwoArrays(arr1, arr2);
        }
        public static int[] concateTwoArrays(int[] arr1, int[] arr2)
        {
            int[] concatedArray = new int[] { };
            concatedArray = arr1.Concat(arr2).ToArray();
            return concatedArray;
        }
        #endregion

        #region Count repeating element in array
        public static void getCountElemnt()
        {
            int[] arr = new int[] { 1, 2, 3, 2, 4, 1, 5 };
            Dictionary<int, int> countOfItems = new Dictionary<int, int>();
            //count elem
            foreach (int eachNumber in arr)
            {
                if (countOfItems.ContainsKey(eachNumber))
                    countOfItems[eachNumber]++;
                else
                    countOfItems[eachNumber] = 1;
            }

            //display elemnts
            foreach (var pair in countOfItems)
            {
                Console.WriteLine($"arr - {pair.Key} : {pair.Value}");
            }

        }
        #endregion

        #region Check Uniqueness
        #region init Array
        public static void initArray()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = checkIsUnique(arr, i);
            }

        }
        #endregion

        #region check
        public static int checkIsUnique(int[] arr, int index)
        {
            Console.Write($"Enter the {index + 1} elemnt : ");
            int num = int.Parse(Console.ReadLine());

            while (arr.Contains(num))
            {
                Console.WriteLine("Array elemnts must be diffreancec");
                Console.Write($"Please Witle {index + 1} elemnt again: ");
                num = int.Parse(Console.ReadLine());
            };
            return num;
        }
        #endregion
        #endregion

        #region Get Power
        public static double getPower(int baseNum, int power)
        {
            Console.WriteLine(Math.Pow(baseNum, power));
            return Math.Pow(baseNum, power);
        }
        #endregion
    }
}
