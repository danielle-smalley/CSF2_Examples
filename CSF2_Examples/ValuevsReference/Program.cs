using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuevsReference
{
    class Program
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



        }//end main
    }//end class
}//namespace 
