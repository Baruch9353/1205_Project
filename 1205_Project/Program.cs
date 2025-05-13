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

        //List of numbers
        static List<double> series = new List<double>();


        
        // Checks for arguments
        static bool checkArgs(string[] args)
        {
            return args.Length > 0;
        }


        //Series request end Validation
        static void seriesRequest()
        {
            series.Clear();
            Console.WriteLine("Please enter at least 3 positive numbers with a space between them:");
            string strSeries = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
               
                string[] separator = new string[] { " " };
                
                //הורדת רווחים מיותרים
                StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries;

                string[] parts = input.Split(separator, options);



                List<double> numbers = new List<double>();

                foreach (string part in parts)
                {
                    if (double.TryParse(part, out double num) && num > 0)
                    {
                        numbers.Add(num);
                    }
                }
             

                if (numbers.Count >= 3)
                {
                    series = numbers;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter at least 3 positive numbers");
                }
            }

        }







        

        static void Main(string[] args)
        {
           
           
        }
    }
}
