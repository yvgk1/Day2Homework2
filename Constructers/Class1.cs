using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
     class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { ID = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.ID = 3;
            
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);

        }

    }

    class Customer
    {
        public Customer()
        {
            
        }
        //default constructor
        public Customer(int id ,string firstname,string lastname,string city)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
