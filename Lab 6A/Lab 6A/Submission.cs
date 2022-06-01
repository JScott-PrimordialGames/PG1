using System;
using System.Diagnostics.Contracts;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * You cannot use multiple return statements any of these methods. 
         * Additionally the use of var is not permitted
         * 
        */

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {
            int[] result = new int[phrase.Length];
            for (int i = 0; i < phrase.Length; i++)
            {
                result[i] = phrase[i];
            }
            return result;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
        {
            double smallest = data[1];
            double largest = 0;
            double mean = 0;

            for (int i = 0;i < data.Length;i++)
            {
                if(data[i] > largest)
                    largest = data[i];
                if (data[i] < smallest)
                    smallest = data[i];
                mean += data[i];
            }

            mean /= data.Length;

            double[] result = new double[2];
            result[0] = smallest;
            result[1] = largest;
            result[2] = mean;
            return result;
        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double largest = 0;
            for (int i = 1; i <= numbers.Length; i++)
            {
                if(numbers[i] > largest)
                    largest = numbers[i];
            }

            for (int i = 1; i <= numbers.Length; i++)
            {
                double temp = numbers[i];
                numbers[i] = temp / largest;
            }
        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        public static bool Test4(string [] names)
        {
            string[] key = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                for (int x = 0; x < key.Length; x++)
                {
                    if (names[i] == key[x])
                        return false;
                } 
                key[i] = names[i];
            }
            return true;
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {
            string result = null;
            for (int i = 0; i < words.Length; i++)
                result += words[i].Substring(0, 1);
            return result;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            char[] result = new char[letters.Length];
            int i = letters.Length -1;
            for (int j = 0; j < letters.Length; j++)
            {
                result[i] = letters[j];
                i--;
            }
            return result;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //
        public static int[,] Test7(int[,] table)
        {
            int[,] result = new int[0,0];
            for (int i = 0;i < table.GetLength(0);i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    result[j, i] = table[i, j];
            }
            return result;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // 
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
            return null;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
            char [] result = new char[ascii.Length];
            for (int i = 0; i < ascii.Length; i++)
            {
                result[i] = (char)ascii[i];
            }
            return result;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if(i%2 != 0)
                {
                    word[i] = char.ToLower(word[i]);
                }
            }
        }
    }
}
