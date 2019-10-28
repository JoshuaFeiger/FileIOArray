using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataPath = @"Data\Students.txt";
            string[] Students;

            Students = new string[3];
            Students[0] = "Sue, McWaters, 34";
            Students[1] = "Bill, Tompson, 23";
            Students[2] = "Charlie, Velis, 22";

            WriteAllStudents(DataPath, Students);

            Students = ReadAllStudents(DataPath);

            DisplayStudentInfo(Students);
        }

        static void DisplayStudentInfo(string[] Students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Info");
            Console.WriteLine();
            Console.WriteLine(
                    "First Name".PadRight(15) +
                    " Last Name".PadRight(15) +
                    " Age".PadRight(15)
                    );
            Console.WriteLine(
                    "----------".PadRight(15) +
                    " ---------".PadRight(15) +
                    " ------".PadRight(15)
                    );

            foreach (string Student in Students)
            {
                //
                //Split out individual fields.
                //
                string[] StudentInfo = Student.Split(',');
                string FirstName = StudentInfo[0];
                string LastName = StudentInfo[1];
                string Age = StudentInfo[2];



                //
                //Display as table
                //
                Console.WriteLine(
                    FirstName.PadRight(15) +
                    LastName.PadRight(15) +
                    Age.PadRight(15)
                    );

                //Console.WriteLine(Student);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void WriteAllStudents(string DataPath, string[] Students)
        {
            File.WriteAllLines(DataPath, Students);
        }

        static string[] ReadAllStudents(string DataPath)
        {
            string[] Students;

            Students = File.ReadAllLines(DataPath);

            return Students;
        }
    }
}
