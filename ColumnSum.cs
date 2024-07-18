using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ColumnSum
    {
        public void displayColumnSum()
        {
            int[,] a = {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            };

            int rows=a.GetLength (0); 
            int col=a.GetLength (1);

            int[] ansCol  = new int[col];

            for(int i = 0; i < col; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    ansCol[i] = ansCol[i] + a[j,i];
                }
            }

            for(int i=0;i<ansCol.Length;i++)
            {
                Console.WriteLine(ansCol[i]); 
            }



        }
    }
}
