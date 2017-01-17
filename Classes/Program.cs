using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining the variables
            string name;
            int age;
            string email;

            Console.WriteLine("Hello");

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Please enter your name");
                    continue;
                }
                else
                {
                    break;
                }

            }
            
            
            
            //Loop to make sure age is a number
            while ("pigs" != "flying")
            {
                Console.WriteLine("Thank you {0}, what is your age? (As a number please)", name);
                string stringAge = Console.ReadLine();
                //Leaves loop if age is a number
                if (int.TryParse(stringAge, out age))
                {
                    break;
                }
                //Continues if it isn't.
                else
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }
            }

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is your email? (If none, leave blank)");
                email = Console.ReadLine();
                if (email == "")
                {
                    //Email is allowed to be blank
                    break;
                }
                if (email.Contains("@") && email != "")
                {
                    //Leaves loop if email contains @
                    break;
                }
                else
                {
                    //Email must contain an @ symbol
                    Console.WriteLine("Please enter a valid email address or nothing");
                    continue;
                }
            }

            Person personA = new Person(name, age, email);
            Console.WriteLine("Thank you {0}", personA.ToString());

            
        }
    }
}
