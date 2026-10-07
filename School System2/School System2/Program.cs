using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 – Enter Student Information
            Console.WriteLine("Enter Student  Information");
            Console.Write("Student Name:");
            string studentName = Console.ReadLine();
            Console.Write("Student Age:");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("•Student Grade:");
            int studentGrade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student Average:");
            double studentAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student Gender:");
            char studentGender = Convert.ToChar(Console.ReadLine());

            //Part 2 – Student Report
            Console.WriteLine("===== Student Report =====");
            Console.WriteLine($"Welcome,{studentName}!");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"Gender: {studentGender}");


            //Part 3 – Student Name
            Console.WriteLine("===== Name Information  =====");
            Console.WriteLine($"Original Name: {studentName}");
            Console.WriteLine($"Uppercase Name: {studentName.ToUpper()}");
            Console.WriteLine($"Lowercase Name: {studentName.ToLower()}");
            Console.WriteLine($"First Character:{studentName[0]}");

            //Part 4 – Simple Student Calculation
            Console.WriteLine("===== Student Average Calculation =====");
            Console.WriteLine($"Original Average:{studentAverage}");
            Console.WriteLine("Bonus Marks: 5");
            double newAverage = studentAverage + 5;
            Console.WriteLine($"New Average:{newAverage}");

            //Part 5 – Student Status
            bool Passed;
            bool Adult;
            Console.WriteLine("===== Student Status =====");
            if (newAverage >= 50)
            {
                Passed = true;
                Console.WriteLine($"Passed:{Passed}");
            }
            else
            {
                Passed = false;
                Console.WriteLine($"Passed:{Passed}");
            }
            if (studentAge >= 18)
            {
                Adult = true;
                Console.WriteLine($"Adult:{Adult}");
            }
            else
            {
                Adult = false;
                Console.WriteLine($"Adult:{Adult}");
            }

            
        }
    }
}
