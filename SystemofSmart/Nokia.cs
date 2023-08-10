using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemofSmart
{
    internal class Nokia : Smartphone 
    {
        private string CountryFabrication;

        public Nokia(string countryFabrication) : base("Old Nokya", "Thirty-two", 10)
        {
            CountryFabrication = countryFabrication;
        }

        public void setCountry(string Newcountry)
        {
            this.CountryFabrication = Newcountry;
        }
        public string getCountry()
        {
            return this.CountryFabrication;
        }

        public override void Apresentation()
        {
            Console.WriteLine("Information about the Nokia:\n");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Memory: {Memory}");
            Console.WriteLine($"Country of fabrication: {CountryFabrication}"); 
        }
    }
}
