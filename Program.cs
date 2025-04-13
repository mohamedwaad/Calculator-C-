using System;

namespace ConsoleApp1
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1 / num2));
        }
    }
}

 
