
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CodingAlgorithm
{
    //Given an integer and an array of integers determine whether any two integers in the array sum to that integer.
    public static class TargetSum
    {
        //Brute force solution, O(n^2) time complexity
        public static bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = arr[i] + arr[k];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
