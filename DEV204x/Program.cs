using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204x
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFirstName;
            string studentLastName;
            DateTime studentBirthdate;
            string studentAddress1;
            string studentAddress2;
            string studentCity;
            string studentState;
            string studentZip;
            string studentCountry;
            int studentAge;
            string profFirstName;
            string profLastName;
            string degreeName = "Bachelor of Science in Information Technology";
            int degreeCredits = 60;
            string programName = "Computer Science";
            string programDegreesOffered = "Barchelor, Masters";
            string programDepartmentHead = "Dude Important";

            studentFirstName = "Lauri";
            studentLastName = "Koobas";

            Console.WriteLine(studentFirstName + " " + studentLastName);
            Console.ReadKey();
        }
    }
}
