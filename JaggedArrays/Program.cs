using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 8, 9 };
            jaggedArray[1] = new int[] { 4, 6, 4 };
            jaggedArray[2] = new int[] { 5, 6, 7, 8, 9, 3 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
