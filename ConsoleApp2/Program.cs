using System;
using System.Collections.Generic;

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
        Console.WriteLine(DigitalRoot(493193));





       
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
        int result = Convert.ToInt32(a);  //int result=132189;
        
        
        for (; ; )
        {
            if (result.ToString().Length == 1) {
                return result;
            }
            // int result= 132189
            string temp=result.ToString();
            int all=0;
            for (int i = 0; i < temp.Length; i++) {
                 all += Convert.ToInt32("" + temp[i]);
            }
            result = all;
            continue;       
            

            
        }



    }
}


