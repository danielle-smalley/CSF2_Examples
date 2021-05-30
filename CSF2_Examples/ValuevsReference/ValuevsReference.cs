using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuevsReference
{
    class ValuevsReference
    {
        static void Main(string[] args)
        {
            //Intrinsic datatypes - int, long, double, char
            //These are value types. 
            //int x = 7; a point in memory is established. At this point in memory is sorted the actual value of 7 and refer to it as x.
            //int y = x; a new point in memory is created, refer to this new point in memory with y, after running this line of code the value that is stored at the point in memory referred to as x is copied to the point in memory referred to as y. There are now 2 points in memory, each having the valiue of 7.
            //With value types, if we later on change the value of x or y, the 2 points in memory are operating completely independently of each other.
            //x = 9; what happens after this code runs, is that the value for x (7) is replaced with 9. Nothing happens to the value stored in memory referred to as y. 

            //Reference Type variables - arrays, custom datatype classes
            //car is our custome datatype - car1 - a point in memory that we refer to as car1 is created. But we're not storing actual values. We're storing a reference to another point in memory where the values are actually stored. 
            //car2 = car1; Another point in memory is created. I'm referring to it as car2, but it's actually just storing the same location ("reference") to the point in memory where the values are being stored. 
            //If we went back and change the value for car1, it would affect car2.

            Console.WriteLine("Value Types vs Reference Types");

            //Value types

            int num = 42;
            int num2 = 10;
            Console.WriteLine("{0} & {1}", num, num2); //42 & 10

            num2 = num;
            Console.WriteLine("{0} & {1}", num, num2); //42 & 42

            num = 13;
            Console.WriteLine("{0} & {1}", num, num2); //13 & 42 - num2 is still 42 until it's reassigned. The point in memory stores the actual values of 13 & 42

            //Unlike value types such as int, decimal, and bool, classes are reference types and when you assign them to each other, they are both pointing to the same value. 
            //This means if you change one, you change them both.

            //Display the original values
            Actor a1 = new Actor("Tom Cruise"); //added a Class Actor below, below Main and Class
            Actor a2 = new Actor("Keanu Reeves");

            Console.WriteLine("Values BEFORE copying:\nActor a1: {0}\nActor a2: {1}\n", a1.Name, a2.Name);

            //Now going to copy a1 into a2 (change a2's pointer to a1's value)
            a2 = a1;
            Console.WriteLine("Values AFTER copying:\nActor a1: {0}\nActor a2: {1}\n", a1.Name, a2.Name); //both a1 and a2 now show Tom Cruise

            //This causes problems because reference types do not store their own independent values. Instead, they have a pointer to a location in memory where the values are stored. Both of these variables now point to the same location in memory. 

            //This is what we expect to happen from the reassignment of a2 above. However, unexpected results happen if you change the value for one of them.

            a2.Name = "Sean Connery";
            Console.WriteLine("Values AFTER REASSIGNING:\nActor a1: {0}\nActor a2: {1}\n", a1.Name, a2.Name); //both a1 and a2 show Sean Connery now.
            //This is happening because both a1 and a2 are reference types. What is actually stored at the point in memory that we are referring to as a1 and a2 is a location reference to another point in memory where the values are actually being stored. Both a1 and a2 store the location of the same point in memory, so changing one changes both of them. 


        }//end main
    }//end class
    class Actor
    {
        //prop
        public string Name { get; set; }
        //ctor
        public Actor(string name)
        {
            Name = name;
        }//end ctor

    }//end class
}//namespace 
