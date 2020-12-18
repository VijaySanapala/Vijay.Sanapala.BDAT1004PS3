using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int getTotalX(int[] a, int[] b)
    {
        int lcm = GetLCMByArr(a);
        int gcd = GetGCDByArr(b);
        int totalCount = 0;
        for (int i = lcm, j = 2; i <= gcd; i = lcm * j, j++)
        {
            if (gcd % i == 0)
            {
                totalCount++;
            }
        }
        return totalCount;
    }

    // GCD = greatest common divisor
    static int GetGCD(int a, int b)
    {
        int gcd = 1;
        int minVal = Math.Min(a, b);
        for (int i = 2; i <= minVal; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                gcd = i;
            }
        }
        return gcd;
    }

    // LCM = least common multiple
    static int GetLCM(int a, int b)
    {
        return a * b / GetGCD(a, b);
        /*
        int lcm = 1;
        int maxVal = Math.Max(a, b);
        for (int i = maxVal; ;i++)
        {
            if (i % a == 0 && i % b == 0)
            {
                lcm = i;
                break;
            }
        }
        return lcm;
        */
    }

    static int GetGCDByArr(int[] arr)
    {
        int gcd = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            gcd = GetGCD(gcd, arr[i]);
        }
        return gcd;
    }

    static int GetLCMByArr(int[] arr)
    {
        int lcm = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            lcm = GetLCM(lcm, arr[i]);
        }
        return lcm;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}