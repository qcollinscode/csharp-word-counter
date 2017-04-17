using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Plu = "";
            string str = "";

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(" " + "Hello, Please enter a string of words. \n");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;

            string words = Console.ReadLine();
            Console.WriteLine("\n");

            Console.ResetColor();

            int resultStringLength = words.Split(' ').Length; 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------");
            Console.WriteLine(" " + "Number of Words");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            if(resultStringLength == 1)
            {
                Plu = "There is ";
                str = " word.";
            }
            else
            {
                Plu = "There are ";
                str = " words";
            }
            Console.WriteLine(" " + Plu + resultStringLength + str + "\n");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
