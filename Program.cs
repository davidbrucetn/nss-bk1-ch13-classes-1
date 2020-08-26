using System;

namespace csharp_book1_chap13_classbasics
{

    public class Customer
    {
        // Public Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsLocal { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }

    public class DeliveryService
    {
        /*
          Properties
        */
        public string Name { get; set; }

        public string TransitType { get; set; }

        /*
          Methods
        */
        public void Deliver(Product product, Customer customer)
        {
            Console.WriteLine($"Product delivered by {TransitType} to {customer.FullName}");
        }
    }

    public class Product
    {
        /*
          Properties
        */
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        /*
          Methods
        */
        public void Ship(Customer customer, DeliveryService service)
        {
            if (!customer.IsLocal)
            {
                service.Deliver(this, customer);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // --------------------------- User Defined Types - WRITER  ---------------------------------/
            //The output variable's type is "String",  a built-in type
            string output = "Nashville Software School";

            // Creating the object author which is the instance of the class Writer ->
            //The auther variable's type is "Writer" -- a custom type you defined
            // this becomes Prefix value
            Writer author = new Writer("I do declare: ");
            author.Write(output); //ouputs Prefix + message (output var)

            author.Prefix = "That's right; I said: ";
            author.Write(output);
            // --------------------------- User Defined Types - WRITER  ---------------------------------/

        }

        // --------------------------- User Defined Types - WRITER ---------------------------------/
        public class Writer
        {
            public Writer(string prefix)
            {
                Prefix = prefix;
            }

            public string Prefix { get; set; }

            public void Write(string message)
            {
                Console.WriteLine(Prefix + message);
            }
        }
        // --------------------------- User Defined Types - WRITER ---------------------------------/

        // --------------------------- Public Class - CUSTOMER ---------------------------------/
        public class Customer
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public bool IsLocal { get; set; }

            // Calculated property that has no setter. It is readonly.
            public string FullName
            {
                get
                {
                    return $"{FirstName} {LastName}";
                }
            }
        }
    }
}