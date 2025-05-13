using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1205_Project
{
    internal class Program
    {


        //arry of numbers
        static string[] series = new string[1];



        // Checks for arguments
        //static bool checkArgs(string[] args)
        //{
        //    return args.Length > 2;
        //}


        //Validation
        static bool Validation(string input)
        { 
                return int.TryParse(input , out _);
            

        }



        //Series request  
        static void seriesRequest()
        {
            Console.WriteLine("Please enter at least 3 positive numbers with a space between them:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');



        }
        //Args or a series from the user
        //static void seriesSelection(string[] args)
        //{
        //    if (checkArgs(args))
        //    {
                
        //    }

        //}








        static void Main(string[] args)
        {

            

        }
    }
}
