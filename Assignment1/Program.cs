using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test_Rayhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = { 4, 2, 1, 3, 5 };
            ArrayManipulation.Splice(points, 3, 6);
        }
    }

    class Anagram
    {
        public static bool IsAnagram(string str1, string str2)
        {
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            str1 = new string(arr1);
            str2 = new string(arr2);
            if(str1 == str2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    class ArrayManipulation
    {
        //sorting
        public static void Sort(int[] arr)
        {
            Array.Sort(arr);
            foreach(int x in arr)
            {
                Console.Write(x);
            }
        }

        //reverse
        public static void Reverse()
        {
            int[] points = { 4, 2, 1, 3, 5 };
            Array.Reverse(points);
            foreach (int num in points)
            {
                Console.Write(num + ",");
            }
        }

        //splice
        public static void Splice(int[] arr, int indexNum, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            for(int x = 0; x<indexNum; x++)
            {
                newArr[x] = arr[x]; 
            }
            newArr[indexNum] = num;
            for(int y = newArr.Length-1; y==indexNum; y--)
            {
                newArr[y] = 2;
            }
            Console.Write(string.Join("", newArr));
        }
    }

    class CaesarCipher
    {
        public static void Caesar(string str)
        {
            char[] sentenceArray = str.ToCharArray();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] alphabetArray = alphabet.ToCharArray();
            string output_text = "";
            for(int x = 0; x<sentenceArray.Length; x++)
                {
                    for(int y = 0; y<alphabetArray.Length; y++)
                    {
                        if(sentenceArray[x] == alphabetArray[y])
                        {
                            sentenceArray[x] = alphabetArray[(y + 2) % alphabetArray.Length];
                            break;
                        }
                    }
                }
            output_text = new string (sentenceArray);
            Console.WriteLine(output_text);
        }
    }

    class FizzBuzz
    {
        public static void Fizzbuzz()
        {
            for (int x = 1; x <= 100; x++)
            {
                if (x % 2 == 0 && x % 3 == 0)
                {
                    Console.WriteLine(x + "Fizz Buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine(x + "Buzz");
                }
                else if (x % 2 == 0)
                {
                    Console.WriteLine(x + "Fizz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }

    class Iteration
    {
        public static int IndexOf(int[] arr, int num)
        {
            return Array.IndexOf(arr, num);
        }

        public static int LastIndex(int[] arr)
        {
            return arr[arr.Length - 1];
        }

        public static bool Includes(int[] arr, int num)
        {
            int pos = Array.IndexOf(arr, num);
            if(pos > -1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static void Fill(int[] arr, int num)
        {
            foreach(int x in arr)
            {
                arr[x] = num;
                Console.Write(num + ',');
            }
        }

        public static void Join(int[] arr, string pref)
        {
            for(int x = 0; x < arr.Length-1; x++)
            {
                Console.Write(arr[x] + pref);
            }
            Console.Write(arr[arr.Length - 1]);
        }

        public static void Sum(int[] arr)
        {
            int sum = 0;
            foreach(int x in arr)
            {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }

    class MaxChar
    {
    public static void MaxCharacter(string str)
        {
            var query = str.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
            Console.WriteLine(query);
        }
    }
    class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            str = rgx.Replace(str, "");

            int length = str.Length;
            for(int i=0; i<length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                    return false;
            }
            return true;
        }
    }

    class Recursion
    {
        public static int Factorial(int num)
        {
            if (num == 0)
                return 1;
            return num * Factorial(num - 1);
        }
    }

    class SortingAlgorithm
    {
        public static void BubbleSort()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            int temp;
            for (int j = 0; j <= arr.Length -2; j++)
            {
                for (int i = 0; i <= arr.Length -2; i++)
                {
                    if (arr[i] > arr[i +1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (int p in arr)
                Console.Write(p + " ");
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            for(int x = 0; x<arr.Length-1; x++)
            {
                int smallest = x;

                for(int y = x+1; y<arr.Length; y++)
                {
                    smallest = y;
                }
            }
            return arr;
        }
    }

    class Capitalizations
    {
        public static void Capitalize(string str)
        {
            char[] charsToTrim = {' '};
            string newstr = str.Trim(charsToTrim);
            char[] arr = newstr.ToCharArray();
            
            arr[0] = char.ToUpper(str[0]);
            for(int x = 0; x<arr.Length; x++)
            {
                if(arr[x] == ' ')
                arr[x+1] = char.ToUpper(str[x+1]);
                Console.Write(arr[x]);                
            }
            
        }
    }

    class Reversal
    {
        public static void Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            foreach(char x in arr)
            {
                Console.Write(x + "");
            }
        }
    }
}