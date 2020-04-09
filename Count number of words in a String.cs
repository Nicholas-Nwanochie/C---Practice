
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
31
32
33
34
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CodingAlgorithms
{
    //Count the number of words in a string (Needs to handle multiple spaces between words)
    public static class WordCount
    {
        public static int Count(string x)
        {
            int result = 0;
 
            //Trim whitespace from beginning and end of string
            x = x.Trim();
 
            //Necessary because foreach will execute once with empty string returning 1
            if (x == "")
                return 0;
 
            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
                x = x.Replace("  ", " ");
 
            //Count the words
            foreach (string y in x.Split(' '))
                result++;
 
            return result;
        }
    }
}
