using System;
class Solution
{
    static string angry_Professor(int numberOfStudents, int threshold, int[] arrivalTimes)
    {
        int studentsOnTime = 0;

        for (int i = 0; i < numberOfStudents; i++)
        {
            if (arrivalTimes[i] <= 0)
                studentsOnTime++;
        }

        if (studentsOnTime >= threshold)
            return "NO";
        else
            return "YES";
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            Console.WriteLine(angry_Professor(n, k, a));
        }
    }
}