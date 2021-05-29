using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class TryCatchLab
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lab: Try Catch Practice");
            //MINILAB
            //Prompt the user for the date they were born.
            //Get year, month, and day separately as ints
            //Then use the DateTime constructor to make the date and display their birthday using some formatting.
            //After you have it working, add a try/catch block for dangerous code. 

            //Prompt the user for the date they were born. Get year, month, and day separately as ints:

            Console.WriteLine("Enter your birthday, following the steps below: ");
            try
            {
                Console.WriteLine("Please enter the month you were born in as a number (Example: May = 05): ");
                int userMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the day of the month you were born on, as two digits (Example: the 2nd = 02): ");
                int userDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the full year you were born (Example: 1991): ");
                int userYear = Convert.ToInt32(Console.ReadLine());

                DateTime userBirthday = new DateTime(userYear, userMonth, userDay);
                Console.WriteLine("Here is your birthday: {0:D} !", userBirthday);
            }//end try 

            catch
            {
                Console.WriteLine("Please enter a two digit month, two digit day, and 4 digit year.");
            }//end catch 

        }//end main
    }//end class
}//end namespace
