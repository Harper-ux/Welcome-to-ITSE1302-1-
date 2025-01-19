using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your firstname?"); //name output//
            string firstName = Console.ReadLine(); //user inputs name//
            Console.WriteLine("What is your lastname?"); //user last name output//
            string lastName = Console.ReadLine(); //user inputs lastname//
            Console.WriteLine("What is your favorite color?"); //color output//
            string color = Console.ReadLine(); //user puts in favrotie color//
            Console.WriteLine("How old are you?"); //age out put//
            int age = Convert.ToInt32(Console.ReadLine()); // user puts in age//
            Console.WriteLine("Hello, John Do, your favorite color is red and you are 30");
        }
    }
}
