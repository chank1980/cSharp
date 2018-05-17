using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            // int[,] m2Array = new int[4, 5];
            int[,] m2Array = {
                                {0,1,2,3,4},
                                {2,3,4,5,6},
                                {4,5,6,7,8},
                                {6,7,8,9,10}
                               };
            int total = 0;

            //Console.WriteLine("Enter 5 numbers to be averaged. ");

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("Enter a number than press return: ");
            //    myArray[i] = Convert.ToInt32(Console.ReadLine());
            //    //myArray[i] = userInput;
            //}

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    total += myArray[i];
            //}
            //double average = (double)total / (double)myArray.Length;


            //Console.WriteLine("The average of your 5 numbers is :" +average);


            int[] rowTotal = new int[4];
            int[] colTotal = new int[5];
            int overallTotal = 0;
            for (int i = 0; i < m2Array.GetLength(0); i++)
            {
                
                for (int r = 0; r < m2Array.GetLength(1) ; r++)
                {
                    overallTotal += m2Array[i,r];
                    rowTotal[i] += m2Array[i, r];
                    colTotal[r] += m2Array[i, r];
                }
               

            }
            Console.WriteLine("total" + overallTotal);

            foreach(int i in rowTotal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            foreach (int i in colTotal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
