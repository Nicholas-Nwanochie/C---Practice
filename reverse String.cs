
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CodingAlgorithms
{
    //Reverse a string
    public static class ReverseString
    {
        public static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }
    }
}
