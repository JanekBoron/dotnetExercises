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
using System.Numerics;

class Result
{

    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> newPlayerRank = new List<int>(player.Count);
        int rCount = 0;
        int position = 1;
        int maxRCount = ranked.Count() - 1;
        int previousRank = ranked[0];
        for (int i = player.Count() - 1; i >= 0; i--)
        {
            while (player[i] < ranked[rCount] && rCount < maxRCount)
            {
                rCount++;
                if (ranked[rCount] != previousRank)
                {
                    position++;
                    previousRank = ranked[rCount];
                }
                

            }
            if(!(rCount < maxRCount)&& player[i] < ranked[rCount])
            {
                newPlayerRank.Add(++position);
            }else newPlayerRank.Add(position);


        }
        newPlayerRank.Reverse();
        return newPlayerRank;

    }
}

class Solution
{
    public static void Main(string[] args)
    {


        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        Console.WriteLine(String.Join("\n", result));


    }
}
/*List<int> newPlayerRank = new List<int>(player.Count);
int previousRank = ranked[0];
int count = 1;
int playerRankNum = player.Count - 1;



foreach (int rank in ranked)
{

    if (playerRankNum > 0)
    {
        if (previousRank != rank)
        {
            count++;
            if (player[playerRankNum] >= rank)
            {
                newPlayerRank.Add(count);
                playerRankNum--;
            }
        }
        else
        {

            if (player[playerRankNum] >= rank)

            {
                newPlayerRank.Add(count);
                playerRankNum--;
            }
        }
        previousRank = rank;


    }
}

if (player[playerRankNum] < ranked[ranked.Count - 1])
{
    newPlayerRank.Add(++count);
}

newPlayerRank.Reverse();
return newPlayerRank;

*/