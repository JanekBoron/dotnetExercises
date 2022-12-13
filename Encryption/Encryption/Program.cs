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
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        int row;
        int col;
        char[,] table;
        s = String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));
        double count = s.Count();
        count = Math.Sqrt(count);
        int r = (int)Math.Round(count);

        if (r > count)
        {

            if (count == r)
            {
                row = r;
                col = r;
                table = new char[row, col];
            }
            else
            {
                row = r;
                col = r - 1;
                table = new char[row, col];
            }

        }
        else
        {
            if (count == r)
            {
                row = r;
                col = r;
                table = new char[row, col];
            }
            else
            {
                row = r;
                col = r + 1;
                table = new char[row, col];
            }
        }

        string a;
        List<char> result = new List<char>(s.Length + 10);
        int sSize = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col && sSize < s.Length; j++, sSize++)
            {
                table[i, j] = s[sSize];

            }

        }

        for (int j = 0; j < col; j++)
        {
            for (int i = 0; i < row; i++)
            {

                result.Add(table[i, j]);
            }
            result.Add(' ');
        }

        a = String.Concat(result);



        return a;



    }




}

class Solution
{
    public static void Main(string[] args)
    {


        string s = Console.ReadLine();

        string result = Result.encryption(s);

        Console.WriteLine(result);

    }
}
