﻿using System.CodeDom.Compiler;
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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;

        for (int i = a[0]; i <= b[b.Count()-1]; i++)
        {
            int firstLoop = 0;
            int secondLoop = 0;

            foreach (int num in a)
            {
                if (i % num == 0)
                    firstLoop++;
                else
                    break;
            }

            foreach (int num in b)
            {
                if (num % i == 0)
                    secondLoop++;
                else
                    break;
            }

            if (firstLoop == a.Count() && secondLoop == b.Count())
                count++;
        }

        return count;
    }
   
}



class Solution
{
    public static void Main(string[] args)
    {
        

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);

        
    }
}
