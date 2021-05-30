using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {
        static void Main(string[] args)
        {
            #region Recursion Notes
            /*
             * Recursion is similar to looping. It allows work to be performed repeatedly until some condition is met.
             * Simple definition of recursion: "recursion is a method that calls on itself until some condition is met"
             * 
             * In the example below, we will create a method that counts down from a value that the user defines. We will then call the recursive method, passing in the user defined parameter. 
             * 
             * In our RecursiveCountdown(), if the value the user passes in is 0, the value gets printed to the console, returned, and the method stops running.
             * 
             * If the value the user passes in is not 0, the RecursiveCountdown() will return the RecursiveCountdown() (calling its action again) but this time with the user passed value being 1 less than its previous value. It's a method calling on itself so that actions can be performed over and over.
             * 
             * Why choose recursion instead of loops?
             * Oftentimes in those loops, they don't keep track of the value of the iterator from the previous operator. Example in for loop: you have the i variable, when at the end of the loop it's reassigned (the value updates)
             * With recursion, we can pass a new value AND pass what was there before
             * Recursion is also sometimes easier to read/clearer. It depends on your project.
             */
            #endregion

            //Step 1: Give the user some instructions 
            Console.WriteLine("Enter a value you would like to count down from: ");

            //Step 2: Allow the user to type and we will parse their input into an int which will be the parameter/argument required for our RecursiveCountdown()
            RecursiveCountdown(int.Parse(Console.ReadLine()));
            //See below under Main, created RecursiveCountdown rules there.


        }//end main
        private static int RecursiveCountdown(int value)
        {
            //If the user passed in a value that is equal to 0
            if (value == 0)
            {
                //Write out the value to the screen
                Console.WriteLine("Value is finally {0}", value);
                //return the value to the method and exit
                return value;
            }//end if
            else
            {
                //You will fall into the else if the value is NOT equal to 0.
                //Write out to the screen the value 
                Console.WriteLine("RecursiveCountdown() is called and the current value is {0}", value);
                //Return the RecursiveCountdown() to itself and subtract 1 from the past value.
                return RecursiveCountdown(value - 1); //We continue to call on this method as long as the value passed in is not equal to 0. When the value IS equal to 0, we stop calling on the method. Here, we're just going to return the int.
            }//end else
        }//end RecursiveCountdown()

        /*
         * Notes from additional Recursion video ("What on earth is recursion - computerphile)
         * factorial(n) = n * factorial(n - 1) - just relabeling the n's, endless succession
         * when you hit factorial(1) = 1. This is the way out
         * 
         * factorial(4) = 4 * 3 * 2 * 1 = 24
         * With recursion, will need a stack
         * Or you can do it iteratively 
         * 
         * With recursion, the incoming argument is 1, then answer is 1.
         * Else, return n*factorial(n-1) - so the thing that is 1 less is passed through next (so if it's 4, 3 is then passed in. Then 2 is passed in. Then 1 = 1. 
         * 
         * There isn't just one "n". Recursion wouldn't work if there were only one "n".
         * 
         * The main program is to say "I want factorial 4". For it to work correctly, you put on another stack frame and say "That one is going to deliver back the answer of factorial 4". But factorial 4 says I can't do that until I know what factorial 3 is. So another stack frame for factorial 3. Repeat with 2. Then we're down to 1. Factorial 2 is saying "I am 2 times whatever factorial 1 is". Factorial 3 is saying "I am 3 times whatever factorial 2 is". Factorial 4 is saying "I am 4 times whatever factorial 3 is"... = 24.
         * Each one of these stack frames is holding onto a different value of n. 
         */
    }//end class
}//end namespace
