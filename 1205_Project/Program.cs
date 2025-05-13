using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1205_Project
{
    internal class Program
    {
        static List <string> series = new List<string>();   

        //Validation
        static bool positiveNumber(string input)
        {
            return int.TryParse(input, out int number) && number > 0;
        }




        //Series request  
        static void seriesRequest()
        {         
            Console.WriteLine("Please enter at least 3 positive numbers with a space between them:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            foreach (string part in parts)
            {
                if (positiveNumber(part))
                { 
                   series.Add(part);                      
                }
                else
                {
                    seriesRequest();    
                }                
            }
            //menu()
        }



        //menu
        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("=========== MENU ===========");
            Console.WriteLine(" 1. Input a Series (Replace current)");
            Console.WriteLine(" 2. Display Series (Original Order)");
            Console.WriteLine(" 3. Display Series (Reversed Order)");
            Console.WriteLine(" 4. Display Series (Sorted Ascending)");
            Console.WriteLine(" 5. Display Max Value");
            Console.WriteLine(" 6. Display Min Value");
            Console.WriteLine(" 7. Display Average");
            Console.WriteLine(" 8. Display Number of Elements");
            Console.WriteLine(" 9. Display Sum");
            Console.WriteLine("10. Exit");
            Console.WriteLine("============================");
            Console.Write("Enter your choice (1-10): ");

            ChoiceMenu();
        }


        static void ChoiceMenu()
        {
            string choice = (Console.ReadLine());
            if (positiveNumber(choice))
            {
                switch (choice)
                {
                   
                }
            
        }








        static void Main(string[] args)
        {
            seriesRequest();

        }
    }
}
