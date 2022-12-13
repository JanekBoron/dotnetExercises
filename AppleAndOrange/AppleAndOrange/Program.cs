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
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */


    //s(AppleTreeSide) and t(OrangeTreeSide)  DOM
    //apple at point A Orange at Point B 
    //D = jaka dlugos owocu od drzewa : +prawa -lewa strona

    Func<string, int, double> h;
    Action<string, int, double> b;


   /* public static double test(string word, int digit);
    public static void actionTest(string word, int digit, double digit);
*/

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;
        /*for (int i = 0; i < apples.Count(); i++)
        {
            apples[i] += a;
            
            if (s <= apples[i] && apples[i]<=t)
            {
                appleCount++;
            }

            
        }*/
        appleCount=apples.Aggregate(0, (accum ,apple) =>
        {
            var position = apple + a;
            return (s <= position && position <= t) ? accum+1 : accum;
        },
        (accum) => accum + 10
        );

        for(int j = 0; j < oranges.Count(); j++)
        {
            oranges[j] += b;
            if (s <= oranges[j] && oranges[j] <= t)
            {
                orangeCount++;
            }
        }


        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
       


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);

    }
}
