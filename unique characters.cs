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
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CodingAlgorithms
{
    //Implement an algorithm to determine if a string has all unique characters.
    //What if you cannot use additional data structures?
    //Source: Cracking the Coding Interview p. 73
 
    //Uses a dictionary to store each character and checks for a duplicate entry
    public static class UniqueString
    {
        public static bool IsUnique(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
 
            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                    return false;
                else
                    d.Add(c, 1);
            }
            return true;
        }
 
        //Compares each character to every other character without using an additional data structure
        //O(n^2) time complexity
        public static bool IsUnique1(string s)
        {
            string temp1 = "";
            string temp2 = "";
 
            for (int i = 0; i < s.Length; i++)
            {
                temp1 = s.Substring(i, 1);
                for (int k = 0; k < s.Length; k++)
                {
                    temp2 = s.Substring(k, 1);
                    if ((temp1 == temp2) && (i != k))
                        return false;
                }
            }
            return true;
        }
    }
}
