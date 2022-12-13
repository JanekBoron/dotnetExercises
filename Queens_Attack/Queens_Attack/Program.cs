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
     * Complete the 'queensAttack' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER row
     *  4. INTEGER column
     *  5. 2D_INTEGER_ARRAY obstacles
     */

    public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        int row = r_q;
        int column = c_q;
        int[] minDist = new int[] {
        n - column,
        row - 1,
        column - 1,
        n - row,
        Math.Min(n - column, row - 1),
        Math.Min(column - 1, row - 1),
        Math.Min(column - 1, n - row),
        Math.Min(n - column, n - row),

        };

        foreach (List<int> o in obstacles)
        {

            if (o[0] == row && o[1] > column)
                minDist[0] = Math.Min(minDist[0], o[1] - column - 1);

            if (o[1] == column && o[0] < row)
                minDist[1] = Math.Min(minDist[1], row - o[0] - 1);

            if (o[0] == row && o[1] < column)
                minDist[2] = Math.Min(minDist[2], column - o[1] - 1);

            if (o[1] == column && o[0] > row)
                minDist[3] = Math.Min(minDist[3], o[0] - row - 1);

            if (o[0] - row == column - o[1] && o[0] < row)
                minDist[4] = Math.Min(minDist[4], row - o[0] - 1);

            if (o[0] - row == o[1] - column && o[0] < row)
                minDist[5] = Math.Min(minDist[5], row - o[0] - 1);

            if (o[0] - row == column - o[1] && o[0] > row)
                minDist[6] = Math.Min(minDist[6], o[0] - row - 1);

            if (o[0] - row == o[1] - column && o[0] > row)
                minDist[7] = Math.Min(minDist[7], o[0] - row - 1);

        }

        return minDist.Aggregate((a, b) => a + b);


    }
}

class Solution
{
    public static void Main(string[] args)
    {


        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int row = Convert.ToInt32(secondMultipleInput[0]);

        int column = Convert.ToInt32(secondMultipleInput[1]);

        List<List<int>> obstacles = new List<List<int>>();

        for (int i = 0; i < k; i++)
        {
            obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
        }

        int result = Result.queensAttack(n, k, row, column, obstacles);

        Console.WriteLine(result);

    }
}
