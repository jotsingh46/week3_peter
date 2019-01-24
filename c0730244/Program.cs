using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730244
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if(rating == 0)
            {
                Console.WriteLine("Promoted to Level 1"); 
            }
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }
            
        }
        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle dog_and_cat = new car();
            //Vehicle bowling = new car();
            //Console.WriteLine("how many cars:{0}",Vehicle.howManyCars);
            //Console.ReadLine();

            //Book myBook = new Book();
            //myBook.SetTitle("A separate peace");
            //Console.WriteLine(myBook.GetTitle());
            //Console.ReadLine();
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

    class BookCollection
    {

    }

    class Book : BookCollection
    {
        private String Title;
        public void SetTitle(String aTitle) { this.Title = aTitle; }
        public String GetTitle() { return this.Title; }
    }
}
