using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            bmw.brand = "BMW";
            bmw.speed = 500;
            bmw.price = 3500000;
            bmw.color = "white";


            Mercedes mercedes = new Mercedes();

            mercedes.brand = "Mercedes";
            mercedes.speed = 450;
            mercedes.price = 3450000;
            mercedes.color = "black";


            Console.WriteLine(bmw.color);
            Console.WriteLine(mercedes.speed);

        }
    }
  

   

}
