using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1205_Project
{
    internal class Program
    {
        static List<int> series = new List<int>();

        //Validation
        static bool positiveNumber(string input, out int number)
        {
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine(input + "is not a number");
                return false;
            }

            if (number <= 0)
            {
                Console.WriteLine(input  + "is not a positive number");
                return false;
            }

            return true;
        }


         
        //Series request  
        static void seriesRequest()
        {
            if (series.Count > 0)
            {
                series.Clear();
            }

            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Please enter at least 3 positive numbers with a space between them:");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length >= 3)
                {
                    validInput = true;

                    foreach (string part in parts)
                    {
                        if (positiveNumber(part, out int number))
                        {
                            series.Add(number);
                        }
                        else
                        {
                            validInput = false;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You need to enter at least 3 numbers.");
                }
            }

            PrintMenu();
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

            choiceMenu();
        }



        //Original Order
        static void originalOrder()
        {
            foreach (int number in series)
            {
                Console.WriteLine(number);
            }
            anotherChoice();

        }

        //Reversed Order
        static void reversedOrder()
        {
            for (int i = series.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(series[i]);
            }
            anotherChoice();
        }

        //Sorted Ascending
        static void sortedAscending()
        {
            series.Sort();
            foreach (int number in series)
            {
                Console.WriteLine(number);
            }
            anotherChoice();
        }

        //Max Value
        static void maxValue()
        {
            int max = series[0];
            foreach (int number in series)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max Value: " + max);
            anotherChoice();
        }

        //Min Value
        static void minValue()
        {
            int min = series[0];
            foreach (int number in series)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine("Min Value: " + min);
            anotherChoice();
        }


        //Average
        static void average()
        {
            int sum = 0;
            foreach (int number in series)
            {
                sum += number;
            }
            double average = sum / series.Count;
            Console.WriteLine("Average: " + average);
            anotherChoice();
        }

        //Number of Elements
        static void numberOfElements()
        {
            Console.WriteLine("Number of Elements: " + series.Count);
            anotherChoice();
        }


        //Sum
        static void sum()
        {
            int sum = 0;
            foreach (int number in series)
            {
                sum += number;
            }
            Console.WriteLine("Sum: " + sum);
            anotherChoice();
        }


        //Exit
        static void exit()
        {
            Console.WriteLine("Goodbye!");
            return;
        }



        
        //Another choice
        static void  anotherChoice()
        {
            Console.WriteLine("Enter another choice(1 - 10) :");

        }

        static void choiceMenu()
        {
            int choice;

            do
            {
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out choice);

                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                else
                {
                    if (choice < 1 || choice > 10)
                    {
                        Console.WriteLine("Please enter a number between 1 and 10");
                        continue;
                    }
                    switch (choice)
                    {
                        case 1:
                            seriesRequest();
                            break;
                        case 2:
                            originalOrder();
                            break;
                        case 3:
                            reversedOrder();
                            break;
                        case 4:
                            sortedAscending();
                            break;
                        case 5:
                            maxValue();
                            break;
                        case 6:
                            minValue();
                            break;
                        case 7:
                            average();
                            break;
                        case 8:
                            numberOfElements();
                            break;
                        case 9:
                            sum();
                            break;
                        case 10:
                            exit();
                            break;
                        default:
                            Console.WriteLine("Please try again");
                            break;
                    }
                }

            } while (choice != 10); 
        }


















        static void Main(string[] args)
        {
            seriesRequest();

        }
    }
}
