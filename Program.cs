using StudentCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            var student = new Student() { StudentName = "John Doe" };
            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }

        Console.ReadLine();
    }
}
