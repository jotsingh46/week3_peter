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
            var dog_and_cat = new car();
        }
    }
    class Vehicle
    {
        public String Color = "Blue";
    }

    class car : Vehicle
    {
        public String Color = "Red";
        public car()
        {
            Console.WriteLine("My color is " + Color);
            Console.ReadLine();
        }
    }

}
