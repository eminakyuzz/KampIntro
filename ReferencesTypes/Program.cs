

using System;

namespace ReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine(sayi1);


            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            //Console.WriteLine(sayilar1[0]);


            Person person = new Person();
            Customer customer = new Customer();
            customer.FirstName = "Emin";
            customer.CreditCardNumber = "4444777788889999";
            Employee emmloyee = new Employee();

            Person customer2 = new Customer();

            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CreditCardNumber);  //customer boxing yapıldı


            PersonManager personManager = new PersonManager();
            personManager.Add(customer2);


        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }
    class PersonManager
    {
        public void Add(Person person)
        {

        }
    }



}
