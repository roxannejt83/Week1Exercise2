using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts for user's first name
            Console.WriteLine("What is your first name?");
            //Stores user's input for first name
            string firstname = Console.ReadLine();
            //Prompts for user's last name
            Console.WriteLine("What is your last name?");
            //Stores user's input for last name
            string lastname = Console.ReadLine();
            //Prompts for user's age
            Console.WriteLine("What is your age?");
            //Stores user's input for age
            string age = Console.ReadLine();
            //Prompts for user's favorite color
            Console.WriteLine("What is your favorite color?");
            //Stores user's input for favorite color
            string color = Console.ReadLine();
            //Prints out final output for the user
            Console.WriteLine("Hello " + firstname + " " + lastname + "!  " + "You are " + age + " " + "years old and your favorite color is " + color + ".");
            //Read line of input from user
            Console.Read();
        }
    }
}
