using System;
using System.Security;
using System.Xml.Serialization;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster bb = new Blockbuster();

            bool checkedOut = true;



            while (checkedOut)
            {
                Console.Clear();
                Movie m = bb.Checkout();
                Console.WriteLine($"You have checked out {m.Title}");
                Console.WriteLine();
                m.PrintInfo();

                string userSelection = GetUserInput("Do you want to watch this movie? Enter y/n:  ");
                if (userSelection == "y")
                {
                    m.Play();
                    Console.WriteLine("Enter 1 to check out a new movie.  Enter 2 to return this one and go home: ");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        checkedOut = true;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Ok, thanks for chosing Blockbuter!");
                        break;
                    }
                }
                else if (userSelection == "n")
                {

                    Console.WriteLine("ok, lets get you back to the main menu to pick something else");
                    Console.WriteLine();
                    Console.WriteLine();
                    checkedOut = true;
                }
            }

        }
        public static string GetUserInput(string message)
        {
            Console.Write($"{message}");
            string response = Console.ReadLine();
            return response;
        }

        public static bool CheckedOut()
        {
            String userReply = Console.ReadLine().ToLower();

            if (userReply == "y")
            {
                return true;
            }

            else if (userReply == "n")
            {
                return false;
            }
            return false;
        }


    }
}
