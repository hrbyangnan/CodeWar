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
        Console.WriteLine(IsIsogram("helo"));
       
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
}


