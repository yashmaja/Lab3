using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            bool repeat = true;

            while (repeat)
            {
                Console.Write($"\n{name}, please enter an integer between 1 and 100: ");
                string value = Console.ReadLine();
                int num;
                bool success = int.TryParse(value, out num); // check if Parse to int is succesful. If so, continue. If not, invalid input and try again.

                if (success)
                {
                    if (num >= 1 && num <= 100)
                    {

                        if (num % 2 == 1)
                        {
                            //a
                            Console.WriteLine($"{num} and Odd.");

                            //e - redundant?
                            /*if (num > 60)
                            {
                                Console.WriteLine($"{num} and Odd.");
                            }
                            */
                        }
                        else if (num % 2 == 0)
                        {
                            //b
                            if (num >= 2 && num <= 25)
                            {
                                Console.WriteLine($"{num} is even and less than 25.");
                            }

                            //c
                            else if (num <= 26)
                            {
                                Console.WriteLine("Even");
                            }

                            //d
                            else
                            {
                                Console.WriteLine($"\n{num} and Even");
                            }
                        }

                        while (true)
                        {

                            Console.Write($"\nWould you like to continue, {name}? (y/n) ");
                            string answer = Console.ReadLine();

                            if (answer == "n")
                            {
                                Console.WriteLine($"\nGoodbye {name}!");
                                repeat = false;
                                break;
                            }
                            else if (answer == "y")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Try again.");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nInvalid input. Try again.");
                    }
                }

                else
                {
                    Console.WriteLine("\nInvalid input. Try again.");
                }
            }
        }
    }
}
