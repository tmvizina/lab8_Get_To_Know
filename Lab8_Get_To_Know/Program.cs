using System;
using System.Collections.Generic;

namespace Lab8_Get_To_Know
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn=true;

            List<string> students = new List<string>();
            List<string> hometown = new List<string>();
            List<string> homestate = new List<string>();
            List<string> favoritefood = new List<string>();
            List<string> studentID = new List<string>();

            students.Add("Mark Haines");
            hometown.Add("Grand Rapids");
            homestate.Add("Michigan");
            favoritefood.Add("Cilantro");
            studentID.Add("1");

            students.Add("James Moulton");
            hometown.Add("Toledo");
            homestate.Add("Ohio");
            favoritefood.Add("Sushi");
            studentID.Add("2");

            students.Add("Andrew Kilma");
            hometown.Add("Grayslake");
            homestate.Add("Illinois");
            favoritefood.Add("Sushi");
            studentID.Add("3");

            students.Add("Tommy Waalkes");
            hometown.Add("Raleigh");
            homestate.Add("North Carolina");
            favoritefood.Add("Chicken Curry");
            studentID.Add("4");

            students.Add("Maggie Tamanini");
            hometown.Add("Monrtrose");
            homestate.Add("Michigan");
            favoritefood.Add("Movie Theatre Popcorn");
            studentID.Add("5");

            students.Add("Jerome Brown");
            hometown.Add("Milwaukee");
            homestate.Add("Wisconsin");
            favoritefood.Add("Italian Cuisine");
            studentID.Add("6");

            students.Add("Trent");
            hometown.Add("Rochester");
            homestate.Add("Michigan");
            favoritefood.Add("Tacos");
            studentID.Add("7");

            students.Add("Kevin Jackson II");
            hometown.Add("Detroit");
            homestate.Add("Michigan");
            favoritefood.Add("Asian Cuisine");
            studentID.Add("8");

            students.Add("Joshua Carolin");
            hometown.Add("Northville");
            homestate.Add("Michigan");
            favoritefood.Add("Nalenski");
            studentID.Add("9");

            students.Add("Sean Boatman");
            hometown.Add("Eaton Rapids");
            homestate.Add("Michigan");
            favoritefood.Add("MEAT");
            studentID.Add("10");

            students.Add("Kate Datema");
            hometown.Add("Zeeland");
            homestate.Add("Michigan");
            favoritefood.Add("Pizza");
            studentID.Add("11");

            students.Add("Troy Vizina");
            hometown.Add("Indian River");
            homestate.Add("Michigan");
            favoritefood.Add("Broccoli");
            studentID.Add("12");

            Console.WriteLine("Welcome to your C# class. Which student would you like to learn more about? ");

            string userRequested = GetUserInput($"\nEnter a number 1-12");

            int userRequestedIndex = int.Parse(userRequested) - 1;

            Console.WriteLine($"Student number {userRequested} is {students[userRequestedIndex]} What would you like to know about them?");

            Console.WriteLine("(Hometown/favorite food/homestate) :");

            while (goOn == true)
                {
                    string usermoreinfo = Console.ReadLine();

                    if (usermoreinfo.ToLower() == "hometown")
                    {
                        Console.WriteLine($"Student's hometown is {hometown[userRequestedIndex]}");
                        goOn = false;
                    }
                    else if (usermoreinfo.ToLower() == "favorite food")
                    {
                        Console.WriteLine($"Student's favorite food is {favoritefood[userRequestedIndex]}");
                        goOn = false;
                    }
                    else if (usermoreinfo.ToLower() == "homestate")
                    {
                        Console.WriteLine($"Student's Homestate is {homestate[userRequestedIndex]}");
                        goOn = false;
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist try again");
                    }
                }


        }


        public static string GetUserInput(string message)
        {
            string output = "";
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            

            if (input>=1&&input<=12)
            {
                output = input.ToString();
                return output;
            }
            else
            {
                output = "Invalid Student Number Given";
                Console.WriteLine(output);
                return output;
            }

            
        }
    }
}
