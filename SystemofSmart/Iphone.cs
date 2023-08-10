using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemofSmart
{
    internal class Iphone : Smartphone
    {
        private string Color;
        private int Year; 

        public Iphone(string color, int year) : base("Iphone 14", "Plus", 256)
        {
            Color = color;
            Year = year;
        }

        public void setColor(string Newcolor)
        {
            this.Color = Newcolor;
        }
        public string getColor()
        {
            return this.Color;
        }
        public void setYear(int Newyear)
        {
            this.Year = Newyear;
        }
        public int getYear()
        {
            return this.Year;
        }

        public override void Apresentation()
        {
            Console.WriteLine("Information about the Iphone:\n");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Memory: {Memory}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}\n");
        }
    }
}
