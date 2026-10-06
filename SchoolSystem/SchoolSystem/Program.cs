using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 – Student Information 
            string studentName = "Sami Ali";
            int studentAge = 20;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char studentGender = 'M';
            bool isStudentActive = true;
            Console.WriteLine("//Part 1 – Student Information\n");
            
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("Name:"+studentName);
            Console.WriteLine("Age:"+studentAge);
            Console.WriteLine("Grade:"+studentGrade);
            Console.WriteLine("Average:"+studentAverage);
            Console.WriteLine("Gender:"+studentGender);
            Console.WriteLine("Active:"+isStudentActive+"\n");
           
            //Part 2 – Multiple Students

            string[] students = { "Ahmad", "Sara", "Omar", "Lina" };
            Console.WriteLine("//Part 2 – Multiple Students\n");
            
            Console.WriteLine("===== Students =====");
            Console.WriteLine("Student 1:" + students[0]);
            Console.WriteLine("Student 2:" + students[1]);
            Console.WriteLine("Student 3:" + students[2]);
            Console.WriteLine("Student 4:" + students[3]);
            Console.WriteLine("Number of Students:" + students.Length+"\n");
           

            //Part 3 – Access and Change Array Elements
            Console.WriteLine("//Part 3 – Access and Change Array Elements\n");
            Console.WriteLine(students[0]);
            Console.WriteLine(students[3]+"\n");
            
            Console.WriteLine("===== Before Change =====");
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            Console.WriteLine();

            students[2] = "Khaled";

            Console.WriteLine("===== After Change =====");
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);


        }
    }
}
