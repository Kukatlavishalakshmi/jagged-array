using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the array of four elements:
            int[][] jaggedarray = new int[4][];
            // initialize the elements:
            jaggedarray[0] = new int[2] { 7, 9 };
            jaggedarray[1] = new int[4] {12,42,26,38 };
            jaggedarray[2] = new int[6] { 3,5,7,9,11,13 };
            jaggedarray[3] = new int[3] { 4,6,8 };
            //display the array elements:
            for (int i=0;i<jaggedarray.Length; i++)
            {
                System.Console.Write("element({0}):", i + 1);
                for (int j = 0; j < jaggedarray[i].Length;j++)
                {
                    System.Console.Write(jaggedarray[i][j] + "\t");

                }
                System.Console.WriteLine();

            }
            Console.ReadLine();


        }
    }
}
