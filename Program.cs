using System;

namespace csharp_book1_chap13_classbasics
{

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

            // --------------------------- Working with Product, Customer, DeliveryService ---------------------------------/
            Product tinkerToys = new Product()
            {
                Title = "Tinker Toys",
                Description = "You can build anything you want",
                Price = 32.49,
                Quantity = 25
            };

            Customer marcus = new Customer()
            {
                FirstName = "Marcus",
                LastName = "Fulbright",
                IsLocal = false
            };

            DeliveryService UPS = new DeliveryService()
            {
                Name = "UPS",
                TransitType = "train"
            };

            // Ship the tinker toys to Marcus using UPS
            tinkerToys.Ship(marcus, UPS);

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

    }
}