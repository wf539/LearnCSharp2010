using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    /// <summary>
    /// Class declaration with one method
    /// </summary>
    public class GradeBook
    {
        private string stringCourseName;

        public string strCourseName
        {
            get
            {
                return stringCourseName;
            } // end get
            set
            {
                stringCourseName = value;
            } // end set
        }
        /// <summary>
        /// Display a welome message to the Grade Book user
        /// </summary>
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Grade Book for:\n{0}!", strCourseName);
        } // end method display message
    } // end class GradeBook
}
