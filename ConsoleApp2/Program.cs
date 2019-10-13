using System;
using System.Collections.Generic;
using NUnit;
/*
 An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

    isIsogram "Dermatoglyphics" == true
    isIsogram "moose" == false
    isIsogram "aba" == false
*/
public class ConsoleApp2
{

    static void Main(string[] args)
    {
        int[] y = new int[] { 1, 2, 3, 4, 33, 5, 6, 7, 8, 45, 9, 10, 11, 12, 13, 88 };
        int result = binarySearch(y, 0, y.Length - 1, 45);

        Console.WriteLine(result);

        Console.WriteLine("--------------------");
        int[] a = { 3, 6, 1, 2, 3 };
        int[] b = { 9, 0, 7, 1, 2, 3 };
        int[] c = { 0, 5, 4, 0, 1, 2, 3 };
        int[] d = { 1, 2, 3, 9 };

        Console.WriteLine(isUnique(a) == false ? true : false);
        Console.WriteLine(isUnique(b) == true ? true : false);
        Console.WriteLine(isUnique(c) == false ? true : false);
        Console.WriteLine(isUnique(d) == true ? true : false);


    }



    public static int Feb(int num)
    {

        if (num < 3)
        {
            return 1;
        }
        else
        {
            return Feb(num - 1) + Feb(num - 2);
        }

    }

    public static int Feb2(int num)
    {

        if (num < 3)
        {
            return 1;
        }
        else
        {
            return Feb2(num - 1) + Feb2(num - 2);
        }

    }
    public static int binarySearch(int[] arr, int low, int high, int key)
    {
        int mid = (low + high) / 2;
        if (low > high)
        {
            return -1;
        }
        else
        {
            if (arr[mid] == key)
            {
                return mid;
            }
            else if (arr[mid] > key)
            {
                return binarySearch(arr, low, mid - 1, key);
            }
            else
            {
                return binarySearch(arr, mid + 1, high, key);
            }
        }


    }

    public static bool isUnique(int[] arr)
    {

        HashSet<int> a = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!a.Add(arr[i]))
            {
                return false;
            }
        }

        if (arr.Length != a.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        //Code here...
        int result = numbers[0] + numbers[1];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                if ((numbers[i] + numbers[j]) < result)
                {
                    result = (numbers[i] + numbers[j]);
                }
            }

        }
        return result;

    }

    public static bool IsIsogram(string str)
    {
        if (str == null)
        {
            return true;
        }
        str = str.ToLower();
        char[] arr = new char[str.Length];
        HashSet<char> set = new HashSet<char>();
        // Code on you crazy diamond!
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = str[i];
            set.Add(str[i]);
        }

        if (set.Count == str.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public static int DigitalRoot(long n) //132189
    {
        // Your awesome code here!
        string a = n.ToString();   //string a= "132189"
        long result = Convert.ToInt64(a);  //int result=132189;


        for (; ; )
        {
            if (result.ToString().Length == 1)
            {
                return Convert.ToInt32(result);
            }
            // int result= 132189
            string temp = result.ToString();
            int all = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                all += Convert.ToInt32("" + temp[i]);
            }
            result = all;
            continue;



        }



    }
}


