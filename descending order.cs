
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CodingAlgorithms
{
    //Write a method to sort the elements of an array in descending order
    public static class SortDesc
    {
        public static void Sort(int[] x)
        {
            Array.Sort(x);
            Array.Reverse(x);
        }
    }
}
