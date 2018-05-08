using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Modle = "Hatchback 302";
            car1.Make = "Toyota";

            Car car2 = new Car();
            car2.Modle = "Sport 707";
            car2.Make = "Mini";

            Car car3 = new Car();
            car3.Modle = "Hybrid 254";
            car3.Modle = "Nissan";

            Car car4 = new Car();
            car4.Modle = "Golf Turbo 208";
            car4.Make = "VW";

            Book b1 = new Book();
            b1.Author = "J.K Rolling";
            b1.Title = "Harry Potter & The Chamber of Secrets";
            b1.ISBN = "0-000-0000-0";

            Book b2 = new Book();
            b2.Author = "R.R Tolkin";
            b2.Title = "Lord Of The Rings - Fellow Ship Of The Ring";
            b2.ISBN = "1-123-7654-9";

            Book b3 = new Book();
            b3.Author = "Terry Prachit";
            b3.Title = "Disc World";
            b3.ISBN = "9-678-1234-5";


            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            myList.Add(car3);
            myList.Add(car4);
            myList.Add(b1);
            */

            /* //Object initializers
             Car car1 = new Car() { Make = "OldsMobiel", Modle = "Cutless Supream" };
             Car car2 = new Car() { Make = "Hobo on Wheels", Modle = "HOBO MK1" };
             Car car3 = new Car() { Make = "BatMobiel", Modle = "Unkown" };
             */

            //Collection Initilisers 
            List<Car> myList = new List<Car>()
            {
            
            }


            Console.ReadLine();
          
        }
    }

    class Car
    {
        public string Make {get; set;}
        public string Modle {get; set;}

    }

    class Book
    {
        public string Author {get; set;}
        public string Title {get; set;}
        public string ISBN {get; set;}
    }

}
