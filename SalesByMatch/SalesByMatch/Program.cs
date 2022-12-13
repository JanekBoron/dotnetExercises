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
using System.Buffers;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var x = ArrayPool<int>.Shared;
        var aa = x.Rent(1000);
      
        
        //
        x.Return(aa);
        List<int> a = new List<int>(10000);

        LinkedList<int> xx = new LinkedList<int>();

        xx.AddFirst(1);
        xx.AddFirst(2);
        xx.AddFirst(1);
        xx.AddFirst(3);
        xx.AddFirst(5);

        var dic = new Dictionary<string, int>();


        int count = 0;
        Dictionary<int, int> pairs = new();
        foreach (int i in ar)
        {
            if (pairs.ContainsKey(i))
            {
                pairs[i]++;
                if (pairs[i] % 2 == 0) count++;
            }
            else
            {
                pairs.Add(i, 1);
            }
        }
        return count;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        var hash = new HashSet<int>();
        hash.Add(1);
        hash.Add(1);
        hash.Add(2);
        string train="a"
        train.method(4);
        dynamic q = new List<int>();
        q = 1;
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);

    }

    override
    public void cos(ref int a, out int b)
    {
        b = 0;
    }
}

static class train
{
    public static void method(this string strings, int c)
    {

    }
}


