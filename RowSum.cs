using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class RowSum
    {
        public void displayRowSum()
        {
            int[,] a = {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            int[] ansRow = new int[rows];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    ansRow[i]+= a[i,j]; 
                }
            }
            for (int i = 0; i < ansRow.Length; i++)
            {
                Console.WriteLine(ansRow[i]);
            }
        }
    }
}


            
