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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        DateTime d;
        if (year < 1917)
        {
            JulianCalendar julian = new JulianCalendar();
            d = new DateTime(year, 1, 1, julian).AddDays(255);
            d = new DateTime(julian.GetYear(d), julian.GetMonth(d), julian.GetDayOfMonth(d));
        }
        //GregorianCalendar
        else if (year == 1918)
            d = new DateTime(year, 1, 1).AddDays(255 + 13);
        else
            d = new DateTime(year, 1, 1).AddDays(255);

        return d.ToString("dd.MM.yyyy");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        Console.WriteLine(result);

       
    }
}
