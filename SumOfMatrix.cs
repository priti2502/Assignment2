using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumOfMatrix
    {
       public void displaySum()
        {
            int[,] a = 
            {
                {1,2,3},
                {3,4,5},
                {4,5,6}
            };

            int[,] b = 
            {
                {1,2,3},
                {3,4,5},
                {4,5,6}
            };
            int row=a.GetLength(0); 
            int col=b.GetLength(1); 
            int[,] ans = new int[row,col];

            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {

                    ans[i,j] = a[i,j] + b[i,j];                                                          
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                  Console.Write(ans[i,j]+" "); 
                   
                }
                Console.WriteLine();
            }
        }

    }
}
