using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public  class DisplayUsername
    {
        public static string name = "Hi";
        internal static void PrintUsername()
        {
            Console.WriteLine("Please enter the username");
            string username = Console.ReadLine();

            int val = username.Length;

            Console.WriteLine("The Length " + val);

            if (username.Length > 3)
            {
                Console.WriteLine("Hello " + username + " , How are you?");

                Console.WriteLine("Hello {0} {1} {2}, How are you?", username, "guuu", "tttt");
            }
            else
            {
                Console.WriteLine("Invalid username");
            }
        }

        public static void Display()
        {
            PrintUsername();
        }
    }
}
