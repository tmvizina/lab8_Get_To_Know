using System;
using System.Collections.Generic;
using System.IO;
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
            List<Students> studentobjects = new List<Students>();

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

            Students mark = new Students();
            mark.Name = "Mark Haines";
            mark.Hometown = "Grand Rapids";
            mark.Homestate = "Michigan";
            mark.Favoritefood = "Cilantro";
            studentobjects.Add(mark);

            students.Add("James Moulton");
            hometown.Add("Toledo");
            homestate.Add("Ohio");
            favoritefood.Add("Sushi");
            studentID.Add("2");

            Students james = new Students();
            james.Name = "James Moulton";
            james.Hometown = "Toledo";
            james.Homestate = "Ohio";
            james.Favoritefood = "Sushi";
            studentobjects.Add(james);

            students.Add("Andrew Kilma");
            hometown.Add("Grayslake");
            homestate.Add("Illinois");
            favoritefood.Add("Sushi");
            studentID.Add("3");

            Students andrew = new Students();
            andrew.Name = "Andrew Kilma";
            andrew.Hometown = "Grayslake";
            andrew.Homestate = "Illinois";
            andrew.Favoritefood = "Sushi";
            studentobjects.Add(andrew);

            students.Add("Tommy Waalkes");
            hometown.Add("Raleigh");
            homestate.Add("North Carolina");
            favoritefood.Add("Chicken Curry");
            studentID.Add("4");

            Students tommy = new Students();
            tommy.Name = "Tommy Waalkes";
            tommy.Hometown = "Raleigh";
            tommy.Homestate = "North Carolina";
            tommy.Favoritefood = "Chicken Curry";
            studentobjects.Add(tommy);


            students.Add("Maggie Tamanini");
            hometown.Add("Monrtrose");
            homestate.Add("Michigan");
            favoritefood.Add("Movie Theatre Popcorn");
            studentID.Add("5");

            Students maggie = new Students();
            maggie.Name = "Maggie Tamanini";
            maggie.Hometown = "Monrtrose";
            maggie.Homestate = "Michigan";
            maggie.Favoritefood = "Movie Theatre Popcorn";
            studentobjects.Add(maggie);

            students.Add("Jerome Brown");
            hometown.Add("Milwaukee");
            homestate.Add("Wisconsin");
            favoritefood.Add("Italian Cuisine");
            studentID.Add("6");
            Students jerome = new Students();
            jerome.Name = "Jerome Brown";
            jerome.Hometown = "Milwaukee";
            jerome.Homestate = "Wisconsin";
            jerome.Favoritefood = "Italian Cuisine";
            studentobjects.Add(jerome);

            students.Add("Trent Nedbal");
            hometown.Add("Rochester");
            homestate.Add("Michigan");
            favoritefood.Add("Tacos");
            studentID.Add("7");


            Students trent = new Students();
            trent.Name = "Trent Nedbal";
            trent.Hometown = "Rochester";
            trent.Homestate = "Michigan";
            trent.Favoritefood = "Tacos";
            studentobjects.Add(trent);

            students.Add("Kevin Jackson II");
            hometown.Add("Detroit");
            homestate.Add("Michigan");
            favoritefood.Add("Asian Cuisine");
            studentID.Add("8");

            Students kevin = new Students();
            kevin.Name = "Kevin Jackson II";
            kevin.Hometown = "Detroit";
            kevin.Homestate = "Michigan";
            kevin.Favoritefood = "Asian Cuisine";
            studentobjects.Add(kevin);

            students.Add("Joshua Carolin");
            hometown.Add("Northville");
            homestate.Add("Michigan");
            favoritefood.Add("Nalenski");
            studentID.Add("9");

            Students josh = new Students();
            josh.Name = "Joshua Carolin";
            josh.Hometown = "Northville";
            josh.Homestate = "Michigan";
            josh.Favoritefood = "Nalenski";
            studentobjects.Add(josh);

            students.Add("Sean Boatman");
            hometown.Add("Eaton Rapids");
            homestate.Add("Michigan");
            favoritefood.Add("MEAT");
            studentID.Add("10");

            Students sean = new Students();
            sean.Name = "Sean Boatman";
            sean.Hometown = "Eaton Rapids";
            sean.Homestate = "Michigan";
            sean.Favoritefood = "MEAT";
            studentobjects.Add(sean);

            students.Add("Kate Datema");
            hometown.Add("Zeeland");
            homestate.Add("Michigan");
            favoritefood.Add("Pizza");
            studentID.Add("11");

            Students kate = new Students();
            kate.Name = "Kate Datema";
            kate.Hometown = "Zeeland";
            kate.Homestate = "Michigan";
            kate.Favoritefood = "Pizza";
            studentobjects.Add(kate);

            students.Add("Troy Vizina");
            hometown.Add("Indian River");
            homestate.Add("Michigan");
            favoritefood.Add("Broccoli");
            studentID.Add("12");

            Students troy = new Students();
            troy.Name = "Troy Vizina";
            troy.Hometown = "Indian River";
            troy.Homestate = "Michigan";
            troy.Favoritefood = "Broccoli";

            studentobjects.Add(troy);

            ExportStudents(studentobjects);
           // AddStudent();

            //NOTE THIS GIANT BLOCK OF GARBAGE CODE IS MY LAST ATTEMPT AT THE LAB

            //Console.WriteLine("Welcome to your C# class. Which student would you like to learn more about? ");

            //Console.WriteLine("Would you like to search by student name or number?");

            //string nameornum = Console.ReadLine().ToLower();

            //if (nameornum == "number")
            //{

            //    string userRequested = GetUserInput($"Enter a number 1-12");

            //    int userRequestedIndex = int.Parse(userRequested) - 1;

            //    Console.WriteLine($"Student number {userRequested} is {students[userRequestedIndex]} What would you like to know about them?");



            //    while (goOn == true)
            //    {
            //        Console.WriteLine("(Hometown/favorite food/homestate) :");
            //        string usermoreinfo = Console.ReadLine();

            //        if (usermoreinfo.ToLower() == "hometown")
            //        {
            //            Console.WriteLine($"Student's hometown is {hometown[userRequestedIndex]}, would you like to know more (y/n)");
            //            knowMore = Console.ReadLine().ToLower();

            //            if (knowMore == "y")
            //            {

            //            }
            //            else if (knowMore == "n")
            //            {
            //                Console.WriteLine("Thanks!");
            //                goOn = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid");
            //            }
            //        }
            //        else if (usermoreinfo.ToLower() == "favorite food")
            //        {
            //            Console.WriteLine($"Student's favorite food is {favoritefood[userRequestedIndex]}, would you like to know more (y/n)");
            //            knowMore = Console.ReadLine().ToLower();

            //            if (knowMore == "y")
            //            {

            //            }
            //            else if (knowMore == "n")
            //            {
            //                Console.WriteLine("Thanks!");
            //                goOn = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid");
            //            }

            //        }
            //        else if (usermoreinfo.ToLower() == "homestate")
            //        {
            //            Console.WriteLine($"Student's Homestate is {homestate[userRequestedIndex]}, would you like to know more (y/n)");
            //            knowMore = Console.ReadLine().ToLower();

            //            if (knowMore == "y")
            //            {

            //            }
            //            else if (knowMore == "n")
            //            {
            //                Console.WriteLine("Thanks!");
            //                goOn = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("That data does not exist try again");
            //        }
            //    }
            //}
            //else if (nameornum == "name")
            //{
            //    Console.WriteLine("Please Enter a Name: ");
            //    string InputName = Console.ReadLine();

            //    int Index = students.IndexOf(InputName);
            //    if (Index != -1)
            //    {
            //        Console.WriteLine($"{InputName} is student number {students[Index]}, what would you like to know about them?");



            //        while (goOn == true)
            //        {
            //            Console.WriteLine("(Hometown/favorite food/homestate) :");
            //            string usermoreinfo = Console.ReadLine();

            //            if (usermoreinfo.ToLower() == "hometown")
            //            {
            //                Console.WriteLine($"Student's hometown is {hometown[Index]}, would you like to know more (y/n)");
            //                knowMore = Console.ReadLine().ToLower();

            //                if (knowMore == "y")
            //                {

            //                }
            //                else if (knowMore == "n")
            //                {
            //                    Console.WriteLine("Thanks!");
            //                    goOn = false;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid");
            //                }
            //            }
            //            else if (usermoreinfo.ToLower() == "favorite food")
            //            {
            //                Console.WriteLine($"Student's favorite food is {favoritefood[Index]}, would you like to know more (y/n)");
            //                knowMore = Console.ReadLine().ToLower();

            //                if (knowMore == "y")
            //                {

            //                }
            //                else if (knowMore == "n")
            //                {
            //                    Console.WriteLine("Thanks!");
            //                    goOn = false;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid");
            //                }
            //            }
            //            else if (usermoreinfo.ToLower() == "homestate")
            //            {
            //                Console.WriteLine($"Student's Homestate is {homestate[Index]}, would you like to know more(y / n)");
            //                knowMore = Console.ReadLine().ToLower();

            //                if (knowMore == "y")
            //                {

            //                }
            //                else if (knowMore == "n")
            //                {
            //                    Console.WriteLine("Thanks!");
            //                    goOn = false;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("That data does not exist try again");
            //            }
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Name not found in List");
            //    }
            //}

        }


        public static void ExportStudents(List<Students> studentobjects)
        {
            for (int i = 0; i < studentobjects.Count; i++)
            {
               string line = StudentToString(studentobjects[i]);

                Console.WriteLine(line);
                StreamReader reader = new StreamReader("Students.txt");
                string original = reader.ReadToEnd();
                reader.Close();

                StreamWriter writer = new StreamWriter("Students.txt");
                //Write override everything with the string
                writer.Write(original + line);

                writer.Close();

            }
        }

        public static void AddStudent()
        {
            string filePath = "Students.txt";
            Students s = new Students();
            Console.WriteLine("Please input a name");
            s.Name = Console.ReadLine();

            Console.WriteLine("Please input a Hometown");
            s.Hometown = Console.ReadLine();

            Console.WriteLine("Please input a Homestate");
            s.Homestate = Console.ReadLine();

            Console.WriteLine("Please input favorite food");
            s.Favoritefood = Console.ReadLine();

            string line = StudentToString(s);
            Console.WriteLine(line);

            StreamReader reader = new StreamReader(filePath);
            string original = reader.ReadToEnd();
            reader.Close();

            StreamWriter writer = new StreamWriter(filePath);
            //Write override everything with the string
            writer.Write(original + line);

            writer.Close();
        }

        public static string StudentToString(Students s)
        {
            string output = $"{s.Name}, {s.Hometown}, {s.Homestate}, {s.Favoritefood} \n";
            return output;
        }

        public static Students ConvertToStudents(string line)
        {
            string[] properties = line.Split(',');
            Students s = new Students();

            if (properties.Length == 4)
            {
                s.Name = properties[0];
                s.Hometown = properties[1];
                s.Homestate = properties[2];
                s.Favoritefood = properties[3];
                return s;
            }
            else
            {
                return null;
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

