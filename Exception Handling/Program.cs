using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
   
    internal class Program
    {
        static int n1, n2;
        static string op;
        static void Main(string[] args)
        {
            try
            {
                TakeInputs();
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                        break;
                    case "-":
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                        break;
                    case "*":
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                        break;
                    case "/":
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                        break;
                }
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();




            Console.ReadKey();

        }//Main

        /// <summary>
        /// Takes user input
        /// </summary>
        /// <exception cref="FormatException">
        /// Integer input using parse
        /// </exception>
        /// <exception cref="Exception"></exception>
        static void TakeInputs()
        {
            try
            {
                Console.Write("Number #1: ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Number #2: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Write("Operation (+,-,*,/): ");
                op = Console.ReadLine();
            }
            catch (FormatException fex)
            {
                //Console.WriteLine($"Input error: {fex.Message}");
                throw fex;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Unknown error: {ex.Message}");
                throw ex;
            }

        }
    }//Class
}//Namespace
