using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Exception Handling");
            //An exception is when program is unable to run your application, there's an error. Error messages will mention "stack trace", class names, line numbers, "Unhandled Exception: System.FormatException" etc. We want to make sure users don't see these errors.
            //The try/catch is a structure that is intended to be used when you want to "try" to run potentially dangerous code and "catch" an exception if it occurs.

            //ask the user for a number
            Console.Write("Please enter a number: ");
            // int userNumber = int.Parse(Console.ReadLine()); //will be problematic if user doesn't enter number
            // Console.WriteLine("100 divided by your number is {0}", 100/userNumber); 
            //The code above is potentially dangerous as the Parse() attempts to turn their string into an int. If they (user) typed text, a symbol, or an excessively large or small number, the application will crash.

            //TRY CATCH for "dangerous code"
            //It does reduce performance, but it is often worth it for targeted parts of your code. Targeted being the keyword!

            //Different ways to crash a program:
            //Format Exception - attempting to parse a value into a variable of a different datatype
            //DivideByZero Exception - dividing by zero, not allowed
            //Overflow Exception - number is too large or too small for its datatype container 

            #region First, most simple way to do a try catch
            //try
            //{
            //    int userNumber = int.Parse(Console.ReadLine()); //will be problematic if user doesn't enter number
            //    Console.WriteLine("100 divided by your number is {0}", 100 / userNumber);
            //}//end try 

            //catch
            //{
            //    //try to do the dangerous code above and if it doesn't work, catch the problem and do something else here
            //    Console.WriteLine("An error has occurred. \a"); //remember \a plays an alert noise
            //}//end catch 

            #endregion

            #region A Try Catch for Specific Exceptions
            try
            {
                int userNumber = int.Parse(Console.ReadLine()); //will be problematic if user doesn't enter number
                Console.WriteLine("100 divided by your number is {0}", 100 / userNumber);
            }//end try 
            catch (DivideByZeroException) //this is an exception built into the .Net framework
            {
                //if there is a divide by 0 exception, when we try the potentially dangerous code this will run instead.
                Console.WriteLine("Can't divide by zero...Only Harry Potter can do that.");
            }//end catch
            catch (OverflowException) //another exception built into the .Net framwork - when a number is too large/too small
            {
                Console.WriteLine("Please enter a number between -2 billion and 2 billion, not including 0.");
            }//end catch
            catch (Exception ex) //this is a generic type of exception
            {
                //The variable ex above is holding the generic exception type of data. This is a complex datatype that we did not construct.
                //ex is a variable of type Exception that has all of the info about the exception that occurred.
                Console.WriteLine("Some error has occurred.\nContact System Admin.\n\nError Info: {0}\nType: {1}", ex.Message, ex.GetType());
            }//end catch
            //These show that the try/catch is like an if statement. Only one of these catch blocks will run, not all of them--whichever is applicable to the input provided by the user. 
            #endregion



        }//end main
    }//end class
}//end namespace
