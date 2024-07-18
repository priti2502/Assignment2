namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumAvgofArray sum=new SumAvgofArray();
            sum.displaySumAvg();


            SumOfMatrix sumOfMatrix = new SumOfMatrix();
            sumOfMatrix.displaySum();

            MaxElement max=new MaxElement(); 
            max.displayMax(); 


            ColumnSum sumOfColumn = new ColumnSum();
            sumOfColumn.displayColumnSum();

            RowSum sumOfRow = new RowSum(); 
            sumOfRow.displayRowSum(); 

        }
    }
}
