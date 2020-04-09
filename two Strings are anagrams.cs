
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
namespace Anagram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
           //Receive Words from User  
            Console.Write("Enter first word:");  
            string word1 = Console.ReadLine();  
            Console.Write("Enter second word:");  
            string word2 = Console.ReadLine();  
   
            //Add optional validation of input words if needed.  
            //.....  
   
            //step 1  
            char[] char1 = word1.ToLower().ToCharArray();  
            char[] char2 = word2.ToLower().ToCharArray();  
   
            //Step 2  
            Array.Sort(char1);  
            Array.Sort(char2);  
   
            //Step 3  
            string NewWord1 = new string(char1);  
            string NewWord2 = new string(char2);  
   
            //Step 4  
            //ToLower allows to compare the words in same case, in this case, lower case.  
            //ToUpper will also do exact same thing in this context  
            if (NewWord1 == NewWord2)  
            {  
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);  
            }  
            else  
            {  
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);  
            }  
   
            //Hold Console screen alive to view the results.  
            Console.ReadLine();  
        }  
    }  
} 
