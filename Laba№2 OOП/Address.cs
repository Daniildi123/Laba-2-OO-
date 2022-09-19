using System;
using System.IO;

namespace Address
{
    internal class Address
    {
       
        public int Index { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }


        public void DisplayName()
        {
            Console.WriteLine($"Index: {Index} Country : {Country} City : {City} Street : {Street} House : {House} Apartment : {Apartment}");
        }

        static void Main()
        {
            Address address = new Address();
            address.Index = 02000;
            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Ivachkevicha Jaroslava ";
            address.House = "3";
            address.Apartment = "116";
            address.DisplayName();
        }
    }
}