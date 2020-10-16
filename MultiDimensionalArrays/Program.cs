using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialize and for
            ////int[] array = {1, 3, 9, 5} single dim array
            ////int[,] arrayMulti = new int[3, 4] multidimensional array
            ////Console.WriteLine(array[2, 0]);

            //int[,] multiArray = new int[2, 2];

            //multiArray[0, 0] = 30;
            //multiArray[0, 1] = 60;
            //multiArray[1, 0] = 90;
            //multiArray[1, 1] = 120;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(multiArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            //int[,] arrayMulti = new int[2, 2];

            #region entering values via consolereadline
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine($"Enter element into position {i} {j}");
            //        arrayMulti[i, j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //Console.WriteLine("You entered the following values");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(arrayMulti[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region init second way
            //int[,] arrayMulti = new int[,] { { 5, 9 }, { 8, 6 } };
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(arrayMulti[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Three dimensions
            //int[,,] data = new int[2, 2, 2] { { { 2, 3 }, { 9, 8 } }, { { 7, 3 }, { 1, 5 } } };

            //for (int i = 0; i < data.GetLength(0); i++)
            //{
            //    for (int j = 0; j < data.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < data.GetLength(2); k++)
            //        {
            //            Console.Write(data[i,j,k] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            

            #endregion


        }
    }
}
