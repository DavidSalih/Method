/*
 Author: David Salih
 Date: 9/19/2019
 Description: Method
 */

using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            Console.Write("");

            try
            {
                string usrinput = Console.ReadLine();

                Console.WriteLine("Hello " + usrinput + "!");

            }
            catch
            {
                Console.WriteLine("Type name");
                Console.WriteLine("ESC to exit");
                Console.ReadKey(true);
            }
        }
    }
}
