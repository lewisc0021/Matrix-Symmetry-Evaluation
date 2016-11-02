using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] StudentGrades = new int[5, 3];
            int NumberofRows = 0;
            int NumberofColumns = 0;

            NumberofRows = GetInput("Please enter the number of rows");

            NumberofColumns = GetInput("Please enter the number of columns");


            int[,] Grid = new int[NumberofRows, NumberofColumns];
            //int[,] Grid2 = new int[NumberofColumns, NumberofRows];

            for (int Row = 0; Row < NumberofRows; Row++)
            {
                Console.WriteLine("Row {0}", Row + 1);
                for (int Column = 0; Column < 3; Column++)
                {
                    Console.Write("Please enter Numbers for column{0}: ", Column + 1);
                    Grid[Row, Column] = int.Parse(Console.ReadLine());
                    //Grid2[Column, Row] = Grid[Row, Column];
                }
            }

            bool result = SymmetryCheck(Grid, NumberofRows, NumberofColumns);
            Console.WriteLine(result);

        }//MAIN

 
        private static int GetInput(string P)
        {
            int input;
            Console.WriteLine(P);

            input = int.Parse(Console.ReadLine());
            return input;
        }

        private static bool SymmetryCheck(int[,] Grid, int NumberofRows, int NumberofColumns)
        {
            bool result = true;
            int[] RowSums = new int[NumberofRows];
            int[] ColSums = new int[NumberofColumns];

            //Row Sum
            for (int row = 0; row < NumberofRows; row++)
            {
                int sum1 = 0;
                for (int column = 0; column < NumberofColumns; column++)
                {
                    sum1 += Grid[row, column];
                }
                RowSums[row] = sum1;
             }
            //Column Sum
            for (int row = 0; row < NumberofRows; row++)
            {
                int sum2 = 0;
                for (int column = 0; column < NumberofColumns; column++)
                {
                    sum2 += Grid[column, row];
                }
                ColSums[row] = sum2;
            }////////////////////////////////////////////



            //Printing RowSums and Column Sums
            Console.WriteLine("List of RowSums");
            for (int i = 0; i < RowSums.Length; i++)
            {
                Console.WriteLine(RowSums[i]);
            }
            Console.WriteLine();
            Console.WriteLine("List of ColSums");
            for (int i = 0; i < ColSums.Length; i++)
            {
                Console.WriteLine(ColSums[i]);
            }
            Console.WriteLine();
            //////////////////////////////////////////


            ///Evaluating the Boolean
            for (int i = 0; i < RowSums.Length; i++)
            {
                if (RowSums[i] != ColSums[i])
                    return false;
            }

            return result;
        } 

    }//PROGRAM
}///CLASS
