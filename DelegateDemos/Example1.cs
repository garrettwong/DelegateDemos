using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public class Example1 : IExample
    {

        // Declares a delegate for a method that takes in an int and returns a String.
        public delegate String MethodDelegate(int myInt);

        // Defines some methods to which the delegate can point.
        public class SampleClass
        {

            // Defines an instance method.
            public string myStringMethod(int myInt)
            {
                if (myInt > 0)
                    return ("positive");
                if (myInt < 0)
                    return ("negative");
                return ("zero");
            }

            // Defines a static method.
            public static string mySignMethod(int myInt)
            {
                if (myInt > 0)
                    return ("+");
                if (myInt < 0)
                    return ("-");
                return ("");
            }
        }
        public void Run()
        {
            // Creates one delegate for each method. For the instance method, an
            // instance (mySC) must be supplied. For the static method, use the
            // class name.
            SampleClass mySC = new SampleClass();
            MethodDelegate myD1 = new MethodDelegate(mySC.myStringMethod);
            MethodDelegate myD2 = new MethodDelegate(SampleClass.mySignMethod);

            // Invokes the delegates.
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, myD1(5), myD2(5));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, myD1(-3), myD2(-3));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, myD1(0), myD2(0));
        }
    }
}
