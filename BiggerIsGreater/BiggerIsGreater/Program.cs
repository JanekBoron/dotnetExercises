using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        char[] chars = w.ToCharArray();
        if (chars.Length > 2 && w[0] == w[1])
        {
            return "no answer";
        }

        
       int i=w.Length-1;
        while (i > 0 && chars[i - 1] >= chars[i])
        {
            i--;

        }

        if (i <= 0)
            return "no answer";

        int j = w.Length - 1;

        while(chars[j] <= chars[i - 1])
        {
            j--;
           
        }
        char temp = chars[i - 1];
        chars[i - 1] = chars[j];
        chars[j] = temp;


        j = chars.Length - 1;
        while (i < j)
        {
            temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
            i++;
            j--;
        }

        string result = new string (chars);
        return result; 

    }
}

class Solution
{
    public static void Main(string[] args)
    {

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            Console.WriteLine(result);
        }


    }
}
