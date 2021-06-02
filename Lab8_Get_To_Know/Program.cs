using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8_Get_To_Know
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            string knowMore = "";

            //initilizes new lists of the stings that will keep the same indexes for all things added at the same time
            List<string> students = new List<string>();
            List<string> hometown = new List<string>();
            List<string> homestate = new List<string>();
            List<string> favoritefood = new List<string>();
            List<string> studentID = new List<string>();


            // Student Name
            // Student Hometown
            // Student Homestate ( I Split Hometown into to two attributes since a lot of the class didn't give more attritbutes to add and I wanted a value for all students)
            // Student Favorite Food
            // Student ID, this is the index Value+1 also referenced in input as student number
            //
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

            Console.WriteLine("Would you like to search by student name or number?");

            string nameornum = Console.ReadLine().ToLower();

            if (nameornum == "number")
            {

                string userRequested = GetUserInput($"Enter a number 1-12");

                int userRequestedIndex = int.Parse(userRequested) - 1;

                Console.WriteLine($"Student number {userRequested} is {students[userRequestedIndex]} What would you like to know about them?");



                while (goOn == true)
                {
                    Console.WriteLine("(Hometown/favorite food/homestate) :");
                    string usermoreinfo = Console.ReadLine();

                    if (usermoreinfo.ToLower() == "hometown")
                    {
                        Console.WriteLine($"Student's hometown is {hometown[userRequestedIndex]}, would you like to know more (y/n)");
                        knowMore = Console.ReadLine().ToLower();

                        if (knowMore == "y")
                        {

                        }
                        else if (knowMore == "n")
                        {
                            Console.WriteLine("Thanks!");
                            goOn = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    else if (usermoreinfo.ToLower() == "favorite food")
                    {
                        Console.WriteLine($"Student's favorite food is {favoritefood[userRequestedIndex]}, would you like to know more (y/n)");
                        knowMore = Console.ReadLine().ToLower();

                        if (knowMore == "y")
                        {

                        }
                        else if (knowMore == "n")
                        {
                            Console.WriteLine("Thanks!");
                            goOn = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }

                    }
                    else if (usermoreinfo.ToLower() == "homestate")
                    {
                        Console.WriteLine($"Student's Homestate is {homestate[userRequestedIndex]}, would you like to know more (y/n)");
                        knowMore = Console.ReadLine().ToLower();

                        if (knowMore == "y")
                        {

                        }
                        else if (knowMore == "n")
                        {
                            Console.WriteLine("Thanks!");
                            goOn = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist try again");
                    }
                }
            }
            else if (nameornum == "name")
            {
                Console.WriteLine("Please Enter a Name: ");
                string InputName = Console.ReadLine();

                int Index = students.IndexOf(InputName);
                if (Index != -1)
                {
                    Console.WriteLine($"{InputName} is student number {students[Index]}, what would you like to know about them?");



                    while (goOn == true)
                    {
                        Console.WriteLine("(Hometown/favorite food/homestate) :");
                        string usermoreinfo = Console.ReadLine();

                        if (usermoreinfo.ToLower() == "hometown")
                        {
                            Console.WriteLine($"Student's hometown is {hometown[Index]}, would you like to know more (y/n)");
                            knowMore = Console.ReadLine().ToLower();

                            if (knowMore == "y")
                            {

                            }
                            else if (knowMore == "n")
                            {
                                Console.WriteLine("Thanks!");
                                goOn = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                        }
                        else if (usermoreinfo.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"Student's favorite food is {favoritefood[Index]}, would you like to know more (y/n)");
                            knowMore = Console.ReadLine().ToLower();

                            if (knowMore == "y")
                            {

                            }
                            else if (knowMore == "n")
                            {
                                Console.WriteLine("Thanks!");
                                goOn = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                        }
                        else if (usermoreinfo.ToLower() == "homestate")
                        {
                            Console.WriteLine($"Student's Homestate is {homestate[Index]}, would you like to know more(y / n)");
                            knowMore = Console.ReadLine().ToLower();

                            if (knowMore == "y")
                            {

                            }
                            else if (knowMore == "n")
                            {
                                Console.WriteLine("Thanks!");
                                goOn = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist try again");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Name not found in List");
                }
            }

        }


        public static string GetUserInput(string message)
        {
            string output = "";
            Console.WriteLine(message);



                int input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 12)
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

