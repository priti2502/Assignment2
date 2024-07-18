using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MaxElement
    {
        public void displayMax()
        {
            int[] arr = [23, 4, 56, 34, 25, 67, 78, 69];
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine ("Max:"+ max); 

        }
    }
}
