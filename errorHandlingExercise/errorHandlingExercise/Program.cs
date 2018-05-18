using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace errorHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           /* StreamReader sr = null;

            try
            {

                sr = File.OpenText(@"C:\Users\student\Documents\kc1.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("and the program continues...."); */

            int[] myArray = { 1, 2, 3 };
            int total = 0;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(myArray[i]);
                    total += myArray[i];
                }
                
            }

            

            catch (IndexOutOfRangeException errMsg)
            {

                Console.WriteLine(errMsg.Message);
            }

            try
            {
                total = total / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            



        }
    }
}
