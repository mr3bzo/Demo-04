using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using static System.Formats.Asn1.AsnWriter;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace assignment_04 {
    class assignment_04
    {
        static void Main()
        {
            #region 01
            // 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i < number)
            //    {
            //        Console.Write(i);
            //    }
            //}
            #endregion
            #region 02
            // 2- Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.

            //Console.Write("Enter a number: ");
            //int numbers = int.Parse(Console.ReadLine());

            //Console.Write("Output: ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(numbers * i );
            //}
            #endregion
            #region 03
            // 3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter a number: ");
            //int numberz = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= numberz; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion
            #region 04
            // 4 - Write a program that takes two integers then prints the power.


            //Console.Write("Enter base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result = result * baseNum;
            //}

            //Console.WriteLine("Output: " + result);

            #endregion

            #region 05
            // 5 - Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = new string(input.Reverse().ToArray());
            //Console.WriteLine( reversed);

            #endregion
            #region 06
            //6- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Input starting number: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Input ending number: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.Write("Prime numbers: ");
            //for (int num = start; num <= end; num++)
            //{
            //    bool isPrime = true;
            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (num > 1 && isPrime)
            //        Console.Write(num );

            #endregion
            #region 07 
            //7 - .Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());
            //string binary = "";
            //int num = number;


            //while (num > 0)
            //{
            //    binary = (num % 2) + binary;
            //    num = num / 2;
            //}

            //Console.WriteLine(binary);

            #endregion
            #region 08 
            //8- . Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.Write("Enter Array : ");
            //int N = int.Parse(Console.ReadLine());
            //int[,] Matrix = new int[N, N];
            //for (int i = 0; i < Matrix.GetLength(0); i++)
            //{
            //    for (int n = 0; n < Matrix.GetLength(1); n++)
            //    {
            //        if (i == n)
            //        {
            //            Matrix[i, n] = 1;
            //        }
            //        Console.Write($"{Matrix[i, n]} ");
            //    }
            //    Console.WriteLine("  ");
            //}
            #endregion
            #region 09
            // 9- Write C# program that Extract a substring from a given string.

            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //Console.Write("Enter start position: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter length: ");
            //int length = int.Parse(Console.ReadLine());

            //string substring = text.Substring(start, length);
            //Console.WriteLine( substring);

            #endregion
            #region 10
            //10- Write C# program that take two string variables and print them as one variable 

            //Console.Write("Enter first string: ");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter second string: ");
            //string str2 = Console.ReadLine();

            //string result = str1 + str2;
            //Console.WriteLine( result);
            #endregion

            #region 11
            //11- . Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter Array : ");
            //int N = int.Parse(Console.ReadLine());
            //int[,] Matrix = new int[N, N];
            //for (int i = 0; i < Matrix.GetLength(0); i++)
            //{
            //    for (int n = 0; n < Matrix.GetLength(1); n++)
            //    {
            //        if (i == n)
            //        {
            //            Matrix[i, n] = 1;
            //        }
            //        Console.Write($"{Matrix[i, n]} ");
            //    }
            //    Console.WriteLine("  ");
            //}

            #endregion

            #region 12
            //12- Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];
            //int sum = 0;

            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter element " + (i+1) + ": ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            #endregion

            #region 13
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] numbers = { 5, 1, 8, 3 };
            //Array.Sort(numbers);
            //Console.WriteLine(string.Join(", ", numbers)); 

            //int[] numbers = { 1, 2, 3, 4 };
            //int[] newArray = new int[4];
            //Array.Copy(numbers, newArray, numbers.Length);


            //i cant think how can i combine those to solve the problem :(
            #endregion

            #region 14
            // 14 - Write a program in C# Sharp to count the frequency of each element of an array.


            #endregion
            #region 15
            //15- Write a program in C# Sharp to find maximum and minimum element in an array


            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < size; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine("Maximum: " + max);
            //Console.WriteLine("Minimum: " + min);
            #endregion

            #region 16
            // 16 - Write a program in C# Sharp to find the second largest element in an array.

            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //// Input array elements
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = arr[0];
            //int secondLargest = arr[0];

            //for (int i = 0; i < size; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = arr[i];
            //    }
            //    else if (arr[i] > secondLargest && arr[i] < largest)
            //    {
            //        secondLargest = arr[i];
            //    }
            //}

            //Console.WriteLine("Second largest: " + secondLargest);
            #endregion

            #region 17
            //17-. Consider an Array of Integer values with size N, having values as in this Example


            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //// Input array elements
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])


            // couldnt contnuie 


            #endregion


            #region 18
            // 18 - Write a program to create two multidimensional arrays of same size.
            // Accept value from user and store them in first array
            // . Now copy all the elements of first array on second array and print second array.



            //Console.Write("Enter number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element [{i},{j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Array.Copy(arr1, arr2, arr1.Length);

            //Console.WriteLine("Second Array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] );
            //    }
            //    Console.WriteLine();

            #endregion

            #region 19
            //19 - Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //// Input array elements
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Reverse order: ");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] );
            #endregion
















            }
    }
    }
        
