using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("hva heter du?");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Hei " + firstName + " Hva er etternavnet ditt ?");
            string lastName = Console.ReadLine();
           
            string name = firstName + " " + lastName;
            Console.WriteLine("Hei " + name);


            /*
            Console.WriteLine("Hva heter du?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hei " + firstName + " Hva er etternavnet ditt?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hei " + firstName + " " + lastName);
            */




            /* int a = 0;
            int b = 0;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * b);
            Console.ReadLine(); */


           


        }
    }
}
