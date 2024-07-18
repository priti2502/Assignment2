using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumAvgofArray
    {
        public void displaySumAvg()
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int sum = 0, avg=0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum:"+sum); 
            avg=sum/arr.Length; 
            Console.WriteLine("Average:"+avg); 
        }
    }
}
