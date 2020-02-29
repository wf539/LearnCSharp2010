using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBookTest
    {
        /// <summary>
        /// Main method begins program execution
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // create a GradeBook object and assign it to myGradeBook
            GradeBook myGradeBook = new GradeBook();

            // Display initial value of Course name
            Console.WriteLine("Initial value of Course name is: '{0}'\n", myGradeBook.strCourseName);

            // Prompt for and input Course name
            Console.WriteLine("Please enter the Course name:");
            myGradeBook.strCourseName = Console.ReadLine(); // read a line of text
            Console.WriteLine(); // write blank line

            // call myGradeBook's DisplayMessage method
            myGradeBook.DisplayMessage();
        } // end Main
    } // end class GradeBookTest
}
