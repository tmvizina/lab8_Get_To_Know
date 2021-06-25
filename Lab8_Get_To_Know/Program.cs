using System;
using System.Collections.Generic;
using System.IO;
using Lab8_Get_To_Know.Models;
using System.Linq;

namespace Lab8_Get_To_Know
{
    class Program
    {
        static void Main(string[] args)
        {


            //Loads db from SQL table made in SMSS
            CSMAYContext db = new CSMAYContext();
            List<Student> students = db.Students.ToList();

            //Initializes an instance of the student object created when Entity processes it
            //Then Adds it into the database
            Student scoobs = new Student() { FirstName = "Scooba", LastName = "Steve", Hometown = "Manhattan", Homestate = "New York", FavoriteFood = "Scooby Snacks" };
          //  AddStudent(scoobs,db);

   //         PrintList(students, db);

            //Deletes whatever student was added last, well specifically the 10th PK because there were 10 to begin with
            DeleteStudent(16, db);
     
            //This Updates an entry at the PK within the table
          Update(9, db);

            PrintList(students, db);




        }

        public static void PrintList(List<Student> students, CSMAYContext db)
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Id}  {s.FirstName}  {s.LastName}  {s.Hometown}  {s.Homestate}  {s.FavoriteFood}");
            }

        }


        public static void AddStudent(Student newStudent, CSMAYContext db)
        {
            //This is the same as a INSERT statement in SQL 
            db.Students.Add(newStudent);
            
            //This makes any changes we have done on the C# .Net side of things permanent 
            //You will need to call this method anytime you want to make changes 
            //IE Any CRUD action other than Read 
            db.SaveChanges();
        }

        public static void Update(int id, CSMAYContext db)
        {
            //Find the student by id 
            Student s = db.Students.Find(id);
            
            //Change something 
            s.FirstName = "Troy";
            
            //Pass their updates along and save changes
            db.Students.Update(s);
            db.SaveChanges();
            
        }


        //Warning Delete is permanent and irreversible 
        public static void DeleteStudent(int id, CSMAYContext db)
        {

            //Grab the student 
            Student s = db.Students.Find(id);

            //Tries to find and delete the student
            db.Students.Remove(s);

            db.SaveChanges();
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

