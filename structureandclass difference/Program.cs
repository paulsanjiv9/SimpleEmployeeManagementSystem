using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//this program shows the difference between class and structure
namespace structureandclass_difference
{
    class theclass
    {
        public int x;
    }
    struct thestruct
    {
        public int x;
    }
    class Program
    {
        public static void classtaker(theclass c)
        {
            c.x = 5;
        }
        public static void structuretaker(thestruct s)
        {
            s.x = 5;
        }
        static void Main(string[] args)
        {
            theclass tc = new theclass();
            theclass tc2 = new theclass();

            thestruct ts = new thestruct();
            thestruct ts2 = new thestruct();
           Console.WriteLine("comparing  two instances of class"+ tc.Equals(tc2));
           Console.WriteLine("comparing two instances of structure"+ts.Equals(ts2));
            ts.Equals(ts2);
            tc.x = 1;
            ts.x = 1;
            classtaker(tc);
            structuretaker(ts);
            Console.WriteLine("the class instance value is"+tc.x);
            Console.WriteLine("the structure ts.x value is" + ts.x);
           
            Console.WriteLine("------------------string----------");
            string ram = "subham";
            string shyam = "subham";
           Console.WriteLine( ram.Equals(shyam));
           Console.WriteLine(ram.CompareTo(shyam));
           ram = shyam;
           Console.WriteLine(ram.Equals(shyam));
            


        }
    }
}
