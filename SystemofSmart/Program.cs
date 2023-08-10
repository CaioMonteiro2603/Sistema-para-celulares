using System;

namespace SystemofSmart
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone("Green", 2023);
            iphone.Apresentation(); 
            Nokia nokia = new Nokia("Germany");
            nokia.Apresentation();


        }
    }
}

