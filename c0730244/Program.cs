using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730244
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle dog_and_cat = new car();
            Vehicle bowling = new car();
            Console.WriteLine("how many cars:{0}",Vehicle.howManyCars);
            Console.ReadLine();
        }
    }
    class Vehicle
    {
        public static int howManyCars=0;
        public String Color = "Blue";
    }

    class car : Vehicle
    {
        public String Color = "Red";
        public car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("My color is " + Color);
            Console.ReadLine();
        }
    }

}
