using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demirog";
            customer.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Derin",LastName="Demirog"



            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}
