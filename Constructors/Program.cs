using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer(1, "emin", "akyuz", "bursa");
            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        public Customer(int id, string firstName,string lastName, string city )
        {
            FirstName = firstName;
            Id = id;
            LastName = lastName;
            City = city;
        }
        public Customer()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
